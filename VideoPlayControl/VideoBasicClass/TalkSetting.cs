using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoBasicClass
{
    /// <summary>
    /// 对讲设置
    /// </summary>
    public class TalkSetting
    {
        private bool bolTalkRecordEnable = false;

        /// <summary>
        /// 对讲记录使能
        /// </summary>
        public bool TalkRecordEnable
        {
            get { return bolTalkRecordEnable; }
            set { bolTalkRecordEnable = value; }
        }

        private string strTalkRecordPath_Local = "";

        /// <summary>
        /// 本地对讲记录地址
        /// </summary>
        public string TalkRecordPath_Local
        {
            get { return strTalkRecordPath_Local; }
            set { strTalkRecordPath_Local = value; }
        }

        private string strTalkRecordName_Local = "";

        /// <summary>
        /// 本地对讲记录名称
        /// </summary>
        public string TalkRecordName_Local
        {
            get { return strTalkRecordName_Local; }
            set { strTalkRecordName_Local = value; }
        }

        private string strTalkRecordRealSavePath_Local = "";

        /// <summary>
        /// 录音文件实际保存地址
        /// 人为控制实际生成保存路径是赋值
        /// </summary>
        public string TalkRecordRealSavePath_Local
        {
            get { return strTalkRecordRealSavePath_Local; }
            set { strTalkRecordRealSavePath_Local = value; }
        }
        private string strTalkRecordPath_Server = "";
        /// <summary>
        /// 服务器对讲记录地址
        /// </summary>
        public string TalkRecordPath_Server
        {
            get { return strTalkRecordPath_Server; }
            set { strTalkRecordPath_Server = value; }
        }

        private string strTalkRecordName_Server = "";

        /// <summary>
        /// 服务器对讲记录名称
        /// </summary>
        public string TalkRecordName_Server
        {
            get { return strTalkRecordName_Server; }
            set { strTalkRecordName_Server = value; }
        }

        /// <summary>
        /// 执行对讲操作
        /// 某些特殊情况/特殊设备 不需要执行对讲操作，但是以然需要把对讲状态置为对讲
        /// </summary>
        public bool ExecuteTalk
        {
            get;
            set;
        } = true;


        /// <summary>
        /// 对讲模式
        /// </summary>
        public Enum_TalkModel TalkMode
        {
            get;
            set;
        } = Enum_TalkModel.Talkback;

    }
}
