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
    public class SDK_XMSDKTests
    {
        [TestMethod()]
        public void H264_DVR_Login_CloudTest()
        {
            SDKState.XMSDK_Init();
            H264_DVR_DEVICEINFO OutDev;
            int nError = 0;
            int intResult = SDK_XMSDK.H264_DVR_Login_Cloud("93c4de073e976f89", 34567, "admin", "", out OutDev, out nError, SocketStyle.TCPSOCKET);
            SDK_XMSDK.H264_DVR_Logout(Convert.ToInt32(intResult));
            SDKState.XMSDK_Release();
            Assert.AreEqual(intResult, 1);

        }

        [TestMethod()]
        public void H264_DVR_LoginTest()
        {
            
            SDKState.XMSDK_Init();
            H264_DVR_DEVICEINFO OutDev;
            int nError = 0;
            int intResult = SDK_XMSDK.H264_DVR_Login("192.168.2.165", 34567, "admin", "", out OutDev, out nError, SocketStyle.TCPSOCKET);
            SDK_XMSDK.H264_DVR_Logout(Convert.ToInt32(intResult));
            SDKState.XMSDK_Release();
            Assert.AreEqual(intResult, 1);
        }
    }
}