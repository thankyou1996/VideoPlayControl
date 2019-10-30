using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using PublicClassCurrency;
using VideoPlayControl.VideoRecord;

namespace VideoPlayControl.VideoRecordBackplay
{
    class VideoRecordBackplay_AXIS : IVideoRecordBackplay
    {
      
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
        public float VideoRecordPos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool PauseVideoRecord()
        {
            SDK_XMSDK.H264_DVR_LocalPlayCtrl(m_nLocalplayHandle, SDK_LoalPlayAction.SDK_Local_PLAY_PAUSE, 0);
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
            m_nLocalplayHandle = SDK_XMSDK.H264_DVR_StartLocalPlay(VideoRecordInfo.RecordPath, intptrPlayWnd, null, Convert.ToUInt32(0));
            //SDK_XMSDK.fLocalPlayFileCallBack fileEndCallBack = new SDK_XMSDK.fLocalPlayFileCallBack(FileEndCallBack);
            //bolResult = SDK_XMSDK.H264_DVR_SetFileEndCallBack(m_nLocalplayHandle, fileEndCallBack, IntPtr.Zero);
            SDK_XMSDK.H264_DVR_LocalPlayCtrl(m_nLocalplayHandle, SDK_LoalPlayAction.SDK_Local_PLAY_PAUSE, 0);//暂停
            return bolResult;
        }

        public bool PlayVideoRecord()
        {
            Thread.Sleep(300);
            SDK_XMSDK.H264_DVR_LocalPlayCtrl(m_nLocalplayHandle, SDK_LoalPlayAction.SDK_Local_PLAY_CONTINUE, 0);
            currentPlaybackState = Enum_VideoPlaybackState.Playing;
            StartGetVideoRecordPost();
            return true;
        }

        public bool SetVideoRecordPos(float fltPosValue)
        {
            throw new NotImplementedException();
        }

        public bool CloseVideoRecord()
        {

            if (SDK_XMSDK.H264_DVR_StopLocalPlay(m_nLocalplayHandle))
            {
                m_nLocalplayHandle = 0;
            }
            currentPlaybackState = Enum_VideoPlaybackState.Stopped;
            return true;
        }
        #region 全局变量
        int m_nLocalplayHandle = -1;
        int m_nFastTypeLocal = 0; //本地快播速度
        int m_nSlowTypeLocal = 0;  // 本地慢播速度
        private Enum_VideoPlaybackState currentPlaybackState = Enum_VideoPlaybackState.Null;

        private const int intValue = 30;

        private float Temp_intPos;
        private int Temp_intEndCount;
        private const int Temp_EndMxCount=20;
        #endregion

        #region 事件注册

        /// <summary>
        /// 文件播放完毕回调
        /// </summary>
        /// <param name="lPlayHand"></param>
        /// <param name="nUser"></param>
        void FileEndCallBack(uint lPlayHand, uint nUser)
        {
            if (SDK_XMSDK.H264_DVR_StopLocalPlay(m_nLocalplayHandle))
            {
                m_nLocalplayHandle = 0;
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
                float pos = SDK_XMSDK.H264_DVR_GetPlayPos(m_nLocalplayHandle);
                if (pos > 1)
                {
                    continue;
                }
                Console.WriteLine("TIME:" + DateTime.Now + "_" + pos.ToString());
                VideoRecodPosChange(pos);
                //结束判断
                if (Temp_intPos == pos)
                {
                    Temp_intEndCount++;
                }
                else
                {
                    Temp_intPos = pos; 
                    Temp_intEndCount = 0;
                }
                if (Temp_intEndCount > Temp_EndMxCount)
                {
                    SDK_XMSDK.H264_DVR_StopLocalPlay(m_nLocalplayHandle);
                    currentPlaybackState = Enum_VideoPlaybackState.Stopped;
                    pos = 1;
                    Console.WriteLine("TIME:" + DateTime.Now + "_" + pos.ToString());
                    VideoRecodPosChange(pos);
                    Console.WriteLine("TIME:" + DateTime.Now + "_End");
                }
                
                Thread.Sleep(intValue);
            }
        }

        #endregion 
    }
}
