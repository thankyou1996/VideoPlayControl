using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SKN_Player
{
    class sk_decoder
    {
        public const string str = "sk_decoder.dll";
        /// <summary>
        /// 打开调试
        /// </summary>
        [DllImport(str, CallingConvention = CallingConvention.Cdecl)]
        public extern static void sk_decoder_debug();
        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="file_name"></param>
        /// <param name="hwnd"></param>
        /// <param name="decode_accel"></param>
        /// <param name="render_accel"></param>
        [DllImport(str, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr sk_decoder__start_pb(string file_name, IntPtr hwnd, int decode_accel, int render_accel);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void msg_callback(IntPtr handler, int pos);
        /// <summary>
        /// 设置回调信息
        /// </summary>
        /// <param name="p_8604msg_callback"></param>
        /// <returns></returns>
        [DllImport(str, CallingConvention = CallingConvention.Cdecl)]
        public static extern void sk_decoder__register_timeline_callback(msg_callback cb);



        /// <summary>
        /// 关闭文件
        /// </summary>
        /// <param name="handler"></param>
        [DllImport(str, CallingConvention = CallingConvention.Cdecl)]
        public extern static void sk_decoder__stop_pb(IntPtr handler);
        /// <summary>
        /// 暂停播放
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="play"></param>
        [DllImport(str, CallingConvention = CallingConvention.Cdecl)]
        public extern static void sk_decoder__play(IntPtr handler, bool play);
        /// <summary>
        /// 获取视频播放的范围
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        [DllImport(str, CallingConvention = CallingConvention.Cdecl)]
        public extern static int sk_decoder__get_range(IntPtr handler);
        /// <summary>
        /// 从某一帧开始播放
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="pos"></param>
        [DllImport(str, CallingConvention = CallingConvention.Cdecl)]
        public extern static void sk_decoder__set_timeline(IntPtr handler, int pos);
    }
}
