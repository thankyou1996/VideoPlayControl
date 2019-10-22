using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayControl
{
    /// <summary>
    /// 程序参数
    /// </summary>
    public class ProgParameter
    {

        public static string ProgLogAddress = Environment.CurrentDirectory + "//UserData/VideoPlayControlLog";
        #region CloundSee(云视通相关参数)
        /// <summary>
        /// 云视通初始化端口
        /// </summary>
        public static int intCloundSee_intLocStartPort = ProgConstants.c_intCloundSee_intLocStartPort;

        /// <summary>
        /// 云视通临时文件存放位置
        /// </summary>
        public static string strCloundSee_TempDicPath = ProgConstants.ro_strCloundSee_TempDicPath;
        #endregion

        #region Ezviz (萤石云相关参数)
        
        /// <summary>
        /// 萤石云 开放平台认证中心地址
        /// </summary>
        public static string strEzviz__AuthAddr = ProgConstants.c_strEzviz_AuthAddr_Default;
        
        /// <summary>
        /// 萤石云 开放平台后台地址
        /// </summary>
        public static string strEzviz__PlatForm = ProgConstants.c_strEzviz_PlatForm_Default;
        
        /// <summary>
        /// 萤石云 APPID
        /// </summary>
        public static string strEzviz__AppID = ProgConstants.c_strEzviz_AppID_Default;

        /// <summary>
        /// 萤石云 AppSecret 
        /// </summary>
        public static string strEzviz_AppSecret = ProgConstants.c_strEzviz_AppSecret_Default;

        public static string strEzviz_AccessToken = "at.do2lz6k485mc38pr3n8t74vv2gm10uqm-8kx8l74m7b-04p6ip5-so5iigvth";

        public static int intEzviz_VideoPlayEnvironmentReset = 0;

        /// <summary>
        /// 萤石视频 播放重置环境
        /// </summary>
        public static bool Ezviz_VideoPlayEnvironmentReset
        {
            get { return (intEzviz_VideoPlayEnvironmentReset == 1); }
        }

        #endregion

        #region 时刻视频SDK相关参数
        /// <summary>
        /// 时刻视频_控制端口
        /// </summary>
        public static UInt16 uintSKVideo_ControlPort = 47624;

        /// <summary>
        /// 时刻视频_视频端口
        /// </summary>
        public static UInt16 uintSKVideo_VideoPort = 47724;

        /// <summary>
        /// 时刻视频_音频端口
        /// </summary>
        public static UInt16 uintSKVideo_AudioPort = 47824;
        /// <summary>
        /// 时刻视频_码流端口
        /// </summary>
        public static UInt16 uintSKVideo_AVPort = 47924;

        /// <summary>
        /// 服务器IP
        /// </summary>
        public static string strSKVideo_ServerIP = "103.10.2.130";

        /// <summary>
        /// 客户端ID
        /// </summary>
        public static string strSKVideo_ClientUGID = "Admin";

        /// <summary>
        /// 本地录像存储路径
        /// </summary>
        public static string strSKVideo_RecordDirectory = "";


        /// <summary>
        /// 时刻对讲记录生成方式
        /// true表示新方式生成    即录音是如果无录像通道则主动调用生成视频方法生成录像（录音文件会在文件中生成）
        /// false表示旧方式生成   即录音文件独立生成（对讲接口中的方法）
        /// </summary>
        public static bool SKVideoTalkRecordFlag = true;

        /// <summary>
        /// 时刻视频浏览使用方式
        /// true表示使用新方法进行预览       即使用 p_sdkc_start_rt_video_ex 方法进行预览
        /// false 表示使用旧方法进行预览     即使用p_sdkc_start_rt_video 方法进行预览
        /// </summary>
        public static bool SKVideoPlayFlag = true;
        
        #endregion

        #region 华迈视频相关参数
        /// <summary>
        /// 华迈云登录信息_登录名
        /// </summary>
        //public static string strHuaMaiLoginInfo_LoginName = "test1996";
        public static string strHuaMaiLoginInfo_LoginName = "ja110sk";

        /// <summary>
        /// 华迈云登录信息_登录密码
        /// </summary>
        public static string strHuaMaiLoginInfo_LoginPwd = "ja123123";
        //public static string strHuaMaiLoginInfo_LoginPwd = "123456";

        /// <summary>
        ///华迈平台 登录句柄
        /// </summary>
        public static IntPtr HuaMai_iServer = IntPtr.Zero;

        /// <summary>
        /// 华迈平台_设备树句柄
        /// </summary>
        public static IntPtr HuaMai_iTree = IntPtr.Zero;
        #endregion

        #region 海康流媒体模式相关参数

        /// <summary>
        /// 海康流媒体服务地址
        /// </summary>
        public static string strHikStreamIP = "192.168.2.19";

        /// <summary>
        /// 海康流媒体音频转发服务地址
        /// </summary>
        public static string strHikStreamVoiceIP="0.0.0.0";
        /// <summary>
        /// 海康流媒体音频转发服务端口
        /// </summary>
        public static int intHikStreamVoiceServerPort = 8081;
        /// <summary>
        /// 海康流媒体音频转发服务客户端端口
        /// </summary>。
        public static int intHikStreamVoiceClientPort = 8082;
        #endregion


        /// <summary>
        /// 过渡转换使能
        /// </summary>
        public static bool TransitionEnable
        {
            get { return true ; }
        }
    }
}
