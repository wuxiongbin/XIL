using System.Reflection;
using System.Collections.Generic;
#if USE_ILRT
using ILRuntime.Reflection;
#endif

namespace wxb
{
    class AnyTypeSerialize : ITypeSerialize
    {
        public AnyTypeSerialize(System.Type type, List<FieldInfo> fieldInfos)
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

        byte ITypeSerialize.typeFlag { get { return TypeFlags.classType; } } // 类型标识

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

        void ITypeSerialize.WriteTo(object value, IStream stream)
        {
            if (value == null)
            {
                stream.WriteByte(0);
                return;
            }

            var cnt = fieldInfos.Count;
            stream.WriteByte(cnt == 0 ? (byte)1 : (byte)2);
            if (cnt == 0)
                return;

            ITypeSerialize ts = this;
            for (int i = 0; i < cnt; ++i)
            {
                var field = fieldInfos[i];
                object cv = field.GetValue(value);

                ts = BinarySerializable.GetByFieldInfo(field);

                stream.WriteByte(ts.typeFlag); // 类型标识
                stream.WriteFieldName(field.Name);

                using (new RLStream(stream))
                {
                    ts.WriteTo(cv, stream);
                }
            }
        }

        public void MergeFrom(ref object value, IStream stream)
        {
            byte flag = stream.ReadByte();
            if (flag == 0)
            {
                value = null;
                return;
            }

            if (value == null)
            {
                value = IL.Help.Create(type);
            }

            if (flag == 1)
                return;

            do
            {
                byte typeFlag = stream.ReadByte();
                var fieldName = stream.ReadFieldName();
                var length = RLStream.ReadLength(stream);

                int endPos = stream.WritePos;
                stream.WritePos = stream.ReadPos + length;
                try
                {
                    var fieldInfo = FindFieldInfo(fieldName);
                    ITypeSerialize bs;

                    if (fieldInfo == null)
                    {
                        //L.LogFormat("type:{0} field:{1} typeFlag:{2} 字段不存在!", IL.Help.GetInstanceType(value).FullName, fieldName, typeFlag);
                        stream.ReadPos += length;
                    }
                    else if ((bs = BinarySerializable.GetByFieldInfo(fieldInfo)).typeFlag != typeFlag)
                    {
                        // 类型与之前的有变化了
                        //L.LogFormat("type:{0} field:{1} typeFlag {2}->{3} 有变化!", IL.Help.GetInstanceType(value).FullName, fieldName, typeFlag, bs.typeFlag);
                        stream.ReadPos += length;
                    }
                    else
                    {
                        object cv = fieldInfo.GetValue(value);
                        bs.MergeFrom(ref cv, stream);
                        if (typeFlag == TypeFlags.unityObjectType)
                        {
                            cv = UnityObjectSerialize.To((UnityEngine.Object)cv, fieldInfo.FieldType);
                        }

                        fieldInfo.SetValue(value, cv);
                    }
                }
                catch (System.Exception ex)
                {
                    wxb.L.LogException(ex);
                }
                finally
                {
#if UNITY_EDITOR
                    if (stream.ReadSize != 0)
                    {
                        wxb.L.LogErrorFormat("type:{0} fieldName:{1} length:{2}", type.Name, fieldName, length);
                    }
#endif
                    stream.WritePos = endPos;
                }
            }
            while (stream.ReadSize != 0);
        }

        // 判断两个值是否相等
        public bool IsEquals(object x, object y)
        {
            for (int i = 0; i < fieldInfos.Count; ++i)
            {
                var field = fieldInfos[i];

                var xv = field.GetValue(x);
                var yv = field.GetValue(y);

                if (!BinarySerializable.IsEquip(xv, yv))
                    return false;
            }

            return true;
        }

#if !CloseNested
        // 把值写入到ab当中
        public void WriteTo(object value, Nested.AnyBase ab)
        {
            if (value == null)
            {
                ab.valueType = 0;
                return;
            }

            var cnt = fieldInfos.Count;
            ab.valueType = cnt == 0 ? (byte)2 : (byte)1;
            if (cnt == 0)
                return;

            ITypeSerialize its;
            for (int i = 0; i < cnt; ++i)
            {
                var field = fieldInfos[i];
                object cv = field.GetValue(value);

                its = BinarySerializable.GetByFieldInfo(field);
                its.WriteTo(cv, ab.Create(field.Name, its.typeFlag));
            }
        }


        void ITypeSerialize.MergeFrom(ref object value, Nested.AnyBase ab)
        {
            byte flag = ab.valueType;
            if (flag == 0)
            {
                value = null;
                return;
            }

            if (value == null)
            {
                value = IL.Help.Create(type);
            }

            if (flag == 2)
                return;

            int cnt = fieldInfos.Count;
            FieldInfo field;
            ITypeSerialize its;
            for (int i = 0; i < cnt; ++i)
            {
                field = fieldInfos[i];
                if (ab.Get(field.Name, out var fieldValue))
                {
                    object cv = field.GetValue(value);
                    {
                        its = BinarySerializable.GetByFieldInfo(field);
                        if (fieldValue.typeFlags == its.typeFlag)
                        {
                            its.MergeFrom(ref cv, fieldValue);
                            if (its.typeFlag == TypeFlags.unityObjectType)
                            {
                                cv = UnityObjectSerialize.To((UnityEngine.Object)cv, field.FieldType);
                            }

                            field.SetValue(value, cv);
                        }
                    }
                }
            }
        }
#endif
    }
}
