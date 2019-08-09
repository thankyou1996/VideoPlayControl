using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VideoCurrencyModule.RemotePlayback;
using System.Threading;

namespace VideoPlayControl_RemotePlayback
{
    public partial class RemoteBackplayControl : UserControl
    {
        public RemoteBackplayControl()
        {
            InitializeComponent();
        }


        private VideoChannelRemoteBackplayInfo currentRemoteBackplayInfo;

        public VideoChannelRemoteBackplayInfo CurrentRemoteBackplayInfo
        {
            get { return currentRemoteBackplayInfo; }
            set
            {
                SetRemoteBackplayInfo(value);
            }
        }

        public void SetRemoteBackplayInfo(VideoChannelRemoteBackplayInfo value)
        {
            currentRemoteBackplayInfo = value;
            remoteBackplayProportionControl1.SetRemoteBackplayInfo(value);
        }

        int intInitialWidth = 0;

        public int MaxWitdh
        {
            get
            {
                return (intInitialWidth * 10);
            }
        }
        private void RemoteBackplayControl_Load(object sender, EventArgs e)
        {
            remoteBackplayProportionControl1.Width = this.Width;
            remoteBackplayProportionControl1.Height = this.Height - 12;
            intInitialWidth = remoteBackplayProportionControl1.Width;
            remoteBackplayProportionControl1.MouseWheel += RemoteBackplayProportionControl1_MouseWheel;
        }


        bool bolFlag1 = false;
        int Temp_intX = 0;
        private void RemoteBackplayProportionControl1_MouseDown(object sender, MouseEventArgs e)
        {
            bolFlag1 = true;

            StringBuilder sbDisplayInfo = new StringBuilder();
            sbDisplayInfo.Append("MouseDown" + DateTime.Now.ToString("mm:ss:fff"));
            sbDisplayInfo.Append("e.X:" + e.X + ";e.Y：" + e.Y);
            Temp_intX = e.X;
            Console.WriteLine(sbDisplayInfo.ToString());
        }

        private void RemoteBackplayProportionControl1_MouseUp(object sender, MouseEventArgs e)
        {
            bolFlag1 = false;
            //fc

            StringBuilder sbDisplayInfo = new StringBuilder();
            sbDisplayInfo.Append("MouseUp" + DateTime.Now.ToString("mm:ss:fff"));
            sbDisplayInfo.Append("e.X:" + e.X + ";e.Y：" + e.Y);
            Console.WriteLine(sbDisplayInfo.ToString());
        }

        private void RemoteBackplayProportionControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bolFlag1)
            {
                int Temp_intxxx = e.X - Temp_intX;
                remoteBackplayProportionControl1.Location = new Point { X = remoteBackplayProportionControl1.Location.X + Temp_intxxx, Y = remoteBackplayProportionControl1.Location.Y };
                StringBuilder sbDisplayInfo = new StringBuilder();
                sbDisplayInfo.Append("MouseMove" + DateTime.Now.ToString("mm:ss:fff"));
                sbDisplayInfo.Append("e.X:" + e.X + ";e.Y：" + e.Y);
                Console.WriteLine(sbDisplayInfo.ToString());
                SetRemoteBackplayInfo(currentRemoteBackplayInfo);
            }
        }

        private void RemoteBackplayProportionControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (remoteBackplayProportionControl1.Width < MaxWitdh)
                {
                    remoteBackplayProportionControl1.Width = remoteBackplayProportionControl1.Width * 2;
                }
                
            }
            else
            {
                if (remoteBackplayProportionControl1.Width > intInitialWidth)
                {
                    remoteBackplayProportionControl1.Width = remoteBackplayProportionControl1.Width / 2;
                }
            }
            SetRemoteBackplayInfo(currentRemoteBackplayInfo);
        }
    }
}
