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
        Dictionary<int, EditorPageBtn> EditorPageBtns = new Dictionary<int, EditorPageBtn>();

        EditorPageBtn GetOrCreate(int hashcode)
        {
            EditorPageBtn epb;
            if (EditorPageBtns.TryGetValue(hashcode, out epb))
                return epb;

            epb = new EditorPageBtn();
            EditorPageBtns.Add(hashcode, epb);
            return epb;
        }

        public object OnGUI(string label, object value, System.Type type, out bool isDirty)
        {
            IList current = value as IList;
            isDirty = false;

            int hashcode = current.GetHashCode();
            var isFoldout = false;
            if (!isFoldouts.TryGetValue(hashcode, out isFoldout))
                isFoldouts.Add(hashcode, isFoldout);

            isFoldout = EditorGUILayout.Foldout(isFoldout, 
                current is System.Array ?
                string.Format("{1}[] {0}", label, elementType.Name) :
                string.Format("List<{1}> {0}", label, elementType.Name));
            isFoldouts[hashcode] = isFoldout;
            if (isFoldout)
            {
                int size = current.Count;
                int ns = EditorGUILayout.IntField("Size", size);
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
                    int begin = 0;
                    int end = size;
                    if (size >= 30)
                    {
                        var epb = GetOrCreate(hashcode);
                        epb.total = current.Count;
                        epb.pageNum = 30;
                        epb.OnRender();

                        begin = epb.beginIndex;
                        end = epb.endIndex;
                    }

                    for (int i = begin; i < end; ++i)
                    {
                        bool cd = false;
                        object v = element.OnGUI(string.Format("[{0}]", i), current[i], elementType, out cd);
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
