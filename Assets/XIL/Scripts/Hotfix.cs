#if USE_ILRT
namespace wxb
{
    using System.Reflection;
    using global::IL;
    using System.Collections.Generic;

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
}
#endif