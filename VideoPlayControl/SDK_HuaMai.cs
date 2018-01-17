using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace VideoPlayControl
{
    public static class SDK_HuaMai
    {
        /// <summary>
        /// SDK初始化
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_sdk_init();


        /// <summary>
        /// SDK反初始化
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_sdk_uninit();

        /// <summary>
        /// SDK平台的登录
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern UInt32 hm_server_connect(IntPtr intptrLoginInfo, ref IntPtr intptr, int strErr, int iErrLength);

        /// <summary>
        /// SDK平台的登录
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern UInt32 hm_server_connect(ref _LOGIN_SERVER_INFO intptrLoginInfo, ref IntPtr intptr, ref string strErr, int iErrLength);
        /// <summary>
        /// 注销登录
        /// </summary>
        /// <param name="intptrServer"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_disconnect(IntPtr intptrServer);
        /// <summary>
        /// 获取设备列表
        /// </summary>
        /// <param name="intptrServer"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_get_device_list(IntPtr intptrServer);

        /// <summary>
        /// 获取当前用户登录信息
        /// </summary>
        /// <param name="iServer"></param>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_get_user_info(IntPtr iServer, ref _USER_INFO userInfo);

        /// <summary>
        /// 获取当前用户登录信息
        /// </summary>
        /// <param name="iServer"></param>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_get_user_info(IntPtr iServer, ref IntPtr userInfo);

        /// <summary>
        /// 获取中转穿透信息
        /// </summary>
        /// <param name="intptrServer"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_get_transfer_info(IntPtr intptrServer);

        /// <summary>
        /// 获取树列表
        /// </summary>
        /// <param name="intptrServer"></param>
        /// <param name="intpterTree"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_get_tree(IntPtr intptrServer, ref IntPtr intpterTree);

        /// <summary>
        /// 释放树列表
        /// </summary>
        /// <param name="iTree"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_release_tree(IntPtr iTree);

        /// <summary>
        /// 获取根节点
        /// </summary>
        /// <param name="iTree"></param>
        /// <param name="iRootNode"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_get_root(IntPtr iTree, ref IntPtr iRootNode);

        /// <summary>
        /// 获取根节点
        /// </summary>
        /// <param name="iTree"></param>
        /// <param name="iRootNode"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_get_children_count(IntPtr iNode, ref int iCount);

        /// <summary>
        /// 根据索引号获取子集节点
        /// </summary>
        /// <param name="iTree"></param>
        /// <param name="iRootNode"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_get_child_at(IntPtr iParentNode, int iIndex, ref IntPtr iNode);


        /// <summary>
        /// 通过SN号码获取设备节点
        /// </summary>
        /// <param name="iTree"></param>
        /// <param name="strSN"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_find_device_by_sn(IntPtr iTree, String strDevSN,ref IntPtr iNode);

        /// <summary>
        /// 获取节点类型
        /// </summary>
        /// <param name="iTree"></param>
        /// <param name="strSN"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_get_node_type(IntPtr iNode, ref NODE_TYPE_INFO typeInfo);

        /// <summary>
        /// 获取节点名称
        /// </summary>
        /// <param name="iTree"></param>
        /// <param name="strSN"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern UInt32 hm_server_get_node_name(IntPtr iNode, ref IntPtr iNodeName);

        /// <summary>
        /// 获取设备节点SN码
        /// </summary>
        /// <param name="iTree"></param>
        /// <param name="strSN"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern UInt32 hm_server_get_device_sn(IntPtr iNode, ref IntPtr iDevSN);

        /// <summary>
        /// 获取设备节点URL
        /// </summary>
        /// <param name="iNode"></param>
        /// <param name="iDevUrl"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern UInt32 hm_server_get_device_url(IntPtr iNode, ref IntPtr iDevUrl);

        /// <summary>
        /// 获取设备节点在线状态
        /// </summary>
        /// <param name="iNode"></param>
        /// <param name="iDevUrl"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern UInt32 hm_server_is_online(IntPtr iNode, ref bool bolOnline);

        /// <summary>
        /// 连接设备_ex
        /// </summary>
        /// <param name="iNode"></param>
        /// <param name="iDevUrl"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern UInt32 hm_pu_login_ex(IntPtr iNode, ref IntPtr iDev);

        /// <summary>
        /// 连接设备_ex
        /// </summary>
        /// <param name="iNode"></param>
        /// <param name="iDevUrl"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern UInt32 hm_pu_login_ex(IntPtr iNode, ref _CONNECT_INFO config, ref IntPtr iDev);

        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_pu_logout(IntPtr iDev);

        /// <summary>
        /// 创建实时视频句柄
        /// </summary>
        /// <param name="iDev"></param>
        /// <param name="videoPara"></param>
        /// <param name="iOpenVideo"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern UInt32 hm_pu_open_video(IntPtr iDev, ref _OPEN_VIDEO_PARAM videoPara, ref IntPtr iOpenVideo);

        /// <summary>
        /// 打开实时视频
        /// </summary>
        /// <param name="iOpenVideo"></param>
        /// <param name="videoRes"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_pu_start_video(IntPtr iOpenVideo, ref OPEN_VIDEO_RES videoRes);

        ///// <summary>
        ///// 打开实时视频
        ///// </summary>
        ///// <param name="iOpenVideo"></param>
        ///// <param name="videoRes"></param>
        ///// <returns></returns>
        //[DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        //public static extern UInt32 hm_pu_start_video(IntPtr iOpenVideo, ref IntPtr  IVideoRes);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iOpenVideo"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_pu_stop_video(IntPtr iOpenVideo);

        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_pu_close_video(IntPtr iDev);

        /// <summary>
        /// 视频显示
        /// </summary>
        /// <param name="iWnd"></param>
        /// <param name="option"></param>
        /// <param name="iPort"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_video_display_open_port(IntPtr iWnd, ref DISPLAY_OPTION option, ref IntPtr iPort);

        /// <summary>
        /// 释放播放端口
        /// </summary>
        /// <param name="iPort"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_video_display_close_port(IntPtr iPort);


        /// <summary>
        /// 初始化本地录像
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_util_local_record_init();

        /// <summary>
        /// 开启视频显示
        /// </summary>
        /// <param name="iPort"></param>
        /// <param name="iViewWidth"></param>
        /// <param name="iViewHeight"></param>
        /// <param name="iFPS"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_video_display_start(IntPtr iPort, int iViewWidth, int iViewHeight, int iFPS);

        /// <summary>
        /// 停止视频显示
        /// </summary>
        /// <param name="iPort"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_video_display_stop(IntPtr iPort);

        /// <summary>
        /// 向显示端口传入视频数据
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_video_display_input_data(IntPtr iPort, IntPtr iVideoStream, UInt32 iLen, bool Temp_bol);

        /// <summary>
        /// 初始化本地录像
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_util_loacl_record_init();
                

        /// <summary>
        /// 连接设备
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_pu_login(string strIP, UInt16 uiPort, string strDeviceSN, string strUserName, string strPwd, out IntPtr intptr);



        #region 回调函数设置

        /// <summary>
        /// 视频播放回调函数
        /// </summary>
        /// <param name="iUser"></param>
        /// <param name="frmae"></param>
        /// <param name="err"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        //public delegate void cb_pu_data(IntPtr iUser, _FRAME_DATA frmae, UInt32 err);
        public delegate void cb_pu_data(IntPtr iUser, IntPtr iFrmae, UInt32 err);


        #endregion

        #region 结构体
        /// <summary>
        /// 平台登录信息
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct _LOGIN_SERVER_INFO
        {
            /// <summary>
            /// 平台地址
            /// </summary>
            public string ip;

            /// <summary>
            /// 平台端口
            /// </summary>
            public UInt16 port;

            /// <summary>
            /// 用户名
            /// </summary>
            public string user;

            /// <summary>
            /// 密码
            /// </summary>
            public string password;

            /// <summary>
            /// 系统类型（pc，android，ios）
            /// </summary>
            public string plat_type;

            /// <summary>
            /// 硬件版本（PC传CPU型号，手机平台传手机型号）
            /// </summary>
            public string hard_ver;

            /// <summary>
            /// 软件版本（如v1.0.0.1001）
            /// </summary>
            public string soft_ver;

            /// <summary>
            /// 连接保持时间
            /// </summary>
            public UInt32 keep_time;
        }
        //typedef struct _LOGIN_SERVER_INFO
        //{
        //    cpchar ip;                      //	平台地址
        //    uint16 port;                    //	平台端口
        //    cpchar user;                    //	用户名
        //    cpchar password;                //	密码
        //    cpchar plat_type;               //	系统类型（pc，android，ios）
        //    cpchar hard_ver;                //	硬件版本（PC传CPU型号，手机平台传手机型号）
        //    cpchar soft_ver;                //	软件版本（如v1.0.0.1001）
        //    uint32 keep_time;               //	连接保持时间
        //}
        //LOGIN_SERVER_INFO, *P_LOGIN_SERVER_INFO;
        
        /// <summary>
        /// 用户信息
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct _USER_INFO
        {
            /// <summary>
            /// 用户ID 
            /// </summary>
            public UInt32 id;
            /// <summary>
            /// 用户名称
            /// </summary>
            public string user;
            /// <summary>
            /// 用户昵称
            /// </summary>                                       
            public string nick_name;
            /// <summary>
            /// 电话号码
            /// </summary>
            public string tel;
            /// <summary>
            /// 移动电话号码
            /// </summary>
            public string mobile;
            /// <summary>
            /// 用户地址
            /// </summary>
            public string address;
            /// <summary>
            /// 注册时间
            /// </summary>
            public string reg_date;
            /// <summary>
            /// 最后一次登录时间
            /// </summary>
            public UInt32 last_login_date;
            /// <summary>
            /// 邮箱地址
            /// </summary>
            public string email;

            /// <summary>
            /// 邮箱是否可用
            /// </summary>
            public bool email_valid;

            /// <summary>
            /// 用户的设备角色
            /// </summary>
            public UInt32 actor;

            /// <summary>
            /// 角色1
            /// </summary>
            public string roles1;

            /// <summary>
            /// 角色2
            /// </summary>
            public string roles2;

            /// <summary>
            /// 是否使用报警服务
            /// </summary>
            public bool user_alarm_service;

            /// <summary>
            /// 是否使用中转穿透服务
            /// 0表示不适用 其余代表使用
            /// </summary>
            public UInt32 user_transfer_service;


            //int32 id;
            //cpchar name;
            //cpchar nick_name;
            //cpchar tel;
            //cpchar mobile;
            //cpchar address;
            //cpchar reg_date;
            //cpchar last_login_date;
            //cpchar email;
            //bool email_valid;
            //int32 actor;
            //cpchar role1;
            //cpchar role2;
            //bool use_alarm_service;
            //int32 use_transfer_service;
        }

        //typedef struct _USER_INFO
        //{
        //    int32 id;
        //    cpchar name;
        //    cpchar nick_name;
        //    cpchar tel;
        //    cpchar mobile;
        //    cpchar address;
        //    cpchar reg_date;
        //    cpchar last_login_date;
        //    cpchar email;
        //    bool email_valid;
        //    int32 actor;
        //    cpchar role1;
        //    cpchar role2;
        //    bool use_alarm_service;
        //    int32 use_transfer_service;
        //}
        //USER_INFO, *P_USER_INFO;

        /// <summary>
        /// 播放设置信息
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct _CONNECT_INFO
        {
            /// <summary>
            /// 客户端类型
            /// </summary>
            public CLIENT_TYPE ct;

            /// <summary>
            /// 连接优先级
            /// </summary>
            public CONNECT_PRI cp;

            /// <summary>
            /// 连接模式（CONNECT_MODE）
            /// </summary>
            public CONNECT_MODE cm;
        }

        //typedef struct _CONNECT_INFO
        //{
        //    CLIENT_TYPE ct;     //	客户端类型
        //    CONNECT_PRI cp;     //	连接优先级
        //    int32 cm;           //	连接模式（CONNECT_MODE）
        //}
        //CONNECT_INFO, *P_CONNECT_INFO;

        /// <summary>
        /// 打开视频参数设置
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct _OPEN_VIDEO_PARAM
        {
            /// <summary>
            /// 通道
            /// </summary>
            public UInt32 channel;

            /// <summary>
            /// 码流类型
            /// </summary>
            public CODE_STREAM cs_type;

            /// <summary>
            /// 视频类型
            /// </summary>
            public VIDEO_STREAM vs_type;

            /// <summary>
            /// 回调函数设置
            /// </summary>
            public cb_pu_data cb_data;

            /// <summary>
            /// 窗口句柄
            /// </summary>
            public IntPtr iWnd;

            /// <summary>
            /// 用户回调数据
            /// </summary>
            public IntPtr data;
        }

        //typedef struct _OPEN_VIDEO_PARAM
        //{
        //    uint32 channel;
        //    CODE_STREAM cs_type;
        //    VIDEO_STREAM vs_type;
        //    cb_pu_data cb_data;
        //    window_handle wnd;
        //    user_data data;
        //}
        //OPEN_VIDEO_PARAM, *P_OPEN_VIDEO_PARAM;

        /// <summary>
        /// 帧数据
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _FRAME_DATA
        {
            /// <summary>
            /// 帧信息
            /// </summary>
            public _FRAME_Info frame_info;

            /// <summary>
            /// 帧长度
            /// </summary>
            public UInt32 frame_len;

            /// <summary>
            /// 数据内容
            /// </summary>
            public IntPtr frame_stream;
        }

        /// <summary>
        /// 帧信息
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct _FRAME_Info
        {
            /// <summary>
            /// 视频通道号
            /// </summary>
            public UInt16 channel;

            /// <summary>
            /// 视频类型 VIDEO_STREAM
            /// </summary>
            public UInt16 data_type;

            /// <summary>
            /// 码流类型 CODE_STREAM
            /// </summary>
            public UInt16 stream_type;

            /// <summary>
            /// 帧类型 0-P帧(H264) 1-I帧(H264) 0x20-P帧(H265) 0x21-I帧(H265) 3-参数变化帧 5-PCM音频帧 6-SPEEX音频帧 7-AAC音频帧 9-信息帧
            /// </summary>
            public UInt16 frame_type;

            /// <summary>
            /// 时间戳，单位毫秒
            /// </summary>
            public UInt64 absolute_timestamp;
        }

        /// <summary>
        /// 请求视频返回参数，需用户自行提供存储空间
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct OPEN_VIDEO_RES
        {
            /// <summary>
            /// 通道
            /// </summary>
            public UInt32 channel;

            /// <summary>
            /// 视频编码类型
            /// </summary>
            public VIDEO_ENCODE video_type;

            /// <summary>
            /// 视频画面宽度
            /// </summary>
            public int image_width;

            /// <summary>
            /// 视频画面高度
            /// </summary>
            public int image_height;

            /// <summary>
            /// 视频帧率
            /// </summary>
            public int fps;

            /// <summary>
            /// 视频基准时间
            /// </summary>
            public Int64 basetime;

        }

        /// <summary>
        /// 显示设置
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct DISPLAY_OPTION
        {
            /// <summary>
            /// 显示模式
            /// </summary>
            public DISPLAY_MODE dm;

            /// <summary>
            /// 图片质量
            /// </summary>
            public PIC_QUALITY pq;

        }

        /// <summary>
        /// 本地录像参数
        /// </summary>
        public struct _LOCAL_RECORD_PARAM
        {
            /// <summary>
            /// 录像文件路径及文件名称
            /// </summary>
            public char[] file_name;

            /// <summary>
            /// 录像主版本号
            /// </summary>
            public UInt32 ver;

            /// <summary>
            /// 录像次版本号
            /// </summary>
            public UInt32 subver;

            /// <summary>
            /// 录像时长
            /// </summary>
            public UInt64 time_cost;

            /// <summary>
            /// 视频编码类型
            /// </summary>
            VIDEO_ENCODE video_fmt;

            /// <summary>
            /// 视频帧率
            /// </summary>
            public UInt32 video_fps;

            /// <summary>
            /// 视频画面宽度
            /// </summary>
            public UInt32 video_width;

            /// <summary>
            /// 视频画面高度
            /// </summary>
            public UInt32 video_height;

            /// <summary>
            /// 音频编码类型
            /// </summary>
            AUDIO_ENCODE audio_fmt;

            /// <summary>
            /// 音频通道
            /// </summary>
            public UInt32 audio_channel;

            /// <summary>
            /// 音频采样率
            /// </summary>
            public UInt32 audio_sample;

            /// <summary>
            /// 设备SN
            /// </summary>
            public char[] device_sn;

            /// <summary>
            /// 设备名称
            /// </summary>
            public char[] device_name;

            /// <summary>
            /// 录像记录类型
            /// </summary>
            public VIDEO_RECORD record_type;
        }


        //typedef struct _LOCAL_RECORD_PARAM
        //{
        //    char file_name[260];        //	录像路径和文件名
        //    uint32 ver;             //	录像主版本号
        //    uint32 subver;              //	录像次版本号
        //    uint64 time_cost;           //	录像时长
        //    VIDEO_ENCODE video_fmt;
        //    uint32 video_fps;
        //    uint32 video_width;     //	视频宽
        //    uint32 video_height;        //	视频高
        //    AUDIO_ENCODE audio_fmt;
        //    uint32 audio_channel;
        //    uint32 audio_sample;
        //    char device_sn[68];     //	设备sn
        //    char device_name[68];   //	设备名
        //    VIDEO_RECORD record_type;
        //}
        //LOCAL_RECORD_PARAM, *P_LOCAL_RECORD_PARAM;

        #endregion

        #region 枚举
        /// <summary>
        /// 树节点类型
        /// </summary>
        public enum NODE_TYPE_INFO
        {
            /// <summary>
            /// 无效值
            /// </summary>
            HME_NT_NODE=0,

            /// <summary>
            /// 设备节点
            /// </summary>
            HME_NT_DEVICE=1,

            /// <summary>
            /// DVS节点
            /// </summary>
            HME_NT_DVS=2,

            /// <summary>
            /// 分组节点
            /// </summary>
            HME_NT_GROUP=3,

            /// <summary>
            /// 通道节点
            /// </summary>
            HME_NT_CHANNEL=4
        }

        /// <summary>
        /// 客户端类型
        /// </summary>
        public enum CLIENT_TYPE
        {
            /// <summary>
            /// 移动
            /// </summary>
            CT_MOBILE = 0,
            /// <summary>
            /// PC
            /// </summary>
            CT_PC = 1,
            /// <summary>
            /// 插件
            /// </summary>
            CT_PLUGIN = 2,
            /// <summary>
            /// 平台
            /// </summary>
            CT_PLAT = 3,
            /// <summary>
            /// 设备
            /// </summary>
            CT_PU = 10
        }

        /// <summary>
        /// 连接优先级
        /// </summary>
        public enum CONNECT_PRI
        {
            /// <summary>
            /// 直连优先
            /// </summary>
            CPI_DIR = 1,
            /// <summary>
            /// 穿透优先
            /// </summary>
            CPI_NAT = 2,
            /// <summary>
            /// 中转优先
            /// </summary>
            CPI_RLY = 3,
            /// <summary>
            /// 默认优先级（直连 = 穿透 > 中转）
            /// </summary>
            CPI_DEF = 4	
        }

        /// <summary>
        /// 连接模式，支持与操作
        /// </summary>
        public enum CONNECT_MODE
        {
            /// <summary>
            /// 仅直连
            /// </summary>
            CM_DIR = 1,
            /// <summary>
            /// 仅穿透
            /// </summary>
            CM_NAT = 2,

            /// <summary>
            /// 仅中转
            /// </summary>
            CM_RLY = 4,

            /// <summary>
            /// 默认（直连、穿透和中转同时连接）
            /// </summary>
            CM_DEF = 7
        }

        /// <summary>
        /// 码流设置
        /// </summary>
        public enum CODE_STREAM
        {
            /// <summary>
            /// 无效值
            /// </summary>
            HMS_CS_NONE = -1,

            /// <summary>
            /// 超清 仅 support_third_stream=1可用
            /// </summary>
            HMS_CS_ULTRA_HD = 0,

            /// <summary>
            /// 主码流 -高清
            /// </summary>
            HMS_CS_MAJOR = 1,

            /// <summary>
            /// 次码流 -标清
            /// </summary>
            HMS_CS_MINOR = 2
        }

        /// <summary>
        /// 视频流设置
        /// </summary>
        public enum VIDEO_STREAM
        {
            /// <summary>
            /// 无效值
            /// </summary>
            HMS_VS_NONE = 0,
            /// <summary>
            /// 实时视频
            /// </summary>
            HMS_VS_REAL = 1,
            /// <summary>
            /// 录像回放
            /// </summary>
            HMS_VS_PRERECORD
        }

        /// <summary>
        /// 视频编码类型
        /// </summary>
        public enum VIDEO_ENCODE
        {
            /// <summary>
            /// H264编码类型
            /// </summary>
            HME_VE_H264 = 1,
            
            /// <summary>
            /// MPEG编码类型
            /// </summary>
            HME_VE_MPEG4 = 2,

            /// <summary>
            /// H265编码类型
            /// </summary>
            HME_VE_H265 = 4
        }

        /// <summary>
        /// 显示模式
        /// </summary>
        public enum DISPLAY_MODE
        {
            /// <summary>
            /// 无效值
            /// </summary>
            HME_DM_NONE = 0,

            /// <summary>
            /// DX模式
            /// </summary>
            HME_DM_DX,

            /// <summary>
            /// VFW模式
            /// </summary>
            HME_DM_VFW
        }

        /// <summary>
        /// 图片质量
        /// </summary>
        public enum PIC_QUALITY
        {
            /// <summary>
            /// 高画质
            /// </summary>
            HME_PQ_HIGHT = 1,

            /// <summary>
            /// 低画质
            /// </summary>
            HME_PQ_LOW = 2
        }

        /// <summary>
        /// 原始帧数据类型
        /// </summary>
        public enum _RAW_FRAME_TYPE
        {
            /// <summary>
            /// H264视频P帧
            /// </summary>
            HME_RFT_P = 0,
            
            /// <summary>
            /// H264视频I帧
            /// </summary>
            HME_RFT_I = 1,

            /// <summary>
            /// 音视频
            /// </summary>
            HME_RFT_AUDIO = 2,

            /// <summary>
            /// H265视频P帧
            /// </summary>
            HME_RFT_H265_P = 0x20,

            /// <summary>
            /// H265视频I帧
            /// </summary>
            HME_RFT_H265_I = 0x21,

            /// <summary>
            /// 音频PCM
            /// </summary>
            HME_RFT_PCM = 5,

            /// <summary>
            /// 音频SPEEX
            /// </summary>
            HME_RFT_SPEEX = 6,

            /// <summary>
            /// 音频AAC
            /// </summary>
            HME_RFT_AAC = 7,

            /// <summary>
            /// 音频ARM
            /// </summary>
            HME_RFT_ARM = 8,

            /// <summary>
            /// 音频ADPCM
            /// </summary>
            HME_RFT_ADPCM = 0xA,

            /// <summary>
            /// 音频G711A
            /// </summary>
            HME_RFT_G711A = 0xB,

            /// <summary>
            /// 音频G711U
            /// </summary>
            HME_RFT_G711U = 0xC,

            /// <summary>
            /// 信息帧
            /// </summary>
            HME_RFT_INFO = 9,
        }

        /// <summary>
        /// 音频编码类型
        /// </summary>
        public enum AUDIO_ENCODE
        {
            /// <summary>
            /// 无效数据
            /// </summary>
            HME_AE_NONE = -1,

            /// <summary>
            /// PCM编码类型
            /// </summary>
            HME_AE_PCMS8 = 0,

            /// <summary>
            /// ARM编码类型（保留未用）
            /// </summary>
            HME_AE_ARM = 1,

            /// <summary>
            /// SPEEX编码类型
            /// </summary>
            HME_AE_SPEEX=2,

            /// <summary>
            /// ADPCM编码类型
            /// </summary>
            HME_AE_ADPCM=3,

            /// <summary>
            /// ACC编码类型
            /// </summary>
            HME_AE_AAC=4,

            /// <summary>
            /// G711U
            /// </summary>
            HME_AE_G711A=5,

            /// <summary>
            /// G711A
            /// </summary>
            HME_AE_G711U=6
        }

        /// <summary>
        /// 录像记录类型
        /// </summary>
        public enum VIDEO_RECORD
        {
            /// <summary>
            /// 无效值
            /// </summary>
            HME_VR_NONE=0,

            /// <summary>
            /// 手动录像
            /// </summary>
            HME_VR_HANDLER=1,

            /// <summary>
            /// 报警录像
            /// </summary>
            HME_VR_ALARMTYPE=2,

            /// <summary>
            /// 定时录像
            /// </summary>
            HME_VR_TIMER=4,
        }
        #endregion

        }


}
