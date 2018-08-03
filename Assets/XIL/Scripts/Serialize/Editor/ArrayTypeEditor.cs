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
    class ArrayTypeEditor : IListTypeEditor
    {
        public ArrayTypeEditor(System.Type listType, System.Type elementType, ITypeGUI element) : base(listType, elementType, element)
        {

        }
        
        protected override IList CreateList(System.Type elementType, int count)
        {
            return System.Array.CreateInstance(elementType, count);
        }
    }

    class ListTypeEditor : IListTypeEditor
    {
        ConstructorInfo ctor_info;

        object elementTypeDefaultValue;

        public ListTypeEditor(System.Type listType, System.Type elementType, ITypeGUI element) : base(listType, elementType, element)
        {
            ctor_info = listType.GetConstructor(new System.Type[] { });
            if (elementType.IsClass)
                elementTypeDefaultValue = null;
            else
                elementTypeDefaultValue = elementType.Assembly.CreateInstance(elementType.FullName);
        }

        protected override IList CreateList(System.Type elementType, int count)
        {
            IList list = ctor_info.Invoke(new object[] { }) as IList;
            for (int i = 0; i < count; ++i)
                list.Add(elementTypeDefaultValue);

            return list;
        }
    }
}
