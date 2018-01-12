using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoPlayControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoPlayControl.Tests
{
    [TestClass()]
    public class SDK_JCSDKTests
    {
        [TestMethod()]
        public void JCSDK_InitSDKTest()
        {
            bool bolResult = SDK_JCSDK.JCSDK_InitSDK(0);
            Assert.IsTrue(bolResult);
        }
    }
}