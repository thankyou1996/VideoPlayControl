using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PublicClassCurrency;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    /// <summary>
    /// 智诺视频设备
    /// </summary>
    public class VideoPlay_ZLVideo : IVideoPlay
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

        private int m_nDeviceID = 0;
        private int m_nPlayHandle = 0;
        /// <summary>
        /// 智诺视频关闭
        /// </summary>
        /// <returns></returns>
        public bool VideoClose()
        {
            bool bolResult = false;
            if (m_nPlayHandle != 0)
            {
                SDK_ZLNetSDK.ZLNET_StopSaveRealData(m_nPlayHandle);
                SDK_ZLNetSDK.ZLNET_StopRealPlayEx(m_nPlayHandle);
            }
            if (m_nDeviceID != 0)
            {
                SDK_ZLNetSDK.ZLNET_Logout(m_nDeviceID);
            }
            VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoClose });
            return bolResult;
        }

        /// <summary>
        /// 智诺视频播放
        /// </summary>
        /// <returns></returns>
        public bool VideoPlay()
        {
            bool bolResult = false;
            int err = 0;
            SDK_ZLNetSDK.ZLNET_DEVICEINFO zlDevice = new SDK_ZLNetSDK.ZLNET_DEVICEINFO();
            m_nDeviceID = SDK_ZLNetSDK.ZLNET_LoginEx(CurrentVideoInfo.DVSAddress, Convert.ToUInt16(CurrentVideoInfo.DVSConnectPort), CurrentVideoInfo.UserName, CurrentVideoInfo.Password, 0, (IntPtr)0, ref zlDevice, ref err);
            if (m_nDeviceID > 0)
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.LoginSuccess });
                m_nPlayHandle = SDK_ZLNetSDK.ZLNET_RealPlayEx(m_nDeviceID, CurrentCameraInfo.Channel - 1, intptrPlayMain);
                if (m_nPlayHandle > 0)
                {
                    SDK_ZLNetSDK.ZLNET_AdjustFluency(m_nPlayHandle, 6);
                }
                if (CurrentVideoPlaySet.VideoRecordEnable)  //录像使能
                {
                    string Temp_strVideoRecord = GetLocalSavePath(CurrentVideoPlaySet.VideoRecordFilePath, CurrentVideoPlaySet.VideoRecordFileName);
                    SDK_ZLNetSDK.ZLNET_SaveRealData(m_nPlayHandle, Temp_strVideoRecord);
                }
                VideoPlayState = Enum_VideoPlayState.InPlayState;
            }
            else
            {
                VideoPlayState = Enum_VideoPlayState.NotInPlayState;
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.DevLoginException });
            }

            return bolResult;
        }

        public string GetLocalSavePath(string strSavePath, string strSaveName)
        {
            string strResult = strSavePath + strSaveName;
            if (!strSaveName.EndsWith(".dav"))
            {
                strResult = strSavePath + "\\" + VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel, CurrentVideoInfo.VideoType);
            }
            return strResult;
        }

        public bool VideoPlayCallback(VideoPlayCallbackValue value)
        {
            bool bolResult = false;
            if (VideoPlayCallbackEvent != null)
            {
                return VideoPlayCallbackEvent(this, value);
            }
            return bolResult;
        }

        public bool VideoPlayEx()
        {
            throw new NotImplementedException();
        }

        public bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            throw new NotImplementedException();
        }

        public void VideoSizeChange(int intLeft, int intRight, int intTop, int intBottom)
        {
            //throw new NotImplementedException();
        }
    }
}
