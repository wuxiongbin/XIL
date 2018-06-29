using wxb;
using System.Collections.Generic;

namespace hot
{
    [ReplaceType(typeof(HelloWorld))]
    public static class HotHelloWorld
    {
        [ReplaceFunction()]
        static int get_GetValue(HelloWorld world)
        {
            return 100001;
        }

        [ReplaceFunction()]
        static void Start(HelloWorld world)
        {
            UnityEngine.Debug.LogFormat("Hot Start(HelloWorld world)");
            RefType refType = new RefType((object)world);
            refType.GetField<List<string>>("onTexts").Add("HotHelloWorld Start");
        }

        [ReplaceFunction()]
        static void OnGUI(HelloWorld world)
        {
            UnityEngine.GUILayout.Label("这里是补丁里的逻辑处理！！！");

            RefType refType = new RefType((object)world);
            var texts = refType.GetField<List<string>>("onTexts");
            foreach (var ator in texts)
                UnityEngine.GUILayout.Label(ator);
        }

        [ReplaceFunction()]
        static void Test(HelloWorld world, RefOutParam<int> refValue, RefOutParam<int> outValue)
        {
            refValue.value = 10000;
            outValue.value = 20000;
        }
    }
}