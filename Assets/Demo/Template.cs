using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Template : MonoBehaviour
{
    private void Awake()
    {
#if USE_HOT
        wxb.hotMgr.Init();
#endif

        Test("strdsfd");
        Test(11323);

        string refValue = "refValue1111";
        string outValue;
        int outIntValue;
        string value = TestResult(ref refValue, out outValue, out outIntValue);
        Debug.LogFormat("TestResult string:{0} refValue:{1} outValue:{2} outIntValue:{3}", value, refValue, outValue, outIntValue);
    }

    void Test<T>(T value)
    {
        Debug.LogFormat("Test:{0} value:{1}", typeof(T).Name, value);
    }

    T TestResult<T>(ref T refValue, out T value, out int iV)
    {
        value = default(T);
        iV = 1000;

        return default(T);
    }
}
