using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoBasicClass
{
    public class VideoPlayCallbackValue
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public Enum_VideoPlayEventType evType = Enum_VideoPlayEventType.Unidentified;

        /// <summary>
        /// 事件内容
        /// </summary>
        public string EventContent = "";

    }
}
