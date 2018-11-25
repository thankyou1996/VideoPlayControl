using System;
using System.Collections.Generic;
using System.Text;
using VideoPlayControl.Enum;

namespace VideoPlayControl
{
    /// <summary>
    /// 视频播放设置
    /// </summary>
    public class VideoPlaySetting
    {
        /// <summary>
        /// 自动重连
        /// </summary>
        private bool bolAutoReconn = true;

        /// <summary>
        /// 自动重连
        /// </summary>
        public bool AutoReconn
        {
            get { return bolAutoReconn; }
            set { bolAutoReconn = value; }
        }

        /// <summary>
        /// 视频录像使能
        /// </summary>
        private bool bolVideoRecordEnable = false;
        /// <summary>
        /// 视频录像使能
        /// </summary>
        public bool VideoRecordEnable
        {
            get { return bolVideoRecordEnable; }
            set { bolVideoRecordEnable = value; }
        }



        /// <summary>
        /// 视频录像文件地址
        /// </summary>
        private string strVideoRecordFilePath = "";

        /// <summary>
        /// 视频录像文件地址
        /// </summary>
        public string VideoRecordFilePath
        {
            get { return strVideoRecordFilePath; }
            set { strVideoRecordFilePath = value; }
        }


        /// <summary>
        /// 视频录像文件名称
        /// </summary>
        private string strVideoRecordFileName = "";

        /// <summary>
        /// 视频录像文件名称
        /// </summary>
        public string VideoRecordFileName
        {
            get { return strVideoRecordFileName; }
            set { strVideoRecordFileName = value; }
        }

        private string strVideoRecordFilePath_Server = "";

        /// <summary>
        /// 视频文件存储地址_服务器（不包含文件名称）（通常为相对路径，因为无法知道服务器盘符分区等信息）
        /// </summary>
        public string VideoRecordFilePath_Server
        {
            get { return strVideoRecordFilePath_Server; }
            set { strVideoRecordFilePath_Server = value; }
        }


        private string strVideoRecordFileName_Server = "";

        /// <summary>
        //  视频文件存储文件名称_服务器
        /// </summary>
        public string VideoRecordFileName_Server
        {
            get { return strVideoRecordFileName_Server; }
            set { strVideoRecordFileName_Server = value; }
        }



        /// <summary>
        /// 预录像使能
        /// </summary>
        private bool bolPreVideoRecord = false;

        /// <summary>
        /// 预录像使能
        /// </summary>
        public bool PerVideoRecord
        {
            get { return bolPreVideoRecord; }
            set { bolPreVideoRecord = value; }
        }

        /// <summary>
        /// 预录像文件地址
        /// </summary>
        private string strPreVideoRecordFilePath = "";

        /// <summary>
        /// 预录像文件地址
        /// </summary>
        public string PreVideoRecordFilePath
        {
            get { return strPreVideoRecordFilePath; }
            set { strPreVideoRecordFilePath = value; }
        }

        /// <summary>
        /// 音频使能
        /// </summary>
        private bool bolVideoMonitorEnable = false;
        /// <summary>
        /// 音频使能
        /// </summary>
        public bool VideoMonitorEnable
        {
            get { return bolVideoMonitorEnable; }
            set { bolVideoMonitorEnable = value; }
        }



        /// <summary>
        /// 预置点设置 -1 代表不设置预置点
        /// 注意：部分主机不包含预制点功能
        /// </summary> 
        private int intPreSetPosi = -1;

        /// <summary>
        /// 预制点设置 -1 代表不设置预置点
        /// 注意：部分主机不包含预制点功能
        /// </summary>
        public int PreSetPosi
        {
            get { return intPreSetPosi; }
            set { intPreSetPosi = value; }
        }

        /// <summary>
        /// 预置点设置仅首次生效
        /// </summary>
        public bool bolFirstInForcePreSetPosi = false;
        /// <summary>
        /// 预置点设置仅首次生效
        /// </summary>
        public bool FirstInForcePreSetPosi
        {
            get { return bolFirstInForcePreSetPosi; }
            set { bolFirstInForcePreSetPosi = value; }
        }


        /// <summary>
        /// 云台速度
        /// </summary>
        private int intPTZSpeed = 4;

        /// <summary>
        /// 云台速度
        /// </summary>
        public int PTZSpeed
        {
            get { return intPTZSpeed; }
            set { intPTZSpeed = value; }
        }

        /// <summary>
        /// 连接类型
        /// </summary>
        private Enum_VideoConnType connType;

        /// <summary>
        /// 连接类型
        /// </summary>
        public Enum_VideoConnType ConnType
        {
            get { return connType; }
            set { connType = value; }
        }


        /// <summary>
        /// 视频播放时长（0表示无限制）
        /// </summary>
        private int intVideoPlayTimeLimit = 0;

        /// <summary>
        /// 视频播放时长（0表示无限制）
        /// </summary>
        public int VideoPlayTimeLimit
        {
            get
            {
                return intVideoPlayTimeLimit;
            }
            set
            {
                intVideoPlayTimeLimit = value;
            }
        }

        private bool bolAnsyPlay = false;

        /// <summary>
        /// 异步播放
        /// </summary>
        public bool AnsyPlay
        {
            get { return bolAnsyPlay; }
            set { bolAnsyPlay = value; }
        }

        private int intTimeOutVideoCloseSecond = 180;


        /// <summary>
        /// 超时关闭视频设置(秒) 默认180秒
        /// 注意：目前尽在 VideoPlayWindow 控件中实现(IVideoPlay尚未实现) 
        /// </summary>
        public int TimeOutVideoCloseSecond
        {
            get { return intTimeOutVideoCloseSecond; }
            set { intTimeOutVideoCloseSecond = value; }
        }
    }
}
