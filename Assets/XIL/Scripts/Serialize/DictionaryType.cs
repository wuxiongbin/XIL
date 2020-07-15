using UnityEngine;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace wxb
{
    class DictionaryType : ITypeSerialize
    {
        public DictionaryType(System.Type type, FieldInfo fieldInfo)
        {
            this.type = type;
            this.fieldInfo = fieldInfo;

            IL.Help.GetDictionaryKVType(type, fieldInfo, out keyType, out valueType);

            keyTypeSerialize = BinarySerializable.GetByType(keyType);
            valueTypeSerialize = BinarySerializable.GetByType(valueType);
        }

        FieldInfo fieldInfo;
        System.Type type;
        System.Type keyType;
        System.Type valueType;

        ITypeSerialize keyTypeSerialize;
        ITypeSerialize valueTypeSerialize;

        // 类型标识
        public byte typeFlag { get { return TypeFlags.dicType; } }

        public void WriteTo(object value, IStream ms)
        {
            if (value == null)
            {
                ms.WriteByte(0);
                return;
            }

            ms.WriteByte(1);
            var dic = (IDictionary)value;
            ms.WriteVarInt32(dic.Count);
            foreach (DictionaryEntry ator in dic)
            {
                using (new RLStream(ms))
                {
                    keyTypeSerialize.WriteTo(ator.Key, ms);
                }

                using (new RLStream(ms))
                {
                    valueTypeSerialize.WriteTo(ator.Value, ms);
                }
            }
        }

        public void MergeFrom(ref object value, IStream ms)
        {
            if (ms.ReadByte() == 0)
            {
                value = null;
                return;
            }

            int count = ms.ReadVarInt32();
            var dic = (IDictionary)value;
            if (value == null)
            {
                value = System.Activator.CreateInstance(type, count);
                dic = (IDictionary)value;
            }

            for (int i = 0; i < count; ++i)
            {
                object keyValue = IL.Help.Create(keyType);
                object valueValue = IL.Help.Create(valueType);

                RLStream.MergeFrom(keyTypeSerialize, ms, ref keyValue);
                RLStream.MergeFrom(valueTypeSerialize, ms, ref valueValue);

                dic[keyValue] = valueValue;
            }
        }

        // 判断两个值是否相等
        public bool IsEquals(object x, object y)
        {
            var xDic = (IDictionary)x;
            var yDic = (IDictionary)y;
            int count = xDic.Count;
            if (count != yDic.Count)
                return false;

            foreach (DictionaryEntry ator in xDic)
            {
                if (yDic.Contains(ator.Key))
                {
                    if (!BinarySerializable.IsEquip(ator.Value, yDic[ator.Key]))
                        return false;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
