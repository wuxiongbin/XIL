using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using wxb.IL;
using UnityEngine.UIElements;
#if USE_HOT
using ILRuntime.Mono.Cecil;
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

    // 智能类型
    public class SmartAttribute : System.Attribute
    {

    }

    public static class BinarySerializable
    {
        static Dictionary<string, ITypeSerialize> AllTypes = new Dictionary<string, ITypeSerialize>();
        static ITypeSerialize unityObjectSerialize = null;

        static Dictionary<FieldInfo, ITypeSerialize> RefTypes = new Dictionary<FieldInfo, ITypeSerialize>();

#if USE_HOT
        static Dictionary<ILRuntimeFieldInfo, ITypeSerialize> FieldInfoTypes = new Dictionary<ILRuntimeFieldInfo, ITypeSerialize>();
#endif

        static void Reg<T>(byte typeFlag, System.Action<T, IStream> writeTo, System.Func<IStream, T> mergeFrom) where T : System.IEquatable<T>
        {
            AllTypes.Add(typeof(T).FullName, new Serialize<T>(typeFlag, writeTo, mergeFrom));
        }

        static BinarySerializable()
        {
            Init();
        }

        static void Init()
        {
            unityObjectSerialize = new UnityObjectSerialize();

            // int,uint
            Reg(TypeFlags.intType, (value, ms) => { ms.WriteVarInt32(value); }, (ms) => { return ms.ReadVarInt32(); });
            Reg(TypeFlags.uintType, (value, ms) => { ms.WriteVarUInt32(value); }, (ms) => { return ms.ReadVarUInt32(); });

            // sbyte,byte
            Reg(TypeFlags.sbyteType, (value, ms) => { ms.WriteSByte(value); }, (ms) => { return ms.ReadSByte(); });
            Reg(TypeFlags.byteType, (value, ms) => { ms.WriteByte(value); }, (ms) => { return ms.ReadByte(); });

            // char
            Reg(TypeFlags.charType, (value, ms) => { ms.WriteChar(value); }, (ms) => { return ms.ReadChar(); });

            // long,ulong
            Reg(TypeFlags.longType, (value, ms) => { ms.WriteVarInt64(value); }, (ms) => { return ms.ReadVarInt64(); });
            Reg(TypeFlags.ulongType, (value, ms) => { ms.WriteVarUInt64(value); }, (ms) => { return ms.ReadVarUInt64(); });

            // short,ushort
            Reg(TypeFlags.shortType, (value, ms) => { ms.WriteShort(value); }, (ms) => { return ms.ReadShort(); });
            Reg(TypeFlags.ushortType, (value, ms) => { ms.WriteUShort(value); }, (ms) => { return ms.ReadUShort(); });

            // float
            Reg(TypeFlags.floatType, (value, ms) => { ms.WriteFloat(value); }, (ms) => { return ms.ReadFloat(); });
            // double
            Reg(TypeFlags.doubleType, (value, ms) => { ms.WriteDouble(value); }, (ms) => { return ms.ReadDouble(); });

            // DateTime
            Reg(TypeFlags.DateTimeType, (value, ms) => { ms.WriteLong(value.Ticks); }, (ms) => { return new DateTime(ms.ReadLong()); });

            // string
            Reg(TypeFlags.stringType, (value, ms) => { ms.WriteString(value); }, (ms) => { return ms.ReadString(); });

            // bool
            Reg<bool>(TypeFlags.boolType, (value, ms) => { ms.WriteByte(value ? (byte)1 : (byte)0); }, (ms) => { return ms.ReadByte() == 0 ? false : true; });
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
                if (type.IsEnum)
                {
#if USE_HOT
                    if (type is ILRuntimeType)
                    {
                        ts = new HotEnumTypeSerialize((ILRuntimeType)type);
                    }
                    else
                    {
#endif
                        ts = new EnumTypeSerialize(type);
#if USE_HOT
                    }
#endif
                }
                else if (type.IsArray)
                {
                    ts = new ArrayAnyType(type);
                }
                else if (Help.isListType(type))
                {
                    ts = new ListAnyType(type);
                }
                else if (Help.isDictionaryType(type))
                {
                    // map对象
                    ts = new DictionaryType(type, null);
                }
                else
                {
                    var atts = type.GetCustomAttributes(typeof(SmartAttribute), false);
                    if (atts != null && atts.Length > 0)
                    {
                        ts = new SmartSerializer(type, new AnyTypeSerialize(type, Help.GetSerializeField(type)));
                    }
                    else
                    {
                        List<FieldInfo> fieldinfos = Help.GetSerializeField(type);
                        ts = new AnyTypeSerialize(type, fieldinfos);
                    }
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
            else if (Help.isDictionaryType(fieldType))
            {
                ts = new DictionaryType(fieldType, fieldInfo);
            }
            else
            {
                bool isListType = false;
                if (fieldType.IsArray || (isListType = Help.isListType(fieldType)))
                {
                    int arrayCount = 0;
                    string elementType = null;

                    ILRuntimeFieldInfo ilFieldInfo = (ILRuntimeFieldInfo)fieldInfo;
                    GetElementType(ilFieldInfo.Definition.FieldType, ref arrayCount, out elementType);

                    var et = Help.GetType(elementType);
                    if (et is ILRuntimeType) // 不是热更当中的类型
                        ts = new HotArrayAnyType(Help.GetType(elementType), isListType, arrayCount);
                    else
                        ts = GetByType(fieldType);
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
            Type type = Help.GetInstanceType(obj);
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

#if USE_HOT
        public static void GetElementType(TypeReference type, ref int arrayCount, out string elementType)
        {
            if (type.IsArray)
            {
                ++arrayCount;
                ILRuntime.Mono.Cecil.ArrayType arrayType = (ILRuntime.Mono.Cecil.ArrayType)type;
                GetElementType(arrayType.ElementType, ref arrayCount, out elementType);
            }
            else
            {
                if (type.FullName.StartsWith("System.Collections.Generic.List`1"))
                {
                    ++arrayCount;
                    GenericInstanceType git = type as GenericInstanceType;
                    GetElementType(git.GenericArguments[0], ref arrayCount, out elementType);
                }
                else
                {
                    elementType = type.FullName;
                }
            }
        }
#endif

        // 判断两个值是否相等
        public static bool IsEquip(object x, object y)
        {
            if (x == null && y == null)
                return true;
            if (x != null && y != null)
            {
                Type type = Help.GetInstanceType(x);
                if (type != Help.GetInstanceType(y))
                    return false;

                return GetByType(type).IsEquals(x, y);
            }

            return true;
        }
    }
}