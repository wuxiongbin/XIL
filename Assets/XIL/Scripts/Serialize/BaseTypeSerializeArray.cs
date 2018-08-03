using UnityEngine;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace wxb
{
    abstract class IListSerialize<T> : ITypeSerialize
    {
        int ITypeSerialize.CalculateSize(object value)
        {
            var array = value as IList;
            if (array != null)
            {
                // 长度+各个元素内容
                return WRStream.ComputeLengthSize(array.Count) + (array.Count * GetElementSize());
            }
            else
            {
                return 0;
            }
        }

        protected abstract int GetElementSize();

        protected abstract void Write(WRStream stream, T value);

        void ITypeSerialize.WriteTo(object value, MonoStream ms)
        {
            IList<T> array = (IList<T>)value;
            if (array == null)
                return;

            int count = array.Count;
            ms.Stream.WriteLength(count);

            if (array != null)
            {
                var stream = ms.Stream;
                for (int i = 0; i < count; ++i)
                {
                    Write(stream, array[i]);
                }
            }
        }

        protected abstract IList<T> Create(int lenght);

        void ITypeSerialize.MergeFrom(ref object value, MonoStream ms)
        {
            int lenght = ms.Stream.ReadLength();
            var array = value as IList<T>;
            if (array == null || array.Count != lenght)
            {
                array = Create(lenght);
                value = array;
            }

            var stream = ms.Stream;
            for (int i = 0; i < lenght; ++i)
            {
                array[i] = Read(stream);
            }
        }

        protected abstract T Read(WRStream stream);
    }

    abstract class ArraySerialize<T> : IListSerialize<T>
    {
        protected override IList<T> Create(int lenght)
        {
            return new T[lenght];
        }
    }

    class ArrayIntType : ArraySerialize<int>
    {
        protected override int GetElementSize()
        {
            return 4;
        }

        protected override void Write(WRStream stream, int value)
        {
            stream.WriteInt32(value);
        }

        protected override int Read(WRStream stream)
        {
            return stream.ReadInt32();
        }
    }

    class ArrayUIntType : ArraySerialize<uint>
    {
        protected override int GetElementSize()
        {
            return 4;
        }

        protected override void Write(WRStream stream, uint value)
        {
            stream.WriteInt32(value);
        }

        protected override uint Read(WRStream stream)
        {
            return stream.ReadUInt32();
        }
    }

    class ArraySByteType : ArraySerialize<sbyte>
    {
        protected override int GetElementSize()
        {
            return 1;
        }

        protected override void Write(WRStream stream, sbyte value)
        {
            stream.WriteSByte(value);
        }

        protected override sbyte Read(WRStream stream)
        {
            return stream.ReadSByte();
        }
    }

    class ArrayByteType : ArraySerialize<byte>
    {
        protected override int GetElementSize()
        {
            return 1;
        }

        protected override void Write(WRStream stream, byte value)
        {
            stream.WriteByte(value);
        }

        protected override byte Read(WRStream stream)
        {
            return stream.ReadByte();
        }
    }

    class ArrayCharType : ArraySerialize<char>
    {
        protected override int GetElementSize()
        {
            return 2;
        }

        protected override void Write(WRStream stream, char value)
        {
            stream.WriteInt16(value);
        }

        protected override char Read(WRStream stream)
        {
            return (char)stream.ReadInt16();
        }
    }

    class ArrayShortType : ArraySerialize<short>
    {
        protected override int GetElementSize()
        {
            return 2;
        }

        protected override void Write(WRStream stream, short value)
        {
            stream.WriteInt16(value);
        }

        protected override short Read(WRStream stream)
        {
            return stream.ReadInt16();
        }
    }

    class ArrayUShortType : ArraySerialize<ushort>
    {
        protected override int GetElementSize()
        {
            return 2;
        }

        protected override void Write(WRStream stream, ushort value)
        {
            stream.WriteInt16(value);
        }

        protected override ushort Read(WRStream stream)
        {
            return stream.ReadUInt16();
        }
    }

    class ArrayFloatType : ArraySerialize<float>
    {
        protected override int GetElementSize()
        {
            return 4;
        }

        protected override void Write(WRStream stream, float value)
        {
            stream.WriteFloat(value);
        }

        protected override float Read(WRStream stream)
        {
            return stream.ReadFloat();
        }
    }

    class ArrayDoubleType : ArraySerialize<double>
    {
        protected override int GetElementSize()
        {
            return 8;
        }

        protected override void Write(WRStream stream, double value)
        {
            stream.WriteDouble(value);
        }

        protected override double Read(WRStream stream)
        {
            return stream.ReadDouble();
        }
    }

    class ArrayLongType : ArraySerialize<long>
    {
        protected override int GetElementSize()
        {
            return 8;
        }

        protected override void Write(WRStream stream, long value)
        {
            stream.WriteInt64(value);
        }

        protected override long Read(WRStream stream)
        {
            return stream.ReadInt64();
        }
    }

    class ArrayULongType : ArraySerialize<ulong>
    {
        protected override int GetElementSize()
        {
            return 8;
        }

        protected override void Write(WRStream stream, ulong value)
        {
            stream.WriteInt64(value);
        }

        protected override ulong Read(WRStream stream)
        {
            return stream.ReadUInt64();
        }
    }

    class ArrayStrType : ITypeSerialize
    {
        int ITypeSerialize.CalculateSize(object value)
        {
            var array = value as IList;
            if (array != null)
            {
                int total = WRStream.ComputeLengthSize(array.Count); // 长度

                // 长度+各个元素内容
                for (int i = 0; i <array.Count; ++i)
                {
                    total += WRStream.ComputeStringSize((string)array[i]);
                }
                return total;
            }

            return 0;
        }

        void ITypeSerialize.WriteTo(object value, MonoStream ms)
        {
            string[] array = value as string[];
            if (array != null)
            {
                ms.Stream.WriteLength(array.Length);
                var stream = ms.Stream;
                for (int i = 0; i < array.Length; ++i)
                {
                    stream.WriteString(array[i]);
                }
            }
        }

        void ITypeSerialize.MergeFrom(ref object value, MonoStream ms)
        {
            int lenght = ms.Stream.ReadLength();
            var array = value as string[];
            if (array == null || array.Length != lenght)
            {
                array = new string[lenght];
                value = array;
            }

            var stream = ms.Stream;
            for (int i = 0; i < lenght; ++i)
            {
                array[i] = stream.ReadString();
            }
        }
    }

    class ArrayObjectType : ITypeSerialize
    {
        int ITypeSerialize.CalculateSize(object value)
        {
            Object[] objs = value as Object[];
            if (objs == null)
                return 0;

            return WRStream.ComputeLengthSize(objs.Length) + objs.Length * 2;
        }

        void ITypeSerialize.WriteTo(object value, MonoStream ms)
        {
            Object[] array = (Object[])value;
            if (array == null)
                return;

            ms.Stream.WriteLength(array.Length);
            var stream = ms.Stream;
            for (int i = 0; i < array.Length; ++i)
            {
                stream.WriteInt16((short)ms.Add(array[i]));
            }
        }

        void ITypeSerialize.MergeFrom(ref object value, MonoStream ms)
        {
            int lenght = ms.Stream.ReadLength();
            var array = value as Object[];
            if (array == null || array.Length != lenght)
            {
                array = new Object[lenght];
                value = array;
            }

            var stream = ms.Stream;
            for (int i = 0; i < lenght; ++i)
            {
                short pos = stream.ReadInt16();
                if (pos == -1)
                    array[i] = null;
                else
                    array[i] = ms.objs[pos];
            }
        }
    }
}
