#if !USE_HOT
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
 
[wxb.AutoILMono]
public class TestClass2 : TestClass
{
    public string[] value;
}

public enum TestEnum
{
    TE1,
    TE2,
    TE2_2 = TE2,
    TE3,
    TE4,
}

[wxb.AutoILMono]
public class TestSerial
{
    //public int value;
    //public string strValue;

    //[wxb.ILSerializable("hot.TestListVV")]
    //public wxb.RefType hotValue;

    //public List<float[]> vvv;
    //public List<My[]> my2l;
    //public My[][] my2;

    public TestEnum testEnum;
    //public SeriaBase value;
    //public SeriaBase[][] values;
    //public NoSmartSeriaBase[][] nosmart;
}

[wxb.Smart]
[System.Serializable]
public class SeriaBase
{
    public int value;
}

[wxb.Smart]
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