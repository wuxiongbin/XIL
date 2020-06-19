using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using wxb.IL;
using UnityEngine.UIElements;
#if USE_HOT
using ILRuntime.Reflection;
using ILRuntime.Runtime.Intepreter;
#endif

namespace wxb
{
    public class ILSerializable : System.Attribute
    {
        // 类型名
        public ILSerializable(string typeName)
        {
            this.typeName = typeName;
        }

        public string typeName;
    }

    public static class BinarySerializable
    {
        static Dictionary<string, ITypeSerialize> AllTypes = new Dictionary<string, ITypeSerialize>();
        static ITypeSerialize unityObjectSerialize = null;

        static Dictionary<FieldInfo, ITypeSerialize> RefTypes = new Dictionary<FieldInfo, ITypeSerialize>();

#if USE_HOT
        static Dictionary<ILRuntimeFieldInfo, ITypeSerialize> FieldInfoTypes = new Dictionary<ILRuntimeFieldInfo, ITypeSerialize>();
#endif

        static void Reg<T>(byte typeFlag, System.Func<T, int> calculateSize, System.Action<T, IStream> writeTo, System.Func<IStream, T> mergeFrom)
        {
            AllTypes.Add(typeof(T).FullName, new Serialize<T>(typeFlag, calculateSize, writeTo, mergeFrom));
        }

        static BinarySerializable()
        {
            Init();
        }

        static void Init()
        {
            unityObjectSerialize = new UnityObjectSerialize();

            // int,uint
            Reg(1, (value)=> { return 4; }, (value, ms) => { ms.WriteInt32(value); }, (ms) => { return ms.ReadInt32(); });
            Reg(2, (value) => { return 4; }, (value, ms) => { ms.WriteUInt32(value); }, (ms) => { return ms.ReadUInt32(); });

            // sbyte,byte
            Reg(3, (value) => { return 1; }, (value, ms) => { ms.WriteSByte(value); }, (ms) => { return ms.ReadSByte(); });
            Reg(4, (value) => { return 1; }, (value, ms) => { ms.WriteByte(value); }, (ms) => { return ms.ReadByte(); });

            // char
            Reg(5, (value) => { return 2; }, (value, ms) => { ms.WriteChar(value); }, (ms) => { return ms.ReadChar(); });

            // long,ulong
            Reg(6, (value) => { return 8; }, (value, ms) => { ms.WriteLong(value); }, (ms) => { return ms.ReadLong(); });
            Reg(7, (value) => { return 8; }, (value, ms) => { ms.WriteULong(value); }, (ms) => { return ms.ReadULong(); });

            // short,ushort
            Reg(8, (value) => { return 2; }, (value, ms) => { ms.WriteShort(value); }, (ms) => { return ms.ReadShort(); });
            Reg(9, (value) => { return 2; }, (value, ms) => { ms.WriteUShort(value); }, (ms) => { return ms.ReadUShort(); });

            // float
            Reg(10, (value) => { return 4; }, (value, ms) => { ms.WriteFloat(value); }, (ms) => { return ms.ReadFloat(); });
            // double
            Reg(11, (value) => { return 8; }, (value, ms) => { ms.WriteDouble(value); }, (ms) => { return ms.ReadDouble(); });

            // DateTime
            Reg(12, (value) => { return 8; }, (value, ms) => { ms.WriteLong(value.Ticks); }, (ms) => { return new DateTime(ms.ReadLong()); });

            // string
            Reg(13, WRStream.ComputeStringSize, (value, ms) => { ms.WriteString(value); }, (ms) => { return ms.ReadString(); });
        }

        public static void Release()
        {
            unityObjectSerialize = null;
#if USE_HOT
            FieldInfoTypes.Clear();
#endif
            RefTypes.Clear();
            AllTypes.Clear();
            Init();
        }

        public static ITypeSerialize GetByType(System.Type type)
        {
            ITypeSerialize ts = null;
            string fullname = type.FullName;
            if (AllTypes.TryGetValue(fullname, out ts))
                return ts;

            if (Help.isType(type, typeof(UnityEngine.Object)))
                ts = unityObjectSerialize;
            else
            {
                if (type.IsArray)
                {
                    ts = new ArrayAnyType(type);
                }
                else if (type.IsGenericType && fullname.StartsWith("System.Collections.Generic.List`1[["))
                {
                    ts = new ListAnyType(type);
                }
                else
                {
                    List<FieldInfo> fieldinfos = Help.GetSerializeField(type);
                    ts = new AnyTypeSerialize(type, fieldinfos);
                }
            }

            AllTypes.Add(fullname, ts);
            return ts;
        }

#if USE_HOT
        static ITypeSerialize GetByType(ILRuntimeFieldInfo fieldInfo)
        {
            if (FieldInfoTypes.TryGetValue(fieldInfo, out var ts))
                return ts;

            var fieldType = fieldInfo.FieldType;
            if (fieldType is ILRuntimeWrapperType)
                fieldType = ((ILRuntimeWrapperType)fieldType).RealType;

            if (Help.isType(fieldType, typeof(UnityEngine.Object)))
            {
                ts = unityObjectSerialize;
            }
            else
            {
                if (fieldType.IsArray)
                {
                    ts = new ArrayAnyType(fieldType);
                }
                else if (Help.isListType(fieldType))
                {
                    ts = new ListAnyType(fieldInfo);
                }
                else
                {
                    ts = GetByType(fieldType);
                }
            }

            FieldInfoTypes.Add(fieldInfo, ts);
            return ts;
        }
#endif

        public static ITypeSerialize GetByFieldInfo(FieldInfo fieldInfo)
        {
#if USE_HOT
            if (fieldInfo is ILRuntimeFieldInfo)
            {
                return GetByType(fieldInfo as ILRuntimeFieldInfo);
            }
#endif
            if (fieldInfo.FieldType == typeof(RefType))
            {
                if (RefTypes.TryGetValue(fieldInfo, out var ts))
                    return ts;

                ts = new RefTypeSerialize(IL.Help.GetTypeByFullName(fieldInfo.GetCustomAttribute<ILSerializable>().typeName));
                RefTypes.Add(fieldInfo, ts);
                return ts;
            }

            return GetByType(fieldInfo.FieldType);
        }

        public static ITypeSerialize GetByInstance(object obj)
        {
            System.Type type = obj.GetType();
#if USE_HOT
            if (obj is ILTypeInstance)
            {
                type = ((ILTypeInstance)obj).Type.ReflectionType;
            }
#endif
            return GetByType(type);
        }

        // 写入流
        public static IStream WriteTo(object obj)
        {
            var stream = new WRStream(512);
            GetByInstance(obj).WriteTo(obj, stream);
            return stream;
        }

        public static void MergeFrom(object obj, IStream stream)
        {
            if (stream == null || stream.ReadSize == 0)
                return;

            var ts = GetByInstance(obj);
            if (ts == null)
                return;

            try
            {
                ts.MergeFrom(ref obj, stream);
            }
            catch (System.Exception ex)
            {
                UnityEngine.Debug.LogException(ex);
            }
        }
    }
}