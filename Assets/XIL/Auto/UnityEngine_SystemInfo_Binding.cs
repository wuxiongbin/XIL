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
            Type[] args;
            Type type = typeof(UnityEngine.SystemInfo);
            args = new Type[]{};
            method = type.GetMethod("get_operatingSystem", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_operatingSystem_0);
            args = new Type[]{};
            method = type.GetMethod("get_processorType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_processorType_1);
            args = new Type[]{};
            method = type.GetMethod("get_processorCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_processorCount_2);
            args = new Type[]{};
            method = type.GetMethod("get_systemMemorySize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_systemMemorySize_3);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsMemorySize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsMemorySize_4);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsDeviceName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsDeviceName_5);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsDeviceVendor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsDeviceVendor_6);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsDeviceID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsDeviceID_7);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsDeviceVendorID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsDeviceVendorID_8);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsDeviceVersion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsDeviceVersion_9);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsShaderLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsShaderLevel_10);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsPixelFillrate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsPixelFillrate_11);
            args = new Type[]{};
            method = type.GetMethod("get_supportsShadows", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsShadows_12);
            args = new Type[]{};
            method = type.GetMethod("get_supportsRenderTextures", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsRenderTextures_13);
            args = new Type[]{};
            method = type.GetMethod("get_supportsRenderToCubemap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsRenderToCubemap_14);
            args = new Type[]{};
            method = type.GetMethod("get_supportsImageEffects", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsImageEffects_15);
            args = new Type[]{};
            method = type.GetMethod("get_supports3DTextures", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supports3DTextures_16);
            args = new Type[]{};
            method = type.GetMethod("get_supportsComputeShaders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsComputeShaders_17);
            args = new Type[]{};
            method = type.GetMethod("get_supportsInstancing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsInstancing_18);
            args = new Type[]{};
            method = type.GetMethod("get_supportsSparseTextures", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsSparseTextures_19);
            args = new Type[]{};
            method = type.GetMethod("get_supportedRenderTargetCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportedRenderTargetCount_20);
            args = new Type[]{};
            method = type.GetMethod("get_supportsStencil", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsStencil_21);
            args = new Type[]{};
            method = type.GetMethod("get_supportsVertexPrograms", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsVertexPrograms_22);
            args = new Type[]{typeof(UnityEngine.RenderTextureFormat)};
            method = type.GetMethod("SupportsRenderTextureFormat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SupportsRenderTextureFormat_23);
            args = new Type[]{};
            method = type.GetMethod("get_npotSupport", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_npotSupport_24);
            args = new Type[]{};
            method = type.GetMethod("get_deviceUniqueIdentifier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_deviceUniqueIdentifier_25);
            args = new Type[]{};
            method = type.GetMethod("get_deviceName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_deviceName_26);
            args = new Type[]{};
            method = type.GetMethod("get_deviceModel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_deviceModel_27);
            args = new Type[]{};
            method = type.GetMethod("get_supportsAccelerometer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsAccelerometer_28);
            args = new Type[]{};
            method = type.GetMethod("get_supportsGyroscope", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsGyroscope_29);
            args = new Type[]{};
            method = type.GetMethod("get_supportsLocationService", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsLocationService_30);
            args = new Type[]{};
            method = type.GetMethod("get_supportsVibration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportsVibration_31);
            args = new Type[]{};
            method = type.GetMethod("get_deviceType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_deviceType_32);
            args = new Type[]{};
            method = type.GetMethod("get_maxTextureSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxTextureSize_33);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.SystemInfo());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SystemInfo[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_operatingSystem_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.operatingSystem;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_processorType_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.processorType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_processorCount_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.processorCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_systemMemorySize_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.systemMemorySize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_graphicsMemorySize_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsMemorySize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_graphicsDeviceName_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsDeviceName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_graphicsDeviceVendor_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsDeviceVendor;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_graphicsDeviceID_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsDeviceID;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_graphicsDeviceVendorID_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsDeviceVendorID;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_graphicsDeviceVersion_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsDeviceVersion;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_graphicsShaderLevel_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsShaderLevel;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_graphicsPixelFillrate_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.graphicsPixelFillrate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_supportsShadows_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsShadows;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsRenderTextures_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsRenderTextures;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsRenderToCubemap_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsRenderToCubemap;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsImageEffects_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsImageEffects;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supports3DTextures_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supports3DTextures;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsComputeShaders_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsComputeShaders;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsInstancing_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsInstancing;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsSparseTextures_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsSparseTextures;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportedRenderTargetCount_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportedRenderTargetCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_supportsStencil_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsStencil;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_supportsVertexPrograms_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsVertexPrograms;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SupportsRenderTextureFormat_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
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

        static StackObject* get_npotSupport_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.npotSupport;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_deviceUniqueIdentifier_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.deviceUniqueIdentifier;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_deviceName_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.deviceName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_deviceModel_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.deviceModel;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_supportsAccelerometer_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsAccelerometer;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsGyroscope_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsGyroscope;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsLocationService_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsLocationService;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_supportsVibration_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.supportsVibration;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_deviceType_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.deviceType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_maxTextureSize_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SystemInfo.maxTextureSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
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
