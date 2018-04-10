using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoPlayControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
            int intResult = SDK_XMSDK.H264_DVR_Login_Cloud("93c4de073e976f89", 34567, "admin", "", out OutDev, out nError, "");
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

        [TestMethod()]
        public void H264_DVR_PTZControlTest()
        {
            int iLogin = -1;
            int intResult = 0;
            bool bolResult = false;
            SDKState.XMSDK_Init();
            H264_DVR_DEVICEINFO OutDev;
            int nError = 0;
            iLogin = SDK_XMSDK.H264_DVR_Login_Cloud("4bba3f71cdd143cb", 34567, "admin", "123456", out OutDev, out nError, "");
            H264_DVR_CLIENTINFO playstru = new H264_DVR_CLIENTINFO();
            playstru.nChannel = 0;
            //playstru.nChannel = 0;
            playstru.nStream = 0;
            playstru.nMode = 1;
            playstru.hWnd = IntPtr.Zero;
            int m_iPlayhandle = SDK_XMSDK.H264_DVR_RealPlay(Convert.ToInt32(iLogin), ref playstru);
            bolResult = SDK_XMSDK.H264_DVR_PTZControl(iLogin, 0, Convert.ToInt32(SDK_XMSDK.PTZ_ControlType.PAN_LEFTTOP), false, 10);
            //bolResult = SDK_XMSDK.H264_DVR_PTZControl(1, 0,1, false, 4);
            //(long lLoginID, int nChannelNo, long lPTZCommand, bool bStop DEF_PARAM(0), long lSpeed DEF_PARAM(4));
            Thread.Sleep(1000);
            SDK_XMSDK.H264_DVR_PTZControl(iLogin, 0, Convert.ToInt32(SDK_XMSDK.PTZ_ControlType.PAN_RIGTHDOWN), true, 0);
            //SDK_XMSDK.H264_DVR_PTZControl(iLogin, 1, Convert.ToInt64(SDK_XMSDK.PTZ_ControlType.TILT_DOWN), false, 100);
            //bool bolResult = SDK_XMSDK.H264_DVR_PTZControl(Convert.ToInt32(lLogin), CurrentCameraInfo.Channel, Convert.ToInt32(XMVideoPtzType), !bolStart, CurrentVideoPlaySet.PTZSpeed);
            SDK_XMSDK.H264_DVR_Logout(Convert.ToInt32(intResult));
            SDKState.XMSDK_Release();
            Assert.IsTrue(bolResult);
        }

        [TestMethod()]
        public void H264_DVR_PTZControlExTest()
        {
            int iLogin = -1;
            int intResult = 0;
            bool bolResult = false;
            SDKState.XMSDK_Init();
            H264_DVR_DEVICEINFO OutDev;
            int nError = 0;
            iLogin = SDK_XMSDK.H264_DVR_Login_Cloud("4bba3f71cdd143cb", 34567, "admin", "123456", out OutDev, out nError, "");
            //H264_DVR_CLIENTINFO playstru = new H264_DVR_CLIENTINFO();
            //playstru.nChannel = 0;
            //playstru.nStream = 0;
            //playstru.nMode = 1;
            //playstru.hWnd = IntPtr.Zero;
            //int m_iPlayhandle = SDK_XMSDK.H264_DVR_RealPlay(Convert.ToInt32(iLogin), ref playstru);
            bolResult = SDK_XMSDK.H264_DVR_PTZControlEx(iLogin, 0, Convert.ToInt32(SDK_XMSDK.PTZ_ControlType.EXTPTZ_POINT_MOVE_CONTROL), 1, 0, 0, false);
            SDK_XMSDK.H264_DVR_Logout(Convert.ToInt32(intResult));
            SDKState.XMSDK_Release();
            Assert.IsTrue(bolResult);
        }
    }
}