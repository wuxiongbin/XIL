namespace hot
{
    using UnityEngine;

    static class Extension
    {
        public static T GetField<T>(this wxb.RefType refType, string name)
        {
            return (T)refType.GetField(name);
        }

        public static T TryGetField<T>(this wxb.RefType refType, string name)
        {
            return (T)refType.TryGetField(name);
        }

        public static T GetProperty<T>(this wxb.RefType refType, string name)
        {
            return (T)refType.GetProperty(name);
        }

        public static T TryGetProperty<T>(this wxb.RefType refType, string name)
        {
            return (T)refType.TryGetProperty(name);
        }

        public static T AddHComponent<T>(this GameObject go) where T : Component
        {
            return go.AddComponent(typeof(T)) as T;
        }

        public static T AddHComponent<T>(this Component mono) where T : Component
        {
            return mono.gameObject.AddComponent(typeof(T)) as T;
        }

        public static T GetHComponent<T>(this GameObject go) where T : Component
        {
            return go.GetComponent(typeof(T)) as T;
        }

        public static T GetHComponent<T>(this Component mono) where T : Component
        {
            return mono.GetComponent(typeof(T)) as T;
        }

        public static T GetOrAddHComponent<T>(this GameObject go) where T : Component
        {
            var type = typeof(T);
            var t = go.GetComponent(type);
            if (t == null)
                t = go.AddComponent(type);

            return (T)t;
        }

        public static T GetOrAddHComponent<T>(this Component mono) where T : Component
        {
            var type = typeof(T);
            var t = mono.GetComponent(type);
            if (t == null)
                t = mono.gameObject.AddComponent(type);

            return (T)t;
        }
    }
}