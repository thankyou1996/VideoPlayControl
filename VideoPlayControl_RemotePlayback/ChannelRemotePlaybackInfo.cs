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
    public partial class ChannelRemotePlaybackInfo : UserControl
    {
        public ChannelRemotePlaybackInfo()
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

        private VideoChannelRemotePlaybackInfo currentRemotePlaybackInfo;

        public VideoChannelRemotePlaybackInfo CurrentRemotePlaybackInfo
        {
            get { return currentRemotePlaybackInfo; }
            set
            {
                SetRemotePlaybackInfo(value);
            }
        }

        public void SetRemotePlaybackInfo(VideoChannelRemotePlaybackInfo value)
        {
            currentRemotePlaybackInfo = value;
            if (value != null)
            {
                chkChannel.Text = "通道" + value.ChnnelInfo.Channel;
                proportionInfo.SetRemotePlaybackInfo(value);
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
