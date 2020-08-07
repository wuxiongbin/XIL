#if USE_HOT
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Linq;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class System_Linq_Enumerable_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(System.Linq.Enumerable);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Int32>)};
            method = type.GetMethod("Average", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Average_0);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Int64>)};
            method = type.GetMethod("Average", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Average_1);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Double>)};
            method = type.GetMethod("Average", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Average_2);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Single>)};
            method = type.GetMethod("Average", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Average_3);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Decimal>)};
            method = type.GetMethod("Average", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Average_4);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>>)};
            method = type.GetMethod("Average", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Average_5);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>>)};
            method = type.GetMethod("Average", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Average_6);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>>)};
            method = type.GetMethod("Average", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Average_7);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>>)};
            method = type.GetMethod("Average", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Average_8);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Single>>)};
            method = type.GetMethod("Average", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Average_9);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Int32>)};
            method = type.GetMethod("Max", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Max_10);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Int64>)};
            method = type.GetMethod("Max", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Max_11);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Double>)};
            method = type.GetMethod("Max", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Max_12);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Single>)};
            method = type.GetMethod("Max", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Max_13);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Decimal>)};
            method = type.GetMethod("Max", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Max_14);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>>)};
            method = type.GetMethod("Max", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Max_15);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>>)};
            method = type.GetMethod("Max", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Max_16);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>>)};
            method = type.GetMethod("Max", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Max_17);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Single>>)};
            method = type.GetMethod("Max", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Max_18);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>>)};
            method = type.GetMethod("Max", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Max_19);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Int32>)};
            method = type.GetMethod("Min", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Min_20);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Int64>)};
            method = type.GetMethod("Min", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Min_21);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Double>)};
            method = type.GetMethod("Min", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Min_22);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Single>)};
            method = type.GetMethod("Min", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Min_23);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Decimal>)};
            method = type.GetMethod("Min", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Min_24);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>>)};
            method = type.GetMethod("Min", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Min_25);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>>)};
            method = type.GetMethod("Min", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Min_26);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>>)};
            method = type.GetMethod("Min", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Min_27);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Single>>)};
            method = type.GetMethod("Min", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Min_28);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>>)};
            method = type.GetMethod("Min", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Min_29);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("Range", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Range_30);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Int32>)};
            method = type.GetMethod("Sum", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sum_31);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>>)};
            method = type.GetMethod("Sum", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sum_32);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Int64>)};
            method = type.GetMethod("Sum", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sum_33);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>>)};
            method = type.GetMethod("Sum", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sum_34);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Double>)};
            method = type.GetMethod("Sum", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sum_35);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>>)};
            method = type.GetMethod("Sum", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sum_36);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Single>)};
            method = type.GetMethod("Sum", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sum_37);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Single>>)};
            method = type.GetMethod("Sum", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sum_38);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Decimal>)};
            method = type.GetMethod("Sum", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sum_39);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>>)};
            method = type.GetMethod("Sum", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sum_40);





        }


        static StackObject* Average_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Int32> @source = (System.Collections.Generic.IEnumerable<System.Int32>)typeof(System.Collections.Generic.IEnumerable<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Average(@source);

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Average_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Int64> @source = (System.Collections.Generic.IEnumerable<System.Int64>)typeof(System.Collections.Generic.IEnumerable<System.Int64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Average(@source);

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Average_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Double> @source = (System.Collections.Generic.IEnumerable<System.Double>)typeof(System.Collections.Generic.IEnumerable<System.Double>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Average(@source);

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Average_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Single> @source = (System.Collections.Generic.IEnumerable<System.Single>)typeof(System.Collections.Generic.IEnumerable<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Average(@source);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Average_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Decimal> @source = (System.Collections.Generic.IEnumerable<System.Decimal>)typeof(System.Collections.Generic.IEnumerable<System.Decimal>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Average(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Average_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Average(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Average_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Average(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Average_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Double>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Average(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Average_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Average(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Average_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Single>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Single>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Single>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Average(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Max_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Int32> @source = (System.Collections.Generic.IEnumerable<System.Int32>)typeof(System.Collections.Generic.IEnumerable<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Max(@source);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Max_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Int64> @source = (System.Collections.Generic.IEnumerable<System.Int64>)typeof(System.Collections.Generic.IEnumerable<System.Int64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Max(@source);

            __ret->ObjectType = ObjectTypes.Long;
            *(long*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Max_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Double> @source = (System.Collections.Generic.IEnumerable<System.Double>)typeof(System.Collections.Generic.IEnumerable<System.Double>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Max(@source);

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Max_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Single> @source = (System.Collections.Generic.IEnumerable<System.Single>)typeof(System.Collections.Generic.IEnumerable<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Max(@source);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Max_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Decimal> @source = (System.Collections.Generic.IEnumerable<System.Decimal>)typeof(System.Collections.Generic.IEnumerable<System.Decimal>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Max(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Max_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Max(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Max_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Max(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Max_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Double>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Max(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Max_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Single>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Single>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Single>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Max(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Max_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Max(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Min_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Int32> @source = (System.Collections.Generic.IEnumerable<System.Int32>)typeof(System.Collections.Generic.IEnumerable<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Min(@source);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Min_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Int64> @source = (System.Collections.Generic.IEnumerable<System.Int64>)typeof(System.Collections.Generic.IEnumerable<System.Int64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Min(@source);

            __ret->ObjectType = ObjectTypes.Long;
            *(long*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Min_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Double> @source = (System.Collections.Generic.IEnumerable<System.Double>)typeof(System.Collections.Generic.IEnumerable<System.Double>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Min(@source);

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Min_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Single> @source = (System.Collections.Generic.IEnumerable<System.Single>)typeof(System.Collections.Generic.IEnumerable<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Min(@source);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Min_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Decimal> @source = (System.Collections.Generic.IEnumerable<System.Decimal>)typeof(System.Collections.Generic.IEnumerable<System.Decimal>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Min(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Min_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Min(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Min_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Min(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Min_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Double>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Min(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Min_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Single>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Single>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Single>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Min(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Min_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Min(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Range_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @count = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @start = ptr_of_this_method->Value;


            var result_of_this_method = System.Linq.Enumerable.Range(@start, @count);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Sum_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Int32> @source = (System.Collections.Generic.IEnumerable<System.Int32>)typeof(System.Collections.Generic.IEnumerable<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Sum(@source);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Sum_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Sum(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Sum_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Int64> @source = (System.Collections.Generic.IEnumerable<System.Int64>)typeof(System.Collections.Generic.IEnumerable<System.Int64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Sum(@source);

            __ret->ObjectType = ObjectTypes.Long;
            *(long*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Sum_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Sum(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Sum_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Double> @source = (System.Collections.Generic.IEnumerable<System.Double>)typeof(System.Collections.Generic.IEnumerable<System.Double>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Sum(@source);

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Sum_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Double>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Sum(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Sum_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Single> @source = (System.Collections.Generic.IEnumerable<System.Single>)typeof(System.Collections.Generic.IEnumerable<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Sum(@source);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Sum_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Single>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Single>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Single>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Sum(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Sum_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Decimal> @source = (System.Collections.Generic.IEnumerable<System.Decimal>)typeof(System.Collections.Generic.IEnumerable<System.Decimal>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Sum(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Sum_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>> @source = (System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>>)typeof(System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.Sum(@source);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}
#endif
