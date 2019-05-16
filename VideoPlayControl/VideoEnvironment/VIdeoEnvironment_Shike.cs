using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using static VideoPlayControl.SDK_SKVideoSDK;

namespace VideoPlayControl.VideoEnvironment
{
    public class VIdeoEnvironment_Shike
    {
        /// <summary>
        /// 时刻视频SDK状态
        /// </summary>
        private static Enum_SDKState s_SKVideoSDKState = Enum_SDKState.SDK_Null;

        public static Enum_SDKState SKVideoSDKState
        {
            get { return s_SKVideoSDKState; }
            set
            {
                s_SKVideoSDKState = value;
                SDKState.SDKStateChange(Enum_VideoType.Ezviz, s_SKVideoSDKState);
            }
        }


        private static CallBack p_msg_demo_callback;

        /// <summary>
        /// 时刻视频设备初始化
        /// </summary>
        /// <param name="intAvPort"></param>
        /// <param name="strClientGUID"></param>
        /// <param name="strServerIP"></param>
        /// <param name="uintControlPort"></param>
        /// <param name="uintVideoPort"></param>
        /// <param name="uintAudioPort"></param>
        /// <param name="strRecordDic"></param>
        /// <returns></returns>
        public static Enum_SDKState SKVideoSDKInit()
        {
            SKVideoSDKInit(ProgParameter.strSKVideo_ClientUGID, ProgParameter.strSKVideo_ServerIP, ProgParameter.uintSKVideo_ControlPort, ProgParameter.uintSKVideo_VideoPort, ProgParameter.uintSKVideo_AudioPort, ProgParameter.uintSKVideo_AVPort);
            return SKVideoSDKState;
        }

        /// <summary>
        /// 时刻视频设备初始化
        /// </summary>
        /// <param name="intAvPort"></param>
        /// <param name="strClientGUID"></param>
        /// <param name="strServerIP"></param>
        /// <param name="uintControlPort"></param>
        /// <param name="uintVideoPort"></param>
        /// <param name="uintAudioPort"></param>
        /// <param name="strRecordDic"></param>
        /// <returns></returns>
        public static Enum_SDKState SKVideoSDKInit(string strGUId, string strServerIP)
        {
            ProgParameter.strSKVideo_ClientUGID = strGUId;
            ProgParameter.strSKVideo_ServerIP = strServerIP;
            SKVideoSDKInit(ProgParameter.strSKVideo_ClientUGID, ProgParameter.strSKVideo_ServerIP, ProgParameter.uintSKVideo_ControlPort, ProgParameter.uintSKVideo_VideoPort, ProgParameter.uintSKVideo_AudioPort, ProgParameter.uintSKVideo_AVPort);
            return SKVideoSDKState;
        }

        /// <summary>
        /// 时刻视频设备初始化
        /// </summary>
        /// <param name="strGUId"></param>
        /// <param name="strServerIP"></param>
        /// <param name="uintControlPort"></param>
        /// <param name="uintVideoPort"></param>
        /// <param name="uintAudioPort"></param>
        /// <param name="uintStreamPort"></param>
        /// <returns></returns>
        public static Enum_SDKState SKVideoSDKInit(string strGUId, string strServerIP, int uintControlPort, int uintVideoPort, int uintAudioPort, int uintStreamPort, string strRecordDirectory = "")
        {
            SDKState.SDKEventCallBack(Enum_VideoType.SKVideo, Enum_SDKStateEventType.SDKInitStart);
            ProgParameter.strSKVideo_ClientUGID = strGUId;
            ProgParameter.strSKVideo_ServerIP = strServerIP;
            ProgParameter.uintSKVideo_ControlPort = Convert.ToUInt16(uintControlPort);
            ProgParameter.uintSKVideo_VideoPort = Convert.ToUInt16(uintVideoPort);
            ProgParameter.uintSKVideo_AudioPort = Convert.ToUInt16(uintAudioPort);
            ProgParameter.uintSKVideo_AVPort = Convert.ToUInt16(uintStreamPort);
            ProgParameter.strSKVideo_RecordDirectory = strRecordDirectory;
            SDK_SKVideoSDK.p_sdkc_set_server_av_port(ProgParameter.uintSKVideo_AVPort);   //设置码流端口
            SDK_SKVideoSDK.p_sdkc_init_client(strGUId, strServerIP
                                            , ProgParameter.uintSKVideo_ControlPort
                                            , ProgParameter.uintSKVideo_VideoPort
                                            , ProgParameter.uintSKVideo_AudioPort
                                            , ProgParameter.strSKVideo_RecordDirectory);//初始化
            SDK_SKVideoSDK.p_sdkc_disable_hw_render(); //关闭客户端软解码
            SKVideoSDKState = Enum_SDKState.SDK_Init;
            SDKState.SDKEventCallBack(Enum_VideoType.SKVideo, Enum_SDKStateEventType.SDKInitEnd);
            p_msg_demo_callback = new CallBack(callback);
            SDK_SKVideoSDK.p_sdkc_reg_msg_callback(p_msg_demo_callback);
            return SKVideoSDKState;
        }
        /// <summary>
        /// 获取客户端SDK网络状态
        /// 0，客户端不在线，1，客户端在线
        /// </summary>
        /// <returns></returns>
        public static int GetSKSDKClientOlineStatus()
        {
            return SDK_SKVideoSDK.p_sdkc_get_online();
        }

        public static void callback(UInt32 msg_id, UInt32 arg1, UInt32 arg2, IntPtr data1, UInt32 data1_len, IntPtr data2, UInt32 data2_len)
        {
            st_event st = new st_event();
            switch (msg_id)
            {
                case 0X0C:
                    st = (st_event)Marshal.PtrToStructure(data1, typeof(st_event));
                    switch (st.event_code)
                    {
                        case 0X32://获取摄像头信息（分辨率，码率，帧率）
                            callback_StramInfo(st);
                            break;
                    }
                    break;
                default:
                    break;
            }

        }

        private const string c_GET_CAM_INFO = "VSDK_PS_CMD__GET_CAM_INFO";
        private const string c_GET_NET_SPD = "VSDK_PS_CMD__GET_NET_SPD";
        public static void callback_StramInfo(st_event st)
        {
            string guid = System.Text.Encoding.UTF8.GetString(st.guid).Trim();
            int i = guid.IndexOf("\0");
            guid = guid.Substring(0, i);
            string data = Encoding.Default.GetString(st.event_data).Trim();
            i = data.IndexOf("\0");
            data = data.Substring(0, i);
            Rootobject root = JsonConvert.DeserializeObject<Rootobject>(data);
            //string strJsonDataContent=
            switch (root.cmd)
            {
                case c_GET_CAM_INFO:
                    int Temp_intIndex = data.IndexOf(c_GET_CAM_INFO) + c_GET_CAM_INFO.Length + 9;
                    int Temp_intt = data.Length - Temp_intIndex - 1;
                    string strCotnent = data.Substring(Temp_intIndex, Temp_intt);
                    List<Cam> cs = JsonConvert.DeserializeObject<List<Cam>>(strCotnent);
                    VideoStreamInfoReport(new VideoStreamInfoReportValue
                    {
                        Guid = guid,
                        StreamInfo = new CamsStreamInfo
                        {
                            cams = cs.ToArray()
                        }
                    });
                    break;
                case c_GET_NET_SPD:
                    Temp_intIndex = data.IndexOf(c_GET_NET_SPD) + c_GET_NET_SPD.Length + 9;
                    Temp_intt = data.Length - Temp_intIndex - 1;
                    strCotnent = data.Substring(Temp_intIndex, Temp_intt);
                    Svr[] scrs = JsonConvert.DeserializeObject<Svr[]>(strCotnent);
                    NETSPDReport(new NETSPDReportValue
                    {
                        Guid = guid,
                        Svrs = scrs
                    });
                    break;

            }
        }

        public delegate void VideoStreamInfoReportDelegate(object sender, VideoStreamInfoReportValue VideoStreamInfoReportValue);

        public static event VideoStreamInfoReportDelegate VideoStreamInfoReportEvent;

        private static void VideoStreamInfoReport(VideoStreamInfoReportValue VideoStreamInfoReportValue)
        {
            if (VideoStreamInfoReportEvent != null)
            {
                VideoStreamInfoReportEvent(null, VideoStreamInfoReportValue);
            }
        }
        /// <summary>
        /// 视频流回调信息
        /// </summary>
        public class VideoStreamInfoReportValue
        {
            public string Guid
            {
                get;
                set;
            }
            public CamsStreamInfo StreamInfo
            {
                get;
                set;
            }
        }

        public delegate void NETSPDReportDelegate(object sender, NETSPDReportValue value);

        public static event NETSPDReportDelegate NETSPDReportEvent;

        private static void NETSPDReport(NETSPDReportValue value)
        {
            if (NETSPDReportEvent != null)
            {
                NETSPDReportEvent(null, value);
            }
        }


        public class NETSPDReportValue
        {
            public string Guid;
            public Svr[] Svrs;
        }


        public class Rootobject
        {
            public string cli { get; set; }
            public string cmd { get; set; }
        }

        public class CamsStreamInfo
        {
            public Cam[] cams { get; set; }
        }

        public class Cam
        {
            /// <summary>
            /// 通道
            /// </summary>
            public int chn { get; set; }
            /// <summary>
            ///lo(本地)  net网络
            /// </summary>
            public string type { get; set; }
            /// <summary>
            /// 主码流 分辨率 宽
            /// </summary>
            public int m_w { get; set; }
            /// <summary>
            /// 主码流 分辨率 高
            /// </summary>
            public int m_h { get; set; }
            /// <summary>
            /// 主码流 帧率
            /// </summary>
            public int m_fps { get; set; }
            /// <summary>
            /// 主码流 码率
            /// </summary>
            public int m_br { get; set; }
            /// <summary>
            /// 是否启用
            /// </summary>
            public int en { get; set; }
            public int on { get; set; }
            /// <summary>
            /// 子码流 宽
            /// </summary>
            public int s_w { get; set; }
            /// <summary>
            /// 子码流 高
            /// </summary>
            public int s_h { get; set; }
            /// <summary>
            /// 子码流 帧率
            /// </summary>
            public int s_fps { get; set; }
            /// <summary>
            /// 子码流 码率
            /// </summary>
            public int s_br { get; set; }
        }



        public class Svr
        {
            public string target { get; set; }
            public string port { get; set; }
            public string netcard { get; set; }
            public int delay { get; set; }
            public int cache { get; set; }
            public float up_spd { get; set; }
            public float total_up_spd { get; set; }
            public string result { get; set; }
            public string reason { get; set; }
        }

    }
}
