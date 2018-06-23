using System.IO;
using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace wxb.IL.Editor
{
    public static class HelpEditor
    {
        public static void ForEach<T>(string path, System.Action<T> action, System.Func<string, string, bool> isUsed = null) where T : AssetImporter
        {
            if (string.IsNullOrEmpty(path))
            {
                Debug.Log("非法的目录:" + path);
                return;
            }

            if (path.EndsWith("/"))
                path = path.Substring(0, path.Length - 1);

            if (File.Exists(path))
            {
                // 是个文件
                T assetImporter = AssetImporter.GetAtPath(path) as T;
                if (assetImporter != null)
                {
                    action(assetImporter);
                }
            }
            else
            {
                HashSet<string> guids = new HashSet<string>(AssetDatabase.FindAssets("", new string[] { path }));
                foreach (string guid in guids)
                {
                    string assetPath = AssetDatabase.GUIDToAssetPath(guid);
                    if (assetPath == null)
                        continue;
                    if (!File.Exists(assetPath))
                        continue;

                    if (isUsed != null)
                    {
                        if (!isUsed(assetPath, path))
                            continue;
                    }

                    T assetImporter = AssetImporter.GetAtPath(assetPath) as T;
                    if (assetImporter != null)
                        action(assetImporter);
                }
            }

            AssetDatabase.Refresh();
            AssetDatabase.SaveAssets();

            Resources.UnloadUnusedAssets();
            System.GC.Collect();
        }

        public static void ForEachSelect<T>(System.Action<T> action, System.Func<string, string, bool> isUsed = null) where T : AssetImporter
        {
            ForEach(Selection.objects, action, isUsed);
        }

        public static void ForEach<T>(Object[] objs, System.Action<T> action, System.Func<string, string, bool> isUsed = null) where T : AssetImporter
        {
            foreach (Object o in objs)
            {
                ForEach(AssetDatabase.GetAssetPath(o), action, isUsed);
            }
        }

        public static IEnumerator ForEachSelectASync<T>(System.Action<T> action, System.Func<string, bool> isUsed = null) where T : AssetImporter
        {
            foreach (Object o in Selection.objects)
            {
                IEnumerator itor = ForEachAsync(AssetDatabase.GetAssetPath(o), action, isUsed);
                while (itor.MoveNext())
                    yield return 0;
            }
        }

        public static IEnumerator ForEachAsync<T>(string path, System.Action<T> action, System.Func<string, bool> isUsed = null, IEnumerator ator_end = null) where T : AssetImporter
        {
            if (string.IsNullOrEmpty(path))
            {
                Debug.Log("非法的目录:" + path);
                yield break;
            }

            if (path.EndsWith("/"))
                path = path.Substring(0, path.Length - 1);

            if (File.Exists(path))
            {
                // 是个文件
                T assetImporter = AssetImporter.GetAtPath(path) as T;
                if (assetImporter != null)
                {
                    action(assetImporter);
                }
            }
            else
            {
                HashSet<string> guids = new HashSet<string>(AssetDatabase.FindAssets("", new string[] { path }));
                foreach (string guid in guids)
                {
                    string assetPath = AssetDatabase.GUIDToAssetPath(guid);
                    if (assetPath == null)
                        continue;

                    if (isUsed != null)
                    {
                        if (!isUsed(assetPath))
                            continue;
                    }

                    T assetImporter = AssetImporter.GetAtPath(assetPath) as T;
                    if (assetImporter != null)
                    {
                        action(assetImporter);
                        yield return 0;
                    }
                }
            }

            AssetDatabase.Refresh();
            AssetDatabase.SaveAssets();

            if (ator_end != null)
            {
                while (ator_end.MoveNext())
                    yield return 0;
            }

            Resources.UnloadUnusedAssets();
            System.GC.Collect();
        }
    }
}
