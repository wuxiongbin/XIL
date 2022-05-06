using UnityEditor;
using System.Reflection;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

#if USE_ILRT
using ILRuntime.Runtime.Intepreter;
#endif

namespace wxb.IL.Editor
{
    public static class ILMenuItem
    {
#if !CloseNested
        //[UnityEditor.MenuItem("Assets/IL/生成MethodInfo调用")]
        static void GenMethodInfo()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("using System.Reflection;");
            sb.AppendLine();
            sb.AppendLine("namespace wxb");
            sb.AppendLine("{");
            sb.AppendLine("    public static class RefMethodInfo");
            sb.AppendLine("    {");
            sb.AppendLine("        static object InvokeMethod(this MethodInfo methodInfo, object instance, object[] objs)");
            sb.AppendLine("        {");
            sb.AppendLine("            try");
            sb.AppendLine("            {");
            sb.AppendLine("                return methodInfo.Invoke(instance, objs);");
            sb.AppendLine("            }");
            sb.AppendLine("            catch (System.Exception ex)");
            sb.AppendLine("            {");
            sb.AppendLine("                L.LogError($\"InvokeMethod instance :{(instance == null ? \"null\" : IL.Help.GetInstanceType(instance).Name)} name:{methodInfo.Name}\");");
            sb.AppendLine("                L.LogException(ex);");
            sb.AppendLine("                return null;");
            sb.AppendLine("            }");
            sb.AppendLine("        }");

            sb.AppendLine("        public static object InvokeMethod(this MethodInfo methodInfo, object instance)");
            sb.AppendLine("        {");
            sb.AppendLine("            using (var obj = new global::IL.EmptyObjs())");
            sb.AppendLine("            {");
            sb.AppendLine("                return InvokeMethod(methodInfo, instance, obj.objs);");
            sb.AppendLine("            }");
            sb.AppendLine("        }");

            int count = 10;
            for (int i = 1; i < count; ++i)
            {
                sb.Append("        public static object InvokeMethod(this MethodInfo methodInfo, object instance, ");
                string param = null;
                {
                    int start = sb.Length;
                    System.Text.StringBuilder pp = new System.Text.StringBuilder();
                    for (int j = 0; j < i; ++j)
                    {
                        if (j != 0)
                        {
                            sb.Append(", ");
                            pp.Append(", ");
                        }
                        sb.Append($"object p{j + 1}");
                        pp.Append($"p{j + 1}");
                    }

                    param = pp.ToString();
                }

                sb.AppendLine(")");

                sb.AppendLine("        {");
                sb.AppendLine($"            using (var obj = new global::IL.Objects({param}))");
                sb.AppendLine("            {");
                sb.AppendLine("                return InvokeMethod(methodInfo, instance, obj.objs);");
                sb.AppendLine("            }");
                sb.AppendLine("        }");
            }

            sb.AppendLine("    }");
            sb.AppendLine("}");

            System.IO.File.WriteAllText("Assets/XIL/Scripts/RefMethodInfo.cs", sb.ToString());
        }

        [UnityEditor.MenuItem("Assets/IL/测试依赖顺序")]
        static void TestPrefabCollect()
        {
            var files = PrefabCollect.Collect(Selection.objects, isNeedCheck);
        }

        [UnityEditor.MenuItem("Assets/IL/移除空组件")]
        static void RemoveEmptyPrefab()
        {
            var files = PrefabCollect.Collect(Selection.objects, (file) => 
            {
                return isNeedCheck(AssetDatabase.LoadAssetAtPath<GameObject>(file), (obj, cd) => 
                {
                    if (cd == null || string.IsNullOrEmpty(cd.TypeName) || IL.Help.GetType(cd.TypeName) == null)
                        return true;

                    return false;
                });
            });

            SaveSelectPrefab(files, "移除空组件", (file, obj, customizeData) =>
            {
                if (customizeData == null || string.IsNullOrEmpty(customizeData.TypeName) || IL.Help.GetType(customizeData.TypeName) == null)
                {
                    Object.DestroyImmediate(obj);
                    return true;
                }
                return false;
            }, null);
        }

        static bool isNeedCheck(GameObject go, System.Func<Object, CustomizeData, bool> check)
        {
            var serials = go.GetComponentsInChildren<ISerializationCallbackReceiver>(true);
            int cnt = serials.Length;
            if (cnt == 0)
                return false;

            for (int i = 0; i < cnt; ++i)
            {
                var obj = serials[i] as Object;
                var type = obj.GetType();
                var customizeDataField = IL.Help.GetField(type, "customizeData");
                if (customizeDataField != null)
                {
                    var customizeData = customizeDataField.GetValue(obj) as CustomizeData;
                    if (customizeData != null)
                    {
                        if (check(obj, customizeData))
                            return true;
                    }
                }
            }

            return false;
        }

        static bool isNeedCheck(string file)
        {
            return isNeedCheck(AssetDatabase.LoadAssetAtPath<GameObject>(file), (obj, cd) => true);
        }

        static void SaveSelectPrefab(IList<string> files, string debugText, System.Func<string, Object, CustomizeData, bool> onSet, System.Action onend)
        {
            var start = System.DateTime.Now;
            Debug.Log($"开始执行:{debugText}");
            GlobalCoroutine.StartCoroutine(EditorHelper.ForEachAsync(debugText, files, (file) =>
            {
                bool isOk = PrefabModify.Modify(file, (go) =>
                {
                    var serials = go.GetComponentsInChildren<ISerializationCallbackReceiver>(true);
                    int cnt = serials.Length;
                    if (serials.Length == 0)
                        return;

                    bool isDirty = false;
                    for (int i = 0; i < cnt; ++i)
                    {
                        var obj = serials[i] as Object;
                        var type = obj.GetType();
                        var customizeDataField = IL.Help.GetField(type, "customizeData");
                        if (customizeDataField != null)
                        {
                            var customizeData = customizeDataField.GetValue(obj) as CustomizeData;
                            if (customizeData != null)
                            {
                                if (onSet(file, obj, customizeData))
                                    isDirty = true;
                            }
                        }
                    }

                    if (isDirty)
                        EditorUtility.SetDirty(go);
                });
            },
            ()=> 
            {
                var now = System.DateTime.Now;
                Debug.Log($"{debugText}执行完毕!用时:{(now-start).TotalSeconds}s");
                onend?.Invoke();
            }));
        }

        [UnityEditor.MenuItem("Assets/IL/慎重/一键操作")]
        static void OneAll()
        {
            var files = PrefabCollect.Collect(Selection.objects, isNeedCheck);

            var start = System.DateTime.Now;
            // 1 先以anyObject存储的数据保存到bytes当中
            SaveToBytes(files, "开始第1步", () =>
            {
                // 2 再清除所有anyValue数据
                CleraAnyValue(files, "开始第2步", () =>
                {
                    // 3 以bytes数据来恢复anyValue数据
                    SaveToAnyValue(files, "开始第3步", () =>
                    {
                        var now = System.DateTime.Now;
                        Debug.Log($"一键操作完成用时:{(now - start).TotalSeconds}分!");
                    });
                });
            });
        }

        [UnityEditor.MenuItem("Assets/IL/预置体重保存")]
        [UnityEditor.MenuItem("Assets/IL/慎重/第1步(AnyObject->bytes)")]
        static void Step1()
        {
            var files = PrefabCollect.Collect(Selection.objects, isNeedCheck);
            SaveToBytes(files, "AnyObject->bytes", () => { });
        }

        [UnityEditor.MenuItem("Assets/IL/慎重/第2步(清除AnyObject)")]
        static void Step2()
        {
            var files = PrefabCollect.Collect(Selection.objects, isNeedCheck);
            CleraAnyValue(files, "清除AnyObject", null);
        }

        [UnityEditor.MenuItem("Assets/IL/慎重/第3步(bytes->AnyObject)")]
        static void Step3()
        {
            var files = PrefabCollect.Collect(Selection.objects, isNeedCheck);
            SaveToAnyValue(files, "bytes->AnyObject", null);
        }

        [UnityEditor.MenuItem("Assets/IL/慎重/智能检测")]
        static void Smart()
        {
            var files = PrefabCollect.Collect(Selection.objects, isNeedCheck);
            SaveSelectPrefab(files, "智能检测", (file, obj, cd) =>
            {
                if (cd.anyValue == null || string.IsNullOrEmpty(cd.anyValue.dataKey))
                {
                    // anyValue数据无效
                    cd.BytesToAnyValue();
                    Debug.LogWarning(file);
                    return true;
                }
                return false;
            }, null);
        }

        static void SaveToBytes(IList<string> files, string debugText, System.Action onEnd)
        {
            SaveSelectPrefab(files, debugText, (file, obj, cd) =>
            {
                cd.AnyValueToBytes();
                return true;
            }, onEnd);
        }

        static void CleraAnyValue(IList<string> files, string debugText, System.Action onEnd)
        {
            SaveSelectPrefab(files, debugText, (file, obj, cd) =>
            {
                if (PrefabUtility.IsPartOfPrefabAsset(obj) || PrefabUtility.IsPartOfPrefabInstance(obj))
                {
                    SerializedObject so = new SerializedObject(obj);
                    var anyValue = so.FindProperty("customizeData").FindPropertyRelative("anyValue");
                    PrefabUtility.RevertPropertyOverride(anyValue, InteractionMode.AutomatedAction);
                    so.ApplyModifiedProperties();
                    EditorUtility.SetDirty(obj);
                    so.Dispose();
                }
                else
                {
                    cd.ResetNested();
                }
                return true;
            }, onEnd);
        }

        static void SaveToAnyValue(IList<string> files, string debugText, System.Action onEnd)
        {
            SaveSelectPrefab(files, debugText, (file, obj, cd) =>
            {
                cd.BytesToAnyValue();
                return true;
            }, onEnd);
        }

        [UnityEditor.MenuItem("Assets/IL/检查所有序列化的字符串")]
        static void CheckString()
        {
            Help.Init();

            HashSet<System.Type> baseTypes = new HashSet<System.Type>()
            {
#if !USE_ILRT

#endif
            };

            Help.ForEach((type) =>
            {
                if ((type.FullName.StartsWith("NG.") && type.IsSerializable) || Help.isType(type, baseTypes))
                    Help.GetSerializeField(type);
            });

            SortedSet<string> texts = new SortedSet<string>();
            Dictionary<int, string> hashCodes = new Dictionary<int, string>();
            void Add(string name)
            {
                if (texts.Add(name))
                {
                    hashCodes.Add(name.GetHashCode(), name);
                }
            }

            Add("x");
            Add("y");
            Add("z");
            Help.ForEachCacheType((ct) =>
            {
                var sl = ct.Serializes;
                if (sl == null || sl.Count == 0)
                    return;
                foreach (var ator in sl)
                {
                    Add(ator.Name);
                }
            });

            WriteAutoFieldNames(texts);
            L.Log($"count:{texts.Count}");
        }

        // 生成自动写入字段
        static void WriteAutoFieldNames(SortedSet<string> currents)
        {
            List<string> nows = new List<string>();
            {
                List<string> removes = new List<string>(); // 已经不用的
                string[] olds = ConstString.AllFieldNames;
                Dictionary<string, int> nameToIndexs = new Dictionary<string, int>();
                for (int i = 0; i < olds.Length; ++i)
                {
                    nameToIndexs.Add(olds[i], i);
                    if (!currents.Contains(olds[i]))
                        removes.Add(olds[i]);
                }

                nows.AddRange(olds);
                foreach (var ator in currents)
                {
                    if (nameToIndexs.ContainsKey(ator))
                        continue; // 已经存在的
                    nows.Add(ator); // 新的
                }

                L.Log($"已经不用的key值:{removes.Count} {string.Join("\n", removes)}");
            }

            // 重新保存
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("#if UNITY_EDITOR");
            sb.AppendLine("namespace wxb");
            sb.AppendLine("{");
            sb.AppendLine("    public static partial class ConstString");
            sb.AppendLine("    {");
            sb.AppendLine("        static ConstString()");
            sb.AppendLine("        {");
            sb.AppendLine("            var fieldNames = new string[] ");
            sb.AppendLine("            {");
            int cnt = nows.Count;
            for (int i = 0; i < cnt; ++i)
                sb.AppendLine($"                \"{nows[i]}\", // {i}");
            sb.AppendLine("            };");
            sb.AppendLine("            Set(fieldNames);");
            sb.AppendLine("        }");
            sb.AppendLine("        public static string[] AllFieldNames { get { return FieldNames; } }");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            sb.AppendLine("#endif");
            System.IO.File.WriteAllText("Assets/XIL/Scripts/Serialize/ConstStringAuto.cs", sb.ToString());

            // 写入到序列文件当中，运行时使用
            {
                string file = "Data/FieldNames.bytes";
                var ms = new MemoryStream(1024);
                var writer = new BinaryWriter(ms);
                writer.Write((short)nows.Count);
                foreach (var ator in nows)
                    writer.Write(ator);
                File.WriteAllBytes(file, ms.ToArray());
                ms.Close();
                writer.Close();
            }
        }
#endif
    }
}