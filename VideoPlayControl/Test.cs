using Newtonsoft.Json;
using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl
{
    public class Test
    {

        public static string  JosnTest(VideoInfo v)
        {
            return GetProgCmd_Write_JsonData(v);
        }

        public static VideoInfo JsonTest1(string str)
        {
            return JsonConvert.DeserializeObject<VideoInfo>(str);
        }

        public static string JsonTest2(Dictionary<string ,VideoInfo> dicv)
        {
            return GetProgCmd_Write_JsonData(dicv);
        }

        public static Dictionary<string, VideoInfo> JsonTest3(string str)
        {
            return JsonConvert.DeserializeObject<Dictionary<string, VideoInfo>>(str);
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
    }
}
