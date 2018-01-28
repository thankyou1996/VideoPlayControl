using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoPlayControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicClassCurrency;
using Newtonsoft.Json;

namespace VideoPlayControl.Tests
{
    [TestClass()]
    public class TestTests
    {
        [TestMethod()]
        public void JosnTestTest()
        {
            string strResult = Test.JosnTest(SKVideo_TestData());
            Assert.AreEqual(strResult, "1");
        }

        [TestMethod()]
        public void JsonTest1Test()
        {

            VideoPlayControl.VideoPlaySetting VV = new VideoPlaySetting();
            string strResult = GetProgCmd_Write_JsonData(VV);
            VideoPlaySetting v = JsonConvert.DeserializeObject<VideoPlaySetting>(strResult);
            Assert.AreEqual(VV.PreVideoRecordFilePath, "1234");
        }


        [TestMethod()]
        public void JsonTest2Test()
        {
            VideoInfo v1 = SKVideo_TestData();
            VideoInfo v2 = SKVideo_TestData1();
            Dictionary<String, VideoInfo> dicV = new Dictionary<string, VideoInfo>();
            dicV[v1.DVSNumber] = v1;
            dicV[v2.DVSNumber] = v2;
            string strResult = Test.JsonTest2(dicV);
            Assert.AreEqual(strResult, "1");
        }
        [TestMethod()]
        public void JsonTest3Test()
        {
            VideoInfo v1 = SKVideo_TestData();
            VideoInfo v2 = SKVideo_TestData1();
            Dictionary<String, VideoInfo> dicV = new Dictionary<string, VideoInfo>();
            dicV[v1.DVSNumber] = v1;
            //dicV[v2.DVSNumber] = v2;
            string strResult = Test.JsonTest2(dicV);

            Dictionary<string, VideoInfo> dicVV = Test.JsonTest3(strResult);

            Assert.AreEqual(dicVV["770701"].DVSNumber,"770701");
        }


        public static VideoInfo SKVideo_TestData()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.SKVideo;
            v.DVSAddress = "61-573539920B39-3036";
            v.DVSChannelNum = 16;
            v.DVSConnectPort = 81;
            v.DVSName = "8604双网口测试";
            v.DVSNumber = "770701";
            v.DVSType = "SK8616";
            v.HostID = "9994";
            v.Password = "sk123456";
            v.UserName = "admin";
            v.NetworkState = 0;
            for (int i = 0; i < 4; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSAddress = "61-573551920B39-3036";
                c.DVSType = "SK8616";
                c.DVSNumber = "999401";
                v.Cameras[c.Channel] = c;
            }
            for (int i = 8; i < 16; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSAddress = "61-573551920B39-3036";
                c.DVSType = "SK8616";
                c.DVSNumber = "999401";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        public static VideoInfo SKVideo_TestData1()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.SKVideo;
            v.DVSAddress = "72-00F51F010E10-2B25";
            v.DVSChannelNum = 16;
            v.DVSConnectPort = 81;
            v.DVSName = "8519云台控制";
            v.DVSNumber = "770702";
            v.DVSType = "SK8519V";
            v.HostID = "9994";
            v.Password = "sk123456";
            v.UserName = "admin";
            v.NetworkState = 0;
            for (int i = 0; i < 1; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSAddress = v.DVSAddress;
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            for (int i = 8; i < 12; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSAddress = v.DVSAddress;
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        public static string GetProgCmd_Write_JsonData(object objModel)
        {
            string strResult = "";
            Newtonsoft.Json.Converters.IsoDateTimeConverter iso = new Newtonsoft.Json.Converters.IsoDateTimeConverter();
            JsonSerializerSettings jss = new JsonSerializerSettings() { ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver(), Converters = { iso }, DateFormatHandling = DateFormatHandling.IsoDateFormat };
            iso.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
            strResult = JsonConvert.SerializeObject(objModel, jss);
            return strResult;
        }

    }
}