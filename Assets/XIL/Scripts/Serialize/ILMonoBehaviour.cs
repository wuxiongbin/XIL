namespace wxb
{
    using System.Collections.Generic;
    using UnityEngine;

    public class HotBaseType : System.Attribute
    {
        public HotBaseType(string typeName)
        {
            this.typeName = typeName;
        }

        public string typeName;
    }

    public class ILMonoBehaviour : MonoBehaviour, ISerializationCallbackReceiver
    {
        [SerializeField]
        [HideInInspector]
        protected CustomizeData customizeData;

        public RefType refType
        {
            get
            {
                return customizeData == null ? null : customizeData.GetRefType(this);
            }
        }

        public void SetInstance(object instance)
        {
            if (customizeData == null)
                customizeData = new CustomizeData();
            customizeData.SetInstance(instance, this);
        }

        void ISerializationCallbackReceiver.OnBeforeSerialize()
        {

        }

        void ISerializationCallbackReceiver.OnAfterDeserialize()
        {
            customizeData.OnAfterDeserialize(this);
#if UNITY_EDITOR
            onGUI = refType == null ? null : refType.TryGetMethod("OnGUI");
#endif
        }

#if UNITY_EDITOR
        static List<ILMonoBehaviour> Actives = new List<ILMonoBehaviour>();
        System.Reflection.MethodInfo onGUI;
        [EditorField]
        void Reset()
        {
            customizeData = new CustomizeData();
        }

        [EditorField]
        public void SaveByInstance()
        {
            customizeData.OnBeforeSerialize();
        }

        [EditorField]
        static void GUIOn()
        {
            if (isQuit)
                return;

            int cnt = Actives.Count;
            ILMonoBehaviour il;
            for (int i = 0; i < cnt; ++i)
            {
                il = Actives[i];
                if (il.onGUI != null)
                    il.onGUI.InvokeMethod(il.refType.Instance);
            }
        }

        class ONGUI : MonoBehaviour
        {
            public System.Action ongui;

            private void OnGUI()
            {
                if (ongui == null)
                    return;

                ongui();
            }
        }

        static ONGUI gui;
        static void CreateGUI()
        {
            if (!Application.isPlaying)
                return;

            if (isQuit)
                return;

            if (gui != null)
                return;

            gui = new GameObject("ILMonoBehaviour.OnGUI").AddComponent<ONGUI>();
            gui.ongui = GUIOn;
        }
#endif

        private void Awake()
        {
            if (!isQuit && refType != null)
                refType.TryInvokeMethod("Awake");
        }

        void Start()
        {
            if (!isQuit && refType != null)
                refType.TryInvokeMethod("Start");
        }

        void OnEnable()
        {
            if (!isQuit && refType != null)
                refType.TryInvokeMethod("OnEnable");
#if UNITY_EDITOR
            Actives.Add(this);
            CreateGUI();
#endif
        }

        void OnDisable()
        {
            if (!isQuit && refType != null)
                refType.TryInvokeMethod("OnDisable");
#if UNITY_EDITOR
            Actives.Remove(this);
#endif
        }

        void OnDestroy()
        {
            if (!isQuit && refType != null)
                refType.TryInvokeMethod("OnDestroy");
        }

        public static bool isQuit = false;
        void OnApplicationQuit()
        {
            isQuit = true;
            if (refType != null)
                refType.TryInvokeMethod("OnApplicationQuit");
        }

        public void OnEvent(string name)
        {
            if (!isQuit && refType != null)
                refType.InvokeMethod("OnEvent", name);
        }

        // 调用热更里的函数
        public void OnFunction(string name)
        {
            if (!isQuit && refType != null)
                refType.InvokeMethod(name);
        }
    }
}
