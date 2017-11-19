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

namespace VideoPlayControl_UseDemo
{
    public partial class FrmVideoInfoList : Form
    {
        public FrmVideoInfoList()
        {
            InitializeComponent();
        }

        private void FrmVideoInfoList_Load(object sender, EventArgs e)
        {
            Test();
        }

        public void Test()
        {
            //X5014851
            //X6937816
            //X7438372
            //X5796224
            //X4659975
            //X6227077
            //X6944415
            //X7325728
            //X12041891
            //X7635198
            Dictionary<string, VideoInfo> dicVideoInfos = new Dictionary<string, VideoInfo>();
            //dicVideoInfos=


            VideoInfo videoInfo = new VideoInfo();
            CameraInfo camerasInfo = new CameraInfo();
            videoInfo.VideoType = Enum_VideoType.CloundSee;
            videoInfo.DVSNumber = "000101";
            videoInfo.DVSName = "000101视频";
            videoInfo.DVSAddress = "X5014851";
            //videoInfo.DVSAddress = "720274352";
            //videoInfo.DVSAddress = "532446995";
            //videoInfo.DVSAddress = "797085722";
            //videoInfo.DVSAddress = "607669776";
            videoInfo.DVSConnectPort = 9101;
            videoInfo.UserName = "admin";
            videoInfo.Password = "JHESSY";
            videoInfo.PreviewPwd = "";
            videoInfo.DVSType = "SK85016YS";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 16;
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
            videoInfo.VideoType = Enum_VideoType.CloundSee;
            videoInfo.DVSNumber = "000102";
            videoInfo.DVSName = "000102视频";
            //videoInfo.DVSAddress = "X7656498";
            videoInfo.DVSAddress = "X15987";
            videoInfo.DVSConnectPort = 9101;
            videoInfo.UserName = "admin";
            videoInfo.Password = "12345";
            videoInfo.PreviewPwd = "12345";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 5;
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
            videoInfo.VideoType = Enum_VideoType.CloundSee;
            videoInfo.DVSNumber = "000103";
            videoInfo.DVSName = "000103视频";
            //videoInfo.DVSAddress = "X6392641";
            //videoInfo.DVSAddress = "X7591643";
            videoInfo.DVSConnectPort = 9010;
            videoInfo.UserName = "admin";
            videoInfo.Password = "12345";
            videoInfo.PreviewPwd = "123456";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 5;
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
            videoInfo.VideoType = Enum_VideoType.CloundSee;
            videoInfo.DVSNumber = "000104";
            videoInfo.DVSName = "000104视频";
            //videoInfo.DVSAddress = "X12042037";
            videoInfo.DVSAddress = "X6392641";
            videoInfo.DVSConnectPort = 9010;
            videoInfo.UserName = "admin";
            videoInfo.Password = "123";
            videoInfo.PreviewPwd = "12345";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 5;
            camerasInfo = new CameraInfo();
            for (int i = 0; i < videoInfo.DVSChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                videoInfo.Cameras[i] = camerasInfo;
            }
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;

            videoPlayGroupControls_VideoInfoList11.Init_SetVideoListInfo(dicVideoInfos);
        }
    }
}
