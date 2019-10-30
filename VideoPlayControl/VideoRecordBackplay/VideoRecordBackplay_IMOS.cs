using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PublicClassCurrency;
using VideoPlayControl.VideoRecord;

namespace VideoPlayControl.VideoRecordBackplay
{
    public class VideoRecordBackplay_IMOS : IVideoRecordBackplay
    {
        public VideoRecordInfo VideoRecordInfo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IntPtr intptrPlayWnd { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float VideoRecordPos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event VideoRecodPosChangedDelegate VideoRecodPosChangeEvnet;

        public bool CloseVideoRecord()
        {
            throw new NotImplementedException();
        }

        public bool OpenVideoRecord()
        {
            throw new NotImplementedException();
        }

        public bool PauseVideoRecord()
        {
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
            throw new NotImplementedException();
        }

        public bool SetVideoRecordInfo(VideoRecordInfo v)
        {
            throw new NotImplementedException();
        }

        public bool SetVideoRecordPos(float fltPosValue)
        {
            throw new NotImplementedException();
        }
    }
}
