using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VideoPlayControl.SDKInterface;

namespace SKVideoRemotePlayer
{
    public class PubMethod
    {
        /// <summary>
        /// 下载文件映射
        /// </summary>
        /// <param name="cInfo"></param>
        public static void DownloadFileMap(CameraInfo cInfo)
        {
            //下载录像映射文件
            VideoInfo vInfo = cInfo.VideoInfo;
            string strPath1 = SDK_SKNVideo.GetFileMapPath(cInfo);
            string strPath2 = SDK_SKNVideo.GetLocalFileMapPath(cInfo);
            string Temp_strPath = Path.GetDirectoryName(strPath2);
            SDK_SKNVideo.SDK_NSK_CLIENT_get_file(vInfo.DVSAddress, false, strPath1, strPath2);
            CommonMethod.Common.Delay_Millisecond(1500);
        }
    }
}
