using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VideoCurrencyModule.RemotePlayback;

namespace VideoPlayControl_RemotePlayback_UseDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            List<RemoteBackplayFileInfo> FileInfo = new List<RemoteBackplayFileInfo>();
            FileInfo.Add(new RemoteBackplayFileInfo
            {
                StartTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-12)),
                EndTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-11)),
            });
            FileInfo.Add(new RemoteBackplayFileInfo
            {
                StartTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-11)),
                EndTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-10)),
            });
            FileInfo.Add(new RemoteBackplayFileInfo
            {
                StartTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-8)),
                EndTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-7)),
            });

            FileInfo.Add(new RemoteBackplayFileInfo
            {
                StartTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-4)),
                EndTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-2)),
            });
            VideoChannelRemoteBackplayInfo channelInfo = new VideoChannelRemoteBackplayInfo
            {
                StartTime = DateTime.Now.AddHours(-12),
                EndTime = DateTime.Now,
                BackplayFiles=FileInfo,
            };
            remoteBackplayInfoControl1.SetRemoteBackplayInfo(channelInfo);
            remoteBackplayControl1.SetRemoteBackplayInfo(channelInfo);
        }
        bool bolFlag1 = false;
        int Temp_intX = 0;

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            bolFlag1 = true;
            StringBuilder sbDisplayInfo = new StringBuilder();
            sbDisplayInfo.Append("MouseDown" + DateTime.Now.ToString("mm:ss:fff"));
            sbDisplayInfo.Append("e.X:" + e.X + ";e.Y：" + e.Y);
            Temp_intX = e.X;
            Console.WriteLine(sbDisplayInfo.ToString());
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            bolFlag1 = false;
            StringBuilder sbDisplayInfo = new StringBuilder();
            sbDisplayInfo.Append("MouseUp" + DateTime.Now.ToString("mm:ss:fff"));
            sbDisplayInfo.Append("e.X:" + e.X + ";e.Y：" + e.Y);
            Console.WriteLine(sbDisplayInfo.ToString());
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bolFlag1)
            {
                StringBuilder sbDisplayInfo = new StringBuilder();
                sbDisplayInfo.Append("MouseMove" + DateTime.Now.ToString("mm:ss:fff"));
                sbDisplayInfo.Append("e.X:" + e.X + ";e.Y：" + e.Y);
                int Temp_intxxx = e.X - Temp_intX;
                pictureBox1.Location = new Point { X = pictureBox1.Location.X + Temp_intxxx, Y = pictureBox1.Location.Y }; 
                Console.WriteLine(sbDisplayInfo.ToString());

            }
        }

        private void RemoteBackplayControl1_Click(object sender, EventArgs e)
        {

            //Console.WriteLine("123");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.MouseWheel += PictureBox1_MouseWheel
                ;
        }

        private void PictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            Console.WriteLine("MouseWheel");
            if (e.Delta > 0)
            {
                pictureBox1.Width = pictureBox1.Width * 2;
            }
            else
            {
                pictureBox1.Width = pictureBox1.Width / 2;
            }
        }
    }
}
