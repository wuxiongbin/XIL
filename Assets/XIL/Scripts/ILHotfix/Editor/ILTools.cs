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
            var ilruntime = "USE_ILRT";
            var ilruntime_editor = "USE_ILRT && UNITY_EDITOR";
            var mono = "USE_ILRT";
            var mono_pdb = "USE_ILRT && USE_PDB";
            var mono_mdb = "USE_ILRT && USE_MDB";

            HelpEditor.ForEach("Assets/", (AssetImporter importer) =>
            {
                var text = System.IO.File.ReadAllText(importer.assetPath);
                text = text.Replace(ilruntime, "USE_ILRT");
                WriteBytes(importer.assetPath, System.Text.Encoding.UTF8.GetBytes(text));
            },
            (string file, string root) =>
            {
                if (file.StartsWith("Assets/Scripts/Logic/") || file.StartsWith("Assets/Arts/HotScripts/"))
                    return false;
                
                return file.EndsWith(".cs", true, null);
            });

            return;
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

        [MenuItem("Assets/IL/脚本宏")]
        static void AddILMarco()
        {
            var ilruntime = "!USE_ILRT";
            AddMarco("Assets/Scripts/Logic/", (file) => 
            {
                if (file.StartsWith("Assets/Scripts/Logic/Config/Sources/"))
                    return null;

                if (file.StartsWith("Assets/Scripts/Logic/NetProto/"))
                    return null;

                return ilruntime;
            });

            AddMarco("Assets/Arts/HotScripts/", (file) =>
            {
                if (file.StartsWith("Assets/Scripts/Logic/Config/Sources/"))
                    return null;

                if (file.StartsWith("Assets/Scripts/Logic/NetProto/"))
                    return null;

                return ilruntime;
            });
        }

        public static string ReadText(byte[] bytes)
        {
            int start = (bytes.Length >= 3 && bytes[0] == 0xEF && bytes[1] == 0xBB && bytes[2] == 0xBF) ? 3 : 0;
            string url = System.Text.Encoding.UTF8.GetString(bytes, start, bytes.Length - start);
            return url;
        }

        public static void WriteBytes(string file, byte[] bytes)
        {
            int start = (bytes.Length >= 3 && bytes[0] == 0xEF && bytes[1] == 0xBB && bytes[2] == 0xBF) ? 3 : 0;
            if (start == 0)
                File.WriteAllBytes(file, bytes);
            else
            {
                var copyBytes = new byte[bytes.Length - 3];
                System.Array.Copy(bytes, start, copyBytes, 0, copyBytes.Length);
                File.WriteAllBytes(file, copyBytes);
            }
        }

        static void AddMarco(string assetPath, System.Func<string, string> fun)
        {
            HelpEditor.ForEach(assetPath, (AssetImporter importer) =>
            {
                var marco = fun(importer.assetPath);
                if (string.IsNullOrEmpty(marco))
                    return;

                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append($"#if {marco}");
                {
                    string start = sb.ToString();

                    string file_text = ReadText(System.IO.File.ReadAllBytes(importer.assetPath));
                    if (file_text.StartsWith(start))
                        return;

                    sb.AppendLine();
                    sb.Append(file_text);
                    sb.AppendLine();
                }
                sb.Append($"#endif");
                WriteBytes(importer.assetPath, System.Text.Encoding.UTF8.GetBytes(sb.ToString()));
            },
            (string file, string root) =>
            {
                return file.EndsWith(".cs", true, null);
            });
        }
    }
}