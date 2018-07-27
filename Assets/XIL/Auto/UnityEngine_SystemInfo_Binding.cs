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
            method = type.GetMethod("get_supportsShadows", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsShadows_27);
            args = new Type[]{};
            method = type.GetMethod("get_supportsRawShadowDepthSampling", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsRawShadowDepthSampling_28);
            args = new Type[]{};
            method = type.GetMethod("get_supportsMotionVectors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsMotionVectors_29);
            args = new Type[]{};
            method = type.GetMethod("get_supportsRenderToCubemap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsRenderToCubemap_30);
            args = new Type[]{};
            method = type.GetMethod("get_supportsImageEffects", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsImageEffects_31);
            args = new Type[]{};
            method = type.GetMethod("get_supports3DTextures", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supports3DTextures_32);
            args = new Type[]{};
            method = type.GetMethod("get_supports2DArrayTextures", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supports2DArrayTextures_33);
            args = new Type[]{};
            method = type.GetMethod("get_supports3DRenderTextures", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supports3DRenderTextures_34);
            args = new Type[]{};
            method = type.GetMethod("get_supportsCubemapArrayTextures", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsCubemapArrayTextures_35);
            args = new Type[]{};
            method = type.GetMethod("get_copyTextureSupport", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_copyTextureSupport_36);
            args = new Type[]{};
            method = type.GetMethod("get_supportsComputeShaders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsComputeShaders_37);
            args = new Type[]{};
            method = type.GetMethod("get_supportsInstancing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsInstancing_38);
            args = new Type[]{};
            method = type.GetMethod("get_supportsHardwareQuadTopology", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsHardwareQuadTopology_39);
            args = new Type[]{};
            method = type.GetMethod("get_supports32bitsIndexBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supports32bitsIndexBuffer_40);
            args = new Type[]{};
            method = type.GetMethod("get_supportsSparseTextures", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsSparseTextures_41);
            args = new Type[]{};
            method = type.GetMethod("get_supportedRenderTargetCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportedRenderTargetCount_42);
            args = new Type[]{};
            method = type.GetMethod("get_supportsMultisampledTextures", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsMultisampledTextures_43);
            args = new Type[]{};
            method = type.GetMethod("get_supportsMultisampleAutoResolve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsMultisampleAutoResolve_44);
            args = new Type[]{};
            method = type.GetMethod("get_supportsTextureWrapMirrorOnce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsTextureWrapMirrorOnce_45);
            args = new Type[]{};
            method = type.GetMethod("get_usesReversedZBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_usesReversedZBuffer_46);
            args = new Type[]{typeof(UnityEngine.RenderTextureFormat)};
            method = type.GetMethod("SupportsRenderTextureFormat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SupportsRenderTextureFormat_47);
            args = new Type[]{typeof(UnityEngine.RenderTextureFormat)};
            method = type.GetMethod("SupportsBlendingOnRenderTextureFormat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SupportsBlendingOnRenderTextureFormat_48);
            args = new Type[]{typeof(UnityEngine.TextureFormat)};
            method = type.GetMethod("SupportsTextureFormat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SupportsTextureFormat_49);
            args = new Type[]{};
            method = type.GetMethod("get_npotSupport", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_npotSupport_50);
            args = new Type[]{};
            method = type.GetMethod("get_maxTextureSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxTextureSize_51);
            args = new Type[]{};
            method = type.GetMethod("get_maxCubemapSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxCubemapSize_52);
            args = new Type[]{};
            method = type.GetMethod("get_supportsAsyncCompute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsAsyncCompute_53);
            args = new Type[]{};
            method = type.GetMethod("get_supportsGPUFence", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsGPUFence_54);
            args = new Type[]{};
            method = type.GetMethod("get_supportsAsyncGPUReadback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsAsyncGPUReadback_55);
            args = new Type[]{};
            method = type.GetMethod("get_supportsMipStreaming", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsMipStreaming_56);
            args = new Type[]{typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(UnityEngine.Experimental.Rendering.FormatUsage)};
            method = type.GetMethod("IsFormatSupported", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsFormatSupported_57);

            field = type.GetField("unsupportedIdentifier", flag);
            app.RegisterCLRFieldGetter(field, get_unsupportedIdentifier_0);


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

        static StackObject* get_supportsShadows_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsShadows;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsRawShadowDepthSampling_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsRawShadowDepthSampling;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsMotionVectors_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsMotionVectors;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsRenderToCubemap_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsRenderToCubemap;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsImageEffects_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsImageEffects;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supports3DTextures_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supports3DTextures;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supports2DArrayTextures_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supports2DArrayTextures;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supports3DRenderTextures_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supports3DRenderTextures;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsCubemapArrayTextures_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsCubemapArrayTextures;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_copyTextureSupport_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.copyTextureSupport;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_supportsComputeShaders_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsComputeShaders;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsInstancing_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsInstancing;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsHardwareQuadTopology_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsHardwareQuadTopology;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supports32bitsIndexBuffer_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supports32bitsIndexBuffer;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsSparseTextures_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsSparseTextures;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportedRenderTargetCount_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportedRenderTargetCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_supportsMultisampledTextures_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsMultisampledTextures;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_supportsMultisampleAutoResolve_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsMultisampleAutoResolve;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsTextureWrapMirrorOnce_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsTextureWrapMirrorOnce;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_usesReversedZBuffer_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.usesReversedZBuffer;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SupportsRenderTextureFormat_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
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

        static StackObject* SupportsBlendingOnRenderTextureFormat_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
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

        static StackObject* SupportsTextureFormat_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
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

        static StackObject* get_npotSupport_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.npotSupport;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_maxTextureSize_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.maxTextureSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_maxCubemapSize_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.maxCubemapSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_supportsAsyncCompute_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsAsyncCompute;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsGPUFence_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsGPUFence;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsAsyncGPUReadback_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsAsyncGPUReadback;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsMipStreaming_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsMipStreaming;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsFormatSupported_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
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


        static object get_unsupportedIdentifier_0(ref object o)
        {
            return UnityEngine.SystemInfo.unsupportedIdentifier;
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
