#if USE_ILRT
using System;
using System.Linq;
using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Runtime.Stack;
//#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
#if HOT_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace ILRuntime.Runtime.Generated
{
    public unsafe class RectIntBinder : ValueTypeBinder<RectInt>
    {
        public override unsafe void AssignFromStack(ref RectInt ins, StackObject* ptr, IList<object> mStack)
        {
            StackObject* v = null;
            v = ILIntepreter.Minus(ptr, 1); ins.x = v->Value;
            v = ILIntepreter.Minus(ptr, 2); ins.y = v->Value;
            v = ILIntepreter.Minus(ptr, 3); ins.width = v->Value;
            v = ILIntepreter.Minus(ptr, 4); ins.height = v->Value;
        }

        public override unsafe void CopyValueTypeToStack(ref RectInt ins, StackObject* ptr, IList<object> mStack)
        {
            StackObject* v = null;
            v = ILIntepreter.Minus(ptr, 1); v->Value = ins.x;
            v = ILIntepreter.Minus(ptr, 2); v->Value = ins.y;
            v = ILIntepreter.Minus(ptr, 3); v->Value = ins.width;
            v = ILIntepreter.Minus(ptr, 4); v->Value = ins.height;
        }
    }
}
#endif