using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Linq;

namespace wxb.IL.Editor
{
    public class PrefabCollect
    {
        public class Prefab
        {
            public string assetPath;
            public HashSet<Prefab> dependencies = new HashSet<Prefab>(); // 依赖列表
        }

        public static List<string> Collect(List<string> assets)
        {
            Dictionary<string, Prefab> keys = new Dictionary<string, Prefab>();
            List<Prefab> alls = new List<Prefab>();
            int cnt = assets.Count;
            for (int i = 0; i < cnt; ++i)
            {
                var prefab = new Prefab() { assetPath = assets[i] };
                alls.Add(prefab);
                keys.Add(prefab.assetPath, prefab);
            }

            // 开始排序
            foreach (var ator in alls)
            {
                var deps = AssetDatabase.GetDependencies(ator.assetPath);
                foreach (var dep in deps)
                {
                    if (!dep.EndsWith(".prefab") || dep == ator.assetPath)
                        continue;
                    if (keys.TryGetValue(dep, out var vv))
                        ator.dependencies.Add(vv);
                }
            }

            // 先查找没有任何依赖的
            List<Prefab> resultV = new List<Prefab>();
            HashSet<Prefab> resultV_set = new HashSet<Prefab>();

            while (alls.Count != 0)
            {
                List<Prefab> last = new List<Prefab>();
                for (int i = 0; i < alls.Count; ++i)
                {
                    if (alls[i].dependencies.Count == 0 || resultV_set.IsSubsetOf(alls[i].dependencies))
                        resultV.Add(alls[i]); // 没有任何依赖的
                    else
                        last.Add(alls[i]);
                }

                alls = last;
            }

            List<string> assetPaths = new List<string>();
            resultV.ForEach((x) => assetPaths.Add(x.assetPath));

            return assetPaths;
        }

        public static List<string> Collect(Object[] objs, System.Func<string, bool> isAdd)
        {
            HashSet<string> aps = new HashSet<string>();
            int cnt = objs.Length;
            for (int i = 0; i < cnt; ++i)
            {
                var assetPath = AssetDatabase.GetAssetPath(objs[i]);
                if (System.IO.File.Exists(assetPath))
                {
                    aps.Add(assetPath);
                }
                else
                {
                    HashSet<string> guids = new HashSet<string>(AssetDatabase.FindAssets("", new string[] { assetPath }));
                    foreach (var ator in guids)
                    {
                        assetPath = AssetDatabase.GUIDToAssetPath(ator);
                        if (assetPath == null)
                            continue;
                        aps.Add(assetPath);
                    }
                }
            }

            var vv = new List<string>(aps.Count);
            foreach (var ator in aps)
            {
                if (!ator.EndsWith(".prefab") || !isAdd(ator))
                    continue;

                vv.Add(ator);
            }

            return Collect(vv);
        }
    }
}