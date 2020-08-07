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
    unsafe class UnityEngine_Screen_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Screen);
            args = new Type[]{};
            method = type.GetMethod("get_resolutions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_resolutions_0);
            args = new Type[]{};
            method = type.GetMethod("get_currentResolution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentResolution_1);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32)};
            method = type.GetMethod("SetResolution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetResolution_2);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("SetResolution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetResolution_3);
            args = new Type[]{};
            method = type.GetMethod("get_width", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_width_4);
            args = new Type[]{};
            method = type.GetMethod("get_height", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_height_5);
            args = new Type[]{};
            method = type.GetMethod("get_dpi", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_dpi_6);
            args = new Type[]{};
            method = type.GetMethod("get_fullScreen", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_fullScreen_7);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_fullScreen", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_fullScreen_8);
            args = new Type[]{};
            method = type.GetMethod("get_autorotateToPortrait", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_autorotateToPortrait_9);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_autorotateToPortrait", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_autorotateToPortrait_10);
            args = new Type[]{};
            method = type.GetMethod("get_autorotateToPortraitUpsideDown", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_autorotateToPortraitUpsideDown_11);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_autorotateToPortraitUpsideDown", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_autorotateToPortraitUpsideDown_12);
            args = new Type[]{};
            method = type.GetMethod("get_autorotateToLandscapeLeft", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_autorotateToLandscapeLeft_13);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_autorotateToLandscapeLeft", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_autorotateToLandscapeLeft_14);
            args = new Type[]{};
            method = type.GetMethod("get_autorotateToLandscapeRight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_autorotateToLandscapeRight_15);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_autorotateToLandscapeRight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_autorotateToLandscapeRight_16);
            args = new Type[]{};
            method = type.GetMethod("get_orientation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_orientation_17);
            args = new Type[]{typeof(UnityEngine.ScreenOrientation)};
            method = type.GetMethod("set_orientation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_orientation_18);
            args = new Type[]{};
            method = type.GetMethod("get_sleepTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sleepTimeout_19);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_sleepTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sleepTimeout_20);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Screen());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Screen[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_resolutions_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Screen.resolutions;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_currentResolution_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Screen.currentResolution;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetResolution_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @preferredRefreshRate = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @fullscreen = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @height = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @width = ptr_of_this_method->Value;


            UnityEngine.Screen.SetResolution(@width, @height, @fullscreen, @preferredRefreshRate);

            return __ret;
        }

        static StackObject* SetResolution_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @fullscreen = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @height = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @width = ptr_of_this_method->Value;


            UnityEngine.Screen.SetResolution(@width, @height, @fullscreen);

            return __ret;
        }

        static StackObject* get_width_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Screen.width;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_height_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Screen.height;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_dpi_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Screen.dpi;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_fullScreen_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Screen.fullScreen;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_fullScreen_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Screen.fullScreen = value;

            return __ret;
        }

        static StackObject* get_autorotateToPortrait_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Screen.autorotateToPortrait;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_autorotateToPortrait_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Screen.autorotateToPortrait = value;

            return __ret;
        }

        static StackObject* get_autorotateToPortraitUpsideDown_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Screen.autorotateToPortraitUpsideDown;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_autorotateToPortraitUpsideDown_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Screen.autorotateToPortraitUpsideDown = value;

            return __ret;
        }

        static StackObject* get_autorotateToLandscapeLeft_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Screen.autorotateToLandscapeLeft;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_autorotateToLandscapeLeft_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Screen.autorotateToLandscapeLeft = value;

            return __ret;
        }

        static StackObject* get_autorotateToLandscapeRight_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Screen.autorotateToLandscapeRight;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_autorotateToLandscapeRight_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Screen.autorotateToLandscapeRight = value;

            return __ret;
        }

        static StackObject* get_orientation_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Screen.orientation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_orientation_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ScreenOrientation @value = (UnityEngine.ScreenOrientation)typeof(UnityEngine.ScreenOrientation).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Screen.orientation = value;

            return __ret;
        }

        static StackObject* get_sleepTimeout_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Screen.sleepTimeout;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_sleepTimeout_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.Screen.sleepTimeout = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Screen();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
