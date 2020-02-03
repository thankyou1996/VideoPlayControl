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
using VideoPlayControl.VideoTalk;

namespace VideoPlayControl
{
    public partial class VideoTalkControlManyChannel : UserControl, IVideoTalk
    {

        public TalkSetting CurrentTalkSetting
        {
            get { return videoTalkControl1.CurrentTalkSetting; }
            set { videoTalkControl1.CurrentTalkSetting = value; }
        }

        public VideoInfo CurrentVideoInfo { get => ((IVideoTalk)videoTalkControl1).CurrentVideoInfo; set => ((IVideoTalk)videoTalkControl1).CurrentVideoInfo = value; }
        public VideoTalkChannelInfo CurrentTalkChannel { get => ((IVideoTalk)videoTalkControl1).CurrentTalkChannel; set => ((IVideoTalk)videoTalkControl1).CurrentTalkChannel = value; }
        public Enum_TalkStatus CurrentTalkStatus { get => ((IVideoTalk)videoTalkControl1).CurrentTalkStatus; set => ((IVideoTalk)videoTalkControl1).CurrentTalkStatus = value; }

        public VideoTalkControlManyChannel()
        {
            InitializeComponent();
        }



        public event TalkStausChangedDelegate TalkStausChangedEvent
        {
            add
            {
                ((IVideoTalk)videoTalkControl1).TalkStausChangedEvent += value;
            }

            remove
            {
                ((IVideoTalk)videoTalkControl1).TalkStausChangedEvent -= value;
            }
        }

        public event StartTalkingDelegate StartTalkingEvent
        {
            add
            {
                ((IVideoTalk)videoTalkControl1).StartTalkingEvent += value;
            }

            remove
            {
                ((IVideoTalk)videoTalkControl1).StartTalkingEvent -= value;
            }
        }

        public event StartTalkedDelegate StartTalkedEvent
        {
            add
            {
                ((IVideoTalk)videoTalkControl1).StartTalkedEvent += value;
            }

            remove
            {
                ((IVideoTalk)videoTalkControl1).StartTalkedEvent -= value;
            }
        }

        public event StopTalkedDelegate StopTalkedEvent
        {
            add
            {
                ((IVideoTalk)videoTalkControl1).StopTalkedEvent += value;
            }

            remove
            {
                ((IVideoTalk)videoTalkControl1).StopTalkedEvent -= value;
            }
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

        public bool TalkStausChanged(object TalkStausChangedValue)
        {
            return ((IVideoTalk)videoTalkControl1).TalkStausChanged(TalkStausChangedValue);
        }

        public bool StartTalking(object StartTalkingValue)
        {
            return ((IVideoTalk)videoTalkControl1).StartTalking(StartTalkingValue);
        }

        public bool StopTalked(object StopTalkedValue)
        {
            return ((IVideoTalk)videoTalkControl1).StopTalked(StopTalkedValue);
        }

        public bool SetVideoTalkInfo(VideoInfo videoInfo, VideoTalkChannelInfo talkChannel)
        {
            return ((IVideoTalk)videoTalkControl1).SetVideoTalkInfo(videoInfo, talkChannel);
        }

        public bool StartTlak(Enum_TalkModel talkModel)
        {
            return ((IVideoTalk)videoTalkControl1).StartTlak(talkModel);
        }

        public bool StopTalk()
        {
            return ((IVideoTalk)videoTalkControl1).StopTalk();
        }

        public bool StartTalk(TalkSetting ts)
        {
            return ((IVideoTalk)videoTalkControl1).StartTalk(ts);
        }
    }
}
