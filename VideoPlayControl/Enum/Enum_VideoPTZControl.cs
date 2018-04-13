using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayControl
{
    /// <summary>
    /// 云台控制枚举
    /// </summary>
    public enum Enum_VideoPTZControl
    {
        /// <summary>
        /// 上
        /// </summary>
        PTZControl_Up = 1,
        /// <summary>
        /// 下
        /// </summary>
        PTZControl_Down = 2,
        /// <summary>
        /// 左
        /// </summary>
        PTZControl_Left = 3,
        /// <summary>
        /// 右
        /// </summary>
        PTZControl_Right = 4,
        /// <summary>
        /// 左上
        /// </summary>
        PTZControl_LeftUp = 5,
        /// <summary>
        /// 右上
        /// </summary>
        PTZControl_RightUp = 6,
        /// <summary>
        /// 左下
        /// </summary>
        PTZControl_LeftDown = 7,
        /// <summary>
        /// 右下
        /// </summary>
        PTZControl_RightDown = 8,

        /// <summary>
        /// 缩小
        /// </summary>
        PTZControl_Zoom_Out = 9,

        /// <summary>
        /// 放大
        /// </summary>
        PTZControl_Zoom_In = 10,

        /// <summary>
        /// 设置预置点
        /// </summary>
        PTZControl_SetPreset = 11,

        /// <summary>
        /// 转到预置点
        /// </summary>
        PTZControl_GoToPreser = 12,

        /// <summary>
        /// 删除预置点
        /// </summary>
        PTZControl_DelPreset = 13,
    }
}
