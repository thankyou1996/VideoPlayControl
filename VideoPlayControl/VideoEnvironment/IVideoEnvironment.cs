using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoEnvironment
{
    public interface IVideoEnvironment
    {
        /// <summary>
        /// 初始化
        /// </summary>
        void Init();

        /// <summary>
        /// 反初始化
        /// </summary>
        void Release();
    }
}
