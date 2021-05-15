#if USE_HOT
using UnityEditor;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using ILRuntime.Reflection;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Mono.Cecil;

namespace wxb.Editor
{
    public class ArrayListHot : ITypeGUI
    {
        public ArrayListHot()
        {

        }

        public ArrayListHot(string elementType, int arrayCount, bool isListType)
        {
            Reset(elementType, arrayCount, isListType);
        }

        // 自动赋值
        public bool AutoSetValue(object value, FieldInfo fieldInfo, UnityEngine.GameObject root)
        {
            return false;
        }

        protected void Reset(string elementType, int arrayCount, bool isListType)
        {
            this.arrayCount = arrayCount;
            this.elementType = elementType;
            this.isListType = isListType;
            if (isListType)
            {
                fullTypeName = $"List<{elementType}>";
                for (int i = 0; i < arrayCount - 1; ++i)
                    fullTypeName = $"List<{fullTypeName}>";
            }
            else
            {
                fullTypeName = elementType;
                for (int i = 0; i < arrayCount; ++i)
                    fullTypeName += "[]";
            }

            if (arrayCount == 1)
            {
                typeElement = IL.Help.GetTypeByFullName(elementType);
                elementTypeGUI = TypeEditor.Get(typeElement, null);
            }
            else
            {
                elementTypeGUI = new ArrayListHot(elementType, arrayCount - 1, isListType);
            }
        }

        System.Type typeElement;
        ITypeGUI elementTypeGUI;
        bool isListType = false;
        string fullTypeName;

        int arrayCount; // 数组维数
        string elementType; // 元素类型

        protected IList CreateList(int lenght)
        {
            var et = IL.Help.GetTypeByFullName(elementType);
            if (isListType)
            {
                return IL.Help.CreateIList(et, arrayCount, lenght);
            }
            else
            {
                return IL.Help.CreateArray(et, arrayCount, lenght);
            }
        }

        bool ITypeGUI.OnGUI(object parent, FieldInfo info)
        {
            using (new IndentLevel())
            {
                var current = info.GetValue(parent);
                bool isDirty = false;
                if (current == null)
                {
                    current = CreateList(0);
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

        Dictionary<int, bool> isFoldouts = new Dictionary<int, bool>();
        public object OnGUI(string label, object value, System.Type type, out bool isDirty)
        {
            IList current = value as IList;
            isDirty = false;
            int hashcode = current.GetHashCode();
            var isFoldout = false;
            if (!isFoldouts.TryGetValue(hashcode, out isFoldout))
                isFoldouts.Add(hashcode, isFoldout);

            isFoldout = EditorGUILayout.Foldout(isFoldout, string.Format("{0} {1}", fullTypeName, label));
            isFoldouts[hashcode] = isFoldout;
            if (isFoldout)
            {
                int size = current.Count;
                int ns = EditorGUILayout.IntField("Size", size);
                if (size != ns)
                {
                    bool isSet = true;
                    if (ns >= 1000)
                        isSet = EditorUtility.DisplayDialog("数组过多!", $"确定要创建这么多({ns})的数组吗?", "确定", "取消");

                    if (isSet)
                    {
                        var newV = CreateList(ns);
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
                        object v = elementTypeGUI.OnGUI(string.Format("[{0}]", i), current[i], typeElement, out cd);
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
    }

    //class HotArrayList : ArrayListHot
    //{
    //    public HotArrayList(System.Type listType, FieldInfo fieldInfo)
    //    {
    //        var isListType = listType.IsArray ? false : true;
    //        int arrayCount = 0;
    //        string elementType = null;

    //        ILRuntimeFieldInfo ilFieldInfo = (ILRuntimeFieldInfo)fieldInfo;
    //        BinarySerializable.GetElementType(ilFieldInfo.Definition.FieldType, ref arrayCount, out elementType);

    //        Reset(elementType, arrayCount, isListType);
    //    }
    //}
}
#endif