namespace wxb
{
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

        void ISerializationCallbackReceiver.OnBeforeSerialize()
        {

        }

        void ISerializationCallbackReceiver.OnAfterDeserialize()
        {
            customizeData.OnAfterDeserialize(this);
        }

#if UNITY_EDITOR
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
        private void OnGUI()
        {
            if (!isQuit && refType != null)
                refType.TryInvokeMethod("OnGUI");
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
        }

        void OnDisable()
        {
            if (!isQuit && refType != null)
                refType.TryInvokeMethod("OnDisable");
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
