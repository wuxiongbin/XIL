using UnityEditor;
using System.Reflection;
using System.Collections.Generic;
using UnityEngine;
#if USE_HOT
using ILRuntime.Runtime.Intepreter;
#endif

namespace wxb.IL.Editor
{
    public class ILMonoEditor
    {
        FieldInfo typeNameField;
        FieldInfo instanceField;
        FieldInfo objsField;
        FieldInfo bytesField;

        MonoBehaviour behaviour;
        object customizeData;

        List<System.Type> allTypes;

        static FieldInfo GetField(System.Type type, string name, BindingFlags flags)
        {
            var info = type.GetField(name, flags);
            if (info != null)
                return info;

            if (type.BaseType != null)
                return GetField(type.BaseType, name, flags);

            return null;
        }

        public void InitByBaseType(SerializedObject serializedObject, UnityEngine.MonoBehaviour target, string baseTypeFullName)
        {
            Init(serializedObject, target);

            allTypes = Help.GetBaseType(baseTypeFullName);
            allTypes.Insert(0, null);
        }

        SerializedObject serializedObject;
        public void Init(SerializedObject serializedObject, UnityEngine.MonoBehaviour behaviour)
        {
            this.serializedObject = serializedObject;
#if USE_HOT
            var appdomain = DllInitByEditor.appdomain;
#endif
            this.behaviour = behaviour;
            var customizeDataField = GetField(behaviour.GetType(), "customizeData", BindingFlags.Instance | BindingFlags.NonPublic);
            if (customizeDataField != null)
            {
                customizeData = customizeDataField.GetValue(behaviour);
                if (customizeData == null)
                {
                    customizeData = Help.Create(customizeDataField.FieldType);
                    customizeDataField.SetValue(behaviour, customizeData);
                    EditorUtility.SetDirty(behaviour);
                }

                var customizeData_sp = serializedObject.FindProperty("customizeData");
                bool isHit = GetValue(customizeData, "typeName") == null;
                if (isHit)
                {
                    serializedObject.Update();
                    SetByRef(behaviour, customizeData, "typeName");
                    SetByRef(behaviour, customizeData, "objs");
                    SetByRef(behaviour, customizeData, "bytes");
                    ((CustomizeData)customizeData).OnAfterDeserialize(behaviour);
                    EditorUtility.SetDirty(behaviour);
                }
            }
            else
            {
                customizeData = behaviour;
            }
            
            System.Type type = customizeDataField != null ? customizeDataField.FieldType : behaviour.GetType();
            typeNameField = GetField(type, "typeName", BindingFlags.Instance | BindingFlags.NonPublic);
            instanceField = GetField(type, "instance", BindingFlags.Instance | BindingFlags.NonPublic);
            objsField = GetField(type, "objs", BindingFlags.Instance | BindingFlags.NonPublic);
            bytesField = GetField(type, "bytes", BindingFlags.Instance | BindingFlags.NonPublic);
        }

        // src.name
        static object GetValue(object src, string name)
        {
            var flag = BindingFlags.Instance | BindingFlags.NonPublic;
            var src_field = src.GetType().GetField(name, flag);
            if (src_field == null)
                return null;

            return src_field.GetValue(src);
        }

        // dst.name = src.name;
        static bool SetByRef(object src, object dst, string name)
        {
            var flag = BindingFlags.Instance | BindingFlags.NonPublic;
            var src_field = GetField(src.GetType(), name, flag);
            if (src_field == null)
                return false;

            var dst_field = GetField(dst.GetType(), name, flag);
            if (dst_field == null)
                return false;

            dst_field.SetValue(dst, src_field.GetValue(src));
            return true;
        }

        public void InitByAttribute(SerializedObject serializedObject, UnityEngine.MonoBehaviour target, System.Type attributeType)
        {
            Init(serializedObject, target);

            allTypes = Help.GetCustomAttributesType(attributeType);
            allTypes.Insert(0, null);
        }

        void RegisterCompleteObjectUndo()
        {
            Undo.RegisterCompleteObjectUndo(behaviour, "ILMonoEditor");
        }

        public void OnGUI(string newTypename)
        {
            if (newTypename == null)
                newTypename = string.Empty;

            string typeName = (string)typeNameField.GetValue(customizeData);
            if (!string.Equals(newTypename, typeName))
            {
                RegisterCompleteObjectUndo();

                typeName = newTypename;
                typeNameField.SetValue(customizeData, typeName);
                instanceField.SetValue(customizeData, null);
                EditorUtility.SetDirty(behaviour);
            }

            if (string.IsNullOrEmpty(typeName))
                return;

            var type = Help.GetType(newTypename);
            if (type == null)
            {
                EditorGUILayout.LabelField(string.Format("类型:{0},查找失败!", newTypename));
                return;
            }

            object instance = instanceField.GetValue(customizeData);
            if (instance == null)
            {
                ((CustomizeData)customizeData).OnAfterDeserialize(behaviour);
                return;
            }

            if (wxb.Editor.TypeEditor.OnGUI(instance))
            {
                EditorUtility.SetDirty(behaviour);
                EditorUtility.SetDirty(behaviour.gameObject);
                RegisterCompleteObjectUndo();
            }
        }

        string m_searchName = string.Empty;

        public static string StringPopupT<T>(string label, string selected, List<T> displayedOptions, System.Func<T, string> fun, string searchName = "", params GUILayoutOption[] options)
        {
            List<string> ds = new List<string>();
            string searchLow = string.IsNullOrEmpty(searchName) ? "" : searchName.ToLower();
            for (int i = 0; i < displayedOptions.Count; ++i)
            {
                string item = fun(displayedOptions[i]);
                if (!string.IsNullOrEmpty(searchName) && selected != item && !item.ToLower().Contains(searchLow))
                    continue;
                ds.Add(item);
            }

            return StringPopup(label, selected, ds, options);
        }

        public static string StringPopup(string label, string selected, List<string> displayedOptions, params GUILayoutOption[] options)
        {
            int index = StringPopup(label, displayedOptions.IndexOf(selected), displayedOptions, options);
            return displayedOptions.Count == 0 ? selected : displayedOptions[index];
        }

        public static int StringPopup(string label, int selected, List<string> displayedOptions, params GUILayoutOption[] options)
        {
            if (selected < 0 || selected >= displayedOptions.Count)
                selected = 0;

            List<int> valueList = new List<int>();
            for (int i = 0; i < displayedOptions.Count; ++i)
                valueList.Add(i);

            if (!string.IsNullOrEmpty(label))
                selected = EditorGUILayout.IntPopup(label, selected, displayedOptions.ToArray(), valueList.ToArray(), options);
            else
                selected = EditorGUILayout.IntPopup(selected, displayedOptions.ToArray(), valueList.ToArray(), options);

            return selected;
        }

        public void OnGUI()
        {
            m_searchName = EditorGUILayout.TextField("输入搜索：", m_searchName);
            string typeName = (string)typeNameField.GetValue(customizeData);
            if (!string.IsNullOrEmpty(typeName) && typeName.StartsWith("xys.hot"))
                typeName = typeName.Substring(4);

            string newTypename = StringPopupT("typeName", typeName, allTypes, (System.Type t) => { return t == null ? "null" : t.FullName; }, m_searchName);
            if (newTypename == "null")
                newTypename = null;

            OnGUI(newTypename);
        }

        public void OnChildGUI(Object target)
        {
            FieldInfo isShowTypeInfo = target.GetType().GetField("isShowTypeInfo", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            if (isShowTypeInfo != null)
            {
                bool value = (bool)isShowTypeInfo.GetValue(target);
                bool newValue = EditorGUILayout.Foldout(value, "映射类型数据");
                if (newValue != value)
                    isShowTypeInfo.SetValue(target, newValue);
                if (!newValue)
                    return;
            }

            System.Type type = target.GetType();
            var attributes = type.GetCustomAttributes(typeof(SingleILMono), true);
            if (attributes != null && attributes.Length != 0)
            {
                OnGUI(((SingleILMono)attributes[0]).type);
                return;
            }

            OnGUI();
        }

        //[MenuItem("Assets/TestLogIL")]
        static void TestIL()
        {
            var type = IL.Help.GetTypeByFullName("hot.hotApp");

            var method = type.GetMethod("TestLog", BindingFlags.NonPublic | BindingFlags.Static);
            method.Invoke(null, new object[] { });
        }
    }
}