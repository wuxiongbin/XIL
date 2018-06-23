using System.IO;
using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace wxb.IL.Editor
{
    static class ILTools
    {
        [MenuItem("Assets/IL/添加热更新宏")]
        static void AddHotMacro()
        {
            HelpEditor.ForEachSelect((AssetImporter importer) => 
            {
                string text = string.Format("#if USE_HOT\r{0}\r#endif", File.ReadAllText(importer.assetPath));
                File.WriteAllText(importer.assetPath, text);
            }, 
            (string file, string root) => 
            {
                return file.EndsWith(".cs", true, null) && !file.Contains("/Editor/");
            });
        }

        [MenuItem("Assets/IL/MPB宏")]
        static void AddMPBMacro()
        {
            HelpEditor.ForEachSelect((AssetImporter importer) =>
            {
                string text = string.Format("#if USE_PDB\r{0}\r#endif", File.ReadAllText(importer.assetPath));
                File.WriteAllText(importer.assetPath, text);
            },
            (string file, string root) =>
            {
                return file.EndsWith(".cs", true, null);
            });
        }
    }
}