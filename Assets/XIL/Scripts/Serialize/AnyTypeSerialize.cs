using System.Reflection;
using System.Collections.Generic;
#if USE_HOT
using ILRuntime.Reflection;
#endif

namespace wxb
{
    class AnyType : ITypeSerialize
    {
        public AnyType(System.Type type, List<FieldInfo> fieldInfos)
        {
            this.type = type;
            this.fieldInfos = fieldInfos;
            if (fieldInfos.Count > 4)
            {
                NamesByFields = new Dictionary<string, FieldInfo>();
                foreach (var ator in fieldInfos)
                    NamesByFields.Add(ator.Name, ator);
            }
        }

        byte ITypeSerialize.typeFlag { get { return 0; } } // 类型标识

        System.Type type;
        List<FieldInfo> fieldInfos;
        Dictionary<string, FieldInfo> NamesByFields = null;

        FieldInfo FindFieldInfo(string name)
        {
            if (NamesByFields != null)
            {
                if (NamesByFields.TryGetValue(name, out var fieldInfo))
                    return fieldInfo;
            }
            else
            {
                int count = fieldInfos.Count;
                for (int i = 0; i < count; ++i)
                {
                    if (fieldInfos[i].Name == name)
                        return fieldInfos[i];
                }
            }

            return null;
        }

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

                var fieldType = fieldInfo.FieldType;
                total += 1; // 类型标识
                total += WRStream.ComputeStringSize(fieldInfo.Name);
                int size = BinarySerializable.GetByFieldInfo(fieldInfo).CalculateSize(cv);
                total += WRStream.ComputeLengthSize(size);
                total += size;
            }

            return total;
        }

        void ITypeSerialize.WriteTo(object value, IStream stream)
        {
            if (value == null)
                return;

            ITypeSerialize ts = this;
            for (int i = 0; i < fieldInfos.Count; ++i)
            {
                var field = fieldInfos[i];
                object cv = field.GetValue(value);
                if (cv == null)
                    continue;

                ts = BinarySerializable.GetByFieldInfo(field);

                stream.WriteByte(ts.typeFlag); // 类型标识
                stream.WriteString(field.Name);
                int count = ts.CalculateSize(cv);
                if (count == 0)
                    continue;

                stream.WriteLength(count);
#if UNITY_EDITOR
                int write_pos = stream.WritePos;
#endif
                ts.WriteTo(cv, stream);
#if UNITY_EDITOR
                if (stream.WritePos != write_pos + count)
                {
                    UnityEngine.Debug.LogErrorFormat("type:{0} CalculateSize error!", ts.GetType().Name);
                }
#endif
            }
        }

        public void MergeFrom(ref object value, IStream stream)
        {
            if (value == null)
            {
                value = IL.Help.Create(type);
            }

            while (stream.ReadSize != 0)
            {
                byte typeFlag = stream.ReadByte();
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
                        var fieldInfo = FindFieldInfo(fieldName);
                        ITypeSerialize bs;

                        if (fieldInfo == null || 
                            ((bs = BinarySerializable.GetByFieldInfo(fieldInfo)).typeFlag != typeFlag)) // 类型与之前的有变化了
                        {
                            stream.ReadPos += length;
                        }
                        else
                        {
                            object cv = fieldInfo.GetValue(value);
                            bs.MergeFrom(ref cv, stream);
                            if (typeFlag == UnityObjectSerialize.type)
                            {
                                cv = UnityObjectSerialize.To((UnityEngine.Object)cv, fieldInfo.FieldType);
                            }

                            fieldInfo.SetValue(value, cv);
                        }
                    }
                    catch (System.Exception ex)
                    {
                        UnityEngine.Debug.LogException(ex);
                    }
                    finally
                    {
#if UNITY_EDITOR
                        if (stream.ReadSize != 0)
                        {
                            UnityEngine.Debug.LogErrorFormat("type:{0} fieldName:{1} length:{2}", type.Name, fieldName, length);
                        }
#endif
                        stream.WritePos = endPos;
                    }
                }
            }
        }
    }
}
