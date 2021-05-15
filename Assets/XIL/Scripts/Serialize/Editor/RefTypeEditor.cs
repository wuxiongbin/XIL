using UnityEngine;
using System.Reflection;
using System.Collections.Generic;

namespace wxb.Editor
{
    public class RefTypeEditor : ITypeGUI
    {
        public RefTypeEditor(System.Type type)
        {
            this.type = type;
            typeGUI = TypeEditor.Get(type, null);
        }

        ITypeGUI typeGUI;
        System.Type type;

        public object OnGUI(string label, object value, System.Type type, out bool isDirty)
        {
            RefType refType = (RefType)value;
            typeGUI.OnGUI(label, refType.Instance, refType.Type, out isDirty);
            return value;
        }

        public bool OnGUI(object parent, FieldInfo info)
        {
            using (new IndentLevel())
            {
                bool isDirty = false;

                object current = info.GetValue(parent);
                if (current == null)
                {
                    current = new RefType(type);
                    info.SetValue(parent, current);
                    isDirty = true;
                }

                bool isd = false;
                OnGUI(string.Format("{1} {0}", info.Name, type.Name), current, type, out isd);
                return isDirty | isd;
            }
        }


        // 自动赋值
        public bool AutoSetValue(object value, FieldInfo fieldInfo, GameObject root)
        {
            return false;
        }
    }
}
