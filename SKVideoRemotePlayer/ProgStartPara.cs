using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKVideoRemotePlayer
{
    /// <summary>
    /// 程序启动参数
    /// </summary>
    public class ProgPara
    {

        public static ProgPara CurrentProgPara
        {
            get;
            set;
        }

        /// <summary>
        /// 服务器地址
        /// </summary>
        public string ServerAddress
        {
            get;
            set;
        }

        /// <summary>
        /// 服务器端口
        /// </summary>
        public UInt16 ServerPort
        {
            get;
            set;
        }

        /// <summary>
        /// 登陆名称
        /// </summary>
        public string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// 选中通道
        /// </summary>
        public int Channel
        {
            get;
            set;
        }


        /// <summary>
        /// 远程回放开始时间
        /// </summary>
        public DateTime PlaybackTimeStart
        {
            get;
            set;
        }

        /// <summary>
        /// 远程回放结束时间
        /// </summary>
        public DateTime PlaybackTimeEnd
        {
            get;
            set;
        }


        /// <summary>
        /// 远程回放时间
        /// </summary>
        public DateTime PlaybackTime
        {
            get;
            set;
        }
        public string XmlCgfFullPath
        {
            get;
            set;
        }

        /// <summary>
        /// 录像相关文件保存路径
        /// </summary>
        public string DefaultSaveDir
        {
            get;
            set;
        }
        public VideoInfo VideoInfo
        {
            get;
            set;
        }



    }
}
