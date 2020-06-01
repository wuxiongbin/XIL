namespace wxb
{
    using System.Reflection;
    using System.Collections.Generic;

    [EditorClass]
    static partial class AutoRegILType
    {
        class Cache
        {
            public string clsName;
            public string realClsName;
            public string isByRef;
        }

        static Dictionary<System.Type, Cache> Caches = new Dictionary<System.Type, Cache>();

        public static string GetClassRealClsName(System.Type type)
        {
            string clsName;
            string realClsName;
            bool isByRef;
            GetClassName(type, out clsName, out realClsName, out isByRef);
            return realClsName;
        }

        static void GetClassName(System.Type type, out string clsName, out string realClsName, out bool isByRef, bool simpleClassName = false)
        {
            isByRef = type.IsByRef;
            if (isByRef)
                type = type.GetElementType();
            bool isArray = type.IsArray;
            if (isArray)
                type = type.GetElementType();
            string realNamespace = null;
            bool isNestedGeneric = false;
            if (type.IsNested)
            {
                string bClsName, bRealClsName;
                bool tmp;
                var rt = type.ReflectedType;
                if (rt.IsGenericType && rt.IsGenericTypeDefinition)
                {
                    if (type.IsGenericType)
                    {
                        rt = rt.MakeGenericType(type.GetGenericArguments());
                        isNestedGeneric = true;
                    }
                }
                if (rt == type)
                {
                    wxb.L.LogErrorFormat("type:{0} -> {1}", type.Name, rt.Name);
                }

                GetClassName(rt, out bClsName, out bRealClsName, out tmp);
                clsName = simpleClassName ? "" : bClsName + "_";
                realNamespace = bRealClsName + ".";
            }
            else
            {
                clsName = simpleClassName ? "" : (!string.IsNullOrEmpty(type.Namespace) ? type.Namespace.Replace(".", "_") + "_" : "");
                realNamespace = !string.IsNullOrEmpty(type.Namespace) ? type.Namespace + "." : null;
            }
            clsName = clsName + type.Name.Replace(".", "_").Replace("`", "_").Replace("<", "_").Replace(">", "_");
            bool isGeneric = false;
            string ga = null;
            if (type.IsGenericType && !isNestedGeneric)
            {
                isGeneric = true;
                clsName += "_";
                ga = "<";
                var args = type.GetGenericArguments();
                bool first = true;
                foreach (var j in args)
                {
                    if (first)
                        first = false;
                    else
                    {
                        clsName += "_";
                        ga += ", ";
                    }
                    string a, b;
                    bool tmp;
                    if (type == j)
                    {
                        wxb.L.LogErrorFormat("type:{0} -> {1}", type.Name, j.Name);
                    }

                    GetClassName(j, out a, out b, out tmp, true);
                    clsName += a;
                    ga += b;
                }
                ga += ">";
            }
            if (!simpleClassName)
                clsName += "_Binding";
            if (isArray)
                clsName += "_Array";

            realClsName = realNamespace;
            if (isGeneric)
            {
                int idx = type.Name.IndexOf("`");
                if (idx > 0)
                {
                    realClsName += type.Name.Substring(0, idx);
                    realClsName += ga;
                }
                else
                    realClsName += type.Name;
            }
            else
                realClsName += type.Name;

            if (isArray)
                realClsName += "[]";
        }

        public static void ConvertToDelegate(System.Type type, System.Text.StringBuilder sb, string suffix)
        {
            var mi = type.GetMethod("Invoke");
            var ps = mi.GetParameters();
            //for (int i = 0; i < ps.Length; ++i)
            //{
            //    if (ps[i].IsOut || ps[i].ParameterType.IsByRef)
            //        return;
            //}

            //if (ps.Length >= 5)
            //    return;

            string clsName, rName;
            bool isByRef;
            GetClassName(type, out clsName, out rName, out isByRef);
            sb.Append(suffix);
            sb.Append("appdomain.DelegateManager.RegisterDelegateConvertor<");
            sb.Append(rName);
            sb.AppendLine(">((act) =>");

            sb.Append(suffix);
            sb.AppendLine("{");

            sb.Append(suffix);
            sb.Append("    return new ");
            sb.Append(rName);
            sb.Append("((");
            bool first = true;
            foreach (var i in ps)
            {
                if (first)
                {
                    first = false;
                }
                else
                    sb.Append(", ");
                sb.Append(i.Name);
            }
            sb.AppendLine(") =>");

            sb.Append(suffix);
            sb.AppendLine("    {");
            if (mi.ReturnType != typeof(void))
            {
                sb.Append(suffix);
                sb.Append("        return ((System.Func<");

                first = true;
                foreach (var i in mi.GetParameters())
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                        sb.Append(", ");
                    GetClassName(i.ParameterType, out clsName, out rName, out isByRef);
                    sb.Append(rName);
                }

                if (!first)
                {
                    sb.Append(", ");
                }

                GetClassName(mi.ReturnType, out clsName, out rName, out isByRef);
                sb.Append(rName);
                sb.Append(">");
            }
            else
            {
                sb.Append(suffix);
                sb.Append("        ((System.Action");
                first = true;
                foreach (var i in mi.GetParameters())
                {
                    if (first)
                    {
                        first = false;
                        sb.Append("<");
                    }
                    else
                        sb.Append(", ");
                    GetClassName(i.ParameterType, out clsName, out rName, out isByRef);
                    sb.Append(rName);
                }

                if (first == false)
                {
                    sb.Append(">");
                }
            }
            sb.Append(")act)(");
            first = true;
            foreach (var i in mi.GetParameters())
            {
                if (first)
                {
                    first = false;
                }
                else
                    sb.Append(", ");
                sb.Append(i.Name);
            }
            sb.AppendLine(");");

            sb.Append(suffix);
            sb.AppendLine("    });");

            sb.Append(suffix);
            sb.AppendLine("});");
        }

        const string RegTextFile = @"#if USE_HOT && {0}
namespace AutoIL
{{
    using ILRuntime.Runtime.Enviorment;

    static class ILRegType
    {{
        static public void RegisterFunctionDelegate(AppDomain appdomain)
        {{
{1}
        }}

        static public void RegisterDelegateConvertor(AppDomain appdomain)
        {{
{2}
        }}

        static public void RegisterMethodDelegate(AppDomain appdomain)
        {{
{3}
        }}

        static public void Fame()
        {{
{4}
        }}
    }}
}}
" + "#endif";

        static void DelegateAdapter(DelegateKey key, SB SB, string suffix, System.Action<System.Text.StringBuilder> onfun)
        {
            System.Text.StringBuilder sb = null;
            bool isVoid = key.returnType.Name == "Void";
            var ps = key.parameters;
            if (isVoid)
            {
                sb = SB.RegisterMethodDelegate;
                if (onfun != null)
                    onfun(sb);

                sb.Append(suffix);
                sb.Append("appdomain.DelegateManager.RegisterMethodDelegate<");
            }
            else
            {
                sb = SB.RegisterFunctionDelegate;
                if (onfun != null)
                    onfun(sb);

                sb.Append(suffix);
                sb.Append("appdomain.DelegateManager.RegisterFunctionDelegate<");
            }

            bool first = true;
            foreach (var i in ps)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    sb.Append(", ");
                }

                string clsName;
                string realClsName;
                bool isByRef;
                GetClassName(i, out clsName, out realClsName, out isByRef);
                sb.Append(realClsName);
            }

            if (!isVoid)
            {
                if (ps.Count != 0)
                    sb.Append(", ");

                string clsName;
                string realClsName;
                bool isByRef;
                GetClassName(key.returnType, out clsName, out realClsName, out isByRef);
                sb.Append(realClsName);
            }

            sb.Append(">");
            sb.Append("();");
            sb.AppendLine();
        }
    }
}