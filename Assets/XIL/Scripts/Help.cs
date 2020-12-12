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
                string name = itor.Key;
                AllTypesByFullName.Add(name, itor.Value.ReflectionType);
#if USE_HOT
                if (name.IndexOf('/') != -1)
                    AllTypesByFullName.Add(name.Replace('/', '+'), itor.Value.ReflectionType);
#endif
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
            Reg<char>();
#endif
            var assemblies = System.AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
#if UNITY_EDITOR
                string fn = assembly.FullName;
                if (fn.StartsWith("Assembly-CSharp-Editor"))
                    continue;
                if (fn.EndsWith(".Editor.dll"))
                    continue;
#endif
                //if (assembly.FullName.StartsWith("Assembly-CSharp"))
                {
                    var types = assembly.GetTypes();
                    foreach (var type in types)
                    {
                        if (type.FullName.StartsWith("<"))
                            continue;

                        System.Type t = null;
                        if (AllTypesByFullName.TryGetValue(type.FullName, out t))
                        {
//#if USE_HOT
//                            if (t != type)
//                            {
//                                if ((t is ILRuntimeWrapperType) && ((ILRuntimeWrapperType)t).RealType == type)
//                                    continue;

//                                wxb.L.LogErrorFormat("error:{0}", type.FullName);
//                            }
//#endif
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
            BaseTypes.Add(typeof(bool));
            BaseTypes.Add(typeof(char));

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
            AllTypesByFullName.Add("bool", typeof(bool));
            AllTypesByFullName.Add("char", typeof(char));
        }

        public static void ReleaseAll()
        {
            AllTypesByFullName.Clear();
            BaseTypes.Clear();
            Caches.Clear();
#if UNITY_EDITOR
            BinarySerializable.Release();
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

#if USE_HOT
            ILRuntime.Runtime.Enviorment.AppDomain appDomain;
#if UNITY_EDITOR
            appDomain = DllInitByEditor.appdomain;
#else
            appDomain = hotMgr.appdomain;
#endif
            var ilType = appDomain.GetType(name);
            if (ilType == null)
                return false;

            type = GetRealType(ilType.ReflectionType);
            AllTypesByFullName.Add(name, type);
            return true;
#else
            return false;
#endif
        }

        public static void RegType(System.Type type)
        {
#if USE_HOT && UNITY_EDITOR
            if (AllTypesByFullName.Count == 0)
            {
                var app = DllInitByEditor.appdomain;
            }
#endif
            AllTypesByFullName.Add(type.FullName, type);
        }

        public static System.Type GetTypeByFullName(string name)
        {
            if (TryGetTypeByFullName(name, out var type))
                return type;

            L.LogErrorFormat("type:{0} not find!", name);
            return null;
        }

        public static System.Type GetType(string name)
        {
            return GetTypeByFullName(name);
        }

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
        public static List<System.Type> GetBaseType(string baseTypeFullName)
        {
            List<System.Type> types = new List<System.Type>();
            foreach (var itor in AllTypesByFullName)
            {
                if (itor.Value.IsAbstract)
                    continue;
                if (itor.Value.IsInterface)
                    continue;

                var bt = itor.Value.BaseType;
                while (bt != null)
                {
                    if (bt.FullName == baseTypeFullName)
                    {
                        types.Add(itor.Value);
                        break;
                    }
                    else
                        bt = bt.BaseType;
                }
            }

            return types;
        }

        public static System.Type GetInstanceType(object instance)
        {
            var type = instance.GetType();
#if USE_HOT
            if (type == typeof(ILTypeInstance))
                return ((ILTypeInstance)instance).Type.ReflectionType;
#endif
            return type;
        }

        public static bool HasCustomAttributes(System.Type type, System.Type customAtt)
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

        public static List<FieldInfo> GetSerializeField(System.Type type)
        {
            return GetOrCreate(type).GetSerializeField();
        }

        static void GetFieldsByType(System.Type type, List<FieldInfo> fieldInfos)
        {
            GetFieldsByType(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, fieldInfos);
        }

        static void GetFieldsByType(System.Type type, BindingFlags flags, List<FieldInfo> fieldInfos)
        {
            var fields = type.GetFields(flags);
            foreach (var ator in fields)
            {
                //if (!fieldInfos.Contains(ator))
                    fieldInfos.Add(ator);
            }
        }

        public static void GetDictionaryKVType(System.Type type, FieldInfo fieldInfo, out System.Type keyElement, out System.Type valueElement)
        {
#if USE_HOT
            if (fieldInfo is ILRuntimeFieldInfo)
            {
                var ilFieldInfo = (ILRuntimeFieldInfo)fieldInfo;
                var gas = ilFieldInfo.ILFieldType.GenericArguments;
                keyElement = gas[0].Value.ReflectionType;
                valueElement = gas[1].Value.ReflectionType;
                return;
            }
#endif
            var argus = type.GetGenericArguments();
            keyElement = argus[0];
            valueElement = argus[1];
        }

        static public void GetSerializeField(System.Type type, List<FieldInfo> fieldinfos, BindingFlags flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
        {
            if (type.IsArray || type.GetInterface("System.Collections.Generic.IList") != null)
                return;

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
                List<FieldInfo> fields = new List<FieldInfo>();
                GetFieldsByType(type, fields);
                for (int i = 0; i < fields.Count; ++i)
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
                        if (fieldType == typeof(RefType))
                        {
                            var att = field.GetCustomAttribute<wxb.ILSerializable>();
                            if (att != null)
                            {
                                if (!TryGetTypeByFullName(att.typeName, out var refType))
                                {
                                    L.LogErrorFormat("class:{0} field:{1} {2}不存在此类型!", fieldType.DeclaringType.Name, field.Name, att.typeName);
                                    continue;
                                }
                            }

                            fieldinfos.Add(field);
                        }
                        else
                        {
                            if (IsSerializableType(field))
                            {
                                fieldinfos.Add(field);
                            }
                        }
                    }
                }
            }
        }

        static bool IsSerializableType(FieldInfo fieldInfo)
        {
#if USE_HOT
            if (fieldInfo is ILRuntimeFieldInfo)
            {
                return IsSerializableType(fieldInfo.FieldType, fieldInfo);
            }
#endif
            return IsSerializableType(fieldInfo.FieldType, fieldInfo);
        }

        public static System.Type GetRealType(System.Type type)
        {
#if USE_HOT
            if (type is ILRuntimeWrapperType)
            {
                type = ((ILRuntimeWrapperType)type).RealType;
                return type;
            }
            else if (type is ILRuntimeType)
            {

            }
#endif
            return type;
        }

        static bool IsILType(System.Type type)
        {
#if USE_HOT
            type = GetRealType(type);
            if (type is ILRuntimeType || type == typeof(ILTypeInstance))
                return true;

            if (type.IsArray)
                return IsILType(type.GetElementType());
            else if (type.GetInterface("System.Collections.IList") != null)
                return IsILType(type.GetGenericArguments()[0]);
#endif
            return false;
        }

        static bool IsArrayOrList(System.Type type)
        {
            return type.IsArray || (type.GetInterface("System.Collections.IList") != null);
        }

#if USE_HOT
        static bool IsSerializableType(TypeReference typeReference)
        {
            try
            {
                if (typeReference.IsArray)
                {
                    return IsSerializableType(typeReference.GetElementType());
                }
                else if (typeReference is GenericInstanceType && typeReference.FullName.StartsWith("System.Collections.Generic.List`1<"))
                {
                    GenericInstanceType git = typeReference as GenericInstanceType;
                    return IsSerializableType(git.GenericArguments[0]);
                }
                else
                {
                    if (typeReference.Namespace == "UnityEngine")
                        return true;
                   
                    return typeReference.Resolve().IsSerializable;
                }
            }
            catch (System.Exception ex)
            {
                L.LogException(ex);
                return false;
            }
        }
#endif

        // 是否是可序列化的类型
        static bool IsSerializableType(System.Type type, FieldInfo fieldInfo)
        {
            type = GetRealType(type);
            if (IsBaseType(type))
                return true;

            if (type.IsEnum)
                return true;

            if (isType(type, typeof(UnityEngine.Object)))
                return true;

            if (type == typeof(UnityEngine.Vector2) ||
                type == typeof(UnityEngine.Vector3) ||
                type == typeof(UnityEngine.Vector4) ||
                type == typeof(UnityEngine.Vector2Int) ||
                type == typeof(UnityEngine.Vector3Int))
            {
                return true;
            }

            if (type.IsArray)
            {
                var element = GetRealType(type).GetElementType();
#if USE_HOT
                if (fieldInfo is ILRuntimeFieldInfo)
                    return IsSerializableType(((ILRuntimeFieldInfo)fieldInfo).Definition.FieldType);
#endif
                return IsSerializableType(element, null);
            }
            else if (isListType(type))
            {
                var element = type.GetGenericArguments()[0];
#if USE_HOT
                if (fieldInfo is ILRuntimeFieldInfo)
                    return IsSerializableType(((ILRuntimeFieldInfo)fieldInfo).Definition.FieldType);
#endif
                return IsSerializableType(element, null);
            }
            else if (isDictionaryType(type))
            {
                System.Type keyElement;
                System.Type valueElement;
                GetDictionaryKVType(type, fieldInfo, out keyElement, out valueElement);
                if (IsSerializableType(keyElement, null) && IsSerializableType(valueElement, null))
                    return true; // 都是可序列化的，才行

                return false;
            }

            if (!type.IsSerializable)
            {
                return false;
            }

            if (type.IsInterface || type.IsAbstract)
            {
                var atts = type.GetCustomAttributes(typeof(SmartAttribute), false);
                if (atts == null || atts.Length == 0)
                    return false;
            }

            return true;
        }

        public static bool isListType(System.Type type)
        {
            if (type.IsGenericType && type.GetInterface("System.Collections.IList") != null)
                return true;
            return false;
        }

        public static bool isDictionaryType(System.Type type)
        {
            if (type.IsGenericType && type.GetInterface("System.Collections.IDictionary") != null)
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
            if (type.IsInterface || type.IsAbstract)
                return null;

            if (type.IsArray)
            {
                return System.Array.CreateInstance(type.GetElementType(), 0);
            }
            else if (type == typeof(string))
            {
                return string.Empty;
            }
            else if (type == typeof(int))
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

#if USE_HOT
        static System.Collections.IList CreateIList(int arrayCount, int count)
        {
            System.Collections.IList list = null;
            switch (arrayCount)
            {
            case 2:
                list = new List<List<ILTypeInstance>>(count);
                for (int i = 0; i < count; ++i)
                    list.Add(new List<ILTypeInstance>());
                break;

            case 3:
                list = new List<List<List<ILTypeInstance>>>(count);
                for (int i = 0; i < count; ++i)
                    list.Add(new List<List<ILTypeInstance>>());
                break;

            case 4:
                list = new List<List<List<List<ILTypeInstance>>>>(count);
                for (int i = 0; i < count; ++i)
                    list.Add(new List<List<List<ILTypeInstance>>>());
                break;

            case 5:
                list = new List<List<List<List<List<ILTypeInstance>>>>>(count);
                for (int i = 0; i < count; ++i)
                    list.Add(new List<List<List<List<ILTypeInstance>>>>());
                break;

            default:
                UnityEngine.Debug.LogErrorFormat("CreateList {0} type arrayCount:{1}", typeof(ILTypeInstance).Name, arrayCount);
                break;
            }

            return list;
        }

        static System.Collections.IList CreateArray(int arrayCount, int count)
        {
            System.Collections.IList list = null;
            switch (arrayCount)
            {
            case 2:
                list = new ILTypeInstance[count][];
                for (int i = 0; i < count; ++i)
                    list[i] = new ILTypeInstance[0];
                break;

            case 3:
                list = new ILTypeInstance[count][][];
                for (int i = 0; i < count; ++i)
                    list[i] = new ILTypeInstance[0][];
                break;

            case 4:
                list = new ILTypeInstance[count][][][];
                for (int i = 0; i < count; ++i)
                    list[i] = new ILTypeInstance[0][][];
                break;

            case 5:
                list = new ILTypeInstance[count][][][][];
                for (int i = 0; i < count; ++i)
                    list[i] = new ILTypeInstance[0][][][];
                break;
            default:
                UnityEngine.Debug.LogErrorFormat("CreateArray {0} type arrayCount:{1}", typeof(ILTypeInstance).Name, arrayCount);
                break;
            }

            return list;
        }

        public static System.Collections.IList CreateIList(System.Type elementType, int arrayCount, int count)
        {
            if (arrayCount == 1)
            {
                ILRuntimeType ilrt = elementType as ILRuntimeType;
                List<ILTypeInstance> list = new List<ILTypeInstance>(count);
                for (int i = 0; i < count; ++i)
                    list.Add(new ILTypeInstance(ilrt.ILType));
                return list;
            }
            else
            {
                return CreateIList(arrayCount, count);
            }
        }

        public static System.Collections.IList CreateArray(System.Type elementType, int arrayCount, int count)
        {
            if (arrayCount == 1)
            {
                ILRuntimeType ilrt = elementType as ILRuntimeType;
                ILTypeInstance[] list = new ILTypeInstance[count];
                for (int i = 0; i < count; ++i)
                    list[i] = new ILTypeInstance(ilrt.ILType);
                return list;
            }
            else
            {
                return CreateArray(arrayCount, count);
            }
        }
#endif
    }
}

