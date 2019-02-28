using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxisMediaParserLib;
using AxisMediaViewerLib;
using PublicClassCurrency;
using VideoPlayControl.Enum;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    /// <summary>
    /// 安迅士视频播放对象
    /// </summary>
    public class VideoPlay_AXIS : IVideoPlay
    {
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
        public int VideoplayWindowWidth { get ; set; }
        public int VideoplayWindowHeight { get; set; }

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
        List<byte> lstVideoRecord = new List<byte>();
        private object objVideoRecordLock = new object();

        public bool VideoClose()
        {
            bool bolResult = false;
            Axis_VideoColse();
            return bolResult;
        }

        public bool VideoPlay()
        {
            bool bolResult = false;
            Axis_VideoPlay();
            return bolResult;
        }
        public void VideoSizeChange(int intLeft, int intRight, int intTop, int intBottom)
        {
            viewer.SetVideoPosition(intLeft, intTop, intRight, intBottom);
        }

        #region Axis 安迅士

        private AxisMediaParser parser;
        private AxisMediaViewer viewer;

        #region 基本事件
        private void Axis_VideoPlay()
        {
            Task.Factory.StartNew(() =>
            {
                // Create AXIS Media Parser and AXIS Media Viewer components
                parser = new AxisMediaParser();
                viewer = new AxisMediaViewer();
            }).Wait();

            //事件注册
            parser.OnVideoSample += OnVideoSample;
            parser.OnAudioSample += OnAudioSample;
            parser.OnMetaDataSample += OnMetaDataSample;
            parser.OnError += OnError;

            //流媒体参数
            parser.ShowLoginDialog = true;
            StringBuilder sbUrl = new StringBuilder();
            sbUrl.Append("axrtsphttp://");
            sbUrl.Append(CurrentVideoInfo.DVSAddress);
            sbUrl.Append("/axis-media/media.amp?videocodec=JPEG");
            sbUrl.Append("&camera=" + CurrentCameraInfo.Channel);
            string strUrl = sbUrl.ToString();
            parser.MediaURL = strUrl;
            parser.MediaUsername = CurrentVideoInfo.UserName;
            parser.MediaPassword = CurrentVideoInfo.Password;

            //设置页面参数
            viewer.VideoRenderer = (int)AMV_RENDER_OPTIONS.AMV_VIDEO_RENDERER_EVR;      //视频解码器，注意回放视频是要同一
            //图片回调
            //viewer.EnableOnDecodedImage = true;
            //viewer.OnDecodedImage += OnDecodedImage;
            //viewer.ColorSpace = (short)AMV_COLOR_SPACE.AMV_CS_RGB24;
            viewer.EnableOnDecodedImage = false;
            viewer.ColorSpace = (short)AMV_COLOR_SPACE.AMV_CS_YUY2;
            viewer.LiveMode = true;     //实时模式

            int cookieID;
            int numberOfStreams;
            object objmediaTypeBuffer;
            parser.Connect(out cookieID, out numberOfStreams, out objmediaTypeBuffer); //连接
            viewer.Init(0, objmediaTypeBuffer, intptrPlayMain.ToInt64());               //初始化
            viewer.SetVideoPosition(0, 0, VideoplayWindowWidth, VideoplayWindowHeight);
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                lstVideoRecord = new List<byte>();
                byte[] bytsMediaType = (byte[])objmediaTypeBuffer;
                lstVideoRecord.AddRange(BitConverter.GetBytes(bytsMediaType.Length));
                lstVideoRecord.AddRange(bytsMediaType);
            }
            viewer.Start();
            parser.Start();
            VideoPlayState = Enum_VideoPlayState.Connecting;
        }

        private void Axis_VideoColse()
        {
            if (parser != null)
            {
                if (parser.Status == (int)AMP_STATUS.AMP_STATUS_RUNNING)
                {
                    parser.Stop();
                    viewer.Stop();
                }
                if (CurrentVideoPlaySet.VideoRecordEnable && lstVideoRecord.Count > 0)
                {
                    Axis_GenerateRecord(CurrentVideoPlaySet.VideoRecordFilePath);
                }
                parser.OnVideoSample -= OnVideoSample;
                parser.OnAudioSample -= OnAudioSample;
                parser.OnMetaDataSample -= OnMetaDataSample;
                parser.OnError -= OnError;
                viewer.OnDecodedImage -= OnDecodedImage;
                Marshal.FinalReleaseComObject(viewer);
                viewer = null;
                Marshal.FinalReleaseComObject(parser);
                parser = null;
            }
        }

        private void Axis_GenerateRecord(string strVideoRecordPath)
        {
            if (lstVideoRecord.Count > 0)
            {

                if (!strVideoRecordPath.EndsWith(".bin"))
                {
                    //不存在文件名称
                    CommonMethod.Common.CreateFolder(strVideoRecordPath);//创建文件夹
                    StringBuilder sbRecFilePath = new StringBuilder();
                    sbRecFilePath.Append(strVideoRecordPath);
                    sbRecFilePath.Append("\\" + CurrentVideoInfo.DVSNumber);                                //视频设备编号
                    sbRecFilePath.Append("_" + CurrentCameraInfo.Channel.ToString().PadLeft(2, '0'));       //通道号
                    sbRecFilePath.Append("_" + DateTime.Now.ToString("yyyyMMddHHmmss"));                    //时间
                    sbRecFilePath.Append("_" + "06.bin");                                                   //分类后缀及文件格式
                    strVideoRecordPath = sbRecFilePath.ToString();
                }
                else
                {
                    string Temp_strUpperLevelFolderPath = strVideoRecordPath.Substring(0, strVideoRecordPath.LastIndexOf("\\"));
                    CommonMethod.Common.CreateFolder(Temp_strUpperLevelFolderPath);//创建文件夹
                }
                //统一写入文件
                using (FileStream f = new FileStream(strVideoRecordPath, FileMode.Create))
                {
                    f.Write(lstVideoRecord.ToArray(), 0, lstVideoRecord.Count);
                }
                lstVideoRecord = new List<byte>();
            }
        }

        #endregion

        #region 回调事件
        /// <summary>
        /// 回调_视频信息
        /// </summary>
        /// <param name="cookieID"></param>
        /// <param name="sampleType"></param>
        /// <param name="sampleFlags"></param>
        /// <param name="startTime"></param>
        /// <param name="stopTime"></param>
        /// <param name="SampleArray"></param>
        private void OnVideoSample(int cookieID, int sampleType,
            int sampleFlags, ulong startTime, ulong stopTime, object SampleArray)
        {
            #region 视频录像
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                lock (objVideoRecordLock)
                {
                    byte[] bufferBytes = (byte[])SampleArray;
                    lstVideoRecord.AddRange(BitConverter.GetBytes(sampleType));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(sampleFlags));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(startTime));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(stopTime));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(bufferBytes.Length));
                    lstVideoRecord.AddRange(bufferBytes);
                }
            }
            #endregion
            long renderStartTime = 0;
            long renderStopTime = 1;
            if ((long)startTime + parser.LiveTimeOffset > 0)
            {
                renderStartTime = (long)startTime + parser.LiveTimeOffset;
                renderStopTime = (long)stopTime + parser.LiveTimeOffset;
            }
            viewer.RenderVideoSample(sampleFlags, (ulong)renderStartTime, (ulong)renderStopTime, SampleArray);
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
            VideoPlayState = Enum_VideoPlayState.InPlayState;
        }
        //void UpdateTimeDisplay(DateTime time)
        //{
        //    if (InvokeRequired)
        //    {
        //        // If called from a non UI thread, let the UI thread perform the call 
        //        BeginInvoke(new Action<DateTime>(UpdateTimeDisplay), new object[] { time });
        //        return;
        //    }

        //    // Update the time label
        //    this.Text = time.ToString("yyyy-MM-dd HH:mm:ss.fff");
        //}
        // Event handler from the parser for each audio frame buffer
        private void OnAudioSample(int cookieID, int sampleType,
            int sampleFlags, ulong startTime, ulong stopTime, object SampleArray)
        {
            // Let viewer render audio sample
            //视频录像
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                lock (objVideoRecordLock)
                {
                    byte[] bufferBytes = (byte[])SampleArray;
                    lstVideoRecord.AddRange(BitConverter.GetBytes(sampleType));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(sampleFlags));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(startTime));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(stopTime));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(bufferBytes.Length));
                    lstVideoRecord.AddRange(bufferBytes);
                }
            }
            // Add LiveTimeOffset to original timestamp for optimal latency when rendering
            long renderStartTime = 0;
            long renderStopTime = 1;
            if ((long)startTime + parser.LiveTimeOffset > 0)
            {
                renderStartTime = (long)startTime + parser.LiveTimeOffset;
                renderStopTime = (long)stopTime + parser.LiveTimeOffset;
            }
            viewer.RenderAudioSample(sampleFlags, (ulong)renderStartTime, (ulong)renderStopTime, SampleArray);
        }

        private void OnMetaDataSample(int cookieID, int sampleType,
            int sampleFlags, ulong startTime, ulong stopTime, string metaData)
        {
            //视频录像
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                lock (objVideoRecordLock)
                {
                    byte[] bufferBytes = System.Text.Encoding.UTF8.GetBytes(metaData);
                    lstVideoRecord.AddRange(BitConverter.GetBytes(sampleType));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(sampleFlags));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(startTime));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(stopTime));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(bufferBytes.Length));
                    lstVideoRecord.AddRange(bufferBytes);
                }
            }
        }

        /// <summary>
        /// 回调_异常事件
        /// </summary>
        /// <param name="errorCode"></param>
        private static void OnError(int errorCode)
        {
            AMP_ERROR ampError = (AMP_ERROR)errorCode;
            MessageBox.Show(string.Format("Parser OnErrorEventHandler {1} (0x{0:X})",
                errorCode, ampError.ToString()));
        }

        /// <summary>
        /// 回调_图片解码
        /// </summary>
        /// <param name="StartTime"></param>
        /// <param name="ColorSpace"></param>
        /// <param name="SampleArray"></param>
        private void OnDecodedImage(ulong StartTime, short ColorSpace, object SampleArray)
        {
            //byte[] decodedData = (byte[])SampleArray;
            //Bitmap bm = new Bitmap(CreateBitmap(decodedData));
            //bm.Save("firstImage.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private static Bitmap CreateBitmap(byte[] data)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
            {
                int bitmapFileHeaderSize = 14;
                binaryWriter.Write('B');
                binaryWriter.Write('M');
                binaryWriter.Write(bitmapFileHeaderSize + data.Length); // 4 bytes
                binaryWriter.Write((short)0);
                binaryWriter.Write((short)0);
                int bitmapInfoHeaderLength = BitConverter.ToInt32(data, 0);
                binaryWriter.Write(bitmapFileHeaderSize + bitmapInfoHeaderLength);
                binaryWriter.Write(data);

                return (Bitmap)Image.FromStream(memoryStream);
            }
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
        public bool VideoPlayEx()
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion


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
        /// 视频播放中是否可以录像  
        /// （临时变量，true 表示StartVideoRecord有实现 false 表示没有具体实现 用于界面控制 ）
        /// </summary>
        public bool VideoPlayingRecordEnable
        {
            get { return true; }
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
            CurrentVideoPlaySet.VideoRecordEnable = false;
            VideoClose();
            VideoPlay();
            return bolResult;
        }
    }
}
