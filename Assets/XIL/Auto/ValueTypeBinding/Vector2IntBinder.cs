#if USE_HOT
using UnityEngine;
using System.Collections.Generic;
using ILRuntime.Other;
using System;
using System.Reflection;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Runtime.Stack;
using System.Numerics;

namespace ILRuntime.Runtime.Generated
{
    public unsafe class Vector2IntBinder : ValueTypeBinder<Vector2Int>
    {
        public override unsafe void AssignFromStack(ref Vector2Int ins, StackObject* ptr, IList<object> mStack)
        {
            var v = ILIntepreter.Minus(ptr, 1);
            ins.x = v->Value;
            v = ILIntepreter.Minus(ptr, 2);
            ins.y = v->Value;
        }

        public override unsafe void CopyValueTypeToStack(ref Vector2Int ins, StackObject* ptr, IList<object> mStack)
        {
            var v = ILIntepreter.Minus(ptr, 1);
            v->Value = ins.x;
            v = ILIntepreter.Minus(ptr, 2);
            v->Value = ins.y;
        }
    }
}
#endif