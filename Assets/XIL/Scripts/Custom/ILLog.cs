#if USE_ILRT
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
        public static void Log(ILIntepreter __intp, Enviorment.AppDomain __domain, UnityEngine.LogType level, string text)
        {
            UnityEngine.Debug.unityLogger.Log(level,
                string.Format("{0}\nStackTrance:{1}", text, __domain.DebugService.GetStackTrace(__intp)));
        }
    }
}
#endif