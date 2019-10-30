using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using PublicClassCurrency;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoRecord;
using static VideoPlayControl.SDKInterface.SDK_TLi;

namespace VideoPlayControl.VideoRecordBackplay
{
    class VideoRecordBackplay_TLi : IVideoRecordBackplay
    {
        int m_hPlayPort = 0;

        private float videoRecordPos = 0;
        public float VideoRecordPos
        {
            get { return videoRecordPos; }
            set
            {
                videoRecordPos = value;
                VideoRecodPosChange(videoRecordPos);
            }
        }



        public event VideoRecodPosChangedDelegate VideoRecodPosChangeEvnet;

       
        private bool VideoRecodPosChange(float fltPosValue)
        {
            if (VideoRecodPosChangeEvnet != null)
            {
                VideoRecodPosChangeEvnet(this, fltPosValue);
            }
            return true;
        }

        public bool SetVideoRecordInfo(VideoRecordInfo v)
        {
            VideoRecordInfo = v;
            return true;
        }

        public VideoRecordInfo VideoRecordInfo { get ; set ; }
        public IntPtr intptrPlayWnd { get ; set ; }
        
        public bool PauseVideoRecord()
        {
            SDK_TLi.TLPlay_Pause(m_hPlayPort, true);
            currentPlaybackState = Enum_VideoPlaybackState.Paused;
            return true;
        }

        public bool PlayFast()
        {
            throw new NotImplementedException();
        }

        public bool PlaySlow()
        {
            throw new NotImplementedException();
        }

        public bool OpenVideoRecord()
        {
            bool bolResult = false;
            
            m_hPlayPort = 0;
            if (SDK_TLi.TLPlay_GetPort(ref m_hPlayPort))//获取播放句柄
            {
                SDK_TLi.TLPlay_SetPlayMode(m_hPlayPort, TLPLAYMODE.TL_PLAY_FILE).ToString();//设备播放模式
                SDK_TLi.TLPlay_OpenFile(m_hPlayPort, VideoRecordInfo.RecordPath);//打开码流
            }
            return bolResult;
        }

        public bool PlayVideoRecord()
        {
            CommonMethod.Common.Delay_Millisecond(300);
            if (currentPlaybackState == Enum_VideoPlaybackState.Paused)
            {
                SDK_TLi.TLPlay_Pause(m_hPlayPort, false);
            }
            else
            {
                SDK_TLi.TLPlay_Play(m_hPlayPort, intptrPlayWnd);
            }
            currentPlaybackState = Enum_VideoPlaybackState.Playing;
            StartGetVideoRecordPost();
            return true;
        }

        public bool SetVideoRecordPos(float fltPosValue)
        {
            return TLPlay_SetPlayPos(m_hPlayPort, fltPosValue);
        }

        public bool CloseVideoRecord()
        {
            if (TLPlay_Close(m_hPlayPort))
            {
                m_hPlayPort = 0;
            }
            currentPlaybackState = Enum_VideoPlaybackState.Stopped;
            return true;
        }
        #region 全局变量
        private Enum_VideoPlaybackState currentPlaybackState = Enum_VideoPlaybackState.Null;

        private const int intValue = 30;
        #endregion

        #region 事件注册

        /// <summary>
        /// 文件播放完毕回调
        /// </summary>
        /// <param name="lPlayHand"></param>
        /// <param name="nUser"></param>
        void FileEndCallBack(uint lPlayHand, uint nUser)
        {
            if (TLPlay_Close(m_hPlayPort))
            {
                m_hPlayPort = 0;
            }
        }


        #endregion

        #region 控件独立事件

        Thread thrGetPosValue;
        /// <summary>
        /// 实时获取当前视频信息位置
        /// </summary>
        public void StartGetVideoRecordPost()
        {
            if (thrGetPosValue == null||!thrGetPosValue.IsAlive)
            {
                thrGetPosValue = new Thread(thrGetVideoRecordPos);
                thrGetPosValue.IsBackground = true;
                thrGetPosValue.Start();
            }
        }
        public void thrGetVideoRecordPos()
        {
            while (currentPlaybackState == Enum_VideoPlaybackState.Playing)
            {
                float pos = SDK_TLi.TLPlay_GetPlayPos(m_hPlayPort);
                if (pos > 1)
                {
                    continue;
                }
                //Console.WriteLine("TIME:" + DateTime.Now + "_" + pos.ToString());
                VideoRecordPos = pos;
                if (VideoRecordPos == 1)
                {
                    CloseVideoRecord();
                    OpenVideoRecord();
                    VideoRecordPos = 0;
                }
                
                Thread.Sleep(intValue);
            }
        }

        #endregion 
    }
}
