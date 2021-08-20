using System;
using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System.Diagnostics;

namespace wxb
{
    [System.AttributeUsage(System.AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class EnumExpel : System.Attribute
    {

    }

    [System.AttributeUsage(System.AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class EnumValue : System.Attribute
    {
        public EnumValue(string name)
        {
            Name = name;
            Priority = 0;
        }

        public EnumValue(string name, int priority)
        {
            Name = name;
            Priority = priority;
        }

        public string Name { get; protected set; }
        public int Priority { get; protected set; }// 扩展枚举值显示顺序用，默认都为0，不影响原来的枚举顺序
    }

#if UNITY_EDITOR
    public class Enum2Type
    {
        class E
        {
            public Enum value; // 枚举值
            public string src; // 源值
            public string text; // 枚举描述
            public int priority;// 枚举位置顺序
        }

        class ET
        {
            public ET()
            {
                valueList = new List<E>();
//                 intValue = new List<int>();
//                 srcTextList = new List<string>();
//                 showTextList = new List<string>();
            }

            // 值类型
            public List<E> valueList { get; protected set; }

            public int[] intValue { get; set; }

            public string[] srcTextList { get; set; }

            public string[] showTextList { get; set; }

            public int FindIndex(Enum value)
            {
                for (int i = 0; i < valueList.Count; ++i)
                {
                    if (value.Equals(valueList[i].value))
                    {
                        return i;
                    }
                }

                return -1;
            }

            public E FindE(int value)
            {
                for (int i = 0; i < valueList.Count; ++i)
                {
                    if (((int)((object)valueList[i].value)) == value)
                        return valueList[i];
                }

                return null;
            }

            public E FindE(Enum value)
            {
                for (int i = 0; i < valueList.Count; ++i)
                {
                    if (((int)(object)valueList[i].value) == ((int)(object)value))
                        return valueList[i];
                }

                return null;
            }
        }

        class Etype
        {
            public Etype(Type t)
            {
                type = t;
                etype = new ET();
            }

            // 类型
            public System.Type type { get; protected set; }

            public ET etype { get; protected set; }
        }

        static Dictionary<Type, Etype> TypeList = new Dictionary<Type, Etype>();

        static Etype To(Type type)
        {
            if (!type.IsEnum)
                return null; // 非枚举

            Etype etype = null;
            if (TypeList.TryGetValue(type, out etype))
                return etype;

            etype = new Etype(type);
            foreach (MemberInfo info in type.GetMembers())
            {
                if (info.MemberType == MemberTypes.Field && info.Name != "value__")
                {
                    object[] os = info.GetCustomAttributes(typeof(EnumExpel), false);
                    if (os != null && os.Length != 0)
                        continue;

                    E e = new E();
                    e.src = info.Name;
                    e.value = (System.Enum)System.Enum.Parse(type, e.src);
                    e.text = e.src;
                    os = info.GetCustomAttributes(typeof(EnumValue), false);
                    if (os != null && os.Length > 0)
                    {
                        EnumValue ev = os[0] as EnumValue;
                        e.text = ev.Name;
                        e.priority = ev.Priority;
                    }

                    etype.etype.valueList.Add(e);                    
                }
            }
            etype.etype.valueList.Sort(EnumPriorityCompare);

            int cnt = etype.etype.valueList.Count;
            var iv = etype.etype.intValue = new int[cnt];
            var stl = etype.etype.srcTextList = new string[cnt];
            var stv = etype.etype.showTextList = new string[cnt];
            for (int i = 0; i < cnt; ++i)
            {
                E e = etype.etype.valueList[i];
                iv[i] = (int)(object)e.value;
                stl[i] = e.src;
                stv[i] = $"{iv[i]} [{e.text}]";
            }

            TypeList.Add(type, etype);
            return etype;
        }
        static int EnumPriorityCompare(E x, E y)
        {
            int r = x.priority.CompareTo(y.priority);
            if (r == 0)
                return x.value.CompareTo(y.value);
            else
                return r;
        }

        static Etype To<T>() where T : struct, System.Enum
        {
            Type type = typeof(T);
            return To(type);
        }

        public static T EnumPopupT<T>(string label, T selected, params GUILayoutOption[] options) where T : struct, System.Enum
        {
            return (T)EnumPopup(label, (Enum)selected, options);
        }

        public static System.Enum EnumPopup(string label, System.Enum selected, params GUILayoutOption[] options)
        {
            Etype etype = To(selected.GetType());
            int value = etype.etype.FindIndex(selected);
            if (value == -1)
                value = 0;

            if (string.IsNullOrEmpty(label))
                value = UnityEditor.EditorGUILayout.IntPopup(etype.etype.intValue[value], etype.etype.showTextList, etype.etype.intValue, options);
            else
                value = UnityEditor.EditorGUILayout.IntPopup(label, etype.etype.intValue[value], etype.etype.showTextList, etype.etype.intValue, options);

            int index = System.Array.IndexOf(etype.etype.intValue, value);
            return etype.etype.valueList[index].value;
        }
    }
#endif
}
