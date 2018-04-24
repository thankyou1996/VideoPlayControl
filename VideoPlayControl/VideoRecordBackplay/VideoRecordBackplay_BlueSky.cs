using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            //关闭
            throw new NotImplementedException();
        }

        public bool OpenVideoRecord()
        {
            throw new NotImplementedException();
        }

        public bool PauseVideoRecord()
        {
            //暂停
            throw new NotImplementedException();
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
            //播放
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
                return false;
            }

            nRet = SDK_BlueSDK.dvxLocalPlaySetPlayMode(LocalPlayHandle, 0);
            nRet = SDK_BlueSDK.dvxLocalPlayPlay(LocalPlayHandle);
            if (nRet != (int)dvxSdkType.ReturnError.DVX_OK)
            {
                //MessageBox.Show("文件播放失败");
                return false;
            }
            nRet = SDK_BlueSDK.dvxPlaySound(LocalPlayHandle);
            SDK_BlueSDK.dvxLocalPlayGetTime(LocalPlayHandle, ref m_nStartTime, ref m_nEndTime);

            if (m_nEndTime - m_nStartTime <= 0)
            {
                //MessageBox.Show("BSR文件的时间不对");
                return false;
            }
            //OJBK
            m_bPlay = true;
            return true;
        }

        public bool SetVideoRecordInfo(VideoRecordInfo v)
        {
            VideoRecordInfo = v;
            return true;
        }

        public bool SetVideoRecordPos(float fltPosValue)
        {
            throw new NotImplementedException();
        }
    }
}
