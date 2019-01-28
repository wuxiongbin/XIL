using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

#if UNITY_EDITOR
[UnityEditor.InitializeOnLoad]
#endif
// 资源路径
public static class ResourcesPath
{
    static ResourcesPath()
    {
        dataPath = Application.dataPath;

        streamingAssetsPath =
#if UNITY_EDITOR
            dataPath + "/StreamingAssets/";
#else
            Application.streamingAssetsPath + "/";
#endif

#if UNITY_EDITOR
        string projectPath = dataPath.Substring(0, dataPath.Length - 7).Replace('\\', '/');
#endif

        LocalBasePath =
#if UNITY_EDITOR
            projectPath + "/Pack/" + PlatformKey + "/";
#elif (UNITY_ANDROID || UNITY_IPHONE) && (!UNITY_EDITOR)
            Application.persistentDataPath + "/";
#else
            Application.dataPath.Replace('\\', '/') + "/../Pack/" + PlatformKey + "/";
#endif

        LocalDataPath = LocalBasePath + "Data/";

        LocalTempPath =
#if UNITY_EDITOR
            projectPath + "/Pack/" + PlatformKey + "/Temp/";
#elif (UNITY_ANDROID || UNITY_IPHONE) && (!UNITY_EDITOR)
            Application.temporaryCachePath + "/";
#else
            Application.dataPath.Replace('\\', '/') + "/../Pack/" + PlatformKey + "/Temp/";
#endif

        WritePath = 
#if UNITY_EDITOR
        Application.dataPath.Replace('\\', '/') + "/../tempLocalData/";
#elif (UNITY_ANDROID || UNITY_IPHONE) && (!UNITY_EDITOR)
        Application.persistentDataPath + "/";
#else
        Application.dataPath.Replace('\\', '/') + "/../";
#endif

#if (UNITY_ANDROID || UNITY_IPHONE) && !UNITY_EDITOR
        wxb.L.LogFormat("streamingAssetsPath:{0}", streamingAssetsPath);
        wxb.L.LogFormat("LocalBasePath:{0}", LocalBasePath);
        wxb.L.LogFormat("LocalDataPath:{0}", LocalDataPath);
        wxb.L.LogFormat("LocalTempPath:{0}", LocalTempPath);
#endif
    }

    static public readonly string dataPath;

    static public readonly string streamingAssetsPath;

    public const string PlatformKey =
#if UNITY_IPHONE
        "iPhone";
#elif UNITY_ANDROID
        "Android";
#elif UNITY_STANDALONE_WIN
        "StandaloneWindows";
#elif UNITY_STANDALONE_OSX
		"StandaloneOSX";
#else
        "Unknown";
#endif

    // 返回一个可写的路径
    static public readonly string WritePath;
    static public readonly string LocalBasePath;
    static public readonly string LocalDataPath;
    static public readonly string LocalTempPath;
}