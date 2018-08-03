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
            AllTypes.Add(typeof(int).FullName, new IntType());
            AllTypes.Add(typeof(uint).FullName, new UIntType());
            AllTypes.Add(typeof(sbyte).FullName, new sByteType());
            AllTypes.Add(typeof(byte).FullName, new ByteType());
            AllTypes.Add(typeof(char).FullName, new CharType());
            AllTypes.Add(typeof(short).FullName, new ShortType());
            AllTypes.Add(typeof(ushort).FullName, new UShortType());
            AllTypes.Add(typeof(long).FullName, new LongType());
            AllTypes.Add(typeof(ulong).FullName, new ULongType());
            AllTypes.Add(typeof(float).FullName, new FloatType());
            AllTypes.Add(typeof(double).FullName, new DoubleType());
            AllTypes.Add(typeof(string).FullName, new StrType());
            AllTypes.Add(typeof(UnityEngine.Object).FullName, new ObjectType());
        }
        
        // 基础类型
        static Dictionary<string, ITypeGUI> AllTypes = new Dictionary<string, ITypeGUI>();

        public static ITypeGUI Get(System.Type type)
        {
            ITypeGUI typeGUI = null;
            string fullName = type.FullName;
            if (AllTypes.TryGetValue(fullName, out typeGUI))
                return typeGUI;

            if (IL.Help.isType(type, typeof(UnityEngine.Object)))
            {
                return AllTypes[typeof(UnityEngine.Object).FullName];
            }

            if (type.IsArray)
            {
                var elementType = type.GetElementType();
                var arrayGUI = new ArrayTypeEditor(type, elementType, Get(elementType));
                AllTypes.Add(fullName, arrayGUI);

                return arrayGUI;
            }
            else if (type.IsGenericType && type.FullName.StartsWith("System.Collections.Generic.List`1[["))
            {
                var elementTypes = type.GetGenericArguments();
                if (elementTypes.Length == 1)
                {
                    var arrayGUI = new ListTypeEditor(type, elementTypes[0], Get(elementTypes[0]));
                    AllTypes.Add(fullName, arrayGUI);

                    return arrayGUI;
                }
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
            AllTypes.Add(fullName, gui);
            return gui;
        }

        public static bool OnGUI(object parent)
        {
            bool isDirty = false;
            List<FieldInfo> fieldinfos = IL.Help.GetSerializeField(parent);
            for (int i = 0; i < fieldinfos.Count; ++i)
            {
                var field = fieldinfos[i];
                isDirty |= Get(field.FieldType).OnGUI(parent, field);
            }

            return isDirty;
        }
    }
}
