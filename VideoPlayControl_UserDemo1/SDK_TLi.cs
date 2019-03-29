using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace VideoPlayControl_UserDemo1
{
    public class ProgConstants
    {

        /// <summary>
        /// 通立SDK_TLPlay.dll
        /// </summary>
        public const string c_strTLISDKFilePath_TLPlay = "\\TLiVideoSDK\\TLPlay.dll";
        /// <summary>
        /// 通立SDK_NetDvr2.dll
        /// </summary>
        public const string c_strTLISDKFilePath_NetDvr2 = "\\TLiVideoSDK\\NetDvr2.dll";
    }
    public class SDK_TLi
    {
        public static int GetNodeIndexByDeviceID(string strDeviceID)
        {
            int intResult = -1;
            //for (int i = 0; i < VideoEnvironment_TL.devices.Count; i++)
            //{
            //    if (VideoEnvironment_TL.devices[i].devicenode.device_ID == strDeviceID)
            //    {
            //        intResult = i;
            //    }
            //}
            return intResult;
        }

        #region TLPlay



        /// <summary>
        /// 获得新的播放句柄
        /// </summary>
        /// <param name="pnPort"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_TLPlay, CallingConvention = CallingConvention.StdCall)]
        public extern static bool TLPlay_GetPort(ref int pnPort);

        /// <summary>
        /// 设置播放模式，在Open之前调用。
        /// </summary>
        /// <param name="nPort"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_TLPlay, CallingConvention = CallingConvention.StdCall)]
        public extern static bool TLPlay_SetPlayMode(int nPort, TLPLAYMODE mode);

        /// <summary>
        /// 打开码流，需先设置TL_PLAY_REALTIME_STREAM 或者TL_PLAY_POOL_STREAM 方式
        /// </summary>
        /// <param name="nPort"></param>
        /// <param name="dwPoolsize"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_TLPlay, CallingConvention = CallingConvention.StdCall)]
        public extern static bool TLPlay_OpenStream(int nPort, uint dwPoolsize);

        /// <summary>
        /// //说明：
        //		播放开始，播放视频画面大小将根据hWnd窗口调整，
        //		要全屏显示，只需把hWnd窗口放大到全屏。
        //		若已经播放，则仅改变当前播放速度为正常速度。
        //  输入参数：
        //		hWnd		播放视频的窗口句柄。
        /// </summary>
        /// <param name="nPort"></param>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_TLPlay, CallingConvention = CallingConvention.StdCall)]
        public extern static bool TLPlay_Play(int nPort, IntPtr hWnd);


        //停止播放
        [DllImport(ProgConstants.c_strTLISDKFilePath_TLPlay, CallingConvention = CallingConvention.StdCall)]
        public extern static bool TLPlay_Stop(int nPort);


        [DllImport(ProgConstants.c_strTLISDKFilePath_TLPlay, CallingConvention = CallingConvention.StdCall)]
        public extern static bool TLPlay_Close(int nPort);


        [DllImport(ProgConstants.c_strTLISDKFilePath_TLPlay, CallingConvention = CallingConvention.StdCall)]
        public extern static bool TLPlay_FreePort(int nPort);
        [DllImport(ProgConstants.c_strTLISDKFilePath_TLPlay, CallingConvention = CallingConvention.StdCall)]
        public extern static bool TLPlay_InputVideoData(int nPort, ref byte pBuf, uint nSize);
        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="nPort"></param>
        /// <param name="pBuf"></param>
        /// <param name="nSize"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_TLPlay, CallingConvention = CallingConvention.StdCall)]
        public extern static bool TLPlay_OpenFile(int nPort, string fileName);

        //[DllImport(ProgConstants.c_strTLISDKFilePath_TLPlay, EntryPoint = "TLPlay_InputVideoData", CallingConvention = CallingConvention.StdCall)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //public static extern bool TLPlay_InputVideoData(int nPort, ref byte pBuf, uint nSize);
        //public extern static bool TLPlay_InputVideoData(long nPort, ushort[] pBuf, uint nSize);

        [DllImport(ProgConstants.c_strTLISDKFilePath_TLPlay, CallingConvention = CallingConvention.StdCall)]
        public extern static uint TLPlay_GetLastError(long nPort);

        [DllImport(ProgConstants.c_strTLISDKFilePath_TLPlay, EntryPoint = "TLPlay_GetBMP", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TLPlay_GetBMP(int nPort, IntPtr sBMPFileName);


        /// <summary>
        /// 获取总时间长度
        /// </summary>
        /// <param name="nPort"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_TLPlay, EntryPoint = "TLPlay_GetFileTime", CallingConvention = CallingConvention.StdCall)]
        public static extern uint TLPlay_GetFileTime(int nPort);
        /// <summary>
        /// 获取播放百分比
        /// </summary>
        /// <param name="nPort"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_TLPlay, EntryPoint = "TLPlay_GetPlayPos", CallingConvention = CallingConvention.StdCall)]
        public static extern float TLPlay_GetPlayPos(int nPort);
        /// <summary>
        /// 设置播放进度
        /// </summary>
        /// <param name="nPort"></param>
        /// <param name="fRelativePos">0-1 0%-100%</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_TLPlay, EntryPoint = "TLPlay_SetPlayPos", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TLPlay_SetPlayPos(int nPort, float fRelativePos);
        /// <summary>
        /// 播放暂停
        /// </summary>
        /// <param name="nPort"></param>
        /// <param name="bPause">true则暂停否则恢复</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_TLPlay, EntryPoint = "TLPlay_Pause", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TLPlay_Pause(int nPort, [MarshalAs(UnmanagedType.Bool)] bool bPause);


        //播放模式
        public enum TLPLAYMODE
        {
            TL_PLAY_REALTIME_STREAM,    //实时码流方式，一次输入一帧数据，立即解码
            TL_PLAY_POOL_STREAM,        //缓冲流方式，不立即解码，通过缓冲拿数据
            TL_PLAY_FILE                //文件方式，一次播放一个文件
        };
        #endregion

        #region 结构体
        /// <summary>
        /// 设备信息
        /// </summary>
        public struct DeviceInfo
        {

            public NETDVR_devicenode_t devicenode;
            public int nHandle;
            public bool bLogin;
        }
        #endregion

        #region 接口
        /// <summary>
        /// 初始化SDK
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_startup();

        /// <summary>
        /// 释放SDK资源
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_cleanup();

        /// <summary>
        /// 注册设备(创建客户端)
        /// </summary>
        /// <param name="pAddrInfo"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_createClient(ref NETDVR_addrInfo_t pAddrInfo);

        /// <summary>
        /// 登录服务器
        /// </summary>
        /// <param name="pLoginInfo"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_loginServer_3g(ref NETDVR_loginInfo_3g_t pLoginInfo);

        /// <summary>
        /// 注销设备(注销客户端)
        /// </summary>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static void NETDVR_destroyClient();

        /// <summary>
        /// 获得设备列表
        /// </summary>
        /// <param name="pDeviceList">设备结构</param>
        /// <param name="maxnum">支持最大的设备数</param>
        /// <param name="pNum">实际的设备数</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        //public extern static int NETDVR_getDeviceList([MarshalAsAttribute(UnmanagedType.LPArray)] ref NETDVR_devicenode_t[] pDeviceList, int maxnum, ref int pNum);
        //public extern static int NETDVR_getDeviceList(ref IntPtr pDeviceList, int maxnum, ref int pNum);
        public extern static int NETDVR_getDeviceList(ref NETDVR_devicenode_t1 pDeviceList, int maxnum, ref int pNum);

        /// <summary>
        /// 注册设备GPS信息回调  add by hyc 2010.08.23 
        /// </summary>
        /// <param name="p_cb_func"></param>
        /// <param name="dwContent"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_CLIENT_regCBGps(PFUN_DEVICESTATECBMSG_T p_cb_func, uint dwContent);

        /// <summary>
        /// 注册设备更新消息回调 add by hyc 2010.07.16
        /// </summary>
        /// <param name="p_cb_func"></param>
        /// <param name="dwContent"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_CLIENT_regCBDeviceUpdate(PFUN_CBMSG_T p_cb_func, uint dwContent);

        /// <summary>
        /// 注册服务器掉线消息回调 add by hyc 2010.07.22
        /// </summary>
        /// <param name="p_cb_func"></param>
        /// <param name="dwContent"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_CLIENT_regCBMsgConnLost(PFUN_CONNMSG_T p_cb_func, uint dwContent);

        /// <summary>
        /// 注册设备状态信息回调  add by hyc 2010.08.19 
        /// </summary>
        /// <param name="p_cb_func"></param>
        /// <param name="dwContent"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_CLIENT_regCBDeviceState(PFUN_DEVICESTATECBMSG_T p_cb_func, uint dwContent);

        /// <summary>
        /// 用于注册设备异常信息回调 add by Jevstein 2011.05.19 
        /// </summary>
        /// <param name="p_cb_func"></param>
        /// <param name="dwContent"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_CLIENT_regCBDevException(PFUN_DEVICESTATECBMSG_T p_cb_func, uint dwContent);

        /// <summary>
        /// 用于注册设备开启报警回调 add by hujun 2011.11.26
        /// </summary>
        /// <param name="p_cb_func"></param>
        /// <param name="dwContent"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_CLIENT_regCBDevAlarm(PFUN_DEVICESTATECBMSG_T p_cb_func, uint dwContent);

        /// <summary>
        /// 创建设备连接
        /// </summary>
        /// <param name="p_handle"></param>
        /// <param name="id"></param>
        /// <param name="deviceInfo"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_createDVR_3g(ref int p_handle, [MarshalAs(UnmanagedType.LPStr, SizeConst = 32)]string id, ref NETDVR_devicenode_t deviceInfo);

        /// <summary>
        /// 打开视频接收器并注册原始视频数据的回拨功能
        /// </summary>
        /// <param name="Handle"></param>
        /// <param name="rcv_chn"></param>
        /// <param name="pCBFun"></param>
        /// <param name="dwContent"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_openVideoReciever(int Handle, byte rcv_chn, Delegate pCBFun, uint dwContent);

        /// <summary>
        /// 关闭视频接收器
        /// </summary>
        /// <param name="Handle"></param>
        /// <param name=""></param>
        /// <param name="rcv_chn"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_closeVideoReciever(int Handle, byte rcv_chn);


        //[DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        //public extern static int NETDVR_createVideoDecoder(int Handle, byte rcv_chn, pDecFrameCallBack pCBFun, uint dwContent);

        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_closeSubVideoReciever(int Handle, byte rcv_chn);


        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_openSubVideoReciever(int Handle, byte chn, pFrameCallBack pCBFun, uint dwContent);


        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_createSubVideoDecoder(int Handle, byte rcv_chn, pDecFrameCallBack pCBFun, uint dwContent);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Handle"></param>
        /// <param name="player_index"></param>
        /// <param name="pPlayerCBFun"></param>
        /// <param name="dwContent"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_openPlayCBReciever(int Handle, int player_index, pDecFrameCallBack pPlayerCBFun, uint dwContent);
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_destroySubVideoDecoder(int Handle, byte rcv_chn);


        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_setSubDecoderFMT(int Handle, byte rcv_chn, NETDVR_FMT_TYPE fmt);


        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_startSubVideoSend(int Handle, byte chn, bool bUsedThread = true);


        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_stopSubVideoSend(int Handle, byte rcv_chn);


        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_mutePreViewAudio(int Handle, byte rcv_chn, bool bMute);


        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_openAudioReciever(int Handle, byte rcv_chn, pFrameCallBack pCBFun, uint dwContent);



        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_regDecAudioFrameCB(int Handle, byte rcv_chn, pDecFrameCallBack pCBFun, uint dwContent);


        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_startAudioSend(int Handle, byte rcv_chn);


        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_closeAudioReciever(int Handle, byte rcv_chn);


        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_stopAudioSend(int Handle, byte rcv_chn);


        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_setSubRecordFileNameCB(int Handle, byte chn, pRecFilenameCallBack pRecFilenameCBFunc, uint dwContent);


        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_startSubRecord(int Handle, byte chn, string p_dir_path, uint file_max_len);

        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, EntryPoint = "NETDVR_startRecord")]
        public static extern int NETDVR_startRecord(int Handle, byte chn, string p_dir_path, uint file_max_len);
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_stopSubRecord(int Handle, byte chn);


        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_VOIPRegCapCB(pCapVoipFrameCallBack rcvfunc, uint dwContext);


        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public extern static int NETDVR_startVOIP(int Handle, int voipindex);
        /// <summary>
        /// 远程视频流
        /// </summary>
        /// <param name="Handle"></param>
        /// <param name="player_index"></param>
        /// <param name="pCBFun"></param>
        /// <param name="dwContent"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public static extern int NETDVR_regCBGetPlayEncFrame(int Handle, int player_index, pFrameCallBack pCBFun, uint dwContent);

        /// <summary>
        /// 截图  -  无效 
        /// </summary>
        /// <param name="Handle"></param>
        /// <param name="chn"></param>
        /// <param name="path"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, CallingConvention = CallingConvention.StdCall)]
        public static extern int NETDVR_Subsnapshot(int Handle, int chn, IntPtr path, IntPtr filename);

        /// <summary>
        /// 设置录像状态
        /// </summary>
        /// <param name="Handle"></param>
        /// <param name="p_para"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, EntryPoint = "NETDVR_SetRecordState", CallingConvention = CallingConvention.StdCall)]
        public static extern int NETDVR_SetRecordState(int Handle, IntPtr p_para);
        /// <summary>
        /// 获取录像状态
        /// </summary>
        /// <param name="Handle"></param>
        /// <param name="p_para"></param>
        /// <returns></returns>

        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, EntryPoint = "NETDVR_GetRecordState")]
        public static extern int NETDVR_GetRecordState(int Handle, ref NETDVR_ManualRecord_t p_para);
        /// <summary>
        /// 录像下载
        /// </summary>
        /// <param name="Handle"></param>
        /// <param name="s_save_dir"></param>
        /// <param name="s_save_filename"></param>
        /// <param name="pFileInfo"></param>
        /// <returns></returns>

        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, EntryPoint = "NETDVR_startFileDownload")]
        public static extern int NETDVR_startFileDownload(int Handle, string s_save_dir, string s_save_filename, IntPtr pFileInfo);


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct NETDVR_fileSearchCondition_t
        {

            /// unsigned short
            public ushort chn;

            /// <summary>
            /// 录像类型，按位取值
            /// </summary>
            public ushort type;

            /// <summary>
            /// 开始时间，从"1970-01-01 00:00:00"开始的秒数
            /// </summary>
            public uint start_time;

            /// <summary>
            /// 结束时间，从"1970-01-01 00:00:00"开始的秒数
            /// </summary>
            public uint end_time;
            /// <summary>
            /// 本次搜索起始ID，最小为1
            /// </summary>
            public ushort startID;

            /// <summary>
            /// 本次搜索最多返回条数。由于设备内存限制，max_return不能超过24
            /// </summary>
            public ushort max_return;

            /// <summary>
            /// 保留字段
            /// </summary>
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct NETDVR_recFileSearchResult_t
        {
            /// unsigned short
            public ushort sum;

            /// unsigned short
            public ushort startID;

            /// unsigned short
            public ushort endID;

            /// NETDVR_recFileInfo_t*
            public IntPtr precInfo;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct NETDVR_recFileInfo_t
        {

            /// unsigned char
            public byte channel_no;

            /// unsigned char
            public byte type;

            /// unsigned int
            public uint start_time;

            /// unsigned int
            public uint end_time;

            /// unsigned char
            public byte image_format;

            /// unsigned char
            public byte stream_flag;

            /// unsigned int
            public uint size;

            /// unsigned int
            public uint receivedsize;

            /// unsigned int
            public uint offset;

            /// char[64]
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string filename;

            /// NETDVR_recFileInfo_t*
            public IntPtr pnext;
        }

        /// <summary>
        /// 录像文件搜索
        /// </summary>
        /// <param name="Handle"></param>
        /// <param name="prfs"></param>
        /// <param name="pdesc"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, EntryPoint = "NETDVR_recFilesSearch", CallingConvention = CallingConvention.StdCall)]
        public static extern int NETDVR_recFilesSearch(int Handle, ref NETDVR_fileSearchCondition_t prfs, ref NETDVR_recFileSearchResult_t pdesc);
        //public static extern int NETDVR_recFilesSearch(int Handle, ref NETDVR_fileSearchCondition_t prfs, IntPtr pdesc);
        /// <summary>
        /// 清空搜索结果
        /// </summary>
        /// <param name="pdesc"></param>
        /// <returns></returns>

        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, EntryPoint = "NETDVR_recFilesSearchClean", CallingConvention = CallingConvention.StdCall)]
        public static extern int NETDVR_recFilesSearchClean(ref NETDVR_recFileSearchResult_t pdesc);
        /// <summary>
        /// 开始文件播放
        /// </summary>
        /// <param name="Handle"></param>
        /// <param name="player_index"></param>
        /// <param name="pFileInfo"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, EntryPoint = "NETDVR_startFilePlay")]
        public static extern int NETDVR_startFilePlay(int Handle, int player_index, IntPtr pFileInfo);
        /// <summary>
        /// 开始播放处理
        /// </summary>
        /// <param name="Handle"></param>
        /// <param name="player_index"></param>
        /// <param name="b_send_progress"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, EntryPoint = "NETDVR_playProgress")]
        public static extern int NETDVR_playProgress(int Handle, int player_index, int b_send_progress);
        [DllImport(ProgConstants.c_strTLISDKFilePath_NetDvr2, EntryPoint = "NETDVR_closePlayCBReciever")]
        public static extern int NETDVR_closePlayCBReciever(int Handle, int player_index);

        #endregion

        #region 回调

        /// <summary>
        /// 统一回调接口
        /// </summary>
        /// <param name="ptr1"></param>
        /// <param name="ptr2"></param>
        /// <param name="dwContent"></param>
        public delegate void PFUN_DEVICESTATECBMSG_T(IntPtr ptr1, IntPtr ptr2, uint dwContent);// add by hyc 2010.08.23




        //public delegate void PFUN_DEVICESTATECBMSG_T([MarshalAs(UnmanagedType.LPArray)] byte[] CBmsg, [MarshalAs(UnmanagedType.LPArray)] byte[] device_id, uint dwContent);// add by hyc 2010.08.23
        /// <summary>
        /// GPS信息回调
        /// </summary>
        public static PFUN_DEVICESTATECBMSG_T Fun_GpsInfo;
        /// <summary>
        /// 设备异常
        /// </summary>
        public static PFUN_DEVICESTATECBMSG_T Fun_DeviceException;
        /// <summary>
        /// 设备事件
        /// </summary>
        public static PFUN_DEVICESTATECBMSG_T Fun_DeviceAlarm;
        /// <summary>
        /// 设备状态
        /// </summary>
        public static PFUN_DEVICESTATECBMSG_T Fun_DeviceState;

        public delegate void PFUN_CBMSG_T(IntPtr info, uint dwContent);
        public static PFUN_CBMSG_T pFUN_CBMSG_T;

        public delegate void PFUN_CONNMSG_T(uint CONNmsg, uint dwContent);// add by hyc 2010.07.12 
        public static PFUN_CONNMSG_T pFUN_CONNMSG_T;

        public delegate void PFUN_DEVICESTATECBMSG_T1([MarshalAs(UnmanagedType.LPArray)] byte[] CBmsg, [MarshalAs(UnmanagedType.LPArray)] byte[] device_id, uint dwContent);// add by hyc 2010.08.23
        public static PFUN_DEVICESTATECBMSG_T1 pFUN_DEVICESTATECBMSG_T1;

        public delegate void PFUN_DEVICESTATECBMSG_T2([MarshalAs(UnmanagedType.LPArray)] byte[] CBmsg, [MarshalAs(UnmanagedType.LPArray)] byte[] device_id, uint dwContent);// add by hyc 2010.08.23
        public static PFUN_DEVICESTATECBMSG_T2 pFUN_DEVICESTATECBMSG_T2;

        public delegate void PFUN_DEVICESTATECBMSG_T3([MarshalAs(UnmanagedType.LPArray)] byte[] CBmsg, [MarshalAs(UnmanagedType.LPArray)] byte[] device_id, uint dwContent);// add by hyc 2010.08.23
        public static PFUN_DEVICESTATECBMSG_T3 pFUN_DEVICESTATECBMSG_T3;

        //public delegate void pFrameCallBack(FrameHeadr pFrmHdr, uint dwContextEnc);
        public delegate void pFrameCallBack(IntPtr pFrmHdr, uint dwContextEnc);
        //public delegate void pFrameCallBack(byte mediaType, [MarshalAs(UnmanagedType.LPArray)]ref byte[] pData, uint preBufSize, uint dataSize, byte frameRate, uint frameID, uint timeStamp, VideoParam videoParam, byte audioMode, uint dwContextEnc);


        //public static pFrameCallBack frameCallBack;

        public delegate void pDecFrameCallBack(FrameHeadrDec pFrmHdrDec, uint dwContext);
        //public static pDecFrameCallBack decFrameCallBack;

        public delegate void pRecFilenameCallBack(IntPtr p_filename, uint dwContext);
        public static pRecFilenameCallBack recFilenameCallBack;

        public delegate void pCapVoipFrameCallBack(IntPtr pFrame, uint iFrameLen, uint dwContext);
        public static pCapVoipFrameCallBack capVoipFrameCallBack;


        #endregion
        public struct NETDVR_ManualRecord_t
        {

            /// unsigned int
            public uint chnRecState;
        }
        public struct NETDVR_devicenode_t1
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
            public NETDVR_devicenode_t[] ss;
        }
        public enum NETDVR_RETURN_CODE //
        {
            NETDVR_SUCCESS = 0,
            NETDVR_REC_STATUS_STARTED,
            NETDVR_REC_STATUS_STOPPED,
            NETDVR_ERROR = 2000,
            NETDVR_ERR_UNKNOWN,
            NETDVR_ERR_PARAM,
            NETDVR_ERR_RET_PARAM,
            NETDVR_ERR_NOINIT,
            NETDVR_ERR_COMMAND,
            NETDVR_ERR_NEW_CONNECTION,
            NETDVR_ERR_SEND,
            NETDVR_ERR_OUTOFMEMORY,
            NETDVR_ERR_RESOURCE,
            NETDVR_ERR_FILENOTEXIST,
            NETDVR_ERR_BAUDLIMIT,                       //max = 5
            NETDVR_ERR_CREATESOCKET,                    //create socket error
            NETDVR_ERR_SOCKET,                          //socket error
            NETDVR_ERR_CONNECT,                         //connect error
            NETDVR_ERR_BIND,                            //bind error -1985
            NETDVR_ERR_LISTEN,
            NETDVR_ERR_NETSND,                          //send error
            NETDVR_ERR_NETRCV,                          //recv error
            NETDVR_ERR_TIMEOUT,                         //timeout 
            NETDVR_ERR_CHNERROR,                        // > channel limit -1980
            NETDVR_ERR_DEVICEBUSY,                      //device bush
            NETDVR_ERR_WRITEFLASH,                      //erase error 
            NETDVR_ERR_VERIFY,                          //verify error 
            NETDVR_ERR_CONFLICT,                        //system resource conflict
            NETDVR_ERR_BUSY,                            //system busy-1975
            NETDVR_ERR_USER_SAME,                       //user name conflict
            NETDVR_ERR_LINKLIMIT,
            NETDVR_ERR_DATABASE,
            /* === error code for login === */
            NETDVR_ERR_NOUSER,
            NETDVR_ERR_PASSWD,
            NETDVR_ERR_MACADDR,
            NETDVR_ERR_RELOGIN,
            NETDVR_ERR_NOLOGIN,
            /* === net player === */
            NETDVR_ERR_NETDVR_PLAYER_FULL,
            /* === updateing ==== */
            NETDVR_ERR_UPDATING,
            /* === remote file download error === */
            NETDVR_ERR_DOWNLOAD,
            NETDVR_ERR_FILEOPEN,
            NETDVR_ERR_USERSTOPPED,
            NETDVR_ERR_SERIAL_REOPEN,
            NETDVR_ERR_GET_LOCALMACADDR,
            NETDVR_ERR_SDK_CHECKFAILED,
            NETDVR_ERR_RERECIVE,
            NETDVR_ERR_SENDUPDATEFILE,
            NETDVR_ERR_NOPERMISSION,        //当前用户无权限
            NETDVR_ERR_ACCESSTIME,      //不在可访问时间段内
            NETDVR_ERR_USABLETIME,      //超出可用时长
            NETDVR_ERR_NULLPOINTER      //指针参数为空
        };

        //录像查找回放类型
        public enum NETDVR_REC_INDEX_MASK
        {
            NETDVR_REC_INDEX_TIMER = 0x1,
            NETDVR_REC_INDEX_MD = 0x2,
            NETDVR_REC_INDEX_ALARM = 0x4,
            NETDVR_REC_INDEX_HAND = 0x8,
            NETDVR_REC_INDEX_ALL = 0x10,
        };

        /* ========================== enum of decoded format type (supported currently)============================= */
        //解码视频格式
        public enum NETDVR_FMT_TYPE
        {
            NETDVR_FMT_RGB24 = 2,                   //rgb24 format
            NETDVR_FMT_RGB32 = 4,                   //rgb32 format
            NETDVR_FMT_YV12 = 6,                    //yv12 format
            NETDVR_FMT_I420 = 8,                    //i420 format
            NETDVR_FMT_YUY2 = 10,                   //yuy2 format(snapshot is not supported currently)
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct FrameHeadr
        {
            public byte mediaType;            //encoded (video/audio) media type:
            public IntPtr pData;
            //StringBuilder  ERROR
            //string         Null
            //Intptr         0x00000000
            //byte[]         Null
            //public string pData;                           //byte* pData;               //encoded data buffer
            public uint preBufSize;            //pre buffer size, normally it is 12+4+12
                                               // (FIXED HEADER + Extence option + Extence bit)
            public uint dataSize;              //actual buffer size pointed by pData
            public byte frameRate;            //frame rate, used on receive part. 
            public uint frameID;               //fram id，used on receive part. 
            public uint timeStamp;             //time stamp, used on receive part. 
            public VideoParam videoParam;
            public byte audioMode;        //8, 16, or 32 bit
        };


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct M_tVideoParam
        {

            /// BOOL->int
            [MarshalAs(UnmanagedType.Bool)]
            public bool m_bKeyFrame;

            /// WORD->unsigned short
            public ushort m_wVideoWidth;

            /// WORD->unsigned short
            public ushort m_wVideoHeight;

            /// DWORD->unsigned int
            public uint m_wBitRate;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct M_byAudioMode
        {
            /// BYTE->unsigned char
            public byte m_byAudioMode;

            /// unsigned short
            public ushort m_byAudioRate;

            /// BYTE->unsigned char
            public byte m_byAudioEncType;

            /// BYTE->unsigned char
            public byte m_byAudioDuration;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct PLAYFRAMEHDR
        {

            /// BYTE->unsigned char
            public byte m_byMediaType;

            /// BYTE[8]
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] reserved;

            /// DWORD->unsigned int
            public uint m_dwDataSize;

            /// BYTE->unsigned char
            public byte m_byFrameRate;

            /// DWORD->unsigned int
            public uint m_dwFrameID;

            /// DWORD->unsigned int
            public uint m_dwTimeStamp;
            public Anonymous_3d5d69df_3122_4137_83f1_a9b198afad7b union1;
            /// Anonymous_be800cca_50df_4f63_9911_7228491f1c43
            //public M_tVideoParam m_tVideoParam;
            //public M_byAudioMode m_byAudioMode;
        }


        [StructLayout(LayoutKind.Explicit)]
        public struct Anonymous_3d5d69df_3122_4137_83f1_a9b198afad7b
        {

            /// Anonymous_368bdec8_7c8c_4e92_b07f_b9ab95dbc0b4
            [FieldOffset(0)]
            public Anonymous_368bdec8_7c8c_4e92_b07f_b9ab95dbc0b4 m_tVideoParam;

            /// Anonymous_0584d86c_3910_4038_bad0_69ed09db9a8d
            [FieldOffset(0)]
            public Anonymous_0584d86c_3910_4038_bad0_69ed09db9a8d m_tAudioParam;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct Anonymous_368bdec8_7c8c_4e92_b07f_b9ab95dbc0b4
        {

            /// BOOL->int
            [MarshalAs(UnmanagedType.Bool)]
            public bool m_bKeyFrame;

            /// WORD->unsigned short
            public ushort m_wVideoWidth;

            /// WORD->unsigned short
            public ushort m_wVideoHeight;

            /// DWORD->unsigned int
            public uint m_wBitRate;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Anonymous_0584d86c_3910_4038_bad0_69ed09db9a8d
        {

            /// BYTE->unsigned char
            public byte m_byAudioMode;

            /// unsigned short
            public ushort m_byAudioRate;

            /// BYTE->unsigned char
            public byte m_byAudioEncType;

            /// BYTE->unsigned char
            public byte m_byAudioDuration;
        }


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct VideoParam
        {
            [MarshalAs(UnmanagedType.Bool)]
            public bool keyFrame;               //I(1) or P(0)
            public ushort videoWidth;  //video width
            public ushort videoHeight; //video height
        };

        /* ========================== structure for each decoded  frame ============================= */
        //解码码流帧结构
        public struct FrameHeadrDec
        {
            public byte mediaType;            //original encoded (video/audio) media type:
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public char[] reserved1;                  //reserved
            IntPtr data;                         //decoded data buf
            public uint data_size;             //decoded data length
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] reserved2;                 //reserved for extensible development
            public uint m_dwTimeStamp; //时间戳, 用于接收端
            public video_param video_Param;
            public byte audio_mode;       //8, 16, or 32 bit

        };
        public struct video_param
        {

            NETDVR_FMT_TYPE fmt;             //decoded format
            ushort width;       //video width
            ushort height;      //video height
        }
        /* =============== callback function type for user register  ============= */


        /* ========================== structure for the DVR information ============================= */
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_DeviceInfo_t
        {
            public uint deviceIP;                      //设备IP  
            public ushort devicePort;                      //设备端口 
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] device_name;               //设备名称
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] device_mode;               //设备型号
            public byte maxChnNum;                        //最大通道数
            public byte maxAudioNum;                  //最大音频数
            public byte maxSubstreamNum;              //最大子码流数
            public byte maxPlaybackNum;                   //最大回放数
            public byte maxAlarmInNum;                    //最大报警输入数
            public byte maxAlarmOutNum;                   //最大报警输出数
            public byte maxHddNum;                        //最大硬盘数
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserved;                 //预留
        };
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_AudioProperty_t
        {
            public byte audioEnctype;                 //预览音频编码类型
            public byte audioBitPerSample;                //预览音频位数
            public ushort audioSamplePerSec;               //预览音频采样率
            public ushort audioFrameSize;                  //预览音频每帧大小
            public ushort audioFrameDurTime;               //预览音频每帧间隔
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] reserved;                  //预留
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_VOIPProperty_t
        {
            public byte VOIPBitPerSample;             //语音对讲位数
            public ushort VOIPSamplePerSec;                //语音对讲采样率
            public ushort VOIPFrameSize;                   //语音对讲每帧大小
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] reserved;                  //预留
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_MDProperty_t
        {
            public byte MDCol;                            //移动侦测列数
            public byte MDRow;                            //移动侦测行数
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] reserved;                  //预留
        };

        //add by hyc 2010.07.12
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct NETDVR_addrInfo_t
        {
            public uint ip;                //ip address, necessary /*IN*/
            public ushort port;            //control port, necessary /*IN*//*OUT(if set 0)*/
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct NETDVR_devicenode_t
        {
            /// <summary>
            /// 设备ID
            /// </summary>
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string device_ID;
            /// <summary>
            /// 设备名称
            /// </summary>
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string device_name;
            /// <summary>
            /// 设备组
            /// </summary>
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string group;

            /// <summary>
            /// 最大通道数
            /// </summary>
            public byte maxChnNum;
            /// <summary>
            /// 最大音频数
            /// </summary>
            public byte maxAduioNum;
            /// <summary>
            /// 最大子码流数
            /// </summary>
            public byte maxSubstreamNum;
            /// <summary>
            /// 最大回放数
            /// </summary>
            public byte maxPlaybackNum;
            /// <summary>
            /// 最大报警输入数
            /// </summary>
            public byte maxAlarmInNum;
            /// <summary>
            /// 最大报警输出数
            /// </summary>
            public byte maxAlarmOutNum;
            /// <summary>
            /// 最大硬盘数
            /// </summary>
            public byte maxHddNum;
            /// <summary>
            /// 0:下线，1：上线
            /// </summary>
            public byte state;
            /// <summary>
            /// 按位操作
            /// </summary>
            public ushort recState;
            /// <summary>
            /// 0xff: 不支持这个设备，1：正常，2：无，3：未格式化，4：满， 5:读写出错
            /// </summary>
            public byte sd1state;
            /// <summary>
            /// 0xff: 不支持这个设备，1：正常，2：无，3：未格式化，4：满， 5:读写出错
            /// </summary>
            public byte sd2state;
            /// <summary>
            /// 外部存储 0xff: 不支持这个设备，1：正常，2：无，3：未格式化，4：满， 5:读写出错
            /// </summary>
            public byte outstorestate;
            /// <summary>
            /// 0xff: 不支持这个设备，1：正常，2：无，3：未格式化，4：满， 5:读写出错
            /// </summary>
            public byte hddstate;
            /// <summary>
            /// 手机号
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] mobileNumber;
            /// <summary>
            /// 硬盘信息 1：无硬盘 2：未格式化 3：硬盘满
            /// </summary>
            public byte diskinfo;
            /// <summary>
            /// SD卡信息 1：无sd卡 2：未格式化 3：sd卡满
            /// </summary>
            public byte SDCardinfo;

            // modify by wait

            //byte reserved[50];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] model;
            public ushort ver; //
            public uint buildtime;

            //byte reserved[34];

            public byte audioEnctype;                     //预览音频编码类型（g726:22）
            public byte audioBitPerSample;                //预览音频位数(g726:16)
            public ushort audioSamplePerSec;               //预览音频采样率(g726:16000)
            public ushort audioFrameSize;                  //预览音频每帧大小(g726:164)
            public ushort audioFrameDurTime;               //预览音频每帧间隔(g726:20)
            public byte devtype;                          // 南京通用0x01,0x02表示新设备,0x04表示剪切下载支持断点续传

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] custom_model;//客户定制型号,只用于显示
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] custom_verstr; //客户定制版本号,用于校验和显示, 对应custom_verstr[12]。当客户没有定制时，此字段为空，显示时需要客户端根据app版本号进行拼接。

            public byte storetype; // 1: 无,  2: sd+硬盘， 3: sd+硬盘+扩展存储， 4: 双sd卡， 5: 双sd+扩展， 6: 单sd， 7: 单sd+扩展， 8: 单硬盘， 9: 单硬盘+sd等
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_areanode_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] area_name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] parent_name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_ServerRecordName_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] deviceName;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_devicenode_wifi_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] device_ID;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] device_name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] group;

            public byte maxChnNum;                        //最大通道数
            public byte maxAduioNum;                  //最大音频数
            public byte maxSubstreamNum;              //最大子码流数
            public byte maxPlaybackNum;                   //最大回放数
            public byte maxAlarmInNum;                    //最大报警输入数
            public byte maxAlarmOutNum;                   //最大报警输出数
            public byte maxHddNum;                        //最大硬盘数

            public byte state;                            // 0:下线，1：上线
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] mobileNumber;                 //手机号

            //新增ip地址和端口
            public uint ipaddr;                                     //设备ip地址
            public ushort port;                                       //设备端口 


            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 52 - 6)]
            public byte[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct NETDVR_devicestate_t
        {
            /// <summary>
            /// 0:no hdd; 1:hdd ok; 2:hdd err
            /// </summary>
            public byte hddState;
            /// <summary>
            /// total channel num;
            /// </summary>
            public byte channelNum;
            /// <summary>
            ///  0:no rec; 1:timer rec; 2:MD rec; 3:alarm rec; 4:hand rec
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] recState;
            /// <summary>
            /// 0:ok; 1:lost
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] videoLoss;
            /// <summary>
            /// 0xff: 不支持这个设备，1：正常，2：无，3：未格式化，4：满， 5:读写出错
            /// </summary>
            public byte sd1state;
            /// <summary>
            /// 0xff: 不支持这个设备，1：正常，2：无，3：未格式化，4：满， 5:读写出错
            /// </summary>
            public byte sd2state;
            /// <summary>
            /// 外部存储 0xff: 不支持这个设备，1：正常，2：无，3：未格式化，4：满， 5:读写出错
            /// </summary>
            public byte outstorestate;
            /// <summary>
            /// 0xff: 不支持这个设备，1：正常，2：无，3：未格式化，4：满， 5:读写出错
            /// </summary>
            public byte hddstate;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
            public byte[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct NETDVR_serial_gpsrmc_info_t
        {
            /// <summary>
            /// utc 时间，格式为hhmmss.sss，北京时间须在此基础上加8小时
            /// </summary>
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string utc_position;
            /// <summary>
            /// A:定位 V:未定位	
            /// </summary>
            public byte Status;
            /// <summary>
            /// 纬度，度分格式，为ddmm.mmmm ，例3723.2475  
            /// </summary>
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string latitude;
            /// <summary>
            /// 南北纬指示 N: north ; S: south
            /// </summary>
            public byte n_s_indicator;
            /// <summary>
            /// 经度，度分格式，为dddmm.mmmm ，例12158.3416
            /// </summary>
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string longitude;
            /// <summary>
            /// 东西经指示 E: east ; W: west
            /// </summary>
            public byte e_w_indicator;
            /// <summary>
            /// 相对速度，单位为节，换算成千米/小时须乘以1.852
            /// </summary>
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string speed_over_ground;
            /// <summary>
            /// 相对方向，单位为度
            /// </summary>
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string course_over_ground;
            /// <summary>
            /// 日期，格式为日月年，例2010年8月20日为200810
            /// </summary>
            public int date;
        };


        // 设备异常信息
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct NETDVR_devexeption_t
        {
            /// <summary>
            /// 无硬盘
            /// </summary>
            public byte no_disk;
            /// <summary>
            /// 硬盘未格式化
            /// </summary>
            public byte disk_notfomat;
            /// <summary>
            /// 硬盘满
            /// </summary>
            public byte disk_full;
            /// <summary>
            /// 无SD
            /// </summary>
            public byte no_sd;
            /// <summary>
            /// SD卡未格式化
            /// </summary>
            public byte sd_notfomat;
            /// <summary>
            /// SD满
            /// </summary>
            public byte sd_full;
            /// <summary>
            /// 视频丢失 0-3位表示 1-4CH
            /// </summary>
            public ushort video_loss;
            /// <summary>
            /// 视频遮挡 保留未用
            /// </summary>
            public byte video_block;
            /// <summary>
            /// 当前写入介质坏 1表示硬盘坏 2表示SD卡坏
            /// </summary>
            public byte hdd_error;
            /// <summary>
            /// 报警 0-3位表示 1-4报警
            /// </summary>
            public ushort have_alarm_in;
            /// <summary>
            /// 发生的时间戳,北京时间须在此基础上加8小时
            /// </summary>
            public uint timestamp;
        };

        /* ========================== structure for client's login information ============================= */
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_loginInfo_t
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string username;                  //username for login
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string loginpass;                 //password for login
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string macAddr;                   //client mac address
            public uint ipAddr;                //client ip address
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct NETDVR_loginInfo_3g_t
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string name;                        // 名称，字符串
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string user;                        // 用户名，字符串
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
            public string pass;                        // 密码，字符串
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_loginInfo2_3g_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] name;                        // 名称，字符串
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] user;                        // 用户名，字符串
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public char[] pass;                        // 密码，字符串
        };

        // 客户端登陆回应
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_login_resp_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] client_ID;                     // ID，字符串
            public byte permission_preview;                   //预览权限（音频，视频，对讲，远程抓图）
            public byte permission_playback;                  //远程回放权限（搜索，下载）
            public byte permission_download;                  //远程下载权限（搜索，下载）
            public byte permission_remote_set;                //远程配置权限
            public byte permission_device_control;            //设备控制（PTZ,重启，恢复出厂设置，升级，手动录像，上油上电，断油断电，清除报警）
            public byte permission_GPS_exception_info;        //GPS,异常信息权限
            public byte permission_device_control_2;          //设备控制2（串口）
            public byte permission_storage_server;            //存储服务器（轨迹回放，抓图下载，日报警志）
            public uint group; // add by wait
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 52)]
            public byte[] reserved;
        };


        /* ========================== 主码流分辨率 ============================= */
        enum NETDVR_VIDEOFLG
        {
            NETDVR_VIDEORESOLU_CIF = 0,
            NETDVR_VIDEORESOLU_HD1 = 1,
            NETDVR_VIDEORESOLU_D1 = 2,

            NETDVR_VIDEORESOLU_QCIF = 3,
            NETDVR_VIDEORESOLU_960H = 4,
            NETDVR_VIDEORESOLU_720P = 5,
            NETDVR_VIDEORESOLU_1080P = 6,
            NETDVR_VIDEORESOLU_1080N,
        };

        /* ========================== 子码流参数 ============================= */
        enum NETDVR_SUBFLAG
        {
            NETDVR_SUBFLAG_CIF = 0,
            NETDVR_SUBFLAG_QCIF = 1,
            NETDVR_SUBFLAG_D1 = 2,
        };


        enum NETDVR_SUBBITTYPE
        {
            NETDVR_SUBBITRATE_FIXED = 0,                    //fixed bit rate
            NETDVR_SUBBITRATE_VARIABLE,                 //variable bit rate
        };

        enum NETDVR_SUBVIDEOQUALITY
        {
            NETDVR_SUBVIDEOQUALITY_BEST = 0,                //best video quality
            NETDVR_SUBVIDEOQUALITY_BETTER,              //better video quality
            NETDVR_SUBVIDEOQUALITY_GOOD,                    //good video quality
            NETDVR_SUBVIDEOQUALITY_NORMAL,              //normal video quality
            NETDVR_SUBVIDEOQUALITY_BAD,                 //bad video quality
            NETDVR_SUBVIDEOQUALITY_WORSE,               //worse video quality
        };

        enum NETDVR_SUBFRAMERATE
        {
            NETDVR_SUBFRAMERATE_30 = 30,                    //30f/s
            NETDVR_SUBFRAMERATE_25 = 25,                    //25f/s
            NETDVR_SUBFRAMERATE_20 = 20,                    //20f/s
            NETDVR_SUBFRAMERATE_15 = 15,                    //15f/s
            NETDVR_SUBFRAMERATE_12 = 12,                    //12f/s
            NETDVR_SUBFRAMERATE_10 = 10,                    //10f/s  
            NETDVR_SUBFRAMERATE_8 = 8,                  //8f/s // add by wait 20150407
            NETDVR_SUBFRAMERATE_7 = 7,                  //7f/s
            NETDVR_SUBFRAMERATE_5 = 5,                  //5f/s
            NETDVR_SUBFRAMERATE_3 = 3,                  //3f/s
            NETDVR_SUBFRAMERATE_1 = 1,                  //1f/s
        };

        enum NETDVR_SUBBITRATE
        {
            NETDVR_SUBBITRATE_16 = 16,                  //16kbps
            NETDVR_SUBBITRATE_24 = 24,                  //24kbps
            NETDVR_SUBBITRATE_32 = 32,                  //32kbps
            NETDVR_SUBBITRATE_48 = 48,                  //48kbps
            NETDVR_SUBBITRATE_64 = 64,                  //64kbps
            NETDVR_SUBBITRATE_96 = 96,                  //96kbps
            NETDVR_SUBBITRATE_128 = 128,                //128Kbps
                                                        // add by wait 20150527 --
            NETDVR_SUBBITRATE_160 = 160,
            NETDVR_SUBBITRATE_192 = 192,
            NETDVR_SUBBITRATE_224 = 224,
            // add by wait 20150527 --
            NETDVR_SUBBITRATE_256 = 256,                //256Kbps

            NETDVR_SUBBITRATE_320 = 320,                //320Kbps
            NETDVR_SUBBITRATE_384 = 384,                //384Kbps
            NETDVR_SUBBITRATE_448 = 448,                //448Kbps

            NETDVR_SUBBITRATE_512 = 512,                //512Kbps
                                                        // add by wait 20150527
            NETDVR_SUBBITRATE_768 = 768,                    //768kbps
            NETDVR_SUBBITRATE_1024 = 1024,              //1Mbps
            NETDVR_SUBBITRATE_1536 = 1536,              //1.5Mbps
            NETDVR_SUBBITRATE_2048 = 2048,              //2Mbps
        };

        enum NETDVR_FLOW_TYPE
        {
            NETDVR_FLOW_VIDEO = 0,                      //video flow
            NETDVR_FLOW_MUTI,                           //multiple flow(both video and audio)
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_SubStreamParam_t
        {
            public byte chn;
            public NETDVR_SUBFLAG sub_flag;                 //区分多种子码流列问 0 cif 1 qcif
            public NETDVR_SUBBITTYPE sub_bit_type;              //子码流位率类型
            public ushort sub_intraRate;               //关键帧间隔
            public byte sub_qi;                       //关键帧量化因子
            public byte sub_minQ;                 //最小量化因子
            public byte sub_maxQ;                 //最大量化因子
            public NETDVR_SUBVIDEOQUALITY sub_quality;              //子码流图像质量
            public NETDVR_SUBFRAMERATE sub_framerate;               //子码流的帧率
            public NETDVR_SUBBITRATE sub_bitrate;               //子码流的位率
            public uint copy2chnmask;              //复制到其他通道。每一位一个通道
                                                   //byte		reserved[16];				//保留字段
            public NETDVR_FLOW_TYPE code_type;                  //see flow_type_t
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
            public byte[] reserved;
        };


        enum NETDVR_OVERLAP
        {
            NETDVR_OVERLAP_NO = 0,                  //not overlap when disk(s) is(are) full
            NETDVR_OVERLAP_YES = 1,                 //overlap when disk(s) is(are) full
        };

        enum NETDVR_DVRSTATUS
        {
            NETDVR_DVRSTATUS_HIDDEN = 0,            //don't display the DVR status 
            NETDVR_DVRSTATUS_DISPLAY = 1,           //display the DVR status
        };

        /* ========================== keybord lock time============================= */
        enum NETDVR_LOCKTIME
        {
            NETDVR_LOCKTIME_NEVER = 0,          //never lock
            NETDVR_LOCKTIME_MIN_1 = 60,         //lock time equals 1 minute
            NETDVR_LOCKTIME_MIN_2 = 120,            //lock time equals 2 minutes
            NETDVR_LOCKTIME_MIN_5 = 300,            //lock time equals 5 minutes
            NETDVR_LOCKTIME_MIN_10 = 600,           //lock time equals 10 minutes
            NETDVR_LOCKTIME_MIN_20 = 1200,          //lock time equals 20 minutes
            NETDVR_LOCKTIME_MIN_30 = 1800,          //lock time equals 30 minutes
        };

        enum NETDVR_SWITCHTIME
        {
            NETDVR_SWITCHTIME_NEVER = 0,        //never switch
            NETDVR_SWITCHTIME_SEC_5 = 5,        //switch time equals 5 seconds
            NETDVR_SWITCHTIME_SEC_10 = 10,      //switch time equals 10 seconds
            NETDVR_SWITCHTIME_SEC_20 = 20,      //switch time equals 20 seconds
            NETDVR_SWITCHTIME_SEC_30 = 30,      //switch time equals 30 seconds
            NETDVR_SWITCHTIME_MIN_1 = 60,       //switch time equals 1 minute
            NETDVR_SWITCHTIME_MIN_2 = 120,      //switch time equals 2 minute
            NETDVR_SWITCHTIME_MIN_5 = 300,      //switch time equals 5 minute
        };

        enum NETDVR_VIDEOFORMAT
        {
            NETDVR_VIDEOFORMAT_PAL = 0,         //PAL video format
            NETDVR_VIDEOFORMAT_NTSC = 1,        //NTSC video format
        };
        //typedef enum NETDVR_VIDEOFORMAT video_format_t;

        /* ========================== VGASOLUTION param structure =========================== */

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_VGAPROPERTY
        {
            public ushort width;                       //分辨率宽
            public ushort height;                      //分辨率高
            public byte flashrate;                    //分辨率刷新率
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_VGARESOLLIST
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public NETDVR_VGAPROPERTY[] vgapro;
        };


        enum NETDVR_TRANSPARENCY
        {
            NETDVR_TRANSPARENCY_NO = 0,             //no transparency
            NETDVR_TRANSPARENCY_LOW = 1,            //low transparency
            NETDVR_TRANSPARENCY_MID = 2,            //middle transparency
            NETDVR_TRANSPARENCY_HIGH = 3,           //high transparency
        };

        /* ========================== sys param structure =========================== */
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_systemParam_t
        {
            public ushort device_id;                   //the dvr device id for remote control
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] device_name;           //device name of dvr
            public byte disable_pw;
            public NETDVR_OVERLAP flag_overlap;            //flag_overlap=1, then overlap the disk when the disk is full. or if flag_overlap=0, then not overlap
            public NETDVR_DVRSTATUS flag_statusdisp;       //decide whether to dispay system status or not
            public NETDVR_LOCKTIME lock_time;              //lock time for keybord
            public NETDVR_SWITCHTIME switch_time;          //switch time for preview mode
            public NETDVR_VIDEOFORMAT video_format;        //PAL or NTSC
            public byte vga_solution;
            public NETDVR_TRANSPARENCY transparency;       //menu transparency
            public int languageindex;              //language index of languagelist

            // add by wait ---

            public byte disk_delay; //写硬盘延时
            public ushort shut_delay; //关机延时
            public byte startup_mod; //开机方式0:acc ，1定时
            public byte preview; //预览通道
            public ushort previewdelay; //预览延时
            public byte using_chn; //有效的通道，按位表示 0表示有效 1表示无效

            public ushort startup_delay;// 开机延时 （单位秒）

            // add by wait ---
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct ifly_AlarmInMax_t
        {
            public ushort nCount;//报警信息总个数
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct ifly_getAlarmInInfo_t
        {
            public byte chn;              //通道
            public byte Enable;           // 启用(0 不启用  1启用)
            public byte flag_buzz;        //触发蜂鸣器(0 不触发  1触发)
            public byte logic;            //逻辑反 （0 不启用  1启用） 
            public byte alarmoutnum;      //报警输出通道数(1表示1路报警输出，2表示2路报警输出)
            public ushort alarmout;        //报警输出通道 (按位移, 对应选中通道位置1,从0开始)
            public ushort triggelist;      //触发列表 (按位移  第0位 表示是否能选择   第1位负触发， 第2位正触发)
            public byte trigge;          //触发值 下标
            public uint picswitchlist;   //画面切换列表 (按位移, AV1 - AV8)
            public byte picswitch;       //画面切换值 下标
            public ushort delaylist;       //延时列表（(按位移, 0 - 16）
            public byte delay;           //延时值 下标
            public ushort reporttypelist;  //上报类型列表 (按位移, 0位不上报 1位普通 2位紧急报警)
            public ushort reporttype;      //上报类型值 下标
            public uint alarrecordvalidchn; //报警录像有效通道（按位移 0-7表示8个通道，有效则相应位取值为1，无效取值为0）
            public uint alarrecord;      //报警录像通道 (按位移  对应选中通道位置1,从0开始)

            public Snap_t snap_t;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public char[] eventz;       //事件名称
            public uint copy2chnmask;     //复制到其他通道。每一位一个通道
        };


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct Snap_t
        {
            public uint snapvalidchn; //抓拍有效通道（按位移 0-7表示8个通道，有效则相应位取值为1，无效取值为0）
            public uint snaprecord;   //抓拍通道 (按位移  对应选中通道位置1,从0开始
            public byte snaptype;      //0 单拍 1双拍 2连拍
            public byte snapcount;    //连拍数量
            public ushort snaptime;     //连拍间隔(秒)
        };


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct ifly_getAlarmInInfo_list
        {
            public int ioAlarmChnCount;  //io报警中的通道个数
            public ifly_getAlarmInInfo_t pAlarmConfig;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct ifly_setAlarmInInfo_t
        {

            public byte chn;               //通道
            public byte Enable;            // 启用(0 不启用  1启用)
            public byte flag_buzz;         //触发蜂鸣器(0 不触发  1触发)
            public byte logic;             //逻辑反 （0 不启用  1启用） 
            public ushort alarmout;         //报警输出通道 (按位移, 对应选中通道位置1,从0开始)
            public byte trigge;           //触发值 下标
            public byte picswitch;        //画面切换值 下标
            public byte delay;            //延时值 下标
            public ushort reporttype;       //上报类型值 下标
            public uint alarrecord;       //报警录像通道 (按位移  对应选中通道位置1,从0开始)
            public uint snaprecord;       //抓拍选择的通道（按位移  对应选中通道位置1,从0开始）

            public Snap_t1 snap_t;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public char[] eventname;       //事件名称
            public uint copy2chnmask; //复制到其他通道。每一位一个通道
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct Snap_t1
        {
            public byte snaptype;      //0 单拍 1双拍 2连拍
            public byte snapcount;    //连拍数量
            public ushort snaptime;     //连拍间隔(秒)
        };

        enum NETDVR_BAUDRATE
        {
            NETDVR_BAUDRATE_115200 = 0,
            NETDVR_BAUDRATE_57600 = 1,
            NETDVR_BAUDRATE_38400 = 2,
            NETDVR_BAUDRATE_19200 = 3,
            NETDVR_BAUDRATE_9600 = 4,
            NETDVR_BAUDRATE_4800 = 5,
            NETDVR_BAUDRATE_2400 = 6,
            NETDVR_BAUDRATE_1200 = 7,
            NETDVR_BAUDRATE_300 = 8,
        };

        enum NETDVR_DATABITSEL
        {
            NETDVR_DATABITSEL_8 = 0,                //data bit: 8 bits
            NETDVR_DATABITSEL_7 = 1,                //data bit: 7 bits
            NETDVR_DATABITSEL_6 = 2,                //data bit: 6 bits
        };

        enum NETDVR_STOPBITSEL
        {
            NETDVR_STOPBITSEL_1 = 0,                //stop bit: 1 bit
            NETDVR_STOPBITSEL_2 = 1,                //stop bit: 2 bits
        };

        enum NETDVR_CHECK_TYPE
        {
            NETDVR_CHECK_NONE = 0,                  //no check
            NETDVR_CHECK_ODD = 1,                   //odd check
            NETDVR_CHECK_EVEN = 2,                  //even check
        };

        enum NETDVR_FLOWCONTROL
        {
            NETDVR_FLOWCONTROL_NO = 0,              //no flow control
            NETDVR_FLOWCONTROL_HARDWARE = 1,        //flow control by hardware
            NETDVR_FLOWCONTROL_XON_XOFF = 2,        //flow control by Xon/Xoff
        };

        enum NETDVR_PROTOCOLTYPE
        {
            NETDVR_PROTOCOLTYPE_PELCO_D = 0,        //protocol type : Pelco-d
            NETDVR_PROTOCOLTYPE_PELCO_P = 1,        //protocol type : Pelco-p
            NETDVR_PROTOCOLTYPE_B01 = 2,            //protocol type : B01
            NETDVR_PROTOCOLTYPE_SAMSUNG = 3,        //protocol type : Samsung
        };

        enum NETDVR_YTTRACKCONTROL
        {
            NETDVR_YT_COM_STARTRECORDTRACK = 0,
            NETDVR_YT_COM_STOPRECORDTRACK = 1,
            NETDVR_YT_COM_STARTTRACK = 2,
            NETDVR_YT_COM_STOPTRACK = 3,
        };

        enum NETDVR_YTPRESETPOINTCONTROL
        {
            NETDVR_YT_COM_ADDPRESETPOINT = 0,
            NETDVR_YT_COM_DELPRESETPOINT = 1,
            NETDVR_YT_COM_TOPRESETPOINT = 2,
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_cruisePos_t
        {
            public byte preset_no;                //1 ~ MAX_PRESET_NUM
            public byte dwell_time;               //1 ~ 255 secondes
            public byte cruise_speed;             //1 ~ MAX_CRUISE_SPEED(1 : the slowest speed)
            public byte cruise_flag;              //1-add 2-del
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_cruisePath_t
        {
            public byte chn;
            public byte path_no;                                      //1 ~ MAX_CRUISE_PATH_NUM	
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public NETDVR_cruisePos_t[] cruise_pos; //cruise poisitions of cruise path
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_ptzParam_t
        {
            public byte chn;                      //通道
            public ushort address;
            public NETDVR_BAUDRATE baud_ratesel;
            public NETDVR_DATABITSEL data_bitsel;
            public NETDVR_STOPBITSEL stop_bitsel;
            public NETDVR_CHECK_TYPE check_type;
            public NETDVR_FLOWCONTROL flow_control;
            public NETDVR_PROTOCOLTYPE protocol;
            public uint copy2Chnmask;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] reserved;
        };


        enum NETDVR_PTZCONTROL
        {
            NETDVR_PTZ_COM_STOP = 0,
            NETDVR_PTZ_COM_MOVEUP = 1,
            NETDVR_PTZ_COM_MOVEDOWN = 2,
            NETDVR_PTZ_COM_MOVELEFT = 3,
            NETDVR_PTZ_COM_MOVERIGHT = 4,
            NETDVR_PTZ_COM_ROTATION = 5,
            NETDVR_PTZ_COM_ZOOMADD = 6,
            NETDVR_PTZ_COM_ZOOMSUBTRACT = 7,
            NETDVR_PTZ_COM_FOCUSADD = 8,
            NETDVR_PTZ_COM_FOCUSSUBTRACT = 9,
            NETDVR_PTZ_COM_APERTUREADD = 10,
            NETDVR_PTZ_COM_APERTURESUBTRACT = 11,
            NETDVR_PTZ_COM_LIGHTINGOPEN = 12,
            NETDVR_PTZ_COM_LIGHTINGCLOSE = 13,
            NETDVR_PTZ_COM_WIPERSOPEN = 14,
            NETDVR_PTZ_COM_WIPERSCLOSE = 15,
            NETDVR_PTZ_COM_FAST = 16,
            NETDVR_PTZ_COM_NORMAL = 17,
            NETDVR_PTZ_COM_SLOW = 18,
            NETDVR_PTZ_COM_AUXILIARYOPEN = 19,
            NETDVR_PTZ_COM_AUXILIARYCLOSE = 20,
        };



        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_PtzCtrl_t
        {
            public byte chn;                          //通道
            public NETDVR_PTZCONTROL cmd;                          //命令
            public byte aux;                      //辅助功能
        };

        enum NETDVR_LOGSEARCH_MODE
        {
            NETDVR_LOGSEARCH_MODE_BOTH = 0,         //search by both type and time
            NETDVR_LOGSEARCH_MODE_TYPE = 1,         //search by type
            NETDVR_LOGSEARCH_MODE_TIME = 2,         //search by time
        };

        enum NETDVR_LOGSEARCH_MAIN
        {
            NETDVR_LOGSEARCH_MAIN_ALARM = 0,        //search alarm logs
            NETDVR_LOGSEARCH_MAIN_LOCALOP = 1,      //search local operation logs
            NETDVR_LOGSEARCH_MAIN_REMOTEOP = 2,     //search remote operation logs
            NETDVR_LOGSEARCH_MAIN_EXCEPTION = 3,    //search exception logs
            NETDVR_LOGSEARCH_MAIN_ALL = 4,          //search all logs
            NETDVR_LOGSEARCH_MAIN_3G = 5,
            NETDVR_LOGSEARCH_EVENT = 7,
        };

        enum NETDVR_LOGSEARCH_SLAVE
        {
            /*NETDVR_LOGSEARCH_MAIN_ALARM's slave type*/
            NETDVR_LOGSEARCH_ALARM_IN_BEGIN = 0,    //search alarm input begining logs
            NETDVR_LOGSEARCH_ALARM_IN_END,          //search alarm input ending logs
            NETDVR_LOGSEARCH_ALARM_MD_BEGIN,        //search md alarm begining logs
            NETDVR_LOGSEARCH_ALARM_MD_END,          //search md alarm ending logs
            NETDVR_LOGSEARCH_ALARM_ALL,             //search all alarm logs
                                                    /*NETDVR_LOGSEARCH_MAIN_LOCALOP's slave type*/
            NETDVR_LOGSEARCH_LOCALOP_STARTUP = 16,  //search local operatoin's startup logs
            NETDVR_LOGSEARCH_LOCALOP_SHUTDOWN,      //search local operatoin's shutdown logs
            NETDVR_LOGSEARCH_LOCALOP_LOGIN,         //search local operatoin's login logs
            NETDVR_LOGSEARCH_LOCALOP_LOGOUT,        //search local operatoin's logout logs
            NETDVR_LOGSEARCH_LOCALOP_CONFIG,        //search local operatoin's config logs
            NETDVR_LOGSEARCH_LOCALOP_REC_START,     //search local operatoin's record start logs
            NETDVR_LOGSEARCH_LOCALOP_REC_STOP,      //search local operatoin's record stop logs
            NETDVR_LOGSEARCH_LOCALOP_UPDATE,        //search local operatoin's update logs
            NETDVR_LOGSEARCH_LOCALOP_FORMAT,        //search local operatoin's format logs
            NETDVR_LOGSEARCH_LOCALOP_ALL,           //search all local operatoin logs
                                                    /*NETDVR_LOGSEARCH_MAIN_REMOTEOP's slave type*/
            NETDVR_LOGSEARCH_REMOTEOP_LOGIN = 32,   //search remote operatoin's login logs
            NETDVR_LOGSEARCH_REMOTEOP_LOGOUT,       //search remote operatoin's logout logs
            NETDVR_LOGSEARCH_REMOTEOP_REC_START,    //search remote operatoin's record start logs
            NETDVR_LOGSEARCH_REMOTEOP_REC_STOP,     //search remote operatoin's record stop logs
            NETDVR_LOGSEARCH_REMOTEOP_CONFIG,       //search remote operatoin's config logs
            NETDVR_LOGSEARCH_REMOTEOP_RESTART,      //search remote operatoin's restart logs
            NETDVR_LOGSEARCH_REMOTEOP_VOIP_START,   //search remote operatoin's voip start logs
            NETDVR_LOGSEARCH_REMOTEOP_VOIP_STOP,    //search remote operatoin's voip stop logs
            NETDVR_LOGSEARCH_REMOTEOP_UPDATE,       //search remote operatoin's update logs
            NETDVR_LOGSEARCH_REMOTEOP_ALL,          //search all remote operatoin logs
                                                    /*NETDVR_LOGSEARCH_MAIN_EXCEPTION's slave type*/
            NETDVR_LOGSEARCH_EXCEPTION_VLOSS = 48,  //search exception's video loss logs
            NETDVR_LOGSEARCH_EXCEPTION_VBLIND,      //search exception's video blind logs
            NETDVR_LOGSEARCH_EXCEPTION_HDD_ERR,     //search exception's hdd error logs
            NETDVR_LOGSEARCH_EXCEPTION_HDD_FULL,    //search exception's hdd full logs
            NETDVR_LOGSEARCH_EXCEPTION_ILLEGALOP,   //search exception's illegal operation logs
            NETDVR_LOGSEARCH_EXCEPTION_ALL,         //search all exception logs
        };

        enum NETDVR_SENDMEDIA_TYPE
        {
            NETDVR_TYPE_UDP = 0,
            NETDVR_TYPE_TCP = 1,
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_SendMediaType_t
        {
            public NETDVR_SENDMEDIA_TYPE mediatype;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
            public byte[] reserved;
        };

        enum NETDVR_STORAGEMEDIUM_TYPE
        {
            NETDVR_STORAGETYPE_SD = 0,
            NETDVR_STORAGETYPE_HD = 1,
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_StorageMedium_t
        {
            public NETDVR_STORAGEMEDIUM_TYPE mediatype;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_LanTianinfo_t
        {
            public byte bUpdateRecord;
            public byte Sensitivity;
            public byte Angle;
            public byte TireThreshold;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] reserved;
        };

        /* ========================== structure for log index condition============================= */
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_logSearchCondition_t
        {
            public NETDVR_LOGSEARCH_MODE query_mode;            //search by 3 modes: see logsearch_mode_t
            public NETDVR_LOGSEARCH_MAIN main_type;             //see logsearch_main_t
            public NETDVR_LOGSEARCH_SLAVE slave_type;           //see logsearch_slave_t
            public ushort max_return;              //the max return logs number(how many logs you want to get) [<=12]
            public ushort startID;                 //ignore the front (startID - 1) logs [>=1]
            public uint start_time;                //search from start time
            public uint end_time;                  //search to end time

        };

        /* ========================== structure for each indexed log information============================= */
        struct NETDVR_logInfo_t
        {
            //public uint startTime;                 //log created time
            //public byte main;
            //public byte slave;
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            //public char[] loginfo;                       //log info
            //public NETDVR_logInfo_t* pnext;
        };

        /* ========================== structure for index result's information of logs============================= */
        struct NETDVR_logSearchResult_t
        {
            //public ushort sum;                     //total records of found logs
            //public ushort startID;                 //if no file is indexed, startID will be 0, or it'll be a value based on index condition's startID(struct NETDVR_logSearchCondition_t)
            //public ushort endID;                   //结束的记录,基址为1.当endID和startID相等时,表示之返回一条记录

            //public NETDVR_logInfo_t* pH;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_AlarmfileSearch_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public char[] devicename;                    //device name
            public uint chn;                               //searched channel number
            public byte type;                     //record type
            public uint start_time;                //search from start time
            public uint end_time;                  //search to end time
            public ushort startID;                 //ignore the front (startID - 1) records
            public ushort max_return;              //the max return records number(how many records you want to get)
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
            public byte[] reserved;
        };



        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_TimePlayCond_t
        {
            public byte chn;                              //searched channel number
            public ushort type;                        //record type
            public uint start_time;                //search from start time
            public uint end_time;
        };


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_videoParam_t
        {
            public byte channel_no;                   //通道号
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] channelname;           //通道名
            public byte flag_name;                    //名称位置显示
            public ushort chnpos_x;                    //名称x坐标
            public ushort chnpos_y;                    //名称y坐标
            public byte flag_time;                    //时间位置显示
            public ushort timepos_x;                   //时间x坐标
            public ushort timepos_y;                   //时间y坐标
            public byte flag_mask;                    //遮盖

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public Net_maskAREA_t[] maskinfo;
            //handler
            public byte flag_safechn;             //安全通道标记
            public uint copy2chnmask;              //复制到其他通道。每一位一个通道
                                                   // modify by wait
                                                   //byte		reserved[16];				//保留字段

            public ushort enc_timepos_x;                   //编码叠加时间x坐标
            public ushort enc_timepos_y;                   //编码叠加时间y坐标
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte reserved;             //保留字段


        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct Net_maskAREA_t
        {
            public ushort x;
            public ushort y;
            public ushort width;
            public ushort height;
        }

        enum NETDVR_BITRATE_TYPE
        {
            NETDVR_BITRATE_FIXED = 0,                   //fixed bit rate
            NETDVR_BITRATE_VARIABLE,                    //variable bit rate
        };

        enum NETDVR_BITRATE
        {
            NETDVR_BITRATE_64 = 64,                 //64kbps
            NETDVR_BITRATE_128 = 128,                   //128kbps
            NETDVR_BITRATE_256 = 256,                   //256kbps
            NETDVR_BITRATE_384 = 384,                   //384kbps
            NETDVR_BITRATE_512 = 512,                   //512kbps
            NETDVR_BITRATE_768 = 768,
            NETDVR_BITRATE_1024 = 1024,             //1Mbps
            NETDVR_BITRATE_1536 = 1536,             //1.5Mbps
                                                    // add by wait 20150527
            NETDVR_BITRATE_2048 = 2048,             //2Mbps
        };

        enum NETDVR_VIDEO_QUALITY
        {
            NETDVR_VIDEO_QUALITY_BEST = 0,              //best video quality
            NETDVR_VIDEO_QUALITY_BETTER,                //better video quality
            NETDVR_VIDEO_QUALITY_GOOD,                  //good video quality
            NETDVR_VIDEO_QUALITY_NORMAL,                //normal video quality
            NETDVR_VIDEO_QUALITY_BAD,                   //bad video quality
            NETDVR_VIDEO_QUALITY_WORSE,             //worse video quality
        };

        enum NETDVR_FRAMERATE
        {
            NETDVR_FRAMERATE_30 = 30,                   //30f/s
            NETDVR_FRAMERATE_25 = 25,                   //25f/s
            NETDVR_FRAMERATE_20 = 20,                   //20f/s
            NETDVR_FRAMERATE_15 = 15,                   //15f/s
            NETDVR_FRAMERATE_12 = 12,                   //15f/s
            NETDVR_FRAMERATE_10 = 10,                   //10f/s
            NETDVR_FRAMERATE_8 = 8,                 //10f/s
            NETDVR_FRAMERATE_7 = 7,                 //10f/s
            NETDVR_FRAMERATE_5 = 5,                 //5f/s
            NETDVR_FRAMERATE_3 = 3,                 //3f/s
                                                    // add by wait 20150527
            NETDVR_FRAMERATE_2 = 2,                 //2f/s
            NETDVR_FRAMERATE_1 = 1,                 //1f/s
        };

        enum NETDVR_PRERECORD_TIME
        {
            NETDVR_PRERECORD_TIME_0 = 0,                //do not pre-record
            NETDVR_PRERECORD_TIME_5 = 5,                    //pre-record time: 5s
            NETDVR_PRERECORD_TIME_10 = 10,                  //pre-record time: 10s
            NETDVR_PRERECORD_TIME_15 = 15,                  //pre-record time: 15s
            NETDVR_PRERECORD_TIME_20 = 20,                  //pre-record time: 20s
            NETDVR_PRERECORD_TIME_25 = 25,                  //pre-record time: 25s
            NETDVR_PRERECORD_TIME_30 = 30,                  //pre-record time: 30s
        };

        enum NETDVR_POSTRECORD_TIME
        {
            NETDVR_POSTRECORD_TIME_5 = 5,                   //post-record time: 5s
            NETDVR_POSTRECORD_TIME_10 = 10,                 //post-record time: 10s
            NETDVR_POSTRECORD_TIME_30 = 30,                 //post-record time: 30s
            NETDVR_POSTRECORD_TIME_60 = 60,                 //post-record time: 60s
            NETDVR_POSTRECORD_TIME_120 = 120,               //post-record time: 120s
            NETDVR_POSTRECORD_TIME_300 = 300,               //post-record time: 300s
            NETDVR_POSTRECORD_TIME_600 = 600,               //post-record time: 600s
        };


        struct NETDVR_recordParam_t
        {
            public byte channelno;                    //通道号
            public NETDVR_FLOW_TYPE code_type;                  //see flow_type_t
            public NETDVR_BITRATE_TYPE bit_type;                //see bitrate_type_t
            public NETDVR_BITRATE bit_max;                      //see bitrate_t
            public ushort intraRate;                   //关键帧间隔
            public byte qi;                           //关键帧量化因子
            public byte minQ;                     //最小量化因子
            public byte maxQ;                     //最大量化因子
            public NETDVR_VIDEO_QUALITY quality;                //see video_quality_t
            public NETDVR_FRAMERATE frame_rate;                 //see framerate_t
            public NETDVR_PRERECORD_TIME pre_record;            //see prerecord_time_t
            public NETDVR_POSTRECORD_TIME post_record;          //see postrecord_time_t

            public uint copy2chnmask;
            public byte supportdeinter;
            public byte deinterval;
            public byte supportResolu;                        // 是否支持设置录像分辨率，0 不支持， 1 支持
            public byte resolutionpos;                        //　分辨率选项值 
            public byte video_mode;                       // 视频制式  0 PAL,  1 NTSC

            public byte nPreRecord;                   //预录时间
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] reserved;             //保留字段

        };



        enum NETDVR_WEEKDAY
        {
            NETDVR_WEEKDAY_1 = 0,                       //Monday
            NETDVR_WEEKDAY_2,                           //Tuesday
            NETDVR_WEEKDAY_3,                           //Wednesday
            NETDVR_WEEKDAY_4,                           //Thursday
            NETDVR_WEEKDAY_5,                           //Friday
            NETDVR_WEEKDAY_6,                           //Saturday
            NETDVR_WEEKDAY_7,                           //Sunday
        };


        /* ======================================================= */
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct RecTimeField_t
        {
            public uint starttime;                 //起始时间
            public uint endtime;                   //终止时间
            public byte flag_sch;                 //定时录像
            public byte flag_md;                  //移动侦测录像
            public byte flag_alarm;                   //报警录像
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] reserved;              //保留字段
        };

        //录像布防
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_RecordSCH_t
        {
            public byte chn;                      //通道
            public NETDVR_WEEKDAY weekday;                  //星期
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public RecTimeField_t[] recTimeFieldt;
            public byte copy2Weekday;             //复制到其他天  按位 
            public uint copy2Chnmask;              //复制到其他通道。按位
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserved;             //保留字段
        };


        enum NETDVR_ALARMINTYPE
        {
            NETDVR_ALARMIN_HIGH = 1,                //high level alarm input
            NETDVR_ALARMIN_LOW,                     //low level alarm input
        };

        enum NETDVR_ALARMOUTYPE
        {
            NETDVR_ALARMOUT_NO = 1,                 //alarm output type:normal open
            NETDVR_ALARMOUT_NC,                     //alarm output type:normal close
        };

        enum NETDVR_DELAY_TIME
        {
            NETDVR_DELAY_0 = 0,                 // 无
            NETDVR_DELAY_3 = 3,                 // 3
            NETDVR_DELAY_5 = 5,                 //5s
            NETDVR_DELAY_10 = 10,                   //10s
            NETDVR_DELAY_30 = 30,                   //30s
            NETDVR_DELAY_60 = 60,                   //60s
            NETDVR_DELAY_300 = 61,              //10分
            NETDVR_DELAY_600 = 62,              //20分
            NETDVR_DELAY_900 = 63,              //30分
            NETDVR_DELAY_MANUAL = 0xffff,       //manual
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct AlarmInPtz                           //关联ptz
        {
            public byte flag_preset;          //预置点
            public byte preset;
            public byte flag_cruise;          //巡航点
            public byte cruise;
            public byte flag_track;               //轨迹
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_alarmInParam_t
        {
            public byte inid;                     //报警输入量
            public byte flag_deal;                    //1: deal with input alarm ; 0: for no
            public NETDVR_ALARMINTYPE typein;                       //input alarm type:see alarmintype_t
            public uint triRecChn;                 //触发录像通道，每一位一通道
            public uint triAlarmoutid;             //触发报警输出，按位
            public byte flag_buzz;                    //触发蜂鸣器
            public byte flag_email;                   //触发emaill
            public byte flag_mobile;              //触发手机报警
            public uint delaytime;
            public NETDVR_DELAY_TIME delay;                      //报警输出延时
            public uint copy2AlarmInmask;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public AlarmInPtz[] alarmptz;
            public byte change_chn; // 切换视频 add by wait
            public byte benableftp; // 是否启用ftp功能
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserved;             //保留字段
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_alarmOutParam_t
        {
            public byte outid;                        //报警输出量 
            public NETDVR_ALARMOUTYPE typeout;                 //报警输出类型
            public uint copy2AlarmOutmask;         //复制到其他报警输出。按位
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserved;             //保留字段

        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_AlarmNoticeParam_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] alarm_email;           //报警email地址
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] alarm_mobile;          //报警手机地址
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] reserved;             //保留字段
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_networkParam_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public char[] mac_address;           //mac地址
            public uint ip_address;                    //ip地址
            public ushort server_port;             //设备端口
            public uint net_mask;                  //掩码
            public uint net_gateway;               //网关
            public uint dns;                       //dns
            public byte flag_multicast;               //组播启用标记
            public uint multicast_address;         //组播地址
            public ushort http_port;                   //http端口
            public byte flag_pppoe;                   //pppoe启用标记
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] pppoe_user_name;       //pppoe用户名
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] pppoe_passwd;          //pppoe密码
            public byte flag_dhcp;                    //dhcp启用标志
            public byte ddnsserver;                   //ddns服务商
            public byte flag_ddns;                    //ddns启用标志
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] ddns_domain;           //ddns域名
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] ddns_user;             //ddns用户名
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] ddns_passwd;           //ddns密码
            public uint centerhost_address;            //中心服务器地址
            public ushort centerhost_port;         //中心服务器端口
            public ushort mobile_port;             //手机监控端口
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
            public byte[] reserved;             //保留字段
        };


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_progressParam_t
        {
            public uint curr_pos;
            public uint total_size;
        };
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_AlarmUploadState_t
        {
            //0-信号量报警,1-硬盘满,2-信号丢失,3－移动侦测,4－硬盘未格式化,
            //5-读写硬盘出错,6-遮挡报警,7-制式不匹配, 8-非法访问
            public byte type;
            public byte state;            //1报警 2恢复
            public byte id;               //通道,硬盘号,报警输入号,取决于type 
            public ushort reserved1;       //预留
            public uint reserved2;     //预留	
        };
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct NETDVR_AlarmUploadState3g_t
        {
            /// <summary>
            /// <para>0-信号量报警,1-硬盘满,2-信号丢失,3－移动侦测,4－硬盘未格式化</para>
            /// <para>5-读写硬盘出错,6-遮挡报警,7-制式不匹配, 8-非法访问 9-无SD卡</para>
            /// <para>10-SD卡未格式化,11-SD卡满,12-网络不通,13-视频丢失，14-超速报警,15-sd卡读写出错</para>
            /// <para>16-无硬盘报警 17-兼容飞田 18-G-sensor报警 19-紧急求助报警,20-胎压报警</para>
            /// </summary>
            public byte type;
            /// <summary>
            /// 1报警 2恢复
            /// </summary>
            public byte state;
            /// <summary>
            /// 通道,硬盘号,报警输入号,取决于type
            /// </summary>
            public byte id;
            /// <summary>
            /// 发生时间戳
            /// </summary>
            public uint timestamp;
            /// <summary>
            /// 预留1
            /// </summary>
            public ushort reserved1;
            /// <summary>
            /// 预留2
            /// </summary>
            public uint reserved2;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_AlarmUploadStateExtend_t
        {
            //0-信号量报警,1-硬盘满,2-信号丢失,3－移动侦测,4－硬盘未格式化,
            //5-读写硬盘出错,6-遮挡报警,7-制式不匹配, 8-非法访问 9-无SD卡 
            //10-SD卡未格式化,11-SD卡满,12-网络不通,13-视频丢失，14-超速报警,15-sd卡读写出错
            //16-无硬盘报警 17-兼容飞田 18-G-sensor报警 19-紧急求助报警,20-胎压报警
            public byte type;
            public byte state;            //1报警 2恢复
            public byte id;               //通道,硬盘号,报警输入号,取决于type 
            public uint timestamp;  //发生时间戳
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public char[] alarminfo; //报警信息(翻车，撞车)
            public ushort reserved1;       //预留
            public uint reserved2;     //预留	
        };

        //    typedef void (* PFUN_MSG_T) (uint dwContent);
        //typedef void (* PFUN_MSGHASAUDIO_T) (byte b_has_audio, uint dwContent);
        //typedef void (* PFUN_ERROR_T) (ushort err_code, uint dwContent);
        //typedef void (* PFUN_PROGRESS_T) (struct NETDVR_progressParam_t progress, uint dwContent);
        //typedef void (* PFUN_ALARMSTATE_T) (struct NETDVR_AlarmUploadState_t alarmstate, uint dwContent);
        //typedef void (* PFUN_DOWNLOAD_PROGRESS_T) (uint nIndex,struct NETDVR_progressParam_t progress, uint dwContent);
        //typedef void (* PFUN_DOWNLOAD_ERROR_T) (uint nIndex, ushort err_code, uint dwContent);
        //typedef void (* PFUN_DOWNLOADDATACB_T) (char* databuf, int datasize, uint dwContent);

        //typedef void (* PFUN_DEVICEGETSERVERMSG) (ushort errcode, uint msgtotallen,
        //     BYTE* msginfo, unsigned long msginfolen, uint dwContent );

        ////get device mileage callback function
        //typedef void (* PFUN_DEVICEMILEAGE) (ushort errcode, uint msgtotallen,
        //      BYTE* msginfo, unsigned long msginfolen, uint dwContent );

        //// add by wait 20160301
        //typedef void (* PFUN_MSG_DOWNFILENAME) (char* filename, uint dwContent);

        //#define NETDVR_UPDATE_MOTHERBBOARD 0
        //#define NETDVR_UPDATE_PANEL 1

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_updateParam_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] filename;                      //not neccessary
            public uint size;                      //file size
            public uint verify;                    //verify 
            public ushort version;                 //file versions
            public ushort reserved;                //update option: NETDVR_UPDATE_MOTHERBBOARD/NETDVR_UPDATE_PANEL
        };

        /* ========================== Motion Detect structures =========================== */

        //#define NETDVR_MD_MIN_SENSE	0						
        //#define NETDVR_MD_MAX_SENSE	5

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_motionDetection_t
        {
            public byte chn;
            public uint trigRecChn;                        //触发录像通道 按位
            public uint trigAlarmOut;                  //触发报警输出 按位
            public byte flag_buzz;                        //
            public byte flag_email;                   //触发emaill
            public byte flag_mobile;              //触发手机报警
            public byte sense;
            public NETDVR_DELAY_TIME delay;                          //延时
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 44 * 36)]
            public byte[] block;                   //
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserved;                 //预留
        };

        //视频丢失
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_VideoLostParam_t
        {
            public byte chn;
            public uint trigRecChn;                    //触发录像通道 按位
            public uint trigAlarmOut;              //触发报警输出 按位
            public byte flag_buzz;                    //蜂鸣器
            public byte flag_email;                   //触发emaill
            public byte flag_mobile;              //触发手机报警
            public NETDVR_DELAY_TIME delay;                      //延时
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserved;             //保留字段
        };

        //视频遮挡
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_VideoBlockParam_t
        {
            public byte chn;
            public uint trigRecChn;                    //触发录像通道 按位
            public uint trigAlarmOut;              //触发报警输出 按位
            public byte flag_buzz;                    //蜂鸣器
            public byte flag_email;                   //触发emaill
            public byte flag_mobile;              //触发手机报警
            public NETDVR_DELAY_TIME delay;                      //延时
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserved;             //保留字段
        };



        /* ========================== Alarm IN set pts structures=========================== */
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_alarmInPtz_t
        {
            public byte channo;                   //the channel of the PTZ
            public byte flag_preset;              //enable preset point or not
            public byte preset;                   //the enabled preset point number
            public byte flag_cruise;              //enable cruise or not
            public byte cruise;                   //the enabled cruise number
            public byte flag_track;               //enable track or not
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_alarmHandler_t
        {
            public byte flag_buzz;                //audio alarm flag
            public byte flag_send;                //reserved
            public byte flag_alarmout;                    //trigger alarm out flag
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] alarm_out;             //alarm output set
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public byte[] reserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] recchan;              //triggered record channel
            public byte flag_email;                   //触发emaill
            public byte flag_mobile;              //触发手机报警
            public ushort delay;                       //延时
            public NETDVR_alarmInPtz_t alarminptz;
        };

        /* ==================== user control structure ======================== */
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_userInfo_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public char[] name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public char[] password;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public char[] mac_address;

            /* 1:open， 0:close */
            public byte rcamer;                       //remote yuntai
            public byte rrec;                     //remote record
            public byte rplay;                        //remote playback
            public byte rsetpara;                 //remote set param
            public byte rlog;                     //remote get log
            public byte rtool;                        //remote use tool
            public byte rpreview;                 //remote preview
            public byte ralarm;                       //remote alarm
            public byte rvoip;                        //voip
            public byte lcamer;                       //local yuntai
            public byte lrec;                     //local record
            public byte lplay;                        //local palyback
            public byte lsetpara;                 //local set param
            public byte llog;                     //local log
            public byte ltool;                        //local tool

        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_UserNumber_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public NETDVR_userInfo_t[] userinfo;
        };




        /* ========================== remote HDD INFO structures=========================== */
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_hddInfo_t
        {
            public byte hdd_index;                    //硬盘序号
            public byte hdd_exist;                //1 exist; 0 not exist
            public uint capability;                    //MB
            public uint freesize;                  //MB
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] reserved;              //预留

        };

        /* ========================== remote System Version info structures=========================== */
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_SysVerInfo_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] devicename;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] devicemodel;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] deviceser;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] version;
        };



        /*=========================remote pic adjust============================*/
        enum NETDVR_PICADJUST
        {
            NETDVR_PIC_BRIGHTNESS = 0,
            NETDVR_PIC_CONTRAST,
            NETDVR_PIC_HUE,
            NETDVR_PIC_SATURATION,
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_PICADJUST_T
        {
            public byte channel_no;                   //通道号
            public NETDVR_PICADJUST flag;                     //调节标志:0-3
            public byte val;                      //调节值
            public uint copy2chnmask;              //复制到其他通道。每一位一个通道
        };

        enum NETDVR_TimeFormat_T
        {
            NETDVR_TF_YYYYMMDD = 0,
            NETDVR_TF_MMDDYYYY = 1,
            NETDVR_TF_DDMMYYYY = 2,  // add by wait 20150407
        };

        //系统时间
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_SysTime_t
        {
            public uint systemtime;                    //系统时间
            public NETDVR_TimeFormat_T format;                        //时间格式 选项值
            public byte flag_time;                    //预览时间位置显示
            public ushort timepos_x;                   //预览时间x坐标
            public ushort timepos_y;                   //预览时间y坐标
        };

        enum NETDVR_YTCOM_Protocol_t
        {
            YT_PROTOCOL_N5 = 0,
            YT_PROTOCOL_D4,
            YT_PROTOCOL_S8,
            YT_PROTOCOL_S7,
            YT_PROTOCOL_F2,
            YT_PROTOCOL_G2E,
            YT_PROTOCOL_G2N,
            YT_PROTOCOL_CR,
            YT_PROTOCOL_TY,
            YT_PROTOCOL_YH,
        };

        enum NETDVR_YTCOM_CheckBit_t
        {
            YT_CHECKBIT_NONE = 0,
            YT_CHECKBIT_ODD,
            YT_CHECKBIT_EVEN,
        };

        enum NETDVR_YTCOM_DataBit_t
        {
            YT_DATABIT_8 = 8,
            YT_DATABIT_7 = 7,
            YT_DATABIT_6 = 6,
        };

        enum NETDVR_YTCOM_StopBit_t
        {
            YT_STOPBIT_1 = 1,
            YT_STOPBIT_2 = 2,
        };


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_ComParam_t
        {
            public NETDVR_YTCOM_Protocol_t com_protocol;
            public uint com_baudrate;
            public NETDVR_YTCOM_CheckBit_t com_checkbit;
            public NETDVR_YTCOM_DataBit_t com_databit;
            public NETDVR_YTCOM_StopBit_t com_stopbit;
            public byte serialport;   //1-232, 2-485
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 23)]
            public byte[] reserved; //保留
        };

        //系统语言列表
        enum NETDVR_SYS_LANGUAGE
        {
            NETDVR_SYS_LANGUAGE_CHS = 0,        //简体中文
            NETDVR_SYS_LANGUAGE_ENU = 1,        //美式英文
            NETDVR_SYS_LANGUAGE_CHT = 2,       //繁体中文
            NETDVR_SYS_LANGUAGE_GER = 3,        //德语
            NETDVR_SYS_LANGUAGE_FRE = 4,        //法语
            NETDVR_SYS_LANGUAGE_SPA = 5,        //西班牙语
            NETDVR_SYS_LANGUAGE_ITA = 6,        //意大利
            NETDVR_SYS_LANGUAGE_POR = 7,        //葡萄牙语
            NETDVR_SYS_LANGUAGE_RUS = 8,        //俄语
            NETDVR_SYS_LANGUAGE_TUR = 9,        //土耳其语
            NETDVR_SYS_LANGUAGE_THA = 10,       //泰国语
            NETDVR_SYS_LANGUAGE_JAP = 11,       //日语
            NETDVR_SYS_LANGUAGE_HAN = 12,       //韩语
            NETDVR_SYS_LANGUAGE_POL = 13,       //波兰语
            NETDVR_SYS_LANGUAGE_HEB = 14,       //希伯来语Hebrew
            NETDVR_SYS_LANGUAGE_HUN = 15,       //匈牙利语Hungarian
            NETDVR_SYS_LANGUAGE_ROM = 16,       //罗马语Roma
            NETDVR_SYS_LANGUAGE_INVALID = -1    //仅作填充无效值用
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_SysLangList_t
        {
            public byte max_langnum;      //最多支持语言数 <=32
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public NETDVR_SYS_LANGUAGE[] langlist;   // language list, 最多32项,
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserved; //预留
        };

        //位率列表
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_bitRateList_t
        {
            public byte chn;              //通道
            public byte videotype;            //0 主码流, 1 子码流
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public uint[] bitratelist;   //位率列表, 单位kb, 未使用的填0
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserved;     //预留
        };

        enum enum_resolution_bitraterequest
        {
            RESOLUTION_bitraterequest_QCIF = 1,
            RESOLUTION_bitraterequest_CIF = 2,
            RESOLUTION_bitraterequest_HD1 = 3,
            RESOLUTION_bitraterequest_D1 = 4,
            RESOLUTION_bitraterequest_960H = 5,
            RESOLUTION_bitraterequest_720P = 6,
            RESOLUTION_bitraterequest_1080P = 7,
            RESOLUTION_bitraterequest_1080N = 8,
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_bitRateList_new_dev_t
        {
            public byte resolutiontype; //
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public uint[] bitratelist;   //位率列表, 单位kb, 未使用的填0
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_xwServer_t
        {
            public byte flag_server;
            public uint ip_server;
            public ushort port_server;
            public ushort port_download;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] device_serial;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] device_passwd;
            public byte flag_verifytime;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_SMTPServer_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] alarm_email;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] SMTP_svr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] username;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] userpw;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_Vehicle_cofig_t
        {
            public uint Magic;         //CONST_CONFIG_MAGIC
            public uint DevID;         //设备号,唯一标识
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] DevName;   //设备名称
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] BusNo;    //车牌号,唯一标识
            public uint PathNo;            //线路号
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] ProductNo; //生产号,唯一标识
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] NewDevID;  //新设备号,依迅唯一标识
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] Reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_RemoteNetInfor_t
        {
            public uint admin_host;                       //服务中心ip
            public ushort ctrl_port;                          //控制端口 
            public ushort data_port;                           //数据端口
            public uint admin_host_wifi;                   //wifi中心ip  
            public ushort ctrl_port_wifi;                      //wifi中心  控制端口
            public ushort data_port_wifi;                     //wifi中心  数据端口
            public uint GPS_host_Ip;                       //GPS 中心ip
            public ushort GPS_Port;                            //GPS 中心端口 
            public byte frame_quality_first;                 //图像质量优先   1: 图形优先  0 速度优先
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] ServerDomainname;
            public byte ServerDomainEnable;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
            public char[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_GPS_adjustTime_t
        {
            public byte adjust_type;             //1 设备gps校时  2:服务器校时  0:不校时
            public byte timezone;                 //时区 0东时区 1是西时区
            public byte zonenumh;              //zonenum hour    
            public uint adjust_time;
            public byte zonenumm;            //zonenum minute
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
            public byte[] Reserved;
        };
        //远程抓拍参数
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_Snapshot_t
        {
            public byte type;         //0:实时抓拍 1:历史抓拍
            public byte channel;          //通道号按位
            public uint timestamp;     //历史抓拍的时间戳
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] resolution;    //分辨率数组，8路；1-qcif；2-cif；3-d1
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserved;
        };
        //远程抓图图片信息
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_snapshot_head_t
        {
            public uint size;      //head + data
            public uint timestamp;
            public byte channel;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] devID;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] reserved;
        };

        //转发服务器配置
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_TransSvrInfo_t
        {
            public uint ip;
            public ushort port;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public char[] username;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public char[] password;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 34)]
            public byte[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_Overspeed_t
        {
            public byte enabled;
            public byte display;
            public byte buzzer;
            public byte voice;
            public ushort speed;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] reserved;
        };
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_FatigueDriving_t
        {
            public byte enabled;
            public byte display;
            public byte buzzer;
            public byte voice;
            public ushort hours;
            public byte minute;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public byte[] reserved;
        };
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_OSDDisplayInfo_t
        {
            public ushort datalen;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] osddata;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] reserved;
        };
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_Benan_Info_t
        {
            public byte type; //信息类型，0:驾驶证号，1:VSS车速
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] information; //信息内容
        };
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_VehicleRelatedInfo_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] ownername;//车主名
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] ownerID;//身份证号码
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] ownerphonenum;//电话
            public uint installtime;//安装时间
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] notes;//备注
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public char[] reserved;
        };
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_RecfileLockStatus_t
        {
            public byte chn;              //录像通道  
            public byte type;             //0:解锁，1:加锁
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] filename;    //录像文件名
            public uint start_time;    //文件的开始时间
            public uint end_time;     //文件的结束时间
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_taiya_info_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public char[] tire_id; //胎压计ID
            public int taiya_value;   //胎压值

            //0:左前轮1，1:右前轮1，2:右后轮1,3:左后轮1,
            //4:左前轮2, 5:右前轮2，6:右后轮2,7:左后轮2
            public char lun_num;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public char[] reserved;
        };

        //定时发送时使用
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_TPMS_info_t
        {
            public uint time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public char[] tire_id; //胎压计ID
            public int taiya_value;   //胎压值

            //0:左前轮1，1:右前轮1，2:右后轮1,3:左后轮1,
            //4:左前轮2, 5:右前轮2，6:右后轮2,7:左后轮2
            public char lun_num;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public char[] reserved;
        };
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_Gsensor_info_t
        {
            public byte g_sensor_type; //7: 翻车，6:撞车
                                       /*
                                           direct_of_gsensor的值的意义:
                                           翻车:1:左翻，2:右翻，3:后翻车,4:前翻，5:车辆整个翻过来
                                           撞车:0x01:左撞车，0x2右撞，0x3:前撞，0x4:后撞，0x5:上撞，0x6:下撞
                                       */
            public byte direct_of_gsensor;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public char[] reserved;
        };
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_OBD2_info_t
        {
            public uint time;//UTC
            public int direct_of_light;   //方向灯
            public uint speed;            //车辆时速
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public char[] speed_of_engine;  //引擎转速
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public char[] battery_voltage;  //电瓶电压
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public char[] reserved;
        };
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_GPS_info_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public char[] latitude;  //纬度 
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public char[] longitude; //经度
            public byte n_s_indicator; //N    N: north ; S: south
            public byte e_w_indicator; //W    E: east ; W: west 
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public char[] reserved;
        };

        //要回传的信息结构体,可能会有一部分信息是空的
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_Trans_info_t
        {
            public char type;          //0x1:GPS信息，0X2:OBD信息，0X3:G-sensor信息
            public uint time;          //时间日期信息
                                       //       union
                                       //{
            public NETDVR_Gsensor_info_t g_sensor_info;
            public NETDVR_OBD2_info_t obd2_info;
            public NETDVR_GPS_info_t gpsInfo;
            //};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public char[] reserved;
        };
        //蓝天IO信息
        struct NETDVR_IO_info_t
        {
            //uint time;
            //byte type; //0x0:刹车，0x1:左转向，0x2:右转向
            //byte state; //0x1:状态打开, 0x0:状态关闭
            //byte reserved[8];
        };

        //Gsensor的X,Y,Z 坐标信息
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_Gsensor_XYZ_info
        {
            public uint time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] gsensor_x; //X坐标加速度值，PC端需要转换成浮点数乘以地球加速度g(9.8),即为X分量的值
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] gsensor_y; //Y坐标加速度值，PC端需要转换成浮点数乘以地球加速度g(9.8),即为y分量的值
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] gsensor_z; ////Z坐标加速度值，PC端需要转换成浮点数乘以地球加速度g(9.8),即为Z分量的值
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserved;
        };

        struct NETDVR_OBD2_upload_info_t
        {
            //uint time;
            //ushort fuel_pressure; //燃料压力,kpa
            //byte rpm[16];        //引擎转速,r/min
            //ushort speed;         //车速km/h
            //byte calculated_engine_load_value[8]; //发动机负荷值%
            //byte engine_coolant_temperature[8];   //发动机冷却液温度,摄氏度
            //byte intake_air_temperature[8];       //进气口温度，摄氏度
            //byte throttle_position[8];            //节气门位置%
            //byte battery_voltage[8];              //电池电压v

            ///*status 各位说明*/
            ///*bit6:紧急刹车加速度在-6 M/S2下*/
            ///* bit5:加速度> 6 M/S2*/
            ///*bit4:紧急刹车加速度在-12 M/S2下*/
            ///*bit3:PTO switch ON/OFF, 1: ON, 0: OFF*/
            ///*bit2:BRAKE switch ON/OFF, 1: ON, 0: OFF*/
            ///*bit1:CLUTCH switch ON/OFF, 1: ON, 0: OFF*/
            ///*bit0:ACC switch ON/OFF, 1: ON, 0: OFF*/
            ///**/
            //byte status;
            //uint dser;
            //byte reserved[3];
        };


        //设置通道录像叠加OSD
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_ChnRecOSD_t
        {
            public byte channel_no; //要叠加的通道号 从0 开始
            public byte index; //叠加字符的序号:从0开始, 为以后支持多条做准备,目前设备只支持一条,index只能填0
            public short x; //左上角坐标x
            public short y; //左上角坐标y
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public char[] szRecOSD; //此条叠加的字符内容
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_Offline_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] device_name;
            public uint lastonline;
        };

        //上报信息类型
        enum NETDVR_UpdateInfoType_t
        {
            UPDATA_ALARM = 0, //报警
            UPDATA_TIME, //定时
            UPDATA_NO,//不报警
        };

        //信息上报模式(不上传/报警上传/定时上传)
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_UpdateInfoModel_t
        {
            //0-信号量报警,1-硬盘满,2-信号丢失,3－移动侦测,4－硬盘未格式化,
            //5-读写硬盘出错,6-遮挡报警,7-制式不匹配, 8-非法访问 9-无SD卡 
            //10-SD卡未格式化,11-SD卡满,12-网络不通,13-视频丢失，14-超速报警,15-sd卡读写出错
            //16-无硬盘报警 17-兼容飞田 18-G-sensor报警 19-紧急求助报警,20-胎压报警,21-OBD2
            //22-IO事件,23-RS232,24-设备日志
            public byte type;
            public NETDVR_UpdateInfoType_t updatetype;
            public uint updatetime; //定时上传时间(当updatetype=UPDATA_TIME有效)
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] reserved;
        };


        //音量大小(按百分比)
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_DevVolume_t
        {
            public byte val;  //调节值(百分比)
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] reserved;
        };


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_round_area_set_head_t
        {
            public byte setFlag;      //0:更新区域;1:追加区域;2:修改区域
            public byte areaCount;     //设置的区域总数 (后面跟的 ifly_round_area_content_t 个数)
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_round_area_content_t
        {
            public uint areaID;            //区域ID
                                           //       union
                                           //{

            //   areaAttribute_t;
            public AreaAttribute_t areaAttribute_t;
            public ushort areaAttribute;
            //};

            public uint centerlatitude;        //中心点纬度  以度为单位的纬度值乘以10的6次方
            public uint centerlongitude;   //中心点经度  以度为单位的经度值乘以10的6次方
            public uint radius;                //半径,单位:米
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] begintime;     //YY-MM-DD-hh-mm-ss  (GMT+0 ??? )
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] endtime;       //YY-MM-DD-hh-mm-ss  (GMT+0 ??? )
            public ushort maxSpeed;        //最高速度(km/h)
            public byte overSpeedDur;  //超速持续时间,单位为秒
        };
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        struct AreaAttribute_t
        {

            //ushort bytime:1; //根据时间
            //ushort speedlimit:1; //限速
            //ushort inrdriver:1; //进区域报告给驾驶员
            //ushort inrplatform:1; //进区域报告给平台
            //ushort outrdriver:1; //出区域报告给驾驶员
            //ushort outrplatform:1; //出区域报告给平台 
            //ushort NorS:1;          //0:北纬;1:南纬
            //ushort EorW:1;          //0:东经;1:西经
            //ushort lockdoor : 1;     //0:允许开门 1:禁止开门
            //ushort warnleval : 2;       //报警等级分为1,2,3，如果出现0表示是读的之前的没有添加报警信息的协议
            //ushort reserved : 3;        //保留
            //ushort enablecommu : 1; //0进区域开启通讯模块 1:进区域关闭通信模块
            //ushort getGNSS : 1;     //进区域不采集GNSS详细定位数据 1:进区域采集GNSS详细定位数据
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_area_delete_t
        {
            public byte areaCount; //本消息中包含的区域数, 0为删除所有区域/路线
        }; //删除区域/路线

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_rectangle_area_set_head_t
        {
            public byte setFlag;      //0:更新区域;1:追加区域;2:修改区域
            public byte areaCount;     //设置的区域总数 (后面跟的 ifly_rectangle_area_content_t 个数)
        };


        struct NETDVR_rectangle_area_content_t
        {
            //       uint areaID;            //区域ID
            //       union
            //{
            //	struct

            //       {

            //           ushort bytime:1; //根据时间
            //       ushort speedlimit:1; //限速
            //       ushort inrdriver:1; //进区域报告给驾驶员
            //       ushort inrplatform:1; //进区域报告给平台
            //       ushort outrdriver:1; //出区域报告给驾驶员
            //       ushort outrplatform:1; //出区域报告给平台 
            //       ushort NorS:1;          //0:北纬;1:南纬
            //       ushort EorW:1;          //0:东经;1:西经
            //       ushort lockdoor : 1;     //0:允许开门 1:禁止开门
            //       ushort warnleval : 2;       //报警等级分为1,2,3，如果出现0表示是读的之前的没有添加报警信息的协议
            //       ushort reserved : 3;        //保留
            //       ushort enablecommu : 1; //0进区域开启通讯模块 1:进区域关闭通信模块
            //       ushort getGNSS : 1;     //进区域不采集GNSS详细定位数据 1:进区域采集GNSS详细定位数据
            //   }
            //   areaAttribute_t;
            //	ushort areaAttribute;
            //};

            //uint leftuplatitude;        //左上点纬度  以度为单位的纬度值乘以10的6次方
            //uint leftuplongitude;   //左上点经度  以度为单位的经度值乘以10的6次方
            //uint rightdownlatitude; //右下点纬度  以度为单位的纬度值乘以10的6次方
            //uint rightdownlongitude;    //右下点经度  以度为单位的经度值乘以10的6次方
            //byte begintime[6];     //YY-MM-DD-hh-mm-ss  (GMT+0 ??? )
            //byte endtime[6];       //YY-MM-DD-hh-mm-ss  (GMT+0 ??? )
            //ushort maxSpeed;        //最高速度(km/h)
            //byte overSpeedDur;	//超速持续时间,单位为秒
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct _NETDVR_ef_unlockcar
        {
            public ushort unlocktime;  //解锁时间,单位为秒
            public ushort maxSpeed;        //最高速度(km/h)
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] reserve;    //保留字段
        };


        struct NETDVR_gpsalarm_base_t
        {
            //       union
            //{
            //	struct

            //       {

            //           uint emergency:1;   //紧急报警
            //       uint overspeed:1;   //超速报警
            //       uint fatigue:1;     //疲劳驾驶
            //       uint warning:1;     //预警
            //       uint GNSSmoduleErr:1;   //GNSS模块故障
            //       uint GNSSwireBreak:1;   //GNSS天线未接或被剪断
            //       uint GNSSwireShort:1;   //GNSS天线短路
            //       uint powerUnder:1;      //主电源欠压
            //       uint powerOff:1;            //主电源掉电
            //       uint LCDErr:1;          //LCD或显示器故障
            //       uint TTSErr:1;          //TTS模块故障
            //       uint CAMErr:1;          //摄像头故障
            //       uint reserved1:6;       //保留
            //       uint driveTimeout:1;        //当天累计驾驶超时
            //       uint stopTimeout:1;     //超时停车
            //       uint inoutArea:1;       //进出区域
            //       uint inoutLine:1;       //进出路线
            //       uint driveTimeLack:1;   //路段行驶时间不足/过长
            //       uint deviation:1;       //路线偏离报警
            //       uint VSSErr:1;          //VSS故障
            //       uint oilVolume:1;       //油量异常
            //       uint beStolen:1;            //车辆被盗
            //       uint illegalFires:1;        //非法点火
            //       uint illegalDisplace:1; //非法位移
            //       uint impact:1;      //碰撞侧翻报警
            //       uint reserved2:2;   //保留
            //   }
            //   alarmflag_t;
            //	uint alarmflag; //报警标志
            //};

            //    union
            //	{
            //		struct

            //        {

            //            uint ACC:1;			//0:ACC关;1:ACC开
            //			uint position:1;		//0:未定位;1定位
            //			uint NorS:1;			//0:北纬;1:南纬
            //			uint EorW:1;			//0:东经;1:西经
            //			uint operationOff:1;	//0:运营状态;1:停运状态
            //			uint encrypt:1;		//0:经纬度未加密;1:经纬度已经加密
            //			uint reserved1:4;	//保留
            //			uint oilwayBreak:1;		//0:油路正常;1:油路断开
            //			uint circuitryBreak:1;	//0:电路正常;1:电路断开
            //			uint doorlocked:1;		//0:车门解锁;1:车门加锁
            //			uint reserved2:19;		//保留
            //		}
            //state_t;
            //		uint state;		//状态位
            //	};

            //	uint latitude;  //纬度  以度为单位的纬度值乘以10的6次方
            //uint longitude; //经度  以度为单位的经度值乘以10的6次方
            //ushort altitude;    //海拔高度 单位为米
            //ushort speed;       //速度 1/10km/h
            //ushort direction;   //方向 0-359 正北为0,顺时针
            //byte time[6];	//YY-MM-DD-hh-mm-ss  (GMT+0 ??? )
        }; //位置基本信息


        struct NETDVR_polygon_area_set_head_t
        {
            //        byte setFlag;//0:更新区域， 1：追加区域， 2:修改区域
            //        uint areaID;            //区域ID
            //        union				//区域属性
            //	{
            //		struct

            //        {

            //            ushort bytime:1; //根据时间
            //        ushort speedlimit:1; //限速
            //        ushort inrdriver:1; //进区域报告给驾驶员
            //        ushort inrplatform:1; //进区域报告给平台
            //        ushort outrdriver:1; //出区域报告给驾驶员
            //        ushort outrplatform:1; //出区域报告给平台 
            //        ushort NorS:1;          //0:北纬;1:南纬
            //        ushort EorW:1;          //0:东经;1:西经
            //        ushort lockdoor : 1;     //0:允许开门 1:禁止开门
            //        ushort warnleval : 2;       //报警等级分为1,2,3，如果出现0表示是读的之前的没有添加报警信息的协议
            //        ushort reserved : 3;        //保留
            //        ushort enablecommu : 1; //0进区域开启通讯模块 1:进区域关闭通信模块
            //        ushort getGNSS : 1;     //进区域不采集GNSS详细定位数据 1:进区域采集GNSS详细定位数据
            //    }
            //    areaAttribute_t;
            //		ushort areaAttribute;
            //};

            //byte begintime[6];     //YY-MM-DD-hh-mm-ss  (GMT+0 ??? )
            //byte endtime[6];       //YY-MM-DD-hh-mm-ss  (GMT+0 ??? )
            //ushort maxSpeed;        //最高速度(km/h)
            //byte overSpeedDur; //超速持续时间,单位为秒
            //ushort vertexCount;	//区域总顶点数
        }; //多边形区域设置头

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_polygon_vertex_t
        {
            public uint vertexlatitude;        //顶点纬度  以度为单位的纬度值乘以10的6次方
            public uint vertexlongitude;   //顶点经度  以度为单位的经度值乘以10的6次方
        };  //多边形区域顶点


        struct NETDVR_route_set_head_t
        {
            //       byte setFlag;//0:更新区域， 1：追加区域， 2:修改区域
            //       uint routeID;           //路线ID
            //       union				//区域属性
            //{
            //	struct

            //       {

            //           ushort bytime:1;        //根据时间
            //       ushort reserved1:1; //保留
            //       ushort inrdriver:1; //进路线报告给驾驶员
            //       ushort inrplatform:1;   //进路线报告给平台
            //       ushort outrdriver:1;    //出路线报告给驾驶员
            //       ushort outrplatform:1; //出路线报告给平台 
            //       ushort reserved2:3; //保留
            //       ushort warnleval : 2;       //报警等级分为1,2,3，如果出现0表示是读的之前的没有添加报警信息的协议
            //       ushort reserved : 5;        //保留
            //   }
            //   routeAttribute_t;
            //	ushort routeAttribute;
            //};

            //byte begintime[6];     //YY-MM-DD-hh-mm-ss  (GMT+0 ??? )
            //byte endtime[6];       //YY-MM-DD-hh-mm-ss  (GMT+0 ??? )
            //ushort cornerCount;	//路线总拐点数
        }; //路线设置头

        struct NETDVR_route_corner_t
        {
            //        uint cornerID;          //拐点ID
            //        uint routeID;           //路线ID
            //        uint cornerlatitude;        //拐点纬度  以度为单位的纬度值乘以10的6次方
            //        uint cornerlongitude;   //拐点经度  以度为单位的经度值乘以10的6次方
            //        byte sectionWidth;     //路段宽度. 路段是指该拐点到下一拐点
            //        union				//区域属性
            //	{
            //		struct

            //        {

            //            byte bytime:1;     //根据时间
            //        byte speedlimit:1; //保留
            //        byte NorS:1;           //0:北纬;1:南纬
            //        byte EorW:1;           //0:东经;1:西经
            //        byte reserved:4;   //保留
            //    }
            //    sectionAttribute_t;
            //		byte sectionAttribute;
            //};
            //ushort maxDriveTime;    //单位为秒,路段行驶过长阈值
            //ushort minDriveTime;    //单位为秒,路段行驶不足阈值
            //ushort maxSpeed;        //最高速度(km/h)
            //byte overSpeedDur;	//超速持续时间,单位为秒
        }; //路线拐点

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_gpsalarm_addition_head_t
        {
            public byte infoID;   //附加信息ID	1~255		0x11:超速报警; 0x12进出区域/报警路线
            public byte infoLength;    //附加信息长度	infoID为0x11时, infoLength=1或5; infoID为0x12时, infoLength=6;
        };//位置附加信息

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_gpsalarm_addition_overspeed_t
        {
            public byte areaType; //1:圆形区域 2:矩形区域 3:多边形区域 4:路段	
            public uint areaID;        //区域ID
        };//位置附加信息 ifly_gpsalarm_addition_head_t中的infoID = 0x11

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_gpsalarm_addition_overspeed_noarea_t
        {
            public byte areaType;  //0: 无特定位置
        };//位置附加信息 ifly_gpsalarm_addition_head_t中的infoID = 0x11

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_gpsalarm_addition_inoutarea_t
        {
            byte areaType; //1:圆形区域 2:矩形区域 3:多边形区域 4:路段	
            uint areaID;        //区域ID
            byte direction; //0:进 1:出
        };//位置附加信息 ifly_gpsalarm_addition_head_t中的infoID = 0x11


        struct NETDVR_upload_taiya_info_t
        {
            //uint time;
            //byte tire_id[8]; //胎压计ID
            //uint tire_pres_value;   //胎压值
            //uint tire_temp_value;   //胎温值
            //uint tire_volt_value;   //电压值    
            //                        //0:左前轮1，1:右前轮1，2:右后轮1,3:左后轮1,
            //                        //4:左前轮2, 5:右前轮2，6:右后轮2,7:左后轮2
            //byte lun_num;
            //byte reserved[7];
        };

        struct NETDVR_Device_DebugFile_t
        {
            //ushort debugtype; //Debug文件类型  1:232    2:485
            //byte enable;    //开启Debug文件记录  1:开启  2:关闭
            //byte level; //文件详细程度 1：一般 2：详细
            //byte reserved[8];
        };

        //#define MAX_TXT_LEN 128
        //#define MAX_TITLE_LEN 32


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_txt_display_struct
        {
            public ushort x_pos;//显示位置X坐标  0-720
            public ushort y_pos;//显示位置X坐标 0-576
            public ushort height;//显示高度 0-576
            public ushort width;//显示宽度 0-720
            public uint disp_time;//显示时间，单位秒，0表示一直显示
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
            public byte[] title;//标题
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] content;//内容
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
            public uint[] reserved;//保留
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_ftpparam_t
        {
            public byte enable_ftp_domainame;
            public uint ftp_ip_address;
            public ushort ftp_port;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] ftp_domainame;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] ftp_user_name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] ftp_passwd;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] reserved; //保留字段 
        };

        struct NETDVR_ftpuploadparam_t
        {
            //char valid;

            //byte enable_ftp_domainame;
            //uint ftp_ip_address;
            //ushort ftp_port;
            //char ftp_domainame[64];
            //char ftp_user_name[64];
            //char ftp_passwd[64];
            ////	byte reserved[64]; //保留字段 

            //uint starttime;
            //uint endtime;
            //uint chn;

            //ushort innertime;//支持15/30/45分钟，默认30分钟, 就填 多少分钟
            //byte condition;//可选条件为“WIFI”、网卡”、“3/4G”； (可多选) wifi:0x01, 网卡：0x02， 3/4G：0x04，相与操作
            //byte reserved[49]; // 保留字段
        };

        struct NETDVR_tireparam_t
        {
            //byte alarm_flag;  //是否启用报警
            //int tire_pressure; //轮胎胎压最小值
            //int tire_temperature;  //胎压最小值
            //int tire_voltage;  //胎压(1/10)
            //byte osd_flag;  //报警触发OSD
            //byte buzz_flag; //报警触发BUZZ
            //byte alarm_upload_timer; //如果发生报警,间隔上传时间 
            //byte always_upload_timer; //定时固定上传,无论是否有报警 
            //byte reserved[16];              //保留字段
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_exception_t
        {
            public byte exceptiontype;
            public byte flag_display;
            public byte flag_buzz;
            public byte flag_send;
            public byte flag_alarm;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public char[] alarm_out;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_wifi_backup_t
        {
            public byte enable_domain_flag;           //1：启用域名，0：不启用域名
            public uint wifi_backup_server_ip;    //10进制ip，
            public ushort wifi_backup_port;   //端口
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] domainname;       //域名Ip
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_SIMModel_Info_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public char SIM_ICCID; //SIM卡ICCID号  字符串
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public char SIM_IMEI; //SIM卡IMEI号  字符串
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public char SIM_IMSI; //SIM卡IMSI号 总长度为不大于15位	 字符串
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte reserved; //预留
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_acc_upload_info_t
        {
            public byte acc_off_flag; //acc下线标志位
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
            public byte[] reserved; //保留字段 
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_gpsinner_t
        {
            public byte innerttime; // innerttime:0（60），1（30），2（15），3（10），4（5）
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_odb2inner_t
        {
            public byte innerttime; //innerttime:0（60），1（30），2（15），3（10），4（5）
        };

        struct NETDVR_tire_id_t
        {
            //byte lf[9]; // 左前
            //byte lf2[9]; // 左前2
            //byte rf[9]; // 右前
            //byte rf2[9]; // 右前2
            //byte lb[9]; // 左后
            //byte lb2[9]; // 左后2
            //byte rb[9]; // 右后
            //byte rb2[9]; // 右后2
            //byte reserved[72]; // 保留
        };

        struct NETDVR_tire_ids_t
        {
            //       byte id[20][9];
            //byte reserved[72];
        };

        struct NETDVR_temppwd_t
        {
            //byte pwd[32];
        };

        struct NETDVR_temprange_t
        {
            //byte alarm_flag; //是否启用报警 
            //short id1tempmin; // 温度计1最小值
            //short id1tempmax; // 温度计1最大值
            //short id2tempmin; // 温度计2最小值
            //short id2tempmax; // 温度计1最大值
            //short id3tempmin; // 温度计3最小值
            //short id3tempmax; // 温度计3最小值
            //short id4tempmin; // 温度计4最小值
            //short id4tempmax; // 温度计4最小值
            //byte reserved[6];
            //byte osd;
            //byte buzz;
            //byte alarm_upload_timer; //如果发生报警,间隔上传时间分别是:不上报（0），30S(1), 60S(2) 
            //byte always_upload_timer; //定时固定上传,无论是否有报警都上传，时间分别是：不上报（0），30S(1), 60S(2),180S(3), 300S(4) 
        };

        struct NETDVR_temp_info_t
        {
            //uint time;
            //byte temp_id[10]; //温度计ID 
            //short temp_value; //温度值 
            //byte temp_state; // 0:正常，1高了，2低了
            //byte reserved[6];
        };

        struct NETDVR_upload_tempalaram_info_t
        {
            //uint time;
            //byte temp_id[10]; //温度计ID 
            //short temp_value; //胎温值 
            //byte temp_state; // 0正常，1高了，2低了
            //byte reserved[6];
        };

        struct NETDVR_text_result_t
        {
            //byte title[MAX_TITLE_LEN + 1];//标题
            //byte content[MAX_TXT_LEN + 1];//内容
            //byte result; // 处理结果 0: 超时未处理，1:yes , 2:no 
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_alarmevent_name_t
        {
            public byte alarmid;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public char[] alarmidname;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_edtype_t
        {
            public byte edtype; // 类型
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_acctime_t
        {
            public int innertime;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_gpsinnertime_t
        {
            public int innertime;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_obd2innertime_t
        {
            public int innertime;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_timereboot_t
        {
            public byte enable; // 0：无效，1：有效
            public byte hour; // 小时 
            public byte minute; // 分钟 
            public byte second; // 秒钟 
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] reserved;
        };


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_streamsvr_t
        {
            public uint serverIP;
            public ushort serverPort;
        };


        struct NETDVR_EventSearch_Cond_t
        {
            //byte eventtype;                        //类型 0--全部 其他取值1-255,分别表示某种事件类型
            //uint start_time;                    //开始时间
            //uint end_time;                  //终止时间
            //ushort startID;                 //返回的第一条记录,从1开始
            //ushort max_return;                  //每次返回的最大记录数  不超过500
            //byte reserved[7];               //预留
        };

        struct NETDVR_EventInfo_t
        {
            //byte eventtype;                //事件类型, 1-255
            //uint event_time;            //事件发生时间
            //byte reserved[3];      //预留
            //struct NETDVR_EventInfo_t *pnext;	//指向下一个事件
        };


        struct NETDVR_EventSearchResult_t
        {
            //ushort sum;                     //符合搜索条件的总结果数.
            //ushort startID;                 //此次结果开始ID, 如果为0,表示搜索不到
            //ushort endID;                   //此次结果结束ID.
            //struct NETDVR_EventInfo_t *pEventInfo;	//指向此次结果第一条记录
        };

        struct NETDVR_TTX_SERVERINFO_t
        {
            //byte enable_domain_flag;     //1：启用域名，0：不启用域名
            //uint ttx_server_ip;    //IP地址，
            //ushort ttx_server_port;   //端口
            //char domainname[64];       //域名
            //byte reserved[32];      //预留
        };


        struct NETDVR_COM_PARAM_LITE_t
        {
            public uint com_baudrate;  //波特率
            public byte com_checkbit; //校验位 0:NONE,1:奇校验，2:偶校验
            public byte com_databit;      //数据位 8，7，6
            public byte com_stopbit;      //停止位 1，2
            public byte com_type;     //1-232, 2-485
            public byte reserved;      //保留
        };

        struct NETDVR_TSP_SERVERINFO_t
        {
            //byte enable_domain_flag;               //1：启用域名，0：不启用域名
            //uint trans_serialport_server_ip;    //IP地址，
            //ushort trans_serialport_server_port;   //端口
            //char domainname[64];                    //域名
            //byte enable_trans_flag;                //使能透传 1 启用透传; 0不透传
            //byte protocal_type;                    // 0: 无数据协议  1:通立协议
            //NETDVR_COM_PARAM_LITE_t com_param[2];           //下标0-第一个串口 依次类推
            //byte reserved[20];                  //保留
        };


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_DriveHabit_Set_t
        {
            public ushort thresholdVal;    //阈值
            public ushort count;           //次数
        };

        struct NETDVR_DriveHabit_Param_t
        {
            //NETDVR_DriveHabit_Set_t eventparam[4];  //下标0--停止 1--启动 2--急加/急减/急转弯 3--碰撞
            //byte reserved[16];                      //保留
        };

        struct NETDVR_WIFI_SERVERINFO_t
        {
            //byte enableWifiFlag;   //是否启用WIFI 0 不启用 1启用
            //uint wifiIP;            //WIFI的IP--设备自身的ip
            //uint wifiMask;          //子网掩码
            //uint wifiGateway;       //网关
            //char ESSID[32];                 //ESSID,字符串
            //byte IPtype;           //IP类型 0--静态IP、1--动态IP
            //byte passwordType; //密码类型 0--无密码、1--WEP、2--WPA-PSK/WPA2-PSK
            //char strPassword[30];           //密码,字符串  当passwordType为0时,忽略此项
            //byte authentication;   //认证类型：0--WPA-PSK、1--WPA2-PSK 当passwordType为0或1时,忽略此项
            //byte encrptType;       //加密算法 0--TKIP、1--AES 当passwordType为0或1时,忽略此项
            //byte reserved[16];      //保留
        };


        //帧率列表 
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_Framerate_list_t
        {
            public byte chn;  //通道
            public byte type; // 0 主码流 1 子码流
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] framerate; //帧率列表 未使用的填0
        };


        struct NETDVR_micchipinfo_t
        {
            //char microchip[32];         // 单片机
            //char submicrochip[8]; //  子板单片机信息
            //char reserved[24]; //保留 
        };

        struct NETDVR_alarmeventnew_name_t
        {
            //byte alarmid;
            //char show[16]; // 显示
            //char overname[16]; // 结束名称
            //char alarmidname[16]; //事件名称
            //char reserved[32]; // 保留
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_week_day_t
        {
            public byte flag;
            public byte hour;
            public byte min;
            public byte sec;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] reserved;
        };

        //# ifndef TIM_SEG_NUM
        //#define TIM_SEG_NUM 4
        //#endif

        //# ifndef TIM_WEEK_DAY
        //#define TIM_WEEK_DAY 7
        //#endif

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_Time_Segment_t
        {
            public uint from_mon;
            public uint from_day;
            public uint to_mon;
            public uint to_day;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public NETDVR_week_day_t[] week_day;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public uint[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_Startup_Close_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] flag;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public NETDVR_Time_Segment_t[] time_seg_t;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] reserved;
        };


        //硬盘满
        struct NETDVR_DiskFullParam_t
        {
            //uint trigRecChn; //触发录像通道 按位
            //uint trigAlarmOut; //触发报警输出 按位
            //byte flag_buzz; //蜂鸣器
            //byte flag_email; //触发emaill
            //byte flag_mobile; //触发手机报警
            //ushort delay; //延时
            //byte reserved[16]; //保留字段
        };

        //硬盘错误
        struct NETDVR_DiskErrorParam_t
        {
            //uint trigRecChn; //触发录像通道 按位
            //uint trigAlarmOut; //触发报警输出 按位
            //byte flag_buzz; //蜂鸣器
            //byte flag_email; //触发emaill
            //byte flag_mobile; //触发手机报警
            //ushort delay; //延时
            //byte reserved[16]; //保留字段
        };


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_3g_state
        {
            public byte gpsenalle; //gps存在标志，0:不存在1:存在
            public byte devexist_3g; //3g设备存在标志，0:不存在1:存在
            public byte simexist; //sim卡存在标志，0:无1:有
            public byte daildtate; //拨号状态1:拨号成功2:正在拨号3:空闲
            public byte serverstate; //服务器状态，0:离线1:在线
            public int g3_rssi;    //3g信号强度
            public byte wifiexist; //wifi存在标志，0:无1:有
            public byte wifilink; //wifi连接状态，0:离线1:在线
            public byte transconnectstat;//透传连接		
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserved; //预留
        };


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_video_superpositon
        {
            public byte timeenable; //时间是否有效，0：无效，1：有效
            public byte chnenable; // 通道号是否有效，0：无效，1：有效
            public byte cardnoenable; //车牌号是否有效，0：无效，1：有效
            public byte videolostenable; // 视频丢失是否有效，0：无效，1：有效
            public byte gpsenable; // gps信息是否有效，0：无效，1：有效
            public byte alarminfoenable; // 报警信息是否有效，0：无效，1：有效
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_3ginfo_t
        {
            public uint ip; // ip
            public uint mask;//子网掩码
            public uint gateway; // 网关
            public uint dnsmaster; // 主dns
            public uint dnsslave; // 从dns
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_restore_t
        {
            public byte type; //0:普通信息，1:车辆信息，2:全部
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_3g_t
        {
            public byte type; //0:none 1:evdo189* 2:evdo其它 1:wcdma  //0:无 1:WCDMA 2:EVDO
            public byte connect; //连接方式: 常连接 0; 手动1；短信 2
            public byte bittype; //启用动态码流与否；根据带宽决定是否调整编码码流或帧率
            public byte reserved; //保留位
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] user; //用户名
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] passwd; //密码
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] phone; //电话号码,WCDMA:*99***1#, EVDO:#777
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] strAPN; //接入点 APN, 当这个值为空或者"0"时，不需要处理
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_netstate_t
        {
            public uint timestamp; //  时间戳
            public byte gpsstate;// 1:存在，0：不存在
            public byte g3g4data; // 0:无，1：弱，2：中：3：强
            public byte g3g4exist; // 3g/4g模块，1：存在，0：不存在
            public byte simexist; // sim卡 1：有，0：无
            public byte dialstate; //1：空闲，2：拨号中，3：在线。
            public byte nettype;// 1:2g,2:3g,3:4g,5:wifi,6:网线
            public byte transstate; // 透传状态, 1:是，0：否
            public byte supportttx;// 0: 不支持，1：未认证，2：认证失败，3：在线，4：离线。
            public byte wifiexist; // wifi模块：1：存在，0：不存在
            public byte wifistate;// 1:离线，2：在线
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] reserved; // 保留位。
        };


        //配置批量升级的类型
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_updatedevtype_t
        {
            public byte type;  // 0表示增加升级设备  1表示删除已经配置的升级设备
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] fileName; //升级文件名(type == 0 有效)
            public uint configcount; //配置设备的数量
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public byte[] reserved;
        };

        //批量升级设备信息
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_updatedevinfo_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] device_id; // 设备ID
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] reserved;
        };


        //批量升级正在升级的设备进度信息
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_updateprogress_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] device_id; // 设备名
            public byte type; // type == 0 上传升级文件进度，type == 1 设备升级文件进度
            public uint curr_pos; //当前进度
            public uint total_size; //总进度
        };

        // 查询日志
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_event_search_t
        {
            //uint timestart;  // 开始时间
            //uint timeend; // 结束时间
            //byte eventtype; // 事件类型 (4种，包括全部就是5种)
            //ushort startID; // 返回的第一条记录,从1开始
            //ushort max_return; // 第次返回的最大的记录数，一般不大于24
            //byte reserved[16]; // 保留
        };

        struct NETDVR_search_event_info
        {
            //byte eventtype;
            //uint time;

            //NETDVR_search_event_info* pNext;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_Event_Download_t
        {
            public uint chn; // 通道号
            public uint timestart; // 开始时间
            public uint timeend; // 结束时间
            public uint segmentid; // 开始段序号
            public uint frameid; // 开始帧序号
        };

        struct NETDVR_search_event_desc_t
        {
            //ushort sum; // 总数 
            //ushort startid; // 开始id
            //ushort endid; // 结束id

            //NETDVR_search_event_info* pH;
        };

        struct NETDVR_search_event_info_t
        {
            //byte chn; // 通道号
            //byte eventtype; // 事件类型
            //byte time; // 事件时间点
            //           //再加保留字段 16BYTE
            //byte reserved[16];
        };


        struct NETDVR_valid_chn_t
        {
            //uint validchn; // 按位与 (validchn & 0x01) == 0x01 表示1通道有效.（0为无效，1为有效）
            //byte reserved[8]; // 保留字段
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_gpsinner2_t
        {
            public ushort innerttime; // innertime 这个值表示间隔时间(秒)，范围从5--600。
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_finger_result
        {
            public byte result; // 处理结果： 0)  验证通过 1)     验证失败 2) 指纹正在验证中 
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public byte reserved;
        };

        struct NETDVR_finger_data
        {
            //ushort fingerdatalen;
            //byte fingerdata[700]; // 原始指纹数据只有500字节
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct NETDVR_resolution_list
        {
            public byte chn;
            public byte masterslavestreamtype;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public byte[] resolution;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public byte[] reserved;
        };

        struct NETDVR_dashship_alarm
        {
            //byte opt;                   // 1 装垃圾，2倒垃圾, 0：表示实时水位数据，这个把速度也报上来。
            //byte zoneType;       //该船所处区域类型
            //uint zoneID;               //该船所处区域id
            //uint waterVal;          //该船实时水位值

            //uint speed;  //速度
            //int course;                  //方向

            //uint latitude;                             //纬度还得转换一下,详见上面的截图
            //byte n_s_indicator;      //南北纬指示 N: north ; S: south

            //uint longitude;                                         //精度也得转换一下
            //byte e_w_indicator;            //东西经指示 E: east ; W: west

            //char utc_position[6];      //6字节bcd码 YY MM DD hh mm ss

            //byte reserved[16];

        };

        //获取GPS存储服务器的ip和端口
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct _ifly_gps_serveraddr
        {
            uint server_ip_address;//GPS存储服务器ip地址
            ushort server_port; //GPS存储服务器端口
        }

        //向GPS存储服务器发送查询GPS的时间段
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct _ifly_gps_search
        {
            uint ustartTime; //查询GPS的开始时间:形如:1512455341
            uint uendTime;  //查询GPS的结束时间:形如:1512455345
        };


        //struct _tagGPSTime
        //    {
        //        uint ucYear : 6;        //年(2000+ucYear) 范围(0-64)
        //        uint ucMonth : 4;       //月(1-12)	范围(0-16)
        //        uint ucDay : 5;     //日(1-31)  范围(0-32)
        //        uint ucHour : 5;        //时(0-23)	范围(0-32)
        //        uint ucMinute : 6;  //分(0-59)  范围(0-64)
        //        uint ucSecond : 6;  //秒(0-59)  范围(0-64)
        //    }
        //    ifly_gpstime_t;

        //struct _tagGPSVehicleGps
        //    {
        //        ifly_gpstime_t Time;
        //        uint uiSpeed : 14;  //速度值 KM/S	9999 = 999.9 	范围(0-16384)
        //        uint uiYouLiang : 18;   //油量   升	9999 = 99.99 	范围(0-262100)
        //        uint uiMileage;     //里程   
        //        uint uiCourse;  //地面航向，(0-360) 范围(0-512)
        //        ushort uiStatus;        //（0无效，1有效）
        //        byte n_s_indicator; //南北纬指示 N: north ; S: south
        //        byte e_w_indicator;//东西经指示 E: east ; W: west
        //        short sTempSensor[3];   //温度传感器的状态
        //        int nLongitude;     //经度	4字节 整数部分	9999999 = 9.999999 
        //        int nLatitude;          //纬度	4字节 整数部分	9999999 = 9.999999
        //        int nParkTime;      //停车时长 秒	在静止状态时有效
        //        int Alarmmark; //报警标志 见808协议消息ID：0x0200
        //        int State;//状态 见808协议消息ID：0x0200
        //        int nReserve[2];        //保留参数
        //    }
        //    ifly_gpsinfo_t;


    }
}
