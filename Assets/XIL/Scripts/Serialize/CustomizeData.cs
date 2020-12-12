namespace wxb
{
    using UnityEngine;
    using System.Reflection;
    using System.Collections.Generic;

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
        public RefType GetRefType(object self)
        {
            if (refType_ == null && !string.IsNullOrEmpty(typeName))
                OnAfterDeserialize(self);

            return refType_;
        }

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
            {
                refType_ = null;
                return;
            }

            if (refType_ == null ||refType_.Instance == null || refType_.FullName != typeName)
                refType_ = new RefType(typeName);
            MonoSerialize.MergeFrom(refType_.Instance, bytes, objs);
            refType_.TrySetProperty("csObj", self);

#if UNITY_EDITOR
            instance = refType_.Instance;
#endif
        }
    }
}
