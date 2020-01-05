using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoTalk
{
    /// <summary>
    /// 开始对讲
    /// </summary>
    public class StartTalkingValue
    {
        /// <summary>
        /// 执行对讲操作
        /// 某些特殊情况/特殊设备 不需要执行对讲操作，但是以然需要把对讲状态置为对讲
        /// </summary>
        public bool ExecuteTalk
        {
            get;
            set;
        } = true;
    }
}
