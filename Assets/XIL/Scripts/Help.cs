namespace wxb.IL
{
    using System.Reflection;
#if USE_HOT
    using ILRuntime.Mono.Cecil;
    using ILRuntime.Reflection;
    using ILRuntime.CLR.TypeSystem;
    using ILRuntime.Runtime.Intepreter;
#endif
    using System.Collections.Generic;

    public static class Help
    {
#if !USE_HOT
        static Help()
        {
            Init();
        }
#endif
        // 缓存的类型信息
        static Dictionary<System.Type, CacheType> Caches = new Dictionary<System.Type, CacheType>();

        static void X()
        {
            System.Type v = null;
            // List
            {
                v = typeof(List<object>);
                v = typeof(List<char>);
                v = typeof(List<short>);
                v = typeof(List<ushort>);
                v = typeof(List<int>);
                v = typeof(List<uint>);
                v = typeof(List<long>);
                v = typeof(List<ulong>);
                v = typeof(string);

                v = typeof(object[]);
                v = typeof(char[]);
                v = typeof(short[]);
                v = typeof(ushort[]);
                v = typeof(int[]);
                v = typeof(uint[]);
                v = typeof(long[]);
                v = typeof(ulong[]);
                v = typeof(string[]);
            }

            v = typeof(Dictionary<object, object>);

            // map<char,>
            {
                v = typeof(Dictionary<char, object>);
                v = typeof(Dictionary<char, char>);
                v = typeof(Dictionary<char, short>);
                v = typeof(Dictionary<char, ushort>);
                v = typeof(Dictionary<char, int>);
                v = typeof(Dictionary<char, uint>);
                v = typeof(Dictionary<char, long>);
                v = typeof(Dictionary<char, ulong>);
                v = typeof(Dictionary<char, string>);
                v = typeof(Dictionary<char, bool>);
            }
            // map<short,>
            {
                v = typeof(Dictionary<short, object>);
                v = typeof(Dictionary<short, char>);
                v = typeof(Dictionary<short, short>);
                v = typeof(Dictionary<short, ushort>);
                v = typeof(Dictionary<short, int>);
                v = typeof(Dictionary<short, uint>);
                v = typeof(Dictionary<short, long>);
                v = typeof(Dictionary<short, ulong>);
                v = typeof(Dictionary<short, string>);
                v = typeof(Dictionary<short, bool>);
            }
            // map<ushort,>
            {
                v = typeof(Dictionary<ushort, object>);
                v = typeof(Dictionary<ushort, char>);
                v = typeof(Dictionary<ushort, short>);
                v = typeof(Dictionary<ushort, ushort>);
                v = typeof(Dictionary<ushort, int>);
                v = typeof(Dictionary<ushort, uint>);
                v = typeof(Dictionary<ushort, long>);
                v = typeof(Dictionary<ushort, ulong>);
                v = typeof(Dictionary<ushort, string>);
                v = typeof(Dictionary<ushort, bool>);
            }
            // map<int,>
            {
                v = typeof(Dictionary<int, object>);
                v = typeof(Dictionary<int, char>);
                v = typeof(Dictionary<int, short>);
                v = typeof(Dictionary<int, ushort>);
                v = typeof(Dictionary<int, int>);
                v = typeof(Dictionary<int, uint>);
                v = typeof(Dictionary<int, long>);
                v = typeof(Dictionary<int, ulong>);
                v = typeof(Dictionary<int, string>);
                v = typeof(Dictionary<int, bool>);
            }
            // map<uint,>
            {
                v = typeof(Dictionary<uint, object>);
                v = typeof(Dictionary<uint, char>);
                v = typeof(Dictionary<uint, short>);
                v = typeof(Dictionary<uint, ushort>);
                v = typeof(Dictionary<uint, int>);
                v = typeof(Dictionary<uint, uint>);
                v = typeof(Dictionary<uint, long>);
                v = typeof(Dictionary<uint, ulong>);
                v = typeof(Dictionary<uint, string>);
                v = typeof(Dictionary<uint, bool>);
            }
            // map<long,>
            {
                v = typeof(Dictionary<long, object>);
                v = typeof(Dictionary<long, char>);
                v = typeof(Dictionary<long, short>);
                v = typeof(Dictionary<long, ushort>);
                v = typeof(Dictionary<long, int>);
                v = typeof(Dictionary<long, uint>);
                v = typeof(Dictionary<long, long>);
                v = typeof(Dictionary<long, ulong>);
                v = typeof(Dictionary<long, string>);
                v = typeof(Dictionary<long, bool>);
            }
            // map<ulong,>
            {
                v = typeof(Dictionary<ulong, object>);
                v = typeof(Dictionary<ulong, char>);
                v = typeof(Dictionary<ulong, short>);
                v = typeof(Dictionary<ulong, ushort>);
                v = typeof(Dictionary<ulong, int>);
                v = typeof(Dictionary<ulong, uint>);
                v = typeof(Dictionary<ulong, long>);
                v = typeof(Dictionary<ulong, ulong>);
                v = typeof(Dictionary<ulong, string>);
                v = typeof(Dictionary<ulong, bool>);
            }
            // map<string,>
            {
                v = typeof(Dictionary<string, object>);
                v = typeof(Dictionary<string, char>);
                v = typeof(Dictionary<string, short>);
                v = typeof(Dictionary<string, ushort>);
                v = typeof(Dictionary<string, int>);
                v = typeof(Dictionary<string, uint>);
                v = typeof(Dictionary<string, long>);
                v = typeof(Dictionary<string, ulong>);
                v = typeof(Dictionary<string, string>);
                v = typeof(Dictionary<string, bool>);
            }
        }

        public static CacheType GetOrCreate(System.Type type)
        {
            CacheType st = null;
            if (!Caches.TryGetValue(type, out st))
            {
                st = new CacheType(type);
                Caches.Add(type, st);
            }

            return st;
        }

        public static FieldInfo GetField(System.Type type, string name)
        {
            if (type == null)
                return null;

            return GetOrCreate(type).GetField(name);
        }

        public static MethodInfo GetMethod(System.Type type, string name)
        {
            if (type == null)
                return null;

            return GetOrCreate(type).GetMethod(name);
        }

        public static PropertyInfo GetProperty(System.Type type, string name)
        {
            if (type == null)
                return null;

            return GetOrCreate(type).GetProperty(name);
        }

        static void Reg<T>()
        {
            var type = typeof(T);
            AllTypesByFullName[type.FullName] = type;
        }
        
        static ConstructorInfo GetConstructor(System.Type instanceType, System.Type param)
        {
            return GetOrCreate(instanceType).GetCtor(param);
        }

        public static readonly object[] EmptyObj = new object[0];
        public static readonly object[] OneObj = new object[1];
        public static readonly System.Type[] OneType = new System.Type[1];
        public static readonly System.Type[] EmptyType = new System.Type[0];

        public static object CreateInstaince(System.Type instanceType, object parent)
        {
            object instance = null;
            var cache = GetOrCreate(instanceType);
            ConstructorInfo ctor;

            if (parent != null)
            {
                var type = parent.GetType();

                // 创建实例出来
                ctor = cache.GetCtor(type);
                if (ctor != null)
                {
                    try
                    {
                        OneObj[0] = parent;
                        instance = ctor.Invoke(OneObj);
                    }
                    catch (System.Exception ex)
                    {
                        wxb.L.LogErrorFormat("type:{0}", instanceType.FullName);
                        wxb.L.LogException(ex);
                        throw ex;
                    }
                    finally
                    {
                        OneObj[0] = null;
                    }

                    return instance;
                }
            }

            ctor = cache.GetCtor();
            if (ctor != null)
            {
                try
                {
                    instance = ctor.Invoke(EmptyObj);
                }
                catch (System.Exception ex)
                {
                    wxb.L.LogErrorFormat("type:{0}", instanceType.FullName);
                    wxb.L.LogException(ex);
                    throw ex;
                }
            }
            else
            {
                wxb.L.LogErrorFormat("{0}: not find Constructor!", instanceType.Name);
            }

            return instance;
        }

        public static void Init()
        {
            ReleaseAll();
#if USE_HOT
#if UNITY_EDITOR
            foreach (var itor in DllInitByEditor.appdomain.LoadedTypes)
#else
            foreach (var itor in hotMgr.appdomain.LoadedTypes)
#endif
            {
                AllTypesByFullName.Add(itor.Key, itor.Value.ReflectionType);
            }

            Reg<int>();
            Reg<uint>();
            Reg<sbyte>();
            Reg<byte>();
            Reg<short>();
            Reg<ushort>();
            Reg<long>();
            Reg<ulong>();
            Reg<string>();
            Reg<float>();
            Reg<double>();
#endif
            var assemblies = System.AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
#if UNITY_EDITOR
                if (assembly.FullName.StartsWith("Assembly-CSharp-Editor"))
                    continue;
#endif
                if (assembly.FullName.StartsWith("Assembly-CSharp"))
                {
                    var types = assembly.GetTypes();
                    foreach (var type in types)
                    {
                        if (type.FullName.StartsWith("<"))
                            continue;

                        System.Type t = null;
                        if (AllTypesByFullName.TryGetValue(type.FullName, out t))
                        {
#if USE_HOT
                            if (t != type)
                            {
                                if ((t is ILRuntimeWrapperType) && ((ILRuntimeWrapperType)t).RealType == type)
                                    continue;

                                wxb.L.LogErrorFormat("error:{0}", type.FullName);
                            }
#endif
                            continue;
                        }
                        AllTypesByFullName.Add(type.FullName, type);
                    }
                }
            }

            BaseTypes.Add(typeof(int));
            BaseTypes.Add(typeof(uint));
            BaseTypes.Add(typeof(sbyte));
            BaseTypes.Add(typeof(byte));
            BaseTypes.Add(typeof(short));
            BaseTypes.Add(typeof(ushort));
            BaseTypes.Add(typeof(long));
            BaseTypes.Add(typeof(ulong));
            BaseTypes.Add(typeof(string));
            BaseTypes.Add(typeof(float));
            BaseTypes.Add(typeof(double));

            AllTypesByFullName.Add("int", typeof(int));
            AllTypesByFullName.Add("uint", typeof(uint));
            AllTypesByFullName.Add("sbyte", typeof(sbyte));
            AllTypesByFullName.Add("byte", typeof(byte));
            AllTypesByFullName.Add("short", typeof(short));
            AllTypesByFullName.Add("ushort", typeof(ushort));
            AllTypesByFullName.Add("long", typeof(long));
            AllTypesByFullName.Add("ulong", typeof(ulong));
            AllTypesByFullName.Add("string", typeof(string));
            AllTypesByFullName.Add("float", typeof(float));
            AllTypesByFullName.Add("double", typeof(double));
        }

        public static void ReleaseAll()
        {
            AllTypesByFullName.Clear();
            BaseTypes.Clear();
            Caches.Clear();
#if UNITY_EDITOR
            MonoSerialize.Release();
            if (on_release_all != null)
                on_release_all();
#endif
        }

#if UNITY_EDITOR
        [EditorField]
        public static System.Action on_release_all;

        [EditorField]
        public static bool IsEditorAttribute(MemberInfo minfo)
        {
            if (minfo.GetCustomAttributes(typeof(EditorField), true).Length != 0)
                return true;

            if (minfo is MethodBase)
            {
                var info = minfo as MethodBase;
                if (info.IsSpecialName && (info.Name.StartsWith("get_") || info.Name.StartsWith("set_")))
                {
                    var flag = BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
                    var propertys = info.ReflectedType.GetProperties(flag);
                    string name = info.Name.Substring(4);
                    foreach (var ator in propertys)
                    {
                        if (ator.Name == name)
                        {
                            if (ator.GetCustomAttributes(typeof(EditorField), true).Length != 0)
                                return true;
                        }
                    }
                }
            }

            return false;
        }
#endif
        static HashSet<System.Type> BaseTypes = new HashSet<System.Type>();

        public static bool IsBaseType(System.Type type)
        {
            return BaseTypes.Contains(type);
        }

        static Dictionary<string, System.Type> AllTypesByFullName = new Dictionary<string, System.Type>();

        public static void ForEach(System.Action<System.Type> fun)
        {
            foreach (var ator in AllTypesByFullName)
                fun(ator.Value);
        }

        public static bool TryGetTypeByFullName(string name, out System.Type type)
        {
#if USE_HOT && UNITY_EDITOR
            if (AllTypesByFullName.Count == 0)
            {
                var app = DllInitByEditor.appdomain;
            }
#endif
            if (AllTypesByFullName.TryGetValue(name, out type))
                return true;

            return false;
        }

        public static System.Type GetTypeByFullName(string name)
        {
#if USE_HOT && UNITY_EDITOR
            if (AllTypesByFullName.Count == 0)
            {
                var app = DllInitByEditor.appdomain;
            }
#endif
            System.Type t = null;
            if (AllTypesByFullName.TryGetValue(name, out t))
                return t;

            wxb.L.LogErrorFormat("type:{0} not find!", name);
            return null;
        }

        public static System.Type GetType(string name)
        {
            return GetTypeByFullName(name);
        }

#if UNITY_EDITOR
        [EditorField]
        public static List<System.Type> GetCustomAttributesType(System.Type type)
        {
            List<System.Type> types = new List<System.Type>();
            foreach (var itor in AllTypesByFullName)
            {
                if (itor.Value.IsAbstract)
                    continue;
                if (itor.Value.IsInterface)
                    continue;

                if (HasCustomAttributes(itor.Value, type))
                {
                    types.Add(itor.Value);
                }
            }

            return types;
        }
      
        // 得到继承type的类型
        [EditorField]
        public static List<System.Type> GetBaseType(string baseTypeFullName)
        {
            List<System.Type> types = new List<System.Type>();
            foreach (var itor in AllTypesByFullName)
            {
                if (itor.Value.IsAbstract)
                    continue;
                if (itor.Value.IsInterface)
                    continue;
                if (itor.Value.BaseType != null && itor.Value.BaseType.FullName == baseTypeFullName)
                    types.Add(itor.Value);
            }

            return types;
        }

        [EditorField]
        static bool HasCustomAttributes(System.Type type, System.Type customAtt)
        {
            if (type == null)
                return false;

            bool has = type.GetCustomAttributes(customAtt, true).Length == 0 ? false : true;
#if USE_HOT
            if (has)
                return true;

            ILRuntimeType rt = type as ILRuntimeType;
            if (rt == null)
                return false;

            try
            {
                return HasCustomAttributes(type.BaseType, customAtt);
            }
            catch (System.Exception ex)
            {
                wxb.L.LogException(ex);
                return false;
            }
#else
            return has;
#endif
        }
#endif
        public static List<FieldInfo> GetSerializeField(System.Type type)
        {
            return GetOrCreate(type).GetSerializeField();
        }

        static public void GetSerializeField(System.Type type, List<FieldInfo> fieldinfos)
        {
            if (type.IsGenericType && type.FullName.StartsWith("System.Collections.Generic.List`1[["))
            {
                return;
            }

#if USE_HOT
            bool isILType = false;
            HashSet<string> noPubs = new HashSet<string>();
            HashSet<string> allfields = new HashSet<string>();
            if (type is ILRuntimeType)
            {
                isILType = true;
                type = ((ILRuntimeType)type).ILType.ReflectionType;
                TypeDefinition typeDef = ((ILRuntimeType)type).ILType.TypeDefinition;
                var fields = typeDef.Fields;
                for (int i = 0; i < fields.Count; ++i)
                {
                    var field = fields[i];
                    allfields.Add(field.Name);
                    if (!field.IsPublic)
                        noPubs.Add(field.Name);
                }
            }
#endif
            {
                var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                for (int i = 0; i < fields.Length; ++i)
                {
                    var field = fields[i];
                    var fieldType = field.FieldType;
                    if (field.IsStatic)
                        continue;
#if USE_HOT
                    if (isILType && !allfields.Contains(field.Name))
                        continue;
#endif
                    bool isPublic = field.IsPublic;
                    if (fieldType.BaseType == typeof(System.MulticastDelegate) || fieldType.BaseType == typeof(System.Delegate))
                        continue;
#if USE_HOT
                    if (isPublic)
                    {
                        if (isILType && noPubs.Contains(field.Name))
                            isPublic = false;
                    }
#endif
                    if (isPublic || (field.GetCustomAttributes(typeof(UnityEngine.SerializeField), false).Length != 0))
                    {
                        if (fieldType.IsArray)
                        {
                            var element = fieldType.GetElementType();
                            if (element.IsArray || isListType(element)) // 不支持2D数组类型
                                continue;

                            if (IsBaseType(element) || isType(element, typeof(UnityEngine.Object)))
                            {
                                fieldinfos.Add(field);
                            }
                            else
                            {
                                if (element.IsSerializable)
                                {
                                    fieldinfos.Add(field);
                                }
                            }
                        }
                        else if (BaseTypes.Contains(fieldType))
                        {
                            // 基础类型
                            fieldinfos.Add(field);
                        }
                        else if (isListType(fieldType))
                        {
                            System.Type element = GetElementByList(field);
                            if (element.IsArray || isListType(element)) // 不支持2D数组类型
                                continue;

                            if (IsBaseType(element) || isType(element, typeof(UnityEngine.Object)))
                            {
                                fieldinfos.Add(field);
                            }
                            else
                            {
                                if (element.IsSerializable)
                                {
                                    fieldinfos.Add(field);
                                }
                            }
                        }
                        else
                        {
                            if (
#if USE_HOT
                                (field.FieldType is ILRuntimeType && ((ILRuntimeType)field.FieldType).ILType.TypeDefinition.IsSerializable) ||
#endif
                                field.FieldType.IsSerializable || isType(field.FieldType, typeof(UnityEngine.Object)))
                                fieldinfos.Add(field);
                        }
                    }
                }
            }
        }

        public static bool isListType(System.Type type)
        {
            if (type.IsGenericType && type.FullName.StartsWith("System.Collections.Generic.List`1[["))
                return true;
            return false;
        }

        public static System.Type GetElementByList(FieldInfo fieldInfo)
        {
            var type = fieldInfo.FieldType;
            System.Type element;
#if USE_HOT
            if (type is ILRuntimeWrapperType)
            {
                element = ((ILRuntimeWrapperType)type).RealType.GetGenericArguments()[0];
                string FullName = element.FullName;
                if (element == typeof(ILTypeInstance))
                {
                    ILRuntimeFieldInfo ilField = fieldInfo as ILRuntimeFieldInfo;
                    var vv = ilField.ILFieldType.GenericArguments;
                    return vv[0].Value.ReflectionType;
                }
                else
                {
                    return element;
                }
            }
            else
#endif
            {
                element = type.GetGenericArguments()[0];
            }

            return element;
        }

        public static System.Type GetElementByList(System.Type type)
        {
            System.Type element;
#if USE_HOT
            if (type is ILRuntimeWrapperType)
            {
                element = ((ILRuntimeWrapperType)type).RealType.GetGenericArguments()[0];
                string FullName = element.FullName;
                if (element == typeof(ILTypeInstance))
                {
                    wxb.L.LogError(element.FullName);
                }
            }
            else
#endif
            {
                element = type.GetGenericArguments()[0];
            }

            return element;
        }

        static public List<FieldInfo> GetSerializeField(object obj)
        {
#if USE_HOT
            if (obj is ILTypeInstance)
            {
                ILTypeInstance ili = (ILTypeInstance)obj;
                return GetOrCreate(ili.Type.ReflectionType).GetSerializeField();
            }
#endif
            return GetOrCreate(obj.GetType()).GetSerializeField();
        }

        public static bool isType(System.Type src, System.Type baseType)
        {
            var bt = src.BaseType;
            while (bt != null)
            {
                if (bt == baseType)
                    return true;

                bt = bt.BaseType;
            }

            return false;
        }

        public static object Create(System.Type type)
        {
            if (type.IsArray)
            {
                return System.Array.CreateInstance(type.GetElementType(), 0);
            }
            else if (type.Name == "String")
            {
                return string.Empty;
            }
            else if (type.Name == "Int32")
            {
                return 0;
            }
#if USE_HOT
            else if (type is ILRuntimeType)
            {
                var constructor = GetOrCreate(type).GetCtor();
                if (constructor == null)
                {
                    wxb.L.LogErrorFormat("type:{0} not GetConstructor", type.Name);
                    return null;
                }
                return constructor.Invoke(null);
            }
            else if (type is ILRuntimeWrapperType)
            {
                ILRuntimeWrapperType rwt = type as ILRuntimeWrapperType;
                return Create(rwt.RealType);
            }
            else if (type == typeof(ILTypeInstance))
            {
                L.LogError("type error is ILTypeInstance!");
                return null;
            }
#endif
            else
            {
                return System.Activator.CreateInstance(type);
            }
        }
    }
}

