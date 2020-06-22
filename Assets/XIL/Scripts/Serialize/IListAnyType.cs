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

        byte ITypeSerialize.typeFlag { get { return 100; } } // 数组标识

        int ITypeSerialize.CalculateSize(object value)
        {
            if (value == null)
                return 0;

            IList array = value as IList;

            int total = WRStream.ComputeLengthSize(array.Count);
            total += 1;

            // 长度+各个元素内容
            for (int i = 0; i < array.Count; ++i)
            {
                int s = elementTypeSerialize.CalculateSize(array[i]);
                total += WRStream.ComputeLengthSize(s);
                total += s;
            }
            return total;

            //if (!isSmartType)
            //{
            //    total += 1; // 元素类型

            //    // 长度+各个元素内容
            //    for (int i = 0; i < array.Count; ++i)
            //    {
            //        int s = elementTypeSerialize.CalculateSize(array[i]);
            //        total += WRStream.ComputeLengthSize(s);
            //        total += s;
            //    }
            //}
            //else
            //{
            //    object elementObj;
            //    ITypeSerialize es;
            //    int elementSize = 0;

            //    // 长度+各个元素内容
            //    for (int i = 0; i < array.Count; ++i)
            //    {
            //        elementObj = array[i];
            //        if (elementObj == null)
            //        {
            //            es = NullTypeSerialize.instance;
            //        }
            //        else
            //        {
            //            es = BinarySerializable.GetByType(elementObj.GetType());
            //        }

            //        total += 1;
            //        elementSize = es.CalculateSize(array[i]);
            //        total += WRStream.ComputeLengthSize(elementSize);
            //        total += elementSize;
            //    }
            //}

            //return total;
        }

        void ITypeSerialize.WriteTo(object value, IStream stream)
        {
            IList array = (IList)value;
            if (array == null)
                return;

            stream.WriteByte(elementTypeSerialize.typeFlag);
            stream.WriteLength(array.Count);
            for (int i = 0; i < array.Count; ++i)
            {
                int count = elementTypeSerialize.CalculateSize(array[i]);
                stream.WriteLength(count);
                if (count != 0)
                {
                    elementTypeSerialize.WriteTo(array[i], stream);
                }
            }

            //if (!isSmartType)
            //{
            //    stream.WriteByte(elementTypeSerialize.typeFlag);
            //    stream.WriteLength(array.Count);
            //    for (int i = 0; i < array.Count; ++i)
            //    {
            //        int count = elementTypeSerialize.CalculateSize(array[i]);
            //        stream.WriteLength(count);
            //        if (count != 0)
            //        {
            //            elementTypeSerialize.WriteTo(array[i], stream);
            //        }
            //    }
            //}
            //else
            //{
            //    stream.WriteLength(array.Count);

            //    object elementObj;
            //    ITypeSerialize es;
            //    int elementSize = 0;
            //    for (int i = 0; i < array.Count; ++i)
            //    {
            //        elementObj = array[i];
            //        if (elementObj == null)
            //        {
            //            es = NullTypeSerialize.instance;
            //        }
            //        else
            //        {
            //            es = BinarySerializable.GetByType(elementObj.GetType());
            //        }

            //        stream.WriteByte(es.typeFlag);
            //        elementSize = es.CalculateSize(elementObj);
            //        stream.WriteLength(elementSize);
            //        if (elementSize != 0)
            //        {
            //            es.WriteTo(elementObj, stream);
            //        }
            //    }
            //}
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

            //if (isBaseType)
            //{
            //    int flagType = stream.ReadByte();
            //    int lenght = stream.ReadLength();

            //    bool isTypeTrue = flagType == elementTypeSerialize.typeFlag; // 类型是否一致
            //    var array = value as IList;
            //    if (isTypeTrue && (array == null || array.Count != lenght))
            //    {
            //        array = Create(lenght);
            //        value = array;
            //    }

            //    for (int i = 0; i < lenght; ++i)
            //    {
            //        int count = stream.ReadLength();
            //        if (count != 0)
            //        {
            //            int endpos = stream.WritePos;
            //            stream.WritePos = stream.ReadPos + count;
            //            try
            //            {
            //                if (isTypeTrue)
            //                {
            //                    object v = array[i];
            //                    elementTypeSerialize.MergeFrom(ref v, stream);
            //                    array[i] = v;
            //                }
            //                else
            //                {
            //                    stream.ReadPos += count;
            //                }
            //            }
            //            catch (System.Exception ex)
            //            {
            //                wxb.L.LogException(ex);
            //            }
            //            finally
            //            {
            //                stream.WritePos = endpos;
            //            }
            //        }
            //        else
            //        {
            //            if (isTypeTrue)
            //                array[i] = null;
            //        }
            //    }
            //}
            //else
            //{
            //    int lenght = stream.ReadLength();
            //    var array = value as IList;
            //    if (array == null || array.Count != lenght)
            //    {
            //        array = Create(lenght);
            //        value = array;
            //    }

            //    int typeFalg;
            //    int count = 0;
            //    for (int i = 0; i < lenght; ++i)
            //    {
            //        typeFalg = stream.ReadByte();
            //        count = stream.ReadLength();

            //        int endpos = stream.WritePos;
            //        stream.WritePos = stream.ReadPos + count;
            //        try
            //        {
            //            if (typeFalg == NullTypeSerialize.instance.typeFlag)
            //            {
            //                array[i] = null;
            //            }
            //            else
            //            {
            //                object v = array[i];
            //                elementTypeSerialize.MergeFrom(ref v, stream);
            //                array[i] = v;
            //            }
            //        }
            //        catch (System.Exception ex)
            //        {
            //            wxb.L.LogException(ex);
            //        }
            //        finally
            //        {
            //            stream.WritePos = endpos;
            //        }
            //    }
            //}
        }
    }
}