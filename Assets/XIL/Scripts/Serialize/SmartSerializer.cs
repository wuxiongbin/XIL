namespace wxb
{
    public class SmartSerializer : ITypeSerialize
    {
        public SmartSerializer(System.Type baseType, ITypeSerialize baseTypeSerialize)
        {
            this.baseType = baseType;
            this.baseTypeSerialize = baseTypeSerialize;
        }

        System.Type baseType;
        ITypeSerialize baseTypeSerialize;
        byte ITypeSerialize.typeFlag { get { return 0; } } // 类型标识

        void ITypeSerialize.WriteTo(object value, IStream ms)
        {
            if (value == null)
            {
                ms.WriteString(string.Empty);
                return;
            }

            var type = value.GetType();
            var serial = type == baseType ? baseTypeSerialize : BinarySerializable.GetByType(type);
            ms.WriteString(type.FullName);
            serial.WriteTo(value, ms);
        }

        void ITypeSerialize.MergeFrom(ref object value, IStream ms)
        {
            string fullName = ms.ReadString();
            if (string.IsNullOrEmpty(fullName))
                return;

            System.Type type;
            if (value == null || ((type = value.GetType()).FullName != fullName))
            {
                type = IL.Help.GetTypeByFullName(fullName);
                value = IL.Help.Create(type);
            }

            var serial = type == baseType ? baseTypeSerialize : BinarySerializable.GetByType(type);
            serial.MergeFrom(ref value, ms);
        }

        int ITypeSerialize.CalculateSize(object value)
        {
            if (value == null)
                return WRStream.ComputeStringSize(string.Empty);

            var type = value.GetType();
            var serial = type == baseType ? baseTypeSerialize : BinarySerializable.GetByType(type);

            var fullName = type.FullName;
            int total = WRStream.ComputeStringSize(fullName);
            return total + serial.CalculateSize(value);
        }
    }
}