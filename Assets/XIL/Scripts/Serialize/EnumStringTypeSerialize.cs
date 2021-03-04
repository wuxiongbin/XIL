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
    }
}
