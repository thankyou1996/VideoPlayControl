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
    /// <summary>
    /// 视频通道列表
    /// </summary>
    public partial class VideoChannelList : UserControl
    {
        #region 全局变量
        /// <summary>
        /// 当前视频信息
        /// </summary>
        public VideoInfo CurrentVideoInfo;

        /// <summary>
        /// 按钮列表
        /// </summary>
        public List<Button> lstbtns;

        /// <summary>
        /// 初始按钮位置 X
        /// </summary>
        int intbtnStartX = 1;

        /// <summary>
        /// 初始按钮位置 Y
        /// </summary>
        int intbtnStartY = 1;

        /// <summary>
        /// 默认按钮宽度 60
        /// </summary>
        public int intbtnWidth = 60;

        /// <summary>
        /// 默认按钮高度 30
        /// </summary>
        public int intbtnHeight = 30;

        public Color clrDefaultColor = Control.DefaultBackColor;

        public Color clrSelectedColor = Color.Red;

        private Color clrBackColor = SystemColors.ControlDark;
        #endregion

        #region 事件委托
        public delegate void ButtonChannel_ClickDelegate(object sender, CameraInfo cameraInfo);

        public event ButtonChannel_ClickDelegate ButtonChannel_ClickEvent;

        private void ButtonChannel_Click(object sender,CameraInfo cameraInfo)
        {
            if (ButtonChannel_ClickEvent != null)
            {
                ButtonChannel_ClickEvent(sender, cameraInfo);
            }
        }

        #endregion 


        /// <summary>
        /// 视频通道列表名称
        /// </summary>
        public VideoChannelList()
        {
            InitializeComponent();
            intbtnWidth = (this.pnlMain.Width - 1) / 2;
            lstbtns = new List<Button>();
        }

        private void VideoChannelList_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 设置视频信息
        /// </summary>
        /// <param name="videoInfo"></param>
        public void Init_SetVideoInfo(VideoInfo videoInfo)
        {
            CurrentVideoInfo = videoInfo;
            SetVideoInfoCameraInfo();
            
        }

        #region 初始化
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
           

        }
        #endregion

        #region 公用事件
        /// <summary>
        /// 按钮背景颜色重置
        /// </summary>
        public void ButtonListBackColorReset()
        {
            foreach (Button btn in lstbtns)
            {
                btn.BackColor = clrDefaultColor;
            }
        }

        /// <summary>
        /// 获取选中按钮数量
        /// </summary>
        /// <returns></returns>
        public int GetSelectedButtonCount()
        {
            int intResult = 0;
            foreach (Button btn in lstbtns)
            {
                if (btn.BackColor == clrSelectedColor)
                {
                    intResult++;
                }
            }
            return intResult;
        }
        #endregion

        /// <summary>
        /// 设置摄像头信息按钮
        /// </summary>
        public void SetVideoInfoCameraInfo()
        {
            int intCol = 0;
            int intRow = 0;
            CalculationToButonWidth();
            for (int i = lstbtns.Count - 1; i >= 0; i--)
            {
                lstbtns[i].Dispose();
            }
            lstbtns.Clear();
            ttip.RemoveAll();
            if (CurrentVideoInfo != null)
            {
                foreach (KeyValuePair<int, CameraInfo> kv in CurrentVideoInfo.Cameras)
                {
                    //1(x:2 y:27)  2(x:66 y=27)
                    //3(x:2,y:63)  4(x:66 y=63)
                    Button btn = new Button();
                    btn.Name = "btn" + kv.Value.Channel.ToString();
                    btn.Location = new System.Drawing.Point(intbtnStartX + (intbtnWidth * intCol), intbtnStartY + (intbtnHeight * intRow));
                    btn.Size = new System.Drawing.Size(intbtnWidth, intbtnHeight);
                    btn.Text = "通道" + kv.Value.Channel.ToString();
                    btn.BackColor = Control.DefaultBackColor;
                    pnlMain.Controls.Add(btn);
                    btn.Tag = kv.Value;
                    btn.Click += btnCameraInfo_Click;
                    lstbtns.Add(btn);
                    ttip.SetToolTip(btn, kv.Value.CameraName);
                    intCol++;
                    if (intCol >= 2)
                    {
                        intCol = 0;
                        intRow++;
                    }
                }
            }
        }


        public void CalculationToButonWidth()
        {
            int Temp_intRowCount = CurrentVideoInfo.Cameras.Count / 2;
            if (CurrentVideoInfo.Cameras.Count % 2 != 0)
            {   
                //存在余数 
                Temp_intRowCount++;
            }
            if ((Temp_intRowCount * intbtnHeight) > pnlMain.Height)
            {
                //预留滚动条
                intbtnWidth = (this.pnlMain.Width - 21) / 2;
            }
            else
            {
                intbtnWidth = (this.pnlMain.Width - 1) / 2;
            }
            
        }

        /// <summary>
        /// 按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCameraInfo_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            CameraInfo camerInfo = (CameraInfo)btn.Tag;
            ButtonChannel_Click(sender, camerInfo);
        }

        #region 自动以属性
        [Description("主体背景颜色"), Category("自定义属性")]
        public Color ClrBackColor
        {
            get { return clrBackColor; }
            set
            {
                clrBackColor = value;
                pnlMain.BackColor = clrBackColor;
            }
        }

        #endregion
    }
}
