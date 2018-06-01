using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace VideoPlayControl_UseDemo
{
    public partial class FrmCapture : Form
    {
        public FrmCapture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strPath = @"C:\SHIKE_Video\9999\20180531021925\61-57354AA60831-3136_20180531021934_01_bfr10.H264";
            GetPicFromVideo(strPath, "240*180", "5");
        }
        #region 从视频画面中截取一帧画面为图片
        /// <summary>
        /// 从视频画面中截取一帧画面为图片
        /// </summary>
        /// <param name="VideoName">视频文件，绝对路径</param>
        /// <param name="WidthAndHeight">图片的尺寸如:240*180</param>
        /// <param name="CutTimeFrame">开始截取的时间如:"1"</param>
        /// <returns></returns>
        public string GetPicFromVideo(string VideoName, string WidthAndHeight, string CutTimeFrame)
        {
            string ffmpeg = Application.StartupPath+ "\\ffmpeg\\ffmpeg.exe";//ffmpeg执行文件的路径
            string Temp_strPath = @"C:\SHIKE_Video\SKAlarmPic";
            string PicName = VideoName + ".jpg";//视频图片的名字，绝对路径
            //ffmpeg.exe - i D:\SK_VideoRecord\9999\20180530092930\61 - 57354AA60831 - 3136_20180530092941_09_bfr10.H264 - f image2 - r 5   D:\SK_VideoRecord\9999\20180530092930\b -% 03d.jpg

            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(ffmpeg);
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //startInfo.Arguments = " -i " + VideoName
            //                    + " -y -f image2 -r " + CutTimeFrame
            //                    + " -t 0.001 -s " + WidthAndHeight
            //                    + " " + PicName;  //設定程式執行參數
            StringBuilder sbCmd = new StringBuilder();
            sbCmd.Append(" -i "+ VideoName);
            sbCmd.Append("-f image2 - r 5   G:\\Test\\b -% 03d.jpg");
            //sbCmd.Append("") startInfo.
           
            startInfo.Arguments = sbCmd.ToString();
           //startInfo.Arguments = " -i " + VideoName
           //                     + " -y -f image2 -r " + CutTimeFrame
           //                     + " -t 0.001 -s " + WidthAndHeight
           //                     + " " + PicName;  //設定程式執行參數
            try
            {
                System.Diagnostics.Process.Start(startInfo);
                Thread.Sleep(5000);//线程挂起，等待ffmpeg截图完毕
            }
            catch (Exception)
            {
                return "";
            }

            //返回视频图片完整路径
            if (System.IO.File.Exists(PicName))
                return PicName;
            return "";
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            //string strSavePath = @"G:\Test";
            //bool bolResult = VideoPlayControl.SDK_SKVideoSDK.GetPictureForVideoRecord(@"C:\SHIKE_Video\9999\20180531021956\61-57354AA60831-3136_20180531022002_01_bfr10.H264", strSavePath, 10);

            string strSavePath = @"G:\Test";
            GetPictureForVideoRecord(@"C:\SHIKE_Video\9999\20180531021956\61-57354AA60831-3136_20180531022002_01_bfr10.H264", strSavePath, 10);
        }
        public static bool GetPictureForVideoRecord(string strVideoRecord, string strSaveFolder, int intFrequcency)
        {
            bool bolResult = false;
            StringBuilder sbffmpegCmd = new StringBuilder();
            sbffmpegCmd.Append("ffmpeg.exe ");
            sbffmpegCmd.Append("-i " + strVideoRecord);
            sbffmpegCmd.Append(" -f image2 -r 5   ");
            sbffmpegCmd.Append(strSaveFolder + "\\b-%03d.jpg");
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";    //设置要启动的应用程序
            p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;    // 接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;  //输出信息
            p.StartInfo.RedirectStandardError = true;   // 输出错误
            p.StartInfo.CreateNoWindow = true;          //不显示程序窗口
            p.Start();          //启动程序
            p.StandardInput.WriteLine(sbffmpegCmd.ToString() + "&exit");//向cmd窗口发送输入信息
            p.StandardInput.AutoFlush = true;
            return bolResult;
        }

    }
}
