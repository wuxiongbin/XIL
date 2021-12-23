using UnityEngine;
using System.Collections.Generic;

namespace wxb
{
    public class MonoStream : WRStream, IStream
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
            if (o == null)
                return 0;

            int pos = objs.IndexOf(o);
            if (pos == -1)
            {
                objs.Add(o);
                pos = objs.Count;
            }
            else
            {
                pos += 1;
            }

            return pos;
        }

        public void WriteUnityObject(Object obj)
        {
            if (obj == null)
            {
                WriteVarInt32(0);
                return;
            }

            int pos = objs.IndexOf(obj);
            if (pos == -1)
            {
                objs.Add(obj);
                pos = objs.Count;
            }
            else
            {
                pos += 1;
            }

            WriteVarInt32(pos);
        }

        public Object ReadUnityObject()
        {
            var pos = ReadVarInt32();
            if (pos == 0)
                return null;

            return objs[pos - 1];
        }

        void IStream.WriteFieldName(string value)
        {
            WriteString(value);
        }

        string IStream.ReadFieldName()
        {
            return ReadString();
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

#if !CloseNested // 关闭预置体嵌套支持
        public static Nested.Any0 WriteToTS(object obj)
        {
            Nested.Any0 ab = new Nested.Any0();
            ab.dataKey = ".root";
            BinarySerializable.GetByInstance(obj).WriteTo(obj, ab);
            return ab;
        }

        public static void MergeFrom(object obj, Nested.AnyBase ab)
        {
            BinarySerializable.MergeFrom(obj, ab);
        }
#endif
    }
}
