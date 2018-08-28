namespace IL
{
    public struct EmptyObjs : System.IDisposable
    {
        static object[] Emptys = new object[0];

        public object[] objs { get { return Emptys; } }

        void System.IDisposable.Dispose()
        {

        }
    }

    public partial struct Objects : System.IDisposable
    {
        public object[] objs;

        void System.IDisposable.Dispose()
        {
            ObjectArrayPools.Delete(objs);
        }
    }
}