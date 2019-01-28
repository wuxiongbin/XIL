#if USE_HOT
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class ILLog
    {
        public static void Log(ILIntepreter __intp, Enviorment.AppDomain __domain, UnityEngine.LogType level, string format, params object[] objs)
        {
            var text = (objs == null || objs.Length == 0) ? format : string.Format(format, objs);

            var t = string.Format("{0}\nStackTrance:{1}", text, __domain.DebugService.GetStackTrance(__intp));
            switch (level)
            {
            case UnityEngine.LogType.Error:
                UnityEngine.Debug.LogError(t);
                break;
            case UnityEngine.LogType.Log:
                UnityEngine.Debug.Log(t);
                break;
            case UnityEngine.LogType.Warning:
                UnityEngine.Debug.LogWarning(t);
                break;
            }
        }
    }
}
#endif