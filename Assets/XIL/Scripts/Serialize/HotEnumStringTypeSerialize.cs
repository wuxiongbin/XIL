#if USE_ILRT
using UnityEngine;
using System.Reflection;
using System.Collections.Generic;

namespace wxb
{
    // 枚举类型
    class HotEnumStringTypeSerialize : ITypeSerialize
    {
        public HotEnumStringTypeSerialize(ILRuntime.Reflection.ILRuntimeType type)
        {
            enumType = type;
        }

        ILRuntime.Reflection.ILRuntimeType enumType;

        byte ITypeSerialize.typeFlag { get { return TypeFlags.enumStringType; } } // 类型标识

        void ITypeSerialize.WriteTo(object obj, IStream ms)
        {
            ms.WriteString(Str2Enum.GetEnumStr(obj, enumType));
        }

        void ITypeSerialize.MergeFrom(ref object value, IStream ms)
        {
            string enumStr = ms.ReadString();
            value = Str2Enum.To(enumStr, enumType);
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
            ab.baseValue = Str2Enum.GetEnumStr(value, enumType);
        }

        // 通过ab来设置值
        void ITypeSerialize.MergeFrom(ref object value, Nested.AnyBase ab)
        {
            value = Str2Enum.To(ab.baseValue, enumType);
        }
#endif
    }
}
#endif