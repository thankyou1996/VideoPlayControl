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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Init();
        }

        #region 初始化

        public void Init()
        {
            Init_ControlInit();
        }

        public void Init_ControlInit()
        {
            DataTable dtSource = new DataTable();
            //dtSource.
        }
        #endregion






        private void btnVideoPly_Click(object sender, EventArgs e)
        {
            VideoInfo videoInfo = new VideoInfo();
            videoInfo.VideoType = VideoTypeEnum.CloundSee;
            videoInfo.DVSAddress = "X5014851";
            videoInfo.DVSConnectPort = 15851;
            videoInfo.UserName = "admin";
            videoInfo.Password = "123456";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            CameraInfo camerasInfo = new CameraInfo();
            camerasInfo.Channel = 1;
            camerasInfo.CameraName = "通道1";
            videoInfo.Cameras[1] = camerasInfo;
            videoPlayMain1.CloundSee_SDKInit();
            videoPlayMain1.Init_VideoInfo(videoInfo);
            videoPlayMain1.VideoPlay();
        }

        private void FrmMain_Move(object sender, EventArgs e)
        {
            videoPlayMain1.VideoPlayWindows_Move();
        }

        
    }
}
