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
            UnityEngine_Quaternion_Binding.Register(app);
            UnityEngine_GameObject_Binding.Register(app);
            UnityEngine_Object_Binding.Register(app);
            UnityEngine_Transform_Binding.Register(app);
            UnityEngine_RectTransform_Binding.Register(app);
            UnityEngine_Time_Binding.Register(app);
            wxb_hotMgr_Binding.Register(app);
            wxb_RefType_Binding.Register(app);
            System_Type_Binding.Register(app);
            System_Reflection_MethodInfo_Binding.Register(app);
            System_Reflection_FieldInfo_Binding.Register(app);
            System_Reflection_PropertyInfo_Binding.Register(app);
            UnityEngine_Debug_Binding.Register(app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding.Register(app);
            ILRuntime_Runtime_Intepreter_ILTypeInstance_Binding.Register(app);
            System_Math_Binding.Register(app);
            System_Convert_Binding.Register(app);
            System_DateTime_Binding.Register(app);
            System_TimeSpan_Binding.Register(app);
            System_String_Binding.Register(app);
            System_Text_StringBuilder_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_ILTypeInstance_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_UInt32_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int64_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_UInt64_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding.Register(app);
            System_Text_RegularExpressions_Regex_Binding.Register(app);
            System_Text_RegularExpressions_Group_Binding.Register(app);
            System_Text_RegularExpressions_Match_Binding.Register(app);
            System_Text_RegularExpressions_CaptureCollection_Binding.Register(app);
            System_Text_RegularExpressions_GroupCollection_Binding.Register(app);
            UnityEngine_UI_LayoutElement_Binding.Register(app);
            UnityEngine_UI_Text_Binding.Register(app);
            UnityEngine_UI_Image_Binding.Register(app);
            UnityEngine_UI_Graphic_Binding.Register(app);
            UnityEngine_EventSystems_UIBehaviour_Binding.Register(app);
            UnityEngine_MonoBehaviour_Binding.Register(app);
            UnityEngine_Color_Binding.Register(app);
            System_Collections_Generic_HashSet_1_Int64_Binding.Register(app);
            System_Collections_Generic_HashSet_1_Int32_Binding.Register(app);
            System_Linq_Enumerable_Binding.Register(app);
            UnityEngine_Canvas_Binding.Register(app);
            UnityEngine_Matrix4x4_Binding.Register(app);
            UnityEngine_Video_VideoPlayer_Binding.Register(app);
            System_Enum_Binding.Register(app);
            UnityEngine_Screen_Binding.Register(app);
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
