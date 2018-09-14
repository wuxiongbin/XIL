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

        public Objects(object p0)
        {
            objs = ObjectArrayPools.New(1);
            objs[0] = p0;
        }

        public Objects(object p0, object p1)
        {
            objs = ObjectArrayPools.New(2);
            objs[0] = p0;
            objs[1] = p1;
        }

        public Objects(object p0, object p1, object p2)
        {
            objs = ObjectArrayPools.New(3);
            objs[0] = p0;
            objs[1] = p1;
            objs[2] = p2;
        }

        public Objects(object p0, object p1, object p2, object p3)
        {
            objs = ObjectArrayPools.New(4);
            objs[0] = p0;
            objs[1] = p1;
            objs[2] = p2;
            objs[3] = p3;
        }

        public Objects(object p0, object p1, object p2, object p3, object p4)
        {
            objs = ObjectArrayPools.New(5);
            objs[0] = p0;
            objs[1] = p1;
            objs[2] = p2;
            objs[3] = p3;
            objs[4] = p4;
        }

        public Objects(object p0, object p1, object p2, object p3, object p4, object p5)
        {
            objs = ObjectArrayPools.New(6);
            objs[0] = p0;
            objs[1] = p1;
            objs[2] = p2;
            objs[3] = p3;
            objs[4] = p4;
            objs[5] = p5;
        }

        public Objects(object p0, object p1, object p2, object p3, object p4, object p5, object p6)
        {
            objs = ObjectArrayPools.New(7);
            objs[0] = p0;
            objs[1] = p1;
            objs[2] = p2;
            objs[3] = p3;
            objs[4] = p4;
            objs[5] = p5;
            objs[6] = p6;
        }

        public Objects(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7)
        {
            objs = ObjectArrayPools.New(8);
            objs[0] = p0;
            objs[1] = p1;
            objs[2] = p2;
            objs[3] = p3;
            objs[4] = p4;
            objs[5] = p5;
            objs[6] = p6;
            objs[7] = p7;
        }

        public Objects(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)
        {
            objs = ObjectArrayPools.New(9);
            objs[0] = p0;
            objs[1] = p1;
            objs[2] = p2;
            objs[3] = p3;
            objs[4] = p4;
            objs[5] = p5;
            objs[6] = p6;
            objs[7] = p7;
            objs[8] = p8;
        }

        public Objects(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9)
        {
            objs = ObjectArrayPools.New(10);
            objs[0] = p0;
            objs[1] = p1;
            objs[2] = p2;
            objs[3] = p3;
            objs[4] = p4;
            objs[5] = p5;
            objs[6] = p6;
            objs[7] = p7;
            objs[8] = p8;
            objs[9] = p9;
        }

        void System.IDisposable.Dispose()
        {
            ObjectArrayPools.Delete(objs);
        }
    }
}