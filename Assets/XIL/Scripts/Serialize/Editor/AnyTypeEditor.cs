using UnityEngine;
using System.Reflection;
using System.Collections.Generic;

namespace wxb.Editor
{
    public class GUIColor : System.IDisposable
    {
        Color color;

        public GUIColor(Color color)
        {
            this.color = GUI.color;
            GUI.color = color;
        }

        public void Dispose()
        {
            GUI.color = color;
        }

    }
    public class IndentLevel : System.IDisposable
    {
        public IndentLevel()
        {
            ++UnityEditor.EditorGUI.indentLevel;
        }

        public void Dispose()
        {
            --UnityEditor.EditorGUI.indentLevel;
        }
    }

    public class AnyType : ITypeGUI
    {
        static public string GetPath(UnityEngine.GameObject root, UnityEngine.GameObject child)
        {
            if (root == child)
                return "";

            List<string> childs = new List<string>();
            var current = child.transform;
            var rt = root == null ? null : root.transform;
            while (true)
            {
                childs.Add(current.name);
                current = current.parent;
                if (current == null || current == rt)
                    break;
            }

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(childs[childs.Count - 1]);
            for (int i = childs.Count - 2; i >= 0; --i)
                sb.AppendFormat("/{0}", childs[i]);

            return sb.ToString();
        }

        public static bool isInherited(System.Type type, System.Type baseType)
        {
            if (type == null)
                return false;

            if (type == baseType)
                return true;

            if (type.BaseType == null)
                return false;

            if (type.BaseType == baseType)
                return true;

            return isInherited(type.BaseType, baseType);
        }

        public AnyType(System.Type type, List<FieldInfo> infos)
        {
            this.type = type;
            this.infos = infos;

            foreach (var d in infos)
            {
                if (d.Name == "root" && d.FieldType == typeof(GameObject))
                {
                    copyRoot = d;
                    break;
                }
            }

            bool isR = false;
            if (copyRoot != null)
            {
                foreach (var d in infos)
                {
                    if (d == copyRoot)
                        continue;

                    if (d.FieldType == typeof(GameObject) || isInherited(d.FieldType, typeof(Component)))
                    {
                        isR = true;
                    }
                }
            }

            if (!isR)
                copyRoot = null;
        }

        FieldInfo copyRoot;
        System.Type type;
        List<FieldInfo> infos;

        Dictionary<object, bool> isFoldouts = new Dictionary<object, bool>();

        public object OnGUI(string label, object value, System.Type type, out bool isDirty)
        {
            var current = value;
            if (current != null)
            {
                int hashcode = current.GetHashCode();
                var isFoldout = false;
                if (!isFoldouts.TryGetValue(hashcode, out isFoldout))
                    isFoldouts.Add(hashcode, isFoldout);

                UnityEditor.EditorGUILayout.BeginHorizontal();
                isFoldout = UnityEditor.EditorGUILayout.Foldout(isFoldout, label);
                if (copyRoot != null && GUILayout.Button("复制初始化"))
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    GameObject root = copyRoot.GetValue(current) as GameObject;
                    if (root != null)
                    {
                        sb.AppendLine("var rt = root.transform;");
                        sb.AppendLine("Transform rtm = null;");
                        foreach (var d in infos)
                        {
                            if (d.Name == "root")
                                continue;

                            if (isInherited(d.FieldType, typeof(Component)))
                            {
                                Component v = (Component)d.GetValue(current);
                                if (v != null)
                                {
                                    if (d.FieldType == typeof(Transform))
                                    {
                                        sb.AppendFormat("{0} = (rtm = rt.Find(\"{0}\")) == null ? null : rtm;", d.Name, GetPath(root, v.gameObject));
                                    }
                                    else if (d.FieldType == typeof(RectTransform))
                                    {
                                        sb.AppendFormat("{0} = (rtm = rt.Find(\"{0}\")) == null ? null : (RectTransform)rtm;", d.Name, GetPath(root, v.gameObject));
                                    }
                                    else
                                    {
                                        sb.AppendFormat("{0} = (rtm = rt.Find(\"{1}\")) == null ? null : rtm.GetComponent<{2}>();", d.Name, GetPath(root, v.gameObject), d.FieldType.Name);
                                    }

                                    sb.AppendLine();
                                }
                            }
                            else if (d.FieldType == typeof(GameObject))
                            {
                                GameObject v = (GameObject)d.GetValue(current);
                                if (v != null)
                                {
                                    sb.AppendFormat("{0} = (rtm = rt.Find(\"{1}\")) == null ? null : rtm.gameObject;", d.Name, GetPath(root, v.gameObject), d.FieldType.Name);
                                    sb.AppendLine();
                                }
                            }
                        }

                        GUIUtility.systemCopyBuffer = sb.ToString();
                        Debug.Log(sb.ToString());
                    }
                }
                UnityEditor.EditorGUILayout.EndHorizontal();
                isFoldouts[hashcode] = isFoldout;
                if (!isFoldout)
                {
                    isDirty = false;
                    return false;
                }
            }

            isDirty = false;
            if (value == null)
            {
                value = IL.Help.Create(type);
                isDirty = true;
            }

            for (int i = 0; i < infos.Count; ++i)
            {
                var field = infos[i];
                object v = field.GetValue(value);
                if (v == null && (!IL.Help.isType(field.FieldType, typeof(Object))))
                {
                    v = IL.Help.Create(field.FieldType);
                    field.SetValue(value, v);
                    isDirty = true;
                }

                isDirty |= TypeEditor.Get(field.FieldType).OnGUI(value, field);
            }

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
                    current = IL.Help.Create(info.FieldType);
                    info.SetValue(parent, current);
                    isDirty = true;
                }

                bool isd = false;
                OnGUI(string.Format("{0}({1})", info.Name, info.FieldType.Name), current, info.FieldType, out isd);
                return isDirty | isd;
            }
        }
    }
}
