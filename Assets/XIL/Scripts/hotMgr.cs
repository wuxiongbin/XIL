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
            AutoReplace();
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
                return new ReplaceType(IL.Help.GetTypeByFullName(typeRef.FullName));
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
                field.SetValue(null, new global::IL.DelegateBridge(info));
                UnityEngine.Debug.LogFormat("ReplaceFunction type:{0} fieldName:{1}", type.Name, fieldName);
            }

            return true;
        }

        // 自动注册
        static void AutoReplace()
        {
            var types = new Dictionary<string, IType>(appdomain.LoadedTypes);
            foreach (var ator in types)
            {
                ILType type = ator.Value as ILType;
                if (type == null)
                    continue;

                var typeDefinition = type.TypeDefinition;
                ReplaceType replaceType = GetReplaceType(typeDefinition.CustomAttributes);
                System.Type rt = replaceType == null ? null : replaceType.type;
                foreach (var il in type.GetMethods())
                {
                    var ilMethod = il as ILMethod;
                    if (ilMethod == null)
                        continue;

                    var method = ilMethod.Definition;
                    ReplaceFunction replaceFunction = GetReplaceFunction(method.CustomAttributes);
                    if (replaceFunction == null)
                        continue;

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
                        UnityEngine.Debug.LogErrorFormat("type:{0} method:{1} not find {2} hot field!", type.Name, method.Name, fieldName);
                        continue;
                    }

                    field.SetValue(null, new global::IL.DelegateBridge(ilMethod.ReflectionMethodInfo));
                    UnityEngine.Debug.LogFormat("type:{0} method:{1} Replace {2}.{3}!", type.Name, method.Name, srcType.Name, fieldName);
                }
            }
        }
    }
}
#endif
