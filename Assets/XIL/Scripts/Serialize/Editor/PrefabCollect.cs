using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

namespace wxb.IL.Editor
{
    public class PrefabCollect
    {
        public class Prefab : System.IComparable<Prefab>
        {
            public string assetPath;
            public SortedSet<Prefab> dependencies = new SortedSet<Prefab>(); // 依赖列表

            public int CompareTo(Prefab p)
            {
                return assetPath.CompareTo(p.assetPath);
            }

            public override string ToString()
            {
                return $"{assetPath} depend:{dependencies.Count}";
            }
        }

        static bool ContainsList(SortedSet<Prefab> alls, SortedSet<Prefab> list)
        {
            foreach (var p in list)
            {
                if (!alls.Contains(p))
                    return false;
            }
            return true;
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
                    {
                        ator.dependencies.Add(vv);
                    }
                }
            }

            // 先查找没有任何依赖的
            List<Prefab> resultV = new List<Prefab>();
            SortedSet<Prefab> resultV_set = new SortedSet<Prefab>();

            List<Prefab> current = alls;
            int lastCount = current.Count;
            while (lastCount != 0)
            {
                List<Prefab> last = new List<Prefab>();
                for (int i = 0; i < current.Count; ++i)
                {
                    var c = current[i];
                    if (c.dependencies.Count == 0 || ContainsList(resultV_set, c.dependencies))
                    {
                        resultV.Add(c); // 没有任何依赖的
                        resultV_set.Add(c);
                    }
                    else
                        last.Add(c);
                }

                current = last;
                if (lastCount == current.Count)
                    break;

                lastCount = current.Count;
            }

            if (current.Count != 0)
            {
                // 产生子循环依赖
                foreach (var ator in current)
                {
                    foreach (var dep in ator.dependencies)
                    {
                        if (dep.dependencies.Contains(ator))
                            L.LogError($"{ator}和{dep}相互依赖!");
                    }
                }
            }
            else
            {
                L.Log("没有相互依赖!");
            }

            List<string> assetPaths = new List<string>();
            resultV.ForEach((x) => assetPaths.Add(x.assetPath));
            current.ForEach((x) => assetPaths.Add(x.assetPath));

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