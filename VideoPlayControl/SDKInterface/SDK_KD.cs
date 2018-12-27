using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace VideoPlayControl.SDKInterface
{
    
    /// <summary>
    /// 科达SDK接口
    /// </summary>
    public class SDK_KD
    {
        #region 回调

        [Serializable]
        public delegate int PFUNCNVRSDKCALLBACK(ref TSDK_CallBackInfo pTSDK_CallBackInfo, uint u32WParam,
                                       uint u32LParam, uint u32UserData);
        #endregion

        #region 结构体
        /// <summary>
        /// 初始化结构体
        /// </summary>
        [Serializable]
        public struct TSDK_Init
        {
            public PFUNCNVRSDKCALLBACK m_pFuncNvrSdkProc;
            //string SerializeParam();   // 序列化结构体
        };

        /// <summary>
        /// 回调信息
        /// </summary>
        [Serializable]
        public struct TSDK_CallBackInfo
        {
            int m_nNvrID;
            int m_nDeviceID;
            int m_nChnID;
            int m_nErrorCode;
            int m_nMsgCode;
            uint m_dwReserved1;
            uint m_dwReserved2;
        };
        #endregion
        public static bool serializeObjToStr(Object obj, out string serializedStr)
        {
            bool serializeOk = false;
            serializedStr = "";
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, obj);
                serializedStr = System.Convert.ToBase64String(memoryStream.ToArray());

                serializeOk = true;
            }
            catch(Exception ex)
            {
                serializeOk = false;
            }

            return serializeOk;
        }
        [DllImport(ProgConstants.c_strKDFilePath)]
        public static extern int DS_Init();

        /// <summary>
        /// SDK初始化接口
        /// </summary>
        /// <param name="cb"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strKDFilePath)]
        public static extern int NET_NVR_SDKInit(TSDK_Init init);

        /// <summary>
        /// SDK反初始化
        /// </summary>
        /// <param name="pSerialTSDK_Init"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strKDFilePath)]
        public static extern int NET_NVR_SDKCleanup();

        /// <summary>
        /// 登陆DVR
        /// </summary>
        /// <param name="pSerialTSDK_Init"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strKDFilePath)]
        public static extern int NET_NVR_LoginSync(IntPtr pSerialTSDK_Init);
        /// <summary>
        /// 登出
        /// </summary>
        /// <param name="pSerialTSDK_Init"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strKDFilePath)]
        public static extern int NET_NVR_Logout(int nNvrID);

        /// <summary>
        /// 申请码流
        /// </summary>
        /// <param name="pSerialTSDK_Init"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strKDFilePath)]
        public static extern int NET_NVR_ApplyVideoStream(IntPtr pSerialTSDK_Init);

        /// <summary>
        /// 关闭码流
        /// </summary>
        /// <param name="pSerialTSDK_Init"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strKDFilePath)]
        public static extern int NET_NVR_StopVideoStream(IntPtr pSerialTSDK_Init);
    }
}
