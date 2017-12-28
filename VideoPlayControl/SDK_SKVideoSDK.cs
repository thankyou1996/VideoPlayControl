using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

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
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] guid;
            public byte length;
            public byte event_code;
            public Int32 time;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
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

        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]//码流端口 默认47924
        public static extern int p_sdkc_set_server_av_port(int av_prort);
        //char	*guid,	char *server_ip, u16	server_c_port, u16	server_v_port, u16	server_a_port
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]//默认端口  47624  47724  47824
        public static extern void p_sdkc_init_client(string clientguid, string server_ip, int server_c_port, int server_v_port, int server_a_port, string record_directory);
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]//mode:1，全双工，2，监听，3，喊话
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
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
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
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]//channel 从0开始
        public static extern void p_sdkc_start_rt_video(string guid, int channel, IntPtr handle, int enable_record, int max_mbyte, int max_min, string rec_file_path);

        /// <summary>
        /// 停止播放视频
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="channel"></param>
        /// <param name="handle"></param>
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        public static extern void p_sdkc_stop_rt_video(string guid, int channel, IntPtr handle);
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        public static extern void p_sdkc_exit_client();

        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        public static extern int p_sdkc_stop_talk(string guid);

        /// <summary>
        /// 客户端SDK在线状态
        /// 0，客户端不在线，1，客户端在线
        /// </summary>
        /// <returns></returns>
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        public static extern int p_sdkc_get_online();
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        public static extern int p_sdkc_disable_hw_render();//151201 软件解
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        public static extern int p_sdkc_enable_hw_render();//151201 硬件解码

        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        public static extern void p_vsdk_open(string strIP, int iport, out byte ret_val);
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        public static extern void p_vsdk_talkback_open(byte duplex, out byte ret_val);
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        //        * @param  mode:		模式选择
        //*						@arg 1: 实时对讲
        //                      @arg 2: 监听
        //                      @arg 3: 喊话
        //*
        public static extern void p_vsdk_talkback_start(string strGuid, byte channel, byte mode, out byte ret_val);
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        public static extern void p_vsdk_talkback_stop(string strGuid, out byte ret_val);
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        public static extern void p_vsdk_close();

        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        public static extern void p_vsdk_open_console();
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        public static extern void p_vsdk_close_console();

        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        public static extern void p_vsdk_get_device_info_all(IntPtr info_array);
        //public static extern void p_vsdk_get_device_info_all(ref client_info_all info_array);
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]//获取事件
        //public static extern void p_vsdk_pop_event(ref  st_event stevent, out  byte ret_val);
        public static extern void p_vsdk_pop_event(IntPtr stevent, out byte ret_val);
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        public static extern void p_vsdk_talkback_save_start(string file1, string file2, out byte ret_val);
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        public static extern void p_vsdk_talkback_save_stop(out byte ret_val);
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        public static extern void p_vsdk_snap_picture(string strGuid, byte snap_count, short snap_interver, byte channel, string file1_path, string file2_path, string file3_path, string file4_path, string file5_path, byte ret_val);
        //p_vsdk_snap_picture(guid_str,5,50,1,"d:\\1.jpeg","d:\\2.jpeg","d:\\3.jpeg","d:\\4.jpeg","d:\\5.jpeg",&ret_val);

        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]//设定客户端存储根文件夹
        public static extern void p_scfs_set_save_folder(string base_folder);
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]//使能客户端文件存储
        public static extern void p_scfs_enable_save();

        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int p_sdkc_start_playback_av(string guid, byte channel, UInt32 start_ts, IntPtr handle);
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int p_sdkc_stop_playback_av(string guid, byte channel, IntPtr handle);
        //170308
        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int p_sdkc_stop_talk_all();



        [DllImport("\\SKVideoSDK\\VLC_SDK.DLL")]
        public static extern void p_sdkc_get_revideo_data(string strGuid, int intChannel, string strUrl);

        #endregion
        
    }
}
