using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

namespace PackTool
{
    public class MacroDefine
    {
        public MacroDefine()
        {
            Load();
        }

        List<string> MacroList = new List<string>(); // 当前的宏列表

        public bool isDirty { get; protected set; }// 是否需要保存

        public bool has(string macro)
        {
            if (MacroList.Contains(macro))
                return true;

            return false;
        }

        public bool Add(string macro)
        {
            if (MacroList.Contains(macro))
                return false;

            isDirty = true;
            MacroList.Add(macro);
            return true;
        }

        public bool Remove(string macro)
        {
            bool ishas = false;
            if ((ishas = MacroList.Remove(macro)))
                isDirty = true;
            return ishas;
        }

        public void RemoveAll()
        {
            MacroList.Clear();
            isDirty = true;
        }

        // 加载当前宏定义
        public void Load()
        {
            isDirty = false;
            MacroList.Clear();
            string[] macros = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup).Split(';');
            MacroList.AddRange(macros);
        }

        // 保存当前宏定义
        public bool Save()
        {
            if (isDirty)
            {
                isDirty = false;
                string text = string.Join(";", MacroList.ToArray());
                wxb.L.Log("重置宏:" + text);
                PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, text);
                return true;
            }

            return false;
        }
    }
}