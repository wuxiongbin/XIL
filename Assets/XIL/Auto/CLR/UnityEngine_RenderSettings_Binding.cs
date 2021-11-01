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
    unsafe class UnityEngine_RenderSettings_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.RenderSettings);
            args = new Type[]{};
            method = type.GetMethod("get_fog", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_fog_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_fog", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_fog_1);
            args = new Type[]{};
            method = type.GetMethod("get_fogStartDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_fogStartDistance_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_fogStartDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_fogStartDistance_3);
            args = new Type[]{};
            method = type.GetMethod("get_fogEndDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_fogEndDistance_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_fogEndDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_fogEndDistance_5);
            args = new Type[]{};
            method = type.GetMethod("get_fogMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_fogMode_6);
            args = new Type[]{typeof(UnityEngine.FogMode)};
            method = type.GetMethod("set_fogMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_fogMode_7);
            args = new Type[]{};
            method = type.GetMethod("get_fogColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_fogColor_8);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("set_fogColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_fogColor_9);
            args = new Type[]{};
            method = type.GetMethod("get_fogDensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_fogDensity_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_fogDensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_fogDensity_11);
            args = new Type[]{};
            method = type.GetMethod("get_ambientMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ambientMode_12);
            args = new Type[]{typeof(UnityEngine.Rendering.AmbientMode)};
            method = type.GetMethod("set_ambientMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ambientMode_13);
            args = new Type[]{};
            method = type.GetMethod("get_ambientSkyColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ambientSkyColor_14);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("set_ambientSkyColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ambientSkyColor_15);
            args = new Type[]{};
            method = type.GetMethod("get_ambientEquatorColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ambientEquatorColor_16);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("set_ambientEquatorColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ambientEquatorColor_17);
            args = new Type[]{};
            method = type.GetMethod("get_ambientGroundColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ambientGroundColor_18);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("set_ambientGroundColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ambientGroundColor_19);
            args = new Type[]{};
            method = type.GetMethod("get_ambientIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ambientIntensity_20);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_ambientIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ambientIntensity_21);
            args = new Type[]{};
            method = type.GetMethod("get_ambientLight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ambientLight_22);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("set_ambientLight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ambientLight_23);
            args = new Type[]{};
            method = type.GetMethod("get_subtractiveShadowColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_subtractiveShadowColor_24);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("set_subtractiveShadowColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_subtractiveShadowColor_25);
            args = new Type[]{};
            method = type.GetMethod("get_skybox", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_skybox_26);
            args = new Type[]{typeof(UnityEngine.Material)};
            method = type.GetMethod("set_skybox", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_skybox_27);
            args = new Type[]{};
            method = type.GetMethod("get_sun", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sun_28);
            args = new Type[]{typeof(UnityEngine.Light)};
            method = type.GetMethod("set_sun", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sun_29);
            args = new Type[]{};
            method = type.GetMethod("get_ambientProbe", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ambientProbe_30);
            args = new Type[]{typeof(UnityEngine.Rendering.SphericalHarmonicsL2)};
            method = type.GetMethod("set_ambientProbe", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ambientProbe_31);
            args = new Type[]{};
            method = type.GetMethod("get_customReflection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_customReflection_32);
            args = new Type[]{typeof(UnityEngine.Cubemap)};
            method = type.GetMethod("set_customReflection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_customReflection_33);
            args = new Type[]{};
            method = type.GetMethod("get_reflectionIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reflectionIntensity_34);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_reflectionIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reflectionIntensity_35);
            args = new Type[]{};
            method = type.GetMethod("get_reflectionBounces", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reflectionBounces_36);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_reflectionBounces", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reflectionBounces_37);
            args = new Type[]{};
            method = type.GetMethod("get_defaultReflectionMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultReflectionMode_38);
            args = new Type[]{typeof(UnityEngine.Rendering.DefaultReflectionMode)};
            method = type.GetMethod("set_defaultReflectionMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_defaultReflectionMode_39);
            args = new Type[]{};
            method = type.GetMethod("get_defaultReflectionResolution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultReflectionResolution_40);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_defaultReflectionResolution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_defaultReflectionResolution_41);
            args = new Type[]{};
            method = type.GetMethod("get_haloStrength", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_haloStrength_42);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_haloStrength", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_haloStrength_43);
            args = new Type[]{};
            method = type.GetMethod("get_flareStrength", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_flareStrength_44);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_flareStrength", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_flareStrength_45);
            args = new Type[]{};
            method = type.GetMethod("get_flareFadeSpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_flareFadeSpeed_46);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_flareFadeSpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_flareFadeSpeed_47);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.RenderSettings[s]);


        }


        static StackObject* get_fog_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.fog;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_fog_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.RenderSettings.fog = value;

            return __ret;
        }

        static StackObject* get_fogStartDistance_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.fogStartDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_fogStartDistance_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.RenderSettings.fogStartDistance = value;

            return __ret;
        }

        static StackObject* get_fogEndDistance_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.fogEndDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_fogEndDistance_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.RenderSettings.fogEndDistance = value;

            return __ret;
        }

        static StackObject* get_fogMode_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.fogMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_fogMode_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.FogMode @value = (UnityEngine.FogMode)typeof(UnityEngine.FogMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.RenderSettings.fogMode = value;

            return __ret;
        }

        static StackObject* get_fogColor_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.fogColor;

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* set_fogColor_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @value = new UnityEngine.Color();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder.ParseValue(ref @value, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }


            UnityEngine.RenderSettings.fogColor = value;

            return __ret;
        }

        static StackObject* get_fogDensity_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.fogDensity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_fogDensity_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.RenderSettings.fogDensity = value;

            return __ret;
        }

        static StackObject* get_ambientMode_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.ambientMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_ambientMode_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.AmbientMode @value = (UnityEngine.Rendering.AmbientMode)typeof(UnityEngine.Rendering.AmbientMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.RenderSettings.ambientMode = value;

            return __ret;
        }

        static StackObject* get_ambientSkyColor_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.ambientSkyColor;

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* set_ambientSkyColor_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @value = new UnityEngine.Color();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder.ParseValue(ref @value, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }


            UnityEngine.RenderSettings.ambientSkyColor = value;

            return __ret;
        }

        static StackObject* get_ambientEquatorColor_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.ambientEquatorColor;

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* set_ambientEquatorColor_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @value = new UnityEngine.Color();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder.ParseValue(ref @value, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }


            UnityEngine.RenderSettings.ambientEquatorColor = value;

            return __ret;
        }

        static StackObject* get_ambientGroundColor_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.ambientGroundColor;

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* set_ambientGroundColor_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @value = new UnityEngine.Color();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder.ParseValue(ref @value, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }


            UnityEngine.RenderSettings.ambientGroundColor = value;

            return __ret;
        }

        static StackObject* get_ambientIntensity_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.ambientIntensity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_ambientIntensity_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.RenderSettings.ambientIntensity = value;

            return __ret;
        }

        static StackObject* get_ambientLight_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.ambientLight;

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* set_ambientLight_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @value = new UnityEngine.Color();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder.ParseValue(ref @value, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }


            UnityEngine.RenderSettings.ambientLight = value;

            return __ret;
        }

        static StackObject* get_subtractiveShadowColor_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.subtractiveShadowColor;

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* set_subtractiveShadowColor_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @value = new UnityEngine.Color();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Color_Binding_Binder.ParseValue(ref @value, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }


            UnityEngine.RenderSettings.subtractiveShadowColor = value;

            return __ret;
        }

        static StackObject* get_skybox_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.skybox;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_skybox_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material @value = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.RenderSettings.skybox = value;

            return __ret;
        }

        static StackObject* get_sun_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.sun;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_sun_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Light @value = (UnityEngine.Light)typeof(UnityEngine.Light).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.RenderSettings.sun = value;

            return __ret;
        }

        static StackObject* get_ambientProbe_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.ambientProbe;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_ambientProbe_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.SphericalHarmonicsL2 @value = (UnityEngine.Rendering.SphericalHarmonicsL2)typeof(UnityEngine.Rendering.SphericalHarmonicsL2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.RenderSettings.ambientProbe = value;

            return __ret;
        }

        static StackObject* get_customReflection_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.customReflection;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_customReflection_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cubemap @value = (UnityEngine.Cubemap)typeof(UnityEngine.Cubemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.RenderSettings.customReflection = value;

            return __ret;
        }

        static StackObject* get_reflectionIntensity_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.reflectionIntensity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_reflectionIntensity_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.RenderSettings.reflectionIntensity = value;

            return __ret;
        }

        static StackObject* get_reflectionBounces_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.reflectionBounces;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_reflectionBounces_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.RenderSettings.reflectionBounces = value;

            return __ret;
        }

        static StackObject* get_defaultReflectionMode_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.defaultReflectionMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_defaultReflectionMode_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.DefaultReflectionMode @value = (UnityEngine.Rendering.DefaultReflectionMode)typeof(UnityEngine.Rendering.DefaultReflectionMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.RenderSettings.defaultReflectionMode = value;

            return __ret;
        }

        static StackObject* get_defaultReflectionResolution_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.defaultReflectionResolution;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_defaultReflectionResolution_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.RenderSettings.defaultReflectionResolution = value;

            return __ret;
        }

        static StackObject* get_haloStrength_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.haloStrength;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_haloStrength_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.RenderSettings.haloStrength = value;

            return __ret;
        }

        static StackObject* get_flareStrength_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.flareStrength;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_flareStrength_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.RenderSettings.flareStrength = value;

            return __ret;
        }

        static StackObject* get_flareFadeSpeed_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.RenderSettings.flareFadeSpeed;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_flareFadeSpeed_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.RenderSettings.flareFadeSpeed = value;

            return __ret;
        }





    }
}
#endif
