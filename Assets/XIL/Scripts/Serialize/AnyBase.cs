// 类型序列化，主要用来支持预置体嵌套，u3d真无语，byte[]数据类型也会进行预置体嵌套修改混合,造成byte[]数据错乱，解析失败
// 最好在打包机上，定义下CloseNested这个宏，保持打包出来的AB里不带TypeSerialize数据
#if !CloseNested //

namespace wxb.Nested
{
    using System.Collections.Generic;

    [System.Serializable]
    public abstract class AnyBase
    {
        public string dataKey;
        public string typeName; // 类型名
        public byte valueType; // 值类型
        public byte typeFlags; // 类型标识

        public string baseValue; // 基础类型的值
        public UnityEngine.Object unityObj; // unity类型值

        public int listCount; // 列表数量
        public byte elementTypeFlags;

        public AnyBase clone()
        {
            var self = CreateSelf();
            CopyTo(self);
            {
                var items = this.items;
                int cnt = items.Count;
                List<AnyBase> cloneItems = new List<AnyBase>();
                for (int i = 0; i < cnt; ++i)
                    cloneItems.Add(items[i].clone());
                self.items = cloneItems;
            }

            return self;
        }

        protected abstract AnyBase CreateSelf();
        protected abstract AnyBase CreateItem();

        // value = this
        public void CopyTo(AnyBase value)
        {
            value.dataKey = dataKey;
            value.typeName = typeName;
            value.valueType = valueType;
            value.typeFlags = typeFlags;
            value.baseValue = baseValue;
            value.unityObj = unityObj;
            value.listCount = listCount;
            value.elementTypeFlags = elementTypeFlags;
        }

        public abstract List<AnyBase> items { get; set; }

        public abstract AnyBase Create(string key, byte typeFlags);
        public abstract bool Get(string key, out AnyBase ab);

        // 当前深度
        public abstract int depth { get; }

        protected static void Blend(AnyBase now, AnyBase old)
        {
            if (old == null)
                return;

            var newFields = now.items;
            var oldFields = old.items;
            int nowCnt = newFields.Count;
            int oldCnt = oldFields.Count;

            Dictionary<string, AnyBase> keyToIndexs = new Dictionary<string, AnyBase>();
            for (int i = 0; i < nowCnt; ++i)
                keyToIndexs.Add(newFields[i].dataKey, newFields[i]);

            List<AnyBase> news = new List<AnyBase>();
            for (int i = 0; i < oldCnt; ++i)
            {
                var od = oldFields[i];
                if (keyToIndexs.TryGetValue(od.dataKey, out var v))
                {
                    // 新值与老值，都有值
                    news.Add(v);
                    Blend(v, od);
                    keyToIndexs.Remove(od.dataKey);
                }
                else
                {
                    // 新的没有值，旧的有值，保留旧的
                    news.Add(od);
                }
            }

            foreach (var ator in keyToIndexs)
                news.Add(ator.Value);

            now.items = news;
        }
    }

    public abstract class AnyID<T> : AnyBase where T : AnyBase, new()
    {
        [UnityEngine.SerializeField]
        List<T> fields;

        public override List<AnyBase> items
        {
            get
            {
                if (fields == null)
                    return new List<AnyBase>();

                return new List<AnyBase>(fields);
            }

            set
            {
                if (fields == null)
                    fields = new List<T>();
                else
                    fields.Clear();

                if (value != null)
                {
                    foreach (var ator in value)
                    {
                        var t = ator as T;
                        if (t == null)
                            UnityEngine.Debug.LogError("items add null!");
                        fields.Add(t);
                    }
                }
            }
        }

        public override AnyBase Create(string key, byte typeFlags)
        {
            T ab = new T();
            ab.dataKey = key;
            ab.typeFlags = typeFlags;
            if (fields == null)
                fields = new List<T>();
            fields.Add(ab);
            return ab;
        }

        public override bool Get(string key, out AnyBase ab)
        {
            int cnt = fields.Count;
            for (int i = 0; i < cnt; ++i)
            {
                if (fields[i].dataKey == key)
                {
                    ab = fields[i];
                    return true;
                }
            }

            ab = null;
            return false;
        }
        protected override AnyBase CreateItem()
        {
            return new T();
        }

        protected override AnyBase CreateSelf()
        {
            switch (depth)
            {
                case 0: return new Any0();
                case 1: return new Any1();
                case 2: return new Any2();
                case 3: return new Any3();
                case 4: return new Any4();
                case 5: return new Any5();
                case 6: return new Any6();
                case 7: return new Any7();
            }

            throw new System.Exception($"AnyBase.CreateSelf {depth}");
        }
    }

    [System.Serializable]
    public class Any0 : AnyID<Any1>
    {
        public override int depth { get { return 0; } }
        public static void Blend(Any0 now, Any0 old)
        {
            AnyBase.Blend(now, old);
        }
    }

    [System.Serializable]
    public class Any1 : AnyID<Any2>
    {
        public override int depth { get { return 1; } }
    }

    [System.Serializable]
    public class Any2 : AnyID<Any3>
    {
        public override int depth { get { return 2; } }
    }

    [System.Serializable]
    public class Any3 : AnyID<Any4>
    {
        public override int depth { get { return 3; } }
    }

    [System.Serializable]
    public class Any4 : AnyID<Any5>
    {
        public override int depth { get { return 4; } }
    }

    [System.Serializable]
    public class Any5 : AnyID<Any6>
    {
        public override int depth { get { return 5; } }
    }

    [System.Serializable]
    public class Any6 : AnyID<Any7>
    {
        public override int depth { get { return 6; } }
    }

    [System.Serializable]
    public class Any7 : AnyID<AnyEnd>
    {
        public override int depth { get { return 7; } }
    }

    [System.Serializable]
    public class AnyEnd : AnyBase
    {
        public override int depth { get { return 8; } }

        public override List<AnyBase> items 
        {
            get
            {
                throw new System.Exception("AnyEnd.items Get");
            }

            set
            {
                throw new System.Exception("AnyEnd.items set");
            }
        }

        public override AnyBase Create(string key, byte typeFlags)
        {
            throw new System.Exception("AnyEnd.Create");
        }

        public override bool Get(string key, out AnyBase ab)
        {
            throw new System.Exception("AnyEnd.Get");
        }

        protected override AnyBase CreateItem()
        {
            throw new System.Exception("AnyEnd.CreateItem()");
        }

        protected override AnyBase CreateSelf()
        {
            return new AnyEnd();
        }
    }
}
#endif