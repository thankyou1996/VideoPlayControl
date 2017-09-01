using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VideoPlayControl_UseDemo
{
    public partial class Frm_VideoPlayWindows : Form
    {
        public Frm_VideoPlayWindows()
        {
            InitializeComponent();
        }

        public Frm_VideoPlayWindows(VideoInfo videoInfo)
        {
            InitializeComponent();
            videoPlayWindow1.Init_VideoInfo(videoInfo);
            videoPlayWindow1.VideoPlay();
        }

        private void Frm_VideoPlayWindows_Load(object sender, EventArgs e)
        {
            
        }
        private void Frm_VideoPlayWindows_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoPlayWindow1.VideoPlayWindows_Close();
        }

        private void Frm_VideoPlayWindows_Move(object sender, EventArgs e)
        {
            videoPlayWindow1.VideoPlayWindows_Move();
        }

        private void videoPlayWindow1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("1");
        }
    }
}
