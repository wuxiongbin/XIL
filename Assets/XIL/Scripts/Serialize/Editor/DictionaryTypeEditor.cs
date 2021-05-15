using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using UnityEditor;

namespace wxb.Editor
{
    public class ColorQueue
    {
        public ColorQueue()
        {
            colors = new Color[] { GUI.color, Color.yellow };
        }

        public ColorQueue(params Color[] objs)
        {
            colors = objs;
        }

        Color[] colors = null;

        int index = 0;

        public void Next(bool isSet)
        {
            if (isSet)
                GUI.color = Color.green;
            else
                Next();
        }

        public void Next()
        {
            GUI.color = colors[(index++) % colors.Length];
        }

        public void Recover()
        {
            GUI.color = colors[0];
        }
    }

    public class DictionaryTypeEditor : ITypeGUI
    {
        public DictionaryTypeEditor(System.Type type, FieldInfo fieldInfo)
        {
            this.type = type;
            IL.Help.GetDictionaryKVType(type, fieldInfo, out keyType, out valueType);

            keyTypeGUI = TypeEditor.Get(keyType, null);
            valueTypeGUI = TypeEditor.Get(valueType, null);
            this.fieldInfo = fieldInfo;
        }

        FieldInfo fieldInfo;
        System.Type type;
        System.Type keyType;
        System.Type valueType;
        ITypeGUI keyTypeGUI;
        ITypeGUI valueTypeGUI;

        string GetTypeName()
        {
            return $"Dictionary<{keyType.Name}, {valueType.Name}>";
        }

        public bool OnGUI(object parent, FieldInfo info)
        {
            using (new IndentLevel())
            {
                bool isDirty = false;

                object current = info.GetValue(parent);
                if (current == null)
                {
                    current = IL.Help.Create(info.FieldType);
                    info.SetValue(parent, current);
                    isDirty = true;
                }

                bool isd = false;
                object value = OnGUI(string.Format("{1} {0}", info.Name, GetTypeName()), current, info.FieldType, out isd);
                if (isd)
                    info.SetValue(parent, value);
                return isDirty | isd;
            }
        }

        Dictionary<int, bool> isFoldouts = new Dictionary<int, bool>();

        Dictionary<int, EditorPageBtn> EditorPageBtns = new Dictionary<int, EditorPageBtn>();

        EditorPageBtn GetOrCreate(int hashcode)
        {
            EditorPageBtn epb;
            if (EditorPageBtns.TryGetValue(hashcode, out epb))
                return epb;

            epb = new EditorPageBtn();
            EditorPageBtns.Add(hashcode, epb);
            return epb;
        }

        class KV
        {
            public List<object> keys;
            public List<object> values;

            public System.Collections.IDictionary current;

            public KV(System.Collections.IDictionary current)
            {
                this.current = current;
                keys = new List<object>();
                values = new List<object>();
                Reset();
            }

            void Reset()
            {
                foreach (System.Collections.DictionaryEntry ator in current)
                {
                    keys.Add(ator.Key);
                    values.Add(ator.Value);
                }
            }

            public int Count { get { return keys.Count; } }

            public void Sync()
            {
                current.Clear();
                for (int i = 0; i < keys.Count; ++i)
                    current[keys[i]] = values[i];

                keys.Clear();
                values.Clear();
                Reset();
            }
        }

        Dictionary<object, KV> Dics = new Dictionary<object, KV>();

        KV Get(object value)
        {
            KV kv = null;
            if (Dics.TryGetValue(value, out kv))
                return kv;

            kv = new KV((System.Collections.IDictionary)value);
            Dics.Add(value, kv);
            return kv;
        }

        public object OnGUI(string label, object value, System.Type type, out bool isDirty)
        {
            System.Collections.IDictionary current = value as System.Collections.IDictionary;
            isDirty = false;
            int hashcode = current.GetHashCode();
            var isFoldout = false;
            if (!isFoldouts.TryGetValue(hashcode, out isFoldout))
                isFoldouts.Add(hashcode, isFoldout);

            isFoldout = EditorGUILayout.Foldout(isFoldout, label);
            isFoldouts[hashcode] = isFoldout;
            if (!isFoldout)
                return value;

            using (new IndentLevel())
            {
                KV kv = Get(value);
                EditorGUILayout.BeginHorizontal();
                if (GUILayout.Button("增加"))
                {
                    kv.keys.Add(IL.Help.Create(keyType));
                    kv.values.Add(IL.Help.Create(valueType));
                }
                if (GUILayout.Button("同步"))
                {
                    kv.Sync();
                    isDirty = true;
                }
                if (GUILayout.Button("清除"))
                {
                    kv.keys.Clear();
                    kv.values.Clear();
                    kv.Sync();
                    isDirty = true;
                }
                EditorGUILayout.EndHorizontal();

                int size = kv.Count;
                int begin = 0;
                int end = size;
                if (size >= 30)
                {
                    var epb = GetOrCreate(hashcode);
                    epb.total = current.Count;
                    epb.pageNum = 30;
                    epb.OnRender();

                    begin = epb.beginIndex;
                    end = epb.endIndex;
                }

                ColorQueue cq = new ColorQueue();
                for (int i = begin; i < end; ++i)
                {
                    bool cdk = false;
                    bool cdv = false;

                    cq.Next();
                    object k = keyTypeGUI.OnGUI("key", kv.keys[i], keyType, out cdk);
                    object v = valueTypeGUI.OnGUI("value", kv.values[i], valueType, out cdv);

                    kv.keys[i] = k;
                    kv.values[i] = v;
                }
                cq.Recover();
            }
            return current;
        }

        // 自动赋值
        public bool AutoSetValue(object value, FieldInfo fieldInfo, GameObject root)
        {
            return false;
        }
    }
}
