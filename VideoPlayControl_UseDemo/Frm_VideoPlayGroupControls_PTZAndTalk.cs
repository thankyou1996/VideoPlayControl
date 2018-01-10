using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoPlayControl;

namespace VideoPlayControl_UseDemo
{
    public partial class Frm_VideoPlayGroupControls_PTZAndTalk : Form
    {
        public Frm_VideoPlayGroupControls_PTZAndTalk()
        {
            InitializeComponent();
        }

        private void Frm_VideoPlayGroupControls_PTZAndTalk_Load(object sender, EventArgs e)
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
            SDKState.CloundSee_SDKInit();
            SDKState.Ezviz_SDKInit();
            SDKState.SKVideoSDKInit(ProgParameter.uintSKVideo_AVPort, ProgParameter.strSKVideo_ClientUGID, ProgParameter.strSKVideo_ServerIP, ProgParameter.uintSKVideo_ControlPort, ProgParameter.uintSKVideo_VideoPort, ProgParameter.uintSKVideo_AudioPort, "");
            //SDKState.SKVideoSDKInit(ProgParameter.uintSKVideo_AVPort, ProgParameter.strSKVideo_ClientUGID, "192.168.2.10", ProgParameter.uintSKVideo_ControlPort, ProgParameter.uintSKVideo_VideoPort, ProgParameter.uintSKVideo_AudioPort, "");

            SetTestData_ZWVideoAndSKTalk();
        }

        #region 测试数据
        public void SetTestData_ZWVideoAndSKTalk()
        {
            Dictionary<string, VideoInfo> dicVideoInfos = new Dictionary<string, VideoInfo>();
            VideoInfo videoInfo = new VideoInfo();
            CameraInfo camerasInfo = new CameraInfo();
            videoInfo.VideoType = Enum_VideoType.CloundSee;
            videoInfo.DVSNumber = "000101";
            videoInfo.DVSName = "ZW视频";
            videoInfo.DVSAddress = "X5014851";
            videoInfo.DVSConnectPort = 9101;
            videoInfo.UserName = "admin";
            videoInfo.Password = "JHESSY";
            videoInfo.PreviewPwd = "";
            videoInfo.DVSType = "SK8501ZW";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 8;
            camerasInfo = new CameraInfo();
            for (int i = 1; i < videoInfo.DVSChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                videoInfo.Cameras[i] = camerasInfo;
            }
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;


            videoInfo = new VideoInfo();
            videoInfo.VideoType = Enum_VideoType.SKVideo;
            videoInfo.DVSNumber = "000102";
            videoInfo.DVSName = "SK519V";
            videoInfo.DVSType = "SK519V";
            //videoInfo.DVSAddress = "61-B5513D572279-4E54";
            //videoInfo.DVSAddress = "61-3E477829FE12-4EF4";
            videoInfo.DVSAddress = "71-00F51F012D0C-2830";
            videoInfo.DVSConnectPort = 9101;
            videoInfo.UserName = "admin";
            videoInfo.Password = "12345";
            videoInfo.PreviewPwd = "";
            videoInfo.IntercomEnable = true;
            videoInfo.OnlyIntercom = false;
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 16;
            camerasInfo = new CameraInfo();
            for (int i = 0; i < videoInfo.DVSChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                videoInfo.Cameras[i] = camerasInfo;
            }
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;

            videoInfo = new VideoInfo();
            videoInfo.VideoType = Enum_VideoType.SKVideo;
            videoInfo.DVSNumber = "000103";
            videoInfo.DVSName = "SK8604";
            videoInfo.DVSType = "SK8604";
            videoInfo.DVSAddress = "61-573539920B39-3036";
            videoInfo.DVSConnectPort = 9101;
            videoInfo.UserName = "admin";
            videoInfo.Password = "12345";
            videoInfo.PreviewPwd = "";
            videoInfo.IntercomEnable = true;
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 16;
            camerasInfo = new CameraInfo();
            for (int i = 0; i < videoInfo.DVSChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                videoInfo.Cameras[i] = camerasInfo;
            }
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;

            videoPlayGroupControls_PTZAndTalk1.bolPreViewPwdVerify = false;
            videoPlayGroupControls_PTZAndTalk1.PreViewPwdVerifyEvent += PreViewPwdVerify;
            videoPlayGroupControls_PTZAndTalk1.Init_VideoInfoSet(dicVideoInfos);
        }
        #endregion

        public bool PreViewPwdVerify(object sender, string strVideoID)
        {
            VideoPlayGroupControls_PTZAndTalk v = (VideoPlayGroupControls_PTZAndTalk)sender;
            if (v.dicCurrentVideoInfos[strVideoID].PreviewPwd == "123456")
            {
                return true;
            }
            return false;
        }

        private void Frm_VideoPlayGroupControls_PTZAndTalk_Move(object sender, EventArgs e)
        {
            videoPlayGroupControls_PTZAndTalk1.ControlMove();
        }
    }
}
