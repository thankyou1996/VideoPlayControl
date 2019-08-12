using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VideoCurrencyModule.RemotePlayback;

namespace VideoPlayControl_RemotePlayback
{
    public partial class ChannelRemoteBackplayInfo : UserControl
    {
        public ChannelRemoteBackplayInfo()
        {
            InitializeComponent();
        }

        private void ChannelRemoteBackplayInfo_Load(object sender, EventArgs e)
        {
            proportionInfo.Paint += ProportionInfo_Paint ;
        }

        private void ProportionInfo_Paint(object sender, PaintEventArgs e)
        {
            this.OnPaint(e);
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
            if (value != null)
            {
                chkChannel.Text = "通道" + value.ChnnelInfo.Channel;
                proportionInfo.SetRemoteBackplayInfo(value);
            }
        }

        public event EventHandler CheckedChanged;

        private void ChkChannel_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckedChanged != null)
            {
                CheckedChanged(this, e);
            }
        }

        /// <summary>
        /// 选中状态
        /// </summary>
        public bool Checked
        {
            get
            {
                return chkChannel.Checked;
            }
            set
            {
                chkChannel.Checked = value;
            }

        }
    }
}
