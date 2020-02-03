using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoBasicClass;
using static VideoPlayControl.SDKInterface.SDK_TLi;

namespace VideoPlayControl.VideoTalk
{
    public class VideoTalk_TLi : IVideoTalk
    {
        SDKInterface.SDK_TLi.DeviceInfo d;
        int m_hPlayPort = 0;
        pDecFrameCallBack frameCallBack;
        public VideoInfo CurrentVideoInfo
        { get; set; }
        public VideoTalkChannelInfo CurrentTalkChannel { get; set; }
        private Enum_TalkStatus currentTalkStatus;
        public Enum_TalkStatus CurrentTalkStatus
        {
            get
            {
                return currentTalkStatus;
            }
            set
            {
                if (currentTalkStatus != value)
                {
                    currentTalkStatus = value;
                    TalkStausChanged(null);
                }
            }
        }

        private TalkSetting currentTalkSetting = new TalkSetting();

        /// <summary>
        /// 时刻设备对讲设置
        /// </summary>
        public TalkSetting CurrentTalkSetting
        {
            get { return currentTalkSetting; }
            set { currentTalkSetting = value; }
        }

        /// <summary>
        /// 时刻视频设备标签
        /// </summary>
        public object Tag { get; set; }

        public event TalkStausChangedDelegate TalkStausChangedEvent;

        public bool TalkStausChanged(object TalkStausChangedValue)
        {
            bool bolResult = false;
            if (TalkStausChangedEvent != null)
            {
                TalkStausChangedEvent(this, TalkStausChangedValue);
            }
            return bolResult;
        }
        public event StartTalkingDelegate StartTalkingEvent;

        public bool StartTalking(object StartTalkingValue)
        {
            bool bolResult = false;
            if (StartTalkingEvent != null)
            {
                StartTalkingEvent(this, StartTalkingValue);
            }
            return bolResult;
        }

        public event StartTalkedDelegate StartTalkedEvent;

        /// <summary>
        /// 结束对讲后事件
        /// </summary>
        public event StopTalkedDelegate StopTalkedEvent;

        /// <summary>
        /// 结束对讲后事件
        /// </summary>
        /// <param name="StopTalkedValue"></param>
        /// <returns></returns>
        public bool StopTalked(object StopTalkedValue)
        {
            bool bolResult = false;
            if (StopTalkedEvent != null)
            {
                StopTalkedEvent(this, StopTalkedValue);
            }
            return bolResult;
        }

        public bool SetVideoTalkInfo(VideoInfo videoInfo, VideoTalkChannelInfo talkChannel)
        {
            bool bolResult = false;
            if (CurrentTalkStatus != Enum_TalkStatus.Null)
            {
                StopTalk();
            }
            CurrentVideoInfo = videoInfo;
            CurrentTalkChannel = talkChannel;
            return bolResult;
        }

        public bool StartTlak(Enum_TalkModel talkModel)
        {
            bool bolResult = false;
            VideoEnvironment.VideoEnvironment_TL.TL_StartTalking(null);
            VideoEnvironment.VideoEnvironment_TL.TL_StartTalkingEvent += VideoEnvironment_TL_TL_StartTalkingEvent;
            if (CurrentTalkStatus != Enum_TalkStatus.Null)  //处于对讲中 先关闭
            {
                StopTalk();
            }
            int Temp_intIndex = SDK_TLi.GetNodeIndexByDeviceID(CurrentVideoInfo.DVSUniqueCode);
            if (Temp_intIndex == -1)
            {
                //刷新设备列表
                VideoEnvironment.VideoEnvironment_TL.RefreshDeviceList();
            }
            Temp_intIndex = SDK_TLi.GetNodeIndexByDeviceID(CurrentVideoInfo.DVSUniqueCode);
            if (Temp_intIndex == -1)
            {
                return false;
            }
            d = VideoEnvironment.VideoEnvironment_TL.devices[Temp_intIndex];
            StartTalking(null);
            SDK_TLi.NETDVR_devicenode_t deviceInfo = new SDKInterface.SDK_TLi.NETDVR_devicenode_t();
            deviceInfo.device_ID = d.devicenode.device_ID;
            deviceInfo.maxSubstreamNum = d.devicenode.maxSubstreamNum;
            SDK_TLi.NETDVR_createDVR_3g(ref d.nHandle, deviceInfo.device_ID, ref deviceInfo);
            SDK_TLi.TLPlay_GetPort(ref m_hPlayPort);
            SDK_TLi.TLPlay_SetPlayMode(m_hPlayPort, SDKInterface.SDK_TLi.TLPLAYMODE.TL_PLAY_POOL_STREAM);
            SDK_TLi.TLPlay_OpenStream(m_hPlayPort, 1 << 20);
            SDK_TLi.TLPlay_Play(m_hPlayPort, IntPtr.Zero);
            frameCallBack = new pDecFrameCallBack(DealVoipAuidoFrame);
            int ret = NETDVR_VOIPRegRcvCB(d.nHandle, 0, frameCallBack, Convert.ToUInt32(m_hPlayPort));
            ret = SDK_TLi.NETDVR_startVOIP(d.nHandle, 0);
            bool bol = SDK_TLi.TLPlay_PlaySound(m_hPlayPort);
            CurrentTalkStatus = (Enum_TalkStatus)(int)talkModel;
            return bolResult;
        }

        /// <summary>
        /// 开始对讲
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public virtual bool StartTalk(TalkSetting ts)
        {
            CurrentTalkSetting = ts;
            return StartTlak(ts.TalkMode);
        }
        private bool VideoEnvironment_TL_TL_StartTalkingEvent(object sender, object StartTalkBeginValue)
        {
            StopTalk();
            return true;
        }

        public void DealVoipAuidoFrame(IntPtr ip, uint dwContextEnc)
        {
            FrameHeadrDec pFrmHdrDec = (FrameHeadrDec)Marshal.PtrToStructure(ip, typeof(FrameHeadrDec));
            if (pFrmHdrDec.data == IntPtr.Zero)
            {
                return;
            }
            PLAYFRAMEHDR hdr = new PLAYFRAMEHDR
            {
                m_byMediaType = pFrmHdrDec.mediaType,
                m_dwDataSize = pFrmHdrDec.data_size,
                m_byFrameRate = 0,
                m_dwFrameID = 0,
                m_dwTimeStamp = pFrmHdrDec.m_dwTimeStamp,
                union1 = new Anonymous_3d5d69df_3122_4137_83f1_a9b198afad7b
                {
                    m_tAudioParam = new Anonymous_0584d86c_3910_4038_bad0_69ed09db9a8d
                    {
                        m_byAudioMode = pFrmHdrDec.audio_mode,
                    }
                }
            };
            int Temp_int = Marshal.SizeOf(hdr);
            byte[] pD = new byte[pFrmHdrDec.data_size];
            Marshal.Copy(pFrmHdrDec.data, pD, 0, (int)pFrmHdrDec.data_size);
            byte[] pl = PubMethod.StructToBytes(hdr);
            byte[] bytes = pl.Concat(pD).ToArray();
            uint len = Convert.ToUInt32(pFrmHdrDec.data_size + 40);
            bool bol = SDK_TLi.TLPlay_InputAudioData(m_hPlayPort, ref bytes[0], len);
        }
        
        /// <summary>
        /// 时刻对讲设备_结束对讲
        /// </summary>
        /// <returns></returns>
        public bool StopTalk()
        {
            bool bolResult = false;
            if (CurrentVideoInfo != null && CurrentTalkStatus != Enum_TalkStatus.Null)
            {
                VideoEnvironment.VideoEnvironment_TL.TL_StartTalkingEvent -= VideoEnvironment_TL_TL_StartTalkingEvent;
                int ret = NETDVR_stopVOIP(d.nHandle, 0);
                TLPlay_Stop(m_hPlayPort);
                TLPlay_Close(m_hPlayPort);
                TLPlay_FreePort(m_hPlayPort);
                CurrentTalkStatus = Enum_TalkStatus.Null;
            }
            return bolResult;
        }

    }
}
