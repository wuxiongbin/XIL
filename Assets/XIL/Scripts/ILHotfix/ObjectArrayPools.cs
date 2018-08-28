namespace IL
{
    using System.Collections.Generic;

    public static class ObjectArrayPools
    {
        public interface IPool
        {
            object[] New(int length);
            void Delete(object[] objs);
        }

        class DefaultPool : IPool
        {
            object[] IPool.New(int length)
            {
                return new object[length];
            }

            void IPool.Delete(object[] objs)
            {

            }
        }

        class QueuePool : IPool
        {
            // 最多20个参数吧
            object[] Pools = new object[20];

            object[] IPool.New(int length)
            {
                int key = length - 1;
                object obj = Pools[key];
                if (obj == null)
                    return new object[length];

                if (obj is object[])
                {
                    var v = (object[])obj;
                    Pools[key] = null;
                    return v;
                }
                else
                {
                    Queue<object[]> objs = obj as Queue<object[]>;
                    if (objs.Count != 0)
                        return objs.Dequeue();
                }

                return new object[length];
            }

            void IPool.Delete(object[] objs)
            {
                int key = objs.Length - 1;
                var pool = Pools[key];
                if (pool == null)
                {
                    Pools[key] = objs;
                }
                else
                {
                    Queue<object[]> pools = null;
                    if (pool is object[])
                    {
                        pools = new Queue<object[]>();
                        pools.Enqueue((object[])pool);
                        Pools[key] = pools;
                    }
                    else
                    {
                        pools = pool as Queue<object[]>;
                    }
                    pools.Enqueue(objs);
                }
            }
        }

        class ListPool : IPool
        {
            List<object[]> objs = new List<object[]>();
            object[] IPool.New(int length)
            {
                int l = objs.Count;
                object[] v = null;
                for (int i = 0; i < objs.Count; ++i)
                {
                    v = objs[i];
                    if (v != null && v.Length == length)
                    {
                        objs[i] = null;
                        return v;
                    }
                }

                return new object[length];
            }

            void IPool.Delete(object[] v)
            {
                int l = objs.Count;
                for (int i = 0; i < l; ++i)
                {
                    if (objs[i] == null)
                    {
                        objs[i] = v;
                        return ;
                    }
                }

                objs.Add(v);
            }
        }

        static IPool current = new QueuePool();

        public static void SetCurrent(IPool pool)
        {
            current = pool;
        }

        public static object[] New(int length)
        {
            return current.New(length);
        }

        public static void Delete(object[] objs)
        {
            int length = objs.Length;
            for (int i = 0; i < length; ++i)
                objs[i] = null;

            current.Delete(objs);
        }
    }
}