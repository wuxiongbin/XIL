#if USE_HOT
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Mono.Cecil;
using ILRuntime.Runtime.Intepreter;
#endif
using System;
using System.Collections.Generic;

namespace wxb
{
    public static class Str2Enum
    {
#if USE_HOT
        class EnumValue
        {
            public EnumValue(EnumInfo info)
            {
                this.info = info;
            }
            public EnumInfo info;
            public string name; // 枚举名
            public int value; // 枚举整形值
            public FieldDefinition field;
        }

        class EnumInfo
        {
            public EnumInfo(ILType type)
            {
                this.type = type;
            }

            public ILType type;
            Dictionary<string, EnumValue> names = new Dictionary<string, EnumValue>(); // 名字列表
            Dictionary<int, EnumValue> values = new Dictionary<int, EnumValue>(); // 值列表
            public object[] allValues; // 所有值

            public EnumValue defaultValue;

            public void Add(FieldDefinition field)
            {
                var name = field.Name;
                int value = (int)field.Constant;
                EnumValue ev = new EnumValue(this);
                ev.name = name;
                ev.value = value;
                ev.field = field;

                names[name] = ev;
                values[value] = ev;

                if (defaultValue == null)
                    defaultValue = ev;
            }

            public bool GetStr(int value, out string name)
            {
                if (values.TryGetValue(value, out var ev))
                {
                    name = ev.name;
                    return true;
                }

                name = null;
                return false;
            }

            public bool GetValue(string name, out int value)
            {
                if (names.TryGetValue(name, out var ev))
                {
                    value = ev.value;
                    return true;
                }

                value = 0;
                return false;
            }

            public EnumValue Get(string name)
            {
                if (names.TryGetValue(name, out var ev))
                    return ev;

                return null;
            }

            public EnumValue Get(int value)
            {
                if (values.TryGetValue(value, out var ev))
                    return ev;

                return null;
            }
        }

        static Dictionary<Type, EnumInfo> enumValues = new Dictionary<Type, EnumInfo>();

        static EnumInfo Get(System.Type type)
        {
            if (!enumValues.TryGetValue(type, out var enumInfo))
            {
                var it = ((ILRuntime.Reflection.ILRuntimeType)type).ILType;
                if (!it.IsEnum)
                    throw new Exception(string.Format("{0} is not Enum", type.FullName));

                enumInfo = new EnumInfo(it);
                enumValues.Add(type, enumInfo);
                var fields = it.TypeDefinition.Fields;
                List<object> allValues = new List<object>();
                for (int i = 0; i < fields.Count; i++)
                {
                    var f = fields[i];
                    if (f.IsStatic)
                    {
                        enumInfo.Add(f);
                        allValues.Add(f.Constant);
                    }
                }

                enumInfo.allValues = allValues.ToArray();
            }

            return enumInfo;
        }

        static bool TryGet(System.Type type, string key, out object value)
        {
            if (Get(type).GetValue(key, out var enumValue))
            {
                value = enumValue;
                return true;
            }

            value = null;
            return false;
        }
#endif

        public static object To(string str, System.Type type)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            try
            {
                if (str[0] >= '0' && str[0] <= '9')
                {
#if USE_HOT
                    if (type is ILRuntime.Reflection.ILRuntimeType)
                        return int.Parse(str);
#endif
                    return Enum.ToObject(type, int.Parse(str)); // 数字
                }

#if USE_HOT
                if (type is ILRuntime.Reflection.ILRuntimeType)
                {
                    if (TryGet(type, str, out var value))
                        return value;

                    return Get(type).defaultValue.value;
                }
#endif
                return Enum.Parse(type, str);
            }
            catch (System.Exception ex)
            {
                L.LogException(ex);
                L.LogError($"type:{type.Name} not find {str}!");
            }

            return 0;
        }

#if USE_HOT
        public static string GetEnumStr(object value, System.Type type)
        {
            int intValue = (int)value;
            EnumInfo ei = Get(type);
            if (ei.GetStr(intValue, out var name))
                return name;

            return intValue.ToString();
        }
#endif

        public static bool TryParse(string value, System.Type type, out object t)
        {
            if (string.IsNullOrEmpty(value))
            {
                t = null;
                return false;
            }

            if (value[0] >= '0' && value[0] <= '9')
            {
                // 数字
#if USE_HOT
                if (type is ILRuntime.Reflection.ILRuntimeType)
                {
                    t = int.Parse(value);
                    return true;
                }
#endif
                t = Enum.ToObject(type, int.Parse(value)); // 数字
                return true;
            }

#if USE_HOT
            if (type is ILRuntime.Reflection.ILRuntimeType)
            {
                if (TryGet(type, value, out t))
                    return true;

                return false;
            }
#endif
            return TryParse(type, value, out t);
        }

        static bool TryParse(System.Type type, string value, out object ev)
        {
            var names = Enum.GetNames(type);
            for (int i = 0;i < names.Length; ++i)
            {
                if (names[i] == value)
                {
                    ev = Enum.Parse(type, value);
                    return true;
                }
            }

            ev = null;
            return false;
        }

        public static Array GetEnumValues(System.Type type)
        {
#if USE_HOT
            if (type is ILRuntime.Reflection.ILRuntimeType)
            {
                return Get(type).allValues;
            }
#endif
            return type.GetEnumValues();
        }

        public static void Release()
        {
#if USE_HOT
            enumValues.Clear();
#endif
        }
    }
}