using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    public class VideoPlay_SKNVideo : IVideoPlay
    {
        public VideoInfo CurrentVideoInfo { get; set; }
        public CameraInfo CurrentCameraInfo { get; set; }
        public VideoPlaySetting CurrentVideoPlaySet { get; set; }
        public IntPtr intptrPlayMain { get; set; }
        private Enum_VideoPlayState videoPlayState = Enum_VideoPlayState.VideoInfoNull;
        public Enum_VideoPlayState VideoPlayState
        {
            get { return videoPlayState; }
            set
            {
                if (videoPlayState != value)
                {
                    videoPlayState = value;
                    if (VideoPlayStateChangedEvent != null)
                    {
                        VideoPlayStateChangedEvent(this, null);
                    }
                }
            }
        }
        public int VideoplayWindowWidth { get; set; }
        public int VideoplayWindowHeight { get; set; }

        public event VideoPlayCallbackDelegate VideoPlayCallbackEvent;

        public event VideoPlayStateChangedDelegate VideoPlayStateChangedEvent;
        public bool VideoPlayCallback(VideoPlayCallbackValue value)
        {
            bool bolResult = false;
            if (VideoPlayCallbackEvent != null)
            {
                return VideoPlayCallbackEvent(this, value);
            }
            return bolResult;
        }
        public bool VideoClose()
        {
            bool bolResult = false;
            SDK_SKNVideo.SDK_NSK_CLIENT_close_rt_video(intptrPlayMain);
            VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            return bolResult;
        }

        public bool VideoPlay()
        {
            bool bolResult = false;
            VideoPlayState = Enum_VideoPlayState.Connecting;
            string Temp_strVideoRecord = null;
            string Temp_strServerVideoRecord = null;
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                //启用录像
                Temp_strVideoRecord = GetLocalSavePath(CurrentVideoPlaySet.VideoRecordFilePath, "");
                Temp_strServerVideoRecord = GetServerSavePath(CurrentVideoPlaySet.VideoRecordFilePath_Server, CurrentVideoPlaySet.VideoRecordFileName_Server);
            }

            SDK_SKNVideo.SDK_NSK_CLIENT_open_rt_video(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel - 1, 1, intptrPlayMain, Temp_strVideoRecord, Temp_strServerVideoRecord);
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
            VideoPlayState = Enum_VideoPlayState.InPlayState;
            return bolResult;
        }

        /// <summary>
        /// 获取服务器保存地址
        /// </summary>
        /// <returns></returns>
        private string GetServerSavePath(string strSavePath, string strSaveName)
        {
            if (!strSaveName.EndsWith(".h264"))
            {
                if (string.IsNullOrEmpty(strSaveName))
                {
                    strSaveName = VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel, CurrentVideoInfo.VideoType);
                }
                else
                {
                    strSaveName = strSaveName + ".h264";
                }
            }
            if (strSavePath.Length > 2 && !strSaveName.EndsWith("\\"))
            {
                strSavePath = strSavePath + "\\";
            }
            string strResult = strSavePath + strSaveName;
            if (!strResult.StartsWith("\\"))
            {
                strResult = "\\" + strResult;
            }
            return strResult;
        }

        /// <summary>
        /// 获取客户端保存地址
        /// </summary>
        /// <param name="strSavePath"></param>
        /// <param name="strSaveName"></param>
        /// <returns></returns>
        private string GetLocalSavePath(string strSavePath, string strSaveName)
        {
            string strResult = strSavePath + strSaveName;
            if (!CurrentVideoPlaySet.VideoRecordFilePath.EndsWith(".h264"))
            {

                strResult = strSavePath + "\\" + VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel, CurrentVideoInfo.VideoType);
            }
            return strResult;
        }

        public bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            //throw new NotImplementedException();
            return false;
        }

        public void VideoSizeChange(int intLeft, int intRight, int intTop, int intBottom)
        {
            //throw new NotImplementedException();
            //return false;
        }

        public bool VideoPlayEx()
        {
            //throw new NotImplementedException();
            return false;
        }
    }
}
