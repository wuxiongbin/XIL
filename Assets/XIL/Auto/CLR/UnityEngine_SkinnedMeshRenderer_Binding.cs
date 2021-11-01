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
    unsafe class UnityEngine_SkinnedMeshRenderer_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.SkinnedMeshRenderer);
            args = new Type[]{};
            method = type.GetMethod("get_quality", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_quality_0);
            args = new Type[]{typeof(UnityEngine.SkinQuality)};
            method = type.GetMethod("set_quality", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_quality_1);
            args = new Type[]{};
            method = type.GetMethod("get_updateWhenOffscreen", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_updateWhenOffscreen_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_updateWhenOffscreen", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_updateWhenOffscreen_3);
            args = new Type[]{};
            method = type.GetMethod("get_forceMatrixRecalculationPerRender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_forceMatrixRecalculationPerRender_4);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_forceMatrixRecalculationPerRender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_forceMatrixRecalculationPerRender_5);
            args = new Type[]{};
            method = type.GetMethod("get_rootBone", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rootBone_6);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("set_rootBone", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rootBone_7);
            args = new Type[]{};
            method = type.GetMethod("get_bones", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_bones_8);
            args = new Type[]{typeof(UnityEngine.Transform[])};
            method = type.GetMethod("set_bones", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_bones_9);
            args = new Type[]{};
            method = type.GetMethod("get_sharedMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sharedMesh_10);
            args = new Type[]{typeof(UnityEngine.Mesh)};
            method = type.GetMethod("set_sharedMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sharedMesh_11);
            args = new Type[]{};
            method = type.GetMethod("get_skinnedMotionVectors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_skinnedMotionVectors_12);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_skinnedMotionVectors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_skinnedMotionVectors_13);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetBlendShapeWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBlendShapeWeight_14);
            args = new Type[]{typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("SetBlendShapeWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetBlendShapeWeight_15);
            args = new Type[]{typeof(UnityEngine.Mesh)};
            method = type.GetMethod("BakeMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BakeMesh_16);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Boolean)};
            method = type.GetMethod("BakeMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BakeMesh_17);
            args = new Type[]{};
            method = type.GetMethod("get_localBounds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_localBounds_18);
            args = new Type[]{typeof(UnityEngine.Bounds)};
            method = type.GetMethod("set_localBounds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_localBounds_19);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.SkinnedMeshRenderer());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SkinnedMeshRenderer[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_quality_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.quality;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_quality_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SkinQuality @value = (UnityEngine.SkinQuality)typeof(UnityEngine.SkinQuality).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.quality = value;

            return __ret;
        }

        static StackObject* get_updateWhenOffscreen_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.updateWhenOffscreen;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_updateWhenOffscreen_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.updateWhenOffscreen = value;

            return __ret;
        }

        static StackObject* get_forceMatrixRecalculationPerRender_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.forceMatrixRecalculationPerRender;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_forceMatrixRecalculationPerRender_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.forceMatrixRecalculationPerRender = value;

            return __ret;
        }

        static StackObject* get_rootBone_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rootBone;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_rootBone_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @value = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rootBone = value;

            return __ret;
        }

        static StackObject* get_bones_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.bones;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_bones_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform[] @value = (UnityEngine.Transform[])typeof(UnityEngine.Transform[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.bones = value;

            return __ret;
        }

        static StackObject* get_sharedMesh_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sharedMesh;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_sharedMesh_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh @value = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sharedMesh = value;

            return __ret;
        }

        static StackObject* get_skinnedMotionVectors_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.skinnedMotionVectors;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_skinnedMotionVectors_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.skinnedMotionVectors = value;

            return __ret;
        }

        static StackObject* GetBlendShapeWeight_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetBlendShapeWeight(@index);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetBlendShapeWeight_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @index = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetBlendShapeWeight(@index, @value);

            return __ret;
        }

        static StackObject* BakeMesh_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.BakeMesh(@mesh);

            return __ret;
        }

        static StackObject* BakeMesh_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @useScale = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.BakeMesh(@mesh, @useScale);

            return __ret;
        }

        static StackObject* get_localBounds_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.localBounds;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_localBounds_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Bounds @value = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SkinnedMeshRenderer instance_of_this_method = (UnityEngine.SkinnedMeshRenderer)typeof(UnityEngine.SkinnedMeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.localBounds = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.SkinnedMeshRenderer();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
