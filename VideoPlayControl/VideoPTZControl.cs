using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace VideoPlayControl
{
    public partial class VideoPTZControl : UserControl
    {
        public VideoPTZControl()
        {
            InitializeComponent();
        }

        private void VideoPTZControl_Load(object sender, EventArgs e)
        {
            picUp.Tag = Enum_VideoPTZControl.PTZControl_Up;
            picDown.Tag = Enum_VideoPTZControl.PTZControl_Down;
            picLeft.Tag = Enum_VideoPTZControl.PTZControl_Left;
            picRight.Tag = Enum_VideoPTZControl.PTZControl_Right;

            picUp.MouseDown += picPTZControl_MouseDown;
            picDown.MouseDown += picPTZControl_MouseDown;
            picLeft.MouseDown += picPTZControl_MouseDown;
            picRight.MouseDown += picPTZControl_MouseDown;

            picUp.MouseUp += picPTZControl_MouseUp;
            picDown.MouseUp += picPTZControl_MouseUp;
            picLeft.MouseUp += picPTZControl_MouseUp;
            picRight.MouseUp += picPTZControl_MouseUp;

        }

        public delegate void PTZControlDelegate(Enum_VideoPTZControl PTZControlCmd, bool bolStart);

        public event PTZControlDelegate PTZControlEvent;

        private void PTZControl(Enum_VideoPTZControl PTZControlCmd,bool bolStart)
        {
            if (PTZControlEvent != null)
            {
                PTZControlEvent(PTZControlCmd, bolStart);
            }
        }

        private void picPTZControl_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            Enum_VideoPTZControl enumPTZControl = (Enum_VideoPTZControl)pic.Tag;
            PTZControl(enumPTZControl, true);
        }

        private void picPTZControl_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            Enum_VideoPTZControl enumPTZControl = (Enum_VideoPTZControl)pic.Tag;
            PTZControl(enumPTZControl, false);
        }
        
    }
}
