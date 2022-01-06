using IL;
using wxb;
using UnityEngine;
using System.Collections.Generic;
#pragma warning disable 169
#pragma warning disable 649

namespace Test
{
    [AutoInitAndRelease]
    public static class RectBinderTest
    {
        static void Log(string log)
        {
            Debug.Log($"RectBinder:{log}");
        }

        static void Init()
        {
            Rect xywh = new Rect(1, 2, 3, 4);
            Rect source = new Rect(xywh);
            Rect position_size = new Rect(new Vector2(1, 2), new Vector2(5, 6));

            Log($"xywh:{xywh}");
            Log($"source:{source}");
            Log($"position_size:{position_size}");
            Log($"Rect.zero:{Rect.zero}");

            Log($"xywh.yMax:{xywh.yMax}");
            Log($"xywh.xMax:{xywh.xMax}");
            Log($"xywh.yMin:{xywh.yMin}");
            Log($"xywh.xMin:{xywh.xMin}");
            Log($"xywh.x:{xywh.x}");
            Log($"xywh.height:{xywh.height}");
            Log($"xywh.width:{xywh.width}");
            Log($"xywh.max:{xywh.max}");
            Log($"xywh.min:{xywh.min}");
            Log($"xywh.center:{xywh.center}");
            Log($"xywh.position:{xywh.position}");
            Log($"xywh.y:{xywh.y}");
            Log($"xywh.size:{xywh.size}");

            Log($"MinMaxRect:{Rect.MinMaxRect(3, 4, 5, 6)}");
            Log($"NormalizedToPoint:{Rect.NormalizedToPoint(xywh, new Vector2(0, 1))}");
            Log($"PointToNormalized:{Rect.PointToNormalized(xywh, new Vector2(0, 1))}");
            Log($"Contains:{xywh.Contains(new Vector3(1, 2, 3), true)}");
            Log($"Contains:{xywh.Contains(new Vector3(1, 2, 3))}");
            Log($"Contains:{xywh.Contains(new Vector2(1, 2))}");
            Log($"Equals:{xywh.Equals(source)}");
            Log($"Overlaps:{xywh.Overlaps(source, true)}");
            Log($"Overlaps:{xywh.Overlaps(source)}");

            xywh.Set(5, 6, 7, 8);
            Log($"== :{xywh == source}");
            Log($"!= :{xywh != source}");
        }
    }
}