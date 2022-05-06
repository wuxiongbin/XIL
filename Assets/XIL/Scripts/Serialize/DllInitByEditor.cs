#if USE_ILRT && UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
#if USE_ILRT
using ILRuntime.Runtime.Enviorment;
#endif
using wxb;

namespace wxb
{
    [EditorClass]
    public class DllInitByEditor
    {
#if !USE_ILRT
        static System.Reflection.Assembly assembly;
        public static void Init()
        {
            if (assembly != null)
                return;

            assembly = System.Reflection.Assembly.Load(System.IO.File.ReadAllBytes("Data/DyncDll.dll"), System.IO.File.ReadAllBytes("Data/DyncDll.pdb"));
        }
#else
        static AppDomain appdomain_;

        public static void Release()
        {
            if (appdomain_ != null)
            {
                appdomain_ = null;
                IL.Help.ReleaseAll();
            }
        }

        public static AppDomain appdomain
        {
            get
            {
                if (hotMgr.appdomain != null)
                {
                    return hotMgr.appdomain;
                }
                else if (appdomain_ == null)
                {
                    LoadDLL();
                }

                return appdomain_;
            }
        }

        static MemoryStream ReadFile(string file)
        {
            if (!System.IO.File.Exists(file))
                return null;

            var bytes = System.IO.File.ReadAllBytes(file);
            var ms = new MemoryStream(bytes);
            return ms;
        }

        [MenuItem("Assets/IL/LoadHotDLL")]
        public static void LoadDLL()
        {
            Release();

            appdomain_ = new AppDomain();
            hotMgr.RegDelegate(appdomain_);
            try
            {
                var fs = ReadFile("Data/DyncDll.dll");
#if USE_PDB
                var p = ReadFile("Data/DyncDll.pdb");
                appdomain.LoadAssembly(fs, p, new ILRuntime.Mono.Cecil.Pdb.PdbReaderProvider());
#elif USE_MDB
                var p = ReadFile("Data/DyncDll.mdb");
                appdomain.LoadAssembly(fs, p, new ILRuntime.Mono.Cecil.Mdb.MdbReaderProvider());
#else
                appdomain_.LoadAssembly(fs);
#endif
            }
            catch (System.Exception ex)
            {
                wxb.L.LogException(ex);
            }

            wxb.IL.Help.Init();
        }
#endif
    }
}
#endif