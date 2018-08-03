using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace wxb.Editor
{
    public class EditorPageBtn
    {
        public int total = 0;
        public int current = 0;
        public int pageNum = 50; // 一页的个数

        public int TotalPage
        {
            get
            {
                int page = total / pageNum;
                if (total % pageNum == 0)
                    return page;

                return page + 1;
            }
        }

        public int beginIndex
        {
            get
            {
                current = Mathf.Clamp(current, 1, TotalPage);
                return Mathf.Max(0, ((current - 1) * pageNum));
            }
        }

        public int endIndex
        {
            get
            {
                return Mathf.Min(total, beginIndex + pageNum);
            }
        }

        protected Vector2 ScrollPosition;

        public void ForEach(System.Action<int> fun, bool isScroll = false)
        {
            if (total == 0)
                return;

            if (isScroll)
            {
                ScrollPosition = EditorGUILayout.BeginScrollView(ScrollPosition);
            }

            for (int i = beginIndex; i < endIndex; ++i)
            {
                fun(i);
            }

            if (isScroll)
            {
                EditorGUILayout.EndScrollView();
            }
        }

        public void OnRender()
        {
            if (TotalPage <= 1)
                return;

            // 没有页数
            int tmp = current;
            EditorGUILayout.BeginHorizontal();
            using (new IndentLevel())
            {
                using (new GUIColor(Color.cyan))
                {
                    GUILayout.Space(UnityEditor.EditorGUI.indentLevel * 10);
                    if (GUILayout.Button("上一页"))
                        --tmp;
                    GUILayout.Button(string.Format("{0} / {1}", current, TotalPage), GUILayout.Width(60));
                    if (GUILayout.Button("下一页"))
                        ++tmp;

                    current = Mathf.Clamp(tmp, 1, TotalPage);
                }
            }
            EditorGUILayout.EndHorizontal();
        }
    }
}