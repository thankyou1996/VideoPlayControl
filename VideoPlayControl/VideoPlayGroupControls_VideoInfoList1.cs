using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;
using static CommonMethod.CommonObject;

namespace VideoPlayControl
{
    public partial class VideoPlayGroupControls_VideoInfoList1 : UserControl
    {

        #region 事件
        public delegate void VideoChannelClickDelegate(object sender,Button btn);

        public event VideoChannelClickDelegate VideoChannelClickEvent;

        private void VideoChannelClick(object sender, Button btn)
        {
            if (VideoChannelClickEvent != null)
            {
                VideoChannelClickEvent(this, btn);
            }
        }


        #endregion

        /// <summary>
        /// 当前视频信息
        /// </summary>
        public Dictionary<string, PublicClassCurrency.VideoInfo> dicCurrentVideoInfos = new Dictionary<string, VideoInfo>();

        public string CurrentVideoID = "";
        public VideoPlayGroupControls_VideoInfoList1()
        {
            InitializeComponent();
            videoChannelList1.ChannelButtonColumn = 4;
            videoChannelList1.bolAutoSetBtnSize = true;
            videoChannelList1.ButtonChannel_ClickEvent += VideoChannelClick;
        }
        private void VideoPlayGroupControls_VideoInfoList1_Load(object sender, EventArgs e)
        {
            //videoChannelList1.ChannelButtonColumn = 4;
            //videoChannelList1.bolAutoSetBtnSize = true;
            //videoChannelList1.ButtonChannel_ClickEvent += VideoChannelClick;
        }
        public void Init_SetVideoListInfo(Dictionary<string ,VideoInfo> videoInfoList)
        {
            cmbVideoList.SelectedIndexChanged -= cmbVideolist_SelectedIndexChanged;     //取消事件（防止出现重复注册情况）
            cmbVideoList.Items.Clear();
            dicCurrentVideoInfos = videoInfoList;
            if (dicCurrentVideoInfos.Count > 0)
            {
                
                ComboBoxItem cmbItem;
                foreach (KeyValuePair<string, PublicClassCurrency.VideoInfo> kv in dicCurrentVideoInfos)
                {
                    if (kv.Value.DVSChannelNum > 0)
                    {
                        //大于0 添加
                        cmbItem = new ComboBoxItem(kv.Key, kv.Value.DVSName);
                        cmbVideoList.Items.Add(cmbItem);
                    }
                }
                cmbVideoList.SelectedIndexChanged += cmbVideolist_SelectedIndexChanged;     //注册事件
                if (cmbVideoList.Items.Count > 0)
                {
                    cmbVideoList.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// 显示视频信息
        /// </summary>
        /// <param name="v"></param>
        public void DisplayVideoInfo(VideoInfo v)
        {
            txtVideoID.Text = v.DVSNumber;
            txtOnlieStatus.Text = v.NetworkState > 0 ? "在线" : v.NetworkState == 0 ? "离线" : "未明";
            txtVideoType.Text = v.DVSType;
            txtVideoChannel.Text = Convert.ToString(v.DVSChannelNum);
            txtVideoName.Text = v.DVSName;
            txtVideAddress.Text = v.DVSAddress;
            videoChannelList1.Init_SetVideoInfo(v);
            
        }


        #region　控件事件
        /// <summary>
        /// 视频设备列表_选中项改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVideolist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem cmbItem = (ComboBoxItem)cmbVideoList.SelectedItem;
            CurrentVideoID = Convert.ToString(cmbItem.ItemValue);
            DisplayVideoInfo(dicCurrentVideoInfos[CurrentVideoID]);
        }
        #endregion

        
    }
}
