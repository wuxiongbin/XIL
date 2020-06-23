namespace wxb
{
    public interface IStream
    {
        int WritePos { get; set; }
        int ReadPos { get; set; }
        int WriteRemain { get; }
        int ReadSize { get; }

        void WriteLength(int value);
        int ReadLength();

        void WriteInt32(int value);
        int ReadInt32();

        void WriteUInt32(uint value);
        uint ReadUInt32();

        void WriteSByte(sbyte value);
        sbyte ReadSByte();

        void WriteByte(byte value);
        byte ReadByte();

        void WriteChar(char value);
        char ReadChar();

        void WriteLong(long value);
        long ReadLong();

        void WriteULong(ulong value);
        ulong ReadULong();

        void WriteShort(short value);
        short ReadShort();

        void WriteUShort(ushort value);
        ushort ReadUShort();

        void WriteFloat(float value);
        float ReadFloat();

        void WriteDouble(double value);
        double ReadDouble();

        void WriteString(string value);
        string ReadString();
        void WriteUnityObject(UnityEngine.Object obj);
        UnityEngine.Object ReadUnityObject();

        byte[] GetBytes();

        // 以WritePos位置为参数，移动当前数据块
        void MoveWritePos(int offset, int count);
    }
}