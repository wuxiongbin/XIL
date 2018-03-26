using System;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Collections.Generic;

namespace PackTool
{
    public class OpenHotMacro : TemplatesMarco
    {
        const string marco = "USE_HOT";
        const string path = "";

        const string MenuItemOpen = "XIL/插件/开启";
        const string MenuItemClose = "XIL/插件/取消";

        [MenuItem(MenuItemClose, true)]
        public static bool BufCannelToggle()
        {
            MacroDefine macroDefine = new MacroDefine();
            return macroDefine.has(marco);
        }

        [MenuItem(MenuItemOpen, true)]
        public static bool BufOpenToggle()
        {
            MacroDefine macroDefine = new MacroDefine();
            return !macroDefine.has(marco);
        }

        [MenuItem(MenuItemClose)]
        public static void BufCannel()
        {
            SetEnable(false, marco, path);
            OpenHotMDBMacro.BufCannel();
        }

        [MenuItem(MenuItemOpen)]
        public static void BufOpen()
        {
            SetEnable(true, marco, path);
        }
    }

    public class OpenHotMDBMacro : TemplatesMarco
    {
        const string marco = "USE_PDB";
        const string path = "";

        const string MenuItemOpen = "XIL/插件/PDB开启";
        const string MenuItemClose = "XIL/插件/PDB取消";

        [MenuItem(MenuItemClose, true)]
        public static bool BufCannelToggle()
        {
            MacroDefine macroDefine = new MacroDefine();
            return macroDefine.has(marco);
        }

        [MenuItem(MenuItemOpen, true)]
        public static bool BufOpenToggle()
        {
            MacroDefine macroDefine = new MacroDefine();
            return !macroDefine.has(marco);
        }

        [MenuItem(MenuItemClose)]
        public static void BufCannel()
        {
            SetEnable(false, marco, path);
        }

        [MenuItem(MenuItemOpen)]
        public static void BufOpen()
        {
            OpenHotMacro.BufOpen();
            SetEnable(true, marco, path);
        }
    }

}