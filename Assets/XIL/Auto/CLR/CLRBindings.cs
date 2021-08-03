#if USE_HOT
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ILRuntime.Runtime.Generated
{
    class CLRBindings
    {

        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            System_Int32_Binding.Register(app);
            System_Single_Binding.Register(app);
            System_Int64_Binding.Register(app);
            System_Object_Binding.Register(app);
            System_String_Binding.Register(app);
            System_Array_Binding.Register(app);
            UnityEngine_Vector2_Binding.Register(app);
            UnityEngine_Vector3_Binding.Register(app);
            UnityEngine_Vector4_Binding.Register(app);
            UnityEngine_Rect_Binding.Register(app);
            UnityEngine_RectInt_Binding.Register(app);
            UnityEngine_Vector2Int_Binding.Register(app);
            UnityEngine_Vector3Int_Binding.Register(app);
            UnityEngine_Quaternion_Binding.Register(app);
            UnityEngine_GameObject_Binding.Register(app);
            UnityEngine_Mathf_Binding.Register(app);
            UnityEngine_Ray_Binding.Register(app);
            UnityEngine_Application_Binding.Register(app);
            UnityEngine_Object_Binding.Register(app);
            UnityEngine_Transform_Binding.Register(app);
            UnityEngine_RectTransform_Binding.Register(app);
            UnityEngine_Texture_Binding.Register(app);
            UnityEngine_Texture2D_Binding.Register(app);
            UnityEngine_Shader_Binding.Register(app);
            UnityEngine_Renderer_Binding.Register(app);
            UnityEngine_RenderSettings_Binding.Register(app);
            UnityEngine_RenderTexture_Binding.Register(app);
            UnityEngine_MeshRenderer_Binding.Register(app);
            UnityEngine_SkinnedMeshRenderer_Binding.Register(app);
            UnityEngine_SpriteRenderer_Binding.Register(app);
            UnityEngine_Mesh_Binding.Register(app);
            UnityEngine_Animator_Binding.Register(app);
            UnityEngine_RuntimeAnimatorController_Binding.Register(app);
            UnityEngine_AnimationClip_Binding.Register(app);
            UnityEngine_AnimationEvent_Binding.Register(app);
            UnityEngine_Physics_Binding.Register(app);
            UnityEngine_Collider_Binding.Register(app);
            UnityEngine_BoxCollider_Binding.Register(app);
            UnityEngine_Material_Binding.Register(app);
            UnityEngine_QualitySettings_Binding.Register(app);
            UnityEngine_ParticleSystem_Binding.Register(app);
            UnityEngine_MonoBehaviour_Binding.Register(app);
            UnityEngine_Component_Binding.Register(app);
            UnityEngine_Behaviour_Binding.Register(app);
            UnityEngine_Color_Binding.Register(app);
            UnityEngine_Resources_Binding.Register(app);
            UnityEngine_AssetBundle_Binding.Register(app);
            UnityEngine_Camera_Binding.Register(app);
            UnityEngine_SystemInfo_Binding.Register(app);
            UnityEngine_Time_Binding.Register(app);
            wxb_hotMgr_Binding.Register(app);
            wxb_IL_Help_Binding.Register(app);
            wxb_RefType_Binding.Register(app);
            System_Type_Binding.Register(app);
            System_Reflection_MethodInfo_Binding.Register(app);
            System_Reflection_FieldInfo_Binding.Register(app);
            System_Reflection_PropertyInfo_Binding.Register(app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_List_1_Object_Binding.Register(app);
            System_Collections_Generic_List_1_Int32_Binding.Register(app);
            System_Collections_Generic_List_1_String_Binding.Register(app);
            System_Collections_Generic_List_1_Int64_Binding.Register(app);
            System_Collections_Generic_List_1_UInt32_Binding.Register(app);
            System_Collections_Generic_List_1_UInt64_Binding.Register(app);
            ILRuntime_Runtime_Intepreter_ILTypeInstance_Binding.Register(app);
            System_Net_Sockets_TcpClient_Binding.Register(app);
            System_Net_Sockets_Socket_Binding.Register(app);
            System_Math_Binding.Register(app);
            System_Convert_Binding.Register(app);
            System_DateTime_Binding.Register(app);
            System_TimeSpan_Binding.Register(app);
            System_Text_StringBuilder_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_ILTypeInstance_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_UInt32_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int64_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_UInt64_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Object_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Object_Object_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_Object_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_UInt32_Object_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int64_Object_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_UInt64_Object_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_Object_Binding.Register(app);
            UnityEngine_Sprite_Binding.Register(app);
            UnityEngine_UI_LayoutElement_Binding.Register(app);
            UnityEngine_UI_Text_Binding.Register(app);
            UnityEngine_UI_Image_Binding.Register(app);
            UnityEngine_UI_Graphic_Binding.Register(app);
            UnityEngine_SceneManagement_SceneManager_Binding.Register(app);
            UnityEngine_EventSystems_UIBehaviour_Binding.Register(app);
            System_Collections_Generic_HashSet_1_Int64_Binding.Register(app);
            System_Collections_Generic_HashSet_1_Int32_Binding.Register(app);
            System_Collections_Generic_HashSet_1_String_Binding.Register(app);
            System_Linq_Enumerable_Binding.Register(app);
            UnityEngine_Canvas_Binding.Register(app);
            UnityEngine_Matrix4x4_Binding.Register(app);
            UnityEngine_Video_VideoPlayer_Binding.Register(app);
            System_Enum_Binding.Register(app);
            UnityEngine_Screen_Binding.Register(app);
            wxb_Hotfix_Binding.Register(app);
            System_Func_2_ILTypeInstance_Boolean_Binding.Register(app);
            TestInterface_Binding.Register(app);
            ITestInterface_Binding.Register(app);
            UnityEngine_GUILayout_Binding.Register(app);
            System_Collections_Generic_List_1_String_Binding_Enumerator_Binding.Register(app);
            System_IDisposable_Binding.Register(app);
            IL_RefOutParam_1_Int32_Binding.Register(app);
            wxb_L_Binding.Register(app);
            UnityEngine_Random_Binding.Register(app);
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE ILRuntime Appdomain destroy
        /// </summary>
        public static void Shutdown(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}
#endif
