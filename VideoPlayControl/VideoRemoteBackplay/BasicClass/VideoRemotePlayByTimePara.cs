using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoRemoteBackplay.BasicClass
{
    public class VideoRemotePlayByTimePara
    {
        /// <summary>
        /// 摄像头信息
        /// </summary>
        public CameraInfo CameraInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartPlayTime
        {
            get;
            set;
        }


        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndPlayTime
        {
            get;
            set;
        }


    }
}
