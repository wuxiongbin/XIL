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
            "`",
        };

        static bool isAttribute(System.Type type)
        {
            if (type.BaseType == null)
                return false;

            if (type.BaseType == typeof(System.Attribute))
                return true;

            return isAttribute(type.BaseType);
        }

        public static List<string> FixMarkIL()
        {
            var assembly = Assembly.Load("Assembly-CSharp");
            var types = assembly.GetExportedTypes();

            List<string> classes = new List<string>();
            HashSet<Type> delegateTypes = new HashSet<Type>();

            foreach (var t in types)
            {
                //已手动标记
                if (t.IsAbstract || t.IsClass == false || t.IsInterface || t.IsNotPublic || t.IsNested || typeof(Delegate).IsAssignableFrom(t))
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

                if (t.GetCustomAttributes(typeof(HotfixAttribute), false).Length == 0)
                {
                    //ILRuntime
                    string FullName = t.FullName;
                    if (FullName.StartsWith("IL.") ||
                        FullName.StartsWith("ILRuntime.") ||
                        FullName.StartsWith("wxb.") || 
                        FullName.StartsWith("Mono."))
                        continue;
                }

                classes.Add(t.FullName.Replace('+', '.'));
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

            List<string> delegates = allDelegateNames.ToList();
            delegates.Sort();
            classes.Sort();

            Debug.Log(string.Format("Find {0} Classes {1} Delegates.", classes.Count, delegates.Count));
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