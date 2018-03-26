using wxb;
using System.Collections.Generic;

namespace hot
{
    public static class HotTemplate
    {
        public static void Reg()
        {
            hotMgr.ReplaceFunction(typeof(Template), "Test", typeof(HotTemplate).GetMethod("Test", hotMgr.bindingFlags));
            hotMgr.ReplaceFunction(typeof(Template), "TestResult", typeof(HotTemplate).GetMethod("TestResult", hotMgr.bindingFlags));
        }

        static void Test(List<object> values)
        {
            Template instance = values[0] as Template;
            object value = values[1];
            var type = value.GetType();
            UnityEngine.Debug.LogFormat("type:{0} value:{1}", type.FullName, value.ToString());
        }

        static object TestResult(List<object> values)
        {
            Template template = values[0] as Template;
            object refValue = values[1];
            UnityEngine.Debug.LogFormat("refValue:{0}", refValue.ToString());

            if (refValue.GetType().FullName == typeof(string).FullName)
            {
                string refSV = (string)refValue;
                refSV = "Hot Value";

                values[1] = refSV;
                values.Add("Hot Value Out"); // 
                values.Add(32323);
                return "Hot TestResult Result";
            }

            return null;
        }
    }
}