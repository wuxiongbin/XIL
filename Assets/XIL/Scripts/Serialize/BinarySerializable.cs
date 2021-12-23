using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using wxb.IL;
#if USE_HOT
using ILRuntime.Mono.Cecil;
using ILRuntime.Reflection;
using ILRuntime.Runtime.Intepreter;
#endif

namespace wxb
{
    [System.AttributeUsage(AttributeTargets.Class)]
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
    [System.AttributeUsage(AttributeTargets.Class)]
    public class SmartAttribute : System.Attribute
    {

    }

    // 类型引用
    [System.AttributeUsage(AttributeTargets.Class)]
    public class CSharpAgent : System.Attribute
    {
        public CSharpAgent()
        {

        }
    }

    [System.AttributeUsage(AttributeTargets.Enum)]
    public class EnumString : System.Attribute
    {
        public EnumString()
        {

        }
    }

    public static class BinarySerializable
    {
        static Dictionary<string, ITypeSerialize> AllTypes = new Dictionary<string, ITypeSerialize>();
        static ITypeSerialize unityObjectSerialize = null;
        static ITypeSerialize objectSerialize = null;

        static Dictionary<FieldInfo, ITypeSerialize> RefTypes = new Dictionary<FieldInfo, ITypeSerialize>();

#if USE_HOT
        static Dictionary<ILRuntimeFieldInfo, ITypeSerialize> FieldInfoTypes = new Dictionary<ILRuntimeFieldInfo, ITypeSerialize>();
#endif

        static void Reg<T>(byte typeFlag, System.Action<T, IStream> writeTo, System.Func<IStream, T> mergeFrom, System.Func<T, string> writeToS, System.Func<string, T> mergeFromS) where T : System.IEquatable<T>
        {
            AllTypes.Add(typeof(T).FullName, new Serialize<T>(typeFlag, writeTo, mergeFrom, writeToS, mergeFromS));
        }

        static BinarySerializable()
        {
            Init();
        }

        static void Init()
        {
            unityObjectSerialize = new UnityObjectSerialize();
            objectSerialize = new ObjectSerialize();

            // int,uint
            Reg(TypeFlags.intType, (value, ms) => ms.WriteVarInt32(value), (ms) => ms.ReadVarInt32(), (value) => value.ToString(), (str) => int.Parse(str));
            Reg(TypeFlags.uintType, (value, ms) => ms.WriteVarUInt32(value), (ms) => ms.ReadVarUInt32(), (value) => value.ToString(), (str) => uint.Parse(str));

            // sbyte,byte
            Reg(TypeFlags.sbyteType, (value, ms) => ms.WriteSByte(value), (ms) => ms.ReadSByte(), (value) => value.ToString(), (str) => sbyte.Parse(str));
            Reg(TypeFlags.byteType, (value, ms) => ms.WriteByte(value), (ms) => ms.ReadByte(), (value) => value.ToString(), (str) => byte.Parse(str));

            // char
            Reg(TypeFlags.charType, (value, ms) => ms.WriteChar(value), (ms) => ms.ReadChar(), (value) => value.ToString(), (str) => char.Parse(str));

            // long,ulong
            Reg(TypeFlags.longType, (value, ms) => ms.WriteVarInt64(value), (ms) => ms.ReadVarInt64(), (value) => value.ToString(), (str) => long.Parse(str));
            Reg(TypeFlags.ulongType, (value, ms) => ms.WriteVarUInt64(value), (ms) => ms.ReadVarUInt64(), (value) => value.ToString(), (str) => ulong.Parse(str));

            // short,ushort
            Reg(TypeFlags.shortType, (value, ms) => ms.WriteShort(value), (ms) => ms.ReadShort(), (value) => value.ToString(), (str) => short.Parse(str));
            Reg(TypeFlags.ushortType, (value, ms) => ms.WriteUShort(value), (ms) => ms.ReadUShort(), (value) => value.ToString(), (str) => ushort.Parse(str));

            // float
            Reg(TypeFlags.floatType, (value, ms) => ms.WriteFloat(value), (ms) => ms.ReadFloat(), (value) => value.ToString(), (str) => float.Parse(str));
            // double
            Reg(TypeFlags.doubleType, (value, ms) => ms.WriteDouble(value), (ms) => ms.ReadDouble(), (value) => value.ToString(), (str) => double.Parse(str));

            // DateTime
            Reg(TypeFlags.DateTimeType, (value, ms) => { ms.WriteLong(value.Ticks); }, (ms) => new DateTime(ms.ReadLong()), (value) => value.ToString(), (str) => DateTime.Parse(str));

            // string
            Reg(TypeFlags.stringType, (value, ms) => { ms.WriteString(value); }, (ms) => { return ms.ReadString(); }, (value) => value, (str) => str);

            // bool
            Reg<bool>(TypeFlags.boolType, (value, ms) => ms.WriteByte(value ? (byte)1 : (byte)0), (ms) => ms.ReadByte() == 0 ? false : true, (value) => value.ToString(), (str) => bool.Parse(str));

            Reg<Vector2Int>(TypeFlags.vector2Int, 
                (value, ms) => 
                {
                    ms.WriteInt32(value.x); 
                    ms.WriteInt32(value.y); 
                },                 
                (ms) => 
                {
                    Vector2Int vi = new Vector2Int();
                    vi.x = ms.ReadInt32();
                    vi.y = ms.ReadInt32();

                    return vi;
                },
                (value)=> $"{value.x},{value.y}",
                (value)=> 
                {
                    Vector2Int vi = new Vector2Int();
                    string[] ss = value.Split(',');
                    vi.x = int.Parse(ss[0]);
                    vi.y = int.Parse(ss[1]);

                    return vi;
                });

            Reg<Vector3Int>(TypeFlags.vector3Int,
                (value, ms) =>
                {
                    ms.WriteInt32(value.x);
                    ms.WriteInt32(value.y);
                    ms.WriteInt32(value.z);
                },
                (ms) =>
                {
                    Vector3Int vi = new Vector3Int();
                    vi.x = ms.ReadInt32();
                    vi.y = ms.ReadInt32();
                    vi.z = ms.ReadInt32();
                    
                    return vi;
                },
                (value) => $"{value.x},{value.y},{value.z}",
                (value) =>
                {
                    Vector3Int vi = new Vector3Int();
                    string[] ss = value.Split(',');
                    vi.x = int.Parse(ss[0]);
                    vi.y = int.Parse(ss[1]);
                    vi.z = int.Parse(ss[2]);

                    return vi;
                });
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
            else if (type == typeof(object))
                ts = objectSerialize;
            else
            {
                if (type.IsEnum)
                {
#if USE_HOT
                    if (type is ILRuntimeType)
                    {
                        var atts = type.GetCustomAttributes(typeof(EnumString), false);
                        if (atts != null && atts.Length != 0)
                            ts = new HotEnumStringTypeSerialize(type as ILRuntimeType);
                        else
                            ts = new HotEnumTypeSerialize(type as ILRuntimeType);
                    }
                    else
                    {
#endif
                        var atts = type.GetCustomAttributes(typeof(EnumString), false);
                        if (atts != null && atts.Length != 0)
                            ts = new EnumStringTypeSerialize(type);
                        else
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
                        atts = type.GetCustomAttributes(typeof(CSharpAgent), false);
                        if (atts != null && atts.Length > 0)
                        {
                            ts = new CSharpAgentSerialize(type);
                        }
                        else
                        {
                            List<FieldInfo> fieldinfos = Help.GetSerializeField(type);
                            ts = new AnyTypeSerialize(type, fieldinfos);
                        }
                    }
                }
            }

            AllTypes.Add(fullname, ts);
            return ts;
        }

#if USE_HOT
        public static System.Type GetType(string name)
        {
            if (name.EndsWith("[]"))
                return Help.GetType(name.Substring(0, name.Length - 2)).MakeArrayType();

            return Help.GetType(name);
        }

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
                    var et = GetType(elementType);
                    if (et is ILRuntimeType) // 不是热更当中的类型
                        ts = new HotArrayAnyType(et, isListType, arrayCount);
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

                var att = fieldInfo.GetCustomAttribute<ILSerializable>();
                if (att != null)
                {
                    ts = new RefTypeSerialize(Help.GetTypeByFullName(att.typeName));
                    RefTypes.Add(fieldInfo, ts);
                }
                else
                {
                    return AnyRefTypeSerialize.instance;
                }

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
            var stream = new DefaultStream(512);
            GetByInstance(obj).WriteTo(obj, stream);
            return stream;
        }

        public static IStream WriteTo(object obj, IStream stream)
        {
            GetByInstance(obj).WriteTo(obj, stream);
            return stream;
        }

        public static IStream WriteTo(System.Type type, object obj, IStream stream)
        {
            GetByType(type).WriteTo(obj, stream);
            return stream;
        }

        public static object MergeFrom(System.Type type, object obj, IStream stream)
        {
            if (stream == null || stream.ReadSize == 0)
                return obj;

            try
            {
                var ts = GetByType(type);
                ts.MergeFrom(ref obj, stream);
            }
            catch (System.Exception ex)
            {
                UnityEngine.Debug.LogException(ex);
            }

            return obj;
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

#if !CloseNested // 关闭预置体嵌套支持
        public static void MergeFrom(object obj, Nested.AnyBase ab)
        {
            var its = GetByInstance(obj);
            if (its == null)
                return;

            try
            {
                its.MergeFrom(ref obj, ab);
            }
            catch (System.Exception ex)
            {
                UnityEngine.Debug.LogException(ex);
            }
        }
#endif

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

        public static IStream CreateReaderStream(System.IO.BinaryReader reader)
        {
            var cnt = (int)(reader.BaseStream.Length - reader.BaseStream.Position);
            byte[] bytes = new byte[cnt];
            reader.Read(bytes, 0, cnt);
            var stream = new DefaultStream(bytes);
            stream.WritePos = cnt;
            return stream;
        }

#if UNITY_EDITOR
        //[UnityEditor.MenuItem("Assets/TestBinarySerializable")]
        //static void TestBinarySerializable()
        //{
        //    DG.NetProto.ChatMessageVo cmvo = new DG.NetProto.ChatMessageVo();
        //    cmvo.templateParam.Add("xx", new object[] { "3333", "2222" });
        //    var stream = WriteTo(cmvo);

        //    DG.NetProto.ChatMessageVo nmvo = new DG.NetProto.ChatMessageVo();
        //    MergeFrom(nmvo, stream);

        //    Log.Debug($"{cmvo.templateParam.Count}->{nmvo.templateParam.Count}");
        //}
#endif
    }
}