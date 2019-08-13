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
    public class SDK_SKNVideoTests
    {


        public SDK_SKNVideoTests()
        {
            int intResult = SDK_SKNVideo.SDK_NSK_CLIENT_init("127.0.0.1", 48624, "Admin", Environment.CurrentDirectory, Environment.CurrentDirectory);
            //int intResult = SDK_SKNVideo.SDK_NSK_CLIENT_init("127.0.0.1", 48624, "Admin", "", "");
        }

        [TestMethod()]
        public void SDK_NSK_CLIENT_get_fileTest()
        {
            CommonMethod.Common.Delay_Millisecond(3000);
            //string strPath = Environment.CurrentDirectory + "\\TEST\\VHS_ch16_61-5737338A0736-3232_REVIDEO" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".h264";
            string strPath = "\\TEST\\VHS_ch16_61-5737338A0736-3232_REVIDEO" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".h264";
            //string strPath = "\\TEST\\Working\\TEST1\\VHS_ch16_61-5737338A0736-3232_REVIDEO" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".h264";

            int intResult = SDK_SKNVideo.SDK_NSK_CLIENT_get_file("63-343854040533-3339", false, "REVIDEO_CHNN_9", strPath);
            CommonMethod.Common.Delay_Millisecond(20000);
            Assert.Fail();
        }
        /// <summary>
        /// 获取录像映射文件
        /// </summary>
        [TestMethod()]
        public void SDK_NSK_CLIENT_get_fileTest1()
        {
            CommonMethod.Common.Delay_Millisecond(1000);
            //string strPath = Environment.CurrentDirectory + "\\TEST\\VHS_ch16_61-5737338A0736-3232_REVIDEO.h264";
            string strPath = "\\TEST\\VHS_ch16_61-5737338A0736-3232_REVIDEO" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".h264";
            int intResult = SDK_SKNVideo.SDK_NSK_CLIENT_get_file("63-343854040533-3339", false, "/hdd/map_md5/FILE_MAP_09", "TEST\\FILE_MAP_09.txt");
            CommonMethod.Common.Delay_Millisecond(1000);
            Assert.Fail();
        }


        /// <summary>
        /// 下载录像文件地址
        /// </summary>
        [TestMethod()]
        public void SDK_NSK_CLIENT_get_fileTest2()
        {
            CommonMethod.Common.Delay_Millisecond(5000);
            //string strPath = Environment.CurrentDirectory + "\\TEST\\VHS_ch16_61-5737338A0736-3232_REVIDEO.h264";
            string strPath = "\\TEST\\VHS_ch09_63-343854040533-3339_1565166299.h264";
            int intResult = SDK_SKNVideo.SDK_NSK_CLIENT_get_file("63-343854040533-3339", false, "/hdd/normal/VHS_ch09_63-343854040533-3339_1565166299.h264", strPath);
            CommonMethod.Common.Delay_Millisecond(3000);
            Assert.Fail();
        }
    }
}