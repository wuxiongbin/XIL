namespace wxb
{
    using UnityEngine;
    using System.Reflection;
    using System.Collections.Generic;

    public class AutoILMono : System.Attribute
    {

    }

    public class ILMonoBehaviour : MonoBehaviour, ISerializationCallbackReceiver
    {
        [SerializeField]
        [HideInInspector]
        string typeName; // 对应的类型

        [SerializeField]
        [HideInInspector]
        List<Object> objs; // 对应的unity对象

        [SerializeField]
        [HideInInspector]
        byte[] bytes; // 对应的序列化数据字段

        public RefType refType { get; private set; }

        void ISerializationCallbackReceiver.OnBeforeSerialize()
        {
#if UNITY_EDITOR
            if (instance == null)
            {
                bytes = null;
                objs.Clear();
                refType = null;
            }
            else
            {
                var ms = MonoSerialize.WriteTo(instance);
                bytes = ms.Stream.GetBytes();
                objs = ms.objs;
            }
#endif
        }

        void ISerializationCallbackReceiver.OnAfterDeserialize()
        {
            Init();
        }

#if UNITY_EDITOR
        object instance;
        public List<Object> Objs { get { return objs; } }
#endif

        void Init()
        {
            if (string.IsNullOrEmpty(typeName))
                return;

            if (refType == null)
            {
                refType = new RefType(typeName, this);
            }
            MonoSerialize.MergeFrom(refType.Instance, bytes, objs);

#if UNITY_EDITOR
            instance = refType.Instance;
#endif
        }

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
