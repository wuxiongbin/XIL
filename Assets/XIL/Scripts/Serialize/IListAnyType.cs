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
            stream.WriteVarInt32(array.Count);
            object elementObj;
            for (int i = 0; i < array.Count; ++i)
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

            for (int i = 0; i < lenght; ++i)
            {
                int count = RLStream.ReadLength(stream);
                int endpos = stream.WritePos;
                stream.WritePos = stream.ReadPos + count;
                try
                {
                    if (isTypeTrue)
                    {
                        object v = array[i];
                        elementTypeSerialize.MergeFrom(ref v, stream);
                        array[i] = v;
                    }
                    else
                    {
#if UNITY_EDITOR
                        if (stream.ReadSize != 0)
                        {
                            L.LogErrorFormat("IListAnyType stream.ReadSize != 0");
                        }
#endif
                        stream.ReadPos += count;
                    }
                }
                catch (System.Exception ex)
                {
                    L.LogException(ex);
                }
                finally
                {
                    stream.WritePos = endpos;
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
    }
}