using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoPlayControl.VideoPlay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicClassCurrency;

namespace VideoPlayControl.VideoPlay.Tests
{
    [TestClass()]
    public class VideoPlay_HikStreamTests
    {
        [TestMethod()]
        public void GetHikStreamUrlTest()
        {
            VideoInfo vInfo = TestDataSource.HikStreamData.GetVideoInfo();
            string strUrl = VideoPlay_HikStream.GetHikStreamUrl(vInfo, vInfo.Cameras[5]);
            Assert.AreEqual(strUrl, "");
        }
    }
}