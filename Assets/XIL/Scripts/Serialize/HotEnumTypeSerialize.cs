#if USE_ILRT
using UnityEngine;
using System.Reflection;
using System.Collections.Generic;

namespace wxb
{
    // 枚举类型
    class HotEnumTypeSerialize : ITypeSerialize
    {
        public HotEnumTypeSerialize(ILRuntime.Reflection.ILRuntimeType type)
        {
            enumType = type;
        }

        ILRuntime.Reflection.ILRuntimeType enumType;

        byte ITypeSerialize.typeFlag { get { return TypeFlags.enumType; } } // 类型标识

        void ITypeSerialize.WriteTo(object obj, IStream ms)
        {
            ms.WriteVarInt32((int)obj);
        }

        void ITypeSerialize.MergeFrom(ref object value, IStream ms)
        {
            int id = ms.ReadVarInt32();
            value = id;
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
            ab.baseValue = ((int)value).ToString();
        }
        void ITypeSerialize.MergeFrom(ref object value, Nested.AnyBase ab)
        {
            value = int.Parse(ab.baseValue);
        }
#endif
    }
}
#endif