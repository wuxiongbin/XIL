namespace wxb
{
    using UnityEngine;
    using System.Reflection;
    using System.Collections.Generic;

    [System.Serializable]
    public class CustomizeData
    {
        [SerializeField]
        //[HideInInspector]
        string typeName; // 对应的类型

        public string TypeName
        {
            get { return typeName; }
        }

        [SerializeField]
        //[HideInInspector]
        List<Object> objs; // 对应的unity对象

        [SerializeField]
        //[HideInInspector]
        byte[] bytes; // 对应的序列化数据字段

        RefType refType_ = null;
        public RefType GetRefType(object self)
        {
            if (refType_ == null && !string.IsNullOrEmpty(typeName))
                OnAfterDeserialize(self);

            return refType_;
        }

        public void SetInstance(object instance, object self)
        {
            refType_ = new RefType(instance);
            typeName = refType_.FullName;

            refType_.TrySetProperty("csObj", self);

#if UNITY_EDITOR
            this.instance = refType_.Instance;
#endif
        }

#if !CloseNested
        [SerializeField]
        public Nested.Any0 anyValue;

        public void ResetNested()
        {
            anyValue = null;
        }
#endif

#if UNITY_EDITOR
        public void SetType(string typeName)
        {
            this.typeName = typeName;
        }

        public object getInstance()
        {
            return instance;
        }

        public void OnTypeChange(string newTypeName)
        {
            typeName = newTypeName;
            instance = null;
            refType_ = null;
        }

        bool isShowTypeInfo;
        object instance;
        bool isDllChange()
        {
#if USE_ILRT
            if (instance is ILRuntime.Runtime.Intepreter.ILTypeInstance)
            {
                var ti = instance as ILRuntime.Runtime.Intepreter.ILTypeInstance;
                if (ti.Type.AppDomain != DllInitByEditor.appdomain)
                    return true;
            }
#endif
            return false;
        }

        public void CheckDllChange()
        {
            if (isDllChange())
            {
                refType_ = null;
                instance = null;
            }
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
#if !CloseNested
                    anyValue = null;
#endif
                }
            }
            else
            {
                if (!isDllChange())
                {
                    var ms = MonoSerialize.WriteTo(instance);
                    bytes = ms.GetBytes();
                    objs = ms.objs;
#if !CloseNested
                    var ab = MonoSerialize.WriteToTS(instance);
                    Nested.Any0.Blend(ab, anyValue);
                    anyValue = (Nested.Any0)ab.clone();
#endif
                }
                else
                {
                    refType_ = null;
                    instance = null;
                }
            }
        }

#if !CloseNested
#if UNITY_EDITOR
        public static bool isUsedBytes = false;
#endif
        public void BytesToAnyValue()
        {
            if (string.IsNullOrEmpty(typeName))
                return;

            var rt = new RefType(typeName);
            MonoSerialize.MergeFrom(rt.Instance, bytes, objs);

            anyValue = MonoSerialize.WriteToTS(rt.Instance);
        }

        public void AnyValueToBytes()
        {
            if (string.IsNullOrEmpty(typeName))
                return;

            var rt = new RefType(typeName);
            MonoSerialize.MergeFrom(rt.Instance, anyValue);

            var ms = MonoSerialize.WriteTo(rt.Instance);
            bytes = ms.GetBytes();
            objs = ms.objs;
        }
#endif
#endif
#if !CloseNested
        bool IsUsedBytes()
        {
#if UNITY_EDITOR
            if (isUsedBytes)
                return true;
#endif
            return anyValue == null || string.IsNullOrEmpty(anyValue.dataKey);
        }
#endif
        public void OnAfterDeserialize(object self)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                refType_ = null;
#if UNITY_EDITOR
                instance = null;
#endif
                return;
            }

            if (refType_ == null || refType_.Instance == null || refType_.FullName != typeName)
                refType_ = new RefType(typeName);

            if (refType_.Instance == null)
                return;

#if !CloseNested
            if (!IsUsedBytes())
            {
                // 数据因为预置体嵌套被修改了，不完整了,使用TypeSerialize数据来初始化
                MonoSerialize.MergeFrom(refType_.Instance, anyValue);
            }
            else
            {
#endif
                MonoSerialize.MergeFrom(refType_.Instance, bytes, objs);
#if !CloseNested
            }
#endif
            refType_.TrySetProperty("csObj", self);

#if UNITY_EDITOR
            instance = refType_.Instance;
#endif
        }
    }
}
