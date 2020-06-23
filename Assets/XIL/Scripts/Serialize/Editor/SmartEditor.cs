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
            AnyType anyType;
            var currentType = value == null ? baseType : IL.Help.GetInstanceType(value);
            if (currentType == baseType)
            {
                anyType = (AnyType)selfTypeGUI;
            }
            else
            {
                anyType = (AnyType)TypeEditor.Get(currentType, null);
            }

            value = anyType.OnGUI(label, value, currentType, out isDirty);
            if (anyType.GetFoldout(value))
            {
                using (new IndentLevel())
                {
                    if (ShowTypeSelect(ref value, label, "OnGUI." + value.GetHashCode().ToString()))
                        isDirty = true;
                }
            }

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

        // x = y
        static void SetValue(object x, object y)
        {
            List<FieldInfo> xinfos = IL.Help.GetSerializeField(x);
            List<FieldInfo> yinfos = IL.Help.GetSerializeField(y);

            for (int i = 0; i < xinfos.Count; ++i)
            {
                var xfieldInfo = xinfos[i];
                var yfieldInfo = yinfos.Find((yi) => { return yi.Name == xfieldInfo.Name && yi.FieldType == xfieldInfo.FieldType; });
                if (yfieldInfo == null)
                    continue;

                xfieldInfo.SetValue(x, yfieldInfo.GetValue(y));
            }
        }

        bool ShowTypeSelect(ref object value, string label, string key)
        {
            bool isDirty = false;
            var allTypes = IL.Help.GetBaseType(baseType.FullName);
            {
                for (int i = allTypes.Count - 1; i >= 0; --i)
                {
                    var at = allTypes[i];
                    if (at.IsAbstract || !at.IsSerializable)
                        allTypes.RemoveAt(i);
                }
                allTypes.Insert(0, null);
            }

            bool isSet = false;
            string newTypename;
            using (new GUIColor(Color.cyan))
            {
                var typeName = GetKey(key);
                if (string.IsNullOrEmpty(typeName) && value != null)
                    typeName = IL.Help.GetInstanceType(value).FullName;
                UnityEditor.EditorGUILayout.BeginHorizontal();
                newTypename = IL.Editor.ILMonoEditor.StringPopupT($"设置{label}类型", typeName, allTypes, (System.Type t) => { return t == null ? "null" : t.FullName; }, "");
                SetKey(key, newTypename);
                if (newTypename == "null")
                    newTypename = string.Empty;
                isSet = GUILayout.Button("设置");
                UnityEditor.EditorGUILayout.EndHorizontal();
            }

            if (isSet)
            {
                var newInstance = string.IsNullOrEmpty(newTypename) ? null : IL.Help.Create(IL.Help.GetTypeByFullName(newTypename));
                if (value != null && newInstance != null)
                {
                    // 赋值下
                    SetValue(newInstance, value);
                }

                if (newInstance != null)
                {
                    var te = TypeEditor.Get(IL.Help.GetInstanceType(newInstance), null);
                    if (te is AnyType)
                        ((AnyType)te).SetFoldout(newInstance, true);
                }

                value = newInstance;
                isDirty = true;
            }

            return isDirty;
        }

        public bool OnGUI(object parent, FieldInfo info)
        {
            using (new IndentLevel())
            {
                bool isDirty = false;
                object current = info.GetValue(parent);
                if (current == null)
                {
                    string key = parent.GetHashCode().ToString() + (info == null ? "" : info.GetHashCode().ToString());
                    if (ShowTypeSelect(ref current, info.Name, key))
                    {
                        info.SetValue(parent, current);
                        isDirty = true;
                        return isDirty;
                    }
                }

                if (current == null)
                    return isDirty;

                var type = IL.Help.GetInstanceType(current);
                bool isd = false;
                if (type == baseType)
                    current = selfTypeGUI.OnGUI(string.Format("{1} {0}", info.Name, type.Name), current, type, out isd);
                else
                {
                    current = OnGUI(string.Format("{1} {0}", info.Name, type.Name), current, type, out isd);
                }

                if (isd)
                {
                    info.SetValue(parent, current);
                }

                return isDirty | isd;
            }
        }
    }
}
