using System.IO;
using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace wxb.IL.Editor
{
    static class ILTools
    {
        [MenuItem("Assets/IL/ILRuntime插件宏")]
        static void AddMonoMarco()
        {
            var ilruntime = "USE_HOT";
            var ilruntime_editor = "USE_HOT && UNITY_EDITOR";
            var mono = "USE_HOT\r#define READ_ONLY";
            var mono_pdb = "USE_HOT && USE_PDB\r#define READ_ONLY";
            var mono_mdb = "USE_HOT && USE_MDB\r#define READ_ONLY";

            AddMarco("Assets/XIL/ILSource/", 
                (file) => 
                {
                    if (file.StartsWith("Assets/XIL/ILSource/ILRuntime/"))
                    {
                        if (file.StartsWith("Assets/XIL/ILSource/ILRuntime/Runtime/CLRBinding/"))
                            return ilruntime_editor;
                        return ilruntime;
                    }
                    else if (file.StartsWith("Assets/XIL/ILSource/Mono.Cecil/"))
                    {
                        if (file.StartsWith("Assets/XIL/ILSource/Mono.Cecil/symbols/mdb"))
                            return mono_mdb;
                        else if (file.StartsWith("Assets/XIL/ILSource/Mono.Cecil/symbols/pdb"))
                            return mono_pdb;
                        return mono;
                    }

                    return ilruntime;
                });
        }

        static void AddMarco(string assetPath, System.Func<string, string> fun)
        {
            HelpEditor.ForEach(assetPath, (AssetImporter importer) =>
            {
                var marco = fun(importer.assetPath);
                if (string.IsNullOrEmpty(marco))
                    return;

                string start = string.Format("#if {0}\r", marco);
                string file_text = File.ReadAllText(importer.assetPath);
                if (file_text.StartsWith(start))
                    return;

                string text = string.Format("{0}{1}\r#endif", start, file_text);
                File.WriteAllText(importer.assetPath, text);
            },
            (string file, string root) =>
            {
                return file.EndsWith(".cs", true, null);
            });
        }
    }
}