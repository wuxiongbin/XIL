namespace wxb
{
    using System.Reflection;
    using System.Collections.Generic;

    public class CacheType
    {
        public CacheType(System.Type type)
        {
            this.type = type;
        }

        public System.Type type { get; private set; }
        Dictionary<string, MemberInfo> NameToMethodBase = new Dictionary<string, MemberInfo>();
        List<FieldInfo> serializes; // 序列化的字段

        struct Ctor
        {
            public System.Type param;
            public ConstructorInfo info;
        }

        Ctor[] Ctors;
        ConstructorInfo default_ctor; // 默认构造
        bool is_default_ctor = false;

        public ConstructorInfo GetCtor()
        {
            if (is_default_ctor)
                return default_ctor;

            is_default_ctor = true;
            default_ctor = type.GetConstructor(IL.Help.Flags, null, IL.Help.EmptyType, null);
            return default_ctor;
        }

        public ConstructorInfo GetCtor(System.Type param)
        {
            int count = 0;
            if (Ctors != null)
            {
                count = Ctors.Length;
                for (int i = 0; i < count; ++i)
                {
                    if (Ctors[i].param == param)
                        return Ctors[i].info;
                }
            }

            var p = param;
            while (p != null)
            {
                IL.Help.OneType[0] = p;
                var ctor = type.GetConstructor(IL.Help.Flags, null, IL.Help.OneType, null);
                if (ctor != null)
                {
                    System.Array.Resize(ref Ctors, count + 1);
                    Ctors[count] = new Ctor() { param = param, info = ctor };
                    return ctor;
                }

                p = p.BaseType;
            }

            System.Array.Resize(ref Ctors, count + 1);
            Ctors[count] = new Ctor() { param = param, info = null };
            return null;
        }

        public MethodInfo GetMethod(string name)
        {
            MemberInfo mb = null;
            if (NameToMethodBase.TryGetValue(name, out mb))
                return (MethodInfo)mb;

            System.Type st = type;
            while (true)
            {
                MethodInfo info = st.GetMethod(name, IL.Help.Flags);
                if (info == null)
                {
                    if ((st = st.BaseType) != null)
                    {
                        continue;
                    }
                }

                NameToMethodBase.Add(name, info);
                return info;
            }
        }

        public PropertyInfo GetProperty(string name)
        {
            MemberInfo mb = null;
            if (NameToMethodBase.TryGetValue(name, out mb))
                return (PropertyInfo)mb;

            System.Type st = type;
            while (true)
            {
                PropertyInfo info = st.GetProperty(name, IL.Help.Flags);
                if (info == null)
                {
                    if ((st = st.BaseType) != null)
                    {
                        continue;
                    }
                }

                NameToMethodBase.Add(name, info);
                return info;
            }
        }

        public FieldInfo GetField(string name)
        {
            MemberInfo mb = null;
            if (NameToMethodBase.TryGetValue(name, out mb))
                return (FieldInfo)mb;

            System.Type st = type;
            while (true)
            {
                FieldInfo info = st.GetField(name, IL.Help.Flags);
                if (info == null)
                {
                    if ((st = st.BaseType) != null)
                    {
                        continue;
                    }
                }

                NameToMethodBase.Add(name, info);
                return info;
            }
        }

        public List<FieldInfo> GetSerializeField()
        {
            if (serializes == null)
            {
                serializes = new List<FieldInfo>();

                IL.Help.GetSerializeField(type, serializes);
#if USE_HOT
                if (type.BaseType != null)
                    IL.Help.GetSerializeField(type.BaseType, serializes);
#endif
            }

            return serializes;
        }
    }
}