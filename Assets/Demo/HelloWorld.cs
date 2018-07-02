using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public HelloWorld()
    {

    }

    public void TestFunc()
    {
        Debug.Log("TestFunc");
    }

    public void TestField()
    {
        Debug.Log("TestField");
    }

    List<string> onTexts = new List<string>();
    private void Awake()
    {
#if USE_HOT
        wxb.hotMgr.Init();
#endif
        Debug.LogFormat("GetValue:{0}", GetValue);

        int refValue = 0;
        int outValue = 0;
        Test(ref refValue, out outValue);
        Debug.LogFormat("ref value:{0} out value:{1}", refValue, outValue);

        TestFunc();
    }

    void Test(ref int refValue, out int outValue)
    {
        refValue = 100;
        outValue = 200;
    }

    public int GetValue
    {
        get
        {
            return 0;
        }
    }

    void Start()
    {
        onTexts.Add("HelloWorld Start()");

        TestX("Start");
        TestX(1, 1111);
        TestX(2, "1111");
        TestX();
    }

    void OnEnable()
    {
        onTexts.Add("HelloWorld OnEnable()");
    }

    void OnDisable()
    {
        onTexts.Add("HelloWorld OnDisable()");
    }

    private void OnGUI()
    {
        foreach (var ator in onTexts)
            GUILayout.Label(ator);
    }

    public void TestX(string name)
    {
        onTexts.Add(string.Format("TestX(string:{0})", name));
    }

    public void TestX(int x, long name)
    {
        onTexts.Add(string.Format("TestX(int:{0},long:{1})", x, name));
    }

    public void TestX(int x, string name)
    {
        onTexts.Add(string.Format("TestX(int:{0},string:{1})", x, name));
    }

    public void TestX()
    {
        onTexts.Add("TestX()");
    }
}
