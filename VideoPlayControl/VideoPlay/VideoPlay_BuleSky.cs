using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using PublicClassCurrency;

namespace VideoPlayControl.VideoPlay
{
    public class VideoPlay_BuleSky : IVideoPlay
    {
        IntPtr VideoPlayHandle;
        public VideoPlay_BuleSky(IntPtr intPtr)
        {
            VideoPlayHandle = intPtr;
        }
        /// <summary>
        /// 登录句柄
        /// </summary>
        IntPtr DvxHandle = IntPtr.Zero;
        IntPtr RealHandle = IntPtr.Zero;
        int _nRet = -1;
        UInt32 g_IpcDif;
        public int m_ndevType;
        bool m_isIPCLotus;//是不是IPC的lotus的机型
        bool m_bisHaveThirdStream;
        dvxSdkType.IPCPreViewPara m_IPCPreViewPara = new dvxSdkType.IPCPreViewPara();
        dvxSdkType.RealOpenPara m_hRealOpenPara = new dvxSdkType.RealOpenPara();
        public IntPtr iiiiiiii = IntPtr.Zero;

        public VideoInfo CurrentVideoInfo { get; set; }
        public CameraInfo CurrentCameraInfo { get; set; }
        public VideoPlaySetting CurrentVideoPlaySet { get; set; }
        public IntPtr intptrPlayMain { get; set; }
        public Enum_VideoPlayState VideoPlayState { get; set; }

        public event VideoPlayEventCallBackDelegate VideoPlayEventCallBackEvent;
        private void VideoPlayEventCallBack(Enum_VideoPlayEventType eventType)
        {
            if (VideoPlayEventCallBackEvent != null)
            {
                VideoPlayEventCallBackEvent(this, eventType);
            }
        }

        public bool VideoClose()
        {
            //VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnSuccess);
            //VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlay);
            //throw new NotImplementedException();
            
            if (DvxHandle == IntPtr.Zero)
            {
                return true;
            }

            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                //关闭录像
                _nRet = SDK_BlueSDK.dvxRealStopSaveAs(RealHandle);
                if ((int)dvxSdkType.ReturnError.DVX_OK != _nRet)
                {
                    //MessageBox.Show("停止录像不成功");
                    VideoPlayEventCallBack(Enum_VideoPlayEventType.StopVideoRecordException);
                    return false;
                }
                VideoPlayEventCallBack(Enum_VideoPlayEventType.StopVideoRecord);
            }


            StateReset();

            SDK_BlueSDK.dvxSecuritySessionAuthClear(DvxHandle);
            SDK_BlueSDK.dvxDestory(DvxHandle);
            DvxHandle = IntPtr.Zero;
            m_ndevType = 0;
            VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoClose);
            return true;
        }

        public bool VideoPlay()
        {
            if (DvxHandle != IntPtr.Zero)
            {
                //已登录，请注销
                //return true;
                goto VideoPlay;
            }

            _nRet = SDK_BlueSDK.dvxCreate(CurrentVideoInfo.DVSAddress, (ushort)CurrentVideoInfo.DVSConnectPort, (ushort)CurrentVideoInfo.DVSDataPort, CurrentVideoInfo.UserName, CurrentVideoInfo.Password, ref DvxHandle);
            if (_nRet != (int)dvxSdkType.ReturnError.DVX_OK || DvxHandle == IntPtr.Zero)
            {
                //登录失败
                VideoPlayEventCallBack(Enum_VideoPlayEventType.UserAccessError);
                return false;
            }
            else
            {
                //登录成功
                dvxSdkType.SystemVersionInfo ver = new dvxSdkType.SystemVersionInfo();
                dvxSdkType.SystemDescribleInfo m_sysDesInfo = new dvxSdkType.SystemDescribleInfo();
                _nRet = SDK_BlueSDK.dvxSysVersion(DvxHandle, ref ver);
                if (_nRet == 0)
                {
                    g_IpcDif = 0;
                    m_ndevType = GetDevType(ver.serial);
                    if (m_ndevType == 2)  //IPC 获取IPC支持的功能，如宽动态、白平衡等
                    {
                        dvxSdkType.SysModulePara sysModule = new dvxSdkType.SysModulePara();
                        dvxSdkType.AVDescribe avDescribe = new dvxSdkType.AVDescribe();
                        _nRet = SDK_BlueSDK.dvxSysModulesGet(DvxHandle, ref sysModule);
                        if (2 <= sysModule.rdver) //B02版本开始可以直接获取设备能力
                        {
                            _nRet = SDK_BlueSDK.dvxSysDescribeEx(DvxHandle, ref m_sysDesInfo);
                            if ((int)dvxSdkType.ReturnError.DVX_OK == _nRet)
                            {
                                g_IpcDif = m_sysDesInfo.features;
                                if (5 == m_sysDesInfo.platform)
                                {
                                    m_isIPCLotus = true;
                                }
                            }
                            _nRet = SDK_BlueSDK.dvxAVDescrible(DvxHandle, ref avDescribe);
                            if ((int)dvxSdkType.ReturnError.DVX_OK == _nRet)
                            {
                                if ((0 == (avDescribe.bitstreams & 0x04)) || (true == m_isIPCLotus))
                                {
                                    m_bisHaveThirdStream = false;
                                }
                            }
                        }
                        else
                        {
                            CheckIPCType(ver.model);
                        }
                    }
                    else if (m_ndevType == 1)//Limit D
                    {
                        _nRet = SDK_BlueSDK.dvxSysDescribeEx(DvxHandle, ref m_sysDesInfo);
                    }
                }
                dvxSdkType.SystemSerialGet SerialInfo = new dvxSdkType.SystemSerialGet();
                _nRet = SDK_BlueSDK.dvxSysSerialGet(DvxHandle, ref SerialInfo);
                if (((int)dvxSdkType.ReturnError.DVX_OK) == _nRet && (10 == SerialInfo.version_type))//version_type : 10 加密 DVR
                {
                    Byte[] buf = new Byte[64 * 1024];
                    int nRealLen = 0;
                    _nRet = SDK_BlueSDK.dvxUkeyEt199ReadAllInfo(ref buf, 64 * 1024, ref nRealLen);
                    if ((int)dvxSdkType.ReturnError.DVX_OK == _nRet)
                    {
                        dvxSdkType.UkeyAuthizeParam authParam = new dvxSdkType.UkeyAuthizeParam();
                        int nValue = 0;
                        authParam.authLen = (UInt32)(nRealLen > (64 * 1024) ? (64 * 1024) : nRealLen);
                        authParam.auth = buf;
                        _nRet = SDK_BlueSDK.dvxSecuritySessionAuthizeSet(DvxHandle, ref authParam, ref nValue);

                    }
                }


            }

            VideoPlay:
            //预览视频
            if (DvxHandle == IntPtr.Zero)
            {
                //listBox1.Items.Insert(0, "当前无登录的DVR!");
                VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnFailed);
                return false;
            }
            else
            {
                //如果当前正在预览
                if (RealHandle != IntPtr.Zero)
                {
                    //关闭预览
                    int nRet = SDK_BlueSDK.dvxRealStop(RealHandle);
                    if (nRet != 0)
                    {
                        //listBox1.Items.Insert(0, "停止现场流失败");
                        VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlayException);

                        return false;
                    }

                    nRet = SDK_BlueSDK.dvxRealClose(ref RealHandle);
                    if (nRet != 0)
                    {
                        //listBox1.Items.Insert(0, "关闭现场流失败");
                        VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlayException);

                        return false;
                    }

                    RealHandle = IntPtr.Zero;

                    StateReset();
                    //关闭成功
                    //return true;
                }
                //else
                //{
                if (SDK_BlueSDK.dvxIsLogin(DvxHandle))
                {
                    SDK_BlueSDK.dvxLogout(DvxHandle);
                    if ((int)dvxSdkType.ReturnError.DVX_OK != SDK_BlueSDK.dvxLogin(DvxHandle, CurrentVideoInfo.UserName, CurrentVideoInfo.Password, 10000))
                    {
                        //MessageBox.Show("当前设备已断线，并且登录不上");
                        VideoPlayEventCallBack(Enum_VideoPlayEventType.UserAccessError);

                        return false;
                    }

                }

                //bool bPreviewDlgOK = false;
                bool bImageEhnace = false;
                if (m_ndevType != 2)
                {
                    bImageEhnace = false;

                    m_hRealOpenPara.channel = (Char)CurrentCameraInfo.Channel;
                    m_hRealOpenPara.subStream = (Char)0;//主码流
                    m_hRealOpenPara.transProc = (Char)1;

                    m_hRealOpenPara.transMode = (Char)1;
                    m_hRealOpenPara.ip = 0;

                }
                _nRet = SDK_BlueSDK.dvxRealOpen(DvxHandle, ref m_hRealOpenPara, intptrPlayMain, VideoPlayHandle, 1283, ref RealHandle);
                if (((int)dvxSdkType.ReturnError.DVX_OK) != _nRet || RealHandle == IntPtr.Zero)
                {
                    if ((0 == m_hRealOpenPara.channel) && 0x19 == _nRet)
                    {
                        //listBox1.Items.Insert(0, "零通道预览失败，请停止设备端本地回放后再试");
                        VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlayException);

                        //return false;
                    }
                    else
                    {
                        //return false;
                        //listBox1.Items.Insert(0, "启动现场流预览失败");
                        VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlayException);

                    }

                    StateReset();

                    return false;
                }

                _nRet = SDK_BlueSDK.dvxRealImageEnhance(RealHandle, bImageEhnace);
                if ((int)dvxSdkType.ReturnError.DVX_OK == _nRet)
                {
                    m_IPCPreViewPara.bImageEhnace = false;
                }
                _nRet = SDK_BlueSDK.dvxRealStart(RealHandle);
                if ((int)dvxSdkType.ReturnError.DVX_OK != _nRet)
                {
                    //listBox1.Items.Insert(0, "开始现场流预览失败");
                    VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlayException);

                    StateReset();
                    return false;
                }
                VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlay);

                if (CurrentVideoPlaySet.VideoRecordEnable)
                {
                    //录像
                    if (RealHandle == IntPtr.Zero)
                    {
                        //没有预览

                    }
                    else
                    {
                        BlueSkyVideo_VideoRecordStart(CurrentVideoPlaySet.VideoRecordFilePath);
                    }
                }

                return true;
                //}
            }




        }

        /// <summary>
        /// 获取设备类型
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public int GetDevType(byte[] version)
        {

            string strver = Encoding.ASCII.GetString(version);
            if (strver.Length > 4)
            {
                strver = strver.Substring(0, 4);
            }
            int nType = 0;
            if (version == null)
            {

            }
            else if (string.Compare(strver, "2030") == 0 || string.Compare(strver, "2130") == 0 || string.Compare(strver, "2230") == 0)
            {
                nType = 2;
            }
            else if (string.Compare(strver, "2033") == 0 || string.Compare(strver, "2034") == 0 || string.Compare(strver, "2035") == 0 || string.Compare(strver, "2036") == 0)
            {
                nType = 1;
            }
            return nType;
        }

        /// <summary>
        /// //判断IPC类型
        /// </summary>
        /// <param name="pMode"></param>
        public void CheckIPCType(byte[] pMode)
        {
            string strpMode = Encoding.ASCII.GetString(pMode);
            do
            {
                //区分日夜型
                do
                {
                    if ((0 == string.Compare(strpMode, "BSR-IM1150-A0207")) || (0 == string.Compare(strpMode, "BSR-IM1150-B0207")) || (0 == string.Compare(strpMode, "BS-IS1150-B0207")) ||
                      (0 == string.Compare(strpMode, "BSR-IM1150-A0201")) || (0 == string.Compare(strpMode, "BSR-IM1150-B0201")) || (0 == string.Compare(strpMode, "BS-IS1150-B0201")) ||
                      (0 == string.Compare(strpMode, "BSR-IM1110-A0501")) || (0 == string.Compare(strpMode, "BSR-IM1110-B0501")) || (0 == string.Compare(strpMode, "BS-IS1110-B0501")) ||
                      (0 == string.Compare(strpMode, "BSR-IM2130-A0501")) || (0 == string.Compare(strpMode, "BSR-IM2130-B0501")) || (0 == string.Compare(strpMode, "BS-IS2130-B0501")) ||
                      (0 == string.Compare(strpMode, "BSR-IM1110-A0507")) || (0 == string.Compare(strpMode, "BSR-IM1110-B0507")) || (0 == string.Compare(strpMode, "BS-IS1110-B0507")) ||
                      (0 == string.Compare(strpMode, "BSR-IM1110-B0201")) || (0 == string.Compare(strpMode, "BS-IS1110-B0201")) ||
                      (0 == string.Compare(strpMode, "BSR-IM2130-B0201")) || (0 == string.Compare(strpMode, "BS-IS2130-B0201") ||
                      (0 == string.Compare(strpMode, "BSR-IM2230-B0501")) || (0 == string.Compare(strpMode, "BS-IS2230-B0501")) || (0 == string.Compare(strpMode, "BSR-IM2230-B0201")) ||
                      (0 == string.Compare(strpMode, "BS-IS2230-B0201")) || (0 == string.Compare(strpMode, "BSR-IM2210-B0501")) || (0 == string.Compare(strpMode, "BS-IS2210-B0501")) ||
                      (0 == string.Compare(strpMode, "BSR-IM2210-B0201")) || (0 == string.Compare(strpMode, "BS-IS2210-B0201")))
                      )
                    {
                        g_IpcDif |= 256;
                    }

                } while (false);

                //区分智能
                do
                {
                    if ((0 == string.Compare(strpMode, "BSR-IM1150-A0007")) || (0 == string.Compare(strpMode, "BSR-IM1150-B0007")) || (0 == string.Compare(strpMode, "BSR-IM1150-A0207")) ||
                      (0 == string.Compare(strpMode, "BSR-IM1150-B0207")) || (0 == string.Compare(strpMode, "BS-IS1150-B0207")) || (0 == string.Compare(strpMode, "BSR-IM1110-A0507")) ||
                      (0 == string.Compare(strpMode, "BSR-IM1110-B0507")) || (0 == string.Compare(strpMode, "BS-IS1110-B0507"))
                      )
                    {
                        g_IpcDif |= 32768;
                    }

                } while (false);

                //区分宽动态
                do
                {
                    if ((0 == string.Compare(strpMode, "BSR-IM1110-A0501")) || (0 == string.Compare(strpMode, "BSR-IM1110-B0501")) || (0 == string.Compare(strpMode, "BS-IS1110-B0501")) ||
                      (0 == string.Compare(strpMode, "BSR-IM2130-A0501")) || (0 == string.Compare(strpMode, "BSR-IM2130-B0501")) || (0 == string.Compare(strpMode, "BS-IS2130-B0501")) ||
                      (0 == string.Compare(strpMode, "BSR-IM1110-A0507")) || (0 == string.Compare(strpMode, "BSR-IM1110-B0507")) || (0 == string.Compare(strpMode, "BS-IS1110-B0507") ||
                      (0 == string.Compare(strpMode, "BSR-IM2230-B0501")) || (0 == string.Compare(strpMode, "BS-IS2230-B0501")) ||
                      (0 == string.Compare(strpMode, "BSR-IM2210-B0501")) || (0 == string.Compare(strpMode, "BS-IS2210-B0501")))
                      )
                    {
                        g_IpcDif |= 128;
                    }

                } while (false);

                //背光补偿、强光抑制、数字降噪（含半球机型及320W像素机型）
                do
                {
                    if ((0 == string.Compare(strpMode, "BSR-IM2230-B0501")) || (0 == string.Compare(strpMode, "BS-IS2230-B0501")) || (0 == string.Compare(strpMode, "BSR-IM2230-B0201")) ||
                      (0 == string.Compare(strpMode, "BS-IS2230-B0201")) || (0 == string.Compare(strpMode, "BSR-IM2210-B0501")) || (0 == string.Compare(strpMode, "BS-IS2210-B0501")) ||
                      (0 == string.Compare(strpMode, "BSR-IM2210-B0201")) || (0 == string.Compare(strpMode, "BS-IS2210-B0201")) ||
                      (0 == string.Compare(strpMode, "BSR-IM2130-A0501")) || (0 == string.Compare(strpMode, "BSR-IM2130-B0501")) || (0 == string.Compare(strpMode, "BSR-IM2130-B0201")) ||
                      (0 == string.Compare(strpMode, "BS-IS2130-B0501")) || (0 == string.Compare(strpMode, "BS-IS2130-B0201"))
                      )
                    {
                        g_IpcDif |= 512; //背光补偿
                        g_IpcDif |= 2048; //强光抑制
                        g_IpcDif |= 1024; //数字降噪
                    }

                } while (false);


            } while (false);
        }

        public void StateReset()
        {
            RealHandle = IntPtr.Zero;
            m_IPCPreViewPara.bImageEhnace = false;
            m_IPCPreViewPara.channels = (Char)1;
            m_IPCPreViewPara.subStream = (Char)0;
            m_IPCPreViewPara.transProc = (Char)1;
        }

        /// <summary>
        /// 录像回放
        /// </summary>
        /// <param name="strRecFilePath"></param>
        /// <returns></returns>
        public bool BlueSkyVideo_VideoRecordStart(string strRecFilePath)
        {
            StringBuilder sbRecFilePath = new StringBuilder();
            if (string.IsNullOrEmpty(strRecFilePath))
            {
                //不存在路径 使用默认路径 
                strRecFilePath = ProgConstants.strBlueSkyVideo_RecDicPath + "\\" + CurrentVideoInfo.DVSAddress;    //默认路径
                if (!Directory.Exists(strRecFilePath))
                {
                    //文件夹不存在，创建文件夹
                    Directory.CreateDirectory(strRecFilePath);
                }
            }
            if (!strRecFilePath.EndsWith(".bsr"))
            {
                //后缀错误，使用默认文件生成
                //默认路径格式 [当前工作路径/XMVideoRecFile/DVSAddress/时间(yyyyMMddHHmmss)_通道号(01)]

                strRecFilePath += "\\" + VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel, CurrentVideoInfo.VideoType);
            }
            _nRet = SDK_BlueSDK.dvxRealStartSaveAs(RealHandle, strRecFilePath, 1, 1); //avi - 6 brs - 1
            if ((int)dvxSdkType.ReturnError.DVX_OK != _nRet)
            {
                //录像启动不成功
                VideoPlayEventCallBack(Enum_VideoPlayEventType.StartVideoRecordException);
                return false;
            }
            VideoPlayEventCallBack(Enum_VideoPlayEventType.StartVideoRecord);
            return true;
            //bool bolResult = SDK_XMSDK.H264_DVR_StartLocalRecord(m_iPlayhandle, strRecFilePath, Convert.ToInt32(MEDIA_FILE_TYPE.MEDIA_FILE_NONE));
            //return bolResult;
        }
    }
}
