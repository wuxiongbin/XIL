using IL;
using wxb;
using UnityEngine;
using System.Collections.Generic;
#pragma warning disable 169
#pragma warning disable 649

namespace hot
{
    [ReplaceType(typeof(TestInterface))] 
    public static class HotTestInterface
    {
        static Hotfix __Hotfix_ITestInterface_Test;
        [ReplaceFunction((System.Type)null, "__Hotfix_ITestInterface.Test", "__Hotfix_ITestInterface_Test")]
        static void ITestInterface_Test(TestInterface self)
        {
            Debug.Log("HotTestInterface.ITestInterface_Test");
            __Hotfix_ITestInterface_Test.Invoke(self);
        }
    }
}