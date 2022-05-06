namespace wxb.Editor
{
    using UnityEngine;
    using UnityEditor;
    using System.Collections.Generic;
    using UnityEngine.SceneManagement;

    class FindHotTypeEditor : EditorWindow
    {
        [MenuItem("XIL/查找热更组件", false, 9)]
        static public void OpenPackEditorWindow()
        {
            EditorWindow.GetWindow<FindHotTypeEditor>(false, "查找热更组件", true);
        }

        string searchKey;
        Vector2 ScrollPosition = Vector2.zero;
        List<Object> objs = new List<Object>();
        EditorPageBtn page;

        static void CheckGameObject(GameObject go, string searchKey, List<Object> objs)
        {
            var scene = go.scene;
            if (scene.name == null || scene.path == null)
                return;

            if (scene.buildIndex == -1 && scene.name != "DontDestroyOnLoad" && scene.name != go.name && !scene.path.StartsWith("Assets/"))
                return;

            var serials = go.GetComponentsInChildren<ISerializationCallbackReceiver>(true);
            int cnt = serials.Length;
            if (cnt == 0)
                return;

            for (int i = 0; i < cnt; ++i)
            {
                var obj = serials[i] as Object;
                var type = obj.GetType();
                var customizeDataField = IL.Help.GetField(type, "customizeData");
                if (customizeDataField != null)
                {
                    if (string.IsNullOrEmpty(searchKey))
                        objs.Add(obj);
                    else
                    {
                        var customizeData = customizeDataField.GetValue(obj) as CustomizeData;
                        if (customizeData != null && customizeData.TypeName.ToLower().Contains(searchKey))
                            objs.Add(obj);
                    }
                }
            }
        }

        void OnGUI()
        {
            EditorGUILayout.BeginHorizontal();
            searchKey = EditorGUILayout.TextField("关键字", searchKey);
            bool isSet = GUILayout.Button("查找");
            EditorGUILayout.EndHorizontal();
            if (isSet)
            {
                objs.Clear();

                var roots = Resources.FindObjectsOfTypeAll<Transform>();
                HashSet<Transform> rrs = new HashSet<Transform>();
                foreach (var ator in roots)
                {
                    if (ator.root == null)
                        rrs.Add(ator);
                    else
                        rrs.Add(ator.root);
                }

                var sk = string.IsNullOrEmpty(searchKey) ? string.Empty : searchKey.ToLower();
                foreach (var ator in rrs)
                    CheckGameObject(ator.gameObject, sk, objs);
            }

            if (page == null)
                page = new EditorPageBtn();
            page.total = objs.Count;
            page.pageNum = 50;
            EditorGUILayout.LabelField($"总数:{objs.Count}");
            page.OnRender();
            ScrollPosition = EditorGUILayout.BeginScrollView(ScrollPosition);
            for (int i = page.beginIndex; i < page.endIndex; ++i)
            {
                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.ObjectField($"目标:{i})", objs[i], typeof(Object), true);
                if (GUILayout.Button("选中"))
                    Selection.activeObject = objs[i];
                EditorGUILayout.EndHorizontal();
            }
            EditorGUILayout.EndScrollView();
        }
    }
}
