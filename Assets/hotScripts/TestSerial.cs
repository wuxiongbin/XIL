#if !USE_HOT
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using wxb;

[System.Serializable]
public class TestClass
{
    [SerializeField]
    int value2;
    public int value1;
}

public class TestClass1 : TestClass
{
    public string value;
}

[Smart]
[System.Serializable]
public abstract class TestD
{
    public int value;
    public string strValue;
}

[System.Serializable]
public class TestD111 : TestD
{

}

public class TestClass2 : hot.HotBehaviour
{
    public long longValue;
    public string vvValue;
    public int intValue;
    //public long[] longsValue;
    //public int[] intsValue;
    //public int intValue;
    //public long longValue;
    //public float floatValue;
    //public string[] value;
    //public Dictionary<int, string> dics;
    //public Dictionary<TestD, string> vvv;
}

public enum TestEnum
{
    TE1,
    TE2,
    TE2_2 = TE2,
    TE3,
    TE4,
}

public class TestSerial : hot.HotBehaviour
{
    //public int value;
    //public string strValue;

    //[wxb.ILSerializable("hot.TestListVV")]
    //public wxb.RefType hotValue;

    //public List<float[]> vvv;
    //public List<My[]> my2l;
    //public My[][] my2;

    public List<GameObject[]> goss;
    public GameObject[] gos;
    public GameObject go;
    public List<GameObject> goList;
    public Camera camera;
    public Light light;
    public TestEnum testEnum;
    public SeriaBase value;
    public SeriaBase[] values;
    public NoSmartSeriaBase nosmart;
    public NoSmartSeriaBase[] nosmarts;

    public string[] strings;
    public string[][] stringss;

    public int[] ints;
    public int[][] intss;

    public List<string> strList;
    public List<List<string>> strLists;

    public List<int> intList;
    public List<List<int>> intLists;
}

[wxb.Smart]
[System.Serializable]
public class SeriaBase
{
    public int value;
}

[System.Serializable]
public class NoSmartSeriaBase
{
    public int value;
}

[System.Serializable]
public class NoSmartSeria1 : NoSmartSeriaBase
{
    public string value2;
}

[System.Serializable]
public class NoSmartSeria2 : NoSmartSeriaBase
{
    public string[] value3;
}


[System.Serializable]
public class TestSeria : SeriaBase
{
    public int xxx;
    public string values;
}

[System.Serializable]
public class Test1Seria : SeriaBase
{
    public float xxx;
}

[System.Serializable]
public class My
{
    public float xxx;
    public string xxx1;
}
#endif