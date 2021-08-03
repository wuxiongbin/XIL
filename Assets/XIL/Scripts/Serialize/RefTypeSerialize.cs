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

        void ITypeSerialize.MergeFrom(ref object value, IStream stream)
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

        // 判断两个值是否相等
        bool ITypeSerialize.IsEquals(object x, object y)
        {
            RefType xValue = (RefType)x;
            RefType yValue = (RefType)y;

            return BinarySerializable.IsEquip(xValue.Instance, yValue.Instance);
        }

#if !CloseNested
        // 把值写入到ab当中
        void ITypeSerialize.WriteTo(object value, Nested.AnyBase ab)
        {
            RefType refType = (RefType)value;
            if (refType == null || refType.Instance == null)
                return;

            typeSerialize.WriteTo(refType.Instance, ab);
        }

        // 通过ab来设置值
        void ITypeSerialize.MergeFrom(ref object value, Nested.AnyBase ab)
        {
            RefType refType = (RefType)value;
            if (refType == null)
            {
                refType = new RefType(type);
                value = refType;
            }

            var instance = refType.Instance;
            typeSerialize.MergeFrom(ref instance, ab);
            refType.SetInstance(instance);
        }
#endif
    }
}
