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
    unsafe class UnityEngine_Application_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Application);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("Quit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Quit_0);
            args = new Type[]{};
            method = type.GetMethod("Quit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Quit_1);
            args = new Type[]{};
            method = type.GetMethod("Unload", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Unload_2);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("CanStreamedLevelBeLoaded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CanStreamedLevelBeLoaded_3);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("CanStreamedLevelBeLoaded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CanStreamedLevelBeLoaded_4);
            args = new Type[]{};
            method = type.GetMethod("get_isPlaying", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isPlaying_5);
            args = new Type[]{typeof(UnityEngine.Object)};
            method = type.GetMethod("IsPlaying", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsPlaying_6);
            args = new Type[]{};
            method = type.GetMethod("get_isFocused", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isFocused_7);
            args = new Type[]{};
            method = type.GetMethod("GetBuildTags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBuildTags_8);
            args = new Type[]{typeof(System.String[])};
            method = type.GetMethod("SetBuildTags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetBuildTags_9);
            args = new Type[]{};
            method = type.GetMethod("get_buildGUID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_buildGUID_10);
            args = new Type[]{};
            method = type.GetMethod("get_runInBackground", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_runInBackground_11);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_runInBackground", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_runInBackground_12);
            args = new Type[]{};
            method = type.GetMethod("HasProLicense", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasProLicense_13);
            args = new Type[]{};
            method = type.GetMethod("get_isBatchMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isBatchMode_14);
            args = new Type[]{};
            method = type.GetMethod("get_dataPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_dataPath_15);
            args = new Type[]{};
            method = type.GetMethod("get_streamingAssetsPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_streamingAssetsPath_16);
            args = new Type[]{};
            method = type.GetMethod("get_persistentDataPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_persistentDataPath_17);
            args = new Type[]{};
            method = type.GetMethod("get_temporaryCachePath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_temporaryCachePath_18);
            args = new Type[]{};
            method = type.GetMethod("get_absoluteURL", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_absoluteURL_19);
            args = new Type[]{};
            method = type.GetMethod("get_unityVersion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_unityVersion_20);
            args = new Type[]{};
            method = type.GetMethod("get_version", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_version_21);
            args = new Type[]{};
            method = type.GetMethod("get_installerName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_installerName_22);
            args = new Type[]{};
            method = type.GetMethod("get_identifier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_identifier_23);
            args = new Type[]{};
            method = type.GetMethod("get_installMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_installMode_24);
            args = new Type[]{};
            method = type.GetMethod("get_sandboxType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sandboxType_25);
            args = new Type[]{};
            method = type.GetMethod("get_productName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_productName_26);
            args = new Type[]{};
            method = type.GetMethod("get_companyName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_companyName_27);
            args = new Type[]{};
            method = type.GetMethod("get_cloudProjectId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cloudProjectId_28);
            args = new Type[]{typeof(UnityEngine.Application.AdvertisingIdentifierCallback)};
            method = type.GetMethod("RequestAdvertisingIdentifierAsync", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequestAdvertisingIdentifierAsync_29);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("OpenURL", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OpenURL_30);
            args = new Type[]{};
            method = type.GetMethod("get_targetFrameRate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_targetFrameRate_31);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_targetFrameRate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_targetFrameRate_32);
            args = new Type[]{typeof(UnityEngine.LogType)};
            method = type.GetMethod("GetStackTraceLogType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetStackTraceLogType_33);
            args = new Type[]{typeof(UnityEngine.LogType), typeof(UnityEngine.StackTraceLogType)};
            method = type.GetMethod("SetStackTraceLogType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetStackTraceLogType_34);
            args = new Type[]{};
            method = type.GetMethod("get_consoleLogPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_consoleLogPath_35);
            args = new Type[]{};
            method = type.GetMethod("get_backgroundLoadingPriority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_backgroundLoadingPriority_36);
            args = new Type[]{typeof(UnityEngine.ThreadPriority)};
            method = type.GetMethod("set_backgroundLoadingPriority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_backgroundLoadingPriority_37);
            args = new Type[]{};
            method = type.GetMethod("get_genuine", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_genuine_38);
            args = new Type[]{};
            method = type.GetMethod("get_genuineCheckAvailable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_genuineCheckAvailable_39);
            args = new Type[]{typeof(UnityEngine.UserAuthorization)};
            method = type.GetMethod("RequestUserAuthorization", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequestUserAuthorization_40);
            args = new Type[]{typeof(UnityEngine.UserAuthorization)};
            method = type.GetMethod("HasUserAuthorization", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasUserAuthorization_41);
            args = new Type[]{};
            method = type.GetMethod("get_platform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_platform_42);
            args = new Type[]{};
            method = type.GetMethod("get_isMobilePlatform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isMobilePlatform_43);
            args = new Type[]{};
            method = type.GetMethod("get_isConsolePlatform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isConsolePlatform_44);
            args = new Type[]{};
            method = type.GetMethod("get_systemLanguage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_systemLanguage_45);
            args = new Type[]{};
            method = type.GetMethod("get_internetReachability", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_internetReachability_46);
            args = new Type[]{typeof(UnityEngine.Application.LowMemoryCallback)};
            method = type.GetMethod("add_lowMemory", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_lowMemory_47);
            args = new Type[]{typeof(UnityEngine.Application.LowMemoryCallback)};
            method = type.GetMethod("remove_lowMemory", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_lowMemory_48);
            args = new Type[]{typeof(UnityEngine.Application.LogCallback)};
            method = type.GetMethod("add_logMessageReceived", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_logMessageReceived_49);
            args = new Type[]{typeof(UnityEngine.Application.LogCallback)};
            method = type.GetMethod("remove_logMessageReceived", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_logMessageReceived_50);
            args = new Type[]{typeof(UnityEngine.Application.LogCallback)};
            method = type.GetMethod("add_logMessageReceivedThreaded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_logMessageReceivedThreaded_51);
            args = new Type[]{typeof(UnityEngine.Application.LogCallback)};
            method = type.GetMethod("remove_logMessageReceivedThreaded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_logMessageReceivedThreaded_52);
            args = new Type[]{typeof(UnityEngine.Events.UnityAction)};
            method = type.GetMethod("add_onBeforeRender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onBeforeRender_53);
            args = new Type[]{typeof(UnityEngine.Events.UnityAction)};
            method = type.GetMethod("remove_onBeforeRender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onBeforeRender_54);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("add_focusChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_focusChanged_55);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("remove_focusChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_focusChanged_56);
            args = new Type[]{typeof(System.Action<System.String>)};
            method = type.GetMethod("add_deepLinkActivated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_deepLinkActivated_57);
            args = new Type[]{typeof(System.Action<System.String>)};
            method = type.GetMethod("remove_deepLinkActivated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_deepLinkActivated_58);
            args = new Type[]{typeof(System.Func<System.Boolean>)};
            method = type.GetMethod("add_wantsToQuit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_wantsToQuit_59);
            args = new Type[]{typeof(System.Func<System.Boolean>)};
            method = type.GetMethod("remove_wantsToQuit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_wantsToQuit_60);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_quitting", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_quitting_61);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_quitting", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_quitting_62);
            args = new Type[]{};
            method = type.GetMethod("get_isEditor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isEditor_63);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Application());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Application[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Quit_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @exitCode = ptr_of_this_method->Value;


            UnityEngine.Application.Quit(@exitCode);

            return __ret;
        }

        static StackObject* Quit_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.Application.Quit();

            return __ret;
        }

        static StackObject* Unload_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.Application.Unload();

            return __ret;
        }

        static StackObject* CanStreamedLevelBeLoaded_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @levelIndex = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Application.CanStreamedLevelBeLoaded(@levelIndex);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CanStreamedLevelBeLoaded_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @levelName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Application.CanStreamedLevelBeLoaded(@levelName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isPlaying_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.isPlaying;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsPlaying_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Object @obj = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Application.IsPlaying(@obj);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isFocused_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.isFocused;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetBuildTags_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.GetBuildTags();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetBuildTags_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String[] @buildTags = (System.String[])typeof(System.String[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.SetBuildTags(@buildTags);

            return __ret;
        }

        static StackObject* get_buildGUID_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.buildGUID;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_runInBackground_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.runInBackground;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_runInBackground_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Application.runInBackground = value;

            return __ret;
        }

        static StackObject* HasProLicense_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.HasProLicense();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isBatchMode_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.isBatchMode;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_dataPath_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.dataPath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_streamingAssetsPath_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.streamingAssetsPath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_persistentDataPath_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.persistentDataPath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_temporaryCachePath_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.temporaryCachePath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_absoluteURL_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.absoluteURL;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_unityVersion_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.unityVersion;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_version_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.version;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_installerName_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.installerName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_identifier_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.identifier;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_installMode_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.installMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_sandboxType_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.sandboxType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_productName_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.productName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_companyName_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.companyName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_cloudProjectId_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.cloudProjectId;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RequestAdvertisingIdentifierAsync_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Application.AdvertisingIdentifierCallback @delegateMethod = (UnityEngine.Application.AdvertisingIdentifierCallback)typeof(UnityEngine.Application.AdvertisingIdentifierCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Application.RequestAdvertisingIdentifierAsync(@delegateMethod);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* OpenURL_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @url = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.OpenURL(@url);

            return __ret;
        }

        static StackObject* get_targetFrameRate_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.targetFrameRate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_targetFrameRate_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.Application.targetFrameRate = value;

            return __ret;
        }

        static StackObject* GetStackTraceLogType_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LogType @logType = (UnityEngine.LogType)typeof(UnityEngine.LogType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Application.GetStackTraceLogType(@logType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetStackTraceLogType_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.StackTraceLogType @stackTraceType = (UnityEngine.StackTraceLogType)typeof(UnityEngine.StackTraceLogType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LogType @logType = (UnityEngine.LogType)typeof(UnityEngine.LogType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.SetStackTraceLogType(@logType, @stackTraceType);

            return __ret;
        }

        static StackObject* get_consoleLogPath_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.consoleLogPath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_backgroundLoadingPriority_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.backgroundLoadingPriority;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_backgroundLoadingPriority_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ThreadPriority @value = (UnityEngine.ThreadPriority)typeof(UnityEngine.ThreadPriority).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.backgroundLoadingPriority = value;

            return __ret;
        }

        static StackObject* get_genuine_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.genuine;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_genuineCheckAvailable_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.genuineCheckAvailable;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RequestUserAuthorization_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.UserAuthorization @mode = (UnityEngine.UserAuthorization)typeof(UnityEngine.UserAuthorization).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Application.RequestUserAuthorization(@mode);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* HasUserAuthorization_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.UserAuthorization @mode = (UnityEngine.UserAuthorization)typeof(UnityEngine.UserAuthorization).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Application.HasUserAuthorization(@mode);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_platform_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.platform;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_isMobilePlatform_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.isMobilePlatform;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isConsolePlatform_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.isConsolePlatform;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_systemLanguage_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.systemLanguage;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_internetReachability_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.internetReachability;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* add_lowMemory_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Application.LowMemoryCallback @value = (UnityEngine.Application.LowMemoryCallback)typeof(UnityEngine.Application.LowMemoryCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.lowMemory += value;

            return __ret;
        }

        static StackObject* remove_lowMemory_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Application.LowMemoryCallback @value = (UnityEngine.Application.LowMemoryCallback)typeof(UnityEngine.Application.LowMemoryCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.lowMemory -= value;

            return __ret;
        }

        static StackObject* add_logMessageReceived_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Application.LogCallback @value = (UnityEngine.Application.LogCallback)typeof(UnityEngine.Application.LogCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.logMessageReceived += value;

            return __ret;
        }

        static StackObject* remove_logMessageReceived_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Application.LogCallback @value = (UnityEngine.Application.LogCallback)typeof(UnityEngine.Application.LogCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.logMessageReceived -= value;

            return __ret;
        }

        static StackObject* add_logMessageReceivedThreaded_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Application.LogCallback @value = (UnityEngine.Application.LogCallback)typeof(UnityEngine.Application.LogCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.logMessageReceivedThreaded += value;

            return __ret;
        }

        static StackObject* remove_logMessageReceivedThreaded_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Application.LogCallback @value = (UnityEngine.Application.LogCallback)typeof(UnityEngine.Application.LogCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.logMessageReceivedThreaded -= value;

            return __ret;
        }

        static StackObject* add_onBeforeRender_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Events.UnityAction @value = (UnityEngine.Events.UnityAction)typeof(UnityEngine.Events.UnityAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.onBeforeRender += value;

            return __ret;
        }

        static StackObject* remove_onBeforeRender_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Events.UnityAction @value = (UnityEngine.Events.UnityAction)typeof(UnityEngine.Events.UnityAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.onBeforeRender -= value;

            return __ret;
        }

        static StackObject* add_focusChanged_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> @value = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.focusChanged += value;

            return __ret;
        }

        static StackObject* remove_focusChanged_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> @value = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.focusChanged -= value;

            return __ret;
        }

        static StackObject* add_deepLinkActivated_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String> @value = (System.Action<System.String>)typeof(System.Action<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.deepLinkActivated += value;

            return __ret;
        }

        static StackObject* remove_deepLinkActivated_58(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String> @value = (System.Action<System.String>)typeof(System.Action<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.deepLinkActivated -= value;

            return __ret;
        }

        static StackObject* add_wantsToQuit_59(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<System.Boolean> @value = (System.Func<System.Boolean>)typeof(System.Func<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.wantsToQuit += value;

            return __ret;
        }

        static StackObject* remove_wantsToQuit_60(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<System.Boolean> @value = (System.Func<System.Boolean>)typeof(System.Func<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.wantsToQuit -= value;

            return __ret;
        }

        static StackObject* add_quitting_61(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.quitting += value;

            return __ret;
        }

        static StackObject* remove_quitting_62(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.quitting -= value;

            return __ret;
        }

        static StackObject* get_isEditor_63(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.isEditor;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Application();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
