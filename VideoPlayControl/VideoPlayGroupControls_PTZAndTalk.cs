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
using static CommonMethod.CommonObject;
using VideoPlayControl.VideoBasicClass;
using VideoPlayControl.VideoTalk;
using VideoPlayControl.VideoPlay;

namespace VideoPlayControl
{
    public partial class VideoPlayGroupControls_PTZAndTalk : UserControl
    {
        public TalkSetting CurrentTalkSetting
        {
            get { return videoTalkControlManyChannel1.CurrentTalkSetting; }
            set { videoTalkControlManyChannel1.CurrentTalkSetting = value; }
        }

        #region 全局变量
        /// <summary>
        /// 当前视频信息
        /// </summary>
        public Dictionary<string, VideoInfo> dicCurrentVideoInfos = new Dictionary<string, VideoInfo>();

        /// <summary>
        /// 当前播放视频设备ID 
        /// </summary>
        public string strCurrentVideoID = "";

        /// <summary>
        /// 当前播放摄像头
        /// </summary>
        public CameraInfo CurrentCameraInfo;

        /// <summary>
        ///  是否显示 SDK状态改变事件
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


        string strTalkVideoNum = "";

        /// <summary>
        /// 播放视频控件组_基本
        /// </summary>
        public VideoPlayGroupControls_PTZAndTalk()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 播放视频控件组_基本
        /// </summary>
        public VideoPlayGroupControls_PTZAndTalk(Dictionary<string, VideoInfo> dicVideoInfos)
        {
            InitializeComponent();
            dicCurrentVideoInfos = dicVideoInfos;
        }
        private void VideoPlayGroupControls_Basic_Load(object sender, EventArgs e)
        {
            videoPlayWindow.VideoPlayCallbackEvent += VideoPlayEventCallBackEvent;
            videoPTZControl.PTZControlEvent += VideoPTZControl;
            videoTalkControlManyChannel1.StartTalkingEvent += VideoTalkControlManyChannel1_StartTalkingEvent;
        }

        /// <summary>
        /// 开始对讲前事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="StartTalkBeginValue"></param>
        /// <returns></returns>
        private bool VideoTalkControlManyChannel1_StartTalkingEvent(object sender, object StartTalkBeginValue)
        {
            bool bolResult = false;
            IVideoTalk ivt = (IVideoTalk)sender;
            //对讲前主动关闭声音音频输出，避免程序出现枭叫声
            videoPlayWindow.CloseSound();
            return bolResult;
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
        /// <param name="strVideoID"></param>
        /// <returns></returns>
        public bool PreViewPwdVerify(string strVideoID)
        {
            return PreViewPwdVerifyEvent(this, strVideoID);
        }

        /// <summary>
        /// 对讲开始时事件
        /// </summary>
        public event StartTalkingDelegate StartTalkingEvent
        {
            add { videoTalkControlManyChannel1.StartTalkingEvent += value; }
            remove { videoTalkControlManyChannel1.StartTalkingEvent -= value; }
        }
        private event VideoPlayCallbackDelegate videoPlayCallbaclEvent;
        /// <summary>
        /// 视频播放回调事件
        /// </summary>
        public event VideoPlayCallbackDelegate VideoPlayCallbackEvent
        {
            add
            {
                videoPlayWindow.VideoPlayCallbackEvent += value;
                videoPlayCallbaclEvent += value;
            }
            remove
            {
                videoPlayWindow.VideoPlayCallbackEvent -= value;
                videoPlayCallbaclEvent -= value;
            }
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
            Init_ControlInit1();
        }


        /// <summary>
        ///　初始化_控件初始化 
        /// </summary>
        public void Init_ControlInit()
        {
            cmbVideoList.Items.Clear();
            if (dicCurrentVideoInfos.Count > 0)
            {
                cmbVideoList.SelectedIndexChanged -= cmbVideolist_SelectedIndexChanged;     //取消事件（防止出现重复注册情况）
                ComboBoxItem cmbItem;
                foreach (KeyValuePair<string, PublicClassCurrency.VideoInfo> kv in dicCurrentVideoInfos)
                {
                    cmbItem = new ComboBoxItem(kv.Key, kv.Value.DVSName);
                    cmbVideoList.Items.Add(cmbItem);
                }
                cmbVideoList.SelectedIndexChanged += cmbVideolist_SelectedIndexChanged;     //注册事件
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

        public void Init_ControlInit1()
        {
            cmbVideoList.Items.Clear();
            //设备列表
            cmbVideoList.SelectedIndexChanged -= cmbVideolist_SelectedIndexChanged;     //取消事件（防止出现重复注册情况）
            ComboBoxItem cmbItem;
            foreach (VideoInfo v in dicCurrentVideoInfos.Values)
            {
                if (!v.OnlyIntercom)
                {
                    cmbItem = new ComboBoxItem(v.DVSNumber, v.DVSName);
                    cmbVideoList.Items.Add(cmbItem);
                }
            }
            if (cmbVideoList.Items.Count > 0)
            {
                cmbVideoList.SelectedIndexChanged += cmbVideolist_SelectedIndexChanged;     //注册事件
                cmbVideoList.SelectedIndex = 0;
            }

            //对讲列表
            bool bolResult = videoTalkControlManyChannel1.SetVideoInfo(dicCurrentVideoInfos);
            pageTalk.Parent = bolResult ? tabToolbar : null;
            #region 云台信息

            bool bolPTZControlEnable = false;
            foreach (VideoInfo v in dicCurrentVideoInfos.Values)
            {
                if (bolPTZControlEnable)
                {
                    break;
                }
                bolPTZControlEnable = v.PTZControlEnable;
            }
            if (bolPTZControlEnable)
            {
                //云台预置点列表
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
            else
            {
                pagePTZControl.Parent = bolPTZControlEnable ? tabToolbar : null;
            }
            #endregion
            pblRight_Bottom.Visible = tabToolbar.TabCount > 0;
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
        private bool VideoPlayEventCallBackEvent(object sender, VideoPlayCallbackValue eventValue)
        {
            bool bolResult = false;
            IVideoPlay v = (IVideoPlay)sender;
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
                switch (eventValue.evType)
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
                    case Enum_VideoPlayEventType.VideoPlayException:
                        sbDisplayInfo.Append("视频播放异常");
                        break;
                    case Enum_VideoPlayEventType.DevLoginException:
                        sbDisplayInfo.Append("设备登录异常" + v.CurrentVideoInfo.LoginPrompt);
                        break;
                    case Enum_VideoPlayEventType.DeviceNotExist:
                        sbDisplayInfo.Append("设备不存在");
                        break;
                    case Enum_VideoPlayEventType.ConnNumMax:
                        sbDisplayInfo.Append("超出设备最大连接数");
                        break;
                    case Enum_VideoPlayEventType.StartVideoRecord:
                        sbDisplayInfo.Append("开始视频视频录像");
                        break;
                    case Enum_VideoPlayEventType.StartVideoRecordException:
                        sbDisplayInfo.Append("开始视频视频录像异常");
                        break;
                    case Enum_VideoPlayEventType.StopVideoRecord:
                        sbDisplayInfo.Append("停止视频录像");
                        break;

                    case Enum_VideoPlayEventType.StopVideoRecordException:
                        sbDisplayInfo.Append("停止视频录像异常");
                        break;
                    case Enum_VideoPlayEventType.LoginStart:
                        sbDisplayInfo.Append("设备开始登陆");
                        break;
                    case Enum_VideoPlayEventType.LogonIn:
                        sbDisplayInfo.Append("设备登陆中");
                        break;
                    case Enum_VideoPlayEventType.LoginSuccess:
                        sbDisplayInfo.Append("设备登陆成功");
                        break;
                    case Enum_VideoPlayEventType.DeviceStreamTypeException:
                        sbDisplayInfo.Append("设备码流类型异常");
                        break;
                    case Enum_VideoPlayEventType.NoDeviceAuthority:
                        sbDisplayInfo.Append("无设备权限");
                        break;
                    default:
                        sbDisplayInfo.AppendFormat("[{0}]{1}", eventValue.evType.ToString(), eventValue.EventContent);
                        break;
                }
                sbDisplayInfo.Append("[" + videoPlayWindow.intConnCount + "]");
                DisplayRecord(sbDisplayInfo.ToString());
            }
            return bolResult;
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

        public void VideoChannelListButton_Click(object sender, int intIndex)
        {
            if (videoChannelList.lstbtns.Count > intIndex)
            {
                Button btn = videoChannelList.lstbtns[intIndex];
                videoChannelList.ButtonListBackColorReset();
                btn.BackColor = Color.Red;
                if (videoPlayWindow.CurrentVideoInfo != null)
                {
                    videoPlayWindow.VideoClose();
                }
                CurrentCameraInfo = (CameraInfo)btn.Tag;
                //if(videoPlayWindow.)
                videoPlayWindow.Init_VideoInfo(dicCurrentVideoInfos[strCurrentVideoID], CurrentCameraInfo, videoPlaySet);
                videoPlayWindow.VideoPlay();
            }
        }


        /// <summary>
        /// 视频通道点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cameraInfo"></param>
        public void VideoChannelListButton_Click(object sender, Button btn)
        {
            videoChannelList.ButtonListBackColorReset();
            btn.BackColor = Color.Red;
            if (videoPlayWindow.CurrentVideoInfo != null)
            {
                videoPlayWindow.VideoClose();
            }
            CurrentCameraInfo = (CameraInfo)btn.Tag;
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
                    VideoChannelListButton_Click(videoChannelList, 0);
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

        public void SetPTZVisible(bool bolVisible)
        {
            pagePTZControl.Parent = bolVisible ? tabToolbar : null;
            pblRight_Bottom.Visible = tabToolbar.TabCount > 0;
        }
        
        #endregion

        #region 公用事件
        /// <summary>
        /// 显示提示信息
        /// </summary>
        /// <param name="strDisplayInfo"></param>
        public void DisplayRecord(string strDisplayInfo)
        {
            if (this.IsHandleCreated)
            {   
                //当前窗口句柄已创建
                //当前控件未被释放
                this.BeginInvoke(new EventHandler(delegate
                {
                        tslblPrompt.Text = strDisplayInfo;
                }));
                //CommonMethod.LogWrite.WritExceptionLog("VideoPlayControl_DisplayRecord_[" + strDisplayInfo + "]", ex, ProgParameter.ProgLogAddress);
            }
            
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
                VideoChannelListButton_Click(videoChannelList, 0);
                bolFlag = false;
            }
            else
            {
                foreach (Button btn in videoChannelList.lstbtns)
                {
                    CameraInfo c = (CameraInfo)btn.Tag;
                    if (c.Channel == intChannel)
                    {
                        VideoChannelListButton_Click(videoChannelList, btn);
                        bolFlag = false;
                        break;
                    }
                }
            }
            if (bolFlag)
            {
                //无选中通道播放第一通道
                VideoChannelListButton_Click(videoChannelList, 0);
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
            //videoPlayWindow.VideoPlayWindows_Close();
            videoTalkControlManyChannel1.ControlColse();
        }

        #endregion

        private void tsmi_CloundSeeSetWindows_Click(object sender, EventArgs e)
        {

        }

        private void tsmi_VideoRecord_Click(object sender, EventArgs e)
        {
            //1.IVideoPlay 添加录像接口
            //videoPlayWindow.StartVideoRecord();
        }
    }
}
