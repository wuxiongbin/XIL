namespace wxb
{
    using UnityEngine;
    using System.Reflection;
    using System.Collections.Generic;

    public class RefType
    {
        public RefType(string fullType, object param)
        {
            this.fullType = fullType;
            type = IL.Help.GetTypeByFullName(fullType);

            if (type != null)
                instance = IL.Help.CreateInstaince(type, param);
        }

        public RefType(string fullType)
        {
            this.fullType = fullType;
            type = IL.Help.GetTypeByFullName(fullType);

            if (type != null)
                instance = IL.Help.CreateInstaince(type, null);
        }

        public RefType(object instance)
        {
            this.instance = instance;

#if USE_HOT
            if (instance is ILRuntime.Runtime.Intepreter.ILTypeInstance)
            {
                var realType = (ILRuntime.Runtime.Intepreter.ILTypeInstance)instance;
                type = realType.Type.ReflectionType;
            }
            else
#endif
            {
                type = instance.GetType();
            }

            fullType = type.FullName;
        }

        object instance;
        string fullType;
        System.Type type;
       
        public object Instance { get { return instance; } }
        public System.Type Type { get { return type; } }

        public T GetField<T>(string name) { return (T)GetField(name); }
        public void SetField(string name, object value)
        {
            var field = IL.Help.GetField(type, name);
            if (field == null)
            {
                UnityEngine.Debug.LogErrorFormat("type:{0} field:{1} not find!", fullType, name);
                return ;
            }

            try
            {
                field.SetValue(instance, value);
            }
            catch (System.Exception ex)
            {
                UnityEngine.Debug.LogErrorFormat("SetField type:{0} name:{1}", type.Name, name);
                UnityEngine.Debug.LogException(ex);
            }
        }

        // 得到某个字段的值
        public object GetField(string name)
        {
            var field = IL.Help.GetField(type, name);
            if (field == null)
            {
                Debug.LogErrorFormat("type:{0} field:{1} not find!", fullType, name);
                return null;
            }

            try
            {
                return field.GetValue(instance);
            }
            catch (System.Exception ex)
            {
                Debug.LogErrorFormat("GetField type:{0} name:{1}", type.Name, name);
                Debug.LogException(ex);
                return null;
            }
        }

        public T TryGetField<T>(string name)
        {
            return (T)TryGetField(name);
        }

        public object TryGetField(string name)
        {
            var field = IL.Help.GetField(type, name);
            if (field == null)
                return null;

            try
            {
                return field.GetValue(instance);
            }
            catch (System.Exception ex)
            {
                Debug.LogErrorFormat("TryGetField type:{0} name:{1}", type.Name, name);
                Debug.LogException(ex);
                return null;
            }
        }

        public void TrySetField(string name, object value)
        {
            var field = IL.Help.GetField(type, name);
            if (field == null)
                return;

            try
            {
                field.SetValue(instance, value);
            }
            catch (System.Exception ex)
            {
                Debug.LogErrorFormat("TrySetField type:{0} name:{1}", type.Name, name);
                Debug.LogException(ex);
            }
        }

        public void InvokeMethod(string name, params object[] param)
        {
            InvokeMethodReturn(name, param);
        }

        public object InvokeMethodReturn(string name, params object[] param)
        {
            var methodInfo = IL.Help.GetMethod(type, name);
            if (methodInfo == null)
            {
                Debug.LogErrorFormat("type:{0} field:{1} not find!", fullType, name);
                return null;
            }

            try
            {
                return methodInfo.Invoke(instance, param);
            }
            catch(System.Exception ex)
            {
                Debug.LogErrorFormat("InvokeMethodReturn type:{0} name:{1}", type.Name, name);
                Debug.LogException(ex);
                return null;
            }
        }

        public void TryInvokeMethod(string name, params object[] param)
        {
            TryInvokeMethodReturn(name, param);
        }

        public object TryInvokeMethodReturn(string name, params object[] param)
        {
            var methodInfo = IL.Help.GetMethod(type, name);
            if (methodInfo == null)
                return null;
            try
            {
                return methodInfo.Invoke(instance, param);
            }
            catch (System.Exception ex)
            {
                Debug.LogErrorFormat("TryInvokeMethodReturn type:{0} name:{1}", type.Name, name);
                Debug.LogException(ex);
                return null;
            }
        }

        public object GetProperty(string name)
        {
            var propertyInfo = IL.Help.GetProperty(type, name);
            if (propertyInfo == null)
            {
                Debug.LogErrorFormat("type:{0} Property:{1} not find!", fullType, name);
                return null;
            }

            try
            {
                return propertyInfo.GetValue(instance, null);
            }
            catch (System.Exception ex)
            {
                Debug.LogErrorFormat("GetProperty type:{0} name:{1}", type.Name, name);
                Debug.LogException(ex);
                return null;
            }
        }

        public T GetProperty<T>(string name)
        {
            return (T)GetProperty(name);
        }

        public void SetProperty(string name, object value)
        {
            var propertyInfo = IL.Help.GetProperty(type, name);
            if (propertyInfo == null)
            {
                Debug.LogErrorFormat("type:{0} Property:{1} not find!", fullType, name);
                return;
            }

            try
            {
                propertyInfo.SetValue(instance, value, null);
            }
            catch (System.Exception ex)
            {
                Debug.LogErrorFormat("SetProperty type:{0} name:{1}", type.Name, name);
                Debug.LogException(ex);
            }
        }

        public object TryGetProperty(string name)
        {
            var propertyInfo = IL.Help.GetProperty(type, name);
            if (propertyInfo == null)
                return null;
            try
            {
                return propertyInfo.GetValue(instance, null);
            }
            catch (System.Exception ex)
            {
                Debug.LogErrorFormat("TryGetProperty type:{0} name:{1}", type.Name, name);
                Debug.LogException(ex);
                return null;
            }
        }

        public T TryGetProperty<T>(string name)
        {
            return (T)TryGetProperty(name);
        }

        public void TrySetProperty(string name, object value)
        {
            var propertyInfo = IL.Help.GetProperty(type, name);
            if (propertyInfo == null)
                return;

            try
            {
                propertyInfo.SetValue(instance, value, null);
            }
            catch (System.Exception ex)
            {
                Debug.LogErrorFormat("TrySetProperty type:{0} name:{1}", type.Name, name);
                Debug.LogException(ex);
            }
        }
    }
}