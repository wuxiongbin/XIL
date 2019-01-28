using UnityEngine;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace wxb
{
    abstract class IListAnyType : ITypeSerialize
    {
        protected System.Type arrayType;
        protected System.Type elementType;
        protected ITypeSerialize elementTypeSerialize;

        public IListAnyType(System.Type arrayType, System.Type elementType)
        {
            this.arrayType = arrayType;
            this.elementType = elementType;
            elementTypeSerialize = MonoSerialize.GetByType(elementType);
        }

        int ITypeSerialize.CalculateSize(object value)
        {
            if (value == null)
                return 0;

            IList array = value as IList;
            int total = WRStream.ComputeLengthSize(array.Count);
            // 长度+各个元素内容
            for (int i = 0; i < array.Count; ++i)
            {
                int s = elementTypeSerialize.CalculateSize(array[i]);
                total += WRStream.ComputeLengthSize(s);
                total += s;
            }

            return total;
        }

        void ITypeSerialize.WriteTo(object value, MonoStream ms)
        {
            IList array = (IList)value;
            if (array == null)
                return;

            var stream = ms.Stream;
            stream.WriteLength(array.Count);
            for (int i = 0; i < array.Count; ++i)
            {
                int count = elementTypeSerialize.CalculateSize(array[i]);
                stream.WriteLength(count);
                if (count != 0)
                {
                    elementTypeSerialize.WriteTo(array[i], ms);
                }
            }
        }

        protected abstract IList Create(int lenght);

        void ITypeSerialize.MergeFrom(ref object value, MonoStream ms)
        {
            var stream = ms.Stream;
            int lenght = stream.ReadLength();
            var array = value as IList;
            if (array == null || array.Count != lenght)
            {
                array = Create(lenght);
                value = array;
            }

            for (int i = 0; i < lenght; ++i)
            {
                object v = array[i];
                int count = stream.ReadLength();
                if (count != 0)
                {
                    int endpos = stream.WritePos;
                    stream.WritePos = stream.ReadPos + count;
                    try
                    {
                        elementTypeSerialize.MergeFrom(ref v, ms);
                        array[i] = v;
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
                    array[i] = null;
                }
            }
        }
    }
}
