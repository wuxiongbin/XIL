#if USE_HOT && UNITY_EDITOR
using System.Linq;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace wxb
{
    public static class GenerateCLRBinding
    {
        [UnityEditor.MenuItem("XIL/CLR绑定")]
        static void Generate()
        {
            HashSet<System.Type> types = new HashSet<System.Type>();

            types.Add(typeof(int));
            types.Add(typeof(float));
            types.Add(typeof(long));
            types.Add(typeof(object));
            types.Add(typeof(string));
            types.Add(typeof(System.Array));
            types.Add(typeof(Vector2));
            types.Add(typeof(Vector3));
            types.Add(typeof(Vector4));
            types.Add(typeof(Rect));
            types.Add(typeof(RectInt));
            types.Add(typeof(Vector2Int));
            types.Add(typeof(Vector3Int));
            types.Add(typeof(Quaternion));
            types.Add(typeof(GameObject));
            types.Add(typeof(Mathf));
            types.Add(typeof(Ray));
            types.Add(typeof(Application));
            types.Add(typeof(Object));
            types.Add(typeof(Transform));
            types.Add(typeof(RectTransform));
            types.Add(typeof(Texture));
            types.Add(typeof(Texture2D));
            types.Add(typeof(Shader));
            types.Add(typeof(Renderer));
            types.Add(typeof(Graphics));
            types.Add(typeof(RenderSettings));
            types.Add(typeof(RenderTexture));
            types.Add(typeof(MeshRenderer));
            types.Add(typeof(SkinnedMeshRenderer));
            types.Add(typeof(SpriteRenderer));
            types.Add(typeof(Mesh));
            types.Add(typeof(UnityEngine.Animator));
            types.Add(typeof(RuntimeAnimatorController));
            types.Add(typeof(AnimationClip));
            types.Add(typeof(AnimationEvent));
            types.Add(typeof(Physics));
            types.Add(typeof(Collider));
            types.Add(typeof(BoxCollider));
            types.Add(typeof(Material));
            types.Add(typeof(QualitySettings));
            types.Add(typeof(ParticleSystem));
            //types.Add(typeof(ParticleSystem.LightsModule));
            //types.Add(typeof(ParticleSystem.TriggerModule));
            //types.Add(typeof(ParticleSystem.CollisionModule));
            //types.Add(typeof(ParticleSystem.NoiseModule));
            //types.Add(typeof(ParticleSystem.ExternalForcesModule));
            //types.Add(typeof(ParticleSystem.RotationBySpeedModule));
            //types.Add(typeof(ParticleSystem.RotationOverLifetimeModule));
            //types.Add(typeof(ParticleSystem.SizeBySpeedModule));
            //types.Add(typeof(ParticleSystem.SizeOverLifetimeModule));
            //types.Add(typeof(ParticleSystem.ColorBySpeedModule));
            //types.Add(typeof(ParticleSystem.ColorOverLifetimeModule));
            //types.Add(typeof(ParticleSystem.ForceOverLifetimeModule));
            //types.Add(typeof(ParticleSystem.InheritVelocityModule));
            //types.Add(typeof(ParticleSystem.TrailModule));
            //types.Add(typeof(ParticleSystem.LimitVelocityOverLifetimeModule));
            //types.Add(typeof(ParticleSystem.EmitParams));
            //types.Add(typeof(ParticleSystem.MinMaxGradient));
            //types.Add(typeof(ParticleSystem.Burst));
            //types.Add(typeof(ParticleSystem.Particle));
            //types.Add(typeof(ParticleSystem.TextureSheetAnimationModule));
            //types.Add(typeof(ParticleSystem.SubEmittersModule));
            //types.Add(typeof(ParticleSystem.ShapeModule));
            //types.Add(typeof(ParticleSystem.EmissionModule));
            //types.Add(typeof(ParticleSystem.MainModule));
            //types.Add(typeof(ParticleSystem.MinMaxCurve));
            //types.Add(typeof(ParticleSystem.VelocityOverLifetimeModule));
            //types.Add(typeof(ParticleSystem.CustomDataModule));
            types.Add(typeof(MonoBehaviour));
            types.Add(typeof(Component));
            types.Add(typeof(Behaviour));
            types.Add(typeof(Color));
            types.Add(typeof(Resources));
            types.Add(typeof(AssetBundle));
            types.Add(typeof(Camera));
            types.Add(typeof(SystemInfo));
            types.Add(typeof(Time));
            types.Add(typeof(wxb.hotMgr));
            types.Add(typeof(wxb.IL.Help));
            types.Add(typeof(wxb.RefType));
            types.Add(typeof(System.Type));
            types.Add(typeof(System.Reflection.MethodInfo));
            types.Add(typeof(System.Reflection.FieldInfo));
            types.Add(typeof(System.Reflection.PropertyInfo));
            //types.Add(typeof(Debug));
            //types.Add(typeof(Log));

            //所有DLL内的类型的真实C#类型都是ILTypeInstance
            types.Add(typeof(List<ILRuntime.Runtime.Intepreter.ILTypeInstance>));
            types.Add(typeof(List<object>));
            types.Add(typeof(List<int>));
            types.Add(typeof(List<string>));
            types.Add(typeof(List<long>));
            types.Add(typeof(List<uint>));
            types.Add(typeof(List<ulong>));

            types.Add(typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance));
            types.Add(typeof(System.Array));

            types.Add(typeof(System.Net.Sockets.TcpClient));
            types.Add(typeof(System.Net.Sockets.Socket));

            types.Add(typeof(System.Math));
            types.Add(typeof(System.Convert));
            types.Add(typeof(System.DateTime));
            types.Add(typeof(System.TimeSpan));
            types.Add(typeof(System.Text.StringBuilder));
            types.Add(typeof(Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, ILRuntime.Runtime.Intepreter.ILTypeInstance>));
            types.Add(typeof(Dictionary<int, ILRuntime.Runtime.Intepreter.ILTypeInstance>));
            types.Add(typeof(Dictionary<uint, ILRuntime.Runtime.Intepreter.ILTypeInstance>));
            types.Add(typeof(Dictionary<long, ILRuntime.Runtime.Intepreter.ILTypeInstance>));
            types.Add(typeof(Dictionary<ulong, ILRuntime.Runtime.Intepreter.ILTypeInstance>));
            types.Add(typeof(Dictionary<string, ILRuntime.Runtime.Intepreter.ILTypeInstance>));
            types.Add(typeof(Dictionary<object, ILRuntime.Runtime.Intepreter.ILTypeInstance>));

            types.Add(typeof(Dictionary<object, object>));
            types.Add(typeof(Dictionary<int, object>));
            types.Add(typeof(Dictionary<uint, object>));
            types.Add(typeof(Dictionary<long, object>));
            types.Add(typeof(Dictionary<ulong, object>));
            types.Add(typeof(Dictionary<string, object>));

            //types.Add(typeof(System.Text.RegularExpressions.Regex));
            //types.Add(typeof(System.Text.RegularExpressions.Group));
            //types.Add(typeof(System.Text.RegularExpressions.Match));
            //types.Add(typeof(System.Text.RegularExpressions.CaptureCollection));
            //types.Add(typeof(System.Text.RegularExpressions.GroupCollection));
            types.Add(typeof(Sprite));
            types.Add(typeof(UnityEngine.UI.LayoutElement));
            types.Add(typeof(UnityEngine.UI.Text));
            types.Add(typeof(UnityEngine.UI.Image));
            types.Add(typeof(UnityEngine.UI.Graphic));
            types.Add(typeof(UnityEngine.SceneManagement.SceneManager));
            types.Add(typeof(UnityEngine.EventSystems.UIBehaviour));
            types.Add(typeof(UnityEngine.MonoBehaviour));
            types.Add(typeof(UnityEngine.Color));
            types.Add(typeof(HashSet<long>));
            types.Add(typeof(HashSet<int>));
            types.Add(typeof(HashSet<string>));
            types.Add(typeof(System.Linq.Enumerable));
            types.Add(typeof(Canvas));
            types.Add(typeof(Matrix4x4));
            types.Add(typeof(UnityEngine.Video.VideoPlayer));
            types.Add(typeof(System.Enum));
            types.Add(typeof(Screen));
            types.Add(typeof(wxb.Hotfix));

            types.UnionWith(ValueTypes);

            DllInitByEditor.LoadDLL();
            ILRuntime.Runtime.CLRBinding.BindingCodeGenerator.CrawlAppdomain(wxb.DllInitByEditor.appdomain);
            types.Remove(typeof(UnityEngine.Debug));
            types.Remove(typeof(System.Activator));
            ILRuntime.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(
                types.ToList(), 
                "Assets/XIL/Auto/CLR",
                null, null, ValueTypes);
        }

        static List<System.Type> ValueTypes = new List<System.Type>
        {
            typeof(Vector2),
            typeof(Vector3),
            typeof(Quaternion),

            typeof(Vector4),
            typeof(Vector2Int),
            typeof(Vector3Int),
            typeof(Rect),
            typeof(RectInt),
            typeof(Matrix4x4),
            typeof(Color),
            typeof(Color32),
        };

        [UnityEditor.MenuItem("XIL/生成跨域继承适配")]
        static void GenerateCross()
        {
            GenerateCrossBindingAdapterCode(new System.Type[]
            {
                typeof(IComparer<int>),
            },
            "Assets/XIL/Auto/CrossAdaptor");
        }

        [UnityEditor.MenuItem("XIL/编译运行时脚本")]
        public static void TestRuntimeScript()
        {
            string filepath = ResourcesPath.LocalBasePath + "ScriptOnly";
            UnityEditor.BuildPipeline.BuildStreamedSceneAssetBundle(new string[] { }, filepath, UnityEditor.EditorUserBuildSettings.activeBuildTarget, UnityEditor.BuildOptions.BuildScriptsOnly);
            if (System.IO.File.Exists(filepath))
                System.IO.File.Delete(filepath);
        }

        static void SaveFile(string file, string text)
        {
            if (System.IO.File.Exists(file))
                System.IO.File.Delete(file);
            else
                System.IO.Directory.CreateDirectory(file.Substring(0, file.LastIndexOf('/')));

            System.IO.File.WriteAllText(file, text, System.Text.Encoding.UTF8);
        }

        static void GenerateCrossBindingAdapterCode(IList<System.Type> types, string root)
        {
            List<string> clsNames = new List<string>();
            foreach (var type in types)
            {
                string text = ILRuntime.Runtime.Enviorment.CrossBindingCodeGenerator.GenerateCrossBindingAdapterCode(
                    type, 
                    "wxb", 
                    out var clsName);
                clsNames.Add(clsName);
                SaveFile($"{root}/{clsName}Adapter.cs", text);
            }

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("#if USE_HOT");
            sb.AppendLine("using ILRuntime.Runtime.Enviorment;");
            sb.AppendLine("namespace wxb");
            sb.AppendLine("{");
            sb.AppendLine("    public static class AllAdapter");
            sb.AppendLine("    {");
            sb.AppendLine("        public static void Register(AppDomain appdomain)");
            sb.AppendLine("        {");
            foreach (var ator in clsNames)
                sb.AppendLine($"            appdomain.RegisterCrossBindingAdaptor(new {ator}Adapter());");
            sb.AppendLine("        }");
            sb.AppendLine("        public static void Release()");
            sb.AppendLine("        {");
            foreach (var ator in clsNames)
                sb.AppendLine($"            {ator}Adapter.Adapter.ReleaseStaticField();");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            sb.AppendLine("#endif");

            SaveFile($"{root}/AllAdapter.cs", sb.ToString());
        }
    }
}
#endif