using UnityEditor;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if USE_HOT
using ILRuntime.Mono.Cecil;
using ILRuntime.Reflection;
using ILRuntime.Runtime.Intepreter;
#endif

namespace wxb.Editor
{
    class CSharpAgentType : ITypeGUI
    {
        public CSharpAgentType(System.Type type)
        {
            this.type = type;

            unityType = IL.Help.GetField(type, "unity").FieldType;
            csharpAgentSerialize = BinarySerializable.GetByType(type) as CSharpAgentSerialize;
        }

        System.Type type;
        System.Type unityType;
        CSharpAgentSerialize csharpAgentSerialize;

        bool ITypeGUI.OnGUI(object parent, FieldInfo info)
        {
            using (new IndentLevel())
            {
                bool isDirty = false;
                object ov = info.GetValue(parent);
                object nv = OnGUI(info.Name, ov, info.FieldType, out isDirty);
                if (isDirty)
                {
                    info.SetValue(parent, nv);
                    return true;
                }

                return false;
            }
        }

        public object OnGUI(string label, object value, System.Type type, out bool isDirty)
        {
#if USE_HOT
            if (type is ILRuntimeWrapperType)
            {
                type = ((ILRuntimeWrapperType)type).RealType;
            }
#endif
            isDirty = false;
            var src = CSharpAgentSerialize.GetUnityObject(this.type, value);
            var nv = EditorGUILayout.ObjectField(label, src, unityType, true);
            if (nv != src)
            {
                isDirty = true;
                csharpAgentSerialize.SetObject(ref value, nv);
            }
            else
                isDirty = false;

            return value;
        }
    }
}
