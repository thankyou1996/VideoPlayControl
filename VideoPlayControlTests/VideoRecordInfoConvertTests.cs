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
    public class VideoRecordInfoConvertTests
    {
        [TestMethod()]
        public void GetVideoRecordInfo_ByFileNameTest()
        {
            //string Temp_strValueInfo = "461001_01_20180425191749_17.bsr";
            //string Temp_strValueInfo = "61-57356B140B39-3036_20190218204632_09_bfr10.H264";
            //string Temp_strValueInfo = "002501_01_20190723142607_81.H264";
            //string Temp_strValueInfo = "61-543032620F30-3430_20200117153111_09_bfr10.H264";
            string Temp_strValueInfo = "61-543032620F30-3430_20200117153112_09_bfr10.G711";
            VideoPlayControl.VideoRecord.VideoRecordInfo vrInfo = VideoPlayControl.VideoRecord.VideoRecordInfoConvert.GetVideoRecordInfo_ByFileName(Temp_strValueInfo);
            Assert.AreEqual(vrInfo.VideoRecordType, VideoRecord.Enum_VideoRecordType.PrcRecord);
        }

        [TestMethod()]
        public void GetVideoRecordBRFInfo_ByFileNameTest()
        {
            string Temp_strValueInfo = "61-57356B140B39-3036_20190218204632_09_bfr10.H264";

            string Temp_strValueInfo1 = "71-00F51F012D0C-2830_20190723142604_00.H264";
            //VideoRecordInfo vrInfo = VideoRecordInfoConvert.GetVideoRecordBRFInfo_ByFileName(Temp_strValueInfo1);
            //Assert.AreEqual(vrInfo.VideoRecordType, Enum_VIdeoRecordType.Unrecognized);
        }
    }
}