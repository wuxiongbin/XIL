#if !USE_HOT
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace hot
{
    class TestListVV
    {
        public int value;
    }

    [wxb.AutoILMono]
    class MonoSerialTest
    {
        public int maxValue;
        public string nameValue;
        public int[] values;

        public List<int> valuesss;
        public List<TestListVV> ttvaluesss;

        void Start()
        {
            Debug.Log("Start");
        }
    }
}
#endif
