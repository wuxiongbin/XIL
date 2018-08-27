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

        [MenuItem("Assets/LoadHotDLL")]
        static void LoadDLL()
        {
            if (appdomain_ != null)
                return;

            appdomain_ = new AppDomain();
            appdomain.RegisterCrossBindingAdaptor(new CoroutineAdapter());
            System.Type clrType = System.Type.GetType("ILRuntime.Runtime.Generated.CLRBindings");
            if (clrType != null)
                clrType.GetMethod("Initialize").Invoke(null, new object[] { appdomain });

            ILRuntime.Runtime.Generated.UnityEngine_Debug_Binding.Register(appdomain);
            try
            {
                using (System.IO.FileStream fs = new System.IO.FileStream("Data/DyncDll.dll", System.IO.FileMode.Open))
                {
#if USE_PDB
                    using (System.IO.FileStream p = new System.IO.FileStream("Data/DyncDll.pdb", System.IO.FileMode.Open))
                    {
                        appdomain.LoadAssembly(fs, p, new Mono.Cecil.Pdb.PdbReaderProvider());
                    }
#else
                    appdomain_.LoadAssembly(fs);
#endif
                }
            }
            catch (System.Exception ex)
            {
                UnityEngine.Debug.LogException(ex);
            }

            hotMgr.RegDelegate(appdomain_);
            wxb.IL.Help.Init();
        }
    }
}
#endif