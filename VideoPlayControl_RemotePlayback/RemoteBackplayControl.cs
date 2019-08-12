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

        

        private DateTime currentPositionDateTime;

        public DateTime CurrentPositionDateTime
        {
            get
            {
                return currentPositionDateTime;
            }
            set
            {
                SetCurrentPositionDateTime(value);
            }
        }

        public void SetCurrentPositionDateTime(DateTime value)
        {
            if (CurrentRemoteBackplayInfo == null)
            {
                return;
            }
            currentPositionDateTime = value;
            long lStart = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(CurrentRemoteBackplayInfo.StartTime);
            long lEnd = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(CurrentRemoteBackplayInfo.EndTime);
            long Temp_value1 = lEnd - lStart;
            long Temp_setValue = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(value);
            long Temp_value2 = Temp_setValue - lStart;
            double Temp_dbl = (double)Temp_value2 / Temp_value1;
            int Temp_int = Convert.ToInt32(proportionInfo.Width * Temp_dbl);
            proportionInfo.Location = new Point { X = pnlFlag.Location.X - Temp_int, Y=proportionInfo.Location.Y };
            toolTip1.Show(value.ToString("MM-dd HH:mm:ss"), pnlFlag, 3000);
            SetRemoteBackplayInfo(CurrentRemoteBackplayInfo);
            if (PositionDateTimeChangedEvent != null)
            {
                PositionDateTimeChangedEvent(this, null);
            }
        }

        public delegate void PositionDateTimeChangedDelegate (object sender ,object PositionDateTimeChangedDelegateValue);

        public event PositionDateTimeChangedDelegate PositionDateTimeChangedEvent;






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

            proportionInfo.SetRemoteBackplayInfo(value);
            if (currentRemoteBackplayInfo != value)
            {
                currentRemoteBackplayInfo = value;
                proportionInfo.SetRemoteBackplayInfo_Scale(this.Width / 6);
            }
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
            proportionInfo.Width = this.Width;
            proportionInfo.Height = this.Height - 12;
            intInitialWidth = proportionInfo.Width;
            proportionInfo.MouseWheel += RemoteBackplayProportionControl1_MouseWheel;
        }


        bool bolFlag1 = false;
        int Temp_intX = 0;
        private void RemoteBackplayProportionControl1_MouseDown(object sender, MouseEventArgs e)
        {
            bolFlag1 = true;
            Temp_intX = e.X;
        }

        private void RemoteBackplayProportionControl1_MouseUp(object sender, MouseEventArgs e)
        {
            bolFlag1 = false;
            DateTime timSet = GetFlagDateTime();
            //如果文件头尾超过中间，复位
            if (proportionInfo.Location.X > pnlFlag.Location.X)
            {
                //起始事件超过中间线
                //proportionInfo.Location = new Point { X = pnlFlag.Location.X, Y = proportionInfo.Location.Y };
                timSet = currentRemoteBackplayInfo.StartTime;

            }
            else if ((proportionInfo.Location.X + proportionInfo.Width) < pnlFlag.Location.X)
            {
                //终止事件小于中间线
                //proportionInfo.Location = new Point { X = (pnlFlag.Location.X - proportionInfo.Width) + 10, Y = proportionInfo.Location.Y };
                timSet = currentRemoteBackplayInfo.EndTime.AddSeconds(-60);
            }
            CommonMethod.Common.Delay_Millisecond(10);
            SetRemoteBackplayInfo(currentRemoteBackplayInfo);

            //当前中间的时间值
            SetCurrentPositionDateTime(timSet);
        }

        private void RemoteBackplayProportionControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bolFlag1)
            {
                int Temp_intxxx = e.X - Temp_intX;
                proportionInfo.Location = new Point { X = proportionInfo.Location.X + Temp_intxxx, Y = proportionInfo.Location.Y };
                SetRemoteBackplayInfo(currentRemoteBackplayInfo);
            }
        }
        bool bolMouseWheel = false;

        private void RemoteBackplayProportionControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (bolMouseWheel)
            {
                return;
            }
            bolMouseWheel = true;
            DateTime Temp_current = GetFlagDateTime();
            if (e.Delta > 0)
            {
                if (proportionInfo.Width < MaxWitdh)
                {
                    proportionInfo.Width = proportionInfo.Width * 2;
                    SetCurrentPositionDateTime(Temp_current);
                    proportionInfo.SetRemoteBackplayInfo_Scale(this.Width / 6);
                    this.BeginInvoke(new EventHandler(delegate
                    {
                        CommonMethod.Common.Delay_Millisecond(100);
                        SetRemoteBackplayInfo(CurrentRemoteBackplayInfo);
                    }));
                }
            }
            else
            {
                if (proportionInfo.Width > intInitialWidth)
                {
                    proportionInfo.Width = proportionInfo.Width / 2;
                    SetCurrentPositionDateTime(Temp_current);
                    proportionInfo.SetRemoteBackplayInfo_Scale(this.Width / 6);
                    this.BeginInvoke(new EventHandler(delegate
                    {
                        CommonMethod.Common.Delay_Millisecond(100);
                        SetRemoteBackplayInfo(CurrentRemoteBackplayInfo);
                    }));
                }
            }
            bolMouseWheel = false;
        }

        private void ProportionInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int Temp_int = pnlFlag.Location.X - e.X;
            proportionInfo.Location = new Point { X = Temp_int, Y = proportionInfo.Location.Y };
            SetCurrentPositionDateTime(GetFlagDateTime());
        }


        public DateTime GetFlagDateTime()
        {
            int Temp_value = pnlFlag.Location.X - proportionInfo.Location.X;
            long lResult = proportionInfo.Get(Temp_value);
            DateTime tim = VideoCurrencyModule.PubMethod.UnixMillisecondsTimestampToDateTime(lResult);
            return tim;
        }

    }
}
