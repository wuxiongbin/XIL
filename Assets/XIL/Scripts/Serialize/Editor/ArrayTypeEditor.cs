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

        protected override void SetDefault(IList list, int count)
        {
            if (elementTypeDefaultValue == null)
            {
                for (int i = 0; i < count; ++i)
                {
                    var value = CreateByType(elementType);
                    list[i] = value;
                }
            }
            else
            {
                for (int i = 0; i < count; ++i)
                    list[i] = elementTypeDefaultValue;
            }
        }

        protected override IList Create(System.Type elementType, int count)
        {
            IList list = System.Array.CreateInstance(elementType, count);
            return list;
        }
    }

    class ListTypeEditor : IListTypeEditor
    {
        ConstructorInfo ctor_info;

        public ListTypeEditor(System.Type listType, System.Type elementType, ITypeGUI element) : base(listType, elementType, element)
        {
            ctor_info = listType.GetConstructor(new System.Type[] { });
        }

        protected override void SetDefault(IList list, int count)
        {
            if (elementTypeDefaultValue == null)
            {
                for (int i = 0; i < count; ++i)
                    list.Add(CreateByType(elementType));
            }
            else
            {
                for (int i = 0; i < count; ++i)
                    list.Add(elementTypeDefaultValue);
            }
        }

        protected override IList Create(System.Type elementType, int count)
        {
            IList list = ctor_info.Invoke(new object[] { }) as IList;
            return list;
        }
    }
}
