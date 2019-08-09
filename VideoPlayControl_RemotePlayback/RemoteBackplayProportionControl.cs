using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using VideoCurrencyModule.RemotePlayback;

namespace VideoPlayControl_RemotePlayback
{
    public partial class RemoteBackplayProportionControl : UserControl
    {
        public RemoteBackplayProportionControl()
        {
            InitializeComponent();
        }
        private void RemoteBackplayProportionControl_Load(object sender, EventArgs e)
        {
            pictureBox1.MouseWheel += PictureBox1_MouseWheel;
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
            if (value.BackplayFiles != null)
            {
                //文件信息进行排序
                List<RemoteBackplayFileInfo> lstBackplayFile = value.BackplayFiles.OrderBy(item => item.StartTimeStamp).ToList();
                long lStart = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(value.StartTime);
                long lEnd = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(value.EndTime);
                int intMaxValue = this.Width;
                Graphics g = pictureBox1.CreateGraphics();
                Rectangle r = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
                SolidBrush brush = new SolidBrush(Color.White);
                g.FillRectangle(brush, r);
                foreach (RemoteBackplayFileInfo item in lstBackplayFile)
                {
                    int intStartPosition = GetPosition(lStart, lEnd, item.StartTimeStamp, pictureBox1.Width);
                    int intEndPosition = GetPosition(lStart, lEnd, item.EndTimeStamp, pictureBox1.Width);
                    int Temp_intWidth = intEndPosition - intStartPosition;
                    r = new Rectangle(intStartPosition, 0, Temp_intWidth, this.Height);
                    brush = new SolidBrush(Color.Green);
                    g.FillRectangle(brush, r);
                }
            }
        }

        public void SetRemoteBackplayInfo_(VideoChannelRemoteBackplayInfo value)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Rectangle r = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
        }

        public int GetPosition(long lStart, long lEnd, long lTimeSpan, int intValue)
        {
            double Temp_dblPercentageStart = GetPercentage(lStart, lEnd, lTimeSpan);
            int intResult = Convert.ToInt32(intValue * Temp_dblPercentageStart);
            return intResult;
        }

        public double GetPercentage(long lStart,long lEnd,long lTimeSpan)
        {
            double intResult = 0;
            if (lStart > lTimeSpan)
            {
                intResult = 0;
            }
            else if (lEnd < lTimeSpan)
            {
                intResult = 100;
            }
            else
            {
                long Temp_value1 = lEnd - lStart;
                long Temp_value2 = lTimeSpan - lStart;
                intResult = (double)Temp_value2 / (double)Temp_value1;
            }
            return intResult;


        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.OnMouseDown(e);
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.OnMouseMove(e);
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.OnMouseUp(e);
        }

        private void PictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            this.OnMouseWheel(e);
        }
    }
}
