using UnityEngine;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace wxb
{
    class ArrayAnyType : IListAnyType
    {
        public ArrayAnyType(System.Type arrayType) : base(arrayType, arrayType.GetElementType())
        {

        }

        protected override IList Create(int lenght)
        {
            return System.Array.CreateInstance(elementType, lenght);
        }
    }

    class ListAnyType : IListAnyType
    {
        ConstructorInfo ctor_info;
        object elementDefaultValue = null;
        static System.Type[] ctor_type_param = new System.Type[1] { typeof(int) };
        static object[] ctor_param = new object[1] { 0 };

        public ListAnyType(System.Type listType) : base(listType, IL.Help.GetElementByList(listType))
        {
            Init();
        }

        public ListAnyType(FieldInfo fieldInfo) : base(fieldInfo.FieldType, IL.Help.GetElementByList(fieldInfo))
        {
            Init();
        }

        void Init()
        {
            try
            {
                ctor_info = arrayType.GetConstructor(ctor_type_param);
                if (!elementType.IsClass)
                    elementDefaultValue = elementType.Assembly.CreateInstance(elementType.FullName);
            }
            catch (System.Exception ex)
            {
                wxb.L.LogException(ex);
            }
        }

        protected override IList Create(int lenght)
        {
            ctor_param[0] = lenght;
            try
            {
                IList list = ctor_info.Invoke(ctor_param) as IList;
                for (int i = 0; i < lenght; ++i)
                    list.Add(elementDefaultValue);
                return list;
            }
            catch (System.Exception ex)
            {
                wxb.L.LogException(ex);
                return null;
            }
        }
    }
}
