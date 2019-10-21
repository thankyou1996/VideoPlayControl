using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoBasicClass;
using VideoPlayControl.VideoRemoteBackplay.BasicClass;
using VideoPlayControl.VideoRemoteBackplay.Enum;
using static VideoPlayControl.SDKInterface.SDK_TLi;

namespace VideoPlayControl.VideoRemoteBackplay
{
    public class VideoRemoteBackplay_TLi : IVIdeoRemoteBackplay
    {
        public VideoInfo CurrentVideoInfo
        {
            get;
            set;
        }
        public CameraInfo CurrentCameraInfo { get; set; }

        private PictureBox picPlayMain = null;
        public PictureBox PicPlayMain
        {
            get
            {
                return picPlayMain;
            }

            set
            {
                picPlayMain = value;
                if (picPlayMain != null && picPlayMain.IsHandleCreated)
                {
                    IntPtrPlayMain = picPlayMain.Handle;
                }
            }
        }

        /// <summary>
        /// 播放句柄
        /// </summary>
        public IntPtr IntPtrPlayMain
        {
            get;
            private set;
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
        /// 查找远程文件
        /// </summary>
        /// <param name="vInfo"></param>
        /// <param name="para"></param>
        /// <returns></returns>

        public static VideoRemoteFileInfo[] FindRemoteFile1(VideoInfo vInfo, VideoRemotePlaySearchPara para)
        {
            VideoRemoteFileInfo[] result = new VideoRemoteFileInfo[3];
            SDK_TLi.NETDVR_devicenode_t deviceInfo = new SDK_TLi.NETDVR_devicenode_t();
            int Temp_intIndex = SDK_TLi.GetNodeIndexByDeviceID(vInfo.DVSUniqueCode);
            SDK_TLi.DeviceInfo devicenode = VideoEnvironment.VideoEnvironment_TL.devices[Temp_intIndex];
            SDK_TLi.NETDVR_fileSearchCondition_t fileSearch = new SDK_TLi.NETDVR_fileSearchCondition_t
            {
                chn = 2,
                type = (ushort)NETDVR_REC_INDEX_MASK.NETDVR_REC_INDEX_ALL,
                start_time = Convert.ToUInt32(CommonMethod.ConvertClass.DateTimeToUnixTimestamp(para.StartTime)),
                end_time = (uint)((para.EndTime.ToUniversalTime().Ticks - 621355968000000000) / 10000000) + 86400,
                startID = 1,
                max_return = 3
            };
            NETDVR_recFileSearchResult_t recFile = new NETDVR_recFileSearchResult_t();
            int intResult = SDK_TLi.NETDVR_recFilesSearch(devicenode.nHandle, ref fileSearch, ref recFile);
            NETDVR_recFileInfo_t fileInfo = (NETDVR_recFileInfo_t)Marshal.PtrToStructure(recFile.precInfo, typeof(NETDVR_recFileInfo_t));
            Console.WriteLine(fileInfo.channel_no + " - 文件名称：" + fileInfo.filename);
            while (fileInfo.pnext != IntPtr.Zero)
            {
                fileInfo = (NETDVR_recFileInfo_t)Marshal.PtrToStructure(fileInfo.pnext, typeof(NETDVR_recFileInfo_t));
                Console.WriteLine(fileInfo.channel_no + " - 文件名称：" + fileInfo.filename);
                result[0].FileName = fileInfo.filename;
            }
            return result;
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
