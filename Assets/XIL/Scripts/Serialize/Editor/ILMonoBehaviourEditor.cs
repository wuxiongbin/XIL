using UnityEditor;

namespace wxb.Editor
{
    [CustomEditor(typeof(wxb.ILMonoBehaviour), true)]
    class ILMonoBehaviourEditor : UnityEditor.Editor
    {
        IL.Editor.ILMonoEditor monoEditor = new IL.Editor.ILMonoEditor();

        private void OnEnable()
        {
            string baseType = "hot.HotBehaviour";
            var atts = target.GetType().GetCustomAttributes(typeof(HotBaseType), true);
            if (atts == null || atts.Length != 0)
                baseType = ((HotBaseType)atts[0]).typeName;

            monoEditor.InitByBaseType(serializedObject, target as ILMonoBehaviour, baseType);
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            EditorGUILayout.LabelField("反射序列化数据:");
            monoEditor.OnGUI();
        }
    }
}
