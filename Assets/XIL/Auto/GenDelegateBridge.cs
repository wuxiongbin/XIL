#if USE_HOT
namespace IL
{
    public partial class DelegateBridge
    {
        public void __Gen_Delegate_Imp1()
        {
            using (var pObjs = new EmptyObjs())
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public int __Gen_Delegate_Imp2()
        {
            using (var pObjs = new EmptyObjs())
            {
                int result = default(int);
                result = (int)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public void __Gen_Delegate_Imp3(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp4(object p0, ref System.Int32 p1, out System.Int32 p2)
        {
            p2 = default(System.Int32);
            using (var pObjs = new Objects(p0, new RefOutParam<System.Int32>(p1), new RefOutParam<System.Int32>(p2)))
            {
                var param = pObjs.objs;
                methodInfo.Invoke(null, param);
                p1 = ((RefOutParam<System.Int32>)param[1]).value;
                p2 = ((RefOutParam<System.Int32>)param[2]).value;
            }
        }
        public int __Gen_Delegate_Imp5(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                int result = default(int);
                result = (int)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public void __Gen_Delegate_Imp6(object p0, object p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp7(object p0, int p1, long p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp8(object p0, int p1, object p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public System.Collections.IEnumerator __Gen_Delegate_Imp9(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                System.Collections.IEnumerator result = default(System.Collections.IEnumerator);
                result = (System.Collections.IEnumerator)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }

    }
}
#endif