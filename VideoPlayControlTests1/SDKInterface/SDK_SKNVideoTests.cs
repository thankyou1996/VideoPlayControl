using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoPlayControl.SDKInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.SDKInterface.Tests
{
    [TestClass()]
    public class SDK_SKNVideoTests
    {
        [TestMethod()]
        public void GetChannelByFileMapNameTest()
        {
            string strPath = "/63-00F628C55D02-1812/FILE_MAP_02";
            int intChannel = SDK_SKNVideo.GetChannelByFileMapPath(strPath);
            Assert.AreEqual(intChannel, 1);
        }

        [TestMethod()]
        public void SDK_NSK_CLIENT_dev_delay_alarmTest()
        {
            Assert.Fail();
        }
    }
}