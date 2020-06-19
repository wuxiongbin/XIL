using UnityEngine;
using System.Reflection;
using System.Collections.Generic;

namespace wxb.Editor
{
    public class SmartEditor : ITypeGUI
    {
        public SmartEditor(System.Type type, ITypeGUI selfTypeGUI)
        {
            baseType = type;
            this.selfTypeGUI = selfTypeGUI;
        }

        ITypeGUI selfTypeGUI;
        System.Type baseType;

        public object OnGUI(string label, object value, System.Type type, out bool isDirty)
        {
            var typeGUI = TypeEditor.Get(value.GetType(), null);
            typeGUI.OnGUI(label, value, value.GetType(), out isDirty);
            return value;
        }

        Dictionary<string, string> keys = new Dictionary<string, string>();

        string GetKey(string key)
        {
            keys.TryGetValue(key, out var value);
            return value;
        }

        void SetKey(string key, string value)
        {
            keys[key] = value;
        }

        public bool OnGUI(object parent, FieldInfo info)
        {
            using (new IndentLevel())
            {
                bool isDirty = false;
                {
                    string key = parent.GetHashCode().ToString() + info.GetHashCode().ToString();
                    var allTypes = IL.Help.GetBaseType(baseType.FullName);

                    bool isSet = false;
                    string newTypename;
                    using (new GUIColor(Color.cyan))
                    {
                        var typeName = GetKey(key);
                        UnityEditor.EditorGUILayout.BeginHorizontal();
                        newTypename = IL.Editor.ILMonoEditor.StringPopupT($"设置{info.Name}类型", typeName, allTypes, (System.Type t) => { return t.FullName; }, "");
                        SetKey(key, newTypename);
                        isSet = GUILayout.Button("设置");
                        UnityEditor.EditorGUILayout.EndHorizontal();
                    }

                    if (isSet)
                    {
                        var newInstance = IL.Help.Create(IL.Help.GetTypeByFullName(newTypename));
                        var value = info.GetValue(parent);
                        if (value != null)
                        {
                            // 赋值下
                            var stream = BinarySerializable.WriteTo(value);
                            BinarySerializable.MergeFrom(newInstance, stream);
                        }

                        info.SetValue(parent, newInstance);
                        isDirty = true;

                        ((AnyType)TypeEditor.Get(newInstance.GetType(), null)).SetFoldout(newInstance, true);
                    }
                }

                object current = info.GetValue(parent);
                if (current == null)
                    return false;

                bool isd = false;
                if (current.GetType() == baseType)
                    selfTypeGUI.OnGUI(string.Format("{1} {0}", info.Name, current.GetType().Name), current, current.GetType(), out isd);
                else
                {
                    OnGUI(string.Format("{1} {0}", info.Name, current.GetType().Name), current, current.GetType(), out isd);
                }

                return isDirty | isd;
            }
        }
    }
}
