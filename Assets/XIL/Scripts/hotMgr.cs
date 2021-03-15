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
    using ILRuntime.Mono.Cecil;
    using ILRuntime.Mono.Collections.Generic;
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
                wxb.L.LogErrorFormat("type field:{0}.{1} not find!", type.Name, fieldName);
                return;
            }

            method = IL.Help.GetMethod(type, funName);
            if (method == null)
            {
                wxb.L.LogErrorFormat("type method {0}.{1} not find!", type.Name, funName);
                return;
            }

            var hotMethod = hotfixType.GetMethod(hotfixFunName, wxb.hotMgr.bindingFlags);
            if (hotMethod == null)
            {
                wxb.L.LogErrorFormat("{0}.{1} Replace {2}.{3}", type.Name, funName, hotfixType.Name, hotfixFunName);
                return;
            }

            if (!hotMgr.IsStatic(hotMethod))
            {
                wxb.L.LogErrorFormat("Hotfix type:{0} funName:{1} methodInfo is not static!", hotfixType.Name, hotfixFunName);
                return;
            }

            bridge = new DelegateBridge(hotMethod);
            field.SetValue(null, bridge);
            wxb.L.LogFormat("{0}.{1} Replace {2}.{3}", type.Name, funName, hotfixType.Name, hotfixFunName);
        }

        public void Run(System.Action action)
        {
            field.SetValue(null, null);
            try
            {
                action();
            }
            catch (System.Exception ex)
            {
                wxb.L.LogException(ex);
            }
            field.SetValue(null, bridge);
        }

        public object Run(System.Func<object> fun)
        {
            object value = null;
            field.SetValue(null, null);
            try
            {
                value = fun();
            }
            catch (System.Exception ex)
            {
                wxb.L.LogException(ex);
            }
            field.SetValue(null, bridge);
            return value;
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
                wxb.L.LogException(ex);
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

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Method)]
    public class Platform : System.Attribute
    {
        public Platform(string platform)
        {

        }
    }

    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class ReplaceType : System.Attribute
    {
        // 替换某个类型的某个同名接口
        public ReplaceType(System.Type type)
        {

        }

        // 函数全名
        public ReplaceType(string fullName)
        {

        }
    }

    [System.AttributeUsage(System.AttributeTargets.Method)]
    public class ReplaceFunction : System.Attribute
    {
        // 替换某个类型的某个同名接口
        public ReplaceFunction(System.Type type)
        {

        }

        public ReplaceFunction()
        {

        }

        // fieldNameOrTypeName有可能是类型名，也有可能是字段名
        // 以__Hotfix_开始的为字段名，否则为类型名
        public ReplaceFunction(string fieldNameOrTypeName)
        {

        }

        // 替换某个类型的某个接口
        public ReplaceFunction(System.Type type, string fieldName)
        {

        }

        public ReplaceFunction(string typeName, string fieldName)
        {

        }

        public ReplaceFunction(System.Type type, string fieldName, string hot_hotfix_fieldName)
        {

        }

        public ReplaceFunction(string typeName, string fieldName, string hot_hotfix_fieldName)
        {

        }
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

#if HOT_DEBUG
            if (UnityEngine.Application.isPlaying)
            {
                System.Type debugger_type;
                if (IL.Help.TryGetTypeByFullName("hot.Debugger", out debugger_type))
                {
                    var debugger = new RefType(true, debugger_type);
                    object port = debugger.TryGetField("port");
                    if (port != null)
                    {
                        var ds = appdomain.DebugService;
                        ds.StartDebugService((int)port);
                        object vsWaitTimeoutTime = debugger.TryGetField("vsWaitTimeoutTime");
                        if (vsWaitTimeoutTime != null)
                        {
                            int wt = (int)vsWaitTimeoutTime;
                            if (wt > 0)
                            {
                                L.Log("vsWait begin!");
                                int count = 0;
                                while (!ds.IsDebuggerAttached)
                                {
                                    System.Threading.Thread.Sleep(1000);
                                    ++count;
                                    if (count >= wt)
                                    {
                                        L.Log("vsWait timeout!");
                                        break;
                                    }
                                }
                                L.Log("vsWait end!");
                            }
                        }
                    }
                }
            }
#endif
            refType = new RefType("hot.hotApp");
            refType.TryInvokeMethod("Init");

            AllTypes = new List<IType>();
            foreach (var ator in appdomain.LoadedTypes)
                AllTypes.Add(ator.Value);

            AutoReplace(AllTypes);
            InitByProperty(typeof(AutoInitAndRelease), "Init", AllTypes);
        }

        public const BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

        static System.IO.Stream DllStream;
#if USE_PDB || USE_MDB
        static System.IO.Stream SymbolStream;
#endif
        public static System.IO.MemoryStream CopyStream(System.IO.Stream input)
        {
            try
            {
                if (input == null)
                    return null;

                int length = (int)(input.Length - input.Position);
                byte[] bytes = new byte[length];
                input.Read(bytes, 0, length);
                return new System.IO.MemoryStream(bytes);
            }
            catch (System.Exception ex)
            {
                wxb.L.LogException(ex);
                return null;
            }
        }

        static public void InitHotModule()
        {
            appdomain = new AppDomain();
            try
            {
                DllStream = CopyStream(ResLoad.GetStream("Data/DyncDll.dll"));
                if (DllStream != null)
                {
#if USE_PDB
                    SymbolStream = CopyStream(ResLoad.GetStream("Data/DyncDll.pdb"));
                    appdomain.LoadAssembly(DllStream, SymbolStream, new ILRuntime.Mono.Cecil.Pdb.PdbReaderProvider());
#elif USE_MDB
                    SymbolStream = CopyStream(ResLoad.GetStream("Data/DyncDll.mdb"));
                    appdomain.LoadAssembly(DllStream, SymbolStream, new ILRuntime.Mono.Cecil.Mdb.MdbReaderProvider());
#else
                    appdomain.LoadAssembly(DllStream);
#endif
                }
            }
            catch (System.Exception ex)
            {
                wxb.L.LogException(ex);
            }

            RegDelegate(appdomain);
            IL.Help.Init();
        }

        public static void RegDelegate(AppDomain appdomain)
        {
            appdomain.RegisterCrossBindingAdaptor(new IEnumerableAdapter());

#if UNITY_EDITOR
            System.Type clrType = System.Type.GetType("ILRuntime.Runtime.Generated.CLRBindings");
            if (clrType != null)
                clrType.GetMethod("Initialize").Invoke(null, new object[] { appdomain }); // CLR绑定

            clrType = System.Type.GetType("AutoIL.ILRegType");
            if (clrType != null)
            {
                // 自动委托注册
                clrType.GetMethod("RegisterFunctionDelegate").Invoke(null, new object[] { appdomain });
                clrType.GetMethod("RegisterDelegateConvertor").Invoke(null, new object[] { appdomain });
                clrType.GetMethod("RegisterMethodDelegate").Invoke(null, new object[] { appdomain });
            }
#else
            ILRuntime.Runtime.Generated.CLRBindings.Initialize(appdomain);
            AutoIL.ILRegType.RegisterFunctionDelegate(appdomain);
            AutoIL.ILRegType.RegisterDelegateConvertor(appdomain);
            AutoIL.ILRegType.RegisterMethodDelegate(appdomain);
#endif
            ILRuntime.Runtime.Generated.UnityEngine_Debug_Binding.Register(appdomain);

#if UNITY_ANDROID
            ILRuntime.Runtime.Generated.UnityEngine_Android_Permission_Binding.Register(appdomain);
            ILRuntime.Runtime.Generated.UnityEngine_Android_AndroidDevice_Binding.Register(appdomain);
            ILRuntime.Runtime.Generated.UnityEngine_AndroidInput_Binding.Register(appdomain);
            ILRuntime.Runtime.Generated.UnityEngine_AndroidJavaClass_Binding.Register(appdomain);
            ILRuntime.Runtime.Generated.UnityEngine_AndroidJavaObject_Binding.Register(appdomain);
            ILRuntime.Runtime.Generated.UnityEngine_AndroidJavaProxy_Binding.Register(appdomain);
            ILRuntime.Runtime.Generated.UnityEngine_AndroidJNIHelper_Binding.Register(appdomain);
            ILRuntime.Runtime.Generated.UnityEngine_AndroidJNI_Binding.Register(appdomain);
#endif

            // 热更代码当中使用List<T>类型,注册下
            // List<T>
            {
                appdomain.DelegateManager.RegisterMethodDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance>();
                appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance>();
                appdomain.DelegateManager.RegisterMethodDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance, ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Boolean>();
                appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance, ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>();
                appdomain.DelegateManager.RegisterFunctionDelegate<System.Linq.IGrouping<System.Int32, ILRuntime.Runtime.Intepreter.ILTypeInstance>, System.Linq.IGrouping<System.Int32, ILRuntime.Runtime.Intepreter.ILTypeInstance>>();
                appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<ILRuntime.Runtime.Intepreter.ILTypeInstance>>((act) =>
                {
                    return new System.Comparison<ILRuntime.Runtime.Intepreter.ILTypeInstance>((x, y) =>
                    {
                        return ((System.Func<ILRuntime.Runtime.Intepreter.ILTypeInstance, ILRuntime.Runtime.Intepreter.ILTypeInstance, int>)act)(x, y);
                    });
                });
            }

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction>((act) =>
            {
                return new UnityEngine.Events.UnityAction(() =>
                {
                    ((System.Action)act)();
                });
            });

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
            appdomain.DelegateManager.RegisterFunctionDelegate<bool>();

            appdomain.DelegateManager.RegisterFunctionDelegate<System.IO.BinaryReader>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.IO.BinaryReader, object>();

            appdomain.DelegateManager.RegisterFunctionDelegate<object, object>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.IO.BinaryReader, bool>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.IO.BinaryReader, int>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.IO.BinaryReader, string>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.IO.BinaryReader, long>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.IO.BinaryReader, uint>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILTypeInstance, ILTypeInstance, List<ILTypeInstance>>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Action, System.String, System.Boolean>();
        }

        static System.Type GetType(CustomAttributeArgument caa)
        {
            var value = caa.Value;
            if (value == null)
                return null;

            if (value is string)
            {
                var typeName = value as string;
                if (!string.IsNullOrEmpty(typeName))
                    return GetTypeByName(typeName);
            }
            else if (value is TypeReference)
                return GetTypeByName(((TypeReference)value).FullName);

            return null;
        }

        static bool GetReplaceFunction(Collection<CustomAttribute> CustomAttributes, out System.Type type, out string fieldName, out string hot_fieldName)
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
                    case 0:
                        {
                            type = null;
                            hot_fieldName = null;
                            fieldName = null;
                        }
                        return true;
                    case 1:
                        {
                            var zeroValue = ConstructorArguments[0];
                            var zv = zeroValue.Value;
                            if (zv == null)
                            {
                                type = null;
                                fieldName = null;
                            }
                            else if (zv is string)
                            {
                                string strValue = (string)zv;
                                if (strValue.StartsWith("__Hotfix_"))
                                {
                                    // 字段
                                    fieldName = strValue;
                                    type = null;
                                }
                                else
                                {
                                    type = GetTypeByName(strValue);
                                    fieldName = null;
                                }
                            }
                            else
                            {
                                // 类型
                                type = GetTypeByName(((TypeReference)zeroValue.Value).FullName);
                                fieldName = null;
                            }
                            
                            hot_fieldName = null;
                            return true;
                        }
                    case 2:
                        {
                            var zeroValue = ConstructorArguments[0];
                            var oneValue = ConstructorArguments[1];
                            type = GetType(zeroValue);
                            fieldName = (string)oneValue.Value;
                            hot_fieldName = null;
                            return true;
                        }
                    case 3:
                        {
                            var zeroValue = ConstructorArguments[0];
                            var oneValue = ConstructorArguments[1];
                            var twoValue = ConstructorArguments[2];

                            type = GetType(zeroValue);
                            fieldName = (string)oneValue.Value;
                            hot_fieldName = (string)twoValue.Value;
                            return true;
                        }
                }
            }

            type = null;
            fieldName = null;
            hot_fieldName = null;
            return false;
        }

        static void GetPlatform(Collection<CustomAttribute> CustomAttributes, System.Action<UnityEngine.RuntimePlatform> action)
        {
            CustomAttribute custom;
            for (int i = 0; i < CustomAttributes.Count; ++i)
            {
                custom = CustomAttributes[i];
                if (custom.AttributeType.FullName != "wxb.Platform")
                    continue;

                var param = custom.ConstructorArguments[0];
                UnityEngine.RuntimePlatform platform = (UnityEngine.RuntimePlatform)System.Enum.Parse(typeof(UnityEngine.RuntimePlatform), (string)param.Value);
                action(platform);
            }
        }

        static System.Type GetTypeByName(string fullName)
        {
            if (fullName.IndexOf('/') != -1)
                fullName = fullName.Replace('/', '+');
            return IL.Help.GetTypeByFullName(fullName);
        }

        static System.Type GetReplaceType(Collection<CustomAttribute> CustomAttributes)
        {
            CustomAttribute custom;
            for (int i = 0; i < CustomAttributes.Count; ++i)
            {
                custom = CustomAttributes[i];
                if (custom.AttributeType.FullName != "wxb.ReplaceType")
                    continue;

                var param = custom.ConstructorArguments[0];
                string fullName = null;
                if (param.Value is TypeReference)
                {
                    TypeReference typeRef = param.Value as TypeReference;
                    fullName = typeRef.FullName;
                }
                else
                {
                    fullName = (string)param.Value;
                }

                return GetTypeByName(fullName);
            }

            return null;
        }

        public static bool ReplaceField(System.Type type, string fieldName, MethodInfo info)
        {
            var field = type.GetField(fieldName, bindingFlags);
            if (field == null)
            {
                wxb.L.LogErrorFormat("ReplaceField type:{0} fieldName:{1} not find!", type.Name, fieldName);
                return false;
            }

            if (info == null)
            {
                field.SetValue(null, null);
                wxb.L.LogFormat("ReplaceFunction type:{0} fieldName:{1} Cannel!", type.Name, fieldName);
            }
            else
            {
                if (!IsStatic(info))
                {
                    wxb.L.LogErrorFormat("ReplaceField type:{0} fieldName:{1} methodInfo is not static!", type.Name, fieldName, info.Name);
                    return false;
                }

                field.SetValue(null, new global::IL.DelegateBridge(info));
                wxb.L.LogFormat("ReplaceFunction type:{0} fieldName:{1}", type.Name, fieldName);
            }

            return true;
        }

        public static bool IsStatic(MethodInfo info)
        {
            //#if USE_HOT
            //            if (info is ILRuntime.Reflection.ILRuntimeMethodInfo)
            //            {
            //                var ilMI = info as ILRuntime.Reflection.ILRuntimeMethodInfo;
            //                return ilMI.ILMethod.IsStatic;
            //            }
            //#endif
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

        static UnityEngine.RuntimePlatform GetCurrentPlatform()
        {
#if UNITY_EDITOR
            switch (UnityEditor.EditorUserBuildSettings.activeBuildTarget)
            {
                case UnityEditor.BuildTarget.Android:
                    return UnityEngine.RuntimePlatform.Android;
                case UnityEditor.BuildTarget.iOS:
                    return UnityEngine.RuntimePlatform.IPhonePlayer;
                case UnityEditor.BuildTarget.StandaloneWindows:
                case UnityEditor.BuildTarget.StandaloneWindows64:
                    return UnityEngine.RuntimePlatform.WindowsPlayer;
            }
            return UnityEngine.Application.platform;
#else
            return UnityEngine.Application.platform;
#endif
        }

        // 自动注册
        static void AutoReplace(List<IType> types)
        {
            Dictionary<string, List<MethodInfo>> NameToSorted = new Dictionary<string, List<MethodInfo>>();
            List<UnityEngine.RuntimePlatform> platforms = new List<UnityEngine.RuntimePlatform>();
            UnityEngine.RuntimePlatform rp = GetCurrentPlatform();
            foreach (var ator in types)
            {
                ILType type = ator as ILType;
                if (type == null)
                    continue;

                NameToSorted.Clear();
                var typeDefinition = type.TypeDefinition;
                System.Type rt = GetReplaceType(typeDefinition.CustomAttributes);
                platforms.Clear();
                GetPlatform(typeDefinition.CustomAttributes, (p) => { platforms.Add(p); });
                if (platforms.Count != 0 && !platforms.Contains(rp))
                {
                    wxb.L.LogWarningFormat("platorms:{0} type:{1} not hotfix!", rp, type.Name);
                    continue; // 不属于此平台的
                }
                // 相同函数名排序问题
                foreach (var il in type.GetMethods())
                {
                    var ilMethod = il as ILMethod;
                    if (ilMethod == null)
                        continue;

                    var method = ilMethod.Definition;
                    System.Type methodType;
                    string methodFieldName;
                    string set_hot_field_name;
                    if (!GetReplaceFunction(method.CustomAttributes, out methodType, out methodFieldName, out set_hot_field_name))
                        continue;

                    if (!ilMethod.IsStatic)
                    {
                        wxb.L.LogErrorFormat("type:{0} method:{1} is not static fun!", type.Name, method.Name);
                        continue;
                    }

                    platforms.Clear();
                    GetPlatform(method.CustomAttributes, (p) => { platforms.Add(p); });
                    if (platforms.Count != 0 && !platforms.Contains(rp))
                    {
                        wxb.L.LogWarningFormat("platorms:{0} type:{1}.{2} not hotfix!", rp, type.Name, ilMethod.Name);
                        continue; // 不属于此平台的
                    }

                    System.Type srcType = methodType != null ? methodType : rt;
                    if (srcType == null)
                    {
                        wxb.L.LogErrorFormat("type:{0} method:{1} not set srcType!", type.Name, method.Name);
                        continue;
                    }

                    string fieldName = methodFieldName;
                    if (string.IsNullOrEmpty(fieldName))
                        fieldName = "__Hotfix_" + method.Name;

                    var field = srcType.GetField(fieldName, bindingFlags);
                    if (field == null)
                    {
                        wxb.L.LogErrorFormat("hotType:{0} method:{1} not find srcType:{2}.{3} hot field!", type.Name, method.Name, srcType.FullName, fieldName);
                        continue;
                    }

                    var bridge = new global::IL.DelegateBridge(ilMethod.ReflectionMethodInfo);
                    field.SetValue(null, bridge);
                    Fields.Add(field);
                    wxb.L.LogFormat("type:{0} method:{1} Replace {2}.{3}!", type.Name, method.Name, srcType.Name, fieldName);

                    AutoSetFieldMethodValue(srcType, field, type, fieldName, set_hot_field_name, bridge, NameToSorted);
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
                            wxb.L.LogErrorFormat("hot type:{0} method:{1} not static!", ilType.FullName, name);
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
                    wxb.L.LogException(ex);
                }
            }
        }

        static void AutoSetFieldMethodValue(System.Type srcType, FieldInfo srcFieldInfo, ILType type, string fieldName, string set_hot_field_name, DelegateBridge bridge, Dictionary<string, List<MethodInfo>> NameToSorted)
        {
            FieldDefinition auto_fieldInfo = null;
            if (string.IsNullOrEmpty(set_hot_field_name))
            {
                auto_fieldInfo = FindStaticField(type, fieldName);
                if (auto_fieldInfo == null)
                    return;
            }
            else
            {
                auto_fieldInfo = FindStaticField(type, set_hot_field_name);
                if (auto_fieldInfo == null)
                {
                    L.LogErrorFormat("hotType:{0} fieldName:{1} set_hot_field_name:{2} not find!", type.Name, fieldName, set_hot_field_name);
                    return;
                }
            }

            if (auto_fieldInfo.FieldType.FullName != "wxb.Hotfix")
            {
                L.LogErrorFormat("hotType:{0} fieldName:{1} type:{2} is not wxb.Hotfix!", type.Name, auto_fieldInfo.Name, auto_fieldInfo.FieldType.FullName);
                return;
            }

            var fieldInfo = type.ReflectionType.GetField(auto_fieldInfo.Name, bindingFlags);
            if (fieldInfo == null)
            {
                wxb.L.LogErrorFormat("type:{0} fieldInfo:{1} find but not find clrType fieldInfo!", type.Name, auto_fieldInfo.Name);
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
                    wxb.L.LogErrorFormat("type:{0} method:{1} not find by Field!", type.Name, methodName, fieldName);
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
            if (DllStream != null)
            {
                DllStream.Close();
                DllStream = null;
            }

#if USE_PDB || USE_MDB
            if (SymbolStream != null)
            {
                SymbolStream.Close();
                SymbolStream = null;
            }
#endif
            System.GC.Collect();
        }
    }
}
#endif
