#if USE_HOT
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[UnityEditor.InitializeOnLoad]
public class DllInitByEditor
{
    static DllInitByEditor()
    {
        wxb.hotMgr.Init();
    }
}
#endif