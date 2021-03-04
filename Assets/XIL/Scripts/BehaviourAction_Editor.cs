#if UNITY_EDITOR
using UnityEngine;

namespace wxb
{
    // 通用的组件事件
    public partial class BehaviourAction
    {
        public System.Action editor_onEnable;
        public System.Action editor_onInspectorGUI;
    }
}
#endif