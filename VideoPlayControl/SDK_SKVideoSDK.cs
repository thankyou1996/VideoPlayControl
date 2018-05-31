using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
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
        /// <param name="mode">对讲模式,1，全双工，2，监听，3，喊话</param>
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

        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]//设定客户端存储根文件夹
        public static extern void p_scfs_set_save_folder(string base_folder);
        [DllImport(ProgConstants.c_strSKVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]//使能客户端文件存储
        public static extern void p_scfs_enable_save();

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

        #endregion




        public static List<RemoteVideoRecordInfo> SKRemoteVideoRecordDataPrasing(string strGUID,string strData)
        {
            List<RemoteVideoRecordInfo> result = null;
            try
            {
                int Temp_intIndex = strData.IndexOf("\0");
                if (Temp_intIndex >0)
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
            catch (Exception ex )
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
                    bolResult = false ;
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
        #endregion
    }
}
