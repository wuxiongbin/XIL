#if USE_ILRT
using UnityEngine;
using System.Collections.Generic;
using ILRuntime.Other;
using System;
using System.Reflection;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Stack;
//#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
#if HOT_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace ILRuntime.Runtime.Generated
{
    public unsafe class Vector3IntBinder : ValueTypeBinder<Vector3Int>
    {
        public override unsafe void AssignFromStack(ref Vector3Int ins, StackObject* ptr, IList<object> mStack)
        {
            var v = ILIntepreter.Minus(ptr, 1);
            ins.x = v->Value;
            v = ILIntepreter.Minus(ptr, 2);
            ins.y = v->Value;
            v = ILIntepreter.Minus(ptr, 3);
            ins.z = v->Value;
        }

        public override unsafe void CopyValueTypeToStack(ref Vector3Int ins, StackObject* ptr, IList<object> mStack)
        {
            var v = ILIntepreter.Minus(ptr, 1);
            v->Value = ins.x;
            v = ILIntepreter.Minus(ptr, 2);
            v->Value = ins.y;
            v = ILIntepreter.Minus(ptr, 3);
            v->Value = ins.z;
        }
    }
}
#endif