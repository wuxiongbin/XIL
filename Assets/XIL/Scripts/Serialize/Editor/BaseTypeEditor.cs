using UnityEditor;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if USE_HOT
using ILRuntime.Mono.Cecil;
using ILRuntime.Reflection;
using ILRuntime.Runtime.Intepreter;
#endif

namespace wxb.Editor
{
    abstract class BaseType<T> : ITypeGUI
    {
        public bool OnGUI(object parent, FieldInfo info)
        {
            using (new IndentLevel())
            {
                bool isDirty = false;
                T ov = (T)info.GetValue(parent);
                T nv = (T)OnGUI(info.Name, ov, info.FieldType, out isDirty);
                if (isDirty)
                {
                    info.SetValue(parent, nv);
                    return true;
                }

                return false;
            }
        }

        public object OnGUI(string label, object value, System.Type type, out bool isDirty)
        {
            return OnGUI(label, (T)value, type, out isDirty);
        }

        protected abstract T OnGUI(string label, T value, System.Type type, out bool isDirty);

        public virtual bool AutoSetValue(object value, FieldInfo fieldInfo, GameObject root)
        {
            return false;
        }
    }

    class IntType : BaseType<int>
    {
        protected override int OnGUI(string label, int value, System.Type type, out bool isDirty)
        {
            int v = EditorGUILayout.IntField(label, value);
            if (v != value)
                isDirty = true;
            else
                isDirty = false;

            return v;
        }
    }

    class EnumType : ITypeGUI
    {
        public EnumType(System.Type enumType)
        {
            this.enumType = enumType;
#if USE_HOT
            if (enumType is ILRuntimeType)
            {
                enumStrings = new List<string>();
                enumValues = new List<int>();
                var ilRT = ((ILRuntimeType)enumType).ILType;
                var staticFieldDefinitions = ilRT.StaticFieldDefinitions;
                FieldDefinition sfd;
                for (int i = 0; i < staticFieldDefinitions.Length; ++i)
                {
                    sfd = staticFieldDefinitions[i];
                    enumStrings.Add(sfd.Name);
                    enumValues.Add((int)sfd.Constant);
                }
            }
#endif
        }

        System.Type enumType;
#if USE_HOT
        List<string> enumStrings;
        List<int> enumValues;
#endif

        public bool OnGUI(object parent, FieldInfo info)
        {
            using (new IndentLevel())
            {
                bool isDirty = false;
                object ov = info.GetValue(parent);
                object nv = OnGUI(info.Name, ov, info.FieldType, out isDirty);
                if (isDirty)
                {
                    info.SetValue(parent, nv);
                    return true;
                }

                return false;
            }
        }

        public object OnGUI(string label, object value, System.Type type, out bool isDirty)
        {
#if USE_HOT
            if (type is ILRuntimeType)
            {
                int index = 0;
                {
                    int intValue = (int)value;
                    for (int i = 0; i < enumValues.Count; ++i)
                    {
                        if (enumValues[i] == intValue)
                        {
                            index = i;
                            break;
                        }
                    }
                }

                isDirty = false;
                var newIndex = IL.Editor.ILMonoEditor.StringPopup(label, index, enumStrings);
                if (newIndex != index)
                    isDirty = true;

                return enumValues[newIndex];
            }
#endif
            System.Enum nv;
            {
                nv = EditorGUILayout.EnumPopup(label, (System.Enum)value);
            }

            if ((int)(object)nv != (int)value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }

        public bool AutoSetValue(object value, FieldInfo fieldInfo, GameObject root)
        {
            return false;
        }
    }

    class UIntType : BaseType<uint>
    {
        protected override uint OnGUI(string label, uint value, System.Type type, out bool isDirty)
        {
            uint nv = 0;
            {
                int v = EditorGUILayout.IntField(label, (int)value);
                if (v < 0)
                    v = 0;
                nv = (uint)v;
            }

            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class sByteType : BaseType<sbyte>
    {
        protected override sbyte OnGUI(string label, sbyte value, System.Type type, out bool isDirty)
        {
            sbyte nv = 0;
            {
                int v = EditorGUILayout.IntField(label, (int)value);
                if (v < 0)
                    v = 0;
                nv = (sbyte)v;
            }

            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class ByteType : BaseType<byte>
    {
        protected override byte OnGUI(string label, byte value, System.Type type, out bool isDirty)
        {
            byte nv = 0;
            {
                int v = EditorGUILayout.IntField(label, value);
                if (v < 0)
                    v = 0;
                nv = (byte)v;
            }

            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class CharType : BaseType<char>
    {
        protected override char OnGUI(string label, char value, System.Type type, out bool isDirty)
        {
            char nv = default(char);
            {
                string str = EditorGUILayout.TextField(label, value.ToString());
                if (!string.IsNullOrEmpty(str))
                    nv = str[0];
            }

            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class ShortType : BaseType<short>
    {
        protected override short OnGUI(string label, short value, System.Type type, out bool isDirty)
        {
            short nv = 0;
            {
                int v = EditorGUILayout.IntField(label, value);
                if (v < 0)
                    v = 0;
                nv = (short)v;
            }

            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class UShortType : BaseType<ushort>
    {
        protected override ushort OnGUI(string label, ushort value, System.Type type, out bool isDirty)
        {
            ushort nv = 0;
            {
                int v = EditorGUILayout.IntField(label, value);
                if (v < 0)
                    v = 0;
                nv = (ushort)v;
            }

            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class LongType : BaseType<long>
    {
        protected override long OnGUI(string label, long value, System.Type type, out bool isDirty)
        {
            long nv = EditorGUILayout.LongField(label, value);
            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class ULongType : BaseType<ulong>
    {
        protected override ulong OnGUI(string label, ulong value, System.Type type, out bool isDirty)
        {
            ulong nv = 0;
            {
                long v = EditorGUILayout.LongField(label, (long)value);
                if (v < 0)
                    v = 0;
                nv = (ulong)v;
            }

            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class StrType : BaseType<string>
    {
        protected override string OnGUI(string label, string value, System.Type type, out bool isDirty)
        {
            string nv = EditorGUILayout.TextField(label, value); 
            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class BoolType : BaseType<bool>
    {
        protected override bool OnGUI(string label, bool value, System.Type type, out bool isDirty)
        {
            bool nv = EditorGUILayout.Toggle(label, value);
            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class FloatType : BaseType<float>
    {
        protected override float OnGUI(string label, float value, System.Type type, out bool isDirty)
        {
            float nv = EditorGUILayout.FloatField(label, value);
            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class DoubleType : BaseType<double>
    {
        protected override double OnGUI(string label, double value, System.Type type, out bool isDirty)
        {
            double nv = EditorGUILayout.DoubleField(label, value);
            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class Vector2Type : BaseType<Vector2>
    {
        protected override Vector2 OnGUI(string label, Vector2 value, System.Type type, out bool isDirty)
        {
            Vector2 nv = EditorGUILayout.Vector2Field(label, value);
            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class Vector3Type : BaseType<Vector3>
    {
        protected override Vector3 OnGUI(string label, Vector3 value, System.Type type, out bool isDirty)
        {
            Vector3 nv = EditorGUILayout.Vector3Field(label, value);
            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class Vector4Type : BaseType<Vector4>
    {
        protected override Vector4 OnGUI(string label, Vector4 value, System.Type type, out bool isDirty)
        {
            Vector4 nv = EditorGUILayout.Vector4Field(label, value);
            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class Vector2IntType : BaseType<Vector2Int>
    {
        protected override Vector2Int OnGUI(string label, Vector2Int value, System.Type type, out bool isDirty)
        {
            Vector2Int nv = EditorGUILayout.Vector2IntField(label, value);
            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class Vector3IntType : BaseType<Vector3Int>
    {
        protected override Vector3Int OnGUI(string label, Vector3Int value, System.Type type, out bool isDirty)
        {
            Vector3Int nv = EditorGUILayout.Vector3IntField(label, value);
            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class ObjectType : BaseType<UnityEngine.Object>
    {
        protected override UnityEngine.Object OnGUI(string label, UnityEngine.Object value, System.Type type, out bool isDirty)
        {
            type = IL.Help.GetRealType(type);
            isDirty = false;
            Object nv = null;
            CopyFieldName(label, ()=> 
            {
                nv = EditorGUILayout.ObjectField(label, value, type, true);
            });

            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }

        public static void CopyFieldName(string label, System.Action ongui)
        {
            EditorGUILayout.BeginHorizontal();
            ongui();
            CopyString(label);
            EditorGUILayout.EndHorizontal();
        }

        public static void CopyString(string label)
        {
            if (GUILayout.Button("C", GUILayout.Width(20f)))
            {
                int last = label.LastIndexOf(' ');
                if (last == -1)
                    EditorGUIUtility.systemCopyBuffer = label;
                else
                    EditorGUIUtility.systemCopyBuffer = label.Substring(last + 1);
            }
        }

        public override bool AutoSetValue(object value, FieldInfo fieldInfo, GameObject root)
        {
            if (fieldInfo.GetValue(value) != null)
                return false;

            var fieldType = IL.Help.GetRealType(fieldInfo.FieldType);
            var obj = GetFind(root.transform, fieldInfo.Name, fieldType);
            if (obj == null)
                obj = GetComponentInChildren(root, fieldType);

            if (obj != null)
            {
                fieldInfo.SetValue(value, obj);
                return true;
            }

            return false;
        }

        public static Object GetComponentInChildren(GameObject root, System.Type type)
        {
            if (type == typeof(GameObject))
                return root;

            return root.GetComponentInChildren(type);
        }

        public static Object GetComponent(Transform t, System.Type type)
        {
            if (type == typeof(Transform))
                return t;
            if (type == typeof(GameObject))
                return t.gameObject;

            return t.GetComponent(type);
        }

        public static Object GetFind(Transform root, string name, System.Type type, System.Func<Object, bool> onFind = null)
        {
            int cnt = root.childCount;
            Transform t = root.Find(name);
            if (t != null)
            {
                var tt = GetComponent(t, type);
                if (onFind == null || onFind(tt))
                    return tt;
            }

            for (int i = 0; i < cnt; ++i)
            {
                var child = root.GetChild(i);
                var tt = GetFind(child, name, type, onFind);
                if (tt != null)
                    return tt;
            }

            return null;
        }
    }
}
