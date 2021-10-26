using UnityEditor;
using UnityEngine;

namespace wxb.Editor
{
    [CustomEditor(typeof(BehaviourAction), true)]
    class BehaviourActionEditor : UnityEditor.Editor
    {
        private void OnEnable()
        {
            (target as BehaviourAction)?.editor_onEnable?.Invoke();
        }

        public override void OnInspectorGUI()
        {
            (target as BehaviourAction)?.editor_onInspectorGUI?.Invoke();
        }

        public void OnSceneGUI()
        {
            (target as BehaviourAction)?.editor_onSceneGUI?.Invoke();
        }
    }
}