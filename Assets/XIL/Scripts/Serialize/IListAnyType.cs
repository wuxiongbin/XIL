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

        int ITypeSerialize.CalculateSize(object value)
        {
            if (value == null)
                return 0;

            IList array = value as IList;

            int Count = array.Count;
            int total = WRStream.ComputeLengthSize(Count);
            total += 1;

            // 长度+各个元素内容
            for (int i = 0; i < Count; ++i)
            {
                int s = elementTypeSerialize.CalculateSize(array[i]);
                total += WRStream.ComputeLengthSize(s);
                total += s;
            }
            return total;
        }

        void ITypeSerialize.WriteTo(object value, IStream stream)
        {
            IList array = (IList)value;
            if (array == null)
                return;

            stream.WriteByte(elementTypeSerialize.typeFlag);
            stream.WriteLength(array.Count);
            object elementObj;
            for (int i = 0; i < array.Count; ++i)
            {
                elementObj = array[i];
                int count = elementTypeSerialize.CalculateSize(elementObj);
                stream.WriteLength(count);
                if (count != 0)
                {
                    elementTypeSerialize.WriteTo(elementObj, stream);
                }
            }
        }

        protected abstract IList Create(int lenght);

        void ITypeSerialize.MergeFrom(ref object value, IStream stream)
        {
            int flagType = stream.ReadByte();
            int lenght = stream.ReadLength();

            bool isTypeTrue = flagType == elementTypeSerialize.typeFlag; // 类型是否一致
            var array = value as IList;
            if (isTypeTrue && (array == null || array.Count != lenght))
            {
                array = Create(lenght);
                value = array;
            }

            for (int i = 0; i < lenght; ++i)
            {
                int count = stream.ReadLength();
                if (count != 0)
                {
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
                            stream.ReadPos += count;
                        }
                    }
                    catch (System.Exception ex)
                    {
                        wxb.L.LogException(ex);
                    }
                    finally
                    {
                        stream.WritePos = endpos;
                    }
                }
                else
                {
                    if (isTypeTrue)
                        array[i] = null;
                }
            }
        }
    }
}