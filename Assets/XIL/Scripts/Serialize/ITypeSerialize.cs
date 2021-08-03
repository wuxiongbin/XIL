namespace wxb
{
    public interface ITypeSerialize
    {
        byte typeFlag { get; } // 类型标识
        void WriteTo(object value, IStream ms);
        void MergeFrom(ref object value, IStream ms);
        bool IsEquals(object x, object y); // 判断两个值是否相等

#if !CloseNested // 关闭预置体嵌套支持
        void WriteTo(object value, Nested.AnyBase ab); // 把值写入到ab当中
        void MergeFrom(ref object value, Nested.AnyBase ab); // 通过ab来设置值
#endif
    }
}