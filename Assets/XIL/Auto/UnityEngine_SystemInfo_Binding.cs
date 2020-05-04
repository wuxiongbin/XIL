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
    unsafe class UnityEngine_SystemInfo_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.SystemInfo);
            args = new Type[]{};
            method = type.GetMethod("get_batteryLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_batteryLevel_0);
            args = new Type[]{};
            method = type.GetMethod("get_batteryStatus", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_batteryStatus_1);
            args = new Type[]{};
            method = type.GetMethod("get_operatingSystem", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_operatingSystem_2);
            args = new Type[]{};
            method = type.GetMethod("get_operatingSystemFamily", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_operatingSystemFamily_3);
            args = new Type[]{};
            method = type.GetMethod("get_processorType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_processorType_4);
            args = new Type[]{};
            method = type.GetMethod("get_processorFrequency", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_processorFrequency_5);
            args = new Type[]{};
            method = type.GetMethod("get_processorCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_processorCount_6);
            args = new Type[]{};
            method = type.GetMethod("get_systemMemorySize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_systemMemorySize_7);
            args = new Type[]{};
            method = type.GetMethod("get_deviceUniqueIdentifier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_deviceUniqueIdentifier_8);
            args = new Type[]{};
            method = type.GetMethod("get_deviceName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_deviceName_9);
            args = new Type[]{};
            method = type.GetMethod("get_deviceModel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_deviceModel_10);
            args = new Type[]{};
            method = type.GetMethod("get_supportsAccelerometer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsAccelerometer_11);
            args = new Type[]{};
            method = type.GetMethod("get_supportsGyroscope", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsGyroscope_12);
            args = new Type[]{};
            method = type.GetMethod("get_supportsLocationService", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsLocationService_13);
            args = new Type[]{};
            method = type.GetMethod("get_supportsVibration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsVibration_14);
            args = new Type[]{};
            method = type.GetMethod("get_supportsAudio", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsAudio_15);
            args = new Type[]{};
            method = type.GetMethod("get_deviceType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_deviceType_16);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsMemorySize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsMemorySize_17);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsDeviceName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsDeviceName_18);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsDeviceVendor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsDeviceVendor_19);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsDeviceID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsDeviceID_20);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsDeviceVendorID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsDeviceVendorID_21);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsDeviceType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsDeviceType_22);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsUVStartsAtTop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsUVStartsAtTop_23);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsDeviceVersion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsDeviceVersion_24);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsShaderLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsShaderLevel_25);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsMultiThreaded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsMultiThreaded_26);
            args = new Type[]{};
            method = type.GetMethod("get_renderingThreadingMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_renderingThreadingMode_27);
            args = new Type[]{};
            method = type.GetMethod("get_hasHiddenSurfaceRemovalOnGPU", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasHiddenSurfaceRemovalOnGPU_28);
            args = new Type[]{};
            method = type.GetMethod("get_hasDynamicUniformArrayIndexingInFragmentShaders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasDynamicUniformArrayIndexingInFragmentShaders_29);
            args = new Type[]{};
            method = type.GetMethod("get_supportsShadows", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsShadows_30);
            args = new Type[]{};
            method = type.GetMethod("get_supportsRawShadowDepthSampling", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsRawShadowDepthSampling_31);
            args = new Type[]{};
            method = type.GetMethod("get_supportsMotionVectors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsMotionVectors_32);
            args = new Type[]{};
            method = type.GetMethod("get_supports3DTextures", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supports3DTextures_33);
            args = new Type[]{};
            method = type.GetMethod("get_supports2DArrayTextures", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supports2DArrayTextures_34);
            args = new Type[]{};
            method = type.GetMethod("get_supports3DRenderTextures", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supports3DRenderTextures_35);
            args = new Type[]{};
            method = type.GetMethod("get_supportsCubemapArrayTextures", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsCubemapArrayTextures_36);
            args = new Type[]{};
            method = type.GetMethod("get_copyTextureSupport", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_copyTextureSupport_37);
            args = new Type[]{};
            method = type.GetMethod("get_supportsComputeShaders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsComputeShaders_38);
            args = new Type[]{};
            method = type.GetMethod("get_supportsGeometryShaders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsGeometryShaders_39);
            args = new Type[]{};
            method = type.GetMethod("get_supportsTessellationShaders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsTessellationShaders_40);
            args = new Type[]{};
            method = type.GetMethod("get_supportsInstancing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsInstancing_41);
            args = new Type[]{};
            method = type.GetMethod("get_supportsHardwareQuadTopology", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsHardwareQuadTopology_42);
            args = new Type[]{};
            method = type.GetMethod("get_supports32bitsIndexBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supports32bitsIndexBuffer_43);
            args = new Type[]{};
            method = type.GetMethod("get_supportsSparseTextures", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsSparseTextures_44);
            args = new Type[]{};
            method = type.GetMethod("get_supportedRenderTargetCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportedRenderTargetCount_45);
            args = new Type[]{};
            method = type.GetMethod("get_supportsSeparatedRenderTargetsBlend", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsSeparatedRenderTargetsBlend_46);
            args = new Type[]{};
            method = type.GetMethod("get_supportedRandomWriteTargetCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportedRandomWriteTargetCount_47);
            args = new Type[]{};
            method = type.GetMethod("get_supportsMultisampledTextures", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsMultisampledTextures_48);
            args = new Type[]{};
            method = type.GetMethod("get_supportsMultisampleAutoResolve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsMultisampleAutoResolve_49);
            args = new Type[]{};
            method = type.GetMethod("get_supportsTextureWrapMirrorOnce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsTextureWrapMirrorOnce_50);
            args = new Type[]{};
            method = type.GetMethod("get_usesReversedZBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_usesReversedZBuffer_51);
            args = new Type[]{typeof(UnityEngine.RenderTextureFormat)};
            method = type.GetMethod("SupportsRenderTextureFormat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SupportsRenderTextureFormat_52);
            args = new Type[]{typeof(UnityEngine.RenderTextureFormat)};
            method = type.GetMethod("SupportsBlendingOnRenderTextureFormat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SupportsBlendingOnRenderTextureFormat_53);
            args = new Type[]{typeof(UnityEngine.TextureFormat)};
            method = type.GetMethod("SupportsTextureFormat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SupportsTextureFormat_54);
            args = new Type[]{typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32)};
            method = type.GetMethod("SupportsVertexAttributeFormat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SupportsVertexAttributeFormat_55);
            args = new Type[]{};
            method = type.GetMethod("get_npotSupport", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_npotSupport_56);
            args = new Type[]{};
            method = type.GetMethod("get_maxTextureSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxTextureSize_57);
            args = new Type[]{};
            method = type.GetMethod("get_maxCubemapSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxCubemapSize_58);
            args = new Type[]{};
            method = type.GetMethod("get_maxComputeBufferInputsVertex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxComputeBufferInputsVertex_59);
            args = new Type[]{};
            method = type.GetMethod("get_maxComputeBufferInputsFragment", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxComputeBufferInputsFragment_60);
            args = new Type[]{};
            method = type.GetMethod("get_maxComputeBufferInputsGeometry", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxComputeBufferInputsGeometry_61);
            args = new Type[]{};
            method = type.GetMethod("get_maxComputeBufferInputsDomain", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxComputeBufferInputsDomain_62);
            args = new Type[]{};
            method = type.GetMethod("get_maxComputeBufferInputsHull", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxComputeBufferInputsHull_63);
            args = new Type[]{};
            method = type.GetMethod("get_maxComputeBufferInputsCompute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxComputeBufferInputsCompute_64);
            args = new Type[]{};
            method = type.GetMethod("get_maxComputeWorkGroupSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxComputeWorkGroupSize_65);
            args = new Type[]{};
            method = type.GetMethod("get_maxComputeWorkGroupSizeX", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxComputeWorkGroupSizeX_66);
            args = new Type[]{};
            method = type.GetMethod("get_maxComputeWorkGroupSizeY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxComputeWorkGroupSizeY_67);
            args = new Type[]{};
            method = type.GetMethod("get_maxComputeWorkGroupSizeZ", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxComputeWorkGroupSizeZ_68);
            args = new Type[]{};
            method = type.GetMethod("get_supportsAsyncCompute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsAsyncCompute_69);
            args = new Type[]{};
            method = type.GetMethod("get_supportsGraphicsFence", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsGraphicsFence_70);
            args = new Type[]{};
            method = type.GetMethod("get_supportsAsyncGPUReadback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsAsyncGPUReadback_71);
            args = new Type[]{};
            method = type.GetMethod("get_supportsRayTracing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsRayTracing_72);
            args = new Type[]{};
            method = type.GetMethod("get_supportsSetConstantBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsSetConstantBuffer_73);
            args = new Type[]{};
            method = type.GetMethod("get_minConstantBufferOffsetAlignment", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_minConstantBufferOffsetAlignment_74);
            args = new Type[]{};
            method = type.GetMethod("get_hasMipMaxLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasMipMaxLevel_75);
            args = new Type[]{};
            method = type.GetMethod("get_supportsMipStreaming", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsMipStreaming_76);
            args = new Type[]{};
            method = type.GetMethod("get_usesLoadStoreActions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_usesLoadStoreActions_77);
            args = new Type[]{typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(UnityEngine.Experimental.Rendering.FormatUsage)};
            method = type.GetMethod("IsFormatSupported", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsFormatSupported_78);
            args = new Type[]{typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(UnityEngine.Experimental.Rendering.FormatUsage)};
            method = type.GetMethod("GetCompatibleFormat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCompatibleFormat_79);
            args = new Type[]{typeof(UnityEngine.Experimental.Rendering.DefaultFormat)};
            method = type.GetMethod("GetGraphicsFormat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGraphicsFormat_80);

            field = type.GetField("unsupportedIdentifier", flag);
            app.RegisterCLRFieldGetter(field, get_unsupportedIdentifier_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_unsupportedIdentifier_0, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.SystemInfo());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SystemInfo[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_batteryLevel_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.batteryLevel;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_batteryStatus_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.batteryStatus;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_operatingSystem_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.operatingSystem;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_operatingSystemFamily_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.operatingSystemFamily;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_processorType_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.processorType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_processorFrequency_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.processorFrequency;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_processorCount_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.processorCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_systemMemorySize_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.systemMemorySize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_deviceUniqueIdentifier_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.deviceUniqueIdentifier;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_deviceName_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.deviceName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_deviceModel_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.deviceModel;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_supportsAccelerometer_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsAccelerometer;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsGyroscope_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsGyroscope;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsLocationService_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsLocationService;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsVibration_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsVibration;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsAudio_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsAudio;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_deviceType_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.deviceType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_graphicsMemorySize_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsMemorySize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_graphicsDeviceName_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsDeviceName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_graphicsDeviceVendor_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsDeviceVendor;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_graphicsDeviceID_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsDeviceID;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_graphicsDeviceVendorID_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsDeviceVendorID;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_graphicsDeviceType_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsDeviceType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_graphicsUVStartsAtTop_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsUVStartsAtTop;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_graphicsDeviceVersion_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsDeviceVersion;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_graphicsShaderLevel_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsShaderLevel;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_graphicsMultiThreaded_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsMultiThreaded;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_renderingThreadingMode_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.renderingThreadingMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_hasHiddenSurfaceRemovalOnGPU_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.hasHiddenSurfaceRemovalOnGPU;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_hasDynamicUniformArrayIndexingInFragmentShaders_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.hasDynamicUniformArrayIndexingInFragmentShaders;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsShadows_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsShadows;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsRawShadowDepthSampling_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsRawShadowDepthSampling;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsMotionVectors_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsMotionVectors;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supports3DTextures_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supports3DTextures;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supports2DArrayTextures_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supports2DArrayTextures;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supports3DRenderTextures_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supports3DRenderTextures;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsCubemapArrayTextures_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsCubemapArrayTextures;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_copyTextureSupport_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.copyTextureSupport;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_supportsComputeShaders_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsComputeShaders;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsGeometryShaders_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsGeometryShaders;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsTessellationShaders_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsTessellationShaders;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsInstancing_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsInstancing;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsHardwareQuadTopology_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsHardwareQuadTopology;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supports32bitsIndexBuffer_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supports32bitsIndexBuffer;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsSparseTextures_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsSparseTextures;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportedRenderTargetCount_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportedRenderTargetCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_supportsSeparatedRenderTargetsBlend_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsSeparatedRenderTargetsBlend;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportedRandomWriteTargetCount_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportedRandomWriteTargetCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_supportsMultisampledTextures_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsMultisampledTextures;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_supportsMultisampleAutoResolve_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsMultisampleAutoResolve;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsTextureWrapMirrorOnce_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsTextureWrapMirrorOnce;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_usesReversedZBuffer_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.usesReversedZBuffer;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SupportsRenderTextureFormat_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderTextureFormat @format = (UnityEngine.RenderTextureFormat)typeof(UnityEngine.RenderTextureFormat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.SystemInfo.SupportsRenderTextureFormat(@format);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SupportsBlendingOnRenderTextureFormat_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderTextureFormat @format = (UnityEngine.RenderTextureFormat)typeof(UnityEngine.RenderTextureFormat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.SystemInfo.SupportsBlendingOnRenderTextureFormat(@format);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SupportsTextureFormat_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextureFormat @format = (UnityEngine.TextureFormat)typeof(UnityEngine.TextureFormat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.SystemInfo.SupportsTextureFormat(@format);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SupportsVertexAttributeFormat_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @dimension = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.VertexAttributeFormat @format = (UnityEngine.Rendering.VertexAttributeFormat)typeof(UnityEngine.Rendering.VertexAttributeFormat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.SystemInfo.SupportsVertexAttributeFormat(@format, @dimension);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_npotSupport_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.npotSupport;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_maxTextureSize_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.maxTextureSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_maxCubemapSize_58(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.maxCubemapSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_maxComputeBufferInputsVertex_59(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.maxComputeBufferInputsVertex;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_maxComputeBufferInputsFragment_60(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.maxComputeBufferInputsFragment;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_maxComputeBufferInputsGeometry_61(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.maxComputeBufferInputsGeometry;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_maxComputeBufferInputsDomain_62(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.maxComputeBufferInputsDomain;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_maxComputeBufferInputsHull_63(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.maxComputeBufferInputsHull;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_maxComputeBufferInputsCompute_64(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.maxComputeBufferInputsCompute;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_maxComputeWorkGroupSize_65(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.maxComputeWorkGroupSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_maxComputeWorkGroupSizeX_66(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.maxComputeWorkGroupSizeX;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_maxComputeWorkGroupSizeY_67(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.maxComputeWorkGroupSizeY;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_maxComputeWorkGroupSizeZ_68(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.maxComputeWorkGroupSizeZ;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_supportsAsyncCompute_69(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsAsyncCompute;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsGraphicsFence_70(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsGraphicsFence;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsAsyncGPUReadback_71(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsAsyncGPUReadback;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsRayTracing_72(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsRayTracing;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsSetConstantBuffer_73(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsSetConstantBuffer;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_minConstantBufferOffsetAlignment_74(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.minConstantBufferOffsetAlignment;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_hasMipMaxLevel_75(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.hasMipMaxLevel;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsMipStreaming_76(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsMipStreaming;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_usesLoadStoreActions_77(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.usesLoadStoreActions;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsFormatSupported_78(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Rendering.FormatUsage @usage = (UnityEngine.Experimental.Rendering.FormatUsage)typeof(UnityEngine.Experimental.Rendering.FormatUsage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Rendering.GraphicsFormat @format = (UnityEngine.Experimental.Rendering.GraphicsFormat)typeof(UnityEngine.Experimental.Rendering.GraphicsFormat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.SystemInfo.IsFormatSupported(@format, @usage);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetCompatibleFormat_79(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Rendering.FormatUsage @usage = (UnityEngine.Experimental.Rendering.FormatUsage)typeof(UnityEngine.Experimental.Rendering.FormatUsage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Rendering.GraphicsFormat @format = (UnityEngine.Experimental.Rendering.GraphicsFormat)typeof(UnityEngine.Experimental.Rendering.GraphicsFormat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.SystemInfo.GetCompatibleFormat(@format, @usage);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGraphicsFormat_80(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Rendering.DefaultFormat @format = (UnityEngine.Experimental.Rendering.DefaultFormat)typeof(UnityEngine.Experimental.Rendering.DefaultFormat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.SystemInfo.GetGraphicsFormat(@format);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_unsupportedIdentifier_0(ref object o)
        {
            return UnityEngine.SystemInfo.unsupportedIdentifier;
        }

        static StackObject* CopyToStack_unsupportedIdentifier_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = UnityEngine.SystemInfo.unsupportedIdentifier;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.SystemInfo();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
