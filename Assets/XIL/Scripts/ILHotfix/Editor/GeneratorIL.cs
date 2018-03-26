#if USE_HOT
namespace wxb
{
    using UnityEditor;
    using UnityEngine;
    using System.Reflection;
    using System.Collections.Generic;

    public static class Generator
    {
        public class Parameter
        {
            public Parameter(Type pt, string name, string typeName)
            {
                this.pt = pt;
                this.name = name;
                this.typeName = typeName;
            }

            public Type pt { get; private set; }
            public string name { get; private set; }
            public string typeName { get; private set; }

            public enum Type
            {
                Normal,
                Out,
                Ref,
            }
        }

        static string InitOutParam(List<Parameter> Param, string suffix)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < Param.Count; ++i)
            {
                var p = Param[i];
                if (p.pt == Parameter.Type.Out)
                {
                    sb.AppendFormat("{2}{0} = default({1});", p.name, p.typeName, suffix);
                    sb.AppendLine();
                }
            }

            return sb.ToString();
        }

        static void Append(System.Text.StringBuilder sb, string text, int start)
        {
            int end = text.Length;
            for (int i = start; i < end; ++i)
                sb.Append(text[i]);
        }

        static void Append(System.Text.StringBuilder sb, string text, int start, int count)
        {
            int end = start + count;
            for (int i = start; i < end; ++i)
                sb.Append(text[i]);
        }

        static string SetOutParam(List<Parameter> Param, int start, string suffix)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = start; i < Param.Count; ++i)
            {
                var p = Param[i];
                if (p.pt == Parameter.Type.Out || p.pt == Parameter.Type.Ref)
                {
                    sb.AppendFormat("{3}{0} = ((RefOutParam<{1}>)param[{2}]).value;", p.name, p.typeName, i - start, suffix);
                    sb.AppendLine();
                }
            }

            return sb.ToString();
        }

        static string toGenParam(List<Parameter> Param, int start)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("param = new object[]{ ");

            int count = 0;
            for (int i = start; i < Param.Count; ++i)
            {
                if (count != 0)
                {
                    sb.Append(", ");
                }

                if (Param[i].pt == Parameter.Type.Normal)
                {
                    sb.Append(Param[i].name);
                }
                else
                {
                    sb.Append(string.Format("new RefOutParam<{0}>({1})", Param[i].typeName, Param[i].name));
                }

                ++count;
            }
            sb.Append(" };");

            return sb.ToString();
        }

        static void Global(System.Text.StringBuilder sb, string funName, string returnName, List<Parameter> paramList)
        {
            // 插入生成的IL代码
            //sb.AppendLine("            if (methodInfo != null)");
            //sb.AppendLine("            {");

            string initP = InitOutParam(paramList, "            ");
            if (!string.IsNullOrEmpty(initP))
                sb.Append(initP);

            sb.Append("            object[] ");
            sb.Append(toGenParam(paramList, 0));
            sb.AppendLine();

            if (returnName != "void")
            {
                sb.AppendLine(string.Format("            {0} result = default({0});", returnName));
            }

            if (returnName == "void")
            {
                sb.AppendLine("            methodInfo.Invoke(null, param);");
            }
            else
            {
                sb.AppendFormat("            result = ({0})methodInfo.Invoke(null, param);", returnName);
                sb.AppendLine();
            }

            if (paramList.FindIndex((x) => { return (x.pt == Parameter.Type.Out || x.pt == Parameter.Type.Ref) ? true : false; }) != -1)
            {
                sb.Append(SetOutParam(paramList, 0, "            "));
            }

            if (returnName != "void")
            {
                sb.AppendLine("            return result;");
            }
            else
            {
                //sb.AppendLine("            return;");
            }

            //sb.AppendLine("            }");
        }

        public static void InILCode(System.Text.StringBuilder sb, string funName, string returnName, List<Parameter> paramList)
        {
            //sb.AppendLine();
            //sb.AppendFormat("#if USE_HOT");
            //sb.AppendLine();
            Global(sb, funName, returnName, paramList);
            //sb.AppendFormat("#endif");
            //sb.AppendLine();
        }
    }
}
#endif