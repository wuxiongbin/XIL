#if USE_HOT
using UnityEngine;
using System.Collections.Generic;
using ILRuntime.Other;
using System;
using System.Collections;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.CLR.Method;

namespace wxb
{
    public class IEnumerableAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get
            {
                return null;
            }
        }

        public override Type[] BaseCLRTypes
        {
            get
            {
                return new Type[]
                {
                    typeof(IEnumerable<object>),
                    typeof(IEnumerable),
                    typeof(IEnumerator<object>),
                    typeof(IEnumerator),
                    typeof(IDisposable)
                };
            }
        }

        public override Type AdaptorType
        {
            get
            {
                return typeof(Adapter);
            }
        }

        public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
        {
            return new Adapter(appdomain, instance);
        }

        public class Adapter : 
            IEnumerable<object>,
            IEnumerable,
            IEnumerator<object>,
            IEnumerator,
            IDisposable,
            CrossBindingAdaptorType
        {
            CrossBindingFunctionInfo<bool> mMoveNext = new CrossBindingFunctionInfo<bool>("MoveNext");

            CrossBindingFunctionInfo<IEnumerator<object>> mGetEnumerator_0 = new CrossBindingFunctionInfo<IEnumerator<object>>("System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator");
            CrossBindingFunctionInfo<IEnumerator> mGetEnumerator_1 = new CrossBindingFunctionInfo<IEnumerator>("System.Collections.IEnumerable.GetEnumerator");

            CrossBindingMethodInfo mReset = new CrossBindingMethodInfo("System.Collections.IEnumerator.Reset");
            CrossBindingMethodInfo mDispose = new CrossBindingMethodInfo("System.IDisposable.Dispose");

            CrossBindingFunctionInfo<object> mCurrent_0 = new CrossBindingFunctionInfo<object>("System.Collections.Generic.IEnumerator<System.Object>.get_Current");
            CrossBindingFunctionInfo<object> mCurrent_1 = new CrossBindingFunctionInfo<object>("System.Collections.IEnumerator.get_Current");

            ILTypeInstance instance;
            ILRuntime.Runtime.Enviorment.AppDomain appdomain;

            public Adapter()
            {

            }

            public Adapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
            {
                this.appdomain = appdomain;
                this.instance = instance;
            }

            public ILTypeInstance ILInstance { get { return instance; } }

            object IEnumerator<System.Object>.Current
            {
                get
                {
                    return mCurrent_0.Invoke(instance);
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return mCurrent_1.Invoke(instance);
                }
            }

            void IDisposable.Dispose()
            {
                mDispose.Invoke(instance);
            }

            bool IEnumerator.MoveNext()
            {
                return mMoveNext.Invoke(instance);
            }

            void IEnumerator.Reset()
            {
                mReset.Invoke(instance);
            }

            IEnumerator<object> IEnumerable<object>.GetEnumerator()
            {
                return mGetEnumerator_0.Invoke(instance);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return mGetEnumerator_1.Invoke(instance);
            }
        }
    }
}

#endif