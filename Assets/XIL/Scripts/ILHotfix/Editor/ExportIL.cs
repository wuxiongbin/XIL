#if USE_HOT
namespace wxb
{
    using System;
    using UnityEngine;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    public class GenAutoExport
    {
        static string[] BlackList =
        {
            //"`",
        };

        static bool isAttribute(System.Type type)
        {
            if (type.BaseType == null)
                return false;

            if (type.BaseType == typeof(System.Attribute))
                return true;

            return isAttribute(type.BaseType);
        }

        static bool IsCompilerGenerated(System.Type t)
        {
            var compiler = typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute);
            return IsAttributes(t, compiler);
        }

        static bool IsAttributes(System.Type t, System.Type att)
        {
            if (t.GetCustomAttributes(att, true).Length != 0)
                return true;

            if (t.IsNested)
                return IsAttributes(t.DeclaringType, att);
            return false;
        }

        public static List<string> FixMarkIL()
        {
            //return new List<string>(new string[] { "EditorExtensions.AutoEditorHorizontal" });
            var assembly = Assembly.Load("Assembly-CSharp");
            var types = assembly.GetTypes();
            List<string> classes = new List<string>();
            HashSet<Type> delegateTypes = new HashSet<Type>();
            foreach (var t in types)
            {
                //已手动标记
                if (t.IsClass == false || t.IsInterface || typeof(Delegate).IsAssignableFrom(t))
                    continue;

                if (IsCompilerGenerated(t))
                    continue;

                bool isBlack = false;
                foreach (var bl in BlackList)
                {
                    if (t.FullName.Contains(bl))
                    {
                        isBlack = true;
                        break;
                    }
                }

                if (isBlack)
                    continue;

                if (t.FullName == null)
                    continue;

                if (isAttribute(t))
                    continue;

                if (IsAttributes(t, typeof(EditorClass)))
                {
                    continue;
                }

                if (t.GetCustomAttributes(typeof(HotfixAttribute), false).Length == 0)
                {
                    //ILRuntime
                    string FullName = t.FullName;
                    if (FullName.StartsWith("IL.") ||
                        FullName.StartsWith("ILRuntime.") ||
                        FullName.StartsWith("wxb.") ||
                        FullName.StartsWith("Microsoft.") ||
                        FullName.StartsWith("CsvCommon.") ||
                        FullName.StartsWith("Network.") ||
                        //FullName.StartsWith("Config.") ||
                        FullName.StartsWith("DG.Tweening.") ||
                        FullName.StartsWith("Common.") ||
                        FullName.StartsWith("CommonBase.") ||
                        FullName.StartsWith("UIWidgets.") ||
                        FullName.StartsWith("EditorExtensions") ||
                        FullName.StartsWith("XTools.") || 
                        //FullName.StartsWith("Bale.") ||
                        FullName.StartsWith("AutoIL.") ||
                        FullName.StartsWith("LitJson.") ||
                        FullName.StartsWith("Pool.") ||
                        FullName.StartsWith("<.") ||
                        FullName.StartsWith("AStar.") ||
                        FullName.StartsWith("Mono."))
                        continue;
                }

                switch (t.FullName)
                {
                case "Log":
                case "Logger":
                case "Converter":
                case "RALoad":
                case "Layer":
                    continue;
                default:
                    break;
                }

                classes.Add(t.FullName.Replace('+', '/'));
            }

            HashSet<string> allDelegateNames = new HashSet<string>();
            foreach (var delegateType in delegateTypes)
            {
                bool isSupport = true;
                if (delegateType.FullName == null)
                    continue;

                if (delegateType.IsGenericType && delegateType.ContainsGenericParameters)
                    continue;

                var name = delegateType.FullName.Split("`".ToCharArray())[0].Replace('+', '.');
                //MethodInfo method = delegateType.GetMethod("Invoke");
                var paramSign = "";
                if (delegateType.IsGenericType && delegateType.GetGenericArguments().Length > 0)
                {
                    List<string> paramSigns = new List<string>();
                    foreach (var ptype in delegateType.GetGenericArguments())
                    {
                        if (ptype.IsArray)
                        {
                            if (ptype.FullName == null)
                            {
                                isSupport = false;
                                break;
                            }
                            paramSigns.Add(ptype.FullName.Replace('+', '.') + "[]");
                        }
                        else if (ptype.IsGenericType && ptype.GetGenericTypeDefinition() == typeof(List<>))
                        {
                            var eletype = ptype.GetGenericArguments()[0];
                            if (eletype.IsGenericType || eletype.FullName == null)
                            {
                                isSupport = false;
                                break;
                            }
                            paramSigns.Add(string.Format("List<{0}>", eletype.FullName.Replace('+', '.')));
                        }
                        else if (ptype.IsGenericType && ptype.GetGenericTypeDefinition() == typeof(Dictionary<,>))
                        {
                            var keytype = ptype.GetGenericArguments()[0];
                            var valuetype = ptype.GetGenericArguments()[1];
                            if (keytype.IsGenericType || keytype.FullName == null || valuetype.IsGenericType || valuetype.FullName == null)
                            {
                                isSupport = false;
                                break;
                            }
                            paramSigns.Add(string.Format("Dictionary<{0}, {1}>", keytype.FullName.Replace('+', '.'), valuetype.FullName.Replace('+', '.')));
                        }
                        else
                        {
                            if (ptype.FullName == null)
                            {
                                isSupport = false;
                                break;
                            }
                            paramSigns.Add(ptype.FullName.Replace('+', '.'));
                        }
                    }
                    paramSign = string.Format("<{0}>", string.Join(", ", paramSigns.ToArray()));
                }
                if (isSupport)
                    allDelegateNames.Add(name + paramSign);
            }

            //List<string> delegates = allDelegateNames.ToList();
            //delegates.Sort();
            classes.Sort();

            wxb.L.Log(string.Format("Find {0} Classes.", classes.Count/*, delegates.Count*/));
            return classes;
            //string file = gen_config_file;
            //var write = new StreamWriter(file);
            //foreach (var cls in classes)
            //{
            //    write.WriteLine(cls);
            //}

            //write.Close();
        }
    }
}
#endif