using System.Reflection;
using System.Collections.Generic;
using System;
using UnityEditor;
#if USE_HOT
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Reflection;
#endif

namespace wxb.Editor
{
    public interface ITypeGUI
    {
        bool OnGUI(object parent, FieldInfo info);
        object OnGUI(string label, object value, System.Type type, out bool isDirty);
    }

    class EmptyTypeGUI : ITypeGUI
    {
        public bool OnGUI(object parent, FieldInfo info)
        {
            return false;
        }

        public object OnGUI(string label, object value, System.Type type, out bool isDirty)
        {
            isDirty = false;
            return value;
        }
    }

    public static class TypeEditor 
    {
        static TypeEditor()
        {
            Init();
        }

        // 基础类型
        static Dictionary<string, ITypeGUI> BaseTypes = new Dictionary<string, ITypeGUI>();
        static Dictionary<System.Type, ITypeGUI> AllTypes = new Dictionary<System.Type, ITypeGUI>();
        static Dictionary<FieldInfo, ITypeGUI> FieldInfoTypes = new Dictionary<FieldInfo, ITypeGUI>();
        static ITypeGUI unityObjectGUI;
        static ITypeGUI emptyTypeGUI;

        public static void Release()
        {
            AllTypes.Clear();
            FieldInfoTypes.Clear();
            BaseTypes.Clear();
            Init();
        }

        [UnityEditor.InitializeOnLoadMethod]
        static void InitializeOnLoadMethod()
        {
            wxb.IL.Help.on_release_all = Release;
        }

        static void Init()
        {
            emptyTypeGUI = new EmptyTypeGUI();
            unityObjectGUI = new ObjectType();

            BaseTypes.Add(typeof(int).FullName, new IntType());
            BaseTypes.Add(typeof(uint).FullName, new UIntType());
            BaseTypes.Add(typeof(sbyte).FullName, new sByteType());
            BaseTypes.Add(typeof(byte).FullName, new ByteType());
            BaseTypes.Add(typeof(char).FullName, new CharType());
            BaseTypes.Add(typeof(short).FullName, new ShortType());
            BaseTypes.Add(typeof(ushort).FullName, new UShortType());
            BaseTypes.Add(typeof(long).FullName, new LongType());
            BaseTypes.Add(typeof(ulong).FullName, new ULongType());
            BaseTypes.Add(typeof(float).FullName, new FloatType());
            BaseTypes.Add(typeof(double).FullName, new DoubleType());
            BaseTypes.Add(typeof(string).FullName, new StrType());
            BaseTypes.Add(typeof(bool).FullName, new BoolType());
        }

        public static ITypeGUI Get(System.Type type, FieldInfo fieldInfo)
        {
            ITypeGUI typeGUI = null;
            if (BaseTypes.TryGetValue(type.FullName, out typeGUI))
                return typeGUI;

            if (fieldInfo == null)
            {
                if (AllTypes.TryGetValue(type, out typeGUI))
                    return typeGUI;

                typeGUI = GetTypeGUI(type, null);
                AllTypes.Add(type, typeGUI);
                return typeGUI;
            }
            else
            {
                if (FieldInfoTypes.TryGetValue(fieldInfo, out typeGUI))
                    return typeGUI;

                typeGUI = GetTypeGUI(type, fieldInfo);
                FieldInfoTypes.Add(fieldInfo, typeGUI);
                return typeGUI;
            }
        }

        static ITypeGUI GetTypeGUI(System.Type type, FieldInfo fieldInfo)
        {
            if (IL.Help.isType(type, typeof(UnityEngine.Object)))
                return unityObjectGUI;

            if (type.IsEnum)
                return new EnumType(type);

            if (type == typeof(RefType))
            {
                if (fieldInfo == null)
                    return emptyTypeGUI;

                var ils = fieldInfo.GetCustomAttribute<ILSerializable>();
                return new RefTypeEditor(IL.Help.GetTypeByFullName(ils.typeName));
            }

            var atts = type.GetCustomAttributes(typeof(SmartAttribute), false);
            if (atts != null && atts.Length > 0) 
            {
                return new SmartEditor(type, new AnyType(type, IL.Help.GetSerializeField(type)));
            }

#if USE_HOT
            ILRuntimeFieldInfo ilFieldInfo = (ILRuntimeFieldInfo)fieldInfo;
            if (ilFieldInfo != null && (type.IsArray || IL.Help.isListType(type)))
            {
                var isListType = type.IsArray ? false : true;
                int arrayCount = 0;
                string elementType;
                BinarySerializable.GetElementType(ilFieldInfo.Definition.FieldType, ref arrayCount, out elementType);
                if (arrayCount >= 2)
                {
                    // 2维数组
                    return new ArrayListHot(elementType, arrayCount, isListType);
                }
            }
#endif
            if (type.IsArray)
            {
                var elementType = type.GetElementType();
                var arrayGUI = new ArrayTypeEditor(type, elementType, Get(elementType, null));
                return arrayGUI;
            }
            else if (IL.Help.isListType(type))
            {
                System.Type elementType = null;
                if (fieldInfo != null)
                    elementType = IL.Help.GetElementByList(fieldInfo);
                else
                    elementType = type.GetGenericArguments()[0];

                return new ListTypeEditor(type, elementType, Get(elementType, null));
            }
#if USE_HOT
            if (type is ILRuntimeType)
            {
                if ((type.Name.EndsWith("[]")))
                    return emptyTypeGUI;

                if (!((ILRuntimeType)type).ILType.TypeDefinition.IsSerializable)
                    return emptyTypeGUI;
            }
            else
#endif
            {
                if (!type.IsSerializable)
                    return emptyTypeGUI;
            }

            return new AnyType(type, IL.Help.GetSerializeField(type));
        }

        public static bool OnGUI(object parent)
        {
            bool isDirty = false;
            List<FieldInfo> fieldinfos = IL.Help.GetSerializeField(parent);
            for (int i = 0; i < fieldinfos.Count; ++i)
            {
                var field = fieldinfos[i];
                if (Get(field.FieldType, field).OnGUI(parent, field))
                    isDirty = true;
            }

            return isDirty;
        }
    }
}
