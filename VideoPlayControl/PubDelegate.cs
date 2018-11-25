using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl
{
    #region 视频相关

    /// <summary>
    /// 视频播放事件回调V_2.0
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="evValue"></param>
    /// <returns></returns>
    public delegate bool VideoPlayCallbackDelegate(object sender, VideoPlayCallbackValue evValue);



    /// <summary>
    /// 视频播放状态改变
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="VideoPlayStateChangedValue"></param>
    /// <returns></returns>
    public delegate bool VideoPlayStateChangedDelegate(object sender, object VideoPlayStateChangedValue);
    #endregion



    #region 对讲相关

    /// <summary>
    /// 对讲状态改变事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="TalkStausChangedValue"></param>
    /// <returns></returns>
    public delegate bool TalkStausChangedDelegate(object sender, object TalkStausChangedValue);

    /// <summary>
    /// 开始对讲时(前)事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="StartTalkBeginValue"></param>
    /// <returns></returns>
    public delegate bool StartTalkingDelegate(object sender, object StartTalkBeginValue);

    /// <summary>
    /// 开始对讲后事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="StartTalkedValue"></param>
    /// <returns></returns>
    public delegate bool StartTalkedDelegate(object sender, object StartTalkedValue);

    /// <summary>
    /// 结束对讲前事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="StopTalkValue"></param>
    /// <returns></returns>
    public delegate bool StopTalkedDelegate(object sender, object StopTalkValue);
    #endregion 

}
