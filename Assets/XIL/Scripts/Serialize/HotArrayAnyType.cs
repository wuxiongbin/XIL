#if USE_ILRT
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

        static IList CreateArray<T>(int arrayCount, int count)
        {
            IList list = null;
            switch (arrayCount)
            {
            case 2:
                list = new T[count][];
                for (int i = 0; i < count; ++i)
                    list[i] = new T[0];
                break;

            case 3:
                list = new T[count][][];
                for (int i = 0; i < count; ++i)
                    list[i] = new T[0][];
                break;

            case 4:
                list = new T[count][][][];
                for (int i = 0; i < count; ++i)
                    list[i] = new T[0][][];
                break;

            case 5:
                list = new T[count][][][][];
                for (int i = 0; i < count; ++i)
                    list[i] = new T[0][][][];
                break;
            default:
                UnityEngine.Debug.LogErrorFormat("CreateArray {0} type arrayCount:{1}", typeof(T).Name, arrayCount);
                break;
            }

            return list;
        }

        static IList CreateList<T>(int arrayCount, int count)
        {
            IList list = null;
            switch (arrayCount)
            {
            case 2:
                list = new List<List<T>>(count);
                for (int i = 0; i < count; ++i)
                    list.Add(new List<T>());
                break;

            case 3:
                list = new List<List<List<T>>>(count);
                for (int i = 0; i < count; ++i)
                    list.Add(new List<List<T>>());
                break;

            case 4:
                list = new List<List<List<List<T>>>>(count);
                for (int i = 0; i < count; ++i)
                    list.Add(new List<List<List<T>>>());
                break;

            case 5:
                list = new List<List<List<List<List<T>>>>>(count);
                for (int i = 0; i < count; ++i)
                    list.Add(new List<List<List<List<T>>>>());
                break;

            default:
                UnityEngine.Debug.LogErrorFormat("CreateList {0} type arrayCount:{1}", typeof(T).Name, arrayCount);
                break;
            }

            return list;
        }

        protected override IList Create(int lenght)
        {
            if (isListType)
            {
                return IL.Help.CreateIList(elementType, arrayCount, lenght);
            }
            else
            {
                return IL.Help.CreateArray(elementType, arrayCount, lenght);
            }
        }
    }
}
#endif