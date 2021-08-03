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
    unsafe class UnityEngine_GUILayout_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.GUILayout);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Label", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Label_0);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Label", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Label_1);
            args = new Type[]{typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Label", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Label_2);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Label", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Label_3);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Label", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Label_4);
            args = new Type[]{typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Label", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Label_5);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Box", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Box_6);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Box", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Box_7);
            args = new Type[]{typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Box", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Box_8);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Box", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Box_9);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Box", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Box_10);
            args = new Type[]{typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Box", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Box_11);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Button", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Button_12);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Button", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Button_13);
            args = new Type[]{typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Button", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Button_14);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Button", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Button_15);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Button", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Button_16);
            args = new Type[]{typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Button", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Button_17);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("RepeatButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RepeatButton_18);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("RepeatButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RepeatButton_19);
            args = new Type[]{typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("RepeatButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RepeatButton_20);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("RepeatButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RepeatButton_21);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("RepeatButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RepeatButton_22);
            args = new Type[]{typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("RepeatButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RepeatButton_23);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("TextField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TextField_24);
            args = new Type[]{typeof(System.String), typeof(System.Int32), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("TextField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TextField_25);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("TextField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TextField_26);
            args = new Type[]{typeof(System.String), typeof(System.Int32), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("TextField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TextField_27);
            args = new Type[]{typeof(System.String), typeof(System.Char), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("PasswordField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PasswordField_28);
            args = new Type[]{typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("PasswordField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PasswordField_29);
            args = new Type[]{typeof(System.String), typeof(System.Char), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("PasswordField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PasswordField_30);
            args = new Type[]{typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("PasswordField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PasswordField_31);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("TextArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TextArea_32);
            args = new Type[]{typeof(System.String), typeof(System.Int32), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("TextArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TextArea_33);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("TextArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TextArea_34);
            args = new Type[]{typeof(System.String), typeof(System.Int32), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("TextArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TextArea_35);
            args = new Type[]{typeof(System.Boolean), typeof(UnityEngine.Texture), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Toggle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Toggle_36);
            args = new Type[]{typeof(System.Boolean), typeof(System.String), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Toggle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Toggle_37);
            args = new Type[]{typeof(System.Boolean), typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Toggle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Toggle_38);
            args = new Type[]{typeof(System.Boolean), typeof(UnityEngine.Texture), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Toggle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Toggle_39);
            args = new Type[]{typeof(System.Boolean), typeof(System.String), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Toggle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Toggle_40);
            args = new Type[]{typeof(System.Boolean), typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Toggle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Toggle_41);
            args = new Type[]{typeof(System.Int32), typeof(System.String[]), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Toolbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Toolbar_42);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Texture[]), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Toolbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Toolbar_43);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.GUIContent[]), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Toolbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Toolbar_44);
            args = new Type[]{typeof(System.Int32), typeof(System.String[]), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Toolbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Toolbar_45);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Texture[]), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Toolbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Toolbar_46);
            args = new Type[]{typeof(System.Int32), typeof(System.String[]), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUI.ToolbarButtonSize), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Toolbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Toolbar_47);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Texture[]), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUI.ToolbarButtonSize), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Toolbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Toolbar_48);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.GUIContent[]), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Toolbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Toolbar_49);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.GUIContent[]), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUI.ToolbarButtonSize), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Toolbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Toolbar_50);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.GUIContent[]), typeof(System.Boolean[]), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Toolbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Toolbar_51);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.GUIContent[]), typeof(System.Boolean[]), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUI.ToolbarButtonSize), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Toolbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Toolbar_52);
            args = new Type[]{typeof(System.Int32), typeof(System.String[]), typeof(System.Int32), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("SelectionGrid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectionGrid_53);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Texture[]), typeof(System.Int32), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("SelectionGrid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectionGrid_54);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.GUIContent[]), typeof(System.Int32), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("SelectionGrid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectionGrid_55);
            args = new Type[]{typeof(System.Int32), typeof(System.String[]), typeof(System.Int32), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("SelectionGrid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectionGrid_56);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Texture[]), typeof(System.Int32), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("SelectionGrid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectionGrid_57);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.GUIContent[]), typeof(System.Int32), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("SelectionGrid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectionGrid_58);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("HorizontalSlider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HorizontalSlider_59);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("HorizontalSlider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HorizontalSlider_60);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("VerticalSlider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, VerticalSlider_61);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("VerticalSlider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, VerticalSlider_62);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("HorizontalScrollbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HorizontalScrollbar_63);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("HorizontalScrollbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HorizontalScrollbar_64);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("VerticalScrollbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, VerticalScrollbar_65);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("VerticalScrollbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, VerticalScrollbar_66);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("Space", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Space_67);
            args = new Type[]{};
            method = type.GetMethod("FlexibleSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FlexibleSpace_68);
            args = new Type[]{typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("BeginHorizontal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginHorizontal_69);
            args = new Type[]{typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("BeginHorizontal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginHorizontal_70);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("BeginHorizontal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginHorizontal_71);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("BeginHorizontal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginHorizontal_72);
            args = new Type[]{typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("BeginHorizontal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginHorizontal_73);
            args = new Type[]{};
            method = type.GetMethod("EndHorizontal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EndHorizontal_74);
            args = new Type[]{typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("BeginVertical", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginVertical_75);
            args = new Type[]{typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("BeginVertical", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginVertical_76);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("BeginVertical", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginVertical_77);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("BeginVertical", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginVertical_78);
            args = new Type[]{typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("BeginVertical", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginVertical_79);
            args = new Type[]{};
            method = type.GetMethod("EndVertical", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EndVertical_80);
            args = new Type[]{typeof(UnityEngine.Rect)};
            method = type.GetMethod("BeginArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginArea_81);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(System.String)};
            method = type.GetMethod("BeginArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginArea_82);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture)};
            method = type.GetMethod("BeginArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginArea_83);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent)};
            method = type.GetMethod("BeginArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginArea_84);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("BeginArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginArea_85);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(System.String), typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("BeginArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginArea_86);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("BeginArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginArea_87);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("BeginArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginArea_88);
            args = new Type[]{};
            method = type.GetMethod("EndArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EndArea_89);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("BeginScrollView", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginScrollView_90);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("BeginScrollView", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginScrollView_91);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("BeginScrollView", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginScrollView_92);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("BeginScrollView", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginScrollView_93);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("BeginScrollView", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginScrollView_94);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("BeginScrollView", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginScrollView_95);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("BeginScrollView", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginScrollView_96);
            args = new Type[]{};
            method = type.GetMethod("EndScrollView", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EndScrollView_97);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Rect), typeof(UnityEngine.GUI.WindowFunction), typeof(System.String), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Window", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Window_98);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Rect), typeof(UnityEngine.GUI.WindowFunction), typeof(UnityEngine.Texture), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Window", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Window_99);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Rect), typeof(UnityEngine.GUI.WindowFunction), typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Window", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Window_100);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Rect), typeof(UnityEngine.GUI.WindowFunction), typeof(System.String), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Window", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Window_101);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Rect), typeof(UnityEngine.GUI.WindowFunction), typeof(UnityEngine.Texture), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Window", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Window_102);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Rect), typeof(UnityEngine.GUI.WindowFunction), typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("Window", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Window_103);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("Width", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Width_104);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("MinWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MinWidth_105);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("MaxWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MaxWidth_106);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("Height", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Height_107);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("MinHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MinHeight_108);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("MaxHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MaxHeight_109);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("ExpandWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ExpandWidth_110);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("ExpandHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ExpandHeight_111);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.GUILayout());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.GUILayout[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Label_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture @image = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.Label(@image, @options);

            return __ret;
        }

        static StackObject* Label_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.Label(@text, @options);

            return __ret;
        }

        static StackObject* Label_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIContent @content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.Label(@content, @options);

            return __ret;
        }

        static StackObject* Label_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture @image = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.Label(@image, @style, @options);

            return __ret;
        }

        static StackObject* Label_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.Label(@text, @style, @options);

            return __ret;
        }

        static StackObject* Label_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIContent @content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.Label(@content, @style, @options);

            return __ret;
        }

        static StackObject* Box_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture @image = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.Box(@image, @options);

            return __ret;
        }

        static StackObject* Box_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.Box(@text, @options);

            return __ret;
        }

        static StackObject* Box_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIContent @content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.Box(@content, @options);

            return __ret;
        }

        static StackObject* Box_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture @image = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.Box(@image, @style, @options);

            return __ret;
        }

        static StackObject* Box_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.Box(@text, @style, @options);

            return __ret;
        }

        static StackObject* Box_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIContent @content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.Box(@content, @style, @options);

            return __ret;
        }

        static StackObject* Button_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture @image = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.Button(@image, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Button_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.Button(@text, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Button_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIContent @content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.Button(@content, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Button_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture @image = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.Button(@image, @style, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Button_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.Button(@text, @style, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Button_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIContent @content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.Button(@content, @style, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RepeatButton_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture @image = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.RepeatButton(@image, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RepeatButton_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.RepeatButton(@text, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RepeatButton_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIContent @content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.RepeatButton(@content, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RepeatButton_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture @image = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.RepeatButton(@image, @style, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RepeatButton_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.RepeatButton(@text, @style, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RepeatButton_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIContent @content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.RepeatButton(@content, @style, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TextField_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.TextField(@text, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TextField_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @maxLength = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.TextField(@text, @maxLength, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TextField_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.TextField(@text, @style, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TextField_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @maxLength = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.TextField(@text, @maxLength, @style, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* PasswordField_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Char @maskChar = (char)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @password = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.PasswordField(@password, @maskChar, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* PasswordField_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @maxLength = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Char @maskChar = (char)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @password = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.PasswordField(@password, @maskChar, @maxLength, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* PasswordField_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Char @maskChar = (char)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @password = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.PasswordField(@password, @maskChar, @style, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* PasswordField_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @maxLength = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Char @maskChar = (char)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.String @password = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.PasswordField(@password, @maskChar, @maxLength, @style, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TextArea_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.TextArea(@text, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TextArea_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @maxLength = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.TextArea(@text, @maxLength, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TextArea_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.TextArea(@text, @style, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TextArea_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @maxLength = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.TextArea(@text, @maxLength, @style, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Toggle_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture @image = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            var result_of_this_method = UnityEngine.GUILayout.Toggle(@value, @image, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Toggle_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            var result_of_this_method = UnityEngine.GUILayout.Toggle(@value, @text, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Toggle_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIContent @content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            var result_of_this_method = UnityEngine.GUILayout.Toggle(@value, @content, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Toggle_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture @image = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            var result_of_this_method = UnityEngine.GUILayout.Toggle(@value, @image, @style, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Toggle_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            var result_of_this_method = UnityEngine.GUILayout.Toggle(@value, @text, @style, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Toggle_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIContent @content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            var result_of_this_method = UnityEngine.GUILayout.Toggle(@value, @content, @style, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Toolbar_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String[] @texts = (System.String[])typeof(System.String[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @selected = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Toolbar(@selected, @texts, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Toolbar_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture[] @images = (UnityEngine.Texture[])typeof(UnityEngine.Texture[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @selected = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Toolbar(@selected, @images, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Toolbar_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIContent[] @contents = (UnityEngine.GUIContent[])typeof(UnityEngine.GUIContent[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @selected = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Toolbar(@selected, @contents, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Toolbar_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String[] @texts = (System.String[])typeof(System.String[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @selected = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Toolbar(@selected, @texts, @style, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Toolbar_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture[] @images = (UnityEngine.Texture[])typeof(UnityEngine.Texture[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @selected = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Toolbar(@selected, @images, @style, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Toolbar_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUI.ToolbarButtonSize @buttonSize = (UnityEngine.GUI.ToolbarButtonSize)typeof(UnityEngine.GUI.ToolbarButtonSize).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String[] @texts = (System.String[])typeof(System.String[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @selected = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Toolbar(@selected, @texts, @style, @buttonSize, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Toolbar_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUI.ToolbarButtonSize @buttonSize = (UnityEngine.GUI.ToolbarButtonSize)typeof(UnityEngine.GUI.ToolbarButtonSize).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Texture[] @images = (UnityEngine.Texture[])typeof(UnityEngine.Texture[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @selected = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Toolbar(@selected, @images, @style, @buttonSize, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Toolbar_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIContent[] @contents = (UnityEngine.GUIContent[])typeof(UnityEngine.GUIContent[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @selected = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Toolbar(@selected, @contents, @style, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Toolbar_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUI.ToolbarButtonSize @buttonSize = (UnityEngine.GUI.ToolbarButtonSize)typeof(UnityEngine.GUI.ToolbarButtonSize).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GUIContent[] @contents = (UnityEngine.GUIContent[])typeof(UnityEngine.GUIContent[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @selected = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Toolbar(@selected, @contents, @style, @buttonSize, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Toolbar_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean[] @enabled = (System.Boolean[])typeof(System.Boolean[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GUIContent[] @contents = (UnityEngine.GUIContent[])typeof(UnityEngine.GUIContent[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @selected = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Toolbar(@selected, @contents, @enabled, @style, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Toolbar_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUI.ToolbarButtonSize @buttonSize = (UnityEngine.GUI.ToolbarButtonSize)typeof(UnityEngine.GUI.ToolbarButtonSize).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean[] @enabled = (System.Boolean[])typeof(System.Boolean[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.GUIContent[] @contents = (UnityEngine.GUIContent[])typeof(UnityEngine.GUIContent[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @selected = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Toolbar(@selected, @contents, @enabled, @style, @buttonSize, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SelectionGrid_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @xCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String[] @texts = (System.String[])typeof(System.String[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @selected = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.SelectionGrid(@selected, @texts, @xCount, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SelectionGrid_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @xCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture[] @images = (UnityEngine.Texture[])typeof(UnityEngine.Texture[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @selected = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.SelectionGrid(@selected, @images, @xCount, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SelectionGrid_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @xCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIContent[] @content = (UnityEngine.GUIContent[])typeof(UnityEngine.GUIContent[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @selected = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.SelectionGrid(@selected, @content, @xCount, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SelectionGrid_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @xCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String[] @texts = (System.String[])typeof(System.String[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @selected = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.SelectionGrid(@selected, @texts, @xCount, @style, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SelectionGrid_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @xCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Texture[] @images = (UnityEngine.Texture[])typeof(UnityEngine.Texture[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @selected = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.SelectionGrid(@selected, @images, @xCount, @style, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SelectionGrid_58(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @xCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GUIContent[] @contents = (UnityEngine.GUIContent[])typeof(UnityEngine.GUIContent[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @selected = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.SelectionGrid(@selected, @contents, @xCount, @style, @options);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* HorizontalSlider_59(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @rightValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @leftValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.HorizontalSlider(@value, @leftValue, @rightValue, @options);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* HorizontalSlider_60(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @thumb = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIStyle @slider = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @rightValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @leftValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.HorizontalSlider(@value, @leftValue, @rightValue, @slider, @thumb, @options);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* VerticalSlider_61(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @rightValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @leftValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.VerticalSlider(@value, @leftValue, @rightValue, @options);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* VerticalSlider_62(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @thumb = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIStyle @slider = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @rightValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @leftValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.VerticalSlider(@value, @leftValue, @rightValue, @slider, @thumb, @options);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* HorizontalScrollbar_63(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @rightValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @leftValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @size = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.HorizontalScrollbar(@value, @size, @leftValue, @rightValue, @options);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* HorizontalScrollbar_64(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @rightValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @leftValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @size = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.HorizontalScrollbar(@value, @size, @leftValue, @rightValue, @style, @options);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* VerticalScrollbar_65(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @bottomValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @topValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @size = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.VerticalScrollbar(@value, @size, @topValue, @bottomValue, @options);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* VerticalScrollbar_66(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @bottomValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @topValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @size = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.VerticalScrollbar(@value, @size, @topValue, @bottomValue, @style, @options);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Space_67(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @pixels = *(float*)&ptr_of_this_method->Value;


            UnityEngine.GUILayout.Space(@pixels);

            return __ret;
        }

        static StackObject* FlexibleSpace_68(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.GUILayout.FlexibleSpace();

            return __ret;
        }

        static StackObject* BeginHorizontal_69(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginHorizontal(@options);

            return __ret;
        }

        static StackObject* BeginHorizontal_70(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginHorizontal(@style, @options);

            return __ret;
        }

        static StackObject* BeginHorizontal_71(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginHorizontal(@text, @style, @options);

            return __ret;
        }

        static StackObject* BeginHorizontal_72(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture @image = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginHorizontal(@image, @style, @options);

            return __ret;
        }

        static StackObject* BeginHorizontal_73(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIContent @content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginHorizontal(@content, @style, @options);

            return __ret;
        }

        static StackObject* EndHorizontal_74(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.GUILayout.EndHorizontal();

            return __ret;
        }

        static StackObject* BeginVertical_75(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginVertical(@options);

            return __ret;
        }

        static StackObject* BeginVertical_76(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginVertical(@style, @options);

            return __ret;
        }

        static StackObject* BeginVertical_77(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginVertical(@text, @style, @options);

            return __ret;
        }

        static StackObject* BeginVertical_78(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture @image = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginVertical(@image, @style, @options);

            return __ret;
        }

        static StackObject* BeginVertical_79(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIContent @content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginVertical(@content, @style, @options);

            return __ret;
        }

        static StackObject* EndVertical_80(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.GUILayout.EndVertical();

            return __ret;
        }

        static StackObject* BeginArea_81(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginArea(@screenRect);

            return __ret;
        }

        static StackObject* BeginArea_82(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginArea(@screenRect, @text);

            return __ret;
        }

        static StackObject* BeginArea_83(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture @image = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginArea(@screenRect, @image);

            return __ret;
        }

        static StackObject* BeginArea_84(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIContent @content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginArea(@screenRect, @content);

            return __ret;
        }

        static StackObject* BeginArea_85(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginArea(@screenRect, @style);

            return __ret;
        }

        static StackObject* BeginArea_86(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginArea(@screenRect, @text, @style);

            return __ret;
        }

        static StackObject* BeginArea_87(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture @image = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginArea(@screenRect, @image, @style);

            return __ret;
        }

        static StackObject* BeginArea_88(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIContent @content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.GUILayout.BeginArea(@screenRect, @content, @style);

            return __ret;
        }

        static StackObject* EndArea_89(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.GUILayout.EndArea();

            return __ret;
        }

        static StackObject* BeginScrollView_90(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @scrollPosition = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.BeginScrollView(@scrollPosition, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BeginScrollView_91(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @alwaysShowVertical = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @alwaysShowHorizontal = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @scrollPosition = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.BeginScrollView(@scrollPosition, @alwaysShowHorizontal, @alwaysShowVertical, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BeginScrollView_92(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @verticalScrollbar = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIStyle @horizontalScrollbar = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @scrollPosition = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.BeginScrollView(@scrollPosition, @horizontalScrollbar, @verticalScrollbar, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BeginScrollView_93(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @scrollPosition = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.BeginScrollView(@scrollPosition, @style);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BeginScrollView_94(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @scrollPosition = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.BeginScrollView(@scrollPosition, @style, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BeginScrollView_95(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @verticalScrollbar = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIStyle @horizontalScrollbar = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @alwaysShowVertical = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Boolean @alwaysShowHorizontal = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @scrollPosition = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.BeginScrollView(@scrollPosition, @alwaysShowHorizontal, @alwaysShowVertical, @horizontalScrollbar, @verticalScrollbar, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BeginScrollView_96(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @background = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIStyle @verticalScrollbar = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GUIStyle @horizontalScrollbar = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Boolean @alwaysShowVertical = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Boolean @alwaysShowHorizontal = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @scrollPosition = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GUILayout.BeginScrollView(@scrollPosition, @alwaysShowHorizontal, @alwaysShowVertical, @horizontalScrollbar, @verticalScrollbar, @background, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* EndScrollView_97(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.GUILayout.EndScrollView();

            return __ret;
        }

        static StackObject* Window_98(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUI.WindowFunction @func = (UnityEngine.GUI.WindowFunction)typeof(UnityEngine.GUI.WindowFunction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @id = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Window(@id, @screenRect, @func, @text, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Window_99(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture @image = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUI.WindowFunction @func = (UnityEngine.GUI.WindowFunction)typeof(UnityEngine.GUI.WindowFunction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @id = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Window(@id, @screenRect, @func, @image, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Window_100(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIContent @content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUI.WindowFunction @func = (UnityEngine.GUI.WindowFunction)typeof(UnityEngine.GUI.WindowFunction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @id = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Window(@id, @screenRect, @func, @content, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Window_101(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GUI.WindowFunction @func = (UnityEngine.GUI.WindowFunction)typeof(UnityEngine.GUI.WindowFunction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @id = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Window(@id, @screenRect, @func, @text, @style, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Window_102(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture @image = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GUI.WindowFunction @func = (UnityEngine.GUI.WindowFunction)typeof(UnityEngine.GUI.WindowFunction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @id = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Window(@id, @screenRect, @func, @image, @style, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Window_103(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] @options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIContent @content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GUI.WindowFunction @func = (UnityEngine.GUI.WindowFunction)typeof(UnityEngine.GUI.WindowFunction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @id = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Window(@id, @screenRect, @func, @content, @style, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Width_104(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @width = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Width(@width);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* MinWidth_105(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minWidth = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.MinWidth(@minWidth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* MaxWidth_106(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxWidth = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.MaxWidth(@maxWidth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Height_107(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @height = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.Height(@height);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* MinHeight_108(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minHeight = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.MinHeight(@minHeight);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* MaxHeight_109(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxHeight = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.GUILayout.MaxHeight(@maxHeight);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ExpandWidth_110(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @expand = ptr_of_this_method->Value == 1;


            var result_of_this_method = UnityEngine.GUILayout.ExpandWidth(@expand);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ExpandHeight_111(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @expand = ptr_of_this_method->Value == 1;


            var result_of_this_method = UnityEngine.GUILayout.ExpandHeight(@expand);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.GUILayout();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
