using wxb;
using System.Collections.Generic;

namespace hot
{
    public static class HotHelloWorld
    {
        public static void Reg()
        {
            hotMgr.ReplaceFunction(typeof(HelloWorld), "Start", typeof(HotHelloWorld).GetMethod("Start", hotMgr.bindingFlags));
            hotMgr.ReplaceFunction(typeof(HelloWorld), "OnGUI", typeof(HotHelloWorld).GetMethod("OnGUI", hotMgr.bindingFlags));
            hotMgr.ReplaceFunction(typeof(HelloWorld), "Test", typeof(HotHelloWorld).GetMethod("Test", hotMgr.bindingFlags));
            hotMgr.ReplaceFunction(typeof(HelloWorld), "get_GetValue", typeof(HotHelloWorld).GetMethod("get_GetValue", hotMgr.bindingFlags));
        }

        static int get_GetValue(HelloWorld world)
        {
            return 100001;
        }

        static void Start(HelloWorld world)
        {
            RefType refType = new RefType((object)world);
            refType.GetField<List<string>>("onTexts").Add("HotHelloWorld Start");
        }

        static void OnGUI(HelloWorld world)
        {
            UnityEngine.GUILayout.Label("这里是补丁里的逻辑处理！！！");

            RefType refType = new RefType((object)world);
            var texts = refType.GetField<List<string>>("onTexts");
            foreach (var ator in texts)
                UnityEngine.GUILayout.Label(ator);
        }

        static void Test(HelloWorld world, RefOutParam<int> refValue, RefOutParam<int> outValue)
        {
            refValue.value = 10000;
            outValue.value = 20000;
        }
    }
}