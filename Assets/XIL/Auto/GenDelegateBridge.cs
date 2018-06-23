#if USE_HOT
namespace IL
{
    public partial class DelegateBridge
    {
        public void __Gen_Delegate_Imp1(object p0)
        {
            object[] param = new object[]{ p0 };
            methodInfo.Invoke(null, param);
        }
        public void __Gen_Delegate_Imp2(object p0, ref System.Int32 p1, out System.Int32 p2)
        {
            p2 = default(System.Int32);
            object[] param = new object[]{ p0, new RefOutParam<System.Int32>(p1), new RefOutParam<System.Int32>(p2) };
            methodInfo.Invoke(null, param);
            p1 = ((RefOutParam<System.Int32>)param[1]).value;
            p2 = ((RefOutParam<System.Int32>)param[2]).value;
        }
        public int __Gen_Delegate_Imp3(object p0)
        {
            object[] param = new object[]{ p0 };
            int result = default(int);
            result = (int)methodInfo.Invoke(null, param);
            return result;
        }
        public void __Gen_Delegate_Imp4()
        {
            object[] param = new object[]{  };
            methodInfo.Invoke(null, param);
        }

    }
}
#endif