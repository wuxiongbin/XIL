using System.Reflection;

namespace wxb
{
    public static class RefMethodInfo
    {
        static object InvokeMethod(this MethodInfo methodInfo, object instance, object[] objs)
        {
            try
            {
                return methodInfo.Invoke(instance, objs);
            }
            catch (System.Exception ex)
            {
                L.LogError($"InvokeMethod instance :{(instance == null ? "null" : IL.Help.GetInstanceType(instance).Name)} name:{methodInfo.Name}");
                L.LogException(ex);
                return null;
            }
        }
        public static object InvokeMethod(this MethodInfo methodInfo, object instance)
        {
            using (var obj = new global::IL.EmptyObjs())
            {
                return InvokeMethod(methodInfo, instance, obj.objs);
            }
        }
        public static object InvokeMethod(this MethodInfo methodInfo, object instance, object p1)
        {
            using (var obj = new global::IL.Objects(p1))
            {
                return InvokeMethod(methodInfo, instance, obj.objs);
            }
        }
        public static object InvokeMethod(this MethodInfo methodInfo, object instance, object p1, object p2)
        {
            using (var obj = new global::IL.Objects(p1, p2))
            {
                return InvokeMethod(methodInfo, instance, obj.objs);
            }
        }
        public static object InvokeMethod(this MethodInfo methodInfo, object instance, object p1, object p2, object p3)
        {
            using (var obj = new global::IL.Objects(p1, p2, p3))
            {
                return InvokeMethod(methodInfo, instance, obj.objs);
            }
        }
        public static object InvokeMethod(this MethodInfo methodInfo, object instance, object p1, object p2, object p3, object p4)
        {
            using (var obj = new global::IL.Objects(p1, p2, p3, p4))
            {
                return InvokeMethod(methodInfo, instance, obj.objs);
            }
        }
        public static object InvokeMethod(this MethodInfo methodInfo, object instance, object p1, object p2, object p3, object p4, object p5)
        {
            using (var obj = new global::IL.Objects(p1, p2, p3, p4, p5))
            {
                return InvokeMethod(methodInfo, instance, obj.objs);
            }
        }
        public static object InvokeMethod(this MethodInfo methodInfo, object instance, object p1, object p2, object p3, object p4, object p5, object p6)
        {
            using (var obj = new global::IL.Objects(p1, p2, p3, p4, p5, p6))
            {
                return InvokeMethod(methodInfo, instance, obj.objs);
            }
        }
        public static object InvokeMethod(this MethodInfo methodInfo, object instance, object p1, object p2, object p3, object p4, object p5, object p6, object p7)
        {
            using (var obj = new global::IL.Objects(p1, p2, p3, p4, p5, p6, p7))
            {
                return InvokeMethod(methodInfo, instance, obj.objs);
            }
        }
        public static object InvokeMethod(this MethodInfo methodInfo, object instance, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)
        {
            using (var obj = new global::IL.Objects(p1, p2, p3, p4, p5, p6, p7, p8))
            {
                return InvokeMethod(methodInfo, instance, obj.objs);
            }
        }
        public static object InvokeMethod(this MethodInfo methodInfo, object instance, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9)
        {
            using (var obj = new global::IL.Objects(p1, p2, p3, p4, p5, p6, p7, p8, p9))
            {
                return InvokeMethod(methodInfo, instance, obj.objs);
            }
        }
    }
}
