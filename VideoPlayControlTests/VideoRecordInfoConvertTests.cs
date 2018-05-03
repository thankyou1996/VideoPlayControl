using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoPlayControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicClassCurrency;

namespace VideoPlayControl.Tests
{
    [TestClass()]
    public class VideoRecordInfoConvertTests
    {
        [TestMethod()]
        public void GetVideoRecordInfo_ByFileNameTest()
        {
            string Temp_strValueInfo = "461001_01_20180425191749_17.bsr";
            VideoRecordInfo vrInfo = VideoRecordInfoConvert.GetVideoRecordInfo_ByFileName(Temp_strValueInfo);
            Assert.AreEqual(vrInfo.VideoRecordType, Enum_VIdeoRecordType.Unrecognized);
        }

    }
}