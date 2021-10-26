#if UNITY_EDITOR
using UnityEngine;

namespace wxb
{
    // 通用的组件事件
    public partial class BehaviourAction
    {
        [EditorField]
        public System.Action editor_onEnable;

        [EditorField]
        public System.Action editor_onInspectorGUI;

        [EditorField]
        public System.Action editor_onDrawGizmos;

        [EditorField]
        public System.Action editor_onSceneGUI;

        [EditorField]
        private void OnDrawGizmos()
        {
            editor_onDrawGizmos?.Invoke();
        }
    }
}
#endif