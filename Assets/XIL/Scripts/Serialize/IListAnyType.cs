using System.Collections;

namespace wxb
{
    abstract class IListAnyType : ITypeSerialize
    {
        protected ITypeSerialize elementTypeSerialize;

        protected bool isSmartType = false; // 数组是否保存一样的类型

        public IListAnyType(ITypeSerialize elementTypeSerialize)
        {
            this.elementTypeSerialize = elementTypeSerialize;
        }

        public IListAnyType()
        {

        }

        byte ITypeSerialize.typeFlag { get { return TypeFlags.arrayType; } } // 数组标识

        void ITypeSerialize.WriteTo(object value, IStream stream)
        {
            IList array = (IList)value;
            if (array == null)
            {
                stream.WriteByte(0);
                return;
            }

            stream.WriteByte(1);
            stream.WriteByte(elementTypeSerialize.typeFlag);
            int cnt = array.Count;
            stream.WriteVarInt32(cnt);
            object elementObj;
            for (int i = 0; i < cnt; ++i)
            {
                elementObj = array[i];
                using (new RLStream(stream))
                {
                    elementTypeSerialize.WriteTo(elementObj, stream);
                }
            }
        }

        protected abstract IList Create(int lenght);

        void ITypeSerialize.MergeFrom(ref object value, IStream stream)
        {
            byte flag = stream.ReadByte();
            if (flag == 0)
            {
                value = null;
                return;
            }

            byte flagType = stream.ReadByte();
            int lenght = stream.ReadVarInt32();

            bool isTypeTrue = flagType == elementTypeSerialize.typeFlag; // 类型是否一致
            var array = value as IList;
            if (isTypeTrue && (array == null || array.Count != lenght))
            {
                array = Create(lenght);
                value = array;
            }

            if (isTypeTrue)
            {
                for (int i = 0; i < lenght; ++i)
                {
                    object v = array[i];
                    RLStream.MergeFrom(elementTypeSerialize, stream, ref v);
                    try
                    {
                        array[i] = v;
                    }
                    catch (System.Exception ex)
                    {
                        Log.Exception(ex);
                    }
                }
            }
            else
            {
                for (int i = 0; i < lenght; ++i)
                {
                    RLStream.Next(stream);
                }
            }
        }

        // 判断两个值是否相等
        bool ITypeSerialize.IsEquals(object x, object y)
        {
            var xlist = (IList)x;
            var ylist = (IList)y;
            int count = xlist.Count;
            if (count != ylist.Count)
                return false;

            for (int i = 0; i < count; ++i)
            {
                if (!BinarySerializable.IsEquip(xlist[i], ylist[i]))
                    return false;
            }

            return true;
        }

#if !CloseNested
        // 把值写入到ab当中
        void ITypeSerialize.WriteTo(object value, Nested.AnyBase ab)
        {
            IList array = (IList)value;
            if (array == null)
            {
                ab.valueType = 0;
                return;
            }

            ab.valueType = 1;
            ab.elementTypeFlags = elementTypeSerialize.typeFlag;
            object elementObj;
            int cnt = array.Count;
            ab.listCount = cnt;
            for (int i = 0; i < cnt; ++i)
            {
                elementObj = array[i];
                var cts = ab.Create($"[{i}]", elementTypeSerialize.typeFlag);
                elementTypeSerialize.WriteTo(elementObj, cts);
            }
        }

        // 通过ab来设置值
        void ITypeSerialize.MergeFrom(ref object value, Nested.AnyBase ab)
        {
            byte flag = ab.valueType;
            if (flag == 0)
            {
                value = null;
                return;
            }

            bool isTypeTrue = ab.elementTypeFlags == elementTypeSerialize.typeFlag; // 类型是否一致
            var array = value as IList;
            int length = ab.listCount;
            if (isTypeTrue && (array == null || array.Count != length))
            {
                array = Create(length);
                value = array;
            }

            if (isTypeTrue)
            {
                for (int i = 0; i < length; ++i)
                {
                    object v = array[i];

                    ab.Get($"[{i}]", out var vv);
                    elementTypeSerialize.MergeFrom(ref v, vv);

                    try
                    {
                        array[i] = v;
                    }
                    catch (System.Exception /*ex*/)
                    {

                    }
                }
            }
        }
#endif
    }
}