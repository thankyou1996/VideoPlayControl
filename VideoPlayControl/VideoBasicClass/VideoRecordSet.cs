using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoBasicClass
{
    /// <summary>
    /// 视频录像设置
    /// </summary>
    public class VideoRecordSet
    {
        private bool bolEnable = false;

        public bool Enable
        {
            get { return bolEnable; }
            set { bolEnable = value; }
        }

        /// <summary>
        /// 视频录像文件地址
        /// </summary>
        private string strVideoRecordFilePath = "";

        /// <summary>
        /// 视频录像文件地址 不包含文件文件名称
        /// </summary>
        public string VideoRecordFilePath
        {
            get { return strVideoRecordFilePath; }
            set { strVideoRecordFilePath = value; }
        }


        /// <summary>
        /// 视频录像文件名称 仅包含文件名称
        /// </summary>
        private string strVideoRecordFileName = "";

        /// <summary>
        /// 视频录像文件名称 仅包含文件名称
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
        /// 视频文件存储文件名称_服务器 仅包含文件名称
        /// </summary> 
        public string VideoRecordFileName_Server
        {
            get { return strVideoRecordFileName_Server; }
            set { strVideoRecordFileName_Server = value; }
        }

        /// <summary>
        /// 超时关闭视频录像 默认180秒
        /// 注意：
        /// </summary>
        private int intTimeOutVideoRecotdCloseSecond = 180;

        /// <summary>
        /// 超时关闭视频录像 默认180秒
        /// 注意：目前仅在 VideoPlayWindow 控件中实现(IVideoPlay尚未实现) 
        /// 注意：关闭视频录像等同于关闭视频
        /// </summary>
        public int TimeOutVideoRecordCloseSecond
        {
            get { return intTimeOutVideoRecotdCloseSecond; }
            set { intTimeOutVideoRecotdCloseSecond = value; }
        }
    }
}
