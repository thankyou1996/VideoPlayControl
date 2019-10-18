using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoPlayControl.VideoTalk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicClassCurrency;

namespace VideoPlayControl.VideoTalk.Tests
{
    [TestClass()]
    public class VideoTalk_ShikeTests
    {
        VideoTalk_Shike v = new VideoTalk_Shike();
        public VideoTalk_ShikeTests()
        {
            
        }

        [TestMethod()]
        public void GetTalkRecordPath_ServerTest()
        {
            VideoInfo vInfo = TestDataSource.SKDataSource.GetSKData_8519B();
            v.SetVideoTalkInfo(vInfo, vInfo.TalkChannel.First().Value);
            string str = v.GetTalkRecordPath_Server("0001\\20191017204811", "");
            Assert.AreEqual(str, "");
        }
    }
}