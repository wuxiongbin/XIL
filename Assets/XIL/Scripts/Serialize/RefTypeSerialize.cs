using System.Reflection;
using System.Collections.Generic;
using UnityEditor;

namespace wxb
{
    class RefTypeSerialize : ITypeSerialize
    {
        public RefTypeSerialize(System.Type type)
        {
            this.type = type;
            typeSerialize = BinarySerializable.GetByType(type);
        }

        System.Type type;
        ITypeSerialize typeSerialize;

        byte ITypeSerialize.typeFlag { get { return TypeFlags.classType; } } // 类型标识

        void ITypeSerialize.WriteTo(object value, IStream stream)
        {
            RefType refType = (RefType)value;
            if (refType == null || refType.Instance == null)
                return ;

            typeSerialize.WriteTo(refType.Instance, stream);
        }

        public void MergeFrom(ref object value, IStream stream)
        {
            RefType refType = (RefType)value;
            if (refType == null)
            {
                refType = new RefType(type);
                value = refType;
            }

            var instance = refType.Instance;
            typeSerialize.MergeFrom(ref instance, stream);
            refType.SetInstance(instance);
        }
    }
}
