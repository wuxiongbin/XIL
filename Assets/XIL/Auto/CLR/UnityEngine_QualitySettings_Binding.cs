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
    unsafe class UnityEngine_QualitySettings_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.QualitySettings);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("IncreaseLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IncreaseLevel_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("DecreaseLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DecreaseLevel_1);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("SetQualityLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetQualityLevel_2);
            args = new Type[]{};
            method = type.GetMethod("IncreaseLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IncreaseLevel_3);
            args = new Type[]{};
            method = type.GetMethod("DecreaseLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DecreaseLevel_4);
            args = new Type[]{};
            method = type.GetMethod("get_pixelLightCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pixelLightCount_5);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_pixelLightCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_pixelLightCount_6);
            args = new Type[]{};
            method = type.GetMethod("get_shadows", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadows_7);
            args = new Type[]{typeof(UnityEngine.ShadowQuality)};
            method = type.GetMethod("set_shadows", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadows_8);
            args = new Type[]{};
            method = type.GetMethod("get_shadowProjection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowProjection_9);
            args = new Type[]{typeof(UnityEngine.ShadowProjection)};
            method = type.GetMethod("set_shadowProjection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowProjection_10);
            args = new Type[]{};
            method = type.GetMethod("get_shadowCascades", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowCascades_11);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_shadowCascades", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowCascades_12);
            args = new Type[]{};
            method = type.GetMethod("get_shadowDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowDistance_13);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_shadowDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowDistance_14);
            args = new Type[]{};
            method = type.GetMethod("get_shadowResolution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowResolution_15);
            args = new Type[]{typeof(UnityEngine.ShadowResolution)};
            method = type.GetMethod("set_shadowResolution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowResolution_16);
            args = new Type[]{};
            method = type.GetMethod("get_shadowmaskMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowmaskMode_17);
            args = new Type[]{typeof(UnityEngine.ShadowmaskMode)};
            method = type.GetMethod("set_shadowmaskMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowmaskMode_18);
            args = new Type[]{};
            method = type.GetMethod("get_shadowNearPlaneOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowNearPlaneOffset_19);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_shadowNearPlaneOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowNearPlaneOffset_20);
            args = new Type[]{};
            method = type.GetMethod("get_shadowCascade2Split", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowCascade2Split_21);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_shadowCascade2Split", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowCascade2Split_22);
            args = new Type[]{};
            method = type.GetMethod("get_shadowCascade4Split", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowCascade4Split_23);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_shadowCascade4Split", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowCascade4Split_24);
            args = new Type[]{};
            method = type.GetMethod("get_lodBias", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lodBias_25);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_lodBias", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lodBias_26);
            args = new Type[]{};
            method = type.GetMethod("get_anisotropicFiltering", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_anisotropicFiltering_27);
            args = new Type[]{typeof(UnityEngine.AnisotropicFiltering)};
            method = type.GetMethod("set_anisotropicFiltering", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_anisotropicFiltering_28);
            args = new Type[]{};
            method = type.GetMethod("get_masterTextureLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_masterTextureLimit_29);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_masterTextureLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_masterTextureLimit_30);
            args = new Type[]{};
            method = type.GetMethod("get_maximumLODLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maximumLODLevel_31);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_maximumLODLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maximumLODLevel_32);
            args = new Type[]{};
            method = type.GetMethod("get_particleRaycastBudget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_particleRaycastBudget_33);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_particleRaycastBudget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_particleRaycastBudget_34);
            args = new Type[]{};
            method = type.GetMethod("get_softParticles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_softParticles_35);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_softParticles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_softParticles_36);
            args = new Type[]{};
            method = type.GetMethod("get_softVegetation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_softVegetation_37);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_softVegetation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_softVegetation_38);
            args = new Type[]{};
            method = type.GetMethod("get_vSyncCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_vSyncCount_39);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_vSyncCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_vSyncCount_40);
            args = new Type[]{};
            method = type.GetMethod("get_antiAliasing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_antiAliasing_41);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_antiAliasing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_antiAliasing_42);
            args = new Type[]{};
            method = type.GetMethod("get_asyncUploadTimeSlice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_asyncUploadTimeSlice_43);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_asyncUploadTimeSlice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_asyncUploadTimeSlice_44);
            args = new Type[]{};
            method = type.GetMethod("get_asyncUploadBufferSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_asyncUploadBufferSize_45);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_asyncUploadBufferSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_asyncUploadBufferSize_46);
            args = new Type[]{};
            method = type.GetMethod("get_asyncUploadPersistentBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_asyncUploadPersistentBuffer_47);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_asyncUploadPersistentBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_asyncUploadPersistentBuffer_48);
            args = new Type[]{};
            method = type.GetMethod("get_realtimeReflectionProbes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_realtimeReflectionProbes_49);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_realtimeReflectionProbes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_realtimeReflectionProbes_50);
            args = new Type[]{};
            method = type.GetMethod("get_billboardsFaceCameraPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_billboardsFaceCameraPosition_51);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_billboardsFaceCameraPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_billboardsFaceCameraPosition_52);
            args = new Type[]{};
            method = type.GetMethod("get_resolutionScalingFixedDPIFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_resolutionScalingFixedDPIFactor_53);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_resolutionScalingFixedDPIFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_resolutionScalingFixedDPIFactor_54);
            args = new Type[]{};
            method = type.GetMethod("get_renderPipeline", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_renderPipeline_55);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderPipelineAsset)};
            method = type.GetMethod("set_renderPipeline", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_renderPipeline_56);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetRenderPipelineAssetAt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRenderPipelineAssetAt_57);
            args = new Type[]{};
            method = type.GetMethod("get_skinWeights", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_skinWeights_58);
            args = new Type[]{typeof(UnityEngine.SkinWeights)};
            method = type.GetMethod("set_skinWeights", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_skinWeights_59);
            args = new Type[]{};
            method = type.GetMethod("get_streamingMipmapsActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_streamingMipmapsActive_60);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_streamingMipmapsActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_streamingMipmapsActive_61);
            args = new Type[]{};
            method = type.GetMethod("get_streamingMipmapsMemoryBudget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_streamingMipmapsMemoryBudget_62);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_streamingMipmapsMemoryBudget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_streamingMipmapsMemoryBudget_63);
            args = new Type[]{};
            method = type.GetMethod("get_streamingMipmapsMaxLevelReduction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_streamingMipmapsMaxLevelReduction_64);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_streamingMipmapsMaxLevelReduction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_streamingMipmapsMaxLevelReduction_65);
            args = new Type[]{};
            method = type.GetMethod("get_streamingMipmapsAddAllCameras", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_streamingMipmapsAddAllCameras_66);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_streamingMipmapsAddAllCameras", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_streamingMipmapsAddAllCameras_67);
            args = new Type[]{};
            method = type.GetMethod("get_streamingMipmapsMaxFileIORequests", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_streamingMipmapsMaxFileIORequests_68);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_streamingMipmapsMaxFileIORequests", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_streamingMipmapsMaxFileIORequests_69);
            args = new Type[]{};
            method = type.GetMethod("get_maxQueuedFrames", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxQueuedFrames_70);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_maxQueuedFrames", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxQueuedFrames_71);
            args = new Type[]{};
            method = type.GetMethod("GetQualityLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetQualityLevel_72);
            args = new Type[]{typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("SetQualityLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetQualityLevel_73);
            args = new Type[]{};
            method = type.GetMethod("get_names", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_names_74);
            args = new Type[]{};
            method = type.GetMethod("get_desiredColorSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_desiredColorSpace_75);
            args = new Type[]{};
            method = type.GetMethod("get_activeColorSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activeColorSpace_76);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.QualitySettings[s]);


        }


        static StackObject* IncreaseLevel_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @applyExpensiveChanges = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.IncreaseLevel(@applyExpensiveChanges);

            return __ret;
        }

        static StackObject* DecreaseLevel_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @applyExpensiveChanges = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.DecreaseLevel(@applyExpensiveChanges);

            return __ret;
        }

        static StackObject* SetQualityLevel_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.SetQualityLevel(@index);

            return __ret;
        }

        static StackObject* IncreaseLevel_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.QualitySettings.IncreaseLevel();

            return __ret;
        }

        static StackObject* DecreaseLevel_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.QualitySettings.DecreaseLevel();

            return __ret;
        }

        static StackObject* get_pixelLightCount_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.pixelLightCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_pixelLightCount_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.pixelLightCount = value;

            return __ret;
        }

        static StackObject* get_shadows_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadows;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_shadows_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ShadowQuality @value = (UnityEngine.ShadowQuality)typeof(UnityEngine.ShadowQuality).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.shadows = value;

            return __ret;
        }

        static StackObject* get_shadowProjection_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowProjection;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_shadowProjection_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ShadowProjection @value = (UnityEngine.ShadowProjection)typeof(UnityEngine.ShadowProjection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.shadowProjection = value;

            return __ret;
        }

        static StackObject* get_shadowCascades_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowCascades;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_shadowCascades_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.shadowCascades = value;

            return __ret;
        }

        static StackObject* get_shadowDistance_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_shadowDistance_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.shadowDistance = value;

            return __ret;
        }

        static StackObject* get_shadowResolution_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowResolution;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_shadowResolution_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ShadowResolution @value = (UnityEngine.ShadowResolution)typeof(UnityEngine.ShadowResolution).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.shadowResolution = value;

            return __ret;
        }

        static StackObject* get_shadowmaskMode_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowmaskMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_shadowmaskMode_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ShadowmaskMode @value = (UnityEngine.ShadowmaskMode)typeof(UnityEngine.ShadowmaskMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.shadowmaskMode = value;

            return __ret;
        }

        static StackObject* get_shadowNearPlaneOffset_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowNearPlaneOffset;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_shadowNearPlaneOffset_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.shadowNearPlaneOffset = value;

            return __ret;
        }

        static StackObject* get_shadowCascade2Split_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowCascade2Split;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_shadowCascade2Split_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.shadowCascade2Split = value;

            return __ret;
        }

        static StackObject* get_shadowCascade4Split_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowCascade4Split;

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* set_shadowCascade4Split_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = new UnityEngine.Vector3();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @value, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }


            UnityEngine.QualitySettings.shadowCascade4Split = value;

            return __ret;
        }

        static StackObject* get_lodBias_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.lodBias;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_lodBias_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.lodBias = value;

            return __ret;
        }

        static StackObject* get_anisotropicFiltering_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.anisotropicFiltering;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_anisotropicFiltering_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnisotropicFiltering @value = (UnityEngine.AnisotropicFiltering)typeof(UnityEngine.AnisotropicFiltering).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.anisotropicFiltering = value;

            return __ret;
        }

        static StackObject* get_masterTextureLimit_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.masterTextureLimit;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_masterTextureLimit_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.masterTextureLimit = value;

            return __ret;
        }

        static StackObject* get_maximumLODLevel_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.maximumLODLevel;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maximumLODLevel_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.maximumLODLevel = value;

            return __ret;
        }

        static StackObject* get_particleRaycastBudget_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.particleRaycastBudget;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_particleRaycastBudget_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.particleRaycastBudget = value;

            return __ret;
        }

        static StackObject* get_softParticles_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.softParticles;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_softParticles_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.softParticles = value;

            return __ret;
        }

        static StackObject* get_softVegetation_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.softVegetation;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_softVegetation_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.softVegetation = value;

            return __ret;
        }

        static StackObject* get_vSyncCount_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.vSyncCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_vSyncCount_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.vSyncCount = value;

            return __ret;
        }

        static StackObject* get_antiAliasing_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.antiAliasing;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_antiAliasing_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.antiAliasing = value;

            return __ret;
        }

        static StackObject* get_asyncUploadTimeSlice_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.asyncUploadTimeSlice;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_asyncUploadTimeSlice_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.asyncUploadTimeSlice = value;

            return __ret;
        }

        static StackObject* get_asyncUploadBufferSize_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.asyncUploadBufferSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_asyncUploadBufferSize_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.asyncUploadBufferSize = value;

            return __ret;
        }

        static StackObject* get_asyncUploadPersistentBuffer_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.asyncUploadPersistentBuffer;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_asyncUploadPersistentBuffer_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.asyncUploadPersistentBuffer = value;

            return __ret;
        }

        static StackObject* get_realtimeReflectionProbes_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.realtimeReflectionProbes;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_realtimeReflectionProbes_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.realtimeReflectionProbes = value;

            return __ret;
        }

        static StackObject* get_billboardsFaceCameraPosition_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.billboardsFaceCameraPosition;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_billboardsFaceCameraPosition_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.billboardsFaceCameraPosition = value;

            return __ret;
        }

        static StackObject* get_resolutionScalingFixedDPIFactor_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.resolutionScalingFixedDPIFactor;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_resolutionScalingFixedDPIFactor_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.resolutionScalingFixedDPIFactor = value;

            return __ret;
        }

        static StackObject* get_renderPipeline_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.renderPipeline;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_renderPipeline_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.RenderPipelineAsset @value = (UnityEngine.Rendering.RenderPipelineAsset)typeof(UnityEngine.Rendering.RenderPipelineAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.renderPipeline = value;

            return __ret;
        }

        static StackObject* GetRenderPipelineAssetAt_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.QualitySettings.GetRenderPipelineAssetAt(@index);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_skinWeights_58(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.skinWeights;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_skinWeights_59(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SkinWeights @value = (UnityEngine.SkinWeights)typeof(UnityEngine.SkinWeights).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.skinWeights = value;

            return __ret;
        }

        static StackObject* get_streamingMipmapsActive_60(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.streamingMipmapsActive;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_streamingMipmapsActive_61(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.streamingMipmapsActive = value;

            return __ret;
        }

        static StackObject* get_streamingMipmapsMemoryBudget_62(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.streamingMipmapsMemoryBudget;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_streamingMipmapsMemoryBudget_63(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.streamingMipmapsMemoryBudget = value;

            return __ret;
        }

        static StackObject* get_streamingMipmapsMaxLevelReduction_64(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.streamingMipmapsMaxLevelReduction;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_streamingMipmapsMaxLevelReduction_65(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.streamingMipmapsMaxLevelReduction = value;

            return __ret;
        }

        static StackObject* get_streamingMipmapsAddAllCameras_66(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.streamingMipmapsAddAllCameras;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_streamingMipmapsAddAllCameras_67(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.streamingMipmapsAddAllCameras = value;

            return __ret;
        }

        static StackObject* get_streamingMipmapsMaxFileIORequests_68(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.streamingMipmapsMaxFileIORequests;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_streamingMipmapsMaxFileIORequests_69(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.streamingMipmapsMaxFileIORequests = value;

            return __ret;
        }

        static StackObject* get_maxQueuedFrames_70(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.maxQueuedFrames;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxQueuedFrames_71(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.maxQueuedFrames = value;

            return __ret;
        }

        static StackObject* GetQualityLevel_72(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.GetQualityLevel();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetQualityLevel_73(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @applyExpensiveChanges = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @index = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.SetQualityLevel(@index, @applyExpensiveChanges);

            return __ret;
        }

        static StackObject* get_names_74(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.names;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_desiredColorSpace_75(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.desiredColorSpace;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_activeColorSpace_76(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.activeColorSpace;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}
#endif
