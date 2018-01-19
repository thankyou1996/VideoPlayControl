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
    public partial class Frm_MulitPicturte : Form
    {
        public VideoInfo CurrentV;
        public Frm_MulitPicturte()
        {
            InitializeComponent();
        }

        private void Frm_MulitPicturte_Load(object sender, EventArgs e)
        {
            //VideoPlayControl.ProgParameter.strEzviz__AppID = "5b97c1d157474f96b8d4c75b936a0057";
            //VideoPlayControl.ProgParameter.strEzviz_AppSecret = "4318d0cc4c43ca156052ba688bc9006a";
            //SDKState.SDKStateChangeEvent += SDKStateChange;
            SDKState.CloundSee_SDKInit();
            SDKState.Ezviz_SDKInit();
            SDKState.SKVideoSDKInit();
            SDKState.HuaMai_Init();

            videoPlayGroupControl_MultiPicture11.SelectedWindowHiglight = true ;
            videoPlayGroupControl_MultiPicture11.AutoSelectedNextWindow = false;
            videoPlayGroupControl_MultiPicture11.SetWindowNum(9);
            CurrentV = TestData_SKData();
        }

        private void btnSetWinNum_Click(object sender, EventArgs e)
        {
            int intNum = Convert.ToInt32(txtWindowNum.Text);
            videoPlayGroupControl_MultiPicture11.SetWindowNum(intNum);
        }

        private void btnCloundSeeData_Click(object sender, EventArgs e)
        {

        }

        private void btnEzvizData_Click(object sender, EventArgs e)
        {

        }

        private void btnSKData_Click(object sender, EventArgs e)
        {
            CurrentV = TestData_SKData();
        }

        private void btnHuaMaiData_Click(object sender, EventArgs e)
        {
            CurrentV = TestData_HuaMaiData();
        }

        #region 测试数据

        public VideoInfo TestData_CloundSeeData()
        {
            VideoInfo v = new VideoInfo();
            return v;
        }

        public VideoInfo TestData_EzvizData()
        {
            VideoInfo v = new VideoInfo();
            return v;
        }

        public VideoInfo TestData_SKData()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.SKVideo;
            v.DVSAddress = "61-573539920B39-3036";
            v.DVSChannelNum = 16;
            v.DVSConnectPort = 81;
            v.DVSName = "8604双网口测试";
            v.DVSNumber = "770701";
            v.DVSType = "SK8616";
            v.HostID = "9994";
            v.Password = "sk123456";
            v.UserName = "admin";
            v.NetworkState = 0;
            for (int i = 0; i < 4; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSAddress = "61-573551920B39-3036";
                c.DVSType = "SK8616";
                c.DVSNumber = "999401";
                v.Cameras[c.Channel] = c;
            }
            for (int i = 8; i < 16; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSAddress = "61-573551920B39-3036";
                c.DVSType = "SK8616";
                c.DVSNumber = "999401";
                v.Cameras[c.Channel] = c;
            }
            return v;
            
        }

        public VideoInfo TestData_SKData(int iIndex)
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.SKVideo;
            v.DVSAddress = "61-573539920B39-3036";
            v.DVSChannelNum = 16;
            v.DVSConnectPort = 81;
            v.DVSName = "8604双网口测试";
            v.DVSNumber = "770701";
            v.DVSType = "SK8616";
            v.HostID = "9994";
            v.Password = "sk123456";
            v.UserName = "admin";
            v.NetworkState = 0;
            CameraInfo c = new CameraInfo();
            c.CameraName = "摄像头" + (iIndex + 1);
            c.Channel = iIndex;
            c.DVSAddress = "61-573551920B39-3036";
            c.DVSType = "SK8616";
            c.DVSNumber = "999401";
            v.Cameras[c.Channel] = c;
            return v;
        }


        public VideoInfo TestData_HuaMaiData()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.HuaMaiVideo;
            v.DVSAddress = "2B9B617805185";
            v.DVSChannelNum = 4;
            v.DVSConnectPort = 81;
            v.DVSName = "华迈云测试";
            v.DVSNumber = "000501";
            v.DVSType = "SK8605HM";
            v.HostID = "0005";
            v.UserName = "admin";
            v.Password = "sk123456";
            v.NetworkState = 0;
            for (int i = 0; i < 4; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSAddress = "E322213C04245";
                c.DVSType = "SK8605HM";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        #endregion

        private void btnSetVideoPlayInfo_Click(object sender, EventArgs e)
        {
            int iChannel = Convert.ToInt32(txtTestDataChannel.Text);
            videoPlayGroupControl_MultiPicture11.SetPlayVideoInfo(CurrentV, iChannel);
        }
        
    }
}
