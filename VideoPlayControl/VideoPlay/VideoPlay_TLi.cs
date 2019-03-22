using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;
using VideoPlayControl.Enum;
using VideoPlayControl.VideoBasicClass;
using static VideoPlayControl.SDKInterface.SDK_TLi;

namespace VideoPlayControl.VideoPlay
{
    /// <summary>
    /// 通立设备
    /// </summary>
    public class VideoPlay_TLi : IVideoPlay
    {
        public pFrameCallBack frameCallBack;
        public pDecFrameCallBack decFrameCallBack;
        public pRecFilenameCallBack recFileNameCallBack;
        public VideoInfo CurrentVideoInfo { get; set; }

        public CameraInfo CurrentCameraInfo { get; set; }
        public VideoPlaySetting CurrentVideoPlaySet { get; set; }

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
                intptrPlayMain = picPlayMain.Handle;
            }
        }
        public IntPtr intptrPlayMain
        {
            get;
            private set;
        }

        int m_hPlayPort = 0;
        SDKInterface.SDK_TLi.DeviceInfo d;
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
        public int VideoplayWindowWidth { get ; set ; }
        public int VideoplayWindowHeight { get ; set; }

   

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
            bool bolResult = true;
            byte btyChannel = (byte)(CurrentCameraInfo.Channel - 1);
            int ret = NETDVR_stopSubVideoSend(d.nHandle, btyChannel);
            ret = NETDVR_destroySubVideoDecoder(d.nHandle, btyChannel);
            ret = NETDVR_closeSubVideoReciever(d.nHandle, btyChannel);
            TLPlay_Stop(m_hPlayPort);
            TLPlay_Close(m_hPlayPort);
            TLPlay_FreePort(m_hPlayPort);
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                NETDVR_stopSubRecord(d.nHandle, btyChannel);
                VideoRecordStatus = false;
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.StopVideoRecord });
            }
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoClose });
            VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            return bolResult;
        }

        public bool VideoPlay()
        {
            bool bolResult = false;
            SDKInterface.SDK_TLi.NETDVR_devicenode_t deviceInfo = new SDKInterface.SDK_TLi.NETDVR_devicenode_t();
            d = VideoEnvironment.VideoEnvironment_TL.devices[0];
            deviceInfo.device_ID = d.devicenode.device_ID;
            deviceInfo.maxSubstreamNum = d.devicenode.maxSubstreamNum;
            SDKInterface.SDK_TLi.NETDVR_createDVR_3g(ref d.nHandle, deviceInfo.device_ID, ref deviceInfo);
            m_hPlayPort=0;
            SDKInterface.SDK_TLi.TLPlay_GetPort(ref m_hPlayPort);
            SDKInterface.SDK_TLi.TLPlay_SetPlayMode(m_hPlayPort, SDKInterface.SDK_TLi.TLPLAYMODE.TL_PLAY_POOL_STREAM);
            SDKInterface.SDK_TLi.TLPlay_OpenStream(m_hPlayPort, 2 << 20);
            SDKInterface.SDK_TLi.TLPlay_Play(m_hPlayPort, PicPlayMain.Handle);
            VideoPlayState = Enum_VideoPlayState.Connecting;
            frameCallBack = get_encframe;
            byte btyChannel = (byte)(CurrentCameraInfo.Channel - 1);
            int ret = NETDVR_openSubVideoReciever(d.nHandle, btyChannel, frameCallBack, 0);
            if ((int)NETDVR_RETURN_CODE.NETDVR_SUCCESS != ret)
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlayException, EventContent = "打开子码流接收异常" });
                NETDVR_closeSubVideoReciever(d.nHandle, btyChannel);
                return false;
            }

            decFrameCallBack = DealDecVideoFrame;
            ret = NETDVR_createSubVideoDecoder(d.nHandle, btyChannel, decFrameCallBack, 0);
            ret = NETDVR_setSubDecoderFMT(d.nHandle, btyChannel, NETDVR_FMT_TYPE.NETDVR_FMT_YV12);
            if ((int)NETDVR_RETURN_CODE.NETDVR_SUCCESS != ret)
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlayException, EventContent = "设置解码格式异常" });
                NETDVR_destroySubVideoDecoder(d.nHandle, btyChannel);
                NETDVR_closeSubVideoReciever(d.nHandle, btyChannel);
                return false;
            }
            ret = NETDVR_startSubVideoSend(d.nHandle, btyChannel);
            if ((int)NETDVR_RETURN_CODE.NETDVR_SUCCESS != ret)
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlayException, EventContent = "设置解码格式异常" });
                NETDVR_destroySubVideoDecoder(d.nHandle, btyChannel);
                NETDVR_closeSubVideoReciever(d.nHandle, btyChannel);
                return false ;
            }
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
            VideoPlayState = Enum_VideoPlayState.InPlayState;
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                recFileNameCallBack = new pRecFilenameCallBack(FilenameCallBack);
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.StartVideoRecord });
                NETDVR_setSubRecordFileNameCB(d.nHandle, btyChannel, recFileNameCallBack, 0);
                NETDVR_startSubRecord(d.nHandle, btyChannel, CurrentVideoPlaySet.VideoRecordFilePath, 0);
            }
            return bolResult;
        }

        public void get_encframe(IntPtr ip, uint dwContextEnc)
        {
            FrameHeadr pFrmHdr = (FrameHeadr)Marshal.PtrToStructure(ip, typeof(FrameHeadr));
            PLAYFRAMEHDR pLAYFRAMEHDR = new PLAYFRAMEHDR
            {
                m_byMediaType = pFrmHdr.mediaType,
                m_dwDataSize = pFrmHdr.dataSize,
                m_byFrameRate = pFrmHdr.frameRate,
                m_dwFrameID = pFrmHdr.frameID,
                m_dwTimeStamp = pFrmHdr.timeStamp
            };
            pLAYFRAMEHDR.union1.m_tVideoParam.m_bKeyFrame = pFrmHdr.videoParam.keyFrame;
            pLAYFRAMEHDR.union1.m_tVideoParam.m_wVideoWidth = pFrmHdr.videoParam.videoWidth;
            pLAYFRAMEHDR.union1.m_tVideoParam.m_wVideoHeight = pFrmHdr.videoParam.videoHeight;
            byte[] pl = StructToBytes(pLAYFRAMEHDR);
            byte[] pD = new byte[pFrmHdr.dataSize];
            Marshal.Copy(pFrmHdr.pData, pD, 0, (int)pFrmHdr.dataSize);
            byte[] bytes = pl.Concat(pD).ToArray();
            if (pFrmHdr.mediaType == 98)
            {
                uint len = Convert.ToUInt32(pFrmHdr.dataSize + 40);
                TLPlay_InputVideoData(m_hPlayPort, ref bytes[0], len);
            }
        }

        private void DealDecVideoFrame(FrameHeadrDec pFrmHdrDec, uint dwContext)
        {
            Console.WriteLine(dwContext);
        }
        /// <summary>
        /// 结构体转byte数组
        /// </summary>
        /// <param name="structObj">要转换的结构体</param>
        /// <returns>转换后的byte数组</returns>
        public byte[] StructToBytes(object structObj)
        {
            //得到结构体的大小
            int size = Marshal.SizeOf(structObj);
            //创建byte数组
            byte[] bytes = new byte[size];
            //分配结构体大小的内存空间
            IntPtr structPtr = Marshal.AllocHGlobal(size);
            //将结构体拷到分配好的内存空间
            Marshal.StructureToPtr(structObj, structPtr, false);
            //从内存空间拷到byte数组
            Marshal.Copy(structPtr, bytes, 0, size);
            //释放内存空间
            Marshal.FreeHGlobal(structPtr);
            //返回byte数组
            return bytes;
        }


        private void FilenameCallBack(IntPtr p_filename, uint dwContext)
        {
            string temp_strValue = CurrentVideoPlaySet.VideoRecordFileName;
            if (CurrentVideoPlaySet.VideoRecordEnable&&string.IsNullOrEmpty(CurrentVideoPlaySet.VideoRecordFileName))
            {
                temp_strValue = VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel, CurrentVideoInfo.VideoType);
            }
            byte[] tmp = System.Text.Encoding.Default.GetBytes(temp_strValue);

            VideoRecordStatus = true;
            Marshal.Copy(tmp, 0, p_filename, tmp.Length);
        }
        public bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            return false;
        }



        /// <summary>
        /// 联动预置点
        /// </summary>
        /// <param name="intPrestValue"></param>
        /// <returns></returns>
        public bool LinkagePresetPoint(int intPrestValue)
        {
            return false;
        }
        public void VideoSizeChange(int intPosX, int intPosY, int intWidth, int intHeight)
        {

        }

        public bool VideoPlayEx()
        {
            throw new NotImplementedException();
        }

        #region 音频相关

        private Enum_VideoPlaySoundState soundState = Enum_VideoPlaySoundState.SoundColse;

        /// <summary>
        /// 音频通道状态
        /// </summary>
        public Enum_VideoPlaySoundState SoundState
        {
            get { return soundState; }
            set
            {
                if (soundState != value)
                {
                    soundState = value;
                    SoundStateChanged();
                }
            }
        }

        /// <summary>
        /// 音频通道状态改变事件
        /// </summary>
        public event SoundStateChangedDelegate SoundStateChangedEvent;

        /// <summary>
        /// 音频通道状态改变事件
        /// </summary>
        /// <returns></returns>
        private bool SoundStateChanged()
        {
            bool bolResult = false;
            if (this.SoundStateChangedEvent != null)
            {
                bolResult = SoundStateChangedEvent(this, null);
            }
            return bolResult;
        }

        /// <summary>
        /// 打开音频通道
        /// </summary>
        /// <returns></returns>
        public bool OpenSound()
        {
            return false;
        }

        /// <summary>
        /// 关闭音频通道
        /// </summary>
        /// <returns></returns>
        public bool CloseSound()
        {
            return false;
        }
        #endregion


        /// <summary>
        /// 录像状态改变事件
        /// </summary>
        public event VideoRecordStatusChangedDelegate VideoRecordStausChangedEvent;
        /// <summary>
        /// 录像状态改变事件
        /// </summary>
        /// <param name="VideoRecordStatusChangedValue"></param>
        private void VideoRecordStausChanged(object VideoRecordStatusChangedValue)
        {
            if (VideoRecordStausChangedEvent != null)
            {
                VideoRecordStausChangedEvent(this, VideoRecordStatusChangedValue);
            }
        }

        private bool bolVideoRecordStatus = false;
        /// <summary>
        /// 视频录像状态 true 表示正在录像 false表示未处于录像中
        /// </summary>
        public bool VideoRecordStatus
        {
            get { return bolVideoRecordStatus; }
            private set
            {
                if (bolVideoRecordStatus != value)
                {
                    bolVideoRecordStatus = value;
                    VideoRecordStausChanged(null);
                };
            }
        }

        /// <summary>
        /// 开始录像
        /// </summary>
        /// <param name="vrSet"></param>
        /// <returns></returns>
        public bool StartVideoRecord(VideoRecordSet vrSet)
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
        public bool StopVideoRecord()
        {
            bool bolResult = false;
            VideoClose();
            CurrentVideoPlaySet.VideoRecordEnable = false;
            VideoPlay();
            return bolResult;
        }

        /// <summary>
        /// 抓图
        /// </summary>
        /// <param name="snapSet"></param>
        /// <returns></returns>
        public bool Snap(VideoSnapSet snapSet)
        {
            bool bolResult = false;

            return bolResult;
        }
    }
}
