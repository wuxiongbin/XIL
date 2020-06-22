using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[wxb.AutoILMono]
public class TestSerial
{
    //public int value;
    //public string strValue;

    //[wxb.ILSerializable("hot.TestListVV")]
    //public wxb.RefType hotValue;

    public List<float[]> vvv;
    public List<My[]> my2l;
    public My[][] my2;

    public SeriaBase value;
}

[wxb.Smart]
[System.Serializable]
public class SeriaBase
{
    public int value;
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