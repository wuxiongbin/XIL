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
        byte ITypeSerialize.typeFlag { get { return TypeFlags.smartType; } } // 类型标识

        void ITypeSerialize.WriteTo(object value, IStream ms)
        {
            if (value == null)
            {
                ms.WriteString(string.Empty);
                return;
            }

            var type = IL.Help.GetInstanceType(value);
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
            if (value == null || ((type = IL.Help.GetInstanceType(value)).FullName != fullName))
            {
                if (IL.Help.TryGetTypeByFullName(fullName, out type))
                    value = IL.Help.Create(type);
            }

            var serial = type == baseType ? baseTypeSerialize : BinarySerializable.GetByType(type);
            serial.MergeFrom(ref value, ms);
        }
    }
}