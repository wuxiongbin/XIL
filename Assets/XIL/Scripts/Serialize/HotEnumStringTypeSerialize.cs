#if USE_HOT
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
    }
}
#endif