using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
#if USE_HOT
using ILRuntime.Reflection;
using ILRuntime.Runtime.Intepreter;
#endif

namespace wxb
{
    using wxb.IL;

    public class MonoStream
    {
        public MonoStream(WRStream Stream, List<Object> objs)
        {
            this.Stream = Stream;
            this.objs = objs;
        }

        public WRStream Stream { get; private set; }

        public List<Object> objs { get; private set; }

        public void Save(string key, object p)
        {
            if (p == null)
                return;

//            if (p.GetType().IsArray)
//            {
//                System.Array va = p as System.Array;

//                // 数组
//                JSONArray array = new JSONArray();
//                json.put(key, array);
//                for (int i = 0; i < va.Length; ++i)
//                {
//                    object v = va.GetValue(i);
//                    if (v == null)
//                        array.put("(null)");
//                    else if (v is Object)
//                    {
//                        array.put(i, Add(v as Object));
//                    }
//                    else if (Help.IsBaseType(v.GetType()))
//                    {
//                        // 基础类型
//                        array.put(i, v);
//                    }
//#if USE_HOT
//                    else if (v is ILTypeInstance)
//                    {

//                    }
//#endif
//                    else
//                    {
//                        JSONObject j = new JSONObject();
//                        MonoStream ms = new MonoStream(j, objs);
//                        array.put(i, j);
//                        MonoSerialize.WriteTo(v, ms);
//                    }
//                }
//            }
//            else
//            {
//                if (p is Object)
//                {
//                    json.putOpt(key, Add(p as Object));
//                }
//                else
//                {
//                    json.putOpt(key, p);
//                }
//            }
        }

        public int Add(Object o)
        {
            int pos = objs.IndexOf(o);
            if (pos == -1)
            {
                objs.Add(o);
                pos = objs.Count - 1;
            }

            return pos;
        }
    }

    public interface ITypeSerialize
    {
        void WriteTo(object value, MonoStream ms);
        void MergeFrom(ref object value, MonoStream ms);
        int CalculateSize(object value);
    }

    public static class MonoSerialize
    {
        static Dictionary<string, ITypeSerialize> AllTypes = new Dictionary<string, ITypeSerialize>();

        static MonoSerialize()
        {
            AllTypes.Add(typeof(int).FullName, new IntType());
            AllTypes.Add(typeof(uint).FullName, new UIntType());
            AllTypes.Add(typeof(sbyte).FullName, new sByteType());
            AllTypes.Add(typeof(byte).FullName, new ByteType());
            AllTypes.Add(typeof(char).FullName, new CharType());
            AllTypes.Add(typeof(short).FullName, new ShortType());
            AllTypes.Add(typeof(ushort).FullName, new UShortType());
            AllTypes.Add(typeof(long).FullName, new LongType());
            AllTypes.Add(typeof(ulong).FullName, new ULongType());
            AllTypes.Add(typeof(string).FullName, new StrType());
            AllTypes.Add(typeof(float).FullName, new FloatType());
            AllTypes.Add(typeof(double).FullName, new DoubleType());
            AllTypes.Add(typeof(Object).FullName, new ObjectType());

            AllTypes.Add(typeof(int[]).FullName, new ArrayIntType());
            AllTypes.Add(typeof(uint[]).FullName, new ArrayUIntType());
            AllTypes.Add(typeof(sbyte[]).FullName, new ArraySByteType());
            AllTypes.Add(typeof(byte[]).FullName, new ArrayByteType());            
            AllTypes.Add(typeof(char[]).FullName, new ArrayCharType());
            AllTypes.Add(typeof(short[]).FullName, new ArrayShortType());
            AllTypes.Add(typeof(ushort[]).FullName, new ArrayUShortType());
            AllTypes.Add(typeof(long[]).FullName, new ArrayLongType());
            AllTypes.Add(typeof(ulong[]).FullName, new ArrayULongType());
            AllTypes.Add(typeof(string[]).FullName, new ArrayStrType());
            AllTypes.Add(typeof(float[]).FullName, new ArrayFloatType());
            AllTypes.Add(typeof(double[]).FullName, new ArrayDoubleType());
            AllTypes.Add(typeof(Object[]).FullName, new ArrayObjectType());
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

        public static ITypeSerialize GetByType(System.Type type)
        {
            ITypeSerialize ts = null;
            string fullname = type.FullName;
            if (AllTypes.TryGetValue(fullname, out ts))
                return ts;

            if (Help.isType(type, typeof(Object)))
            {
                return AllTypes[typeof(Object).FullName];
            }

            if (type.IsArray)
            {
                ts = new ArrayAnyType(type);
                AllTypes.Add(fullname, ts);
            }
            else
            {
                List<FieldInfo> fieldinfos = Help.GetSerializeField(type);
                ts = new AnyType(type, fieldinfos);
                AllTypes.Add(fullname, ts);
            }

            return ts;
        }

        public static MonoStream WriteTo(object obj)
        {
            MonoStream ms = new MonoStream(new WRStream(512), new List<Object>());
            GetByInstance(obj).WriteTo(obj, ms);
            return ms;
        }

        public static void MergeFrom(object obj, byte[] bytes, List<Object> objs)
        {
            if (bytes == null || bytes.Length == 0)
                return;

            var ts = GetByInstance(obj);
            if (ts == null)
                return;

            WRStream stream = new WRStream(bytes);
            stream.WritePos = bytes.Length;
            var ms = new MonoStream(stream, objs);
            ts.MergeFrom(ref obj, ms);
        }
    }
}
