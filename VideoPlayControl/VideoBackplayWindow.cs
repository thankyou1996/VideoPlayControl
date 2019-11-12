using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;
using System.Threading;
using System.Runtime.InteropServices;
using VideoPlayControl.VideoPlayback;
using AxisMediaViewerLib;
using AxisMediaParserLib;
using System.Threading.Tasks;
using VideoPlayControl.VideoRecord;

namespace VideoPlayControl
{
    public partial class VideoBackplayWindow : UserControl
    {

        #region 全局变量

        /// <summary>
        /// 当前回放状态
        /// </summary>
        private Enum_VideoPlaybackState currentPlaybackState=Enum_VideoPlaybackState.Null;

        /// <summary>
        /// 当前回放状态
        /// </summary>
        public Enum_VideoPlaybackState CurrentPlaybackState
        {
            get { return currentPlaybackState; }
            set
            {
                if (currentPlaybackState != value)
                {
                    currentPlaybackState = value;
                    PlayStateChanged();
                }
                
            }
        }

        /// <summary>
        /// 当前播放进度
        /// </summary>
        private int intVideoProgress = 0;
        /// <summary>
        /// 当前播放进度
        /// </summary>
        public int VideoProgresss
        {
            get { return intVideoProgress; }
            set
            {
                if (intVideoProgress != value)
                {
                    intVideoProgress = value;
                    PlayProgressChanged();
                }
                
            }
        }

        /// <summary>
        /// 视频最大比例
        /// </summary>
        public readonly int  MaxScale = 1000;

        /// <summary>
        /// 视频最大比例
        /// </summary>
        public readonly int MinScale = 0;

        #endregion

        #region 事件委托

        #region 播放状态改变事件
        public delegate void PlayStateChangedDelegate(object sneder, object objPlaybackStateChangedValue);

        public event PlayStateChangedDelegate PlayStateChangedEvent;

        private void PlayStateChanged()
        {
            if (PlayStateChangedEvent != null)
            {
                PlayStateChangedEvent(this, null);
            }
        }
        #endregion

        #region 播放进度改变事件
        public delegate void PlayProgressChangedDelegate(object sender, object objPlayProgressChangedValue);
        public event PlayProgressChangedDelegate PlayProgressChangedEvent;
        
        private void PlayProgressChanged()
        {
            if (PlayProgressChangedEvent != null)
            {
                PlayProgressChangedEvent(this, null);
            }
        }

        #endregion
        #endregion

        public VideoRecordInfo CurrentVideoRecordInfo;
        public VideoBackplayWindow()
        {
            InitializeComponent();
        }

        private void VideoBackplayWindow_Load(object sender, EventArgs e)
        {

        }

        #region 设置基本信息

        public bool Init_SetVideoRecord(VideoRecordInfo v)
        {
            if (v.VideoType == Enum_VideoType.Unrecognized)
            {
                return false;
            }
            if (CurrentPlaybackState == Enum_VideoPlaybackState.Playing)
            {
                StopVideoRecord();
            }
            CurrentVideoRecordInfo = v;
            CurrentPlaybackState = Enum_VideoPlaybackState.Stopped;
            return true;
        }

        #endregion

        #region 安讯士 Axis
        private delegate void EndOfStreamDelegate();
        private VideoBackPlay_AmpFileParser fileParser;
        private AxisMediaViewer viewer;
        private decimal playbackRate = 1;
        private long lastCurrentPosition = -1;
        private readonly DateTime NtpTimeEpoch = new DateTime(1900, 1, 1);
        DateTime absoluteTime;
        private Thread renderThread;
        private bool doExitRenderThread = false;
        private object seekingLock = new object();

        private bool Axis_PlayVideoRecord()
        {
            if (CurrentPlaybackState == Enum_VideoPlaybackState.Playing)
            {
                return false;
            }
            if (fileParser == null)
            {
                fileParser = new VideoBackPlay_AmpFileParser(CurrentVideoRecordInfo.RecordPath);
                CreateView(picPlaybackMain.Handle);
                int Temp_intValue = (fileParser.IsVideo ? 1 : 0) + (fileParser.IsAudio ? 2 : 0);
                CurrentVideoRecordInfo.VideoRecordFileType = (Enum_VideoRecordFileType)Temp_intValue;
                viewer.SetVideoPosition(0, 0, picPlaybackMain.Width, picPlaybackMain.Height);
            }
            viewer.Start();
            StartRenderThread();
            if (viewer.PlaybackRate != (double)playbackRate)
            {
                Seek(lastCurrentPosition, (double)playbackRate, true);
            }
            CurrentPlaybackState = Enum_VideoPlaybackState.Playing;
            //SetState(State.Playing);
            return true;
        }

        private bool CreateView(IntPtr iWindowHandle)
        {
            Task.Factory.StartNew(() =>
            {
                viewer = new AxisMediaViewer();

                // Set some media properties
                viewer.VideoRenderer = (int)AMV_RENDER_OPTIONS.AMV_VIDEO_RENDERER_EVR;
                viewer.ColorSpace = (short)AMV_COLOR_SPACE.AMV_CS_RGB32;
                viewer.PlaybackRate = (double)playbackRate;
                viewer.PlayOptions = GetPlayOptions();
                viewer.LiveMode = false;

                viewer.OnMediaPosition += new IAxisMediaViewerEvents_OnMediaPositionEventHandler(OnMediaPosition);

                // Init the Viewer with media type buffer and a win32 hWnd handle to the window. 
                viewer.Init(0, fileParser.MediaTypeBuffer, iWindowHandle.ToInt64());
            }).Wait();
            return true;
        }
        private int GetPlayOptions()
        {
            int playOptions = 0;

            if ((CurrentVideoRecordInfo.VideoRecordFileType | Enum_VideoRecordFileType.Video) > 0)
            {
                playOptions |= (int)AMV_PLAY_OPTIONS.AMV_PO_VIDEO;
            }
            else if ((CurrentVideoRecordInfo.VideoRecordFileType | Enum_VideoRecordFileType.Audio) > 0)
            {
                playOptions |= (int)AMV_PLAY_OPTIONS.AMV_PO_AUDIO;
            }
            return playOptions;
        }

        /// <summary>
        /// 媒体位置改变
        /// </summary>
        /// <param name="currentPosition"></param>
        void OnMediaPosition(long currentPosition)
        {
            if (InvokeRequired)
            {
                // If called from a non UI thread, let the UI thread perform the call 
                BeginInvoke(new IAxisMediaViewerEvents_OnMediaPositionEventHandler(OnMediaPosition),
                    new object[] { currentPosition });
                return;
            }

            lastCurrentPosition = currentPosition;

            // If current position represent absolute time we present the current date and time in the GUI
            absoluteTime = new DateTime(currentPosition + NtpTimeEpoch.Ticks);

            long relativePosition = currentPosition - fileParser.StartTime;
            if (relativePosition < 0)
            {
                relativePosition = 0;
            }
            else if (relativePosition > fileParser.Duration)
            {
                relativePosition = fileParser.Duration;
            }

            // Update progress bar
            if (fileParser.Duration > 0)
            {

                VideoProgresss = (int)(((relativePosition * MaxScale) / fileParser.Duration));
            }
            else
            {
                VideoProgresss = 0;
            }

            // Update time text box
            TimeSpan currentTime = new TimeSpan(relativePosition); // ms -> 100-nanosecond
            TimeSpan currentDuration = new TimeSpan(fileParser.Duration); // ms -> 100-nanosecond

            string timeFormat = (currentTime.Days > 0 || currentDuration.Days > 0) ?
                "({6}) {0:D2}:{1:D2}:{2:D2} / ({7}) {3:D2}:{4:D2}:{5:D2}" :
                "{0:D2}:{1:D2}:{2:D2}:{8:D3} / {3:D2}:{4:D2}:{5:D2}:{9:D3}";

        }

        private void StartRenderThread()
        {
            if (renderThread == null)
            {
                // Create the render thread that will read file and render frames
                renderThread = new Thread(new ThreadStart(RenderThread));
                renderThread.Start();
            }
        }
        private void RenderThread()
        {
            try
            {
                // While there are frames in the in file, read each frame and let the viewer render it
                while (!doExitRenderThread)
                {
                    AmpFileSample sample = null;

                    lock (seekingLock)
                    {
                        sample = fileParser.ReadSample();
                    }

                    if (sample == null)
                    {
                        // end-of-file reached - wait for all samples to render before stopping viewer
                        if (viewer.Flush())
                        {
                            BeginInvoke(new EndOfStreamDelegate(OnEndOfStream));
                            break;
                        }
                    }
                    else
                    {
                        switch (sample.SampleType)
                        {
                            case (int)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_MPEG4_VIDEO_CONFIG:
                            case (int)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_MPEG4_VIDEO_IVOP:
                            case (int)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_MPEG4_VIDEO_PVOP:
                            case (int)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_MPEG4_VIDEO_BVOP:
                            case (int)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_MPEG4_VIDEO_FRAGMENT:
                            case (int)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_MJPEG_VIDEO:
                            case (int)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_H264_VIDEO_CONFIG:
                            case (int)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_H264_VIDEO_IDR:
                            case (int)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_H264_VIDEO_NON_IDR:
                            case (int)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_H264_VIDEO_SEI:
                                if ((viewer.PlayOptions & (int)AMV_PLAY_OPTIONS.AMV_PO_VIDEO) > 0)
                                {
                                    if (playbackRate >= 32 && ((int)AMP_SAMPLE.AMP_S_SYNCPOINT & sample.SampleFlags) == 0)
                                    {
                                        // skip non-sync point video if playback rate is x32 or higher
                                        continue;
                                    }

                                    viewer.RenderVideoSample(sample.SampleFlags, sample.StartTime,
                                        sample.StopTime, sample.Buffer);
                                }
                                break;
                            case (int)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_MPEG4_AUDIO:
                                if ((viewer.PlayOptions & (int)AMV_PLAY_OPTIONS.AMV_PO_AUDIO) > 0)
                                {
                                    viewer.RenderAudioSample(sample.SampleFlags, sample.StartTime,
                                        sample.StopTime, sample.Buffer);
                                }
                                break;
                            case (int)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_METADATA_ONVIF:
                                if ((viewer.PlayOptions & (int)AMV_PLAY_OPTIONS.AMV_PO_META) > 0)
                                {
                                    string metadataDoc = System.Text.Encoding.UTF8.GetString(sample.Buffer);
                                    viewer.RenderMetadataSample(sample.SampleFlags, sample.StartTime,
                                        sample.StopTime, metadataDoc);
                                }
                                break;
                            default:
                                throw new Exception("Unknown sample type");
                        }
                    }
                }
            }
            catch (COMException e)
            {
                MessageBox.Show(string.Format("Exception for {0}, {1}", CurrentVideoRecordInfo.RecordPath, e.Message));
            }
        }


        private void Seek(long mediaPosition, double playbackRate, bool seekToSyncPoint)
        {
            viewer.Stop();
            lock (seekingLock)
            {
                // Seek to the closest video sync point in the file.
                fileParser.Seek(ref mediaPosition);

                if (!seekToSyncPoint)
                {
                    // make viewer preroll all samples before this position
                    viewer.SetStartTime((long)mediaPosition);
                }

                if (playbackRate != viewer.PlaybackRate)
                {
                    viewer.PlaybackRate = playbackRate;
                }

                if (CurrentPlaybackState == Enum_VideoPlaybackState.Paused)
                {
                    viewer.Pause();
                }
                else
                {
                    viewer.Start();
                }
            }
        }

        public bool Axis_StopVideoRecoerd()
        {
            if (viewer != null)
            {
                viewer.Stop();
                StopRenderThread();
                long position = 0;
                fileParser.Seek(ref position);
                viewer.OnMediaPosition -=
                    new IAxisMediaViewerEvents_OnMediaPositionEventHandler(OnMediaPosition);
                Marshal.FinalReleaseComObject(viewer);
                viewer = null;
                fileParser.Close();
                fileParser = null;
            }
            CurrentPlaybackState = Enum_VideoPlaybackState.Stopped;

            return true;
        }

        private void StopRenderThread()
        {
            if (renderThread != null)
            {
                doExitRenderThread = true;
                renderThread.Join();
                doExitRenderThread = false;
                renderThread = null;
            }
        }

        private void OnEndOfStream()
        {
            if (CurrentPlaybackState != Enum_VideoPlaybackState.Stopped)
            {
                VideoProgresss = 0;
                Axis_StopVideoRecoerd();
            }
        }


        public bool Axis_PauseVideoRecord()
        {
            if (CurrentPlaybackState == Enum_VideoPlaybackState.Paused)
            {
                Seek(lastCurrentPosition - 1, (double)playbackRate, false);
            }
            else
            {
                StartRenderThread();
                viewer.Pause();
                CurrentPlaybackState = Enum_VideoPlaybackState.Paused;
            }

            return true;
        }

        #endregion

        #region  雄迈 XMVideoSDK

        #region 全局变量
        int m_nLocalplayHandle = -1;
        int m_nFastTypeLocal = 0; //本地快播速度
        int m_nSlowTypeLocal = 0;  // 本地慢播速度
        #endregion
        private bool XMVideo_PlayVideoRecord()
        {
            SDK_XMSDK.H264_DVR_StartLocalPlay(CurrentVideoRecordInfo.RecordPath, picPlaybackMain.Handle, null, Convert.ToUInt32(0));
            SDK_XMSDK.fLocalPlayFileCallBack fileEndCallBack = new SDK_XMSDK.fLocalPlayFileCallBack(FileEndCallBack);
            SDK_XMSDK.H264_DVR_SetFileEndCallBack(m_nLocalplayHandle, fileEndCallBack, this.Handle);
            return true;
        }

        private bool XMVideo_StopVideoRecord()
        {
            SDK_XMSDK.H264_DVR_StopLocalPlay(m_nLocalplayHandle);
            return true;
        }

        private bool XMVideo_PauseVideoRecord()
        {
            SDK_XMSDK.H264_DVR_LocalPlayCtrl(m_nLocalplayHandle, SDK_LoalPlayAction.SDK_Local_PLAY_PAUSE, 0);
            return true;
        }


        private bool XMVideo_SetVideoRecordPos(float fltPoValue)
        {
            SDK_XMSDK.H264_DVR_SetPlayPos(m_nLocalplayHandle, fltPoValue);
            return true;
        }
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
            //timerLocalPlayBack.Enabled = false;
            //trackBarLocalPlayPos.Value = 0;
        }
        #endregion


        #endregion
        #region 基本事件

        /// <summary>
        /// 播放
        /// </summary>
        /// <returns></returns>
        public bool PlayVideoRecord()
        {
            switch (CurrentVideoRecordInfo.VideoType )
            {
                case Enum_VideoType.Axis:
                    Axis_PlayVideoRecord();
                    break;
                case Enum_VideoType.XMaiVideo:
                    XMVideo_PlayVideoRecord();
                    break;

            }
            return true;
        }

        /// <summary>
        /// 停止
        /// </summary>
        /// <returns></returns>
        public bool StopVideoRecord()
        {
            if (CurrentVideoRecordInfo != null)
            {
                switch (CurrentVideoRecordInfo.VideoType)
                {
                    case Enum_VideoType.Axis:
                        Axis_StopVideoRecoerd();
                        break;
                    case Enum_VideoType.XMaiVideo:
                        XMVideo_StopVideoRecord();
                        break;
                }
            }
            return true;
        }

        /// <summary>
        /// 暂停
        /// </summary>
        /// <returns></returns>
        public bool PauseVideoRecord()
        {
            switch (CurrentVideoRecordInfo.VideoType)
            {
                case Enum_VideoType.Axis:
                    return Axis_PauseVideoRecord();
                    break;
                case Enum_VideoType.XMaiVideo:
                    
                    break;
            }
            return false;
        }

        public bool SetVideoRecordPos(float fltPosValue)
        {
            //cas
            return false;
        }
        #region 事件注册


        #endregion 
        
        #endregion

        private void picPlaybackMain_SizeChanged(object sender, EventArgs e)
        {
            if (viewer != null)
            {
                viewer.SetVideoPosition(0, 0, picPlaybackMain.Width, picPlaybackMain.Height);
            }
        }
    }
}
