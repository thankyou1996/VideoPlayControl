using CommonMethod;
using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl;
using VideoPlayControl.VideoBasicClass;
using static VideoPlayControl.SDK_SKVideoSDK;

namespace VideoPlayControl_UseDemo
{
    public partial class FrmSKVideoSDKTest : Form
    {
        VideoInfo CurrentVideoInfo;
        private CallBack p_msg_demo_callback;
        private p_dl_video_data_callback p_vsdk_reg_dl_video_data_callback;
        List<RemoteVideoRecordInfo> lRemoteVideoRecord;
        DateTime timDownLoadStart;
        DateTime timDownLoadEnd;
        public FrmSKVideoSDKTest()
        {
            InitializeComponent();
        }

        private void FrmSKVideoSDKTest_Load(object sender, EventArgs e)
        {
            CurrentVideoInfo = TestDataSource.TestDataSource.GetSKDVSData1();

            p_msg_demo_callback = new CallBack(callback);
            SDK_SKVideoSDK.p_sdkc_reg_msg_callback(p_msg_demo_callback);
            
            SDK_SKVideoSDK.p_sdkc_init_client("xhcs1", "127.0.0.1", 47624, 47724, 47824, @"d:\");
            while (SDK_SKVideoSDK.p_sdkc_get_online() == 0)
            {
                Common.Delay_Second(1);
            }
            DateTime timStart = DateTime.Now.AddSeconds(-3000);
            DateTime timEnd = DateTime.Now.AddSeconds(-2700);
            long intStartTime = ConvertClass.DateTimeToUnixTimestamp(timStart);
            long intEndTimt= ConvertClass.DateTimeToUnixTimestamp(timEnd);
            //SDK_SKVideoSDK.p_sdkc_start_playback_av(CurrentVideoInfo.DVSAddress, 0, Convert.ToUInt32(intStartTime), pictureBox1.Handle);

            p_vsdk_reg_dl_video_data_callback = new p_dl_video_data_callback(callback_download);
            SDK_SKVideoSDK.p_vsdk_reg_dl_video_data_callback(p_vsdk_reg_dl_video_data_callback);
            //string Temp_strDownPath = @"C:\SHIKE_Video\0138\DownloadTest\" + timStart.ToString("yyyy_MM_dd_HH_mm_ss") + ".H264";
            //string Temp_strDownPath = @"C:\SHIKE_Video\0138\DownloadTest";
            //int intResult = SDK_SKVideoSDK.p_sdkc_request_download_video(CurrentVideoInfo.DVSAddress, 0, (int)intStartTime, (int)intEndTimt, Temp_strDownPath);

        }

        public void callback(UInt32 msg_id, UInt32 arg1, UInt32 arg2, IntPtr data1, UInt32 data1_len, IntPtr data2, UInt32 data2_len)
        {
            st_event st = new st_event();
            switch (msg_id)
            {
                case 12:
                    {
                        st = (st_event)Marshal.PtrToStructure(data1, typeof(st_event));
                        string str = Encoding.Default.GetString(st.event_data);
                        string guid = System.Text.Encoding.Default.GetString(st.guid);
                        int i = guid.IndexOf("\0");
                        if (st.event_code==0x43)
                        {
                            string Y = "Download End";
                            MessageBox.Show(Y);
                        }
                        if (i > 0)
                        {
                            guid = guid.Substring(0, i);
                        }
                        int Temp_intChannelIndex = str.IndexOf("c:");
                        if (str.IndexOf("{") < 0 && Temp_intChannelIndex > 0)
                        {
                            //存在 { }代表事件内容
                            //认为是录像信息进行解析
                            lRemoteVideoRecord = SDK_SKVideoSDK.SKRemoteVideoRecordDataPrasing(guid, str);
                        }
                    }
                    break;
                case 0X43:

                    string x = "Download End";
                    MessageBox.Show(x);
                    break;
                default:
                    break;
            }

        }
        int intCount = 0;
        List<byte> l = new List<byte>();
        public void callback_download(string dguid, string cguid, int channel, IntPtr nalu_data, int nalu_len, IntPtr nalu_idx, uint time_stamp)
        {
            if (time_stamp == 0)
            {
                Console.WriteLine("Download End");
                string Temp_strDownPath = @"C:\SHIKE_Video\0138\DownloadTest\" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".H264";
                System.IO.Stream so = new System.IO.FileStream(Temp_strDownPath, System.IO.FileMode.Create);
                byte[] b = l.ToArray();
                so.Write(b, 0, b.Count());
                so.Close();
                l = new List<byte>();
                Console.WriteLine("Save End");
                timDownLoadEnd = DateTime.Now;
                TimeSpan ts = timDownLoadEnd - timDownLoadStart;
                Console.WriteLine("TimeSpan" + ts.ToString());
            }
            //st_event st = new st_event();
            //st = (st_event)Marshal.PtrToStructure(nalu_data, typeof(st_event));
            string guid = dguid;
            byte[] ys = new byte[nalu_len];
            Marshal.Copy(nalu_data, ys, 0, ys.Length);
            Console.WriteLine(time_stamp.ToString());
            l.AddRange(ys);
            intCount++;
            //Console.WriteLine(intCount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime timStart = DateTime.Now.AddSeconds(-3000);
            //DateTime timEnd = DateTime.Now.AddSeconds(-2700);
            DateTime timStart = DateTime.Parse("2018-05-25 21:02:01");
            DateTime timEnd = DateTime.Parse("2018-05-25 21:05:01");
            long start_time = ConvertClass.DateTimeToUnixTimestamp(timStart);
            long stop_time = ConvertClass.DateTimeToUnixTimestamp(timEnd);
            int intCount = 0;
            while (SDK_SKVideoSDK.p_sdkc_get_online() == 0 && intCount < 10)
            {
                Common.Delay_Second(1);
                intCount++;
            }
            string Temp_strDownPath = @"C:\SHIKE_Video\0138\DownloadTest\" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".H264";
            //string Temp_strDownPath = @"C:\SHIKE_Video\0138\DownloadTest";
            int intResult = SDK_SKVideoSDK.p_sdkc_request_download_video("61-57354AA60831-3136", 0, (int)start_time, (int)stop_time, Temp_strDownPath);
            intCount = 0;
            timDownLoadStart = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Temp_strDownPath = @"C:\SHIKE_Video\0138\DownloadTest\" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".H264";
            System.IO.Stream so = new System.IO.FileStream(Temp_strDownPath, System.IO.FileMode.Create);
            byte[] b = l.ToArray();
            so.Write(b, 0, b.Count());
            so.Close();
            l = new List<byte>();
        }
    }
}
