using System.Collections;

namespace wxb
{
    public static class L
    {
        public interface I
        {
            void Log(object obj);
            void LogFormat(string format, params object[] objs);
            void LogWarningFormat(string format, params object[] objs);            
            void LogError(object obj);
            void LogErrorFormat(string format, params object[] objs);
            void LogException(System.Exception ex);
        }

        class UnityLog : I
        {
            void I.Log(object obj)
            {
                UnityEngine.Debug.Log(obj);
            }

            void I.LogFormat(string format, params object[] objs)
            {
                UnityEngine.Debug.LogFormat(format, objs);
            }
            void I.LogWarningFormat(string format, params object[] objs)
            {
                UnityEngine.Debug.LogWarningFormat(format, objs);
            }
            void I.LogError(object obj)
            {
                UnityEngine.Debug.LogError(obj);
            }
            void I.LogErrorFormat(string format, params object[] objs)
            {
                UnityEngine.Debug.LogErrorFormat(format, objs);
            }
            void I.LogException(System.Exception ex)
            {
                UnityEngine.Debug.LogException(ex);
            }
        }

        static I active = new UnityLog();

        public static void Set(I l)
        {
            active = l;
        }

        public static void Log(object obj)
        {
            if (active == null)
                return;

            active.Log(obj);
        }

        //[System.Diagnostics.Conditional("DEBUGLOG")]
        static public void LogFormat(string format, params object[] objs)
        {
            if (active == null)
                return;

            active.LogFormat(format, objs);
        }

        static public void LogWarningFormat(string format, params object[] objs)
        {
            if (active == null)
                return;

            active.LogWarningFormat(format, objs);
        }

        static public void LogError(object obj)
        {
            if (active == null)
                return;

            active.LogError(obj);
        }

        static public void LogErrorFormat(string format, params object[] objs)
        {
            if (active == null)
                return;

            active.LogErrorFormat(format, objs);
        }

        static public void LogException(System.Exception ex)
        {
            if (active == null)
                return;

            active.LogException(ex);
        }
    }
}
