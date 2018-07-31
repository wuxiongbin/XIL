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

        UnityEngine.MonoBehaviour target;

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

        public void InitByBaseType(UnityEngine.MonoBehaviour target, string baseTypeFullName)
        {
            Init(target);

            allTypes = Help.GetBaseType(baseTypeFullName);
        }

        public void Init(UnityEngine.MonoBehaviour target)
        {
            this.target = target;
            System.Type type = target.GetType();
            typeNameField = GetField(type, "typeName", BindingFlags.Instance | BindingFlags.NonPublic);
            instanceField = GetField(type, "instance", BindingFlags.Instance | BindingFlags.NonPublic);
            objsField = GetField(type, "objs", BindingFlags.Instance | BindingFlags.NonPublic);
            bytesField = GetField(type, "bytes", BindingFlags.Instance | BindingFlags.NonPublic);
        }

        public void InitByAttribute(UnityEngine.MonoBehaviour target, System.Type attributeType)
        {
            Init(target);

            allTypes = Help.GetCustomAttributesType(attributeType);
        }

        public void OnGUI(string newTypename)
        {
            string typeName = (string)typeNameField.GetValue(target);
            if (newTypename != typeName)
            {
                typeName = newTypename;
                typeNameField.SetValue(target, typeName);
                instanceField.SetValue(target, null);
                if (target is UnityEngine.Object)
                    EditorUtility.SetDirty((UnityEngine.Object)target);
            }

            if (string.IsNullOrEmpty(typeName))
                return;

            var type = Help.GetType(newTypename);
            if (type == null)
            {
                EditorGUILayout.LabelField(string.Format("类型:{0},查找失败!", newTypename));
                return;
            }

            object instance = instanceField.GetValue(target);
            if (instance == null
#if USE_HOT
                || (instance is ILTypeInstance && ((ILTypeInstance)instance).Type.FullName != newTypename) 
                || (!(instance is ILTypeInstance) && instance.GetType().FullName != newTypename)
#endif
                )
            {
                var ctor = Help.GetType(newTypename).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new System.Type[0] { } , null);
                if (ctor == null)
                {
                    UnityEngine.Debug.LogErrorFormat("type:{0} not find ctor!", newTypename);
                    instance = null;
                    return;
                }

                instance = ctor.Invoke(null);
                instanceField.SetValue(target, instance);
                if (target is UnityEngine.Object)
                    EditorUtility.SetDirty((UnityEngine.Object)target);

                byte[] bytes = (byte[])bytesField.GetValue(target);
                var objs = (List<UnityEngine.Object>)objsField.GetValue(target);
                MonoSerialize.MergeFrom(instance, bytes, objs);
            }
            else
            {
                if (!UnityEngine.Application.isPlaying)
                {
                    byte[] bytes = (byte[])bytesField.GetValue(target);
                    var objs = (List<UnityEngine.Object>)objsField.GetValue(target);
                    MonoSerialize.MergeFrom(instance, bytes, objs);
                }
            }

            if (wxb.Editor.TypeEditor.OnGUI(instance))
            {
                if (!UnityEngine.Application.isPlaying)
                {
                    Undo.RegisterCompleteObjectUndo(target, "ILMonoEditor");
                }

                var ms = MonoSerialize.WriteTo(instance);
                objsField.SetValue(target, ms.objs);
                bytesField.SetValue(target, ms.Stream.GetBytes());

                if (target is UnityEngine.Object)
                    EditorUtility.SetDirty((UnityEngine.Object)target);
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
            string typeName = (string)typeNameField.GetValue(target);
            if (!string.IsNullOrEmpty(typeName) && typeName.StartsWith("xys.hot"))
                typeName = typeName.Substring(4);

            string newTypename = StringPopupT("typeName", typeName, allTypes, (System.Type t) => { return t.FullName; }, m_searchName);

            OnGUI(newTypename);
        }

        [MenuItem("Assets/TestLogIL")]
        static void TestIL()
        {
            var type = IL.Help.GetTypeByFullName("hot.hotApp");

            var method = type.GetMethod("TestLog", BindingFlags.NonPublic | BindingFlags.Static);
            method.Invoke(null, new object[] { });
        }

    }
}