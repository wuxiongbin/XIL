using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace PackTool
{
    public class TemplatesMarco
    {
        public static void SetEnable(bool isenable, string marco, string path)
        {
            MacroDefine macroDefine = new MacroDefine();
            if (isenable)
            {
                macroDefine.Add(marco);
            }
            else
            {
                macroDefine.Remove(marco);
            }

            AssetDatabase.Refresh();
            macroDefine.Save();
        }

        public static void RemoveMacro(params string[] marcos)
        {
            MacroDefine macroDefine = new MacroDefine();
            foreach (var ator in marcos)
                macroDefine.Remove(ator);

            AssetDatabase.Refresh();
            macroDefine.Save();
        }

        public static void AddMacro(params string[] marcos)
        {
            MacroDefine macroDefine = new MacroDefine();
            foreach (var ator in marcos)
                macroDefine.Add(ator);

            AssetDatabase.Refresh();
            macroDefine.Save();
        }

        static void ToggleBug(string marco, string path)
        {
            MacroDefine macroDefine = new MacroDefine();
            if (macroDefine.has(marco))
            {
                // 移除
                macroDefine.Remove(marco);
            }
            else
            {
                macroDefine.Add(marco);
            }

            AssetDatabase.Refresh();
            macroDefine.Save();
        }
    }
}