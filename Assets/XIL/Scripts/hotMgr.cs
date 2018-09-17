#if USE_HOT
namespace wxb
{
    using System.Reflection;
    using ILRuntime.CLR.Utils;
    using ILRuntime.Runtime.Stack;
    using ILRuntime.Runtime.Enviorment;
    using ILRuntime.Runtime.Intepreter;
    using System.Collections.Generic;
    using ILRuntime.CLR.TypeSystem;
    using Mono.Cecil;
    using Mono.Collections.Generic;
    using ILRuntime.CLR.Method;
    using global::IL;

    public class Hotfix
    {
        public FieldInfo field;
        public MethodInfo method;
        public DelegateBridge bridge;

        public Hotfix(FieldInfo field, MethodInfo method, DelegateBridge bridge)
        {
            this.field = field;
            this.method = method;
            this.bridge = bridge;
        }

        public Hotfix(System.Type type, string name, System.Type hotfixType) : this(type, "__Hotfix_" + name, name, hotfixType, name)
        {

        }

        public Hotfix(System.Type type, string fieldName, string funName, System.Type hotfixType, string hotfixFunName)
        {
            field = type.GetField(fieldName, wxb.hotMgr.bindingFlags);
            if (field == null)
            {
                UnityEngine.Debug.LogErrorFormat("type field:{0}.{1} not find!", type.Name, fieldName);
                return;
            }

            method = type.GetMethod(funName, wxb.hotMgr.bindingFlags);
            if (method == null)
            {
                UnityEngine.Debug.LogErrorFormat("type method {0}.{1} not find!", type.Name, funName);
                return;
            }

            var hotMethod = hotfixType.GetMethod(hotfixFunName, wxb.hotMgr.bindingFlags);
            if (hotMethod == null)
            {
                UnityEngine.Debug.LogErrorFormat("{0}.{1} Replace {2}.{3}", type.Name, funName, hotfixType.Name, hotfixFunName);
                return;
            }

            bridge = new DelegateBridge(hotMethod);
            field.SetValue(null, bridge);
            UnityEngine.Debug.LogFormat("{0}.{1} Replace {2}.{3}", type.Name, funName, hotfixType.Name, hotfixFunName);
        }

        // 执行自身,会把原先热更的字段设置为空，然后通过反射的方式执行自己，再设置回去热更的接口
        public object Invoke(object obj, object[] parameters)
        {
            object r = null;
            field.SetValue(null, null);
            try
            {
                r = method.Invoke(obj, parameters);
            }
            catch (System.Exception ex)
            {
                UnityEngine.Debug.LogException(ex);
            }
            field.SetValue(null, bridge);
            return r;
        }

        public object Invoke(object obj)
        {
            using (var pObjs = new EmptyObjs())
            {
                return Invoke(obj, pObjs.objs);
            }
        }

        public object Invoke(object obj, object p1)
        {
            using (var pObjs = new Objects(p1))
            {
                return Invoke(obj, pObjs.objs);
            }
        }

        public object Invoke(object obj, object p1, object p2)
        {
            using (var pObjs = new Objects(p1, p2))
            {
                return Invoke(obj, pObjs.objs);
            }
        }

        public object Invoke(object obj, object p1, object p2, object p3)
        {
            using (var pObjs = new Objects(p1, p2, p3))
            {
                return Invoke(obj, pObjs.objs);
            }
        }

        public object Invoke(object obj, object p1, object p2, object p3, object p4)
        {
            using (var pObjs = new Objects(p1, p2, p3, p4))
            {
                return Invoke(obj, pObjs.objs);
            }
        }

        public object Invoke(object obj, object p1, object p2, object p3, object p4, object p5)
        {
            using (var pObjs = new Objects(p1, p2, p3, p4, p5))
            {
                return Invoke(obj, pObjs.objs);
            }
        }

        public object Invoke(object obj, object p1, object p2, object p3, object p4, object p5, object p6)
        {
            using (var pObjs = new Objects(p1, p2, p3, p4, p5, p6))
            {
                return Invoke(obj, pObjs.objs);
            }
        }

        public object Invoke(object obj, object p1, object p2, object p3, object p4, object p5, object p6, object p7)
        {
            using (var pObjs = new Objects(p1, p2, p3, p4, p5, p6, p7))
            {
                return Invoke(obj, pObjs.objs);
            }
        }

        public object Invoke(object obj, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)
        {
            using (var pObjs = new Objects(p1, p2, p3, p4, p5, p6, p7, p8))
            {
                return Invoke(obj, pObjs.objs);
            }
        }

        public object Invoke(object obj, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9)
        {
            using (var pObjs = new Objects(p1, p2, p3, p4, p5, p6, p7, p8, p9))
            {
                return Invoke(obj, pObjs.objs);
            }
        }

        public object Invoke(object obj, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9, object p10)
        {
            using (var pObjs = new Objects(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10))
            {
                return Invoke(obj, pObjs.objs);
            }
        }

        public void Release()
        {
            if (field != null)
                field.SetValue(null, null);
        }
    }

    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class ReplaceType : System.Attribute
    {
        // 替换某个类型的某个同名接口
        public ReplaceType(System.Type type)
        {
            this.type = type;
        }

        public System.Type type;
    }

    [System.AttributeUsage(System.AttributeTargets.Method)]
    public class ReplaceFunction : System.Attribute
    {
        // 替换某个类型的某个同名接口
        public ReplaceFunction(System.Type type)
        {
            this.type = type;
        }

        public ReplaceFunction()
        {

        }

        public ReplaceFunction(string fieldName)
        {
            this.fieldName = fieldName;
        }

        // 替换某个类型的某个接口
        public ReplaceFunction(System.Type type, string fieldName)
        {
            this.type = type;
            this.fieldName = fieldName;
        }

        public System.Type type;
        public string fieldName;
    }

    // 自动调用初始化接口，定义在某个类的属性，只要此类下有静态的函数Init，会自动调用
    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class AutoInitAndRelease : System.Attribute
    {

    }

    public static class hotMgr
    {
        public static AppDomain appdomain { get; private set; }

        static RefType refType;
        public static RefType RefType { get { return refType; } }

        // 所有的热更当中的类型
        public static List<IType> AllTypes { get; private set; }

        public static void Init(IResLoad resLoad = null)
        {
            if (appdomain != null)
                return;

#if UNITY_EDITOR
            DllInitByEditor.Release();
#endif
            if (resLoad == null)
            {
#if UNITY_EDITOR
                ResLoad.Set(new EditorResLoad());
#endif
            }
            else
            {
                ResLoad.Set(resLoad);
            }

            InitHotModule();

            refType = new RefType("hot.hotApp");
            refType.TryInvokeMethod("Init");

            AllTypes = new List<IType>();
            foreach (var ator in appdomain.LoadedTypes)
                AllTypes.Add(ator.Value);

            AutoReplace(AllTypes);
            InitByProperty(typeof(AutoInitAndRelease), "Init", AllTypes);
        }

        public const BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

        static public void InitHotModule()
        {
            appdomain = new AppDomain();
            appdomain.RegisterCrossBindingAdaptor(new CoroutineAdapter());

#if UNITY_EDITOR
            System.Type clrType = System.Type.GetType("ILRuntime.Runtime.Generated.CLRBindings");
            if (clrType != null)
            {
                clrType.GetMethod("Initialize").Invoke(null, new object[] { appdomain });
            }
#else
            ILRuntime.Runtime.Generated.CLRBindings.Initialize(appdomain);
#endif
            ILRuntime.Runtime.Generated.UnityEngine_Debug_Binding.Register(appdomain);
            try
            {
                using (var fs = ResLoad.GetStream("Data/DyncDll.dll"))
                {
#if USE_PDB
                    using (var p = ResLoad.GetStream("Data/DyncDll.pdb"))
                    {
                        appdomain.LoadAssembly(fs, p, new Mono.Cecil.Pdb.PdbReaderProvider());
                    }
#else
                    appdomain.LoadAssembly(fs);
#endif
                }
            }
            catch (System.Exception ex)
            {
                UnityEngine.Debug.LogException(ex);
            }

            RegDelegate(appdomain);
            IL.Help.Init();
        }

        public static void RegDelegate(AppDomain appdomain)
        {
            // 热更代码当中使用List<T>类型,注册下
            // List<T>
            {
                appdomain.DelegateManager.RegisterMethodDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance>();
                appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance>();

                appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance, ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>();
                appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<ILRuntime.Runtime.Intepreter.ILTypeInstance>>((act) =>
                {
                    return new System.Comparison<ILRuntime.Runtime.Intepreter.ILTypeInstance>((x, y) =>
                    {
                        return ((System.Func<ILRuntime.Runtime.Intepreter.ILTypeInstance, ILRuntime.Runtime.Intepreter.ILTypeInstance, int>)act)(x, y);
                    });
                });
            }

            appdomain.DelegateManager.RegisterMethodDelegate<object>();
            appdomain.DelegateManager.RegisterMethodDelegate<object[]>();
            appdomain.DelegateManager.RegisterMethodDelegate<long>();
            appdomain.DelegateManager.RegisterMethodDelegate<ulong>();
            appdomain.DelegateManager.RegisterMethodDelegate<int>();
            appdomain.DelegateManager.RegisterMethodDelegate<uint>();
            appdomain.DelegateManager.RegisterMethodDelegate<short>();
            appdomain.DelegateManager.RegisterMethodDelegate<ushort>();
            appdomain.DelegateManager.RegisterMethodDelegate<char>();
            appdomain.DelegateManager.RegisterMethodDelegate<string>();
            appdomain.DelegateManager.RegisterMethodDelegate<object, object>();
            appdomain.DelegateManager.RegisterMethodDelegate<int, object>();
            appdomain.DelegateManager.RegisterMethodDelegate<long, object>();
            appdomain.DelegateManager.RegisterMethodDelegate<string, object>();

#if UNITY_EDITOR
            var clrType = System.Type.GetType("AutoIL.ILRegType");
            if (clrType != null)
            {
                clrType.GetMethod("RegisterFunctionDelegate").Invoke(null, new object[] { appdomain });
                clrType.GetMethod("RegisterDelegateConvertor").Invoke(null, new object[] { appdomain });
                clrType.GetMethod("RegisterMethodDelegate").Invoke(null, new object[] { appdomain });
            }
#else
            AutoIL.ILRegType.RegisterFunctionDelegate(appdomain);
            AutoIL.ILRegType.RegisterDelegateConvertor(appdomain);
            AutoIL.ILRegType.RegisterMethodDelegate(appdomain);
#endif
        }

        static ReplaceFunction GetReplaceFunction(Collection<CustomAttribute> CustomAttributes)
        {
            CustomAttribute custom;
            for (int i = 0; i < CustomAttributes.Count; ++i)
            {
                custom = CustomAttributes[i];
                if (custom.AttributeType.FullName != "wxb.ReplaceFunction")
                    continue;

                var ConstructorArguments = custom.ConstructorArguments;
                switch (ConstructorArguments.Count)
                {
                case 0: return new ReplaceFunction();
                case 1:
                    {
                        if (ConstructorArguments[0].Type.FullName == "System.String")
                        {
                            return new ReplaceFunction(ConstructorArguments[0].Value.ToString());
                        }
                        else
                        {
                            return new ReplaceFunction(IL.Help.GetTypeByFullName(((TypeReference)ConstructorArguments[0].Value).FullName));
                        }
                    }
                case 2:
                    return new ReplaceFunction(IL.Help.GetTypeByFullName(((TypeReference)ConstructorArguments[0].Value).FullName),
                        ConstructorArguments[1].Value.ToString());
                }
            }

            return null;
        }

        static ReplaceType GetReplaceType(Collection<CustomAttribute> CustomAttributes)
        {
            CustomAttribute custom;
            for (int i = 0; i < CustomAttributes.Count; ++i)
            {
                custom = CustomAttributes[i];
                if (custom.AttributeType.FullName != "wxb.ReplaceType")
                    continue;

                var param = custom.ConstructorArguments[0];
                TypeReference typeRef = param.Value as TypeReference;
                var fullName = typeRef.FullName;
                if (fullName.IndexOf('/') != -1)
                    fullName = fullName.Replace('/', '+');
                return new ReplaceType(IL.Help.GetTypeByFullName(fullName));
            }

            return null;
        }

        public static bool ReplaceField(System.Type type, string fieldName, MethodInfo info)
        {
            var field = type.GetField(fieldName, bindingFlags);
            if (field == null)
            {
                UnityEngine.Debug.LogErrorFormat("ReplaceField type:{0} fieldName:{1} not find!", type.Name, fieldName);
                return false;
            }

            if (info == null)
            {
                field.SetValue(null, null);
                UnityEngine.Debug.LogFormat("ReplaceFunction type:{0} fieldName:{1} Cannel!", type.Name, fieldName);
            }
            else
            {
                if (!IsStatic(info))
                {
                    UnityEngine.Debug.LogErrorFormat("ReplaceField type:{0} fieldName:{1} methodInfo is not static!", type.Name, fieldName, info.Name);
                    return false;
                }

                field.SetValue(null, new global::IL.DelegateBridge(info));
                UnityEngine.Debug.LogFormat("ReplaceFunction type:{0} fieldName:{1}", type.Name, fieldName);
            }

            return true;
        }

        static bool IsStatic(MethodInfo info)
        {
#if USE_HOT
            if (info is ILRuntime.Reflection.ILRuntimeMethodInfo)
            {
                var ilMI = info as ILRuntime.Reflection.ILRuntimeMethodInfo;
                return ilMI.ILMethod.IsStatic;
            }
#endif
            return info.IsStatic;
        }

        // 直接替换函数，一般用在没有同名函数情况下
        public static bool ReplaceFunc(System.Type type, string name, MethodInfo info)
        {
            return ReplaceField(type, "__Hotfix_" + name, info);
        }

        static FieldDefinition FindStaticField(ILType type, string name)
        {
            var StaticFieldDefinitions = type.StaticFieldDefinitions;
            if (StaticFieldDefinitions == null)
                return null;

            foreach (var ator in StaticFieldDefinitions)
            {
                if (ator.Name == name)
                    return ator;
            }

            return null;
        }

        static string GetKey(MethodInfo method)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(method.ReturnType.FullName);
            sb.Append("(");
            var Parameters = method.GetParameters();
            for (int i = 0; i < Parameters.Length; ++i)
            {
                if (i != 0)
                    sb.Append(",");
                sb.Append(Parameters[i].ParameterType.FullName);
            }
            sb.Append(")");

            return sb.ToString();
        }

        static List<MethodInfo> FindMethodInfo(System.Type type, string name)
        {
            List<MethodInfo> methods = new List<MethodInfo>();
            foreach (var ator in type.GetMethods(bindingFlags))
            {
                if (ator.Name == name)
                    methods.Add(ator);
            }

            methods.Sort((x, y) =>
            {
                if (x == y)
                    return 0;

                var xc = x.GetParameters();
                var yc = y.GetParameters();
                if (xc.Length != yc.Length)
                    return xc.Length.CompareTo(yc.Length);

                string xkey = GetKey(x);
                string ykey = GetKey(y);
                return xkey.CompareTo(ykey);
            });

            return methods;
        }

        // 自动注册
        static void AutoReplace(List<IType> types)
        {
            Dictionary<string, List<MethodInfo>> NameToSorted = new Dictionary<string, List<MethodInfo>>();
            foreach (var ator in types)
            {
                ILType type = ator as ILType;
                if (type == null)
                    continue;

                NameToSorted.Clear();
                var typeDefinition = type.TypeDefinition;
                ReplaceType replaceType = GetReplaceType(typeDefinition.CustomAttributes);
                System.Type rt = replaceType == null ? null : replaceType.type;
                // 相同函数名排序问题
                foreach (var il in type.GetMethods())
                {
                    var ilMethod = il as ILMethod;
                    if (ilMethod == null)
                        continue;

                    var method = ilMethod.Definition;
                    ReplaceFunction replaceFunction = GetReplaceFunction(method.CustomAttributes);
                    if (replaceFunction == null)
                        continue;

                    if (!ilMethod.IsStatic)
                    {
                        UnityEngine.Debug.LogErrorFormat("type:{0} method:{1} is not static fun!", type.Name, method.Name);
                        continue;
                    }

                    System.Type srcType = replaceFunction.type != null ? replaceFunction.type : rt;
                    if (srcType == null)
                    {
                        UnityEngine.Debug.LogErrorFormat("type:{0} method:{1} not set srcType!", type.Name, method.Name);
                        continue;
                    }

                    string fieldName = replaceFunction.fieldName;
                    if (string.IsNullOrEmpty(fieldName))
                        fieldName = "__Hotfix_" + method.Name;

                    var field = srcType.GetField(fieldName, bindingFlags);
                    if (field == null)
                    {
                        UnityEngine.Debug.LogErrorFormat("hotType:{0} method:{1} not find srcType:{2}.{3} hot field!", type.Name, method.Name, srcType.FullName, fieldName);
                        continue;
                    }

                    var bridge = new global::IL.DelegateBridge(ilMethod.ReflectionMethodInfo);
                    field.SetValue(null, bridge);
                    Fields.Add(field);
                    UnityEngine.Debug.LogFormat("type:{0} method:{1} Replace {2}.{3}!", type.Name, method.Name, srcType.Name, fieldName);

                    AutoSetFieldMethodValue(srcType, field, type, fieldName, bridge, NameToSorted);
                }
            }
        }

        public static void FindAttribute(System.Type attType, System.Action<System.Type> on)
        {
            string autoAttName = attType.FullName;
            List<IMethod> calls = new List<IMethod>();
            foreach (var itor in AllTypes)
            {
                ILType ilType = itor as ILType;
                if (ilType == null)
                    continue;

                TypeDefinition td = ilType.TypeDefinition;
                foreach (var att in td.CustomAttributes)
                {
                    if (att.AttributeType.FullName == autoAttName)
                    {
                        on(ilType.ReflectionType);
                    }
                }
            }
        }

        static void InitByProperty(System.Type attType, string name, List<IType> types)
        {
            string autoAttName = attType.FullName;
            List<IMethod> calls = new List<IMethod>();
            foreach (var itor in types)
            {
                ILType ilType = itor as ILType;
                if (ilType == null)
                    continue;

                TypeDefinition td = ilType.TypeDefinition;
                foreach (var att in td.CustomAttributes)
                {
                    if (att.AttributeType.FullName == autoAttName)
                    {
                        var type = ilType.TypeForCLR;
                        var method = ilType.GetMethod(name, 0);
                        if (method == null)
                            continue;
                        if (!method.IsStatic)
                        {
                            UnityEngine.Debug.LogErrorFormat("hot type:{0} method:{1} not static!", ilType.FullName, name);
                            continue;
                        }
                        calls.Add(method);
                        break;
                    }
                }
            }

            for (int i = 0; i < calls.Count; ++i)
            {
                try
                {
                    appdomain.Invoke(calls[i], null);
                }
                catch (System.Exception ex)
                {
                    UnityEngine.Debug.LogException(ex);
                }
            }
        }

        static void AutoSetFieldMethodValue(System.Type srcType, FieldInfo srcFieldInfo, ILType type, string fieldName, DelegateBridge bridge, Dictionary<string, List<MethodInfo>> NameToSorted)
        {
            var auto_fieldInfo = FindStaticField(type, fieldName);
            if (auto_fieldInfo == null || auto_fieldInfo.FieldType.FullName != "wxb.Hotfix")
                return;

            var fieldInfo = type.ReflectionType.GetField(fieldName, bindingFlags);
            if (fieldInfo == null)
            {
                UnityEngine.Debug.LogErrorFormat("type:{0} fieldInfo:{1} find but not find clrType fieldInfo!", type.Name, fieldName);
                return;
            }

            MethodInfo srcMethodInfo = null;
            {
                string methodName = fieldName.Substring(9);
                int last = methodName.LastIndexOf('_');
                if (last == -1)
                {
                    srcMethodInfo = IL.Help.GetMethod(srcType, methodName);
                }
                else
                {
                    int value = 0;
                    bool isInt = int.TryParse(methodName.Substring(last + 1), out value);
                    if (!isInt)
                    {
                        srcMethodInfo = IL.Help.GetMethod(srcType, methodName);
                    }
                    else
                    {
                        methodName = methodName.Substring(0, last);
                        List<MethodInfo> methods = null;
                        if (!NameToSorted.TryGetValue(methodName, out methods))
                        {
                            methods = FindMethodInfo(srcType, methodName);
                            NameToSorted.Add(methodName, methods);
                        }

                        if (value < methods.Count && value >= 0)
                        {
                            srcMethodInfo = methods[value];
                        }
                    }
                }

                if (srcMethodInfo == null)
                {
                    UnityEngine.Debug.LogErrorFormat("type:{0} method:{1} not find by Field!", type.Name, methodName, fieldName);
                    return;
                }
            }

            Hotfix hotfix = new Hotfix(srcFieldInfo, srcMethodInfo, bridge);
            fieldInfo.SetValue(null, hotfix);
        }

        static HashSet<FieldInfo> Fields = new HashSet<FieldInfo>();

        // 释放所有热更模块
        public static void ReleaseAll()
        {
            if (appdomain == null)
                return;

            ResLoad.Set(null);
            refType.TryInvokeMethod("ReleaseAll");
            //var types = new Dictionary<string, IType>(appdomain.LoadedTypes);
            InitByProperty(typeof(AutoInitAndRelease), "Release", AllTypes);

            foreach (var ator in Fields)
                ator.SetValue(null, null);
            Fields.Clear();

            IL.Help.ReleaseAll();
            AllTypes.Clear();
            AllTypes = null;
            refType = null;
            appdomain = null;
            System.GC.Collect();
        }

#if COM_DEBUG && USE_HOT
        // 重加载热更脚本
#if UNITY_EDITOR
        [EditorField]
#endif
        public static System.Collections.IEnumerator Reload()
        {
            ReleaseAll();
            yield return 0;

            System.GC.Collect();
            yield return UnityEngine.Resources.UnloadUnusedAssets();
            yield return 0;
            System.GC.Collect();

            // 重加载资源包
            yield return com.eb.miku.game.GameLogo.ReloadDebugPack();

            // 重新初始化脚本系统
            Init();
        }
#endif
    }
}
#endif
