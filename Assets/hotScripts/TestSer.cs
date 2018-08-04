#if !USE_HOT
#pragma warning disable 169
#pragma warning disable 649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace hot
{
    [System.Serializable]
    class XXX : System.IEquatable<XXX>
    {
        public long id;
        public string x;
        public string y;

        public bool Equals(XXX other)
        {
            if (id != other.id)
                return false;

            if (x != other.x)
                return false;

            if (y != other.y)
                return false;

            return true;
        }
    }

    [System.Serializable]
    class TEEE1
    {
        public long id;
        //public string name;
        public string text;
    }

    [System.Serializable]
    class TEEE : System.IEquatable<TEEE>
    {
        public long id;
        public string name;
        public string text;

        public XXX xxx;
        //public XXX[] xxxs;

        public static TEEE Range()
        {
            TEEE t = new TEEE();
            t.id = UnityEngine.Random.Range(0, int.MaxValue);
            t.name = "324rr23dc";
            t.text = "sdfasdfsad";

            t.xxx = new XXX()
            {
                id = 32332,
                x = "3232",
                y = "2341"
            };

            return t;
        }

        public bool Equals(TEEE other)
        {
            if (id != other.id)
                return false;

            if (name != other.name)
                return false;

            if (text != other.text)
                return false;

            if (!xxx.Equals(other.xxx))
                return false;

            return true;
        }
    }

    class TestSer1
    {
        [SerializeField]
        TEEE1 teee;

        [SerializeField]
        TEEE1[] teees;
    }

    class TestSer
    {
        [SerializeField]
        TEEE teee;

        [SerializeField]
        TEEE[] teees;

        [SerializeField]
        string name;

        [SerializeField]
        string[] names;

        [SerializeField]
        int intValue;

        [SerializeField]
        int[] intValues;

        [SerializeField]
        uint uintValue;

        [SerializeField]
        uint[] uintValues;

        [SerializeField]
        short shortValue;

        [SerializeField]
        short[] shortValues;

        [SerializeField]
        ushort ushortValue;

        [SerializeField]
        ushort[] ushortValues;

        [SerializeField]
        char charValue;

        [SerializeField]
        char[] charValues;

        [SerializeField]
        float floatValue;

        [SerializeField]
        float[] floatValues;

        [SerializeField]
        double doubleValue;

        [SerializeField]
        double[] doubleValues;

        [SerializeField]
        byte byteValue;

        [SerializeField]
        byte[] byteValues;

        [SerializeField]
        sbyte sbyteValue;

        [SerializeField]
        byte[] sbyteValues;
    }
}
#endif