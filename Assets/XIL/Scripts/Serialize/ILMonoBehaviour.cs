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
        CustomizeData customizeData;

        public RefType refType
        {
            get
            {
                return customizeData.GetRefType(this);
            }
        }

        void ISerializationCallbackReceiver.OnBeforeSerialize()
        {
#if UNITY_EDITOR
            if (customizeData == null)
                return;

            customizeData.OnBeforeSerialize();
#endif
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
#endif

        private void Awake()
        {
            if (refType != null)
                refType.TryInvokeMethod("Awake");
        }

        void Start()
        {
            if (refType != null)
                refType.TryInvokeMethod("Start");
        }

        void OnEnable()
        {
            if (refType != null)
                refType.TryInvokeMethod("OnEnable");
        }

        void OnDisable()
        {
            if (refType != null)
                refType.TryInvokeMethod("OnDisable");
        }

        void OnDestroy()
        {
            if (refType != null)
                refType.TryInvokeMethod("OnDestroy");
        }

        void OnApplicationQuit()
        {
            if (refType != null)
                refType.TryInvokeMethod("OnApplicationQuit");
        }        
    }
}
