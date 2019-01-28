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

        [MenuItem(MenuItemClose, false, 1)]
        public static void BufCannel()
        {
            SetEnable(false, marco, path);
            OpenHotMDBMacro.BufCannel();
            OpenHotPDBMacro.BufCannel();
        }

        [MenuItem(MenuItemOpen, false, 0)]
        public static void BufOpen()
        {
            SetEnable(true, marco, path);
        }
    }

    public class OpenHotPDBMacro : TemplatesMarco
    {
        const string marco = "USE_PDB";
        const string path = "";

        const string MenuItemOpen = "XIL/插件/调试/PDB开启";
        const string MenuItemClose = "XIL/插件/调试/PDB取消";

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
            OpenHotMDBMacro.BufCannel();
            SetEnable(true, marco, path);
        }
    }

    public class OpenHotMDBMacro : TemplatesMarco
    {
        const string marco = "USE_MDB";
        const string path = "";

        const string MenuItemOpen = "XIL/插件/调试/MDB开启";
        const string MenuItemClose = "XIL/插件/调试/MDB取消";

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
            OpenHotPDBMacro.BufCannel();
            SetEnable(true, marco, path);
        }
    }
}