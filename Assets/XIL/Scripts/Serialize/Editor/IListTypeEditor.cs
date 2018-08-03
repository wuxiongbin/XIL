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
    abstract class IListTypeEditor : ITypeGUI
    {
        public IListTypeEditor(System.Type listType, System.Type elementType, ITypeGUI element)
        {
            this.listType = listType;
            this.element = element;
            this.elementType = elementType;
        }

        protected ITypeGUI element;
        protected System.Type elementType;
        protected System.Type listType;

        Dictionary<int, bool> isFoldouts = new Dictionary<int, bool>();

        protected abstract IList CreateList(System.Type elementType, int count);

        public object OnGUI(string label, object value, System.Type type, out bool isDirty)
        {
            IList current = value as IList;
            isDirty = false;

            int hashcode = current.GetHashCode();
            var isFoldout = false;
            if (!isFoldouts.TryGetValue(hashcode, out isFoldout))
                isFoldouts.Add(hashcode, isFoldout);

            isFoldout = EditorGUILayout.Foldout(isFoldout, label);
            isFoldouts[hashcode] = isFoldout;
            if (isFoldout)
            {
                int size = current.Count;
                int ns = EditorGUILayout.IntField("size", size);
                if (size != ns)
                {
                    var newV = CreateList(elementType, ns);
                    int minV = System.Math.Min(size, ns);
                    for (int i = 0; i < minV; ++i)
                        newV[i] = current[i];

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
                        object v = element.OnGUI("element " + i, current[i], elementType, out cd);
                        if (cd)
                        {
                            current[i] = v;
                            isDirty = true;
                        }
                    }
                }
            }

            return current;
        }

        public bool OnGUI(object parent, FieldInfo info)
        {
            using (new IndentLevel())
            {
                var current = info.GetValue(parent);
                bool isDirty = false;
                if (current == null)
                {
                    current = CreateList(elementType, 0);
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
