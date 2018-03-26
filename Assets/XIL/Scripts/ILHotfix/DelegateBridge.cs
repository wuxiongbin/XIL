namespace IL
{
    using System.Collections.Generic;

    public partial class DelegateBridge
    {
        System.Reflection.MethodInfo methodInfo = null;

        public DelegateBridge(System.Reflection.MethodInfo methodInfo)
        {
            this.methodInfo = methodInfo;
        }

        List<object> paramList; // 参数列表
        object result; // 返回列表

        public void InvokeSessionStart()
        {
            paramList = new List<object>();
        }

        public void Invoke(int nRet)
        {
            result = methodInfo.Invoke(null, new object[] { paramList });
        }

        public void InvokeSessionEnd()
        {
            paramList = null;
            result = null;
        }

        public TResult InvokeSessionEndWithResult<TResult>()
        {
            return (TResult)result;
        }

        public void InParam<T>(T p)
        {
            paramList.Add(p);
        }

        public void InParams<T>(T[] ps)
        {
            paramList.Add(ps);
        }

        public void OutParam<TResult>(int pos, out TResult ret)
        {
            ret = (TResult)paramList[pos];
        }
    }
}