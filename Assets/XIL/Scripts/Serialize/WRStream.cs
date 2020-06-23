namespace wxb
{
    public struct RLStream : System.IDisposable
    {
        public RLStream(IStream stream)
        {
            this.stream = stream;
            write_pos = stream.WritePos;
            stream.WritePos = write_pos + 1;
        }

        IStream stream;
        int write_pos;

        void System.IDisposable.Dispose()
        {
            int end_pos = stream.WritePos;
            stream.WritePos = write_pos;
            int length = end_pos - write_pos - 1;

            int size = WRStream.ComputeLengthSize(length);
            if (size != 1)
            {
                stream.WritePos = write_pos + 1;
                stream.MoveWritePos(size - 1, length);
                end_pos += (size - 1);
                stream.WritePos = write_pos;
            }

            stream.WriteLength(length);
            stream.WritePos = end_pos;
        }

        public static int ReadLength(IStream stream)
        {
            return stream.ReadLength();
        }
    }

    public class WRStream : IStream
    {
        public static int ComputeLengthSize(int length)
        {
            return ComputeRawVarint32Size((uint)length);
        }

        /// <summary>
        /// Computes the number of bytes that would be needed to encode a varint.
        /// </summary>
        public static int ComputeRawVarint32Size(uint value)
        {
            if ((value & (0xffffffff << 7)) == 0)
            {
                return 1;
            }
            if ((value & (0xffffffff << 14)) == 0)
            {
                return 2;
            }
            if ((value & (0xffffffff << 21)) == 0)
            {
                return 3;
            }
            if ((value & (0xffffffff << 28)) == 0)
            {
                return 4;
            }
            return 5;
        }

        public static int ComputeStringSize(string value)
        {
            int byteArraySize = value == null ? 0 : Utf8Encoding.GetByteCount(value);
            return ComputeLengthSize(byteArraySize) + byteArraySize;
        }

        public int WriteRemain { get { return mSize - mWritePos; } }
        public int ReadPos { get { return mReadPos; } set { mReadPos = value; } }
        public int WritePos { get { return mWritePos; } set { mWritePos = value; } }

        // 还可读取的大小
        public int ReadSize { get { return WritePos - ReadPos; } }

        protected int mSize = 0;
        protected byte[] mBuffer; // 缓存
        protected int mReadPos = 0; // 当前读取的位置
        protected int mWritePos = 0; // 当前写入的位置

        public int size { get { return mSize; } }

        public WRStream(int size)
        {
            mSize = size;
            mBuffer = new byte[mSize];
        }

        public WRStream(byte[] bytes)
        {
            mSize = bytes.Length;
            mBuffer = bytes;
        }

        public byte[] GetBytes()
        {
            byte[] bytes = new byte[WritePos - ReadPos];
            System.Array.Copy(mBuffer, ReadPos, bytes, 0, bytes.Length);
            return bytes;
        }

        public void ensureCapacity(int length)
        {
            if (length > WriteRemain)
            {
                int newsize = (length + mSize) > (mSize * 2) ? (length + mSize) : (mSize * 2);

                try
                {
                    System.Array.Resize<byte>(ref mBuffer, newsize);
                    mSize = newsize;
                }
                catch (System.OutOfMemoryException ex)
                {
                    wxb.L.LogErrorFormat("size:{0} newSize:{1}", mSize, newsize);
                    throw ex;
                }
            }
        }

        void CheckReadSize(int size)
        {
            if (mReadPos + size > mWritePos)
            {
                throw new System.IndexOutOfRangeException(
                    "CodedInputStream encountered an embedded string or message which claimed to have negative size.");
            }
        }

        internal static readonly System.Text.Encoding Utf8Encoding = System.Text.Encoding.UTF8;

        public void WriteLength(int length)
        {
            WriteRawVarint32((uint)length);
        }

        internal void WriteRawVarint32(uint value)
        {
            // Optimize for the common case of a single byte value
            if (value < 128)
            {
                ensureCapacity(1);
                mBuffer[mWritePos++] = (byte)value;
                return;
            }

            while (value > 127)
            {
                ensureCapacity(1);
                mBuffer[mWritePos++] = (byte)((value & 0x7F) | 0x80);
                value >>= 7;
            }

            ensureCapacity(1);
            mBuffer[mWritePos++] = (byte)value;
        }

        public int ReadLength()
        {
            return (int)ReadRawVarint32();
        }

        internal byte ReadRawByte()
        {
            CheckReadSize(1);
            return mBuffer[mReadPos++];
        }

        private uint SlowReadRawVarint32()
        {
            int tmp = ReadRawByte();
            if (tmp < 128)
            {
                return (uint)tmp;
            }
            int result = tmp & 0x7f;
            if ((tmp = ReadRawByte()) < 128)
            {
                result |= tmp << 7;
            }
            else
            {
                result |= (tmp & 0x7f) << 7;
                if ((tmp = ReadRawByte()) < 128)
                {
                    result |= tmp << 14;
                }
                else
                {
                    result |= (tmp & 0x7f) << 14;
                    if ((tmp = ReadRawByte()) < 128)
                    {
                        result |= tmp << 21;
                    }
                    else
                    {
                        result |= (tmp & 0x7f) << 21;
                        result |= (tmp = ReadRawByte()) << 28;
                        if (tmp >= 128)
                        {
                            // Discard upper 32 bits.
                            for (int i = 0; i < 5; i++)
                            {
                                if (ReadRawByte() < 128)
                                {
                                    return (uint)result;
                                }
                            }
                            throw new System.Exception("MalformedVarint");
                        }
                    }
                }
            }
            return (uint)result;
        }

        internal uint ReadRawVarint32()
        {
            if (ReadSize < 5)
            {
                return SlowReadRawVarint32();
            }

            int tmp = mBuffer[mReadPos++];
            if (tmp < 128)
            {
                return (uint)tmp;
            }
            int result = tmp & 0x7f;
            if ((tmp = mBuffer[mReadPos++]) < 128)
            {
                result |= tmp << 7;
            }
            else
            {
                result |= (tmp & 0x7f) << 7;
                if ((tmp = mBuffer[mReadPos++]) < 128)
                {
                    result |= tmp << 14;
                }
                else
                {
                    result |= (tmp & 0x7f) << 14;
                    if ((tmp = mBuffer[mReadPos++]) < 128)
                    {
                        result |= tmp << 21;
                    }
                    else
                    {
                        result |= (tmp & 0x7f) << 21;
                        result |= (tmp = mBuffer[mReadPos++]) << 28;
                        if (tmp >= 128)
                        {
                            // Discard upper 32 bits.
                            // Note that this has to use ReadRawByte() as we only ensure we've
                            // got at least 5 bytes at the start of the method. This lets us
                            // use the fast path in more cases, and we rarely hit this section of code.
                            for (int i = 0; i < 5; i++)
                            {
                                if (ReadRawByte() < 128)
                                {
                                    return (uint)result;
                                }
                            }
                            throw new System.Exception("MalformedVarint");
                        }
                    }
                }
            }
            return (uint)result;
        }

        public void WriteString(string value)
        {
            if (value == null)
            {
                WriteLength(0);
            }
            else
            {
                int length = Utf8Encoding.GetByteCount(value);
                WriteLength(length);
                ensureCapacity(length);

                if (length == value.Length) // Must be all ASCII...
                {
                    for (int i = 0; i < length; i++)
                    {
                        mBuffer[mWritePos + i] = (byte)value[i];
                    }
                }
                else
                {
                    Utf8Encoding.GetBytes(value, 0, value.Length, mBuffer, mWritePos);
                }
                mWritePos += length;
            }
        }

        public string ReadString()
        {
            int length = ReadLength();
            // No need to read any data for an empty string.
            if (length == 0)
            {
                return "";
            }

            CheckReadSize(length);

            // Fast path:  We already have the bytes in a contiguous buffer, so
            //   just copy directly from it.
            string result = Utf8Encoding.GetString(mBuffer, mReadPos, length);
            mReadPos += length;
            return result;
        }

        public void WriteSByte(sbyte value)
        {
            ensureCapacity(1);
            mBuffer[mWritePos++] = (byte)value;
        }

        public sbyte ReadSByte()
        {
            CheckReadSize(1);
            return (sbyte)mBuffer[mReadPos++];
        }

        public void WriteByte(byte value)
        {
            ensureCapacity(1);
            mBuffer[mWritePos++] = value;
        }

        public byte ReadByte()
        {
            CheckReadSize(1);
            return mBuffer[mReadPos++];
        }

        public void WriteChar(char value)
        {
            ensureCapacity(2);

            mBuffer[mWritePos++] = ((byte)value);
            mBuffer[mWritePos++] = ((byte)(value >> 8));
        }

        public char ReadChar()
        {
            CheckReadSize(2);
            byte b1 = mBuffer[mReadPos++];
            byte b2 = mBuffer[mReadPos++];
            return (char)(b1 | (b2 << 8));
        }

        public void WriteShort(short value)
        {
            ensureCapacity(2);
            mBuffer[mWritePos++] = ((byte)value);
            mBuffer[mWritePos++] = ((byte)(value >> 8));
        }

        public short ReadShort()
        {
            CheckReadSize(2);
            byte b1 = mBuffer[mReadPos++];
            byte b2 = mBuffer[mReadPos++];
            return (short)(b1 | (b2 << 8));
        }

        public void WriteUShort(ushort value)
        {
            ensureCapacity(2);
            mBuffer[mWritePos++] = ((byte)value);
            mBuffer[mWritePos++] = ((byte)(value >> 8));
        }

        public ushort ReadUShort()
        {
            CheckReadSize(2);
            byte b1 = mBuffer[mReadPos++];
            byte b2 = mBuffer[mReadPos++];
            return (ushort)(b1 | (b2 << 8));
        }

        public void WriteInt32(int value)
        {
            ensureCapacity(4);

            mBuffer[mWritePos++] = ((byte)value);
            mBuffer[mWritePos++] = ((byte)(value >> 8));
            mBuffer[mWritePos++] = ((byte)(value >> 16));
            mBuffer[mWritePos++] = ((byte)(value >> 24));
        }

        public int ReadInt32()
        {
            CheckReadSize(4);
            int b1 = mBuffer[mReadPos++];
            int b2 = mBuffer[mReadPos++];
            int b3 = mBuffer[mReadPos++];
            int b4 = mBuffer[mReadPos++];
            return b1 | (b2 << 8) | (b3 << 16) | (b4 << 24);
        }

        public void WriteUInt32(uint value)
        {
            ensureCapacity(4);

            mBuffer[mWritePos++] = ((byte)value);
            mBuffer[mWritePos++] = ((byte)(value >> 8));
            mBuffer[mWritePos++] = ((byte)(value >> 16));
            mBuffer[mWritePos++] = ((byte)(value >> 24));
        }

        public uint ReadUInt32()
        {
            CheckReadSize(4);
            uint b1 = mBuffer[mReadPos++];
            uint b2 = mBuffer[mReadPos++];
            uint b3 = mBuffer[mReadPos++];
            uint b4 = mBuffer[mReadPos++];
            return b1 | (b2 << 8) | (b3 << 16) | (b4 << 24);
        }

        public void WriteLong(long value)
        {
            ensureCapacity(8);

            mBuffer[mWritePos++] = ((byte)value);
            mBuffer[mWritePos++] = ((byte)(value >> 8));
            mBuffer[mWritePos++] = ((byte)(value >> 16));
            mBuffer[mWritePos++] = ((byte)(value >> 24));
            mBuffer[mWritePos++] = ((byte)(value >> 32));
            mBuffer[mWritePos++] = ((byte)(value >> 40));
            mBuffer[mWritePos++] = ((byte)(value >> 48));
            mBuffer[mWritePos++] = ((byte)(value >> 56));
        }

        public long ReadLong()
        {
            CheckReadSize(8);

            long b1 = mBuffer[mReadPos++];
            long b2 = mBuffer[mReadPos++];
            long b3 = mBuffer[mReadPos++];
            long b4 = mBuffer[mReadPos++];
            long b5 = mBuffer[mReadPos++];
            long b6 = mBuffer[mReadPos++];
            long b7 = mBuffer[mReadPos++];
            long b8 = mBuffer[mReadPos++];

            return b1 | (b2 << 8) | (b3 << 16) | (b4 << 24)
                   | (b5 << 32) | (b6 << 40) | (b7 << 48) | (b8 << 56);
        }

        public void WriteULong(ulong value)
        {
            ensureCapacity(8);

            mBuffer[mWritePos++] = ((byte)value);
            mBuffer[mWritePos++] = ((byte)(value >> 8));
            mBuffer[mWritePos++] = ((byte)(value >> 16));
            mBuffer[mWritePos++] = ((byte)(value >> 24));
            mBuffer[mWritePos++] = ((byte)(value >> 32));
            mBuffer[mWritePos++] = ((byte)(value >> 40));
            mBuffer[mWritePos++] = ((byte)(value >> 48));
            mBuffer[mWritePos++] = ((byte)(value >> 56));
        }

        public ulong ReadULong()
        {
            CheckReadSize(8);

            ulong b1 = mBuffer[mReadPos++];
            ulong b2 = mBuffer[mReadPos++];
            ulong b3 = mBuffer[mReadPos++];
            ulong b4 = mBuffer[mReadPos++];
            ulong b5 = mBuffer[mReadPos++];
            ulong b6 = mBuffer[mReadPos++];
            ulong b7 = mBuffer[mReadPos++];
            ulong b8 = mBuffer[mReadPos++];

            return b1 | (b2 << 8) | (b3 << 16) | (b4 << 24)
                   | (b5 << 32) | (b6 << 40) | (b7 << 48) | (b8 << 56);
        }

        static void Reverse(byte[] bytes)
        {
            for (int first = 0, last = bytes.Length - 1; first < last; first++, last--)
            {
                byte temp = bytes[first];
                bytes[first] = bytes[last];
                bytes[last] = temp;
            }
        }

        static void Copy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count)
        {
            if (count > 12)
            {
                System.Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
            }
            else
            {
                int stop = srcOffset + count;
                for (int i = srcOffset; i < stop; i++)
                {
                    dst[dstOffset++] = src[i];
                }
            }
        }

        internal void WriteRawBytes(byte[] value, int offset, int length)
        {
            ensureCapacity(length);
            Copy(value, offset, mBuffer, mWritePos, length);
            mWritePos += length;
        }

        public void WriteFloat(float value)
        {
            byte[] rawBytes = System.BitConverter.GetBytes(value);
            if (!System.BitConverter.IsLittleEndian)
            {
                Reverse(rawBytes);
            }

            WriteRawBytes(rawBytes, 0, 4);
        }

        internal byte[] ReadRawBytes(int size)
        {
            if (size < 0)
            {
                throw new System.Exception("InvalidProtocolBufferException.NegativeSize");
            }
            else if (size == 0)
            {
                return new byte[0];
            }

            CheckReadSize(size);

            byte[] bytes = new byte[size];
            Copy(mBuffer, mReadPos, bytes, 0, size);
            mReadPos += size;
            return bytes;
        }

        public float ReadFloat()
        {
            CheckReadSize(4);

            if (System.BitConverter.IsLittleEndian)
            {
                float ret = System.BitConverter.ToSingle(mBuffer, mReadPos);
                mReadPos += 4;
                return ret;
            }
            else
            {
                byte[] rawBytes = ReadRawBytes(4);
                if (!System.BitConverter.IsLittleEndian)
                {
                    Reverse(rawBytes);
                }
                return System.BitConverter.ToSingle(rawBytes, 0);
            }
        }

        public void WriteDouble(double value)
        {
            WriteLong(System.BitConverter.DoubleToInt64Bits(value));
        }

        public double ReadDouble()
        {
            return System.BitConverter.Int64BitsToDouble(ReadLong());
        }

        public virtual void WriteUnityObject(UnityEngine.Object obj)
        {
            throw new System.Exception("WriteUnityObject");
        }

        public virtual UnityEngine.Object ReadUnityObject()
        {
            throw new System.Exception("ReadUnityObject");
        }

        // 以WritePos位置为参数，移动当前数据块
        public void MoveWritePos(int offset, int count)
        {
            System.Array.Copy(mBuffer, WritePos, mBuffer, WritePos + offset, count);
        }
    }
}