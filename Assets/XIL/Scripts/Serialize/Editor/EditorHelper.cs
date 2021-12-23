using UnityEditor;
using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;

namespace wxb.IL.Editor
{
    public class EditorHelper
    {
        public static IEnumerator ForEachSelectASync(System.Func<string, System.Func<bool>> isUsed, System.Action onend)
        {
            return ForEachSelectASync(Selection.objects, isUsed, onend);
        }

        public static IEnumerator ForEachSelectASync(Object[] objects, System.Func<string, System.Func<bool>> isUsed, System.Action onend)
        {
            foreach (Object o in objects)
            {
                IEnumerator itor = ForEachAsync(AssetDatabase.GetAssetPath(o), isUsed);
                while (itor.MoveNext())
                    yield return 0;
            }

            onend?.Invoke();
        }

        public static IEnumerator ForEachAsync(string path, System.Func<string, System.Func<bool>> func)
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
                var isNext = func(path);
                if (isNext != null)
                {
                    while (isNext())
                        yield return 0;
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

                    var isNext = func(assetPath);
                    if (isNext != null)
                    {
                        while (isNext())
                            yield return 0;
                    }
                }
            }
        }

        public static IEnumerator ForEachAsync(string debugText, IList<string> files, System.Action<string> func, System.Action onEnd)
        {
            int cnt = files.Count;
            for (int i = 0; i < cnt; ++i)
            {
                string assetPath = files[i];
                if (assetPath == null)
                    continue;

                func(assetPath);
                Debug.Log($"assetPath:{assetPath} allfile:{i}/{cnt} {debugText}");
                yield return 0;
            }

            onEnd?.Invoke();
        }
    }
}