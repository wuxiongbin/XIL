using System.Reflection;
using System.Collections.Generic;
using UnityEditor;

namespace wxb
{
    class AnyRefTypeSerialize : ITypeSerialize
    {
        public static AnyRefTypeSerialize instance = new AnyRefTypeSerialize();

        public AnyRefTypeSerialize()
        {

        }

        byte ITypeSerialize.typeFlag { get { return TypeFlags.anyRefType; } } // 类型标识

        void ITypeSerialize.WriteTo(object value, IStream stream)
        {
            RefType refType = (RefType)value;
            if (refType == null || refType.Instance == null)
                return;

            var type = IL.Help.GetInstanceType(value);
            stream.WriteString(type.FullName);
            BinarySerializable.GetByType(type).WriteTo(value, stream);
        }

        void ITypeSerialize.MergeFrom(ref object value, IStream stream)
        {
            if (stream.ReadSize == 0)
            {
                value = null;
                return; // 没有需要初始化的数据
            }

            string fullName = stream.ReadString();           
            RefType refType = (RefType)value;
            if (refType == null || refType.Instance == null)
            {
                refType = new RefType(fullName);
                value = refType;
            }
            else
            {
                var type = IL.Help.GetInstanceType(refType.Instance);
                if (type.FullName != fullName)
                    refType.SetInstance(IL.Help.CreateInstaince(type, null));
            }

            var instance = refType.Instance;
            BinarySerializable.GetByInstance(instance).MergeFrom(ref instance, stream);
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
        public void WriteTo(object value, Nested.AnyBase ab)
        {
            RefType refType = (RefType)value;
            if (refType == null || refType.Instance == null)
            {
                ab.typeName = string.Empty;
                return;
            }

            var type = IL.Help.GetInstanceType(value);
            ab.typeName = type.FullName;
            BinarySerializable.GetByType(type).WriteTo(value, ab);
        }

        void ITypeSerialize.MergeFrom(ref object value, Nested.AnyBase ab)
        {
            string fullName = ab.typeName;
            if (string.IsNullOrEmpty(fullName))
            {
                value = null;
                return;
            }

            RefType refType = (RefType)value;
            if (refType == null || refType.Instance == null)
            {
                refType = new RefType(fullName);
                value = refType;
            }
            else
            {
                var type = IL.Help.GetInstanceType(refType.Instance);
                if (type.FullName != fullName)
                    refType.SetInstance(IL.Help.CreateInstaince(type, null));
            }

            var instance = refType.Instance;
            BinarySerializable.GetByInstance(instance).MergeFrom(ref instance, ab);
            refType.SetInstance(instance);
        }
#endif
    }
}
