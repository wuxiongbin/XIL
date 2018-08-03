using System.Reflection;
using System.Collections.Generic;

namespace wxb
{
    class AnyType : ITypeSerialize
    {
        public AnyType(System.Type type, List<FieldInfo> fieldInfos)
        {
            this.type = type;
            this.fieldInfos = fieldInfos;
        }

        System.Type type;
        List<FieldInfo> fieldInfos;

        int ITypeSerialize.CalculateSize(object value)
        {
            if (value == null)
                return 0;

            int total = 0;
            for (int i = 0; i < fieldInfos.Count; ++i)
            {
                var fieldInfo = fieldInfos[i];
                var cv = fieldInfo.GetValue(value);
                if (cv == null)
                    continue;

                total += WRStream.ComputeStringSize(fieldInfo.Name);
                int size = MonoSerialize.GetByInstance(cv).CalculateSize(cv);
                total += WRStream.ComputeLengthSize(size);
                total += size;
            }

            return total;
        }

        void ITypeSerialize.WriteTo(object value, MonoStream ms)
        {
            if (value == null)
                return;

            var stream = ms.Stream;
            ITypeSerialize ts = this;
            for (int i = 0; i < fieldInfos.Count; ++i)
            {
                var field = fieldInfos[i];
                object cv = field.GetValue(value);
                if (cv == null)
                    continue;

#if USE_HOT
                if (field.FieldType.IsArray && (field.FieldType is ILRuntime.Reflection.ILRuntimeType))
                {
                    var ilType = field.FieldType as ILRuntime.Reflection.ILRuntimeType;
                    ts = MonoSerialize.GetByType(ilType);
                }
                else
#endif
                {
                    ts = MonoSerialize.GetByInstance(cv);
                }

                stream.WriteString(field.Name);
                int count = ts.CalculateSize(cv);
                if (count == 0)
                    continue;

                stream.WriteLength(count);
#if UNITY_EDITOR
                int write_pos = stream.WritePos;
#endif
                ts.WriteTo(cv, ms);
#if UNITY_EDITOR
                if (stream.WritePos != write_pos + count)
                {
                    UnityEngine.Debug.LogErrorFormat("type:{0} CalculateSize error!", ts.GetType().Name);
                }
#endif
            }
        }

        public void MergeFrom(ref object value, MonoStream ms)
        {
            if (value == null)
            {
                value = IL.Help.Create(type);
            }

            WRStream stream = ms.Stream;
            while (stream.ReadSize != 0)
            {
                var fieldName = stream.ReadString();
                var length = stream.ReadLength();
                if (length == 0)
                {

                }
                else
                {
                    int endPos = stream.WritePos;
                    stream.WritePos = stream.ReadPos + length;
                    try
                    {
                        var fieldInfo = fieldInfos.Find((field) => { return fieldName == field.Name; });
                        if (fieldInfo == null)
                        {
                            stream.ReadPos += length;
                        }
                        else
                        {
                            object cv = fieldInfo.GetValue(value);
                            bool isSet = false;
                            if (cv == null)
                            {
                                cv = IL.Help.Create(fieldInfo.FieldType);
                                isSet = true;
                            }

                            MonoSerialize.GetByType(fieldInfo.FieldType).MergeFrom(ref cv, ms);
                            if (isSet || !cv.GetType().IsClass)
                            {
                                fieldInfo.SetValue(value, cv);
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        UnityEngine.Debug.LogException(ex);
                    }
                    finally
                    {
                        stream.WritePos = endPos;
                    }
                }
            }
        }
    }
}
