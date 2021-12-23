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

            int size = WRStream.ComputeRawVarInt32Size(length);
            if (size != 1)
            {
                stream.WritePos = write_pos + 1;
                stream.MoveWritePos(size - 1, length);
                end_pos += (size - 1);
                stream.WritePos = write_pos;
            }

            stream.WriteVarInt32(length);
            stream.WritePos = end_pos;
        }

        public static int ReadLength(IStream stream)
        {
            return stream.ReadVarInt32();
        }

        // ÏÂÒ»¸ö×Ö¶Î
        public static void Next(IStream stream)
        {
            int count = ReadLength(stream);
            int endpos = stream.WritePos;
            stream.WritePos = stream.ReadPos + count;

            stream.ReadPos += count;
#if UNITY_EDITOR
            if (stream.ReadSize != 0)
                L.LogErrorFormat("IListAnyType stream.ReadSize != 0");
#endif
            stream.WritePos = endpos;
        }

        public static void MergeFrom(ITypeSerialize typeSerialize, IStream stream, ref object value)
        {
            int count = ReadLength(stream);
            int endpos = stream.WritePos;
            stream.WritePos = stream.ReadPos + count;
            try
            {
                typeSerialize.MergeFrom(ref value, stream);
#if UNITY_EDITOR
                if (stream.ReadSize != 0)
                {
                    L.LogErrorFormat("IListAnyType stream.ReadSize != 0");
                }
#endif
            }
            catch (System.Exception ex)
            {
                L.LogException(ex);
            }
            finally
            {
                stream.WritePos = endpos;
            }
        }

        public static void MergeFrom(IStream stream, System.Action<IStream> reader)
        {
            int count = ReadLength(stream);
            int endpos = stream.WritePos;
            stream.WritePos = stream.ReadPos + count;
            try
            {
                reader(stream);
            }
            catch (System.Exception ex)
            {
                L.LogException(ex);
            }
            finally
            {
                stream.WritePos = endpos;
            }
        }
    }
}