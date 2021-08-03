#if UNITY_2021
using UnityEditor.SceneManagement;
#else
using UnityEditor.Experimental.SceneManagement;
#endif
using UnityEngine;

namespace wxb
{
    public static class PrefabModify
    {
        static System.Reflection.MethodInfo s_OpenPrefab = null;

        static PrefabStage OpenPrefab(string root)
        {
            if (s_OpenPrefab == null)
            {
                var methods = typeof(PrefabStageUtility).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
                for (int i = 0; i < methods.Length; ++i)
                {
                    var method = methods[i];
                    if (method.Name == "OpenPrefab" && method.GetParameters().Length == 1)
                    {
                        s_OpenPrefab = methods[i];
                        break;
                    }
                }
            }

            return (PrefabStage)s_OpenPrefab.Invoke(null, new object[] { root });
        }

        static System.Reflection.MethodInfo s_save = null;

        static bool SaveCurrentModifiedPrefabStagesIfUserWantsTo(PrefabStage cps)
        {
            if (s_save == null)
            {
                s_save = typeof(PrefabStage).GetMethod("SavePrefab", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            }

            return (bool)s_save.Invoke(cps, new object[] { });
        }

        public static bool Modify(string file, System.Action<GameObject> func)
        {
            var ps = OpenPrefab(file);
            func(ps.prefabContentsRoot);
            return SaveCurrentModifiedPrefabStagesIfUserWantsTo(ps);
        }
    }
}