using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using VideoEncoder;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl
{
    /// <summary>
    /// 时刻视频设备
    /// </summary>
    public class SDK_SKVideoSDK
    {
        #region 宏定义
        //						事件定义
        /**********************************************************/
        public const int SDK_EVENT_CALL_KEY_PRESS = 0x01; // 呼叫按钮被按下
        public const int SDK_EVENT_BAT_LOW = 0x02; // 电池欠压
        public const int SDK_EVENT_BAT_HIGH = 0x03; // 电池过压
        public const int SDK_EVENT_AC_COME = 0x04; // 市电来电
        public const int SDK_EVENT_AC_LOSE = 0x05; // 市电掉电
        public const int SDK_EVENT_PWR_ON = 0x06; // 本机启动
        public const int SDK_EVENT_CALL_START = 0x07;// 呼叫开始
        public const int SDK_EVENT_CALL_END = 0x08; // 呼叫结束
        public const int SDK_EVENT_CALL_FAIL = 0x09; // 呼叫失败
        public const int SDK_EVENT_DURE_CORE_ERR = 0x0a; // 防区模块故障
        public const int SDK_EVENT_3G_LOST = 0x0b; // 3G信号丢失
        public const int SDK_EVENT_CALL_GO_ON = 0x0c; // 呼叫继续
        /**********************************************************/
        //						返回结果定义
        /**********************************************************/
        public const int RET_UNDEFINE_ERR = 0;	// 未知错误
        public const int RET_OK = 1;	// 返回成功
        public const int RET_EMPTY_EVENT = 2;	// 空事件
        public const int RET_NO_FIND_DEVICE = 3;	// 设备不存在
        public const int RET_NO_INIT_AUDIO = 4;	// 未初始化音频设备
        public const int RET_EMPTY_GUID = 5;	// 空设备唯一编号
        public const int RET_DEV_OFF_LINE = 6;	// 设备掉线
        public const int RET_OPEN_FILE_FAIL = 7;	// 打开文件失败
        public const int RET_NO_ENOUGH_MEM = 8; // 内存空间不够

        #endregion

        #region 结构体
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct client_info_all
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 65535, ArraySubType = UnmanagedType.Struct)]
            /// 设备信息结构体列表
            public client_info_lite[] client_info_array;
            /// 设备在线个数
            public int client_online;
            /// 总的在线设备个数，包含了未在线个数
            public int client_all;
        }
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct client_info_lite
        {
            /// 设备临时分配ID号
            public Int32 client_id;
            /// 设备全球唯一标识码
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] guid;
            /// 设备是否在线
            public byte online; // 1：在线  0：离线
            /// 设备是否交换信息完毕，处于可用状态  1:可用  0：不可用
            public byte ready;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct st_event
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
            public byte[] guid;
            public UInt32 length;
            public byte event_code;
            public UInt32 time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10240)]
            public byte[] event_data;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct st_multi_talk
        {
            public int channel_1;
            public int channel_2;
            public int channel_3;
            public int channel_4;
            public int channel_5;
            public int channel_6;
            public int channel_7;
            public int channel_8;
            public int channel_9;
            public int channel_10;
            public int channel_11;
            public int channel_12;
            public int channel_13;
            public int channel_14;
            public int channel_15;
            public int channel_16;
        }
        
        #endregion

        #region 接口定义
 

        #region 回调信息
        public delegate void CallBack(UInt32 msg_id, UInt32 arg1, UInt32 arg2, IntPtr data1, UInt32 data1_len, IntPtr data2, UInt32 data2_len);

        public delegate void p_dl_video_data_callback (string dguid, string cguid,int channel, IntPtr nalu_data,int nalu_len, IntPtr nalu_idx,uint time_stamp);
        /// <summary>
        /// 信息回调
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int p_sdkc_reg_msg_callback(CallBack func);

        /// <summary>
        /// 录像下载回调
        /// </summary>
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void p_vsdk_reg_dl_video_data_callback(p_dl_video_data_callback func);
        #endregion

        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]//码流端口 默认47924
        public static extern int p_sdkc_set_server_av_port(UInt16 av_prort);
        //char	*guid,	char *server_ip, u16	server_c_port, u16	server_v_port, u16	server_a_port
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]//默认端口  47624  47724  47824
        public static extern void p_sdkc_init_client(string clientguid, string server_ip, int server_c_port, int server_v_port, int server_a_port, string record_directory);
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]//mode:1，全双工，2，监听，3，喊话
        public static extern void p_sdkc_start_talk(string guid, int channel, int mode, int enable_record, int max_mbyte, int max_min, string rec_file_path);


        /// <summary>
        /// 多个对讲通道
        /// </summary>
        /// <param name="guid">设备唯一标识码</param>
        /// <param name="channel">对讲通道结构体</param>
        /// <param name="mode">对讲模式,,1，全双工，2，喊话，3，监听</param>
        /// <param name="enable_record">是否允许录像 </param>
        /// <param name="max_mbyte">最大录像的大小，MB计数</param>
        /// <param name="max_min">最大的录像时间，分钟计数</param>
        /// <param name="rec_file_path">需要在服务器存储的文件名</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int p_sdkc_start_multi_talk(string guid, ref st_multi_talk channel, int mode, int enable_record, int max_mbyte, int max_min, string rec_file_path);


        /// <summary>
        /// 开始播放视频
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="channel"></param>
        /// <param name="handle"></param>
        /// <param name="enable_record"></param>
        /// <param name="max_mbyte"></param>
        /// <param name="max_min"></param>
        /// <param name="rec_file_path"></param>
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]//channel 从0开始
        public static extern void p_sdkc_start_rt_video(string guid, int channel, IntPtr handle, int enable_record, int max_mbyte, int max_min, string rec_file_path);
        /// <summary>
        /// 播放现场视频 主码流子码流切换
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="channel"></param>
        /// <param name="handle"></param>
        /// <param name="enable_record"></param>
        /// <param name="max_mbyte"></param>
        /// <param name="max_min"></param>
        /// <param name="use_main_stream">是否使用主码流 0 false 1 true</param>
        /// <param name="rec_file_path"></param>
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]//channel 从0开始
        public static extern void p_sdkc_start_rt_video_ex(string guid, int channel, IntPtr handle, int enable_record, int max_mbyte, int max_min, int use_main_stream, string rec_file_path);

        /// <summary>
        /// 停止播放视频
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="channel"></param>
        /// <param name="handle"></param>
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void p_sdkc_stop_rt_video(string guid, int channel, IntPtr handle);
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void p_sdkc_exit_client();

        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int p_sdkc_stop_talk(string guid);

        /// <summary>
        /// 客户端SDK在线状态
        /// 0，客户端不在线，1，客户端在线
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int p_sdkc_get_online();
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int p_sdkc_disable_hw_render();//151201 软件解
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int p_sdkc_enable_hw_render();//151201 硬件解码

        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void p_vsdk_open(string strIP, int iport, out byte ret_val);
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void p_vsdk_talkback_open(byte duplex, out byte ret_val);
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        //        * @param  mode:		模式选择
        //*						@arg 1: 实时对讲
        //                      @arg 2: 监听
        //                      @arg 3: 喊话
        //*
        public static extern void p_vsdk_talkback_start(string strGuid, byte channel, byte mode, out byte ret_val);
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void p_vsdk_talkback_stop(string strGuid, out byte ret_val);
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void p_vsdk_close();

        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void p_vsdk_open_console();
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void p_vsdk_close_console();

        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void p_vsdk_get_device_info_all(IntPtr info_array);
        //public static extern void p_vsdk_get_device_info_all(ref client_info_all info_array);
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]//获取事件
        //public static extern void p_vsdk_pop_event(ref  st_event stevent, out  byte ret_val);
        public static extern void p_vsdk_pop_event(IntPtr stevent, out byte ret_val);
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void p_vsdk_talkback_save_start(string file1, string file2, out byte ret_val);
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void p_vsdk_talkback_save_stop(out byte ret_val);
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void p_vsdk_snap_picture(string strGuid, byte snap_count, short snap_interver, byte channel, string file1_path, string file2_path, string file3_path, string file4_path, string file5_path, byte ret_val);
        //p_vsdk_snap_picture(guid_str,5,50,1,"d:\\1.jpeg","d:\\2.jpeg","d:\\3.jpeg","d:\\4.jpeg","d:\\5.jpeg",&ret_val);


        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int p_sdkc_start_playback_av(string guid, byte channel, UInt32 start_ts, IntPtr handle);
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int p_sdkc_stop_playback_av(string guid, byte channel, IntPtr handle);
        //170308
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int p_sdkc_stop_talk_all();



        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void p_sdkc_get_revideo_data(string strGuid, int intChannel, string strUrl);

        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int p_sdkc_onvif_ptz_continue_move(string strGuid, int iChannel, int iXSpeed, int iYSpeed, int iZSpeend);

        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int p_sdkc_onvif_ptz_stop(string strGuid, int iChannel);

        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public extern static void p_sdkc_play_remote_audio(string guid, string path, string URL);

        /// <summary>
        /// 设置配置参数
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="path"></param>
        /// <param name="URL"></param>
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public extern static void p_sdkc_get_set_dev_config(string guid, string cfg_file, string cfg_name, string cfg_val);


        /// <summary>
        /// 获取设备通道码流参数 Json
        /// 通过回调信息返回 0x32 VSDK_PS_CMD__GET_CAM_INFO
        /// </summary>
        /// <param name="guid"></param>
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public extern static void p_sdkc_get_dev_cam_info(string guid);

        /// <summary>
        /// 获取设备测速信息
        /// 通过回调信息返回 0x32  VSDK_PS_CMD__GET_NET_SPD
        /// </summary>
        /// <param name="guid"></param>
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public extern static void p_sdkc_get_dev_net_spd(string guid);



        /// <summary>
        /// 客户端透传
        /// </summary>
        /// <param name="guid"></param>
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public extern static void p_sdkc_dev_passthrough(string guid,string cmd);




        #region 录像相关
        /// <summary>
        /// 查询视频记录
        /// </summary>
        /// <param name="guid">GUID</param>
        /// <param name="channel">通道</param>
        /// <param name="start_ts">其实时间</param>
        /// <param name="stop_ts"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int p_sdkc_get_record_time_map(string guid, byte channel, int start_ts, int stop_ts);

        #region 录像下载

        /// <summary>
        /// 录像下载
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="channel"></param>
        /// <param name="start_ts"></param>
        /// <param name="stop_ts"></param>
        /// <param name="save_path"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int p_sdkc_request_download_video(string guid, UInt16 channel, int start_ts, int stop_ts, string save_path);

        #endregion



        public static List<RemoteVideoRecordInfo> SKRemoteVideoRecordDataPrasing(string strGUID, string strData)
        {
            List<RemoteVideoRecordInfo> result = null;
            try
            {
                int Temp_intIndex = strData.IndexOf("\0");
                if (Temp_intIndex > 0)
                {
                    strData = strData.Substring(0, strData.IndexOf("\0"));
                }

                //[a:192.168.2.166] [g: SuperAdmin_PB] [c:08] [s(1526886082) e(1526886150)] [s(1526886179) e(1526887395)] [s(1526887503) e(1526889215)] [s(1526889314) e(1526892684)] [s(1526892685) e(1526895368)] [s(1526895368) e(1526898051)] [s(1526898051) e(1526900729)]
                string strDevAddress = "";
                int intChannel = 0;
                string strGData = "";
                string[] Temp_strData = strData.Split(new char[] { ']', '[' }, StringSplitOptions.RemoveEmptyEntries);

                strDevAddress = Temp_strData[0].Substring(2);
                strGData = Temp_strData[1].Substring(2);
                intChannel = Convert.ToInt32(Temp_strData[2].Substring(2));
                if (Temp_strData.Length > 3)
                {
                    result = new List<RemoteVideoRecordInfo>();
                    for (int i = 3; i < Temp_strData.Length; i++)
                    {
                        string[] Temp_strRecordData = Temp_strData[i].Split(new char[] { 's', 'e', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        long Temp_lStart = Convert.ToInt64(Temp_strRecordData[0]);
                        long Temp_lEnd = Convert.ToInt64(Temp_strRecordData[1]);
                        DateTime timStart = CommonMethod.ConvertClass.UnixTimestampToDateTime(Temp_lStart);
                        DateTime timEnd = CommonMethod.ConvertClass.UnixTimestampToDateTime(Temp_lEnd);
                        RemoteVideoRecordInfo r = new RemoteVideoRecordInfo
                        {
                            VideoGUID = strGUID,
                            VideoAddress = strDevAddress,
                            Channel = intChannel,
                            StartTime = timStart,
                            EndTime = timEnd
                        };
                        r.RemoteVidoRecordName = GetRemoteVideoRecordFileName(r);
                        result.Add(r);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonMethod.LogWrite.WriteEventLog("SKRemoteVideoRecordDataPrasing", strData, ProgParameter.ProgLogAddress);
                CommonMethod.LogWrite.WritExceptionLog("SKRemoteVideoRecordDataPrasing", ex, ProgParameter.ProgLogAddress);
            }
            return result;
        }

        public static bool DownLoadRemoteRecord(RemoteVideoRecordInfo remoteVideoRecordInfo, string strDownFileName)
        {
            bool bolResult = false;
            string strUrl = GetDownLoadRemoteRecordUrl(remoteVideoRecordInfo);
            System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(strUrl);
            //string Temp_strUrl = "http://192.168.2.166/cgi-bin/download.cgi?path=/hdd/normal/VHS_ch09_61-57354AA60831-3136_1526886082.h264&";
            //System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(Temp_strUrl);
            Myrq.Timeout = 5000;
            System.Net.HttpWebResponse myrp = null;
            try
            {
                myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.Timeout)
                {
                    //MessageBox.Show("网络请求超时");
                    bolResult = false;
                    return bolResult;
                }
            }
            long totalBytes = myrp.ContentLength;
            System.IO.Stream st = myrp.GetResponseStream();
            System.IO.Stream so = new System.IO.FileStream(strDownFileName, System.IO.FileMode.Create);
            long totalDownloadedByte = 0;
            byte[] by = new byte[1024];
            int osize = st.Read(by, 0, (int)by.Length);
            while (osize > 0)
            {
                totalDownloadedByte = osize + totalDownloadedByte;
                System.Windows.Forms.Application.DoEvents();
                so.Write(by, 0, osize);
                osize = st.Read(by, 0, (int)by.Length);
            }
            so.Close();
            st.Close();
            return bolResult;
        }

        /// <summary>
        /// 获取下载远程地址
        /// </summary>
        /// <param name="strAddress"></param>
        /// <param name="strFileName"></param>
        /// <returns></returns>
        public static string GetDownLoadRemoteRecordUrl(RemoteVideoRecordInfo remoteVideoRecordInfo)
        {
            StringBuilder sbResult = new StringBuilder();
            sbResult.Append("http://");
            sbResult.Append(remoteVideoRecordInfo.VideoAddress);
            sbResult.Append("/cgi-bin/download.cgi?path=/hdd/normal/");
            sbResult.Append(remoteVideoRecordInfo.RemoteVidoRecordName + "&");
            return sbResult.ToString();
        }

        public static string GetRemoteVideoRecordFileName(RemoteVideoRecordInfo remoteVideoRecordInfo)
        {
            //+ (channel + 1).ToString("00") + "_" + Device_guid + "_" + Form1.download_listfile[i].ToString() + ".h264"
            //VHS_ch01_61 - 57354AA60831 - 3136_1526886080.h264
            StringBuilder sbResult = new StringBuilder();
            sbResult.Append("VHS_ch");
            sbResult.Append((remoteVideoRecordInfo.Channel + 1).ToString("00"));
            sbResult.Append("_");
            sbResult.Append(remoteVideoRecordInfo.VideoGUID);
            sbResult.Append("_");
            sbResult.Append(CommonMethod.ConvertClass.DateTimeToUnixTimestamp(remoteVideoRecordInfo.StartTime));
            sbResult.Append(".h264");
            return sbResult.ToString();
        }
        #endregion


        #region 自定义接口
        #region 录像下载相关
        //Socket mSocket;
        //SocketAsyncEventArgs saeaSend;
        //SocketAsyncEventArgs saeaRece;
        //byte[] bytsSendData = new byte[102400];
        //byte[] bytsReceData = new byte[102400];
        //IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("192.168.2.19"), 6667);

        //public List<string> GetVideoRecordList()
        //{

        //}
        #endregion

        public static st_multi_talk SetMultiTalkChannel(int intIndex, st_multi_talk talkChannel, int intEnable = 1)
        {
            switch (intIndex)
            {
                case 0:
                    talkChannel.channel_1 = intEnable;
                    break;
                case 1:
                    talkChannel.channel_2 = intEnable;
                    break;
                case 2:
                    talkChannel.channel_3 = intEnable;
                    break;
                case 3:
                    talkChannel.channel_4 = intEnable;
                    break;
                case 4:
                    talkChannel.channel_5 = intEnable;
                    break;
                case 5:
                    talkChannel.channel_6 = intEnable;
                    break;
                case 6:
                    talkChannel.channel_7 = intEnable;
                    break;
                case 7:
                    talkChannel.channel_8 = intEnable;
                    break;
                case 8:
                    talkChannel.channel_9 = intEnable;
                    break;
                case 9:
                    talkChannel.channel_10 = intEnable;
                    break;
                case 10:
                    talkChannel.channel_11 = intEnable;
                    break;
                case 11:
                    talkChannel.channel_12 = intEnable;
                    break;
                case 12:
                    talkChannel.channel_13 = intEnable;
                    break;
                case 13:
                    talkChannel.channel_14 = intEnable;
                    break;
                case 14:
                    talkChannel.channel_15 = intEnable;
                    break;
                case 15:
                    talkChannel.channel_16 = intEnable;
                    break;
            }
            return talkChannel;
        }

        public static bool GetPictureForVideoRecord(string strVideoRecord,string strSaveFolder,double dblFrequcency,int intDelatTime_Millisecond)
        {
            bool bolResult = false;
            if (!Directory.Exists(strSaveFolder))
            {
                Directory.CreateDirectory(strSaveFolder) ;
            }
            StringBuilder sbffmpegCmd = new StringBuilder();
            sbffmpegCmd.Append("ffmpeg.exe ");
            sbffmpegCmd.Append("-i " + strVideoRecord);
            sbffmpegCmd.Append(" -f image2 -r " + dblFrequcency + " ");
            //sbffmpegCmd.Append(" -f image2 -r 4.5 ");
            sbffmpegCmd.Append(strSaveFolder + "\\b-%03d.jpg");
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";    //设置要启动的应用程序
            p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;    // 接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;  //输出信息
            p.StartInfo.RedirectStandardError = true;   // 输出错误
            p.StartInfo.CreateNoWindow = true;          //不显示程序窗口
            p.Start();          //启动程序
            p.StandardInput.WriteLine(sbffmpegCmd.ToString() + "&exit");//向cmd窗口发送输入信息
            p.StandardInput.AutoFlush = true;
            int intCount = 0;
            while (!(intCount >= intDelatTime_Millisecond))
            {
                intCount += 100;
                Thread.Sleep(100);
            }
            //重命名伟规范文件
            //命令格式 [通道(两位)][时间(yyyyMMddHHmmss自动生成)][序列号]
            //61 - 57354AA60831 - 3136_20180531194919_01_bfr10
            string Temp_strFileName = strVideoRecord.Substring(strVideoRecord.LastIndexOf("\\")+1);
            DateTime timEndTime = GetTimeByBFRName(Temp_strFileName);
            int intChannel = GetChannelByBFRName(Temp_strFileName);
            RePicname(strSaveFolder, timEndTime, intChannel, dblFrequcency);
            return bolResult;
        }

        public static bool RePicname(string strPicPath,DateTime timEnd ,int intChannel,double dblFrame)
        {
            bool bolResult = false;
            //int intVideoFrame = 30;
            //int intPerSecondNum = intVideoFrame / intFrame; 
            //int intPerSecondNum = Convert.ToInt32(dblFrame);
            int intPerSecondNum = Convert.ToInt32(Math.Round(dblFrame, 0));
            DirectoryInfo directoryinfo = new DirectoryInfo(strPicPath);
            FileInfo[] fInfo = directoryinfo.GetFiles();
            int intFileCount = fInfo.Length;
            //自己计算时间长度 应该可以通过ffmpeg 计算时间长度
            int intSecond = intFileCount / intPerSecondNum;
            DateTime timStart = timEnd.AddSeconds(-intSecond);
            DateTime timName = timStart;
            int intCount = 1;
            foreach (var item in fInfo)
            {
                StringBuilder sbFileName = new StringBuilder();
                sbFileName.Append(intChannel.ToString().PadLeft(2, '0')+"_");
                sbFileName.Append(timName.ToString("yyyyMMddHHmmss")+"_");
                sbFileName.Append(intCount++);
                sbFileName.Append(".jpg");
                if (intCount > intPerSecondNum)
                {
                    timName = timName.AddSeconds(1);
                    intCount = 1;
                }
                string destPath = Path.Combine(strPicPath, sbFileName.ToString());
                //判断是否重名
                if (!File.Exists(destPath))
                {
                    item.MoveTo(destPath);
                }
            }
            return bolResult;
        }

        public static int GetChannelByBFRName(string strFileName)
        {
            string[] strsValue = strFileName.Split('_');
            //61-57354AA60831-3136_20180531194919_01_bfr10.H264
            //DateTime tim = DateTime.ParseExact(strsValue[1], "yyyyMMddHHmmss", CultureInfo.CurrentCulture);
            int intChannel = Convert.ToInt32(strsValue[2]);
            return intChannel;
        }

        public static DateTime  GetTimeByBFRName(string strFileName)
        {
            string[] strsValue = strFileName.Split('_');
            //61-57354AA60831-3136_20180531194919_01_bfr10.H264
            DateTime tim = DateTime.ParseExact(strsValue[1], "yyyyMMddHHmmss", CultureInfo.CurrentCulture);
            //int intChannel = Convert.ToInt32(strsValue[2]);
            return tim;
        }

        public static void testtt()
        {
            VideoEncoder.Encoder enc = new VideoEncoder.Encoder();
            //ffmpeg.exe的路径，程序会在执行目录（....FFmpeg测试\bin\Debug）下找此文件，
            enc.FFmpegPath = "ffmpeg.exe";
            //视频路径
            string videoFilePath = @"C:\SHIKE_Video\9999\20180531223110\61-57354AA60831-3136_20180531223118_01_bfr10.H264";
            VideoFile videoFile = new VideoFile(videoFilePath);

            enc.GetVideoInfo(videoFile);
            TimeSpan totaotp = videoFile.Duration;
            string totalTime = string.Format("{0:00}:{1:00}:{2:00}", (int)totaotp.TotalHours, totaotp.Minutes, totaotp.Seconds);

            Console.WriteLine("时间长度：{0}", totalTime);
            Console.WriteLine("高度：{0}", videoFile.Height);
            Console.WriteLine("宽度：{0}", videoFile.Width);
            Console.WriteLine("数据速率：{0}", videoFile.VideoBitRate);
            Console.WriteLine("数据格式：{0}", videoFile.VideoFormat);
            Console.WriteLine("比特率：{0}", videoFile.BitRate);
            Console.WriteLine("文件路径：{0}", videoFile.Path);
        }
        private const byte gMaxPacket = 5;

        #region 音频转换相关

        [DllImport("G711Decode.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SoundDecode(string input, string output);

        [DllImport("G711Decode.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void PlayPcm(string path);

        public static void CreatePCMFile(string strG711FilePath, string strPCMFilePath)
        {
            FileStream fileStream = new FileStream(strG711FilePath, FileMode.Open);
            FileStream tempStream = null;
            Int64 timeStamp = 0;
            Int16 dataLength = 0;
            string deviceGuid = "";
            SynthesizeClass synthesizeClass = new SynthesizeClass();
            SoundClass soundClass = new SoundClass();
            List<SynthesizeClass> synthesizeList = new List<SynthesizeClass>();
            bool isContain = false; // 记录该设备是否已经存入
            if (fileStream.Length >= 44)
            {
                byte[] buffer = new byte[44];
                fileStream.Read(buffer, 0, 44);  //跳过前面没有用的44个字节
                while (fileStream.Position < fileStream.Length)
                {
                    if (fileStream.Position + 30 <= fileStream.Length)
                    {
                        //录音文件人员
                        buffer = new byte[30];
                        fileStream.Read(buffer, 0, 30);
                        deviceGuid = System.Text.Encoding.Default.GetString(buffer).Split('\0')[0]; // 去掉结束字符


                        if (fileStream.Position + 19 <= fileStream.Length)
                        {
                            fileStream.Seek(1, SeekOrigin.Current); // 跳过00表示的通道

                            buffer = new byte[8];
                            fileStream.Read(buffer, 0, 8);
                            timeStamp = BitConverter.ToInt64(buffer, 0);    //时间戳

                            buffer = new byte[2];
                            fileStream.Read(buffer, 0, 2);
                            dataLength = BitConverter.ToInt16(buffer, 0);
                            buffer = new byte[dataLength];

                            isContain = false;

                            if (fileStream.Position + dataLength <= fileStream.Length) // 后面有数据才开始存储
                            {
                                fileStream.Read(buffer, 0, dataLength);

                                soundClass = new SoundClass();
                                soundClass.soundData = buffer;
                                soundClass.dataLength = dataLength;
                                soundClass.timeStamp = timeStamp;

                                for (int i = 0; i < synthesizeList.Count; i++)
                                {
                                    if (synthesizeList[i].deviceGuid == deviceGuid)
                                    {
                                        isContain = true;
                                        synthesizeList[i].soundList.Add(soundClass);
                                    }
                                }

                                if (isContain == false)
                                {

                                    synthesizeClass = new SynthesizeClass();

                                    synthesizeClass.soundList = new List<SoundClass>();
                                    synthesizeClass.deviceGuid = deviceGuid;
                                    synthesizeClass.soundList.Add(soundClass);

                                    synthesizeList.Add(synthesizeClass);
                                }

                            }

                        }
                    }
                }
                fileStream.Close();
                for (int i = 0; i < synthesizeList.Count; i++)
                {
                    synthesizeClass = synthesizeList[i];
                    tempStream = new FileStream(synthesizeClass.deviceGuid + ".tmp", FileMode.OpenOrCreate);
                    tempStream.Seek(0, SeekOrigin.Begin);
                    tempStream.SetLength(0);
                    for (int j = 0; j < synthesizeClass.soundList.Count; j++)
                    {
                        tempStream.Seek(0, SeekOrigin.End);
                        tempStream.Write(synthesizeClass.soundList[j].soundData, 0, synthesizeClass.soundList[j].soundData.Length);
                        synthesizeClass.soundList[j].soundData = null;
                    }
                    tempStream.Close();
                }
                GC.Collect();
                PlayAndSave(synthesizeList, strPCMFilePath);
            }
        }

        public void PlayTalkRecord1(string strFilePath)
        {
            FileStream fileStream = new FileStream(strFilePath, FileMode.Open);
            FileStream tempStream = null;
            Int64 timeStamp = 0;
            Int16 dataLength = 0;
            string deviceGuid = "";
            SynthesizeClass synthesizeClass = new SynthesizeClass();
            SoundClass soundClass = new SoundClass();
            List<SynthesizeClass> synthesizeList = new List<SynthesizeClass>();
            bool isContain = false; // 记录该设备是否已经存入
            if (fileStream.Length >= 44)
            {
                byte[] buffer = new byte[44];
                fileStream.Read(buffer, 0, 44);  //跳过前面没有用的44个字节
                while (fileStream.Position < fileStream.Length)
                {
                    if (fileStream.Position + 30 <= fileStream.Length)
                    {
                        //录音文件人员
                        buffer = new byte[30];
                        fileStream.Read(buffer, 0, 30);
                        deviceGuid = System.Text.Encoding.Default.GetString(buffer).Split('\0')[0]; // 去掉结束字符


                        if (fileStream.Position + 19 <= fileStream.Length)
                        {
                            fileStream.Seek(1, SeekOrigin.Current); // 跳过00表示的通道

                            buffer = new byte[8];
                            fileStream.Read(buffer, 0, 8);
                            timeStamp = BitConverter.ToInt64(buffer, 0);    //时间戳

                            buffer = new byte[2];
                            fileStream.Read(buffer, 0, 2);
                            dataLength = BitConverter.ToInt16(buffer, 0);
                            buffer = new byte[dataLength];

                            isContain = false;

                            if (fileStream.Position + dataLength <= fileStream.Length) // 后面有数据才开始存储
                            {
                                fileStream.Read(buffer, 0, dataLength);

                                soundClass = new SoundClass();
                                soundClass.soundData = buffer;
                                soundClass.dataLength = dataLength;
                                soundClass.timeStamp = timeStamp;

                                for (int i = 0; i < synthesizeList.Count; i++)
                                {
                                    if (synthesizeList[i].deviceGuid == deviceGuid)
                                    {
                                        isContain = true;
                                        synthesizeList[i].soundList.Add(soundClass);
                                    }
                                }

                                if (isContain == false)
                                {

                                    synthesizeClass = new SynthesizeClass();

                                    synthesizeClass.soundList = new List<SoundClass>();
                                    synthesizeClass.deviceGuid = deviceGuid;
                                    synthesizeClass.soundList.Add(soundClass);

                                    synthesizeList.Add(synthesizeClass);
                                }

                            }

                        }
                    }
                }
                fileStream.Close();
                for (int i = 0; i < synthesizeList.Count; i++)
                {
                    synthesizeClass = synthesizeList[i];
                    tempStream = new FileStream(synthesizeClass.deviceGuid + ".tmp", FileMode.OpenOrCreate);
                    tempStream.Seek(0, SeekOrigin.Begin);
                    tempStream.SetLength(0);
                    for (int j = 0; j < synthesizeClass.soundList.Count; j++)
                    {
                        tempStream.Seek(0, SeekOrigin.End);
                        tempStream.Write(synthesizeClass.soundList[j].soundData, 0, synthesizeClass.soundList[j].soundData.Length);
                        synthesizeClass.soundList[j].soundData = null;
                    }
                    tempStream.Close();
                }
                GC.Collect();
                PlayAndSave(synthesizeList, strFilePath);
            }
        }

        private static void PlayAndSave(List<SynthesizeClass> synthesizeList, string strPCMFilePath)
        {
            Int64 minTimeStamp = 0;
            Int64 maxTimeStamp = 0;

            //WriteLog("分别寻找最短最长时间戳");
            FindMinAndMaxTimeStamp(synthesizeList, ref minTimeStamp, ref maxTimeStamp);
            //WriteLog("开始解码");
            G711ToPcm(synthesizeList, minTimeStamp, maxTimeStamp, strPCMFilePath);

        }

        private static void FindMinAndMaxTimeStamp(List<SynthesizeClass> synthesizeList, ref Int64 minTimeStamp, ref Int64 maxTimeStamp)
        {
            if (synthesizeList.Count > 0)
            {
                minTimeStamp = synthesizeList[0].soundList[0].timeStamp;
                maxTimeStamp = minTimeStamp;
            }
            for (int i = 0; i < synthesizeList.Count; i++)
            {
                if (synthesizeList[i].soundList[0].timeStamp < minTimeStamp)
                {
                    minTimeStamp = synthesizeList[i].soundList[0].timeStamp;
                }
                if (synthesizeList[i].soundList[synthesizeList[i].soundList.Count - 1].timeStamp > maxTimeStamp)
                {
                    maxTimeStamp = synthesizeList[i].soundList[synthesizeList[i].soundList.Count - 1].timeStamp;
                }
            }
        }


        private static void G711ToPcm(List<SynthesizeClass> synthesizeList, Int64 minTimestamp, Int64 maxTimestamp, string strPCMFile)
        {
            Int64 valTimeStamp = 0;
            FileStream[] fileStream = null;
            FileStream outputStream = null;
            SoundClass soundClass = new SoundClass();
            SynthesizeClass synthesizeClass = new SynthesizeClass();
            List<SoundListClass> soundlistClassList = new List<SoundListClass>();
            SoundListClass soundListClass = new SoundListClass();
            int[] listIndex = null;  // 记录上一次的索引处，避免重复索引
            List<SynthesizeClass> syntheClassListBuffer = new List<SynthesizeClass>();
            byte mixFlag = 0;

            fileStream = new FileStream[synthesizeList.Count];
            listIndex = new int[fileStream.Length];

            for (int i = 0; i < synthesizeList.Count; i++)
            {
                SoundDecode(synthesizeList[i].deviceGuid + ".tmp", synthesizeList[i].deviceGuid + ".pcm");
                fileStream[i] = new FileStream(synthesizeList[i].deviceGuid + ".pcm", FileMode.Open);
                fileStream[i].Seek(0, SeekOrigin.Begin);
                listIndex[i] = 0;

                synthesizeClass = new SynthesizeClass();
                synthesizeClass.deviceGuid = synthesizeList[i].deviceGuid;
                synthesizeClass.timeStamp = valTimeStamp;
                synthesizeClass.soundList = new List<SoundClass>();
                syntheClassListBuffer.Add(synthesizeClass);
            }

            valTimeStamp = minTimestamp; // 基准一开始给最小的时间戳
            //    Console.WriteLine("起始时间戳:" + minTimestamp + "   结束时间戳:" + maxTimestamp);
            outputStream = new FileStream(strPCMFile, FileMode.OpenOrCreate);
            outputStream.SetLength(0);

            while (true)
            {
                valTimeStamp += 40; // 新的基准加40ms

                if (valTimeStamp >= maxTimestamp)  // 碰到最大的时间戳就跳出去
                {
                    break;
                }

                /*  开始按基准将每条序列填充到新的缓冲区  */
                for (int i = 0; i < synthesizeList.Count; i++)  // 对所有设备的遍历
                {
                    syntheClassListBuffer[i].timeStamp = valTimeStamp;

                    for (int j = listIndex[i]; j < synthesizeList[i].soundList.Count; j++)  // 对每个设备里每个时间块的遍历
                    {
                        if (synthesizeList[i].soundList[j].timeStamp < valTimeStamp)
                        {
                            soundClass = new SoundClass();
                            soundClass.soundData = new byte[synthesizeList[i].soundList[j].dataLength * 2];
                            fileStream[i].Read(soundClass.soundData, 0, soundClass.soundData.Length);
                            soundClass.timeStamp = synthesizeList[i].soundList[j].timeStamp;
                            //synthesizeClass.soundList.Add(soundClass);
                            syntheClassListBuffer[i].soundList.Add(soundClass);
                        }
                        else
                        {
                            break;
                        }
                        listIndex[i]++;
                    }
                }

                /* 先扔掉多余的包 */
                for (int i = 0; i < syntheClassListBuffer.Count; i++)
                {

                    if (syntheClassListBuffer[i].soundList.Count > gMaxPacket)
                    {
                        // Console.ForegroundColor = ConsoleColor.Red;
                        // Console.WriteLine("设备:" + syntheClassListBuffer[i].deviceGuid + "  时间戳:" + syntheClassListBuffer[i].timeStamp + "  扔掉了" + (syntheClassListBuffer[i].soundList.Count - gMaxPacket).ToString() + "个包");
                        while (syntheClassListBuffer[i].soundList.Count > gMaxPacket)
                        {
                            syntheClassListBuffer[i].soundList.RemoveAt(0);  // 每次都扔掉前面的包
                        }
                    }

                }

                EnqueueWrite(syntheClassListBuffer, outputStream, false, ref mixFlag);
            }
            mixFlag = 0;
            while (true)
            {
                if (EnqueueWrite(syntheClassListBuffer, outputStream, true, ref mixFlag) == true)
                {
                    break;
                }
            }


            outputStream.Close();
            for (int i = 0; i < fileStream.Length; i++)
            {
                fileStream[i].Close();
            }
            //PlayPcm("test.pcm");
        }


        /* 队列写入文件 */
        private static bool EnqueueWrite(List<SynthesizeClass> syntheClassListBuffer, FileStream outputStream, bool flag, ref byte mixFlag)
        {
            /* 开始提取出每个缓冲区的文件并转成16位存储起来 */
            //Console.ForegroundColor = ConsoleColor.White;
            //   Console.Write("开始混包:时间戳:" + syntheClassListBuffer[0].timeStamp);
            byte[] writeData = null;
            List<short[]> readDataList = new List<short[]>();
            Int16[] readData = null;
            Int16[] mixDataList = new short[640 / 2];
            Int64 mixData = 0;
            bool result = false;

            for (int j = 0; j < syntheClassListBuffer.Count; j++)
            {

                if (syntheClassListBuffer[j].soundList.Count > 0)
                {
                    //  Console.Write("    " + syntheClassListBuffer[j].deviceGuid + ":" + syntheClassListBuffer[j].soundList[0].timeStamp + "   (" + (syntheClassListBuffer[j].soundList[0].timeStamp - syntheClassListBuffer[j].lastTimestamp).ToString ());

                    ConvertU8ToS16(syntheClassListBuffer[j].soundList[0].soundData, ref readData);
                    syntheClassListBuffer[j].lastTimestamp = syntheClassListBuffer[j].soundList[0].timeStamp;
                    syntheClassListBuffer[j].soundList.RemoveAt(0); // 移除第一个包

                    readDataList.Add(readData);
                }
                else
                {
                    mixFlag++;
                    if (mixFlag >= syntheClassListBuffer.Count)
                    {
                        return true;
                    }
                    continue;
                }
            }

            if (readDataList.Count == 0)
            {
                return false;
            }

            /* 将存储的16位文件写入文本 */

            for (int j = 0; j < 640 / 2; j++)
            {
                mixData = 0;
                for (int k = 0; k < readDataList.Count; k++)
                {
                    mixData += readDataList[k][j];
                }
                if (mixData < -32760)
                    mixData = -32760;
                if (mixData > 32760)
                    mixData = 32760;
                mixDataList[j] = (short)mixData;
            }


            ConvertS16ToU8(mixDataList, ref writeData);
            outputStream.Seek(0, SeekOrigin.End);
            outputStream.Write(writeData, 0, writeData.Length);

            return result;
            //    Console.WriteLine();
        }

        public static void CreateWAVFile(string strPCMFilePath, string strWAVFilePath)
        {
            //SoundDecode(@"E:\Test.G711", @"E:\Test.pcm");
            //PlayPcm(@"E:\Test.pcm");
            FileStream file = new FileStream(strPCMFilePath, FileMode.OpenOrCreate);
            FileStream ouputStream = new FileStream(strWAVFilePath, FileMode.Create);
            IntPtr ptr = IntPtr.Zero;
            byte[] waveByte = null;
            byte[] readByte = null;
            WaveHeader wave_hdr;

            wave_hdr.main_chunk = 0x46464952;
            wave_hdr.chunk_type = 0x45564157;
            wave_hdr.sub_chunk = 0x20746d66;
            wave_hdr.format_len = 0x10;
            wave_hdr.format = 0x0001;
            wave_hdr.channels = 1;
            wave_hdr.sample_per_sec = 8000;
            wave_hdr.avg_bytes_per_sec = 16000;
            wave_hdr.block_align = 0x02;
            wave_hdr.bits_per_sample = 16;
            wave_hdr.data_chunk = 0x61746164;

            wave_hdr.length = (uint)(file.Length + 44 - 8);
            wave_hdr.data_length = wave_hdr.length - 36;

            ptr = Marshal.AllocHGlobal(Marshal.SizeOf(wave_hdr));
            waveByte = new byte[Marshal.SizeOf(wave_hdr)];
            Marshal.StructureToPtr(wave_hdr, ptr, true);
            Marshal.Copy(ptr, waveByte, 0, waveByte.Length);

            ouputStream.Write(waveByte, 0, waveByte.Length);
            ouputStream.Seek(0, SeekOrigin.End);

            file.Seek(0, SeekOrigin.Begin);
            readByte = new byte[file.Length];
            file.Read(readByte, 0, (int)(file.Length));

            ouputStream.Write(readByte, 0, readByte.Length);


            //WriteLog("文件保存完成");
            ouputStream.Close();
            file.Close();
        }

        private static void ConvertU8ToS16(byte[] sourceData, ref Int16[] destData)
        {
            byte[] tempData = new byte[2];
            destData = new Int16[sourceData.Length / 2];

            for (int i = 0; i < sourceData.Length; i += 2)
            {
                Array.Copy(sourceData, i, tempData, 0, 2);
                destData[i / 2] = System.BitConverter.ToInt16(tempData, 0);
            }
        }

        private static void ConvertS16ToU8(Int16[] sourceData, ref byte[] destData)
        {
            byte[] tempData = new byte[2];
            destData = new byte[sourceData.Length * 2];
            for (int i = 0; i < sourceData.Length; i++)
            {
                tempData = BitConverter.GetBytes(sourceData[i]);
                tempData.CopyTo(destData, i * 2);
            }
        }

        #endregion

        public static string GetGUID(string strGUID)
        {
            string strResult = strGUID;
            strResult = strGUID.Insert(2, "-");
            int Temp_intIndex = strResult.Length - 4;
            strResult = strResult.Insert(Temp_intIndex, "-");
            return strResult;
        }
        #endregion

        #endregion
    }
}
