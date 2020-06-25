using UnityEngine;
using System.Collections.Generic;

namespace wxb
{
    using wxb.IL;

    public class MonoStream : WRStream
    {
        public MonoStream(int size, List<Object> objs) : base(size)
        {
            this.objs = objs;
        }

        public MonoStream(byte[] bytes, List<Object> objs) : base(bytes)
        {
            this.objs = objs;
        }

        public List<Object> objs;

        public int Add(Object o)
        {
            int pos = objs.IndexOf(o);
            if (pos == -1)
            {
                objs.Add(o);
                pos = objs.Count - 1;
            }

            return pos;
        }

        public override void WriteUnityObject(UnityEngine.Object obj)
        {
            int pos = objs.IndexOf(obj);
            if (pos == -1)
            {
                objs.Add(obj);
                pos = objs.Count - 1;
            }

            WriteVarInt32(pos);
        }

        public override UnityEngine.Object ReadUnityObject()
        {
            var pos = ReadVarInt32();
            return objs[pos];
        }
    }

    public static class MonoSerialize
    {
        public static MonoStream WriteTo(object obj)
        {
            var stream = new MonoStream(512, new List<Object>());
            BinarySerializable.GetByInstance(obj).WriteTo(obj, stream);
            return stream;
        }

        public static void MergeFrom(object obj, byte[] bytes, List<Object> objs)
        {
            if (bytes == null)
                return;

            var ms = new MonoStream(bytes, objs);
            ms.WritePos = bytes.Length;
            BinarySerializable.MergeFrom(obj, ms);
        }
    }
}
