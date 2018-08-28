
namespace IL
{
    public partial struct Objects
    {
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

    }
}