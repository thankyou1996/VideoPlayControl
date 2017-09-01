using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;
using System.IO;
using System.Threading;

namespace VideoPlayControl
{
    public partial class VideoPlayGroupControls_Basic : UserControl
    {
        #region 全局变量
        /// <summary>
        /// 当前视频信息
        /// </summary>
        public Dictionary<string, PublicClassCurrency.VideoInfo> dicCurrentVideoInfos = new Dictionary<string, VideoInfo>();

        /// <summary>
        /// 当前播放视频设备ID 
        /// </summary>
        public string strCurrentVideoID = "";

        /// <summary>
        /// 当前播放摄像头
        /// </summary>
        public CameraInfo CurrentCameraInfo;

        /// <summary>
        ///  是否显示 SDL状态改变事件
        /// </summary>
        public bool bolDisPlaySDKState = false;

        /// <summary>
        /// 是否显示 SDK回调事件
        /// </summary>
        public bool bolDisplaySDKEvent = false;

        /// <summary>
        /// 是否显示 视频播放状态
        /// </summary>
        public bool bolDisplayVideoEvent = true;

        /// <summary>
        /// 是否需要密码验证
        /// </summary>
        public bool bolPreViewPwdVerify = false;

        /// <summary>
        /// 视频播放设置
        /// </summary>
        public VideoPlaySetting videoPlaySet = new VideoPlaySetting();

        /// <summary>
        /// 自动播放视频
        /// </summary>
        public bool bolAutoPlayVideo = true;
        #endregion


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
        int intx = 0;
        private void VideoPlayGroupControls_Basic_Load(object sender, EventArgs e)
        {
            //Init();
            intx = Thread.CurrentThread.ManagedThreadId;
            videoPlayWindow.SDKEventCallBackEvent += SDKEventCallBackEvent;
            videoPlayWindow.VideoPlayEventCallBackEvent += VideoPlayEventCallBackEvent;
            videoChannelList.ButtonChannel_ClickEvent += VideoChannelListButton_Click;
            videoPTZControl.PTZControlEvent += VideoPTZControl;
        }

        
        #region 事件委托
        /// <summary>
        /// 视频预览密码验证委托
        /// </summary>
        /// <param name="strPreViewPwdVerify"></param>
        /// <returns></returns>
        public delegate bool PreViewPwdVerifyDelegate(object sender,string strPreViewPwdVerify);

        /// <summary>
        /// 视频预览密码验证事件
        /// </summary>
        public event PreViewPwdVerifyDelegate PreViewPwdVerifyEvent;

        /// <summary>
        /// 视频预览密码验证
        /// </summary>
        /// <param name="strPreViewPwdVerify"></param>
        /// <returns></returns>
        public bool PreViewPwdVerify(string strVideoID)
        {
            return PreViewPwdVerifyEvent(this, strVideoID);
        }
        

        #endregion

        /// <summary>
        /// 初始化_视频信息设置
        /// </summary>
        /// <param name="dicVideoInfos"></param>
        public void Init_VideoInfoSet(Dictionary<string, VideoInfo> dicVideoInfos)
        {
            dicCurrentVideoInfos = dicVideoInfos;
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
            cmbVideoList.Items.Clear();
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

            cmbPreset.Items.Clear();
            for (int i = 1; i < 256; i++)
            {
                cmbPreset.Items.Add(i.ToString().PadLeft(2, '0'));
            }
            if (videoPlaySet.PreSetPosi > 0)
            {
                cmbPreset.SelectedIndex = videoPlaySet.PreSetPosi - 1;
            }
        }

        #endregion

        #region 控件回调事件
        /// <summary>
        /// SDK事件回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="evType"></param>
        /// <param name="strTag"></param>
        public void SDKEventCallBackEvent(object sender, Enum_SDKEventType evType,string strTag)
        {
            if (bolDisplaySDKEvent)
            {
                VideoPlayWindow v = (VideoPlayWindow)sender;
                if (!string.IsNullOrEmpty(strTag))
                {
                    DisplayRecord(evType.ToString() + "[" + strTag + "]");
                }
                DisplayRecord(evType.ToString());
            }
        }

        /// <summary>
        /// SDK状态改变回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="videoType"></param>
        /// <param name="sdkState"></param>
        public void SDKStateChangedCallBackEvent(object sender, Enum_SDKState sdkState)
        {
            if (bolDisPlaySDKState)
            {
                VideoPlayWindow v = (VideoPlayWindow)sender;
                DisplayRecord(sdkState.ToString());
            }

        }

        /// <summary>
        /// 视频播放事件回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="evType"></param>
        /// <param name="strTag"></param>
        public void VideoPlayEventCallBackEvent(object sender, Enum_VideoPlayEventType evType)
        {
            if (bolDisplayVideoEvent)
            {
                StringBuilder sbDisplayInfo = new StringBuilder();
                sbDisplayInfo.Append("[");
                if (dicCurrentVideoInfos != null && dicCurrentVideoInfos.ContainsKey(strCurrentVideoID))
                {
                    sbDisplayInfo.Append(dicCurrentVideoInfos[strCurrentVideoID].DVSNumber + "_");
                    sbDisplayInfo.Append(dicCurrentVideoInfos[strCurrentVideoID].DVSName);
                }
                
                if (CurrentCameraInfo != null)
                {
                    sbDisplayInfo.Append("_");
                    sbDisplayInfo.Append(CurrentCameraInfo.Channel + "_");
                    sbDisplayInfo.Append(CurrentCameraInfo.CameraName );
                }
                sbDisplayInfo.Append("]");
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
                    case Enum_VideoPlayEventType.RequestConn:
                        sbDisplayInfo.Append("请求视频连接");
                        break;
                    case Enum_VideoPlayEventType.ConnSuccess:
                        sbDisplayInfo.Append("连接成功,请求视频信息");
                        break;
                    case Enum_VideoPlayEventType.ConnFailed:
                        sbDisplayInfo.Append("连接失败");
                        break;
                    case Enum_VideoPlayEventType.VideoPlay:
                        sbDisplayInfo.Append("正在播放视频");
                        break;
                    case Enum_VideoPlayEventType.RequestVideoTimeout:
                        sbDisplayInfo.Append("请求视频信息超时");
                        break;
                    case Enum_VideoPlayEventType.VideoDeviceNotOnline:
                        sbDisplayInfo.Append("当前设备不在线");
                        break;
                    case Enum_VideoPlayEventType.UserAccessError:
                        sbDisplayInfo.Append("用户信息验证失败");
                        break;
                    
                    default:
                        sbDisplayInfo.Append("未知状态" + evType.ToString());
                        break;
                }
                sbDisplayInfo.Append("[" + videoPlayWindow.intConnCount + "]");
                
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

        /// <summary>
        /// 视频通道点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cameraInfo"></param>
        public void VideoChannelListButton_Click(object sender, CameraInfo cameraInfo)
        {
            videoChannelList.ButtonListBackColorReset();
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
            if (videoPlayWindow.CurrentVideoInfo != null)
            {
                videoPlayWindow.VideoClose();
            }
            CurrentCameraInfo = cameraInfo;
            //if(videoPlayWindow.)
            videoPlayWindow.Init_VideoInfo(dicCurrentVideoInfos[strCurrentVideoID], CurrentCameraInfo, videoPlaySet);
            videoPlayWindow.VideoPlay();
        }

        #endregion

        #region 控件事件

        /// <summary>
        /// 视频设备列表_选中项改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVideolist_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem cmbItem = (ComboBoxItem)cmbVideoList.SelectedItem;
                strCurrentVideoID = Convert.ToString(cmbItem.ItemValue);
                //SetVideoInfoCameraInfo(CurrentVideoInfos[strCurrentVideoID]);
                videoChannelList.Init_SetVideoInfo(dicCurrentVideoInfos[strCurrentVideoID]);
                if (videoPlayWindow.CurrentVideoInfo != null) //关闭视频播放信息
                {
                    videoPlayWindow.VideoClose();
                }
                if (bolPreViewPwdVerify && (!string.IsNullOrEmpty(dicCurrentVideoInfos[strCurrentVideoID].PreviewPwd)))
                {
                    if (!PreViewPwdVerify(strCurrentVideoID))
                    {
                        //密码验证不通过
                        pnlRight_Main.Enabled = false;
                        return;
                    }
                }
                dicCurrentVideoInfos[strCurrentVideoID].PreviewPwd = "";
                pnlRight_Main.Enabled = true;
                if (bolAutoPlayVideo)
                {
                    VideoChannelListButton_Click(videoChannelList.lstbtns[0], (CameraInfo)videoChannelList.lstbtns[0].Tag);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 预置点列表_选中项改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoPlayWindow.VideoPlayState == Enum_VideoPlayState.InPlayState)
            {
                int intPreset = Convert.ToInt32(cmbPreset.Text.ToString());
                videoPlayWindow.SetPresetPosi(intPreset);
            }
        }
         


        #endregion

        #region 公用事件
        /// <summary>
        /// 显示提示信息
        /// </summary>
        /// <param name="strDisplayInfo"></param>
        public void DisplayRecord(string strDisplayInfo)
        {
            this.BeginInvoke(new EventHandler(delegate
            {
                tslblPrompt.Text = strDisplayInfo;
            }));
        }

        /// <summary>
        /// 控件移动事件
        /// </summary>
        public void ControlMove()
        {
            videoPlayWindow.VideoPlayWindows_Move();
        }

        
        /// <summary>
        ///  播放视频
        ///  1 正常播放
        ///  -1 不存在视频设备
        ///  -2 不存在通道号
        /// </summary>
        /// <param name="strVideoID"></param>
        /// <param name="intChannel"></param>
        /// <returns></returns>
        public int VideoPlay(string strVideoID="", int intChannel=-1)
        {
            int intResult = 1;
            if (!dicCurrentVideoInfos.ContainsKey(strVideoID))
            {
                //不存在视频设备
                intResult = - 1;
            }
            else if (!dicCurrentVideoInfos[strVideoID].Cameras.ContainsKey(intChannel))
            {
                //不存在通道号
                intResult = - 2;
            }
            if (!string.IsNullOrEmpty(strVideoID))
            {
                for (int i = 0; i < cmbVideoList.Items.Count; i++)
                {
                    if (((ComboBoxItem)cmbVideoList.Items[i]).ItemValue.ToString() == strVideoID)
                    {
                        cmbVideoList.SelectedIndex = i;
                        break;
                    }
                }
            }
            bool bolFlag = true;
            if (intChannel == -1)
            {
                VideoChannelListButton_Click(videoChannelList.lstbtns[0], (CameraInfo)videoChannelList.lstbtns[0].Tag);
                bolFlag = false;
            }
            else
            {
                foreach (Button btn in videoChannelList.lstbtns)
                {
                    CameraInfo c = (CameraInfo)btn.Tag;
                    if (c.Channel == intChannel)
                    {
                        VideoChannelListButton_Click(btn, c);
                        bolFlag = false;
                        break;
                    }
                }
            }
            if (bolFlag)
            {
                //无选中通道播放第一通道
                VideoChannelListButton_Click(videoChannelList.lstbtns[0], (CameraInfo)videoChannelList.lstbtns[0].Tag);
            }
            //Directory.CreateDirectory
            return intResult;
        }
        #endregion
        #region 控件外部事件
        /// <summary>
        /// 控件关闭事件
        /// </summary>
        public void ControlClose()
        {
            videoPlayWindow.VideoPlayWindows_Close();
        }

        #endregion


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
