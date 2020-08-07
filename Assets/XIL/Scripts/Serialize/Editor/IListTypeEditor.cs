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

            if (elementType.IsClass)
                elementTypeDefaultValue = null;
            else
                elementTypeDefaultValue = elementType.Assembly.CreateInstance(elementType.FullName);
        }

        protected object elementTypeDefaultValue;
        protected ITypeGUI element;
        protected System.Type elementType;
        protected System.Type listType;

        Dictionary<int, bool> isFoldouts = new Dictionary<int, bool>();

        protected static object CreateByType(System.Type type)
        {
            if (typeof(UnityEngine.Object).IsAssignableFrom(type))
                return null;

            return IL.Help.Create(type);
        }

        protected abstract IList Create(System.Type elementType, int count);
        protected abstract void SetDefault(IList list, int count);

        protected IList CreateList(System.Type elementType, int count)
        {
            var list = Create(elementType, count);
            SetDefault(list, count);
            return list;
        }

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

        static string GetTypeNameSpace(System.Type type)
        {
#if USE_HOT
            if (type is ILRuntime.Reflection.ILRuntimeType)
            {
                var ilRT = ((ILRuntime.Reflection.ILRuntimeType)type);
                if (ilRT.ILType.TypeReference.IsNested)
                {
                    return GetTypeNameSpace(IL.Help.GetTypeByFullName(ilRT.ILType.TypeReference.DeclaringType.FullName));
                }
                else
                {
                    return ilRT.ILType.TypeReference.Namespace;
                }
            }
            else if (type is ILRuntime.Reflection.ILRuntimeWrapperType)
                type = ((ILRuntime.Reflection.ILRuntimeWrapperType)type).RealType;
#endif
            if (!type.IsNested)
                return type.Namespace;

            return GetTypeNameSpace(type.DeclaringType);
        }

        static string GetTypeName(System.Type type)
        {
            if (type.IsArray)
                return string.Format("{0}[]", GetTypeName(type.GetElementType()));

            if (IL.Help.isListType(type))
            {
                var element = type.GetGenericArguments()[0];
                return string.Format("List<{0}>", GetTypeName(element));
            }
            else
            {
                return type.FullName;
            }
        }

        public object OnGUI(string label, object value, System.Type type, out bool isDirty)
        {
            IList current = value as IList;
            isDirty = false;
            int hashcode = current.GetHashCode();
            var isFoldout = false;
            if (!isFoldouts.TryGetValue(hashcode, out isFoldout))
                isFoldouts.Add(hashcode, isFoldout);

            var elementName = elementType.FullName;
            {
                var ns = GetTypeNameSpace(elementType);
                if (!string.IsNullOrEmpty(ns))
                    elementName = elementName.Substring(ns.Length + 1);

                if (elementName.IndexOf('/') != -1)
                    elementName = elementName.Replace("/", ".");
            }

            isFoldout = EditorGUILayout.Foldout(isFoldout, string.Format("{0} {1}", GetTypeName(type), label));
            isFoldouts[hashcode] = isFoldout;
            if (isFoldout)
            {
                int size = current.Count;
                int ns = EditorGUILayout.IntField("Size", size);
                if (size != ns)
                {
                    bool isSet = true;
                    if (ns >= 1000)
                        isSet = EditorUtility.DisplayDialog("数组过多!", string.Format("确定要创建这么多({0})的数组吗?", ns), "确定", "取消");

                    if (isSet)
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
