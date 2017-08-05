using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;

namespace VideoPlayControl
{
    public partial class VideoPlayGroupControls_Basic : UserControl
    {
        /// <summary>
        /// 当前视频信息
        /// </summary>
        public Dictionary<string, PublicClassCurrency.VideoInfo> dicCurrentVideoInfos = new Dictionary<string, VideoInfo>();
        public CameraInfo CurrentCameraInfo;

        public string strCurrentVideoID = "";
        public bool bolDisPlaySDKState = false;
        public bool bolDisplaySDKEvent = false;
        public bool bolDisplayVideoEvent = true;
        public bool bolPreViewPwdVerify = false;

        /// <summary>
        /// 播放视频控件组_基本
        /// </summary>
        public VideoPlayGroupControls_Basic()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 播放视频控件组_基本
        /// </summary>
        public VideoPlayGroupControls_Basic(Dictionary<string, VideoInfo> dicVideoInfos)
        {
            InitializeComponent();
            dicCurrentVideoInfos = dicVideoInfos;
        }

        private void VideoPlayGroupControls_Basic_Load(object sender, EventArgs e)
        {
            //Init();
        }

        
        #region 事件委托
        /// <summary>
        /// 视频预览密码验证委托
        /// </summary>
        /// <param name="strPreViewPwdVerify"></param>
        /// <returns></returns>
        public delegate bool PreViewPwdVerifyDelegate(string strPreViewPwdVerify);

        /// <summary>
        /// 视频预览密码验证事件
        /// </summary>
        public event PreViewPwdVerifyDelegate PreViewPwdVerifyEvent;

        /// <summary>
        /// 视频预览密码验证
        /// </summary>
        /// <param name="strPreViewPwdVerify"></param>
        /// <returns></returns>
        public bool PreViewPwdVerify(string strPreViewPwdVerify)
        {
            if (PreViewPwdVerifyEvent != null)
            {
                return PreViewPwdVerifyEvent(strPreViewPwdVerify);
            }
            return false;
        }

        #endregion

        public void Init_VideoInfoSet(Dictionary<string, VideoInfo> dicVideoInfos)
        {
            dicCurrentVideoInfos = dicVideoInfos;

            //for(int i=0;i<10;i++)
            //{
            //    cmbVideoList.Items.Add(i);

            //}
            Init();
        }

        #region  初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            Init_ControlInit();
        }


        /// <summary>
        ///　初始化_控件初始化 
        /// </summary>
        public void Init_ControlInit()
        {
            videoPlayWindow.SDKEventCallBackEvent += SDKEventCallBackEvent;
            videoPlayWindow.SDKStateChangedCallBackEvent += SDKStateChangedCallBackEvent;
            videoPlayWindow.VideoPlayEventCallBackEvent += VideoPlayEventCallBackEvent;
            videoChannelList.ButtonChannel_ClickEvent += VideoChannelListButton_Click;
            videoPlayWindow.CloundSee_SDKInit();
            videoPTZControl.PTZControlEvent += VideoPTZControl;

            if (dicCurrentVideoInfos.Count > 0)
            {
                ComboBoxItem cmbItem;
                foreach (KeyValuePair<string, PublicClassCurrency.VideoInfo> kv in dicCurrentVideoInfos)
                {
                    cmbItem = new ComboBoxItem(kv.Key, kv.Value.DVSName);
                    cmbVideoList.Items.Add(cmbItem);
                }
                cmbVideoList.SelectedIndexChanged += cmbVideolist_SelectedIndexChanged;
                cmbVideoList.SelectedIndex = 0;
            }
            
            for (int i = 1; i < 256; i++)
            {
                cmbPreset.Items.Add(i.ToString().PadLeft(2, '0'));
            }
            cmbPreset.SelectedIndex = 0;
        }

        #endregion

        public void SDKEventCallBackEvent(object sender, Enum_SDKEventType evType, string strTag)
        {
            if (bolDisplaySDKEvent)
            {
                VideoPlayWindow v = (VideoPlayWindow)sender;
                DisplayRecord(strTag);
            }

        }

        public void SDKStateChangedCallBackEvent(object sender, Enum_VideoType videoType, Enum_SDKState sdkState)
        {
            if (bolDisPlaySDKState)
            {
                VideoPlayWindow v = (VideoPlayWindow)sender;
                DisplayRecord(videoType.ToString() + "_" + sdkState.ToString() + v.Name + "_SDK状态");
            }

        }

        public void VideoPlayEventCallBackEvent(object sender, Enum_VideoPlayEventType evType, string strTag)
        {
            if (bolDisplayVideoEvent)
            {
                StringBuilder sbDisplayInfo = new StringBuilder();
                sbDisplayInfo.Append("[" + dicCurrentVideoInfos[strCurrentVideoID].DVSNumber + "_");
                sbDisplayInfo.Append(dicCurrentVideoInfos[strCurrentVideoID].DVSName + "_");
                sbDisplayInfo.Append(CurrentCameraInfo.Channel + "_");
                sbDisplayInfo.Append(CurrentCameraInfo.CameraName + "]");

                switch (evType)
                {
                    case Enum_VideoPlayEventType.InitEnd:
                        sbDisplayInfo.Append("控件初始化完成");
                        break;
                    case Enum_VideoPlayEventType.LoadEnd:
                        sbDisplayInfo.Append("控件加载完成");
                        break;
                    case Enum_VideoPlayEventType.SetVideoInfo:
                        sbDisplayInfo.Append("设置视频播放信息");
                        break;
                    case Enum_VideoPlayEventType.VideoTypeNotExists:
                        sbDisplayInfo.Append("视频类型不存在");
                        break;
                    case Enum_VideoPlayEventType.VideoClose:
                        sbDisplayInfo.Append("关闭视频");
                        break;
                    case Enum_VideoPlayEventType.RequestVideo:
                        sbDisplayInfo.Append("请求视频信息");
                        break;
                    case Enum_VideoPlayEventType.VideoPlay:
                        sbDisplayInfo.Append("正在播放视频");
                        break;

                    default:
                        sbDisplayInfo.Append("未知状态" + evType.ToString());
                        break;
                }
                DisplayRecord(sbDisplayInfo.ToString());
            }

        }


        /// <summary>
        /// 云台控制
        /// </summary>
        /// <param name="PTZControlCmd"></param>
        /// <param name="bolStart"></param>
        public void VideoPTZControl(Enum_VideoPTZControl PTZControlCmd, bool bolStart)
        {
            videoPlayWindow.VideoPTZControl(PTZControlCmd, bolStart);
        }

        public void VideoChannelListButton_Click(object sender, CameraInfo cameraInfo)
        {
            videoChannelList.ButtonListBackColorReset();
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
            VideoPlaySetting videoPlaySet = new VideoPlaySetting();
            if (videoPlayWindow.CurrentVideoInfo != null)
            {
                videoPlayWindow.VideoClose();
            }
            CurrentCameraInfo = cameraInfo;
            videoPlayWindow.Init_VideoInfo(dicCurrentVideoInfos[strCurrentVideoID], cameraInfo, videoPlaySet);
            videoPlayWindow.VideoPlay();
        }

        private void cmbVideolist_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem cmbItem = (ComboBoxItem)cmbVideoList.SelectedItem;
                //CurrentVideoInfo = (PublicClassCurrency.VideoInfo)cmbItem.ItemValue;
                strCurrentVideoID = Convert.ToString(cmbItem.ItemValue);
                //SetVideoInfoCameraInfo(CurrentVideoInfos[strCurrentVideoID]);
                videoChannelList.Init_SetVideoInfo(dicCurrentVideoInfos[strCurrentVideoID]);
                if (videoPlayWindow.CurrentVideoInfo != null) //关闭视频播放信息
                {
                    videoPlayWindow.VideoClose();
                }

                if (bolPreViewPwdVerify&&(!string.IsNullOrEmpty(dicCurrentVideoInfos[strCurrentVideoID].PreviewPwd)))
                {
                    //触发验证事件
                    if (PreViewPwdVerify(dicCurrentVideoInfos[strCurrentVideoID].PreviewPwd))
                    {
                        //密码验证不通过
                        pnlRight_Main.Enabled = false;
                        return;
                    }
                }
                dicCurrentVideoInfos[strCurrentVideoID].PreviewPwd = "";    //仅第一次验证
                pnlRight_Main.Enabled = true;
                VideoChannelListButton_Click(videoChannelList.lstbtns[0], (CameraInfo)videoChannelList.lstbtns[0].Tag);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void DisplayRecord(string strDisplayInfo)
        {
            tslblPrompt.Text = strDisplayInfo;
        }

        private void cmbPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoPlayWindow.VideoPlayState == Enum_VideoPlayState.InPlayState)
            {
                int intPreset = Convert.ToInt32(cmbPreset.Text.ToString());
                videoPlayWindow.SetPresetPosi(intPreset);
            }
        }
    }
    /// <summary>
    /// 170120 ComboBox Item
    /// value 表示键 display表示显示的值
    /// </summary>
    public class ComboBoxItem
    {
        /// <summary>
        /// ComboBox控件Item
        /// </summary>
        /// <param name="value"></param>
        /// <param name="display"></param>
        public ComboBoxItem(object value, string display)
        {
            this.ItemValue = value;
            this.ItemDisplay = display;
        }

        /// <summary>
        /// Item 键
        /// </summary>
        object itemValue;

        /// <summary>
        /// Item 键
        /// </summary>
        public object ItemValue
        {
            get { return itemValue; }
            set { itemValue = value; }
        }

        /// <summary>
        /// Item 值
        /// </summary>
        string itemDisplay;
        /// <summary>
        /// Item 值
        /// </summary>
        public string ItemDisplay
        {
            get { return itemDisplay; }
            set { itemDisplay = value; }
        }

        /// <summary>
        /// 重写 ToString() 方法
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ItemDisplay;
        }
    }

}
