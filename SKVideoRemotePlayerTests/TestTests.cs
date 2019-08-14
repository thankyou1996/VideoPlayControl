using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using SKVideoRemotePlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKVideoRemotePlayer.Tests
{
    [TestClass()]
    public class TestTests
    {
        [TestMethod()]
        public void ProgStartParaTestTest()
        {
            ProgStartPara para = new ProgStartPara
            {
                ServerAddress = "192.168.2.19",
                ServerPort = 48624,
                UserName = "xhcs1",
                PlaybackTimeStart = DateTime.Now.AddDays(-1),
                PlaybackTimeEnd = DateTime.Now.AddDays(1),
                PlaybackTime = DateTime.Now.AddHours(-1),
                Channel = 9,
                VideoInfo = TestDataSource.SKNVideoDatSource.GetSKData1(),
                DefaultSaveDir = Environment.CurrentDirectory,
                XmlCgfFullPath = Environment.CurrentDirectory
            };

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            string str = JsonConvert.SerializeObject(para, settings);
            ProgStartPara para1= JsonConvert.DeserializeObject<ProgStartPara>(str);
            Assert.AreEqual(para1.ServerAddress,"123" );
        }
    }
}