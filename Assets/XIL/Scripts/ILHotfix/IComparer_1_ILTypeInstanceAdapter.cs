#if USE_HOT
using System;
using System.Reflection;
using IL;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace wxb
{   
    public class IComparer_1_ILTypeInstanceAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get
            {
                return typeof(System.Collections.Generic.IComparer<ILTypeInstance>);
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

        public class Adapter : System.Collections.Generic.IComparer<ILTypeInstance>, CrossBindingAdaptorType
        {
            bool isInvokingToString;
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

            IMethod method_Compare;

            public System.Int32 Compare(ILRuntime.Runtime.Intepreter.ILTypeInstance x, ILRuntime.Runtime.Intepreter.ILTypeInstance y)
            {
                if (method_Compare == null)
                    method_Compare = instance.Type.GetMethod("Compare");

                try
                {
                    using (var ctx = appdomain.BeginInvoke(method_Compare))
                    {
                        ctx.PushObject(instance);
                        ctx.PushObject(x, false);
                        ctx.PushObject(y, false);
                        ctx.Invoke();
                        return ctx.ReadInteger();
                    }
                }
                finally
                {

                }
            }

            public override string ToString()
            {
                IMethod m = appdomain.ObjectType.GetMethod("ToString", 0);
                m = instance.Type.GetVirtualMethod(m);
                if (m == null || m is ILMethod)
                {
                    if (!isInvokingToString)
                    {
                        isInvokingToString = true;
                        string res = instance.ToString();
                        isInvokingToString = false;
                        return res;
                    }
                    else
                        return instance.Type.FullName;
                }
                else
                    return instance.Type.FullName;
            }
        }
    }
}
#endif
