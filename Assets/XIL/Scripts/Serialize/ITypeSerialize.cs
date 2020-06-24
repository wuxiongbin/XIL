namespace wxb
{
    public interface ITypeSerialize
    {
        byte typeFlag { get; } // 类型标识
        void WriteTo(object value, IStream ms);
        void MergeFrom(ref object value, IStream ms);
        bool IsEquals(object x, object y); // 判断两个值是否相等
    }
}