using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VideoPlayControl.Controls.PTZ
{
    public partial class PTZControl_Basic : UserControl
    {
        public PTZControl_Basic()
        {
            InitializeComponent();
        }

        private void PTZControl_Basic_Load(object sender, EventArgs e)
        {
            picUp.Tag = Enum_VideoPTZControl.PTZControl_Up;
            picDown.Tag = Enum_VideoPTZControl.PTZControl_Down;
            picLeft.Tag = Enum_VideoPTZControl.PTZControl_Left;
            picRight.Tag = Enum_VideoPTZControl.PTZControl_Right;
            picLeftUp.Tag = Enum_VideoPTZControl.PTZControl_LeftUp;
            picRightUp.Tag = Enum_VideoPTZControl.PTZControl_RightUp;
            picLeftDown.Tag = Enum_VideoPTZControl.PTZControl_LeftDown;
            picRightDown.Tag = Enum_VideoPTZControl.PTZControl_RightDown;
            btnZoomOut.Tag = Enum_VideoPTZControl.PTZControl_Zoom_Out;
            btnZoomIn.Tag = Enum_VideoPTZControl.PTZControl_Zoom_In;

            picUp.MouseDown += picPTZControl_MouseDown;
            picDown.MouseDown += picPTZControl_MouseDown;
            picLeft.MouseDown += picPTZControl_MouseDown;
            picRight.MouseDown += picPTZControl_MouseDown;
            picLeftUp.MouseDown += picPTZControl_MouseDown;
            picRightUp.MouseDown += picPTZControl_MouseDown;
            picLeftDown.MouseDown += picPTZControl_MouseDown;
            picRightDown.MouseDown += picPTZControl_MouseDown;
            btnZoomOut.MouseDown += picPTZControl_MouseDown;
            btnZoomIn.MouseDown += picPTZControl_MouseDown;

            picUp.MouseUp += picPTZControl_MouseUp;
            picDown.MouseUp += picPTZControl_MouseUp;
            picLeft.MouseUp += picPTZControl_MouseUp;
            picRight.MouseUp += picPTZControl_MouseUp;
            picLeftUp.MouseUp += picPTZControl_MouseUp;
            picRightUp.MouseUp += picPTZControl_MouseUp;
            picLeftDown.MouseUp += picPTZControl_MouseUp;
            picRightDown.MouseUp += picPTZControl_MouseUp;
            btnZoomOut.MouseUp += picPTZControl_MouseUp;
            btnZoomIn.MouseUp += picPTZControl_MouseUp;
        }



        public delegate void PTZControlDelegate(Enum_VideoPTZControl PTZControlCmd, bool bolStart);

        public event PTZControlDelegate PTZControlEvent;

        private void PTZControl(Enum_VideoPTZControl PTZControlCmd, bool bolStart)
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
