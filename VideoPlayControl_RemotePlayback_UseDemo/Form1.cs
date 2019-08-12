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
                StartTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-10)),
                EndTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-4)),
            });

            FileInfo.Add(new RemoteBackplayFileInfo
            {
                StartTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-4)),
                EndTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-1)),
            });
            VideoChannelRemoteBackplayInfo channelInfo = new VideoChannelRemoteBackplayInfo
            {
                ChnnelInfo = new PublicClassCurrency.CameraInfo
                {
                    Channel = 1,
                    CameraName = "通道1"
                },
                StartTime = DateTime.Now.AddHours(-12),
                EndTime = DateTime.Now,
                BackplayFiles = FileInfo,
            };
            remoteBackplayInfoControl1.SetRemoteBackplayInfo(channelInfo);
            remoteBackplayControl1.SetRemoteBackplayInfo(channelInfo);
            channelRemoteBackplayInfo1.SetRemoteBackplayInfo(channelInfo);
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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.MouseWheel += PictureBox1_MouseWheel;
            Test();
            //label3.Parent = pictureBox2;
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

        private void RemoteBackplayInfoControl1_Click(object sender, EventArgs e)
        {

        }

        private void RemoteBackplayInfoControl1_MouseClick(object sender, MouseEventArgs e)
        {
            long l = remoteBackplayInfoControl1.Get(e.X);
            Console.WriteLine(VideoCurrencyModule.PubMethod.UnixMillisecondsTimestampToDateTime(l));
            ;
        }


        public void Test()
        {
            int Temp_int = pictureBox2.Width / 6;

            int Temp_inti = (Temp_int + 5) / 5;
            for (int i = 0; i <= 6; i++)
            {
                int Temp_intxxx = (i * Temp_int);
                Console.WriteLine("Big " + (i + 1) + " :" + Temp_intxxx);
                Panel p = new Panel();
                p.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                p.Location = new System.Drawing.Point(Temp_intxxx, 30);
                p.Name = "panel1";
                p.Size = new System.Drawing.Size(1, 65);
                p.TabIndex = 4;
                pictureBox2.Controls.Add(p);



                for (int j = 1; j < 5; j++)
                {
                    int Temp_intyyyy = (j * Temp_inti);
                    Console.WriteLine("Min " + (j + 1) + " :" + Temp_intyyyy);
                    Panel pp = new Panel();
                    pp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                    pp.Location = new System.Drawing.Point(Temp_intxxx + Temp_intyyyy, 50);
                    pp.Name = "panel2";
                    pp.Size = new System.Drawing.Size(1, 35);
                    pictureBox2.Controls.Add(pp);
                }
            }
        }

        private void PictureBox2_Paint(object sender, PaintEventArgs e)
        {
            //foreach (Control C in this.Controls)
            //{
            //    if (C is Label)

            //    {

            //        Label L = (Label)C;

            //        L.Visible = false;

            //        e.Graphics.DrawString(L.Text, L.Font, new

            //       SolidBrush(L.ForeColor), L.Left - pictureBox1.Left, L.Top - pictureBox1.Top);

            //    }
            //}
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            remoteBackplayControl1.SetCurrentPositionDateTime(dateTimePicker1.Value);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = remoteBackplayControl1.GetFlagDateTime();
            
        }
    }
}
