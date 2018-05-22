#if USE_HOT
namespace wxb
{
    using System.Reflection;
    using ILRuntime.CLR.Utils;
    using ILRuntime.Runtime.Stack;
    using ILRuntime.Runtime.Enviorment;
    using ILRuntime.Runtime.Intepreter;
    using System.Collections.Generic;

    public static class hotMgr
    {
        public static AppDomain appdomain { get; private set; }

        static RefType refType;

        public static void Init()
        {
#if UNITY_EDITOR
            ResLoad.Set(new EditorResLoad());
#endif

            InitHotModule();

            refType = new RefType("hot.hotApp");
            refType.TryInvokeMethod("Init");
        }

        public const BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

        static public void InitHotModule()
        {
            if (appdomain != null)
                return;

            appdomain = new AppDomain();
            appdomain.RegisterCrossBindingAdaptor(new CoroutineAdapter());

            System.Type clrType = System.Type.GetType("ILRuntime.Runtime.Generated.CLRBindings");
            if (clrType != null)
            {
                clrType.GetMethod("Initialize").Invoke(null, new object[] { appdomain });
            }

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

            clrType = System.Type.GetType("AutoIL.ILRegType");
            if (clrType != null)
            {
                clrType.GetMethod("RegisterFunctionDelegate").Invoke(null, new object[] { appdomain });
                clrType.GetMethod("RegisterDelegateConvertor").Invoke(null, new object[] { appdomain });
                clrType.GetMethod("RegisterMethodDelegate").Invoke(null, new object[] { appdomain });
            }

            IL.Help.Init();
        }

        // 替换哪个接口的哪个函数
        public static bool ReplaceFunction(System.Type type, string funName, MethodInfo info)
        {
            string cflag = "";
            string k = funName;
            if (funName == ".ctor")
            {
                cflag = "_c";
                k = "ctor";
            }

            bool isset = false;
            for (int i = 0; i < 99; ++i)
            {
                string fieldName = string.Format("{0}__Hotfix{1}_{2}", cflag, i, k);
                var field = type.GetField(fieldName, bindingFlags);
                if (field == null)
                    break;

                isset = true;

                if (info != null)
                {
                    field.SetValue(null, new global::IL.DelegateBridge(info));
                    UnityEngine.Debug.LogFormat("ReplaceFunction type:{0} name:{1}", type.Name, funName);
                }
                else
                {
                    field.SetValue(null, null);
                    UnityEngine.Debug.LogFormat("ReplaceFunction type:{0} name:{1} Cannel!", type.Name, funName);
                }
            }

            if (!isset)
            {
                UnityEngine.Debug.LogErrorFormat("ReplaceFunction type:{0} name:{1} not find!", type.Name, funName);
            }

            return isset;
        }

        public static bool ReplaceField(System.Type type, string fieldName, MethodInfo info)
        {
            var field = type.GetField(fieldName, bindingFlags);
            if (field == null)
            {
                UnityEngine.Debug.LogErrorFormat("ReplaceField type:{0} fieldName:{1} not find!", type.Name, fieldName);
                return false;
            }

            field.SetValue(null, new global::IL.DelegateBridge(info));
            UnityEngine.Debug.LogFormat("ReplaceFunction type:{0} fieldName:{1}", type.Name, fieldName);
            return true; ;
        }
    }
}
#endif
