using System.Reflection;
using System.Collections.Generic;
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
            AllTypes.Add(typeof(UnityEngine.Object), new ObjectType());

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
        }

        // 基础类型
        static Dictionary<System.Type, ITypeGUI> AllTypes = new Dictionary<System.Type, ITypeGUI>();
        static Dictionary<string, ITypeGUI> BaseTypes = new Dictionary<string, ITypeGUI>();

        public static ITypeGUI Get(System.Type type, FieldInfo fieldInfo)
        {
            ITypeGUI typeGUI = null;
            if (BaseTypes.TryGetValue(type.FullName, out typeGUI))
                return typeGUI;

            if (AllTypes.TryGetValue(type, out typeGUI))
                return typeGUI;

            if (IL.Help.isType(type, typeof(UnityEngine.Object)))
            {
                return AllTypes[typeof(UnityEngine.Object)];
            }

            if (type.IsArray)
            {
                var elementType = type.GetElementType();
                var arrayGUI = new ArrayTypeEditor(type, elementType, Get(elementType, null));
                AllTypes.Add(type, arrayGUI);

                return arrayGUI;
            }
            else if (IL.Help.isListType(type))
            {
                var elementType = IL.Help.GetElementByList(fieldInfo);
                var arrayGUI = new ListTypeEditor(type, elementType, Get(elementType, null));
                AllTypes.Add(type, arrayGUI);

                return arrayGUI;
            }
#if USE_HOT
            if (type is ILRuntimeType && (type.Name.EndsWith("[]")))
            {
                return new EmptyTypeGUI();
            }
#endif
            if (!type.IsSerializable
#if USE_HOT
                && (type.GetType() != typeof(ILRuntimeType) && !((ILRuntimeType)type).ILType.TypeDefinition.IsSerializable)
#endif
                )
            {
                return new EmptyTypeGUI();
            }
            List<FieldInfo> fieldinfos = IL.Help.GetSerializeField(type);
            var gui = new AnyType(type, fieldinfos);
            AllTypes.Add(type, gui);
            return gui;
        }

        public static bool OnGUI(object parent)
        {
            bool isDirty = false;
            List<FieldInfo> fieldinfos = IL.Help.GetSerializeField(parent);
            for (int i = 0; i < fieldinfos.Count; ++i)
            {
                var field = fieldinfos[i];
                isDirty |= Get(field.FieldType, field).OnGUI(parent, field);
            }

            return isDirty;
        }
    }
}
