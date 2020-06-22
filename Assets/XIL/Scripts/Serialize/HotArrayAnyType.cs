#if USE_HOT
using UnityEngine;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using ILRuntime.Reflection;

namespace wxb
{
    class HotArrayAnyType : IListAnyType
    {
        bool isListType;
        int arrayCount;
        System.Type elementType;

        public HotArrayAnyType(System.Type listType, FieldInfo fieldInfo)
        {
            var isListType = listType.IsArray ? false : true;
            int arrayCount = 0;
            string elementType = null;

            ILRuntimeFieldInfo ilFieldInfo = (ILRuntimeFieldInfo)fieldInfo;
            BinarySerializable.GetElementType(ilFieldInfo.Definition.FieldType, ref arrayCount, out elementType);

            Reset(IL.Help.GetType(elementType), isListType, arrayCount);
        }

        public HotArrayAnyType(System.Type elementType, bool isListType, int arrayCount)
        {
            Reset(elementType, isListType, arrayCount);
        }

        public void Reset(System.Type elementType, bool isListType, int arrayCount)
        {
            this.elementType = elementType;
            this.isListType = isListType;
            this.arrayCount = arrayCount;
            if (arrayCount == 1)
                elementTypeSerialize = BinarySerializable.GetByType(elementType);
            else
                elementTypeSerialize = new HotArrayAnyType(elementType, isListType, arrayCount - 1);

            elementTypeFullName = this.elementType.FullName;
        }

        string elementTypeFullName;
        static RefType refType { get { return new RefType(true, IL.Help.GetTypeByFullName("hot.RegArrayType")); } }

        protected override IList Create(int lenght)
        {
            string name = !isListType ? "CreateArray" : "CreateList";
            return (IList)refType.InvokeMethodReturn(name, elementTypeFullName, arrayCount, lenght);
        }
    }
}
#endif