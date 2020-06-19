#if USE_HOT && UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
using ILRuntime.Runtime.Enviorment;
using wxb;

namespace wxb
{
    [EditorClass]
    public class DllInitByEditor
    {
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

        [MenuItem("Assets/LoadHotDLL")]
        static void LoadDLL()
        {
            Release();

            appdomain_ = new AppDomain();
            appdomain.RegisterCrossBindingAdaptor(new CoroutineAdapter());
            System.Type clrType = System.Type.GetType("ILRuntime.Runtime.Generated.CLRBindings");
            if (clrType != null)
                clrType.GetMethod("Initialize").Invoke(null, new object[] { appdomain });

            ILRuntime.Runtime.Generated.UnityEngine_Debug_Binding.Register(appdomain);
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

            hotMgr.RegDelegate(appdomain_);
            wxb.IL.Help.Init();
        }
    }
}
#endif