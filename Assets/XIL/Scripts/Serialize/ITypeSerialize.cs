namespace wxb
{
    public interface ITypeSerialize
    {
        byte typeFlag { get; } // 类型标识
        void WriteTo(object value, IStream ms);
        void MergeFrom(ref object value, IStream ms);
        int CalculateSize(object value);
    }

    public class NullTypeSerialize : ITypeSerialize
    {
        static NullTypeSerialize nullTypeSerialize = new NullTypeSerialize();
        public static ITypeSerialize instance { get { return nullTypeSerialize; } }

        // 类型标识
        byte ITypeSerialize.typeFlag { get { return 250; } }

        void ITypeSerialize.WriteTo(object value, IStream ms)
        {

        }

        void ITypeSerialize.MergeFrom(ref object value, IStream ms)
        {
            value = null;
        }

        int ITypeSerialize.CalculateSize(object value)
        {
            return 0;
        }
    }
}