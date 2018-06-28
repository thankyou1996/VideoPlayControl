using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoPlayControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using static VideoPlayControl.SDK_HikClientSDK;
using System.Threading;

namespace VideoPlayControl.Tests
{
    [TestClass()]
    public class SDK_HikClientSDKTests
    {
        public SDK_HikClientSDKTests()
        {
            SDK_HikClientSDK.NET_DVR_Init();
        }
        [TestMethod()]
        public void NET_DVR_FindPictureTest()
        {
            PublicClassCurrency.VideoInfo vInfo = TestDataSource.TestDataSource.GetHikData2();
            SDK_HikClientSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new SDK_HikClientSDK.NET_DVR_DEVICEINFO_V30();
            //登录设备
            int m_lUserID = SDK_HikClientSDK.NET_DVR_Login_V30(vInfo.DVSAddress, vInfo.DVSConnectPort, vInfo.UserName, vInfo.Password, ref DeviceInfo);

            NET_DVR_FIND_PICTURE_PARAM para = new NET_DVR_FIND_PICTURE_PARAM();
            para.dwSize = (uint)Marshal.SizeOf(para);
            para.lChannel = 1;
            para.byFileType = 0;
            DateTime tim = DateTime.Parse("2018-05-30 21:41:30");
            //DateTime timStart = DateTime.Now.AddSeconds(-70);
            DateTime timStart = tim.AddSeconds(-70);
            SDK_HikClientSDK.NET_DVR_TIME Stime = new SDK_HikClientSDK.NET_DVR_TIME();
            Stime.dwYear = uint.Parse(timStart.Year.ToString());
            Stime.dwMonth = uint.Parse(timStart.Month.ToString());
            Stime.dwDay = uint.Parse(timStart.Day.ToString());
            Stime.dwHour = uint.Parse(timStart.Hour.ToString());
            Stime.dwMinute = uint.Parse(timStart.Minute.ToString());
            Stime.dwSecond = uint.Parse(timStart.Second.ToString());
            para.struStartTime = Stime;
            //DateTime timEnd = DateTime.Now.AddSeconds(-60);
            DateTime timEnd = tim.AddSeconds(-60);
            SDK_HikClientSDK.NET_DVR_TIME Etime = new SDK_HikClientSDK.NET_DVR_TIME();
            Etime.dwYear = uint.Parse(timEnd.Year.ToString());
            Etime.dwMonth = uint.Parse(timEnd.Month.ToString());
            Etime.dwDay = uint.Parse(timEnd.Day.ToString());
            Etime.dwHour = uint.Parse(timEnd.Hour.ToString());
            Etime.dwMinute = uint.Parse(timEnd.Minute.ToString());
            Etime.dwSecond = uint.Parse(timEnd.Second.ToString());
            para.struStopTime = Etime;
            int lFindHandle = SDK_HikClientSDK.NET_DVR_FindPicture(m_lUserID, ref para);
            NET_DVR_FIND_PICTURE lpFindData = new NET_DVR_FIND_PICTURE();
            bool bolEnd = false;
            string strPath = @"C:\SHIKE_Video\9999\Pic";
            int Temp_intCount = 1;
            DateTime Temp_tim = DateTime.Now.AddYears(-10);
            while (!bolEnd)
            {
                long lResult = NET_DVR_FindNextPicture(lFindHandle, ref lpFindData);
                switch (lResult)
                {
                    case 1000:
                        //下载图片
                        NET_DVR_TIME t = lpFindData.struTime;
                        StringBuilder sb = new StringBuilder();
                        DateTime timPic = ConvertToDateTime(lpFindData.struTime);
                        if (Temp_tim == timPic)
                        {
                            Temp_intCount++;
                        }
                        else
                        {
                            Temp_tim = timPic;
                            Temp_intCount = 1;
                        }

                        string strFileName = lpFindData.sFileName;
                        sb.Append(timPic.ToString("yyyyMMddHHmmss") + "_" + Temp_intCount + "_");
                        sb.Append(strFileName.Substring(0, strFileName.IndexOf("_")));
                        string strFilePath = strPath + "\\" + sb.ToString() + ".jpg";
                        NET_DVR_GetPicture(m_lUserID, lpFindData.sFileName, strFilePath);
                        Thread.Sleep(30);
                        break;
                    case 1002:
                        Thread.Sleep(30);
                        break;
                    case 1001:  //未查找到 
                    case 1003:  //查找结束
                    case 1004:  //查找文件异常
                        bolEnd = true;
                        NET_DVR_CloseFindPicture(lFindHandle);
                        break;
                }
            }
            //Thread.Sleep(5000);

            Assert.Fail();
        }

        [TestMethod()]
        public void ConvertToDateTimeTest()
        {

            Assert.Fail();
        }

        [TestMethod()]
        public void ConvertToNetTimeTest()
        {
            DateTime tim = DateTime.Now;
            NET_DVR_TIME t1 = SDK_HikClientSDK.ConvertToNetTime(tim);
            DateTime tim2 = ConvertToDateTime(t1);
            Assert.AreEqual(tim.ToString("yyyyMMddHHmmss"), tim2.ToString("yyyyMMddHHmmss"));
        }

        [TestMethod()]
        public void GetDevicePicTest()
        {
            PublicClassCurrency.VideoInfo vInfo = TestDataSource.TestDataSource.GetHikData2();
            DateTime timStart = DateTime.Parse("2018-05-30 21:42:30");
            //DateTime timStart = DateTime.Now.AddSeconds(-70);
            DateTime timEnd = timStart.AddSeconds(40);
            string strPath = @"C:\SHIKE_Video\9999\Pic";
            bool bolResult = SDK_HikClientSDK.GetDevicePic(vInfo, timStart, timEnd, strPath);
            Assert.IsTrue(bolResult);
        }

        [TestMethod()]
        public void NET_DVR_GetFileByTime_V40Test()
        {
            PublicClassCurrency.VideoInfo vInfo = TestDataSource.TestDataSource.GetHikData2();
            SDK_HikClientSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new SDK_HikClientSDK.NET_DVR_DEVICEINFO_V30();
            //登录设备
            int m_lUserID = SDK_HikClientSDK.NET_DVR_Login_V30(vInfo.DVSAddress, vInfo.DVSConnectPort, vInfo.UserName, vInfo.Password, ref DeviceInfo);
            SDK_HikClientSDK.NET_DVR_PLAYCOND struDownPara = new SDK_HikClientSDK.NET_DVR_PLAYCOND();
            struDownPara.dwChannel = 1; //通道号 Channel number  
            DateTime timStart = DateTime.Parse("2018-05-31 00:33:01");
            struDownPara.struStartTime = ConvertToNetTime(timStart);
            struDownPara.struStopTime = ConvertToNetTime(timStart.AddSeconds(30));
            string sVideoFileName;  //录像文件保存路径和文件名 the path and file name to save      
            sVideoFileName = @"C:\SHIKE_Video\9999\\Downtest_Channel" + struDownPara.dwChannel + ".mp4";

            //按时间下载 Download by time
            Int32 m_lDownHandle = SDK_HikClientSDK.NET_DVR_GetFileByTime_V40(m_lUserID, sVideoFileName, ref struDownPara);
            uint iOutValue = 0;
            if (SDK_HikClientSDK.NET_DVR_PlayBackControl_V40(m_lDownHandle, SDK_HikClientSDK.NET_DVR_PLAYSTART, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue))
            {
                bool bolEnd = false;
                int iPos = 0;
                while (!bolEnd)
                {
                    iPos = SDK_HikClientSDK.NET_DVR_GetDownloadPos(m_lDownHandle);
                    if (iPos == 100)
                    {
                        //下载完成
                        bolEnd = true;
                    }
                    else if (iPos == 200)
                    {
                        //下载异常
                        bolEnd = true;
                    }
                    Thread.Sleep(50);
                }
            }
            NET_DVR_Logout_V30(m_lUserID);
            Assert.Fail();
        }

        [TestMethod()]
        public void DownloadVideoRecordTest()
        {
            PublicClassCurrency.VideoInfo vInfo = TestDataSource.TestDataSource.GetHikData2();
            int intChannel = 1;
            DateTime timStart = DateTime.Parse("2018-05-31 00:40:01");
            DateTime timEnd = DateTime.Parse("2018-05-31 00:47:01");

            string sVideoFileName;  //录像文件保存路径和文件名 the path and file name to save      
            sVideoFileName = @"C:\SHIKE_Video\9999\123\\12331\Downtest_Channel" + timStart.ToString("yyyyMMddHHmmss") + intChannel + ".mp4";
            bool bolResut = SDK_HikClientSDK.DownloadVideoRecord(vInfo, intChannel, timStart, timEnd, sVideoFileName);
            Assert.IsTrue(bolResut);
        }

        [TestMethod()]
        public void GetDevChannelInfoTest()
        {

            PublicClassCurrency.VideoInfo vInfo = TestDataSource.TestDataSource.GetHikData1();
            SDK_HikClientSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new SDK_HikClientSDK.NET_DVR_DEVICEINFO_V30();
            //登录设备
            int m_lUserID = SDK_HikClientSDK.NET_DVR_Login_V30(vInfo.DVSAddress, vInfo.DVSConnectPort, vInfo.UserName, vInfo.Password, ref DeviceInfo);
            SDK_HikClientSDK.SetDevChannelInfo(ref vInfo, DeviceInfo, m_lUserID);
            Assert.AreEqual(vInfo.Cameras.Count, 1);

        }

        [TestMethod()]
        public void NET_DVR_FindFile_V40Test()
        {
            PublicClassCurrency.VideoInfo vInfo = TestDataSource.TestDataSource.GetHikData1();
            SDK_HikClientSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new SDK_HikClientSDK.NET_DVR_DEVICEINFO_V30();
            //登录设备
            int m_lUserID = SDK_HikClientSDK.NET_DVR_Login_V30(vInfo.DVSAddress, vInfo.DVSConnectPort, vInfo.UserName, vInfo.Password, ref DeviceInfo);
            SDK_HikClientSDK.SetDevChannelInfo(ref vInfo, DeviceInfo, m_lUserID);
            //CHCNetSDK.NET_DVR_FILECOND_V40 struFileCond_V40 = new CHCNetSDK.NET_DVR_FILECOND_V40();
            VideoPlayControl.SDK_HikClientSDK.NET_DVR_FILECOND_V40 struFileCond_V40 = new VideoPlayControl.SDK_HikClientSDK.NET_DVR_FILECOND_V40();
            PublicClassCurrency.CameraInfo[] lstC = vInfo.Cameras.Values.ToArray();
            struFileCond_V40.lChannel = lstC[0].Channel;
            struFileCond_V40.dwFileType = 0xff; //0xff-全部，0-定时录像，1-移动侦测，2-报警触发，...
            struFileCond_V40.dwIsLocked = 0xff; //0-未锁定文件，1-锁定文件，0xff表示所有文件（包括锁定和未锁定）
            struFileCond_V40.struStartTime = SDK_HikClientSDK.ConvertToNetTime(DateTime.Now.AddDays(-1));
            struFileCond_V40.struStopTime = SDK_HikClientSDK.ConvertToNetTime(DateTime.Now);
            int iFindfileHandle = VideoPlayControl.SDK_HikClientSDK.NET_DVR_FindFile_V40(m_lUserID, ref struFileCond_V40);
            Assert.AreEqual(iFindfileHandle, 0);
        }
    }
}