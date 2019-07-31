using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using VideoPlayControl;
using VideoPlayControl.VideoTalk;

namespace VideoPlayControl_UseDemo
{
    public partial class FrmTalkControlTest : Form
    {
        public FrmTalkControlTest()
        {
            InitializeComponent();
        }

        private void FrmTalkControlTest_Load(object sender, EventArgs e)
        {
            PublicClassCurrency.VideoInfo v = TestDataSource.SKDataSource.GetSKData_TalkData();
            videoTalkControl1.SetVideoTalkInfo(v, v.TalkChannel[1]);
            videoTalkControl1.StartTalkingEvent += VideoTalkControl1_StartTalkingEvent;
            
            ProgParameter.strHikStreamVoiceIP = "192.168.2.19";
            ProgParameter.intHikStreamVoiceServerPort = 8081;
            ProgParameter.intHikStreamVoiceClientPort = 8082;
            //SDKState.HikDVRSDKStream_Init();
            SDKState.SKVideoSDKInit("hdc","192.168.2.19");
            //while (SDK_SKVideoSDK.p_sdkc_get_online() == 1)
            //{
            //    Thread.Sleep(30);
            //}
            Dictionary<string, VideoInfo> dicV = new Dictionary<string, VideoInfo>();
            dicV[v.DVSNumber] = v;
            videoTalkControlManyChannel1.SetVideoInfo(dicV);
        }

        private bool VideoTalkControl1_StartTalkingEvent(object sneder, object StartTalkBeginValue)
        {
            bool bolResult = false;
            IVideoTalk iv = (IVideoTalk)sneder;
            MessageBox.Show(iv.CurrentTalkChannel.VideoTalkChannelName + "开始对讲");



            return bolResult;
            //throw new NotImplementedException();
        }

        private void videoTalkControl1_Load(object sender, EventArgs e)
        {
            videoTalkControlManyChannel1.StartTalkingEvent += VideoTalkControlManyChannel1_StartTalkingEvent;
        }

        private bool VideoTalkControlManyChannel1_StartTalkingEvent(object sneder, object StartTalkBeginValue)
        {
            bool bolResult = false;
            IVideoTalk iv = (IVideoTalk)sneder;
            //MessageBox.Show(iv.CurrentTalkChannel.VideoTalkChannelName + "开始对讲");
            videoTalkControlManyChannel1.CurrentTalkSetting.TalkRecordEnable = true;

            videoTalkControlManyChannel1.CurrentTalkSetting.TalkRecordPath_Local = @"C:\SHIKE_TalkRecord\2019\7\27";
            videoTalkControlManyChannel1.CurrentTalkSetting.TalkRecordName_Local = DateTime.Now.ToString("yyyyMMddHHmmss") + ".G711";
            return bolResult;
        }

        private void videoTalkControlManyChannel1_Load(object sender, EventArgs e)
        {

        }
    }
}
