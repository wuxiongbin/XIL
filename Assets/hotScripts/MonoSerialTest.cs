#if !USE_HOT
#pragma warning disable 169
#pragma warning disable 649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace hot
{
    [System.Serializable]
    class TestListVV
    {
        public int value;
        public string name;

        [System.Serializable]
        public class TestSSS
        {
            public int value;
            public string name;
        }

        [SerializeField]
        TestSSS[] ssss;

        [SerializeField]
        List<TestSSS> ssss11;
    }

    [wxb.AutoILMono]
    class MonoSerialTest
    {
        //public GameObject go;
        //public int maxValue;
        //public string nameValue;
        //public int[] values;

        //public List<int> valuesss;
        //public TestListVV[] ttvaluess;
        public List<TestListVV> x1;
        public List<TestListVV.TestSSS> x2;

        void Start()
        {
            wxb.L.Log("Start");
        }
    }
}
#endif
