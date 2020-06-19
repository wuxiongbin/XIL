namespace wxb
{
    public class SmartSerializer : ITypeSerialize
    {
        byte ITypeSerialize.typeFlag { get { return 0; } } // 类型标识

        void ITypeSerialize.WriteTo(object value, IStream ms)
        {
            if (value == null)
                return;

            var type = value.GetType();
            var serial = BinarySerializable.GetByType(type);
            ms.WriteString(type.FullName);
            serial.WriteTo(value, ms);
        }

        void ITypeSerialize.MergeFrom(ref object value, IStream ms)
        {
            string fullName = ms.ReadString();
            System.Type type;
            if (value == null || ((type = value.GetType()).FullName != fullName))
            {
                type = IL.Help.GetTypeByFullName(fullName);
                value = IL.Help.Create(type);
            }

            var serial = BinarySerializable.GetByType(type);
            serial.MergeFrom(ref value, ms);
        }

        int ITypeSerialize.CalculateSize(object value)
        {
            if (value == null)
                return 0;

            var type = value.GetType();
            var serial = BinarySerializable.GetByType(type);

            var fullName = type.FullName;
            int total = WRStream.ComputeStringSize(fullName);
            return total + serial.CalculateSize(value);
        }
    }
}