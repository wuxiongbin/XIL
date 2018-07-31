using UnityEngine;
using System.Reflection;
using System.Collections.Generic;

namespace wxb
{
    abstract class Serialize<T> : ITypeSerialize
    {
        int ITypeSerialize.CalculateSize(object value)
        {
            return CalculateSize((T)value);
        }

        protected abstract int CalculateSize(T value);

        protected abstract void Write(WRStream stream, T value);

        void ITypeSerialize.WriteTo(object obj, MonoStream ms)
        {
            T value = (T)obj;
            Write(ms.Stream, value);
        }

        void ITypeSerialize.MergeFrom(ref object value, MonoStream ms)
        {
            value = Read(ms.Stream);
        }

        protected abstract T Read(WRStream stream);
    }


    class IntType : Serialize<int>
    {
        protected override int CalculateSize(int value)
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

    class UIntType : Serialize<uint>
    {
        protected override int CalculateSize(uint value)
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

    class ByteType : Serialize<byte>
    {
        protected override int CalculateSize(byte value)
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

    class sByteType : Serialize<sbyte>
    {
        protected override int CalculateSize(sbyte value)
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

    class CharType : Serialize<char>
    {
        protected override int CalculateSize(char value)
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

    class ShortType : Serialize<short>
    {
        protected override int CalculateSize(short value)
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

    class UShortType : Serialize<ushort>
    {
        protected override int CalculateSize(ushort value)
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

    class FloatType : Serialize<float>
    {
        protected override int CalculateSize(float value)
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

    class DoubleType : Serialize<double>
    {
        protected override int CalculateSize(double value)
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

    class LongType : Serialize<long>
    {
        protected override int CalculateSize(long value)
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

    class ULongType : Serialize<ulong>
    {
        protected override int CalculateSize(ulong value)
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

    class StrType : Serialize<string>
    {
        protected override int CalculateSize(string value)
        {
            return WRStream.ComputeStringSize(value);
        }

        protected override void Write(WRStream stream, string value)
        {
            stream.WriteString(value);
        }

        protected override string Read(WRStream stream)
        {
            return stream.ReadString();
        }
    }

    class ObjectType : ITypeSerialize
    {
        int ITypeSerialize.CalculateSize(object value)
        {
            if (value == null)
                return 0;

            return 2;
        }

        void ITypeSerialize.WriteTo(object value, MonoStream ms)
        {
            if (value == null)
                return;

            ms.Stream.WriteInt16((short)ms.Add((Object)value));
        }

        void ITypeSerialize.MergeFrom(ref object parent, MonoStream ms)
        {
            var pos = ms.Stream.ReadInt16();
            parent = ms.objs[pos];
        }
    }
}
