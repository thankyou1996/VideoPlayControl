using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.Transition
{
    /// <summary>
    /// 视频设备类型转换
    /// </summary>
    public class Transition_VideoTypeConvert
    {
        public static Enum_VideoType GetVideoType(string strVideoTypeName)
        {
            Enum_VideoType result = Enum_VideoType.Unrecognized;
            if (strVideoTypeName.EndsWith("ZW") || strVideoTypeName == "SK838")
            {
                //云视通设备
                result = Enum_VideoType.CloundSee;
            }
            else if (strVideoTypeName.Contains("IPCWA") || strVideoTypeName.Contains("SK835"))
            {
                result = Enum_VideoType.IPCWA;
            }
            else if (strVideoTypeName.EndsWith("YS"))
            {
                result = Enum_VideoType.Ezviz;
            }
            else if (strVideoTypeName.EndsWith("HM"))  //180117 华迈设备
            {
                result = Enum_VideoType.HuaMaiVideo;
            }
            else if (strVideoTypeName == "AXISM3037")
            {
                result = Enum_VideoType.Axis;
            }
            else if (strVideoTypeName.EndsWith("XM")
                    || strVideoTypeName == "SK838C"
                    || strVideoTypeName == "SK836C")
            {
                result = Enum_VideoType.XMaiVideo;
            }
            else if (strVideoTypeName.StartsWith("BSRNR"))
            {
                result = Enum_VideoType.BlueSky;

            }
            else if (strVideoTypeName.Trim() == "SK8616H")
            {
                result = Enum_VideoType.SKNVideo;      //181018 时刻h265
            }
            else if (strVideoTypeName.StartsWith("SK86")
                    || strVideoTypeName.StartsWith("SK519")
                    || strVideoTypeName.StartsWith("SK8519")
                    || (strVideoTypeName == "SK836"))
            {
                result = Enum_VideoType.SKVideo;
            }
            else if (strVideoTypeName.EndsWith("HA")
                    || strVideoTypeName.EndsWith("HY")      //浩云设备，与海康一样
                    )
            {
                result = Enum_VideoType.HikDVR;
            }
            else if (strVideoTypeName.EndsWith("ZL"))
            {
                result = Enum_VideoType.ZLVideo;
            }
            else if (strVideoTypeName.EndsWith("DA"))
            {
                result = Enum_VideoType.DaHuaVideo;
            }
            else
            {
                result = Enum_VideoType.Unrecognized;
            }

            return result;
        }
    }
}
