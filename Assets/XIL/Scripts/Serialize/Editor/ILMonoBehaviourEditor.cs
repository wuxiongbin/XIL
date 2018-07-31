//using UnityEditor;
//using System.Reflection;
//using System.Collections.Generic;
//#if USE_HOT
//using ILRuntime.Runtime.Intepreter;
//#endif

//namespace wxb.Editor
//{
//    [CustomEditor(typeof(wxb.ILMonoBehaviour), true)]
//    class ILMonoBehaviourEditor : UnityEditor.Editor
//    {
//        IL.Editor.ILMonoEditor monoEditor = new IL.Editor.ILMonoEditor();

//        private void OnEnable()
//        {
//            monoEditor.InitByAttribute(target as ILMonoBehaviour, typeof(AutoILMono));
//        }

//        public override void OnInspectorGUI()
//        {
//            base.OnInspectorGUI();

//            EditorGUILayout.LabelField("反射序列化数据:");
//            System.Type type = target.GetType();
//            var attributes = type.GetCustomAttributes(typeof(SingleILMono), true);
//            if (attributes != null && attributes.Length != 0)
//            {
//                monoEditor.OnGUI(((SingleILMono)attributes[0]).type);
//                return;
//            }

//            monoEditor.OnGUI();
//        }
//    }
//}
