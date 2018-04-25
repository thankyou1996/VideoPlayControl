using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using PublicClassCurrency;

namespace VideoPlayControl.VideoRecordBackplay
{
    class VideoRecordBackplay_BlueSky : IVideoRecordBackplay
    {
        IntPtr Handle = IntPtr.Zero;
        public VideoRecordBackplay_BlueSky(IntPtr intPtr)
        {
            Handle = intPtr;
        }
        /// <summary>
        /// 是否播放
        /// </summary>
        bool m_bPlay = false;

        /// <summary>
        /// 是否暂停
        /// </summary>
        bool m_bPaused = false;

        IntPtr LocalPlayHandle = IntPtr.Zero;

        int nRet = -1;
        /// <summary>
        /// 录像开始时间
        /// </summary>
        Int64 m_nStartTime = 0;

        /// <summary>
        /// 录像结束时间
        /// </summary>
        Int64 m_nEndTime = 0;

        private Enum_VideoPlaybackState currentPlaybackState = Enum_VideoPlaybackState.Null;

        public VideoRecordInfo VideoRecordInfo { get; set; }
        public IntPtr intptrPlayWnd { get; set; }

        public event VideoRecodPosChangedDelegate VideoRecodPosChangeEvnet;
        private bool VideoRecodPosChange(float fltPosValue)
        {
            if (VideoRecodPosChangeEvnet != null)
            {
                VideoRecodPosChangeEvnet(this, fltPosValue);
            }
            return true;
        }
        public bool CloseVideoRecord()
        {
            bool bolResult = false;
            //关闭
            if (/*(m_bPlay || m_bPaused) && */LocalPlayHandle != IntPtr.Zero)
            {
                SDK_BlueSDK.dvxLocalPlayStop(LocalPlayHandle);
                SDK_BlueSDK.dvxLocalPlayClose(ref LocalPlayHandle);
                LocalPlayHandle = IntPtr.Zero;
                bolResult = true;
                m_bPlay = false;
                m_bPaused = false;
                currentPlaybackState = Enum_VideoPlaybackState.Stopped;
                VideoRecodPosChange(0);
            }
            return bolResult;
        }

        public bool OpenVideoRecord()
        {
            bool bolResult = false;

            //正在播放。先停止
            if (m_bPlay && LocalPlayHandle != IntPtr.Zero)
            {
                SDK_BlueSDK.dvxLocalPlayStop(LocalPlayHandle);
                SDK_BlueSDK.dvxLocalPlayClose(ref LocalPlayHandle);
                LocalPlayHandle = IntPtr.Zero;
                m_bPlay = false;
            }
            nRet = SDK_BlueSDK.dvxLocalPlayOpen(VideoRecordInfo.RecordPath, intptrPlayWnd, Handle, 1280, ref LocalPlayHandle);
            if (nRet != (int)dvxSdkType.ReturnError.DVX_OK)
            {
                //MessageBox.Show("打开文件失败");
                bolResult = false;
                LocalPlayHandle = IntPtr.Zero;
            }
            else
            {
                bolResult = true;
            }
            return bolResult;
            //throw new NotImplementedException();
        }

        public bool PauseVideoRecord()
        {
            bool bolResult = false;
            //暂停
            if (LocalPlayHandle == IntPtr.Zero)
            {
                bolResult = true;
            }
            else
            {
                SDK_BlueSDK.dvxLocalPlayPause(LocalPlayHandle);
                m_bPaused = true;
                bolResult = true;
                m_bPlay = false;
                currentPlaybackState = Enum_VideoPlaybackState.Paused;
            }
            return bolResult;
        }

        public bool PlayFast()
        {
            throw new NotImplementedException();
        }

        public bool PlaySlow()
        {
            throw new NotImplementedException();
        }

        public bool PlayVideoRecord()
        {
            bool bolResult = false;

            if (m_bPaused && LocalPlayHandle != IntPtr.Zero)
            {
                currentPlaybackState = Enum_VideoPlaybackState.Playing;
                SDK_BlueSDK.dvxLocalPlayPlay(LocalPlayHandle);
                bolResult = true;
                m_bPlay = true;
                m_bPaused = false;
            }
            else
            {

                //播放
                //正在播放。先停止
                //if (m_bPlay && LocalPlayHandle != IntPtr.Zero)
                //{
                //    SDK_BlueSDK.dvxLocalPlayStop(LocalPlayHandle);
                //    SDK_BlueSDK.dvxLocalPlayClose(ref LocalPlayHandle);
                //    LocalPlayHandle = IntPtr.Zero;
                //    m_bPlay = false;
                //}

                //nRet = SDK_BlueSDK.dvxLocalPlayOpen(VideoRecordInfo.RecordPath, intptrPlayWnd, Handle, 1280, ref LocalPlayHandle);
                //if (nRet != (int)dvxSdkType.ReturnError.DVX_OK)
                //{
                //    //MessageBox.Show("打开文件失败");
                //    bolResult = false;
                //}
                //else
                //{
                if (LocalPlayHandle != IntPtr.Zero && m_bPlay == false)
                {
                    if (m_nStartTime != 0)
                    {
                        SDK_BlueSDK.dvxLocalPlaySeek(LocalPlayHandle, m_nStartTime);

                    }
                    nRet = SDK_BlueSDK.dvxLocalPlaySetPlayMode(LocalPlayHandle, 0);
                    nRet = SDK_BlueSDK.dvxLocalPlayPlay(LocalPlayHandle);
                    if (nRet != (int)dvxSdkType.ReturnError.DVX_OK)
                    {
                        //MessageBox.Show("文件播放失败");
                        bolResult = false;
                    }
                    else
                    {
                        nRet = SDK_BlueSDK.dvxPlaySound(LocalPlayHandle);
                        SDK_BlueSDK.dvxLocalPlayGetTime(LocalPlayHandle, ref m_nStartTime, ref m_nEndTime);

                        if (m_nEndTime - m_nStartTime <= 0)
                        {
                            //MessageBox.Show("BSR文件的时间不对");
                            bolResult = false;
                        }
                        else
                        {
                            //OJBK
                            m_bPlay = true;
                            bolResult = true;
                            currentPlaybackState = Enum_VideoPlaybackState.Playing;
                            StartGetVideoRecordPost();
                        }

                    }
                    //}
                }
            }

            return bolResult;
        }

        public bool SetVideoRecordInfo(VideoRecordInfo v)
        {
            VideoRecordInfo = v;
            return true;
        }

        public bool SetVideoRecordPos(float fltPosValue)
        {
            currentPlaybackState = Enum_VideoPlaybackState.Stopped;
            bool bolResult = false;
            //设置播放位置
            if ((m_bPlay || m_bPaused) && LocalPlayHandle != IntPtr.Zero)
            {
                float fltPos = fltPosValue;
                //m_nEndTime

                Int64 pos = (Int64)(fltPos * ((m_nEndTime - m_nStartTime) / 1000));
                pos = pos + (m_nStartTime / 1000);
                SDK_BlueSDK.dvxLocalPlaySeek(LocalPlayHandle, pos * 1000);
                bolResult = true;
            }
            currentPlaybackState = Enum_VideoPlaybackState.Playing;
            return bolResult;
        }



        Thread thrGetPosValue;
        /// <summary>
        /// 实时获取当前视频信息位置
        /// </summary>
        public void StartGetVideoRecordPost()
        {
            if (thrGetPosValue == null || !thrGetPosValue.IsAlive)
            {
                thrGetPosValue = new Thread(thrGetVideoRecordPos);
                thrGetPosValue.IsBackground = true;
                thrGetPosValue.Start();
            }
        }
        public void thrGetVideoRecordPos()
        {
            while (currentPlaybackState != Enum_VideoPlaybackState.Stopped)
            {
                if (currentPlaybackState == Enum_VideoPlaybackState.Playing)
                {
                    if (LocalPlayHandle != IntPtr.Zero && m_bPlay)
                    {
                        Int64 pos = 0;
                        if (SDK_BlueSDK.dvxPlayGetPos(LocalPlayHandle, ref pos) == ((int)dvxSdkType.ReturnError.DVX_OK))
                        {
                            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
                            Int64 intTime = (m_nEndTime - m_nStartTime) / 1000;

                            pos /= 1000;
                            pos = pos - (m_nStartTime / 1000);

                            float dpos = (float)pos / (float)intTime;

                            //Thread.Sleep(500);
                            Console.WriteLine(dpos);
                            if (dpos > -1)
                            {
                                VideoRecodPosChange(dpos);
                            }
                            if (dpos == 1)
                            {
                                currentPlaybackState = Enum_VideoPlaybackState.Stopped;

                                SDK_BlueSDK.dvxLocalPlayStop(LocalPlayHandle);
                                m_bPlay = false;
                                //SDK_BlueSDK.dvxLocalPlayClose(ref LocalPlayHandle);
                            }
                        }
                    }
                }

                Thread.Sleep(100);
            }
        }
    }
}
