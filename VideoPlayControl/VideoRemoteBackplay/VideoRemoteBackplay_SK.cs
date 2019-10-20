using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoBasicClass;
using VideoPlayControl.VideoRemoteBackplay.BasicClass;
using VideoPlayControl.VideoRemoteBackplay.Enum;
using static VideoPlayControl.SDKInterface.SDK_TLi;

namespace VideoPlayControl.VideoRemoteBackplay
{
    public class VideoRemoteBackplay_SK : IVIdeoRemoteBackplay
    {
        public VideoInfo CurrentVideoInfo
        {
            get;
            set;
        }
        public CameraInfo CurrentCameraInfo { get; set; }
        public PictureBox PicPlayMain { get; set; }

        /// <summary>
        /// 播放句柄
        /// </summary>
        public IntPtr IntPtrPlayMain
        {
            get
            {
                if (PicPlayMain != null && PicPlayMain.IsHandleCreated)
                {
                    return PubMethod.GetPicPlayMainHandle(PicPlayMain);
                }
                return IntPtr.Zero;
            }
        }

        private VideoRemoteBackplayStatus backplayStatus = VideoRemoteBackplayStatus.StandBy;
        /// <summary>
        /// 远程回放状态
        /// </summary>
        public VideoRemoteBackplayStatus BackplayStatus
        {
            get { return backplayStatus; }
            set
            {
                if (backplayStatus != value)
                {
                    backplayStatus = value;
                }
            }
        }

        VideoRemoteBackplayStatus IVIdeoRemoteBackplay.BackplayStatus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        PictureBox IVIdeoRemoteBackplay.PicPlayMain { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event VideoRemoteBackplayStatusChangedDelegate VideoRemoteBackplayStatusChangedEvent;

        /// <summary>
        /// 远程回放状态改变事件
        /// </summary>
        /// <param name="VideoRemoteBackplayStatusChangedValue"></param>
        private void VideoRemoteBackplayStatusChanged(object VideoRemoteBackplayStatusChangedValue)
        {
            if (VideoRemoteBackplayStatusChangedEvent != null)
            {
                VideoRemoteBackplayStatusChangedEvent(this, VideoRemoteBackplayStatusChangedValue);
            }
        }
        public VideoRemoteFileInfo[] FindRemoteFile(VideoRemotePlaySearchPara para)
        {
            return FindRemoteFile(CurrentVideoInfo, para);
        }


        public VideoRemoteFileInfo[] FindRemoteFile(VideoInfo vInfo, VideoRemotePlaySearchPara para)
        {
            return FindRemoteFile1(vInfo, para);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vInfo"></param>
        /// <param name="para"></param>
        /// <returns></returns>

        public static VideoRemoteFileInfo[] FindRemoteFile1(VideoInfo vInfo, VideoRemotePlaySearchPara para)
        {
            return null;
        }



        /// <summary>
        /// 远程回放时间段录像
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public bool RemoteBackplayByTime(VideoRemotePlayByTimePara para)
        {
            return false;
        }

        public bool StartRemoteBackplayByTime(VideoRemotePlayByTimePara para)
        {
            return false;
        }

        public bool StopRemoteBackplayByTime()
        {
            return false;
        }
    }
}
