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
    unsafe class UnityEngine_Renderer_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Renderer);
            args = new Type[]{};
            method = type.GetMethod("get_bounds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_bounds_0);
            args = new Type[]{};
            method = type.GetMethod("HasPropertyBlock", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasPropertyBlock_1);
            args = new Type[]{typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("SetPropertyBlock", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPropertyBlock_2);
            args = new Type[]{typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Int32)};
            method = type.GetMethod("SetPropertyBlock", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPropertyBlock_3);
            args = new Type[]{typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("GetPropertyBlock", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPropertyBlock_4);
            args = new Type[]{typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Int32)};
            method = type.GetMethod("GetPropertyBlock", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPropertyBlock_5);
            args = new Type[]{};
            method = type.GetMethod("get_enabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_enabled_6);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_enabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_enabled_7);
            args = new Type[]{};
            method = type.GetMethod("get_isVisible", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isVisible_8);
            args = new Type[]{};
            method = type.GetMethod("get_shadowCastingMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowCastingMode_9);
            args = new Type[]{typeof(UnityEngine.Rendering.ShadowCastingMode)};
            method = type.GetMethod("set_shadowCastingMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowCastingMode_10);
            args = new Type[]{};
            method = type.GetMethod("get_receiveShadows", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_receiveShadows_11);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_receiveShadows", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_receiveShadows_12);
            args = new Type[]{};
            method = type.GetMethod("get_forceRenderingOff", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_forceRenderingOff_13);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_forceRenderingOff", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_forceRenderingOff_14);
            args = new Type[]{};
            method = type.GetMethod("get_motionVectorGenerationMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_motionVectorGenerationMode_15);
            args = new Type[]{typeof(UnityEngine.MotionVectorGenerationMode)};
            method = type.GetMethod("set_motionVectorGenerationMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_motionVectorGenerationMode_16);
            args = new Type[]{};
            method = type.GetMethod("get_lightProbeUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lightProbeUsage_17);
            args = new Type[]{typeof(UnityEngine.Rendering.LightProbeUsage)};
            method = type.GetMethod("set_lightProbeUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lightProbeUsage_18);
            args = new Type[]{};
            method = type.GetMethod("get_reflectionProbeUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reflectionProbeUsage_19);
            args = new Type[]{typeof(UnityEngine.Rendering.ReflectionProbeUsage)};
            method = type.GetMethod("set_reflectionProbeUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reflectionProbeUsage_20);
            args = new Type[]{};
            method = type.GetMethod("get_renderingLayerMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_renderingLayerMask_21);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_renderingLayerMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_renderingLayerMask_22);
            args = new Type[]{};
            method = type.GetMethod("get_rendererPriority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rendererPriority_23);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_rendererPriority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rendererPriority_24);
            args = new Type[]{};
            method = type.GetMethod("get_rayTracingMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rayTracingMode_25);
            args = new Type[]{typeof(UnityEngine.Experimental.Rendering.RayTracingMode)};
            method = type.GetMethod("set_rayTracingMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rayTracingMode_26);
            args = new Type[]{};
            method = type.GetMethod("get_sortingLayerName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sortingLayerName_27);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_sortingLayerName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sortingLayerName_28);
            args = new Type[]{};
            method = type.GetMethod("get_sortingLayerID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sortingLayerID_29);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_sortingLayerID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sortingLayerID_30);
            args = new Type[]{};
            method = type.GetMethod("get_sortingOrder", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sortingOrder_31);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_sortingOrder", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sortingOrder_32);
            args = new Type[]{};
            method = type.GetMethod("get_allowOcclusionWhenDynamic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_allowOcclusionWhenDynamic_33);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_allowOcclusionWhenDynamic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_allowOcclusionWhenDynamic_34);
            args = new Type[]{};
            method = type.GetMethod("get_isPartOfStaticBatch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isPartOfStaticBatch_35);
            args = new Type[]{};
            method = type.GetMethod("get_worldToLocalMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_worldToLocalMatrix_36);
            args = new Type[]{};
            method = type.GetMethod("get_localToWorldMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_localToWorldMatrix_37);
            args = new Type[]{};
            method = type.GetMethod("get_lightProbeProxyVolumeOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lightProbeProxyVolumeOverride_38);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("set_lightProbeProxyVolumeOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lightProbeProxyVolumeOverride_39);
            args = new Type[]{};
            method = type.GetMethod("get_probeAnchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_probeAnchor_40);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("set_probeAnchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_probeAnchor_41);
            args = new Type[]{};
            method = type.GetMethod("get_lightmapIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lightmapIndex_42);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_lightmapIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lightmapIndex_43);
            args = new Type[]{};
            method = type.GetMethod("get_realtimeLightmapIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_realtimeLightmapIndex_44);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_realtimeLightmapIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_realtimeLightmapIndex_45);
            args = new Type[]{};
            method = type.GetMethod("get_lightmapScaleOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lightmapScaleOffset_46);
            args = new Type[]{typeof(UnityEngine.Vector4)};
            method = type.GetMethod("set_lightmapScaleOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lightmapScaleOffset_47);
            args = new Type[]{};
            method = type.GetMethod("get_realtimeLightmapScaleOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_realtimeLightmapScaleOffset_48);
            args = new Type[]{typeof(UnityEngine.Vector4)};
            method = type.GetMethod("set_realtimeLightmapScaleOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_realtimeLightmapScaleOffset_49);
            args = new Type[]{};
            method = type.GetMethod("get_materials", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_materials_50);
            args = new Type[]{typeof(UnityEngine.Material[])};
            method = type.GetMethod("set_materials", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_materials_51);
            args = new Type[]{};
            method = type.GetMethod("get_material", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_material_52);
            args = new Type[]{typeof(UnityEngine.Material)};
            method = type.GetMethod("set_material", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_material_53);
            args = new Type[]{};
            method = type.GetMethod("get_sharedMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sharedMaterial_54);
            args = new Type[]{typeof(UnityEngine.Material)};
            method = type.GetMethod("set_sharedMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sharedMaterial_55);
            args = new Type[]{};
            method = type.GetMethod("get_sharedMaterials", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sharedMaterials_56);
            args = new Type[]{typeof(UnityEngine.Material[])};
            method = type.GetMethod("set_sharedMaterials", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sharedMaterials_57);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Material>)};
            method = type.GetMethod("GetMaterials", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMaterials_58);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Material>)};
            method = type.GetMethod("GetSharedMaterials", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSharedMaterials_59);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo>)};
            method = type.GetMethod("GetClosestReflectionProbes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetClosestReflectionProbes_60);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Renderer());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Renderer[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_bounds_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.bounds;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* HasPropertyBlock_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.HasPropertyBlock();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetPropertyBlock_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPropertyBlock(@properties);

            return __ret;
        }

        static StackObject* SetPropertyBlock_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @materialIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPropertyBlock(@properties, @materialIndex);

            return __ret;
        }

        static StackObject* GetPropertyBlock_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetPropertyBlock(@properties);

            return __ret;
        }

        static StackObject* GetPropertyBlock_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @materialIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetPropertyBlock(@properties, @materialIndex);

            return __ret;
        }

        static StackObject* get_enabled_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.enabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_enabled_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.enabled = value;

            return __ret;
        }

        static StackObject* get_isVisible_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isVisible;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_shadowCastingMode_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.shadowCastingMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_shadowCastingMode_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ShadowCastingMode @value = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.shadowCastingMode = value;

            return __ret;
        }

        static StackObject* get_receiveShadows_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.receiveShadows;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_receiveShadows_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.receiveShadows = value;

            return __ret;
        }

        static StackObject* get_forceRenderingOff_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.forceRenderingOff;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_forceRenderingOff_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.forceRenderingOff = value;

            return __ret;
        }

        static StackObject* get_motionVectorGenerationMode_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.motionVectorGenerationMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_motionVectorGenerationMode_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MotionVectorGenerationMode @value = (UnityEngine.MotionVectorGenerationMode)typeof(UnityEngine.MotionVectorGenerationMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.motionVectorGenerationMode = value;

            return __ret;
        }

        static StackObject* get_lightProbeUsage_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lightProbeUsage;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_lightProbeUsage_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.LightProbeUsage @value = (UnityEngine.Rendering.LightProbeUsage)typeof(UnityEngine.Rendering.LightProbeUsage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lightProbeUsage = value;

            return __ret;
        }

        static StackObject* get_reflectionProbeUsage_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.reflectionProbeUsage;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_reflectionProbeUsage_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ReflectionProbeUsage @value = (UnityEngine.Rendering.ReflectionProbeUsage)typeof(UnityEngine.Rendering.ReflectionProbeUsage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.reflectionProbeUsage = value;

            return __ret;
        }

        static StackObject* get_renderingLayerMask_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.renderingLayerMask;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_renderingLayerMask_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 @value = (uint)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.renderingLayerMask = value;

            return __ret;
        }

        static StackObject* get_rendererPriority_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rendererPriority;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_rendererPriority_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rendererPriority = value;

            return __ret;
        }

        static StackObject* get_rayTracingMode_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rayTracingMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_rayTracingMode_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Rendering.RayTracingMode @value = (UnityEngine.Experimental.Rendering.RayTracingMode)typeof(UnityEngine.Experimental.Rendering.RayTracingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rayTracingMode = value;

            return __ret;
        }

        static StackObject* get_sortingLayerName_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sortingLayerName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_sortingLayerName_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sortingLayerName = value;

            return __ret;
        }

        static StackObject* get_sortingLayerID_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sortingLayerID;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_sortingLayerID_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sortingLayerID = value;

            return __ret;
        }

        static StackObject* get_sortingOrder_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sortingOrder;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_sortingOrder_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sortingOrder = value;

            return __ret;
        }

        static StackObject* get_allowOcclusionWhenDynamic_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.allowOcclusionWhenDynamic;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_allowOcclusionWhenDynamic_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.allowOcclusionWhenDynamic = value;

            return __ret;
        }

        static StackObject* get_isPartOfStaticBatch_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isPartOfStaticBatch;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_worldToLocalMatrix_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.worldToLocalMatrix;

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Matrix4x4_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Matrix4x4_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* get_localToWorldMatrix_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.localToWorldMatrix;

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Matrix4x4_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Matrix4x4_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* get_lightProbeProxyVolumeOverride_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lightProbeProxyVolumeOverride;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_lightProbeProxyVolumeOverride_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @value = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lightProbeProxyVolumeOverride = value;

            return __ret;
        }

        static StackObject* get_probeAnchor_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.probeAnchor;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_probeAnchor_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @value = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.probeAnchor = value;

            return __ret;
        }

        static StackObject* get_lightmapIndex_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lightmapIndex;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_lightmapIndex_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lightmapIndex = value;

            return __ret;
        }

        static StackObject* get_realtimeLightmapIndex_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.realtimeLightmapIndex;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_realtimeLightmapIndex_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.realtimeLightmapIndex = value;

            return __ret;
        }

        static StackObject* get_lightmapScaleOffset_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lightmapScaleOffset;

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector4_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector4_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* set_lightmapScaleOffset_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4 @value = new UnityEngine.Vector4();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector4_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector4_Binding_Binder.ParseValue(ref @value, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @value = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lightmapScaleOffset = value;

            return __ret;
        }

        static StackObject* get_realtimeLightmapScaleOffset_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.realtimeLightmapScaleOffset;

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector4_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector4_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* set_realtimeLightmapScaleOffset_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4 @value = new UnityEngine.Vector4();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector4_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector4_Binding_Binder.ParseValue(ref @value, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @value = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.realtimeLightmapScaleOffset = value;

            return __ret;
        }

        static StackObject* get_materials_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.materials;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_materials_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material[] @value = (UnityEngine.Material[])typeof(UnityEngine.Material[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.materials = value;

            return __ret;
        }

        static StackObject* get_material_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.material;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_material_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material @value = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.material = value;

            return __ret;
        }

        static StackObject* get_sharedMaterial_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sharedMaterial;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_sharedMaterial_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material @value = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sharedMaterial = value;

            return __ret;
        }

        static StackObject* get_sharedMaterials_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sharedMaterials;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_sharedMaterials_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material[] @value = (UnityEngine.Material[])typeof(UnityEngine.Material[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sharedMaterials = value;

            return __ret;
        }

        static StackObject* GetMaterials_58(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Material> @m = (System.Collections.Generic.List<UnityEngine.Material>)typeof(System.Collections.Generic.List<UnityEngine.Material>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetMaterials(@m);

            return __ret;
        }

        static StackObject* GetSharedMaterials_59(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Material> @m = (System.Collections.Generic.List<UnityEngine.Material>)typeof(System.Collections.Generic.List<UnityEngine.Material>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetSharedMaterials(@m);

            return __ret;
        }

        static StackObject* GetClosestReflectionProbes_60(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo> @result = (System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo>)typeof(System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer instance_of_this_method = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetClosestReflectionProbes(@result);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Renderer();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
