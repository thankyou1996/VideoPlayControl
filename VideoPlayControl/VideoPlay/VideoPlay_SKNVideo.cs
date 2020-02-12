using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl.Enum;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    /// <summary>
    /// 时刻H265
    /// </summary>
    public class VideoPlay_SKNVideo : IVideoPlay_Basic
    {
        public VideoPlay_SKNVideo(VideoInfo vInfo) : this(vInfo, vInfo.Cameras.First().Value)
        {

        }
        public VideoPlay_SKNVideo(VideoInfo vInfo, CameraInfo cInfo)
        {
            CurrentVideoInfo = vInfo;
            CurrentCameraInfo = cInfo;
        }

        /// <summary>
        /// 设置码流信息
        /// 如果当前处于视频播放状态 会关闭视频后 重新进入视频播放
        /// </summary>
        /// <param name="vs"></param>
        public override  void SetVideoStream(Enum_VideoStream vs)
        {
            if (vs != VideoStream)
            {
                VideoStream = vs;
                if (VideoPlayState == Enum_VideoPlayState.InPlayState)
                {
                    //处于播放中 关闭视频后切换码流后播放
                    VideoClose();
                    VideoPlay();
                }
                VideoStreamChanged(null);
            }
        }




        /// <summary>
        /// 视频关闭
        /// </summary>
        /// <returns></returns>
        public override bool VideoClose()
        {
            bool bolResult = false;
            SDK_SKNVideo.SDK_NSK_CLIENT_close_rt_video(intptrPlayMain);
            VideoRecordStatus = false;
            VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            return bolResult;
        }
        /// <summary>
        /// 视频播放
        /// </summary>
        /// <returns></returns>
        public override bool VideoPlay()
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
                VideoRecordStatus = true;
            }

            int Temp_intValue = GetVideoStreamValue(VideoStream);
            SDK_SKNVideo.SDK_NSK_CLIENT_open_rt_video(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel - 1, Temp_intValue, intptrPlayMain, Temp_strVideoRecord, Temp_strServerVideoRecord);
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
            VideoPlayState = Enum_VideoPlayState.InPlayState;
            return bolResult;
        }



        /// <summary>
        /// 播放视频
        /// </summary>
        /// <returns></returns>
        public override bool VideoPlay(VideoPlaySetting vps)
        {
            CurrentVideoPlaySet = vps;
            VideoPlay();
            return true;
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
                    strSaveName = VideoRecord.VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel, CurrentVideoInfo.VideoType);
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
        /// 获取客户端保存地址 (完整路径)
        /// </summary>
        /// <param name="strSavePath"></param>
        /// <param name="strSaveName"></param>
        /// <returns></returns>
        private string GetLocalSavePath(string strSavePath, string strSaveName)
        {
            if (string.IsNullOrEmpty(strSaveName) || strSaveName.ToLower().EndsWith(".h264"))
            {
                strSaveName = VideoRecord.VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel, CurrentVideoInfo.VideoType);
            }
            string strResult = strSavePath + "\\" + strSaveName;
            return strResult;
        }

        /// <summary>
        /// 云台控制
        /// </summary>
        /// <param name="PTZControl"></param>
        /// <param name="bolStart"></param>
        /// <returns></returns>
        public override bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            if (bolStart)
            {
                int Temp_iXSpeed = 0;
                int Temp_iYSpeed = 0;
                int Temp_iZSpeed = 0;
                switch (PTZControl)
                {
                    case Enum_VideoPTZControl.PTZControl_Up:
                        Temp_iYSpeed = CurrentVideoPlaySet.PTZSpeed;
                        break;
                    case Enum_VideoPTZControl.PTZControl_Down:
                        Temp_iYSpeed = -CurrentVideoPlaySet.PTZSpeed;
                        break;
                    case Enum_VideoPTZControl.PTZControl_Left:
                        Temp_iXSpeed = -CurrentVideoPlaySet.PTZSpeed;
                        break;
                    case Enum_VideoPTZControl.PTZControl_Right:
                        Temp_iXSpeed = CurrentVideoPlaySet.PTZSpeed;
                        break;
                    case Enum_VideoPTZControl.PTZControl_LeftUp:
                        Temp_iXSpeed = -CurrentVideoPlaySet.PTZSpeed;
                        Temp_iYSpeed = CurrentVideoPlaySet.PTZSpeed;
                        break;
                    case Enum_VideoPTZControl.PTZControl_LeftDown:
                        Temp_iXSpeed = -CurrentVideoPlaySet.PTZSpeed;
                        Temp_iYSpeed = -CurrentVideoPlaySet.PTZSpeed;
                        break;
                    case Enum_VideoPTZControl.PTZControl_RightUp:
                        Temp_iXSpeed = CurrentVideoPlaySet.PTZSpeed;
                        Temp_iYSpeed = CurrentVideoPlaySet.PTZSpeed;
                        break;
                    case Enum_VideoPTZControl.PTZControl_RightDown:
                        Temp_iXSpeed = CurrentVideoPlaySet.PTZSpeed;
                        Temp_iYSpeed = -CurrentVideoPlaySet.PTZSpeed;
                        break;
                    case Enum_VideoPTZControl.PTZControl_Zoom_Out:
                        Temp_iZSpeed = -CurrentVideoPlaySet.PTZSpeed;
                        break;
                    case Enum_VideoPTZControl.PTZControl_Zoom_In:
                        Temp_iZSpeed = CurrentVideoPlaySet.PTZSpeed;
                        break;
                }
                SDK_SKNVideo.SDK_NSK_CLIENT_dev_ovf_ptz_continue_move(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel - 1, Temp_iXSpeed, Temp_iYSpeed, Temp_iZSpeed);
            }
            else
            {
                SDK_SKNVideo.SDK_NSK_CLIENT_dev_ovf_ptz_stop(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel - 1);
            }

            return true;
        }




        /// <summary>
        /// 开始录像
        /// </summary>
        /// <param name="vrSet"></param>
        /// <returns></returns>
        public override bool StartVideoRecord(VideoRecordSet vrSet)
        {
            bool bolResult = true;
            CurrentVideoPlaySet.VideoRecordEnable = vrSet.Enable;
            CurrentVideoPlaySet.VideoRecordFilePath = vrSet.VideoRecordFilePath;
            CurrentVideoPlaySet.VideoRecordFileName = vrSet.VideoRecordFileName;
            CurrentVideoPlaySet.VideoRecordFilePath_Server = vrSet.VideoRecordFilePath_Server;
            CurrentVideoPlaySet.VideoRecordFileName_Server = vrSet.VideoRecordFileName_Server;
            CurrentVideoPlaySet.TimeOutVideoRecordCloseSecond = vrSet.TimeOutVideoRecordCloseSecond;
            //关闭视频
            VideoClose();
            //打开视频
            VideoPlay();
            return bolResult;
        }

        /// <summary>
        /// 关闭录像（不关闭视频）
        /// </summary>
        /// <returns></returns>
        public override bool StopVideoRecord()
        {
            bool bolResult = false;
            VideoClose();
            CurrentVideoPlaySet.VideoRecordEnable = false;
            VideoPlay();
            return bolResult;
        }


        #region 静态方法

        public static int GetVideoStreamValue(Enum_VideoStream vs)
        {
            int intValue = 2;
            switch (vs)
            {
                case Enum_VideoStream.MainStream:
                    intValue = 1;
                    break;
                case Enum_VideoStream.SubStream:
                    intValue = 2;
                    break;
            }
            return intValue;
        }
        #endregion
    }
}
