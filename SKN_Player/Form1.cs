using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SKN_Player
{
    public partial class Form1 : Form
    {
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        IntPtr pb_handler;//播放视频的句柄
        bool pb_pause = false;// 是否暂停;
        
        int total_frames;// 视频播放帧数
        private enum playstate
        {
            play = 0,
            stop
        };

        playstate state_flag = playstate.stop;
        public Form1(string filePath)
        {
            InitializeComponent();
            startPlay(filePath);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void startPlay(string filePath)
        {
            int i = Convert.ToInt32(checkBox1.Checked);
            int j = Convert.ToInt32(checkBox2.Checked);
            IntPtr hwnd = pictureBox1.Handle;
            pb_handler = sk_decoder.sk_decoder__start_pb(filePath, hwnd,i,j);
            total_frames = sk_decoder.sk_decoder__get_range(pb_handler);
            trackBar1.SetRange(0, total_frames);
            callack = new sk_decoder.msg_callback(callback);
            sk_decoder.sk_decoder__register_timeline_callback(callack);
            state_flag = playstate.play;
        }

        #region 控件函数
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void miniBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maxBox_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void 打开文件ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {;
            trackBar1.Value = 0;
            // 首先关闭播放句柄
            sk_decoder.sk_decoder__stop_pb(pb_handler);
            state_flag = playstate.stop;
            label3.Image = global::SKN_Player.Properties.Resources.playon;
            int i = Convert.ToInt32(checkBox1.Checked);
            int j = Convert.ToInt32(checkBox2.Checked);
            // 图片控件的句柄
            IntPtr hwnd = pictureBox1.Handle;
            // 打开文件
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "h264文件(*.h264*)|*.h264|g711文件(*.g711*)|*.g711";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileInfo path = new FileInfo(dlg.FileName);
                string file_path = path.FullName;
                // 开始播放
                pb_handler = sk_decoder.sk_decoder__start_pb(file_path, hwnd,i,j);
            }
            total_frames = sk_decoder.sk_decoder__get_range(pb_handler);
            trackBar1.SetRange(0, total_frames);
            callack = new sk_decoder.msg_callback(callback);
            sk_decoder.sk_decoder__register_timeline_callback(callack);
            state_flag = playstate.play;
        }

        private void 关闭文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sk_decoder.sk_decoder__stop_pb(pb_handler);
            pb_handler = IntPtr.Zero;
        }

        // 暂停/播放
        private void label3_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value == total_frames)
            {
                sk_decoder.sk_decoder__set_timeline(pb_handler, 0);
                label3.Image = global::SKN_Player.Properties.Resources.pauseon;
                state_flag = playstate.stop;
            }
            sk_decoder.sk_decoder__play(pb_handler, !(pb_pause = !pb_pause));
            if (state_flag == playstate.play)
            {
                label3.Image = global::SKN_Player.Properties.Resources.pauseon;
                state_flag = playstate.stop;
            }
            else
            {
                label3.Image = global::SKN_Player.Properties.Resources.playon;
                state_flag = playstate.play;
            }
        }
        // 实现滚动
        private void track_Scroll(object sender, EventArgs e)
        {
            int replayPos = trackBar1.Value;
            sk_decoder.sk_decoder__set_timeline(pb_handler, replayPos);
        }

        static sk_decoder.msg_callback callack;
        // 回调
        private void callback(IntPtr intPtr, int pos)
        {
            if (intPtr == pb_handler)
            {
                this.BeginInvoke(new EventHandler(delegate
                {
                    label4.Text = pos + "/" + total_frames;
                    trackBar1.Value = pos;
                }));
            }
        }
    }
}