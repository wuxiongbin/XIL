namespace wxb
{
    using UnityEngine;
    using System.Reflection;
    using System.Collections.Generic;

    public class AutoILMono : System.Attribute
    {

    }

    public class ILMonoBehaviour : MonoBehaviour
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

#if UNITY_EDITOR
        object instance;
#endif
        public object GetObject()
        {
            Init();
            return refType.Instance;
        }

        void Init()
        {
            if (refType != null)
                return;

            refType = new RefType(typeName, this);
            MonoSerialize.MergeFrom(refType.Instance, bytes, objs);

#if UNITY_EDITOR
            instance = refType.Instance;
#endif
        }

        private void Awake()
        {
            Init();
            refType.TryInvokeMethod("Awake");
        }

        protected virtual void Start()
        {
            refType.TryInvokeMethod("Start");
        }

        protected virtual void OnEnable()
        {
            refType.TryInvokeMethod("OnEnable");
        }

        protected virtual void OnDisable()
        {
            refType.TryInvokeMethod("OnDisable");
        }

        protected virtual void OnDestroy()
        {
            refType.TryInvokeMethod("OnDestroy");
        }

        protected virtual void OnApplicationQuit()
        {
            refType.TryInvokeMethod("OnApplicationQuit");
        }        
    }
}
