namespace wxb
{
    class ObjectSerialize : ITypeSerialize
    {
        public ObjectSerialize()
        {

        }

        byte ITypeSerialize.typeFlag { get { return TypeFlags.objectType; } } // 类型标识

        void ITypeSerialize.WriteTo(object value, IStream ms)
        {
            if (value == null)
            {
                ms.WriteByte(0);
                return;
            }

            ms.WriteByte(1);
            var type = IL.Help.GetInstanceType(value);
            var serial = BinarySerializable.GetByType(type);

            TypeDesc td = TypeDesc.Get(type);
            td.Write(ms);
            serial.WriteTo(value, ms);
        }

        public class TypeDesc
        {
            public byte flag; // 0 正常类型，1 []类型,2,List类型,3,key-value类型
            public string name;
            public TypeDesc element1; // 
            public TypeDesc element2; // 

            // 基础类型
            static System.Collections.Generic.Dictionary<System.Type, byte> baseType2Flag;
            static System.Collections.Generic.Dictionary<byte, System.Type> flag2BaseType;
            static TypeDesc()
            {
                baseType2Flag = new System.Collections.Generic.Dictionary<System.Type, byte>();
                flag2BaseType = new System.Collections.Generic.Dictionary<byte, System.Type>();

                Add(typeof(object), 100);
                Add(typeof(char), 101);
                Add(typeof(byte), 102);
                Add(typeof(sbyte), 103);
                Add(typeof(short), 104);
                Add(typeof(ushort), 105);
                Add(typeof(int), 106);
                Add(typeof(uint), 107);
                Add(typeof(long), 108);
                Add(typeof(ulong), 109);
                Add(typeof(string), 110);
            }

            static void Add(System.Type type, byte flag)
            {
                baseType2Flag.Add(type, flag);
                flag2BaseType.Add(flag, type);
            }

            // 真实类型
            public System.Type GetCurrentType()
            {
                switch (flag)
                {
                    case 0: return IL.Help.GetTypeByFullName(name);
                    case 1: return element1.GetCurrentType().MakeArrayType();
                    case 2: return typeof(System.Collections.Generic.List<>).MakeGenericType(element1.GetCurrentType());
                    case 3: return typeof(System.Collections.Generic.Dictionary<,>).MakeGenericType(element1.GetCurrentType(), element2.GetCurrentType());
                    default: return flag2BaseType[flag];
                }
            }

            public void Write(IStream ms)
            {
                ms.WriteByte(flag);
                switch (flag)
                {
                    case 0:
                        {
                            ms.WriteString(name);
                        }
                        break;
                    case 1:
                    case 2:
                        {
                            element1.Write(ms);
                        }
                        break;
                    case 3:
                        {
                            element1.Write(ms);
                            element2.Write(ms);
                        }
                        break;
                }
            }

            public void Reader(IStream ms)
            {
                flag = ms.ReadByte();
                switch (flag)
                {
                    case 0:
                        {
                            name = ms.ReadString();
                        }
                        break;
                    case 1:
                    case 2:
                        {
                            element1 = new TypeDesc();
                            element1.Reader(ms);
                        }
                        break;
                    case 3:
                        {
                            element1 = new TypeDesc();
                            element2 = new TypeDesc();
                            element1.Reader(ms);
                            element2.Reader(ms);
                        }
                        break;
                }
            }

#if !CloseNested
            public string ToBase64()
            {
                DefaultStream stream = new DefaultStream(512);
                Write(stream);

                return System.Convert.ToBase64String(stream.GetBytes());
            }

            public static TypeDesc CreateByBase64(string base64)
            {
                TypeDesc td = new TypeDesc();
                {
                    var bytes = System.Convert.FromBase64String(base64);
                    DefaultStream stream = new DefaultStream(bytes);
                    stream.WritePos = bytes.Length;
                    td.Reader(stream);
                }

                return td;
            }
#endif

            public static TypeDesc Get(System.Type type)
            {
                TypeDesc td = new TypeDesc();
                if (baseType2Flag.TryGetValue(type, out td.flag))
                {

                }
                else if (type.IsArray)
                {
                    td.flag = 1;
                    td.element1 = Get(type.GetElementType());
                }
                else if (IL.Help.isListType(type))
                {
                    td.flag = 2;
                    td.element1 = Get(type.GetGenericArguments()[0]);
                }
                else if (IL.Help.isDictionaryType(type))
                {
                    td.flag = 3;

                    IL.Help.GetDictionaryKVType(type, null, out var keyType, out var valueType);
                    td.element1 = Get(keyType);
                    td.element2 = Get(valueType);
                }
                else
                {
                    td.flag = 0;
                    td.name = type.FullName;
                }

                return td;
            }
        }

        void ITypeSerialize.MergeFrom(ref object value, IStream ms)
        {
            if (ms.ReadByte() == 0)
            {
                value = null;
                return;
            }

            TypeDesc td = new TypeDesc();
            td.Reader(ms);

            System.Type type = td.GetCurrentType();
            if (value == null || (IL.Help.GetInstanceType(value) != type))
                value = IL.Help.Create(type);

            var serial = BinarySerializable.GetByType(type);
            serial.MergeFrom(ref value, ms);
        }

        // 判断两个值是否相等
        bool ITypeSerialize.IsEquals(object x, object y)
        {
            System.Type xType = IL.Help.GetInstanceType(x);
            System.Type yType = IL.Help.GetInstanceType(y);

            if (xType != yType)
                return false;

            return BinarySerializable.IsEquip(x, y);
        }

#if !CloseNested
        // 把值写入到ab当中
        void ITypeSerialize.WriteTo(object value, Nested.AnyBase ab)
        {
            if (value == null)
            {
                ab.valueType = 0;
                return;
            }

            ab.valueType = 1;
            var type = IL.Help.GetInstanceType(value);
            var serial = BinarySerializable.GetByType(type);

            TypeDesc typeDesc = TypeDesc.Get(type);
            ab.typeName = typeDesc.ToBase64();
            serial.WriteTo(value, ab);
        }

        // 通过ab来设置值
        void ITypeSerialize.MergeFrom(ref object value, Nested.AnyBase ab)
        {
            if (ab.valueType == 0)
            {
                value = null;
                return;
            }

            var typeDesc = TypeDesc.CreateByBase64(ab.typeName);

            System.Type type = typeDesc.GetCurrentType();
            if (value == null || (IL.Help.GetInstanceType(value) != type))
                value = IL.Help.Create(type);

            var serial = BinarySerializable.GetByType(type);
            serial.MergeFrom(ref value, ab);
        }
#endif
    }
}