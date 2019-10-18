using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl.VideoTalk;

namespace VideoPlayControl_UseDemo.TalkTest
{
    public partial class FrmTalkTest_SK : Form
    {
        public FrmTalkTest_SK()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 设备对讲对象
        /// </summary>
        IVideoTalk videoTalk = new VideoTalk_Shike();
        private void FrmTalkTest_SK_Load(object sender, EventArgs e)
        {
            VideoPlayControl.SDKState.SKVideoSDKInit("xxxx", "117.27.157.39");
            VideoInfo vInfo = TestDataSource.SKDataSource.GetSKData_8519B();
            videoTalk.SetVideoTalkInfo(vInfo, vInfo.TalkChannel.First().Value);
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            videoTalk.CurrentTalkSetting.TalkRecordEnable = true;
            videoTalk.StartTlak(VideoPlayControl.VideoBasicClass.Enum_TalkModel.Talkback);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            videoTalk.StopTalk();
        }
    }
}
