
//using AxisMediaParserLib;
//using AxisMediaViewerLib;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.IO;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace VideoPlayControl_UseDemo
//{
//    public partial class Frm_Temp_TestAxis : Form
//    {
//        public Frm_Temp_TestAxis()
//        {
//            InitializeComponent();
//        }
//        // NTP time-stamps start from this date
//        private readonly DateTime NtpTimeEpoch = new DateTime(1900, 1, 1);
//        string strUrl = "axrtsphttp://192.168.2.164/axis-media/media.amp?videocodec=JPEG";
//        string strUserName = "root";
//        string strPwd = "sk123456";
//        private AxisMediaParser parser;
//        private AxisMediaViewer viewer;
//        private int viewerWidth;
//        private int viewerHeight;

//        private bool saveFirstImageToDisk = true;
//        private void Frm_Temp_TestAxis_Load(object sender, EventArgs e)
//        {
//            Task.Factory.StartNew(() =>
//            {
//                // Create AXIS Media Parser and AXIS Media Viewer components
//                parser = new AxisMediaParser();
//                viewer = new AxisMediaViewer();
//            }).Wait();
            
//            parser.OnVideoSample += OnVideoSample;
//            parser.OnAudioSample += OnAudioSample;
//            parser.OnMetaDataSample += OnMetaDataSample;
//            parser.OnError += OnError;

//            //设置流媒体参数
//            parser.ShowLoginDialog = true;
//            parser.MediaURL = strUrl;
//            parser.MediaUsername = strUserName;
//            parser.MediaPassword = strPwd;

//            // 设置页面参数
//            viewer.VideoRenderer = (int)AMV_RENDER_OPTIONS.AMV_VIDEO_RENDERER_EVR;
//            if (saveFirstImageToDisk)
//            {
//                viewer.OnDecodedImage += OnDecodedImage;
//                viewer.ColorSpace = (short)AMV_COLOR_SPACE.AMV_CS_RGB24;
//                viewer.EnableOnDecodedImage = true;
//            }
//            else
//            {
//                viewer.ColorSpace = (short)AMV_COLOR_SPACE.AMV_CS_YUY2;
//                viewer.EnableOnDecodedImage = false;
//            }

//            viewer.LiveMode = true;

//            // Parser connects to the device
//            Console.WriteLine("Connecting to {0}", parser.MediaURL);
//            int cookieID;
//            int numberOfStreams;
//            object mediaTypeBuffer;
//            parser.Connect(out cookieID, out numberOfStreams, out mediaTypeBuffer);

//            // Init the Viewer with media type buffer and a win32 hWnd handle to the window. 
//            viewer.Init(0, mediaTypeBuffer, panel1.Handle.ToInt64());

//            // Get the video frame size and resize the form to fit the video stream 
//            //viewer.GetVideoSize(out viewerWidth, out viewerHeight);
//            //ResizeFormToFitVideoSize(viewerWidth, viewerHeight);
//            viewer.SetVideoPosition(0, 0, panel1.Width, panel1.Height);
//            // Start the viewer before rendering the first frame
//            viewer.Start();

//            // Start the media stream, OnVideoSample will be called for each frame
//            parser.Start();

//            //parser.GetVideoCodec
//        }
//        // Event handler from the parser for each video frame buffer
//        private void OnVideoSample(int cookieID, int sampleType,
//            int sampleFlags, ulong startTime, ulong stopTime, object SampleArray)
//        {
//            // Let viewer render video sample

//            // Add LiveTimeOffset to original timestamp for optimal latency when rendering
//            long renderStartTime = 0;
//            long renderStopTime = 1;
//            if ((long)startTime + parser.LiveTimeOffset > 0)
//            {
//                renderStartTime = (long)startTime + parser.LiveTimeOffset;
//                renderStopTime = (long)stopTime + parser.LiveTimeOffset;
//            }

//            viewer.RenderVideoSample(sampleFlags, (ulong)renderStartTime, (ulong)renderStopTime, SampleArray);

//            // When NTPTimeOffset is not zero it can be used to convert to camera clock time
//            if (parser.NTPTimeOffset > 0)
//            {
//                ulong dateTimeTicks = startTime + parser.NTPTimeOffset + (ulong)NtpTimeEpoch.Ticks;
//                DateTime cameraTime = new DateTime((long)dateTimeTicks);

//                // Note that we display the time when the frame was received not rendered
//                UpdateTimeDisplay(cameraTime.ToLocalTime());
//            }
//        }
//        void UpdateTimeDisplay(DateTime time)
//        {
//            if (InvokeRequired)
//            {
//                // If called from a non UI thread, let the UI thread perform the call 
//                BeginInvoke(new Action<DateTime>(UpdateTimeDisplay), new object[] { time });
//                return;
//            }

//            // Update the time label
//            this.Text = time.ToString("yyyy-MM-dd HH:mm:ss.fff");
//        }
//        // Event handler from the parser for each audio frame buffer
//        private void OnAudioSample(int cookieID, int sampleType,
//            int sampleFlags, ulong startTime, ulong stopTime, object SampleArray)
//        {
//            // Let viewer render audio sample

//            // Add LiveTimeOffset to original timestamp for optimal latency when rendering
//            long renderStartTime = 0;
//            long renderStopTime = 1;
//            if ((long)startTime + parser.LiveTimeOffset > 0)
//            {
//                renderStartTime = (long)startTime + parser.LiveTimeOffset;
//                renderStopTime = (long)stopTime + parser.LiveTimeOffset;
//            }

//            viewer.RenderAudioSample(sampleFlags, (ulong)renderStartTime, (ulong)renderStopTime, SampleArray);
//        }

//        private void OnMetaDataSample(int cookieID, int sampleType,
//            int sampleFlags, ulong startTime, ulong stopTime, string metaData)
//        {
//            // Process metadata samples here

//            // Let viewer overlay metadata sample
//            //
//            // //Add LiveTimeOffset to original timestamp for optimal latency when rendering
//            //long renderStartTime = 0;
//            //long renderStopTime = 1;
//            //if ((long)startTime + parser.LiveTimeOffset > 0)
//            //{
//            //  renderStartTime = (long)startTime + parser.LiveTimeOffset;
//            //  renderStopTime = (long)stopTime + parser.LiveTimeOffset;
//            //}
//            //
//            // viewer.RenderMetadataSample(sampleFlags, renderStartTime, renderStopTime, metaData);
//        }

//        private static void OnError(int errorCode)
//        {
//            AMP_ERROR ampError = (AMP_ERROR)errorCode;
//            MessageBox.Show(string.Format("Parser OnErrorEventHandler {1} (0x{0:X})",
//                errorCode, ampError.ToString()));
//        }



//        private void OnDecodedImage(ulong StartTime, short ColorSpace, object SampleArray)
//        {
//            if (saveFirstImageToDisk)
//            {
//                byte[] decodedData = (byte[])SampleArray;
//                Bitmap bm = new Bitmap(CreateBitmap(decodedData));
//                bm.Save("firstImage.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
//                saveFirstImageToDisk = false;
//            }
//        }

//        private static Bitmap CreateBitmap(byte[] data)
//        {
//            using (MemoryStream memoryStream = new MemoryStream())
//            using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
//            {
//                int bitmapFileHeaderSize = 14;
//                binaryWriter.Write('B');
//                binaryWriter.Write('M');
//                binaryWriter.Write(bitmapFileHeaderSize + data.Length); // 4 bytes
//                binaryWriter.Write((short)0);
//                binaryWriter.Write((short)0);
//                int bitmapInfoHeaderLength = BitConverter.ToInt32(data, 0);
//                binaryWriter.Write(bitmapFileHeaderSize + bitmapInfoHeaderLength);
//                binaryWriter.Write(data);

//                return (Bitmap)Image.FromStream(memoryStream);
//            }
//        }
//        private void ResizeFormToFitVideoSize(int width, int height)
//        {
//            int formWidthChange = width - panel1.ClientSize.Width;
//            int formHeightChange = height - panel1.ClientSize.Height;
//            ClientSize = new Size(ClientSize.Width + formWidthChange,
//                ClientSize.Height + formHeightChange);
//        }

//        private void Frm_Temp_TestAxis_FormClosing(object sender, FormClosingEventArgs e)
//        {
//            if (parser.Status == (int)AMP_STATUS.AMP_STATUS_RUNNING)
//            {
//                parser.Stop();
//                viewer.Stop();
//            }

//            // Unregister event handlers
//            parser.OnVideoSample -= OnVideoSample;
//            parser.OnAudioSample -= OnAudioSample;
//            parser.OnMetaDataSample -= OnMetaDataSample;
//            parser.OnError -= OnError;

//            viewer.OnDecodedImage -= OnDecodedImage;

//            // Inform the GC that COM object no longer will be used
//            Marshal.FinalReleaseComObject(viewer);
//            viewer = null;

//            Marshal.FinalReleaseComObject(parser);
//            parser = null;
//        }

//        private void Frm_Temp_TestAxis_Resize(object sender, EventArgs e)
//        {
//            if (viewer == null)
//            {
//                return;
//            }

//            if (panel1.ClientSize.Width != viewerWidth ||
//                panel1.ClientSize.Height != viewerHeight)
//            {
//                // The video frame area has changed, so the viewer needs to be informed
//                viewerWidth = panel1.ClientSize.Width;
//                viewerHeight = panel1.ClientSize.Height;
//                viewer.SetVideoPosition(0, 0, viewerWidth, viewerHeight);
//            }
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            this.BeginInvoke(new EventHandler(delegate {
//                if (parser.Status == (int)AMP_STATUS.AMP_STATUS_RUNNING)
//                {
//                    parser.Stop();
//                    viewer.Stop();
//                }
//            }));
            
//        }
//    }
//}
