namespace wxb
{
    public partial class WRStream
    {
        public static int ComputeRawVarInt32Size(int length)
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
                            throw new System.Exception("CodedInputStream encountered a malformed varint.");
                        }
                    }
                }
            }
            return (uint)result;
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

        internal void WriteRawVarint64(ulong value)
        {
            while (value > 127)
            {
                ensureCapacity(1);
                mBuffer[mWritePos++] = (byte)((value & 0x7F) | 0x80);
                value >>= 7;
            }

            ensureCapacity(1);
            mBuffer[mWritePos++] = (byte)value;
        }

        internal ulong ReadRawVarint64()
        {
            int shift = 0;
            ulong result = 0;
            while (shift < 64)
            {
                byte b = ReadRawByte();
                result |= (ulong)(b & 0x7F) << shift;
                if ((b & 0x80) == 0)
                {
                    return result;
                }
                shift += 7;
            }

            throw new System.Exception("CodedInputStream encountered a malformed varint.");
        }
    }
}