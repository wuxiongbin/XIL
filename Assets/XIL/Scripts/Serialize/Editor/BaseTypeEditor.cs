using UnityEditor;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
#if USE_HOT
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

    class ObjectType : BaseType<UnityEngine.Object>
    {
        protected override UnityEngine.Object OnGUI(string label, UnityEngine.Object value, System.Type type, out bool isDirty)
        {
#if USE_HOT
            if (type is ILRuntimeWrapperType)
            {
                type = ((ILRuntimeWrapperType)type).RealType;
            }
#endif
            isDirty = false;
            UnityEngine.Object nv = EditorGUILayout.ObjectField(label, value, type, true);
            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }
}
