using IL;
using wxb;
using UnityEngine;
using System.Collections.Generic;
#pragma warning disable 169
#pragma warning disable 649

namespace Test
{
    [AutoInitAndRelease]
    public static class Color32BinderTest
    {
        static void Log(string log)
        {
            Debug.Log($"Color32Binder:{log}");
        }

        static void Init()
        {
            Color32 color32 = new Color32(1, 2, 3, 4);
            Log($"color32:{color32}");
            Log($"Lerp:{(Color32.Lerp(new Color32(100, 100, 100, 100), new Color32(200, 200, 200, 200), 0.5f))}");
            Log($"LerpUnclamped:{(Color32.LerpUnclamped(new Color32(100, 100, 100, 100), new Color32(200, 200, 200, 200), 0.5f))}");
        }
    }
}