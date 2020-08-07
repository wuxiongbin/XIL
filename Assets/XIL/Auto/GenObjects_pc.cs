#if UNITY_STANDALONE_WIN
namespace IL
{
    public partial struct Objects
    {
        public Objects(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9, object p10)
        {
            objs = ObjectArrayPools.New(11);
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
            objs[10] = p10;
        }

    }
}
#endif