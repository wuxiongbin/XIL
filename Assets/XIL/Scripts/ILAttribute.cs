#if USE_ILRT
namespace wxb
{
    using System.Reflection;

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Method)]
    public class Platform : System.Attribute
    {
        public Platform(string platform)
        {
#if !USE_ILRT
            this.platform = platform;
#endif
        }

#if !USE_ILRT
        public string platform;
#endif
    }

    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class ReplaceType : System.Attribute
    {
        // 替换某个类型的某个同名接口
        public ReplaceType(System.Type type)
        {
#if !USE_ILRT
            this.type = type;
#endif
        }

        // 函数全名
        public ReplaceType(string fullName)
        {
#if !USE_ILRT
            this.fullName = fullName;
#endif
        }

#if !USE_ILRT
        System.Type type;
        string fullName;

        public System.Type Type
        {
            get
            {
                if (type != null)
                    return type;
                
                return IL.Help.GetTypeByFullName(fullName);
            }
        }
#endif
    }

    [System.AttributeUsage(System.AttributeTargets.Method)]
    public class ReplaceFunction : System.Attribute
    {
        public ReplaceFunction()
        {
#if !USE_ILRT
            create_type = 0;
#endif
        }

        // 替换某个类型的某个同名接口
        public ReplaceFunction(System.Type type)
        {
#if !USE_ILRT
            create_type = 1;
            this.type = type;
#endif
        }

        // fieldNameOrTypeName有可能是类型名，也有可能是字段名
        // 以__Hotfix_开始的为字段名，否则为类型名
        public ReplaceFunction(string fieldNameOrTypeName)
        {
#if !USE_ILRT
            create_type = 1;
            this.fieldNameOrTypeName = fieldNameOrTypeName;
#endif
        }

        // 替换某个类型的某个接口
        public ReplaceFunction(System.Type type, string fieldName)
        {
#if !USE_ILRT
            create_type = 2;
            this.type = type;
            this.fieldName = fieldName;
#endif
        }

        public ReplaceFunction(string typeName, string fieldName)
        {
#if !USE_ILRT
            create_type = 2;
            this.typeName = typeName;
            this.fieldName = fieldName;
#endif
        }

        public ReplaceFunction(System.Type type, string fieldName, string hot_hotfix_fieldName)
        {
#if !USE_ILRT
            create_type = 3;
            this.type = type;
            this.fieldName = fieldName;
            this.hot_hotfix_fieldName = hot_hotfix_fieldName;
#endif
        }

        public ReplaceFunction(string typeName, string fieldName, string hot_hotfix_fieldName)
        {
#if !USE_ILRT
            create_type = 3;
            this.typeName = typeName;
            this.fieldName = fieldName;
            this.hot_hotfix_fieldName = hot_hotfix_fieldName;
#endif
        }

#if !USE_ILRT
        public int create_type;
        public string fieldNameOrTypeName;
        public System.Type type;
        public string fieldName;
        public string typeName;
        public string hot_hotfix_fieldName;
#endif
    }

    // 自动调用初始化接口，定义在某个类的属性，只要此类下有静态的函数Init，会自动调用
    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class AutoInitAndRelease : System.Attribute
    {

    }
}
#endif