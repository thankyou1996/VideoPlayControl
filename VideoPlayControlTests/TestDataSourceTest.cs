using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoPlayControlTests
{
    [TestClass()]
    public class TestDataSourceTest
    {
        [TestMethod()]
        public void SKVideoSDKInitTest()
        {
            VideoInfo vInfo = TestDataSource.SKNVideoDatSource.GetSKData1();
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            string str = JsonConvert.SerializeObject(vInfo, settings);
            Assert.AreEqual(str, "1");
        }
    }
}
