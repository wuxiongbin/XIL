namespace wxb
{
    using System.Reflection;
    using System.Collections.Generic;

    static partial class AutoRegILType
    {
        static bool IsTemplateInstance(System.Type type)
        {
            if (type.IsGenericType && !type.ContainsGenericParameters)
                return true;

            return false;
        }

        static bool Add(System.Type type, MemberInfo mi, Dictionary<System.Type, UseTypeInfo> dic)
        {
            // 为模版并且实例化了
            if (!IsTemplateInstance(type))
                return false;

            if (IsDelegate(type))
                return false;

            if (IsHotType(type))
            {
                if (type.FullName.StartsWith("System.Collections.Generic.Dictionary`2[["))
                {
                    // 为Map类型
                    var parameter = type.GetGenericArguments();
                    if (IsHotType(parameter[0]) && IsHotType(parameter[1]))
                    {
                        // 都是热更当中的
                        return false;
                    }
                    else
                    {

                    }
                }
                else
                {
                    return false;
                }
            }

            UseTypeInfo info = null;
            if (dic.TryGetValue(type, out info))
            {
                info.Add(mi);
                return true;
            }

            info = new UseTypeInfo();
            info.Add(mi);
            dic.Add(type, info);
            return true;
        }

        static void CheckHotType(System.Type type, Dictionary<System.Type, UseTypeInfo> dic, HashSet<System.Type> Checks)
        {
            if (!IsCheck(type, Checks))
                return;

            if (dic.ContainsKey(type))
                return;

            BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
            //Logger.LogDebug("type:{0}", type.FullName);
            // 查找下C#类型用到的所有模块类型
            foreach (var m in type.GetMembers(flags))
            {
                //Logger.LogDebug("type:{0} {1}", type.FullName, m.Name);
                if (m is FieldInfo)
                {
                    FieldInfo f = m as FieldInfo;
                    Add(f.FieldType, m, dic);
                }
                else if (m is PropertyInfo)
                {
                    PropertyInfo p = m as PropertyInfo;
                    Add(p.PropertyType, m, dic);
                }
                else if (m is MethodInfo)
                {
                    MethodInfo mi = m as MethodInfo;
                    Add(mi.ReturnType, m, dic);
                    foreach (var p in mi.GetParameters())
                    {
                        Add(p.ParameterType, m, dic);
                    }

                    foreach (var t in GetMethodBodyType(mi))
                    {
                        Add(t, m, dic);
                    }
                }
            }
        }
    }
}