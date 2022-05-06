#if USE_ILRT && !USE_ILRT
namespace wxb
{
    using global::IL;
    using System.Reflection;
    using System.Collections.Generic;

    public static partial class hotMgr
    {
        static RefType refType;
        public static RefType RefType { get { return refType; } }

        static Assembly assembly = null;

        public static List<System.Type> AllTypes { get; set; }

        public static void Init(IResLoad resLoad = null)
        {
            if (assembly != null)
                return;

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

            AutoReplace(AllTypes);
            InitByProperty(typeof(AutoInitAndRelease), "Init", AllTypes);
        }

        public const BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

        public static byte[] GetBytes(System.IO.Stream input)
        {
            try
            {
                if (input == null)
                    return null;

                int length = (int)(input.Length - input.Position);
                byte[] bytes = new byte[length];
                input.Read(bytes, 0, length);
                return bytes;
            }
            catch (System.Exception ex)
            {
                wxb.L.LogException(ex);
                return null;
            }
        }

        static public void InitHotModule()
        {
            try
            {
                var bytes = GetBytes(ResLoad.GetStream("Data/DyncDll.dll"));
                if (bytes != null)
                {
                    assembly = System.Reflection.Assembly.Load(bytes);
                    AllTypes = new List<System.Type>(assembly.GetTypes());
                }
            }
            catch (System.Exception ex)
            {
                wxb.L.LogException(ex);
            }

            IL.Help.Init();
        }

        static bool GetReplaceFunction(List<System.Attribute> CustomAttributes, out System.Type type, out string fieldName, out string hot_fieldName)
        {
            System.Attribute custom;
            for (int i = 0; i < CustomAttributes.Count; ++i)
            {
                custom = CustomAttributes[i];
                if (!(custom is ReplaceFunction))
                    continue;

                var rf = custom as ReplaceFunction;
                switch (rf.create_type)
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
                            if (rf.type != null)
                            {
                                type = rf.type;
                                fieldName = null;
                            }
                            else
                            {
                                string strValue = rf.fieldNameOrTypeName;
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

                            hot_fieldName = null;
                            return true;
                        }
                    case 2:
                        {
                            type = rf.type != null ? rf.type : GetTypeByName(rf.typeName);
                            fieldName = rf.fieldName;
                            hot_fieldName = null;
                            return true;
                        }
                    case 3:
                        {
                            type =  rf.type != null ? rf.type : GetTypeByName(rf.typeName);
                            fieldName = rf.fieldName;
                            hot_fieldName = rf.hot_hotfix_fieldName;
                            return true;
                        }
                }
            }

            type = null;
            fieldName = null;
            hot_fieldName = null;
            return false;
        }

        static void GetPlatform(List<System.Attribute> CustomAttributes, System.Action<UnityEngine.RuntimePlatform> action)
        {
            System.Attribute custom;
            for (int i = 0; i < CustomAttributes.Count; ++i)
            {
                custom = CustomAttributes[i];
                if (!(custom is wxb.Platform))
                    continue;

                UnityEngine.RuntimePlatform platform = (UnityEngine.RuntimePlatform)System.Enum.Parse(typeof(UnityEngine.RuntimePlatform), (custom as Platform).platform);
                action(platform);
            }
        }

        static System.Type GetTypeByName(string fullName)
        {
            if (fullName.IndexOf('/') != -1)
                fullName = fullName.Replace('/', '+');
            return IL.Help.GetTypeByFullName(fullName);
        }

        static System.Type GetReplaceType(IList<System.Attribute> CustomAttributes)
        {
            System.Attribute custom;
            var cnt = CustomAttributes.Count;
            for (int i = 0; i < cnt; ++i)
            {
                custom = CustomAttributes[i];
                if (!(custom is ReplaceType))
                    continue;

                return (custom as ReplaceType).Type;
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
            //#if USE_ILRT
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

        static System.Reflection.FieldInfo FindStaticField(System.Type type, string name)
        {
            return type.GetField(name, BindingFlags.Static | BindingFlags.NonPublic);
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
        static void AutoReplace(List<System.Type> types)
        {
            Dictionary<string, List<MethodInfo>> NameToSorted = new Dictionary<string, List<MethodInfo>>();
            List<UnityEngine.RuntimePlatform> platforms = new List<UnityEngine.RuntimePlatform>();
            UnityEngine.RuntimePlatform rp = GetCurrentPlatform();
            List<System.Attribute> attributes = new List<System.Attribute>();
            foreach (var ator in types)
            {
                var type = ator;
                if (type == null)
                    continue;

                if (type.IsEnum || type.IsInterface || type.IsValueType || type.IsArray)
                    continue;

                NameToSorted.Clear();
                attributes.Clear();
                attributes.AddRange(type.GetCustomAttributes());
                System.Type rt = GetReplaceType(attributes);
                platforms.Clear();
                GetPlatform(attributes, (p) => { platforms.Add(p); });
                if (platforms.Count != 0 && !platforms.Contains(rp))
                {
                    wxb.L.LogWarningFormat("platorms:{0} type:{1} not hotfix!", rp, type.Name);
                    continue; // 不属于此平台的
                }

                // 相同函数名排序问题
                foreach (var method in type.GetMethods())
                {
                    System.Type methodType;
                    string methodFieldName;
                    string set_hot_field_name;
                    attributes.Clear();
                    attributes.AddRange(method.GetCustomAttributes());
                    if (!GetReplaceFunction(attributes, out methodType, out methodFieldName, out set_hot_field_name))
                        continue;

                    if (!method.IsStatic)
                    {
                        wxb.L.LogErrorFormat("type:{0} method:{1} is not static fun!", type.Name, method.Name);
                        continue;
                    }

                    platforms.Clear();
                    GetPlatform(attributes, (p) => { platforms.Add(p); });
                    if (platforms.Count != 0 && !platforms.Contains(rp))
                    {
                        wxb.L.LogWarningFormat("platorms:{0} type:{1}.{2} not hotfix!", rp, type.Name, method.Name);
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

                    var bridge = new global::IL.DelegateBridge(method);
                    field.SetValue(null, bridge);
                    Fields.Add(field);
                    wxb.L.LogFormat("type:{0} method:{1} Replace {2}.{3}!", type.Name, method.Name, srcType.Name, fieldName);

                    AutoSetFieldMethodValue(srcType, field, type, fieldName, set_hot_field_name, bridge, NameToSorted);
                }
            }
        }

        static void InitByProperty(System.Type attType, string name, List<System.Type> types)
        {
            string autoAttName = attType.FullName;
            List<MethodInfo> calls = new List<MethodInfo>();
            System.Type[] Emptys = new System.Type[0];
            foreach (var itor in types)
            {
                if (itor.GetCustomAttribute(attType) == null)
                    continue;

                var methods = itor.GetMethods(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
                if (methods == null || methods.Length == 0)
                    continue;

                foreach (var method in methods)
                {
                    if (method.Name == name && method.GetParameters().Length == 0)
                    {
                        calls.Add(method);
                        break;
                    }
                }
            }

            object[] EP = new object[0];
            for (int i = 0; i < calls.Count; ++i)
            {
                try
                {
                    calls[i].Invoke(null, EP);
                }
                catch (System.Exception ex)
                {
                    wxb.L.LogException(ex);
                }
            }
        }

        static void AutoSetFieldMethodValue(System.Type srcType, FieldInfo srcFieldInfo, System.Type type, string fieldName, string set_hot_field_name, DelegateBridge bridge, Dictionary<string, List<MethodInfo>> NameToSorted)
        {
            System.Reflection.FieldInfo auto_fieldInfo = null;
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

            var fieldInfo = type.GetField(auto_fieldInfo.Name, bindingFlags);
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

#if UNITY_EDITOR
        static void CallStatic(string typeName, string methodName, params object[] param)
        {
            System.Type clrType = System.Type.GetType(typeName);
            if (clrType != null)
            {
                var method = clrType.GetMethod(methodName);
                if (method != null)
                    method.Invoke(null, param);
            }
        }
#endif
        // 释放所有热更模块
        public static void ReleaseAll()
        {
            if (assembly == null)
                return;

            ResLoad.Set(null);
            refType.TryInvokeMethod("ReleaseAll");
            InitByProperty(typeof(AutoInitAndRelease), "Release", AllTypes);

            foreach (var ator in Fields)
                ator.SetValue(null, null);
            Fields.Clear();

            IL.Help.ReleaseAll();
            AllTypes.Clear();
            AllTypes = null;
            refType = null;
            assembly = null;
            System.GC.Collect();
        }
    }
}
#endif