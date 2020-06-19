namespace wxb
{
    using UnityEngine;
    using System.Reflection;
    using System.Collections.Generic;

    public partial class RefType
    {
        public RefType(bool isStatic, System.Type type)
        {
            this.type = type;
            this.fullType = type.FullName;
            instance = null;
        }

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

        public RefType(System.Type type)
        {
            this.type = type;
            this.fullType = type.FullName;
            instance = IL.Help.CreateInstaince(type, null);
        }

        public RefType(System.Type type, object param)
        {
            this.type = type;
            this.fullType = type.FullName;
            instance = IL.Help.CreateInstaince(type, param);
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

        public void SetInstance(object instance)
        {
            this.instance = instance;
        }

        //public T GetField<T>(string name) { return (T)GetField(name); }
        public void SetField(string name, object value)
        {
            var field = IL.Help.GetField(type, name);
            if (field == null)
            {
                wxb.L.LogErrorFormat("type:{0} field:{1} not find!", fullType, name);
                return ;
            }

            try
            {
                field.SetValue(instance, value);
            }
            catch (System.Exception ex)
            {
                wxb.L.LogErrorFormat("SetField type:{0} name:{1}", type.Name, name);
                wxb.L.LogException(ex);
            }
        }

        // 得到某个字段的值
        public object GetField(string name)
        {
            var field = IL.Help.GetField(type, name);
            if (field == null)
            {
                wxb.L.LogErrorFormat("type:{0} field:{1} not find!", fullType, name);
                return null;
            }

            try
            {
                return field.GetValue(instance);
            }
            catch (System.Exception ex)
            {
                wxb.L.LogErrorFormat("GetField type:{0} name:{1}", type.Name, name);
                wxb.L.LogException(ex);
                return null;
            }
        }

        //public T TryGetField<T>(string name)
        //{
        //    return (T)TryGetField(name);
        //}

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
                wxb.L.LogErrorFormat("TryGetField type:{0} name:{1}", type.Name, name);
                wxb.L.LogException(ex);
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
                wxb.L.LogErrorFormat("TrySetField type:{0} name:{1}", type.Name, name);
                wxb.L.LogException(ex);
            }
        }

        public void InvokeMethod(string name, object[] param)
        {
            InvokeMethodReturn(name, param);
        }

        public object InvokeMethodReturn(string name, object[] param)
        {
            var methodInfo = IL.Help.GetMethod(type, name);
            if (methodInfo == null)
            {
                wxb.L.LogErrorFormat("type:{0} field:{1} not find!", fullType, name);
                return null;
            }

            try
            {
                return methodInfo.Invoke(instance, param);
            }
            catch(System.Exception ex)
            {
                wxb.L.LogErrorFormat("InvokeMethodReturn type:{0} name:{1}", type.Name, name);
                wxb.L.LogException(ex);
                return null;
            }
        }

        public void TryInvokeMethod(string name, object[] param)
        {
            TryInvokeMethodReturn(name, param);
        }

        public object TryInvokeMethodReturn(string name, object[] param)
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
                wxb.L.LogErrorFormat("TryInvokeMethodReturn type:{0} name:{1}", type.Name, name);
                wxb.L.LogException(ex);
                return null;
            }
        }

        public object GetProperty(string name)
        {
            var propertyInfo = IL.Help.GetProperty(type, name);
            if (propertyInfo == null)
            {
                wxb.L.LogErrorFormat("type:{0} Property:{1} not find!", fullType, name);
                return null;
            }

            try
            {
                return propertyInfo.GetValue(instance, null);
            }
            catch (System.Exception ex)
            {
                wxb.L.LogErrorFormat("GetProperty type:{0} name:{1}", type.Name, name);
                wxb.L.LogException(ex);
                return null;
            }
        }

        //public T GetProperty<T>(string name)
        //{
        //    return (T)GetProperty(name);
        //}

        public void SetProperty(string name, object value)
        {
            var propertyInfo = IL.Help.GetProperty(type, name);
            if (propertyInfo == null)
            {
                wxb.L.LogErrorFormat("type:{0} Property:{1} not find!", fullType, name);
                return;
            }

            try
            {
                propertyInfo.SetValue(instance, value, null);
            }
            catch (System.Exception ex)
            {
                wxb.L.LogErrorFormat("SetProperty type:{0} name:{1}", type.Name, name);
                wxb.L.LogException(ex);
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
                wxb.L.LogErrorFormat("TryGetProperty type:{0} name:{1}", type.Name, name);
                wxb.L.LogException(ex);
                return null;
            }
        }

        //public T TryGetProperty<T>(string name)
        //{
        //    return (T)TryGetProperty(name);
        //}

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
                wxb.L.LogErrorFormat("TrySetProperty type:{0} name:{1}", type.Name, name);
                wxb.L.LogException(ex);
            }
        }

#if UNITY_EDITOR && USE_HOT
        [EditorClass]
        //[UnityEditor.MenuItem("XIL/RefType优化")]
        static void RefTypeOpt()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendFormatLine("namespace wxb");
            sb.AppendFormatLine("{{");
            sb.AppendFormatLine("    public partial class RefType");
            sb.AppendFormatLine("    {{");

            Name(sb, "InvokeMethod", false);
            sb.AppendLine();
            Name(sb, "InvokeMethodReturn", true);
            sb.AppendLine();
            Name(sb, "TryInvokeMethod", false);
            sb.AppendLine();
            Name(sb, "TryInvokeMethodReturn", true);
            sb.AppendLine();

            sb.AppendFormatLine("    }}");
            sb.AppendFormatLine("}}");

            string filename = "Assets/XIL/Scripts/RefType_InvokeMethod.cs";
            if (System.IO.File.Exists(filename))
                System.IO.File.Delete(filename);
            System.IO.File.WriteAllText(filename, sb.ToString());
            UnityEditor.AssetDatabase.ImportAsset(filename);
        }

        [EditorClass]
        static void Name(System.Text.StringBuilder sb, string name, bool isReturn)
        {
            for (int i = 0; i < 11; ++i)
            {
                if (i == 0)
                {
                    sb.AppendFormatLine("        public {0} {1}(string name)", isReturn ? "object" : "void", name);
                    sb.AppendFormatLine("        {{");
                    sb.AppendFormatLine("            using (var obj = new global::IL.EmptyObjs())");
                    sb.AppendFormatLine("            {{");
                    if (isReturn)
                        sb.AppendFormatLine("                return {0}(name, obj.objs);", name);
                    else
                        sb.AppendFormatLine("                {0}(name, obj.objs);", name);
                    sb.AppendFormatLine("            }}");
                    sb.AppendFormatLine("        }}");
                }
                else
                {
                    sb.AppendFormat("        public {0} {1}(string name", isReturn ? "object" : "void", name);
                    for (int j = 0; j < i; ++j)
                    {
                        sb.AppendFormat(", object p{0}", j);
                    }
                    sb.AppendLine(")");

                    sb.AppendFormatLine("        {{");
                    sb.AppendFormat("            using (var obj = new global::IL.Objects(");
                    for (int j = 0; j < i; ++j)
                    {
                        if (j == 0)
                            sb.AppendFormat("p{0}", j);
                        else
                            sb.AppendFormat(", p{0}", j);
                    }
                    sb.AppendLine("))");

                    sb.AppendFormatLine("            {{");
                    if (isReturn)
                        sb.AppendFormatLine("                return {0}(name, obj.objs);", name);
                    else
                        sb.AppendFormatLine("                {0}(name, obj.objs);", name);

                    sb.AppendFormatLine("            }}");
                    sb.AppendFormatLine("        }}");
                }
            }
        }
#endif
    }
}