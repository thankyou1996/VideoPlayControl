using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl
{
    public partial class VideoTalkControlManyChannel : UserControl
    {

        public TalkSetting CurrentTalkSetting
        {
            get { return videoTalkControl1.CurrentTalkSetting; }
            set { videoTalkControl1.CurrentTalkSetting = value; }
        }
        public VideoTalkControlManyChannel()
        {
            InitializeComponent();
        }


        public event StartTalkingDelegate StartTalkingEvent
        {
            add { videoTalkControl1.StartTalkingEvent += value; }
            remove { videoTalkControl1.StartTalkingEvent -= value; }
        }

        Dictionary<string, VideoInfo> CurrentVideoInfos = new Dictionary<string, VideoInfo>();

        public bool SetVideoInfo(Dictionary<string, VideoInfo> dicVideoInfo)
        {
            bool bolResult = false;
            DataTable dtSource = new DataTable();
            dtSource.Columns.Add("Value");
            dtSource.Columns.Add("Display");
            CurrentVideoInfos = dicVideoInfo;
            foreach (VideoInfo v in CurrentVideoInfos.Values)
            {
                foreach (VideoTalkChannelInfo vc in v.TalkChannel.Values)
                {
                    DataRow dr = dtSource.NewRow();
                    //仅在此控件使用，数据源使用拼接获取 较为方便
                    dr["Value"] = v.DVSNumber + "_" + vc.VideoTalkChannel;  
                    dr["Display"] = vc.VideoTalkChannelName;
                    dtSource.Rows.Add(dr);
                    bolResult = true;   //代表有数据
                }
            }
            cmbVideoChannel.ValueMember = "Value";
            cmbVideoChannel.DisplayMember = "Display";
            cmbVideoChannel.DataSource = dtSource;
            if (bolResult)
            {
                //设置默认
                cmbVideoChannel.SelectedIndex = 0;
            }
            return bolResult;
        }

        private void cmbVideoChannel_SelectedValueChanged(object sender, EventArgs e)
        {
            string strTalkChannelInfo = Convert.ToString(cmbVideoChannel.SelectedValue);
            if (!string.IsNullOrEmpty(strTalkChannelInfo))
            {
                string Temp_strVideoID = strTalkChannelInfo.Split('_')[0];
                int Temp_intTalkChannel = Convert.ToInt32(strTalkChannelInfo.Split('_')[1]);
                videoTalkControl1.SetVideoTalkInfo(CurrentVideoInfos[Temp_strVideoID], CurrentVideoInfos[Temp_strVideoID].TalkChannel[Temp_intTalkChannel]);
            }
        }
        public void ControlColse()
        {
            videoTalkControl1.StopTalk();
        }
    }
}
