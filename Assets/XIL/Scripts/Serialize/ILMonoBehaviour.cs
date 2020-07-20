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

    [System.Serializable]
    public class CustomizeData
    {
        [SerializeField]
        [HideInInspector]
        string typeName; // 对应的类型

        public string TypeName
        {
            get { return typeName; }
        }

        [SerializeField]
        [HideInInspector]
        List<Object> objs; // 对应的unity对象

        [SerializeField]
        [HideInInspector]
        byte[] bytes; // 对应的序列化数据字段

        RefType refType_ = null;
        public RefType refType { get { return refType_; } }

#if UNITY_EDITOR
        bool isShowTypeInfo;
        object instance;
        bool isDllChange()
        {
#if USE_HOT
            if (instance is ILRuntime.Runtime.Intepreter.ILTypeInstance)
            {
                var ti = instance as ILRuntime.Runtime.Intepreter.ILTypeInstance;
                if (ti.Type.AppDomain != DllInitByEditor.appdomain)
                    return true;
            }
#endif
            return false;
        }

        public void OnBeforeSerialize()
        {
            if (instance == null)
            {
                if (string.IsNullOrEmpty(typeName))
                {
                    bytes = null;
                    if (objs != null)
                        objs.Clear();
                    else
                        objs = new List<Object>();
                    refType_ = null;
                    instance = null;
                }
            }
            else
            {
                if (!isDllChange())
                {
                    var ms = MonoSerialize.WriteTo(instance);
                    bytes = ms.GetBytes();
                    objs = ms.objs;
                }
                else
                {
                    refType_ = null;
                    instance = null;
                }
            }
        }
#endif

        public void OnAfterDeserialize(object self)
        {
            if (string.IsNullOrEmpty(typeName))
                return;

            refType_ = new RefType(typeName, self);
            MonoSerialize.MergeFrom(refType_.Instance, bytes, objs);

#if UNITY_EDITOR
            instance = refType_.Instance;
#endif
        }
    }

    public class ILMonoBehaviour : MonoBehaviour, ISerializationCallbackReceiver
    {
        [SerializeField]
        CustomizeData customizeData;

        public RefType refType { get { return customizeData.refType; } }

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
