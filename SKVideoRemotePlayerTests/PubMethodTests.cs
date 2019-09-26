using Microsoft.VisualStudio.TestTools.UnitTesting;
using PublicClassCurrency;
using SKVideoRemotePlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoPlayControl.VideoEnvironment;

namespace SKVideoRemotePlayer.Tests
{
    [TestClass()]
    public class PubMethodTests
    {

        public PubMethodTests()
        {
                ProgPara para = new ProgPara
                {
                    ServerAddress = "192.168.2.19",
                    ServerPort = 48624,
                    UserName = "xhcs1",
                    PlaybackTimeStart = DateTime.Now.AddDays(-1),
                    PlaybackTimeEnd = DateTime.Now.AddDays(1),
                    PlaybackTime = DateTime.Now.AddHours(-1),
                    Channel = 1,
                    VideoInfo = TestDataSource.SKNVideoDatSource.GetSKData1(),
                    DefaultSaveDir = Environment.CurrentDirectory,
                    XmlCgfFullPath = Environment.CurrentDirectory
                };
                ProgPara.CurrentProgPara = para;
                VideoEnvironment_SKN.SKNVideoSDK_Init(para.ServerAddress, para.ServerPort, para.UserName, para.XmlCgfFullPath, para.DefaultSaveDir);
        }

        [TestMethod()]
        public void DownloadFileTest()
        {
            CommonMethod.Common.Delay_Millisecond(1000);
            VideoInfo vInfo = TestDataSource.SKNVideoDatSource.GetSKData1();
            string strPath = "VHS_ch09_63-00F628C55D02-1812_1565932748.h264";
            PubMethod.DownloadFile(vInfo, strPath);
            CommonMethod.Common.Delay_Millisecond(30000);
            Assert.Fail();
        }
    }
}