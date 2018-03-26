namespace wxb
{
    using System.IO;

    public interface IResLoad
    {
        Stream GetStream(string path);
    }

#if UNITY_EDITOR
    // 编辑器下的资源加载
    class EditorResLoad : IResLoad
    {
        public EditorResLoad()
        {
            RootPath = ResourcesPath.dataPath + "/../";
        }

        string RootPath { get; set; }

        Stream IResLoad.GetStream(string path)
        {
            string filepath = RootPath + path;
            if (!File.Exists(filepath))
            {
                return null;
            }

            try
            {
                return new MemoryStream(File.ReadAllBytes(filepath));
            }
            catch (System.Exception ex)
            {
                UnityEngine.Debug.LogException(ex);
            }

            return null;
        }
    }
#endif


    public static class ResLoad
    {
        static IResLoad current = null;

        public static void Set(IResLoad load)
        {
            current = load;
        }

        public static Stream GetStream(string path)
        {
            return current.GetStream(path);
        }
    }
}