#if USE_HOT
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

namespace ILRuntime.Runtime.Generated
{
    public unsafe class ColorBinder : ValueTypeBinder<Color>
    {
        public override unsafe void AssignFromStack(ref Color ins, StackObject* ptr, IList<object> mStack)
        {
            StackObject* v = null;
            v = ILIntepreter.Minus(ptr, 1); ins.r = *(float*)&v->Value;
            v = ILIntepreter.Minus(ptr, 2); ins.g = *(float*)&v->Value;
            v = ILIntepreter.Minus(ptr, 3); ins.b = *(float*)&v->Value;
            v = ILIntepreter.Minus(ptr, 4); ins.a = *(float*)&v->Value;
        }

        public override unsafe void CopyValueTypeToStack(ref Color ins, StackObject* ptr, IList<object> mStack)
        {
            StackObject* v = null;
            v = ILIntepreter.Minus(ptr, 1); *(float*)&v->Value = ins.r;
            v = ILIntepreter.Minus(ptr, 2); *(float*)&v->Value = ins.g;
            v = ILIntepreter.Minus(ptr, 3); *(float*)&v->Value = ins.b;
            v = ILIntepreter.Minus(ptr, 4); *(float*)&v->Value = ins.a;
        }
    }
}
#endif