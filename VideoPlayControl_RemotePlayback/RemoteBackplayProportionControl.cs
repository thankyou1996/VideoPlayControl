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

        #region 属性

        /// <summary>
        /// 颜色
        /// </summary>
        public Color MainColor
        {
            get { return pictureBox1.BackColor; }
            set { pictureBox1.BackColor = value; }
        }
        #endregion
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

            if (value!= null)
            {
                //文件信息进行排序
                List<RemoteBackplayFileInfo> lstBackplayFile = value.BackplayFiles.OrderBy(item => item.StartTimeStamp).ToList();
                long lStart = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(value.StartTime);
                long lEnd = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(value.EndTime);
                int intMaxValue = this.Width;
                Graphics g = pictureBox1.CreateGraphics();
                Rectangle r = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
                SolidBrush brush = new SolidBrush(pictureBox1.BackColor);
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


        public void SetRemoteBackplayInfo_Scale(int intWidth)
        {
            pictureBox1.Controls.Clear();
            int Temp_inti = (intWidth + 5) / 5;
            int Temp_intssss = 45;
            for (int i = 0; i <= 506; i++)
            {
                int Temp_intxxx = (i * intWidth);
                if (Temp_intxxx > pictureBox1.Width)
                {
                    return;
                }
                Panel p = new Panel();
                p.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                p.Location = new System.Drawing.Point(Temp_intxxx, 15);
                p.Name = "panel1";
                p.Size = new System.Drawing.Size(1, 65);
                pictureBox1.Controls.Add(p);

                Label lbl = new Label();
                lbl.BackColor = System.Drawing.Color.Transparent;
                lbl.ForeColor = System.Drawing.Color.White;
                lbl.BackColor = Color.FromArgb(0, 0, 0, 0);
                lbl.Location = new System.Drawing.Point((Temp_intxxx - Temp_intssss), 7);
                lbl.Name = "lbl";
                lbl.Size = new System.Drawing.Size(89, 12);
                lbl.TabIndex = 5;
                long l = Get(Temp_intxxx);
                DateTime timFlagValue = VideoCurrencyModule.PubMethod.UnixMillisecondsTimestampToDateTime(l);

                lbl.Text = timFlagValue.ToString("MM-dd HH:mm:ss");
                pictureBox1.Controls.Add(lbl);
                for (int j = 1; j < 5; j++)
                {
                    int Temp_intyyyy = (j * Temp_inti);
                    Panel pp = new Panel();
                    pp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                    pp.Location = new System.Drawing.Point(Temp_intxxx + Temp_intyyyy, 35);
                    pp.Name = "panel2";
                    pp.Size = new System.Drawing.Size(1, 35);
                    pictureBox1.Controls.Add(pp);
                }
            }
        }

        public void SetRemoteBackplayInfo_ScaleTextInfo()
        {

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

        public long Get( int intPosition)
        {
            long result = 1;
            //1.位置
            //2.宽度
            long lStart = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(CurrentRemoteBackplayInfo.StartTime);
            long lEnd = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(CurrentRemoteBackplayInfo.EndTime);
            long Temp_value1 = lEnd - lStart;
            double Temp_dbl = (double)intPosition / this.Width;
            result = Convert.ToInt64(Temp_value1 * Temp_dbl);
            result = lStart + result;
            return result;
            
        }


        public void ControlsAdd(Control c)
        {
            pictureBox1.Controls.Add(c);
        }

        #region 控件事件

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


        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }
        #endregion

        private void PictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.OnMouseDoubleClick(e);
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (this.currentRemoteBackplayInfo != null)
            {
                Console.WriteLine("PictureBox1_Paint:" + this.currentRemoteBackplayInfo.ChnnelInfo.Channel);
            }
            SetRemoteBackplayInfo(currentRemoteBackplayInfo);
            this.OnPaint(e);
        }
    }
}
