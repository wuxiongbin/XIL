using UnityEngine;
using System.Reflection;
using System.Collections.Generic;

namespace wxb
{
    // 枚举类型
    class EnumStringTypeSerialize : ITypeSerialize
    {
        public EnumStringTypeSerialize(System.Type type)
        {
            enumType = type;
        }

        System.Type enumType;

        byte ITypeSerialize.typeFlag { get { return TypeFlags.enumStringType; } } // 类型标识

        void ITypeSerialize.WriteTo(object obj, IStream ms)
        {
            ms.WriteString(obj.ToString());
        }

        void ITypeSerialize.MergeFrom(ref object value, IStream ms)
        {
            var text = ms.ReadString();
            value = Str2Enum.To(text, enumType);
        }

        // 判断两个值是否相等
        bool ITypeSerialize.IsEquals(object x, object y)
        {
            return ((int)x) == ((int)y);
        }

#if !CloseNested
        // 把值写入到ab当中
        void ITypeSerialize.WriteTo(object value, Nested.AnyBase ab)
        {
            ab.baseValue = value.ToString();
        }

        // 通过ab来设置值
        void ITypeSerialize.MergeFrom(ref object value, Nested.AnyBase ab)
        {
            value = Str2Enum.To(ab.baseValue, enumType);
        }
#endif
    }
}
