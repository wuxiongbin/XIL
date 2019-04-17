using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestReplaceFunction
{
    public void Test1()
    {

    }

    public void Test2()
    {

    }

    public void Test3()
    {

    }

    public void Test4()
    {

    }

    public void Test5()
    {

    }
}

public class HelloWorld : MonoBehaviour
{
    public class TestNeast1
    {
        public int value = 0;
    }

    class TestNeast2
    {
        public int value = 0;
    }

    static void TestXX(int p1, int p2, int p3, int p4, string p5, string p6, string p7, string p8, Vector3 p9, Vector2 p10, Vector4 p11)
    {

    }

    static void TestNo()
    {

    }

    static int TestInt()
    {
        return 0;
    }

    public HelloWorld()
    {

    }

    public void TestFunc()
    {
        wxb.L.Log("TestFunc");
    }

    public void TestField()
    {
        wxb.L.Log("TestField");
    }

    List<string> onTexts = new List<string>();

#if UNITY_EDITOR && USE_HOT
    static bool Check()
    {
        var fields = typeof(HelloWorld).GetFields();
        foreach (var field in fields)
        {
            if (field.FieldType == typeof(IL.DelegateBridge))
            {
                return true;
            }
        }

        Debug.LogError("编辑器如果要测试，请点击\"XIL/Hotfix Inject In Editor\"!");
        return false;
    }
#endif

    private void Awake()
    {
#if USE_HOT
#if UNITY_EDITOR
        Check();
#endif
        wxb.hotMgr.Init();
#endif
        wxb.L.LogFormat("GetValue:{0}", GetValue);

        int refValue = 0;
        int outValue = 0;
        Test(ref refValue, out outValue);
        wxb.L.LogFormat("ref value:{0} out value:{1}", refValue, outValue);

        TestFunc();

        TestXX(1, 2, 3, 4, "5", "6", "7", "8", new Vector3(1, 2, 3), new Vector2(4, 5), new Vector4(7, 8, 9, 10));
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
            return 2222;
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
