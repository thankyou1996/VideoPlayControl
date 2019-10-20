using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoPlayControl.VideoBasicClass;
using VideoPlayControl.VideoRemoteBackplay.BasicClass;
using VideoPlayControl.SDKInterface;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VideoPlayControl.VideoRemoteBackplay.Enum;

namespace VideoPlayControl.VideoRemoteBackplay
{
    /// <summary>
    /// 远程回放_海康
    /// </summary>
    public class VideoRemoteBackplay_Hik : IVIdeoRemoteBackplay
    {
        /// <summary>
        /// 登录设备返回值
        /// </summary>
        private int m_lUserID = -1;

        /// <summary>
        /// 文件查找句柄 录像回放句柄
        /// </summary>
        private int m_lPlayHandle = -1;

        /// <summary>
        /// 
        /// </summary>
        uint lpOutValue = 0;

        /// <summary>
        /// 总共时间
        /// </summary>
        uint totalTime = 0;


        private PictureBox picPlayMain = null;
        /// <summary>
        /// 播放窗口
        /// </summary>
        public PictureBox PicPlayMain
        {
            get
            {
                return picPlayMain;
            }

            set
            {
                picPlayMain = value;
            }
        }

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

        /// <summary>
        /// 远程回放状态改变事件
        /// </summary>
        public event VideoRemoteBackplayStatusChangedDelegate VideoRemoteBackplayStatusChangedEvent;

        /// <summary>
        /// 远程回放状态改变事件
        /// </summary>
        /// <param name="VideoRemoteBackplayStatusChangedValue"></param>
        private void VideoRemoteBackplayStatusChanged(object VideoRemoteBackplayStatusChangedValue )
        {
            if (VideoRemoteBackplayStatusChangedEvent != null)
            {
                VideoRemoteBackplayStatusChangedEvent(this, VideoRemoteBackplayStatusChangedValue);
            }
        }



        public VideoInfo CurrentVideoInfo
        {
            get;
            set;
        }
        public CameraInfo CurrentCameraInfo { get; set; }

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
        /// 远程
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public bool StartRemoteBackplayByTime(VideoRemotePlayByTimePara para)
        {
            VideoInfo vInfo = para.CameraInfo.VideoInfo;
            CurrentVideoInfo = vInfo;
            CameraInfo cInfo = para.CameraInfo;
            CurrentCameraInfo = cInfo;
            if (m_lPlayHandle >= 0)
            {
                // 先停止播放
                StopRemoteBackplayByTime();
            }
            if (para.StartPlayTime > para.EndPlayTime)
            {
                return false;
            }
            SDK_Hik.NET_DVR_DEVICEINFO_V30 DeviceInfo = new SDK_Hik.NET_DVR_DEVICEINFO_V30();
            m_lUserID = SDK_Hik.NET_DVR_Login_V30(vInfo.DVSAddress, vInfo.DVSConnectPort, vInfo.UserName, vInfo.Password, ref DeviceInfo);
            uint uuu = SDK_Hik.NET_DVR_GetLastError();
            if (m_lUserID < 0)
            {
                return false;
            }
            SDK_Hik.NET_DVR_TIME Stime = SDK_Hik.ConvertToNetTime(para.StartPlayTime);
            SDK_Hik.NET_DVR_TIME Etime = SDK_Hik.ConvertToNetTime(para.EndPlayTime);
            int intChannel = Convert.ToInt32(cInfo.Channel);
            SDK_Hik.NET_DVR_VOD_PARA struVodPara = new SDK_Hik.NET_DVR_VOD_PARA();
            struVodPara.dwSize = (uint)Marshal.SizeOf(struVodPara);
            struVodPara.struIDInfo.dwChannel = (uint)intChannel; //通道号 Channel number  
            struVodPara.hWnd = IntPtrPlayMain;//回放窗口句柄
            //设置回放的开始时间 Set the starting time to search video files
            struVodPara.struBeginTime = Stime;
            //设置回放的结束时间 Set the stopping time to search video files
            struVodPara.struEndTime = Etime;
            m_lPlayHandle = SDK_Hik.NET_DVR_PlayBackByTime_V40(m_lUserID, ref struVodPara);
            if (m_lPlayHandle == -1)
            {
                return false;
            }
            if (!SDK_Hik.NET_DVR_PlayBackControl(m_lPlayHandle, SDK_Hik.PlayBackControlCode.NET_DVR_PLAYSTART, 0, ref lpOutValue))
            {
                MessageBox.Show("文件播放失败！");
            }
            SDK_Hik.NET_DVR_PlayBackControl(m_lPlayHandle, SDK_Hik.PlayBackControlCode.NET_DVR_PLAYSTARTAUDIO, 0, ref lpOutValue);
            SDK_Hik.NET_DVR_PlayBackControl(m_lPlayHandle, SDK_Hik.PlayBackControlCode.NET_DVR_PLAYAUDIOVOLUME, 0XFFFF, ref lpOutValue);
            SDK_Hik.NET_DVR_PlayBackControl(m_lPlayHandle, SDK_Hik.PlayBackControlCode.NET_DVR_GETTOTALTIME, 0, ref totalTime);
            return true;
        }

        /// <summary>
        /// 远程
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public bool StopRemoteBackplayByTime()
        {
            SDK_Hik.NET_DVR_StopPlayBack(m_lPlayHandle);
            SDK_Hik.NET_DVR_Logout_V30(m_lUserID);
            PicPlayMain.Refresh();
            return false;
        }
    }
}
