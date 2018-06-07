using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl
{
    /// <summary>
    /// 视频播放时间回调
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="eventType"></param>
    public delegate void VideoPlayEventCallBackDelegate(object sender, Enum_VideoPlayEventType eventType);

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
}
