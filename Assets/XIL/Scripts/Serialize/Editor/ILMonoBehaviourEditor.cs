using UnityEditor;
using System.Reflection;
using System.Collections.Generic;
#if USE_HOT
using ILRuntime.Runtime.Intepreter;
#endif

namespace wxb.Editor
{
    [CustomEditor(typeof(wxb.ILMonoBehaviour), true)]
    class ILMonoBehaviourEditor : UnityEditor.Editor
    {
        IL.Editor.ILMonoEditor monoEditor = new IL.Editor.ILMonoEditor();

        private void OnEnable()
        {
            monoEditor.InitByAttribute(serializedObject, target as ILMonoBehaviour, typeof(AutoILMono));
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            EditorGUILayout.LabelField("反射序列化数据:");
            System.Type type = target.GetType();
            monoEditor.OnGUI();
        }
    }
}
