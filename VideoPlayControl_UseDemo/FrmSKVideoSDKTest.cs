using CommonMethod;
using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            CurrentVideoInfo = TestDataSource.TestDataSource.GetSKDVSData3();

            p_msg_demo_callback = new CallBack(callback);
            SDK_SKVideoSDK.p_sdkc_reg_msg_callback(p_msg_demo_callback);
            
            SDK_SKVideoSDK.p_sdkc_init_client("Admin", "192.168.2.19", 47624, 47724, 47824, @"d:\");
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
        List<byte> lVideo = new List<byte>();
        List<byte> lAudio = new List<byte>();
        public void callback_download(string dguid, string cguid, int channel, IntPtr nalu_data, int nalu_len, IntPtr nalu_idx, uint time_stamp,uint isVideo)
        {
            if (time_stamp == 0)
            {
                Console.WriteLine("Download End");
                DateTime tim = DateTime.Now;

                string Temp_strVideo = Path + "\\" + Temp_strName + ".h264";
                System.IO.Stream so = new System.IO.FileStream(Temp_strVideo, System.IO.FileMode.Create);
                byte[] b = lVideo.ToArray();
                so.Write(b, 0, b.Count());
                so.Close();
                lVideo = new List<byte>();



                string Temp_strAudio = Path + "\\" + Temp_strName + ".G711";
                System.IO.Stream sAudio = new System.IO.FileStream(Temp_strAudio, System.IO.FileMode.Create);
                byte[] bAudio = lAudio.ToArray();
                sAudio.Write(bAudio, 0, bAudio.Count());
                sAudio.Close();
                lVideo = new List<byte>();

                this.BeginInvoke(new EventHandler(delegate{

                    string Temp_strSavePath = Path + "\\" + Temp_strName + ".mkv";
                    StringBuilder sbCmd = new StringBuilder();
                    sbCmd.Append("ffmpeg ");
                    sbCmd.Append("-y -r 15 ");
                    sbCmd.Append("-i " + Temp_strVideo + " ");
                    sbCmd.Append("-f mulaw -ar 8000 -ac 1 ");
                    sbCmd.Append("-i " + Temp_strAudio + " ");
                    sbCmd.Append("-vcodec copy -acodec ");
                    sbCmd.Append("aac " + Temp_strSavePath);

                    Process p = new Process();
                    p.StartInfo.FileName = "cmd.exe";    //设置要启动的应用程序
                    p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
                    p.StartInfo.RedirectStandardInput = true;    // 接受来自调用程序的输入信息
                    p.StartInfo.RedirectStandardOutput = true;  //输出信息
                    p.StartInfo.RedirectStandardError = true;   // 输出错误
                    p.StartInfo.CreateNoWindow = true;          //不显示程序窗口
                    p.Start();          //启动程序
                    p.StandardInput.WriteLine(sbCmd.ToString() + "&exit");//向cmd窗口发送输入信息
                    p.StandardInput.AutoFlush = true;
                }));


                Console.WriteLine("Save End");
                timDownLoadEnd = DateTime.Now;
                TimeSpan ts = timDownLoadEnd - timDownLoadStart;
                Console.WriteLine("TimeSpan" + ts.ToString());
                return;
            }
            //st_event st = new st_event();
            //st = (st_event)Marshal.PtrToStructure(nalu_data, typeof(st_event));
            string guid = dguid;
            byte[] ys = new byte[nalu_len];
            Marshal.Copy(nalu_data, ys, 0, ys.Length);
            Console.WriteLine(time_stamp.ToString());
            if (isVideo == 1)
            {
                lVideo.AddRange(ys);
            }
            else
            {
                lAudio.AddRange(ys);
            }
            intCount++;
            //Console.WriteLine(intCount);
        }

        public string Path = @"D:\DownloadTest";
        string Temp_strName = "";

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime timStart = DateTime.Now.AddSeconds(-3000);
            //DateTime timEnd = DateTime.Now.AddSeconds(-2700);
            DateTime timStart = DateTime.Parse("2019-09-06 12:33:00");
            DateTime timEnd = DateTime.Parse("2019-09-06 12:35:01");
            //DateTime timStart = DateTime.Now.AddSeconds(-3000);
            //DateTime timEnd = DateTime.Now.AddSeconds(-2700);
            long start_time = ConvertClass.DateTimeToUnixTimestamp(timStart);
            long stop_time = ConvertClass.DateTimeToUnixTimestamp(timEnd);

            //long start_time = ConvertClass.DateTimeToUnixTimestamp(DateTime.Parse("2019-06-05 17:01:38"));
            //long stop_time = ConvertClass.DateTimeToUnixTimestamp(DateTime.Parse("2019-06-05 17:03:34"));
            //long start_time = ConvertClass.DateTimeToUnixTimestamp(DateTime.Parse("2019-06-05 15:04:13"));
            //long stop_time = ConvertClass.DateTimeToUnixTimestamp(DateTime.Parse("2019-06-05 15:50:03"));
            //long start_time = 1559802091;
            //long stop_time = 1559802199;
            int intCount = 0;
            while (SDK_SKVideoSDK.p_sdkc_get_online() == 0 && intCount < 10)
            {
                Common.Delay_Second(1);
                intCount++;
            }
            //string Temp_strDownPath = @"C:\SHIKE_Video\0138\DownloadTest\" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".H264";
            
            Temp_strName = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
            //string Temp_strDownPath = @"C:\SHIKE_Video\0138\DownloadTest";
            string Temp_strDownPath = Path + "\\" + Temp_strName + "_Temp.h264";
            int intResult = SDK_SKVideoSDK.p_sdkc_request_download_video("72-00F51F0150E8-35B7", 0, (int)start_time, (int)stop_time, Temp_strDownPath);
            intCount = 0;
            timDownLoadStart = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Temp_strDownPath = @"C:\SHIKE_Video\0138\DownloadTest\" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".H264";
            System.IO.Stream so = new System.IO.FileStream(Temp_strDownPath, System.IO.FileMode.Create);
            byte[] b = lVideo.ToArray();
            so.Write(b, 0, b.Count());
            so.Close();
            lVideo = new List<byte>();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string path1 = @"C:\Users\hongdongcheng\Desktop\SK录像文件转码工具(2019_04_25)修正没有后备录像映射表文件的转码";
            string path2 = @"C:\Users\hongdongcheng\Desktop\SK录像文件转码工具(2019_04_25)修正没有后备录像映射表文件的转码\sk_video_convert.exe";
            string str = @"C:\Users\hongdongcheng\Downloads\VHS_ch01_72-00F51F0150E8-35B7_1567741946.h264";
            CommonMethod.ProcessControl.StartProcess(path1, path2, str);
            //System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo(path);
            //info.WorkingDirectory = Path.GetDirectoryName(path);
            //System.Diagnostics.Process.Start(info, str);
        }
    }
}
