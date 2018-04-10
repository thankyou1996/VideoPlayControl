using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl;

namespace VideoPlayControl_UseDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VideoPlayControl.ProgParameter.strEzviz__AppID = "5b97c1d157474f96b8d4c75b936a0057";
            VideoPlayControl.ProgParameter.strEzviz_AppSecret = "4318d0cc4c43ca156052ba688bc9006a";
            videoPlayGroupControls_PTZAndTalk1.bolAutoPlayVideo = true;
            videoPlayGroupControls_PTZAndTalk1.videoPlaySet.VideoRecordEnable = true;
            videoPlayGroupControls_PTZAndTalk1.videoPlaySet.VideoMonitorEnable = true;
            //videoPlayGroupControls_Basic1.videoPlaySet.VideoRecordFilePath = "C:\\SHIKE_Video\\4603\\20170925094530";
            //videoPlayGroupControls_Basic1.bolDisplaySDKEvent = true;
            //videoPlayGroupControls_Basic1.bolDisPlaySDKState = true;
            //videoPlayGroupControls_Basic1.videoPlaySet.PreSetPosi = 13;
            //SDKState.CloundSee_SDKInit();
            //SDKState.Ezviz_SDKInit();
            //SDKState.SKVideoSDKInit();
            //SDKState.HuaMai_Init();
            //SDKState.XMSDK_Release();
            SDKState.XMSDK_Init();
            //SDKState.SKVideoSDKInit(ProgParameter.uintSKVideo_AVPort, ProgParameter.strSKVideo_ClientUGID, "192.168.2.10", ProgParameter.uintSKVideo_ControlPort, ProgParameter.uintSKVideo_VideoPort, ProgParameter.uintSKVideo_AudioPort, "");

            //HuaMaiVideo_TestData();
            Dictionary<string, VideoInfo> dicVideoInfos = new Dictionary<string, VideoInfo>();
            VideoInfo v = TestDataSource.TestDataSource.XMDataSource();
            dicVideoInfos[v.DVSNumber] = v;
            VideoInfo v1 = TestDataSource.TestDataSource.XMDataSource1();
            dicVideoInfos[v1.DVSNumber] = v1;
            videoPlayGroupControls_PTZAndTalk1.bolPreViewPwdVerify = false;
            //videoPlayGroupControls_PTZAndTalk1.PreViewPwdVerifyEvent += PreViewPwdVerify;
            videoPlayGroupControls_PTZAndTalk1.videoPlaySet.VideoRecordEnable = true;
            videoPlayGroupControls_PTZAndTalk1.videoPlaySet.VideoRecordFilePath = Application.StartupPath + "\\AxisVideoRecord";
            videoPlayGroupControls_PTZAndTalk1.Init_VideoInfoSet(dicVideoInfos);
            //videoPlayGroupControls_PTZAndTalk1.VideoPlay("", -1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SDKState.XMSDK_Release();
        }
    }
}
