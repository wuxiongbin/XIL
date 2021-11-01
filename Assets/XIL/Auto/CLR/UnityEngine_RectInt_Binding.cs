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
    unsafe class UnityEngine_RectInt_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.RectInt);
            args = new Type[]{};
            method = type.GetMethod("get_x", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_x_0);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_x", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_x_1);
            args = new Type[]{};
            method = type.GetMethod("get_y", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_y_2);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_y", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_y_3);
            args = new Type[]{};
            method = type.GetMethod("get_center", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_center_4);
            args = new Type[]{};
            method = type.GetMethod("get_min", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_min_5);
            args = new Type[]{typeof(UnityEngine.Vector2Int)};
            method = type.GetMethod("set_min", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_min_6);
            args = new Type[]{};
            method = type.GetMethod("get_max", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_max_7);
            args = new Type[]{typeof(UnityEngine.Vector2Int)};
            method = type.GetMethod("set_max", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_max_8);
            args = new Type[]{};
            method = type.GetMethod("get_width", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_width_9);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_width", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_width_10);
            args = new Type[]{};
            method = type.GetMethod("get_height", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_height_11);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_height", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_height_12);
            args = new Type[]{};
            method = type.GetMethod("get_xMin", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_xMin_13);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_xMin", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_xMin_14);
            args = new Type[]{};
            method = type.GetMethod("get_yMin", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_yMin_15);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_yMin", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_yMin_16);
            args = new Type[]{};
            method = type.GetMethod("get_xMax", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_xMax_17);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_xMax", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_xMax_18);
            args = new Type[]{};
            method = type.GetMethod("get_yMax", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_yMax_19);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_yMax", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_yMax_20);
            args = new Type[]{};
            method = type.GetMethod("get_position", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_position_21);
            args = new Type[]{typeof(UnityEngine.Vector2Int)};
            method = type.GetMethod("set_position", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_position_22);
            args = new Type[]{};
            method = type.GetMethod("get_size", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_size_23);
            args = new Type[]{typeof(UnityEngine.Vector2Int)};
            method = type.GetMethod("set_size", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_size_24);
            args = new Type[]{typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int)};
            method = type.GetMethod("SetMinMax", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetMinMax_25);
            args = new Type[]{typeof(UnityEngine.RectInt)};
            method = type.GetMethod("ClampToBounds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClampToBounds_26);
            args = new Type[]{typeof(UnityEngine.Vector2Int)};
            method = type.GetMethod("Contains", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Contains_27);
            args = new Type[]{typeof(UnityEngine.RectInt)};
            method = type.GetMethod("Overlaps", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Overlaps_28);
            args = new Type[]{};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_29);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_30);
            args = new Type[]{typeof(System.String), typeof(System.IFormatProvider)};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_31);
            args = new Type[]{typeof(UnityEngine.RectInt)};
            method = type.GetMethod("Equals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Equals_32);
            args = new Type[]{};
            method = type.GetMethod("get_allPositionsWithin", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_allPositionsWithin_33);


            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.RectInt());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.RectInt[s]);

            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);

        }

        static void WriteBackInstance(ILRuntime.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.RectInt instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.RectInt[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* get_x_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.x;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_x_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            instance_of_this_method.x = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_y_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.y;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_y_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            instance_of_this_method.y = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_center_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.center;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* get_min_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.min;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* set_min_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2Int @value = new UnityEngine.Vector2Int();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder.ParseValue(ref @value, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @value = (UnityEngine.Vector2Int)typeof(UnityEngine.Vector2Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            instance_of_this_method.min = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_max_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.max;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* set_max_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2Int @value = new UnityEngine.Vector2Int();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder.ParseValue(ref @value, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @value = (UnityEngine.Vector2Int)typeof(UnityEngine.Vector2Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            instance_of_this_method.max = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_width_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.width;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_width_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            instance_of_this_method.width = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_height_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.height;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_height_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            instance_of_this_method.height = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_xMin_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.xMin;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_xMin_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            instance_of_this_method.xMin = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_yMin_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.yMin;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_yMin_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            instance_of_this_method.yMin = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_xMax_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.xMax;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_xMax_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            instance_of_this_method.xMax = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_yMax_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.yMax;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_yMax_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            instance_of_this_method.yMax = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_position_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.position;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* set_position_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2Int @value = new UnityEngine.Vector2Int();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder.ParseValue(ref @value, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @value = (UnityEngine.Vector2Int)typeof(UnityEngine.Vector2Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            instance_of_this_method.position = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_size_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.size;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* set_size_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2Int @value = new UnityEngine.Vector2Int();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder.ParseValue(ref @value, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @value = (UnityEngine.Vector2Int)typeof(UnityEngine.Vector2Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            instance_of_this_method.size = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* SetMinMax_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2Int @maxPosition = new UnityEngine.Vector2Int();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder.ParseValue(ref @maxPosition, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @maxPosition = (UnityEngine.Vector2Int)typeof(UnityEngine.Vector2Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2Int @minPosition = new UnityEngine.Vector2Int();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder.ParseValue(ref @minPosition, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @minPosition = (UnityEngine.Vector2Int)typeof(UnityEngine.Vector2Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            instance_of_this_method.SetMinMax(@minPosition, @maxPosition);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* ClampToBounds_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt @bounds = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref @bounds, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @bounds = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            instance_of_this_method.ClampToBounds(@bounds);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* Contains_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2Int @position = new UnityEngine.Vector2Int();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder.ParseValue(ref @position, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @position = (UnityEngine.Vector2Int)typeof(UnityEngine.Vector2Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.Contains(@position);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Overlaps_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt @other = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref @other, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @other = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.Overlaps(@other);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ToString_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.ToString();

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToString_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @format = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.ToString(@format);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToString_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.IFormatProvider @formatProvider = (System.IFormatProvider)typeof(System.IFormatProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @format = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.ToString(@format, @formatProvider);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Equals_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt @other = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref @other, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @other = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.Equals(@other);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_allPositionsWithin_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectInt instance_of_this_method = new UnityEngine.RectInt();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);
            } else {
                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
                instance_of_this_method = (UnityEngine.RectInt)typeof(UnityEngine.RectInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }

            var result_of_this_method = instance_of_this_method.allPositionsWithin;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            } else {
                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);
            }

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.RectInt();
            ins = (UnityEngine.RectInt)o;
            return ins;
        }

        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @height = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @width = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @yMin = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @xMin = ptr_of_this_method->Value;


            var result_of_this_method = new UnityEngine.RectInt(@xMin, @yMin, @width, @height);

            if(!isNewObj)
            {
                __ret--;
                if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                    ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, __ret, __mStack, ref result_of_this_method);
                } else {
                    WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);
                }
                return __ret;
            }

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
                return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2Int @size = new UnityEngine.Vector2Int();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder.ParseValue(ref @size, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @size = (UnityEngine.Vector2Int)typeof(UnityEngine.Vector2Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2Int @position = new UnityEngine.Vector2Int();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder.ParseValue(ref @position, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @position = (UnityEngine.Vector2Int)typeof(UnityEngine.Vector2Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }


            var result_of_this_method = new UnityEngine.RectInt(@position, @size);

            if(!isNewObj)
            {
                __ret--;
                if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                    ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.WriteBackValue(__domain, __ret, __mStack, ref result_of_this_method);
                } else {
                    WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);
                }
                return __ret;
            }

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_RectInt_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
                return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }


    }
}
#endif
