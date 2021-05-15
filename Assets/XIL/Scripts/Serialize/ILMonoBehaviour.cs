namespace wxb
{
    using UnityEngine;
    using System.Reflection;
    using System.Collections.Generic;

    public class SingleILMono : System.Attribute
    {
        public SingleILMono(System.Type type)
        {
            this.type = type.FullName;
        }

        public string type;
    }

    public class AutoILMono : System.Attribute
    {

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
        void Reset()
        {
            customizeData = new CustomizeData();
        }

        public void SaveByInstance()
        {
            customizeData.OnBeforeSerialize();
        }

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
    }

    public class ILMBUpdate : ILMonoBehaviour
    {
        public System.Action update;
        private void Update()
        {
            if (update != null)
                update();
        }
    }

    public class ILMBLateUpdate : ILMonoBehaviour
    {
        public System.Action lateUpdate;
        private void LateUpdate()
        {
            if (lateUpdate != null)
                lateUpdate();
        }
    }

    public class ILMBLU : ILMonoBehaviour
    {
        public System.Action update;
        private void Update()
        {
            if (update != null)
                update();
        }

        public System.Action lateUpdate;
        private void LateUpdate()
        {
            if (lateUpdate != null)
                lateUpdate();
        }
    }
}
