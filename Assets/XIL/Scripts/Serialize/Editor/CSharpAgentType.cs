using UnityEditor;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if USE_ILRT
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

            unityType = IL.Help.GetRealType(IL.Help.GetField(type, "unity").FieldType);
            realType = IL.Help.GetRealType(IL.Help.GetField(type, "value_").FieldType);
            csharpAgentSerialize = BinarySerializable.GetByType(type) as CSharpAgentSerialize;
        }

        System.Type type;
        System.Type unityType;
        System.Type realType; // Unity序列化对象绑定的类型
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
            type = wxb.IL.Help.GetRealType(type);
            isDirty = false;
            var src = CSharpAgentSerialize.GetUnityObject(this.type, value);
            Object nv = null;
            ObjectType.CopyFieldName(label, () =>
            {
                nv = EditorGUILayout.ObjectField($"{label}({realType.Name})", src, unityType, true);
            });
            if (nv != src)
            {
                isDirty = true;
                csharpAgentSerialize.SetObject(ref value, nv);
            }
            else
                isDirty = false;

            return value;
        }

        // 自动赋值
        public bool AutoSetValue(object value, FieldInfo fieldInfo, GameObject root)
        {
            object cv = fieldInfo.GetValue(value);
            if (cv != null)
            {
                var src = CSharpAgentSerialize.GetUnityObject(type, cv);
                if (src != null)
                    return false;
            }

            var obj = ObjectType.GetFind(root.transform, fieldInfo.Name, unityType, (itor) => { return IsBindType(itor as Component, realType); });
            if (obj == null)
                obj = GetILMonoBindType(root, unityType, realType);
            if (obj != null)
            {
                csharpAgentSerialize.SetObject(ref cv, obj);
                fieldInfo.SetValue(value, cv);
                return true;
            }

            return false;
        }

        static bool IsBindType(Component component, System.Type bindType)
        {
            var property = IL.Help.GetProperty(IL.Help.GetInstanceType(component), "refType");
            if (property == null)
                return false;

            var value = property.GetValue(component) as RefType;
            if (value == null)
                return false;

            if (IL.Help.GetRealType(value.Type) == bindType)
                return true;
            return false;
        }

        static Component GetILMonoBindType(GameObject root, System.Type unityType, System.Type bindType)
        {
            bindType = IL.Help.GetRealType(bindType);
            var components = root.GetComponentsInChildren(unityType, true);
            int cnt = components.Length;
            for (int i = 0; i < cnt; ++i)
            {
                var component = components[i];
                if (IsBindType(component, bindType))
                    return component;
            }

            return null;
        }
    }
}
