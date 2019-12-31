using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoPlayControl.SDKInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoPlayControl.SDKInterface.Tests
{
    [TestClass()]
    public class SDK_TDWYSDKTests
    {
        public SDK_TDWYSDKTests() 
        {
            SDK_TDWYSDK.NetClient_Startup_V4(3000, 6000, 0);
        }
        [TestMethod()]
        public void NetClient_Logon_V4Test()
        {
            //LogonPara
            //SDK_TDWYSDK.NetClient_Logon_V4(0,)
            Assert.Fail();
        }
    }
}