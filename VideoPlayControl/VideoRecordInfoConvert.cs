using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayControl
{
    public class VideoRecordInfoConvert
    {
        /// <summary>
        /// 获取视频记录信息_By文件名称
        /// </summary>
        /// <returns></returns>
        public static VideoRecordInfo GetVideoRecordInfo_ByFileName(string strFileName)
        {
            VideoRecordInfo v = new VideoRecordInfo();
            v.RecordPath = strFileName;
            //通用命令规则 770701_09_20171226174241_81.H264
            //DNSNum_Channnel_起始时间（yyyyMMddHHmmss）_主机类型区分.后缀

            //安讯士: 000601_00_20170126204501_06.bin
            //解析： DNVNum_Channel_起始时间（yyyyMMddHHmmss）_视频设备类型（06安讯士）.bin(后缀)

            string Temp_strOperat = strFileName.Substring(strFileName.LastIndexOf("\\") + 1);
            int Temp_intIndex = Temp_strOperat.LastIndexOf(".");
            int Temp_intIndex1 = Temp_strOperat.LastIndexOf("_");

            string Temp_strVideoType = Temp_strOperat.Substring(Temp_intIndex1 + 1, Temp_intIndex - Temp_intIndex1 - 1);
            switch (Temp_strVideoType)
            {
                case "82":
                    v.VideoRecordType = Enum_VIdeoRecordType.ZLVideoRecord;
                    break;
                case "31":
                    v.VideoRecordType = Enum_VIdeoRecordType.DaHuaVideoRecord;
                    break;
                default:
                    v.VideoRecordType = (Enum_VIdeoRecordType)(Convert.ToInt32(Temp_strVideoType));
                    break;
            }
            //switch (Temp_strVideoType)
            //{
            //    case "06":
            //        v.VideoRecordType = Enum_VIdeoRecordType.Axis;
            //        break;
            //    case "12":
            //        v.VideoRecordType = Enum_VIdeoRecordType.HikDVR;
            //        break;
            //    case "08":
            //        v.VideoRecordType = Enum_VIdeoRecordType.XMaiVideo;
            //        break;
            //    case "09":
            //        v.VideoRecordType = Enum_VIdeoRecordType.BlueSky;
            //        break;
            //    default:
            //        v.VideoRecordType = Enum_VIdeoRecordType.Unrecognized;
            //        return v;
            //}

            Temp_strOperat = Temp_strOperat.Substring(0, Temp_intIndex1);
            Temp_intIndex = Temp_strOperat.LastIndexOf("_");
            string Temp_strStartTime = Temp_strOperat.Substring(Temp_intIndex + 1);
            v.StartTime = DateTime.ParseExact(Temp_strStartTime, "yyyyMMddHHmmss", System.Globalization.CultureInfo.CurrentCulture);

            Temp_strOperat = Temp_strOperat.Substring(0, Temp_intIndex);
            Temp_intIndex = Temp_strOperat.LastIndexOf("_");
            string Temp_strChannel = Temp_strOperat.Substring(Temp_intIndex + 1);
            v.Channel = Convert.ToInt32(Temp_strChannel);

            Temp_strOperat = Temp_strOperat.Substring(0, Temp_intIndex);
            Temp_intIndex = Temp_strOperat.LastIndexOf("_");
            string Temp_strDVSNum = Temp_strOperat.Substring(Temp_intIndex + 1);
            v.DVSNumber = Temp_strDVSNum;
            return v;
        }


        public static string GetVideoRecordName(string strVideoNum, int intChannel, Enum_VideoType videoType)
        {
            return GetVideoRecordName(strVideoNum, intChannel, DateTime.Now, videoType);
        }

        public static string GetVideoRecordName(string strVideoNum, int intChannel,DateTime timVideoRecordStart, Enum_VideoType videoType)
        {
            //通用命令规则 770701_09_20171226174241_81.H264
            //DNSNum_Channnel_起始时间（yyyyMMddHHmmss）_主机类型区分.后缀
            StringBuilder sbVideoRecordFileName = new StringBuilder();
            sbVideoRecordFileName.Append(strVideoNum + "_");
            sbVideoRecordFileName.Append(intChannel.ToString().PadLeft(2, '0') + "_");
            sbVideoRecordFileName.Append(timVideoRecordStart.ToString("yyyyMMddHHmmss") + "_");
            switch (videoType)
            {
                case Enum_VideoType.SKNVideo:
                    sbVideoRecordFileName.Append("81");
                    break;
                case Enum_VideoType.ZLVideo:
                    sbVideoRecordFileName.Append("82");
                    break;
                case Enum_VideoType.DaHuaVideo:
                    sbVideoRecordFileName.Append("31");
                    break;
                default:
                    sbVideoRecordFileName.Append(((int)videoType).ToString().PadLeft(2, '0'));
                    break;
            }
            switch (videoType)
            {
                case Enum_VideoType.Axis:
                    sbVideoRecordFileName.Append(".bin");
                    break;
                case Enum_VideoType.HikDVR:
                    sbVideoRecordFileName.Append(".mp4");
                    break;
                case Enum_VideoType.XMaiVideo:
                case Enum_VideoType.SKVideo:
                case Enum_VideoType.SKNVideo:
                    sbVideoRecordFileName.Append(".H264");
                    break;
                case Enum_VideoType.BlueSky:
                    sbVideoRecordFileName.Append(".bsr");
                    break;
                case Enum_VideoType.ZLVideo:
                case Enum_VideoType.DaHuaVideo:
                    sbVideoRecordFileName.Append(".dav");
                    break;
                default:
                    sbVideoRecordFileName.Append(".mp4");
                    break;
            }

            return sbVideoRecordFileName.ToString();
        }
    }
}
