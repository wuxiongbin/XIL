using UnityEditor;
using System.Reflection;
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
            UnityEngine.Object nv = EditorGUILayout.ObjectField(label, value, type, true);
            if (nv != value)
                isDirty = true;
            else
                isDirty = false;

            return nv;
        }
    }

    class ArrayObjectType : ITypeGUI
    {
        public ArrayObjectType(System.Type elementType, ITypeGUI element)
        {
            this.element = element;
            this.elementType = elementType;
        }

        ITypeGUI element;
        System.Type elementType;

        Dictionary<int, bool> isFoldouts = new Dictionary<int, bool>();

        public object OnGUI(string label, object value, System.Type type, out bool isDirty)
        {
            //if (value is ILTypeInstance)
            //{
            //    isDirty = false;
            //    ILRuntimeType rt = type as ILRuntimeType;
            //    var members = rt.GetMembers(BindingFlags.Instance | BindingFlags.Public);
            //    ILTypeInstance current = value as ILTypeInstance;
            //    int size = (int)type.GetProperty("Lenght").GetValue(value, null);

            //    return value;
            //}
            //else
            {
                System.Array current = value as System.Array;
                isDirty = false;

                int hashcode = current.GetHashCode();
                var isFoldout = false;
                if (!isFoldouts.TryGetValue(hashcode, out isFoldout))
                    isFoldouts.Add(hashcode, isFoldout);

                isFoldout = EditorGUILayout.Foldout(isFoldout, label);
                isFoldouts[hashcode] = isFoldout;
                if (isFoldout)
                {
                    int size = current.Length;
                    int ns = EditorGUILayout.IntField("size", size);
                    if (size != ns)
                    {
                        var newV = System.Array.CreateInstance(elementType, ns);
                        int minV = System.Math.Min(size, ns);
                        for (int i = 0; i < minV; ++i)
                            newV.SetValue(current.GetValue(i), i);

                        current = newV;
                        isFoldouts[newV.GetHashCode()] = isFoldout;
                        isFoldouts.Remove(hashcode);
                        size = ns;
                        isDirty = true;
                    }

                    using (new IndentLevel())
                    {
                        for (int i = 0; i < size; ++i)
                        {
                            bool cd = false;
                            object v = element.OnGUI("element " + i, current.GetValue(i), elementType, out cd);
                            if (cd)
                            {
                                current.SetValue(v, i);
                                isDirty = true;
                            }
                        }
                    }
                }
                return current;
            }
        }

        public bool OnGUI(object parent, FieldInfo info)
        {
            using (new IndentLevel())
            {
                var current = info.GetValue(parent);
                bool isDirty = false;
                if (current == null)
                {
                    current = System.Array.CreateInstance(elementType, 0);
                    info.SetValue(parent, current);
                    isDirty = true;
                }

                bool isd = false;
                object nv = OnGUI(info.Name, current, info.FieldType, out isd);
                if (isd)
                    info.SetValue(parent, nv);

                return isDirty | isd;
            }
        }
    }
}
