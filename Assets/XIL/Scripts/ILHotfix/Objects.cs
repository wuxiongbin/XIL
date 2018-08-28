namespace IL
{
#if UNITY_EDITOR
    using System.Linq;
    using System.Collections.Generic;
#endif

    public partial struct Objects : System.IDisposable
    {
        public object[] objs;

        void System.IDisposable.Dispose()
        {
            ObjectArrayPools.Delete(objs);
        }
    }
}