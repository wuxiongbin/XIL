#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;

namespace wxb.IL.Editor
{
    public class GlobalCoroutine
    {
        static List<IEnumerator> CoroutineList = new List<IEnumerator>();

        static bool IsInit = false;
        public static void StartCoroutine(IEnumerator routine)
        {
            Init();
            if (routine.MoveNext())
            {
                CoroutineList.Add(routine);
            }
        }

        static void Init()
        {
            if (!IsInit || UnityEditor.EditorApplication.update == null)
            {
                IsInit = true;
                UnityEditor.EditorApplication.update += Update;
            }
        }

        static void UnInit()
        {
            if (IsInit)
            {
                IsInit = false;
                UnityEditor.EditorApplication.update -= Update;
            }
        }

        static void Update()
        {
            if (CoroutineList.Count != 0)
            {
                List<IEnumerator> list = new List<IEnumerator>(CoroutineList);
                CoroutineList.Clear();
                for (int i = 0; i < list.Count; ++i)
                {
                    if (list[i].MoveNext())
                        CoroutineList.Add(list[i]);
                }
            }
            else
            {
                UnInit();
            }
        }
    }
}

#endif