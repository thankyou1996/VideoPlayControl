using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace VIdeoPlayControl_UseDemo3
{
    public class NVSSDK
    {

        public const string SDKFolder = "\\TDWYSDK";

        /// <summary>
        /// SDK路径
        /// </summary>
        //public const string SDKFilePath = SDKFolder + "\\NVSSDK.dll";
        public const string SDKFilePath =  "NVSSDK.dll";

        /// <summary>
        /// NSLook
        /// </summary>
        public const string SDKFilePath_nslook = SDKFolder + "\\nslook.dll";

        public const string SDKFilePath_playsdkm4 = SDKFolder + "\\playsdkm4.dll";

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_Startup_V4(Int32 _iServerPort, Int32 _iClientPort, Int32 _iWnd);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_SetNotifyFunction_V4(
                                            MAIN_NOTIFY_V4 _MainNotify,
                                            ALARM_NOTIFY_V4 _AlarmNotify,
                                            PARACHANGE_NOTIFY_V4 _ParaNotify,
                                            COMRECV_NOTIFY_V4 _ComNotify,
                                            PROXY_NOTIFY _ProxyNotify);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_SetMSGHandleEx(UInt32 _uiMessage, IntPtr _hWnd, UInt32 _uiParaMsg, UInt32 _uiAlarmMsg);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_Logon_V4(Int32 _iLogonType, IntPtr _pvPara, Int32 _iInBufferSize);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_Logoff(Int32 _iLogonId);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_GetChannelNum(Int32 _iLogonID, ref Int32 _piChanNum);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_StartRecv(ref UInt32 _uiConID, ref CLIENTINFO _cltInfo, RECVDATA_NOTIFY _cbkDataArrive);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_StopRecv(Int32 _uiConID);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_StartPlay(Int32 _uiConID, IntPtr _hWnd, RECT _rcShow, Int32 _iDecflag);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_StopPlay(Int32 _uiConID);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_StartCaptureFile(Int32 _uiConID, String _pszFilePath, Int32 _iRecordFileType);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_StopCaptureFile(Int32 _uiConID);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_CapturePicture(Int32 _uiConID, Int32 _iPicType, String _pcFileName);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_GetUserNum(Int32 _iLogonID, ref Int32 _piUserNum);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_GetUserInfo(Int32 _iLogonID, Int32 _iUserSerial, IntPtr _cUserName, IntPtr _cPassword, ref Int32 _iAuthority);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_AddUser(Int32 _iLogonID, String _cUserName, String _cPassword, Int32 _iAuthority);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_DelUser(Int32 _iLogonID, String _cUserName);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_ModifyPwd(Int32 _iLogonID, String _cUserName, String _cNewPwd);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_SetVideoPara(Int32 _iLogonID, Int32 _iChanNO, ref STR_VideoParam _tParam);

        [DllImport(SDKFilePath, SetLastError = true)]
        public static extern Int32 NetClient_DeviceCtrlEx(Int32 _iLogonID, Int32 _iChannelNum, Int32 _iActionType, Int32 _iParam1, Int32 _iParam2, Int32 _iControlType);

        [DllImport(SDKFilePath, SetLastError = true)]
        public static extern Int32 NetClient_DrawRectOnLocalVideo(Int32 _uiConID, ref RECT _rcRect, int _iCount);

        [DllImport(SDKFilePath, SetLastError = true)]
        public static extern Int32 NetClient_GetVideoSize(int _iLogonID, int _iChannelNum, ref int _width, ref int _height, int _iStreamNO);

        [DllImport(SDKFilePath, SetLastError = true)]
        public static extern Int32 NetClient_SendCommand(int _iLogonID, int _iCommand, int _iChannel, IntPtr _pBuffer, int _iBufferSize);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_GetAlarmPortNum(Int32 _iLogonID, ref Int32 _iAlarmChannelNo, ref Int32 _iAlarmOutPortNum);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_Query_V5(Int32 _iLogonId, Int32 _iCmdId, Int32 _iChanNo, IntPtr _lpIn, Int32 _iInLen, IntPtr _lpOut, Int32 _iOutLen);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_NetFileGetFileCount(Int32 _iLogonID, ref Int32 iTotalCount, ref Int32 _iCurrentCount);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_PlayBackControl(Int32 _ulConID, int _iControlCode, IntPtr _pcInBuffer, int _iInLen, IntPtr _pcOutBuffer, ref Int32 _iOutLen);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_PlayBack(ref Int32 _ulConID, int _iCmd, ref PlayerParam _PlayerParam, IntPtr _hWnd);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_StopPlayBack(Int32 _ulConID);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_NetFileDownload(ref Int32 _ulConID, int _iLogonID, int _iCmd, IntPtr _lpBuf, int _iBufSize);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_NetFileStopDownloadFile(Int32 _ulConID);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_NetFileGetDownloadPos(Int32 _uiConID, ref Int32 _iPos, ref Int32 _dlSize);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_SetRawFrameCallBack(Int32 _uiConID, RAWFRAME_NOTIFY _cbkGetFrame, IntPtr _pContext);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_SetDevConfig(Int32 _iLogonID, Int32 _iCommand, Int32 _iChannel, IntPtr _lpInBuffer, int _iInBufferSize);

        [DllImport(SDKFilePath)]
        public static extern Int32 NetClient_GetDevConfig(Int32 _iLogonID, Int32 _iCommand, Int32 _iChannel, IntPtr _lpOutBuffer, int _iOutBufferSize, ref int _lpBytesReturned);


        //主回调
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void MAIN_NOTIFY_V4(Int32 _ulLogonID, Int32 _iWparam, IntPtr _iLParam, IntPtr _iUser);
        //报警回调
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ALARM_NOTIFY_V4(Int32 _ulLogonID, Int32 _iChan, Int32 _iAlarmState, Int32 _iAlarmType, IntPtr _iUser);
        //参数改变回调
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void PARACHANGE_NOTIFY_V4(Int32 _ulLogonID, Int32 _iChan, Int32 _iParaType, IntPtr _strPara, IntPtr _iUser);
        //串口数据回调
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void COMRECV_NOTIFY_V4(Int32 _ulLogonID, IntPtr _cData, Int32 _iLen, Int32 _iComNo, IntPtr _iUser);
        //代理回调
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void PROXY_NOTIFY(Int32 _ulLogonID, Int32 _iCmdKey, IntPtr _cData, Int32 _iLen, IntPtr _iUser);

        public delegate void RECVDATA_NOTIFY(uint _ulID, string _strData, int _iLen);

        //登录参数
        [StructLayout(LayoutKind.Sequential)]
        public struct LogonPara
        {
            public int iSize;           //Structure size
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public Char[] cProxy;           //The ip address of the upper-level proxy to which the video is connected,not more than 32 characters, including '\0'
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public Char[] cNvsIP;           //IP address，not more than 32 characters, including '\0'
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public Char[] cNvsName;     //Nvs name. Used for domain name resolution
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public Char[] cUserName;        //Login Nvs username，not more than 16 characters, including '\0'
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public Char[] cUserPwd;     //Login Nvs password，not more than 16 characters, including '\0'
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public Char[] cProductID;       //Product ID，not more than 32 characters, including '\0'
            public int iNvsPort;        //The communication port used by the Nvs server, if not specificed,Use the system default port(3000)
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public Char[] cCharSet;     //Character set
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public Char[] cAccontName;  //The username that connects to the contents server
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public Char[] cAccontPasswd;    //The password that connects to the contents server
        };

        //视频连接参数
        [StructLayout(LayoutKind.Sequential)]
        public struct CLIENTINFO
        {
            public int m_iServerID;         //NVS ID,NetClient_Logon
            public int m_iChannelNo;        //Remote host to be connected video channel number (Begin from 0)
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
            public Char[] m_cNetFile;       //Play the file on net, not used temporarily
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public Char[] m_cRemoteIP;      //IP address of remote host
            public int m_iNetMode;          //Select net mode 1--TCP  2--UDP  3--Multicast
            public int m_iTimeout;          //Timeout length for data receipt
            public int m_iTTL;              //TTL value when Multicast
            public int m_iBufferCount;      //Buffer number
            public int m_iDelayNum;         //Start to call play progress after which buffer is filled
            public int m_iDelayTime;        //Delay time(second), reserve
            public int m_iStreamNO;         //Stream type
            public int m_iFlag;             //0first；1 file opt
            public int m_iPosition;         //0～100，seek pos；-1，no seek
            public int m_iSpeed;            //speed value: 1，2，4，8，       
        };

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        struct vca_TPoint
        {
            public int iX;
            public int iY;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NVS_SCHEDTIME
        {
            public UInt16 m_ustStartHour;
            public UInt16 m_usStartMin;
            public UInt16 m_ustStopHour;
            public UInt16 m_ustStopMin;
            public UInt16 m_ustRecordMode;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct STR_VideoParam
        {
            public UInt16 m_ustBrightness;
            public UInt16 m_usHue;
            public UInt16 m_ustContrast;
            public UInt16 m_ustSaturation;
            [MarshalAs(UnmanagedType.Struct)]
            public NVS_SCHEDTIME m_strctTempletTime;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct Locate3DPosition
        {
            public Int32 iBufSize;
            public Int32 iPointNum;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public vca_TPoint[] tPoint;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NVS_FILE_TIME
        {
            public UInt16 m_iYear;   /* Year */
            public UInt16 m_iMonth;  /* Month */
            public UInt16 m_iDay;    /* Day */
            public UInt16 m_iHour;   /* Hour */
            public UInt16 m_iMinute; /* Minute */
            public UInt16 m_iSecond; /* Second */
        }

        [StructLayout(LayoutKind.Sequential)]
        class NETFILE_QUERY_V5
        {
            public int iBufSize;
            public int iChannNo;
            public int iStreamNo;
            public int iType;
            public NVS_FILE_TIME tStartTime;
            public NVS_FILE_TIME tStopTime;
            public int iPageSize;
            public int iPageNo;
            public int iFiletype;
            public int iDevType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 65)]
            public Char[] cOtherQuery;
            public int iTriggerType;
            public int iTrigger;
            public int iQueryType;
            public int iQueryCondition;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5 * 68)]
            public Char[,] cField;
            public int iQueryChannelCount;
            public int iBufferSize;
            public IntPtr ptChannelList;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 65)]
            public Char[] cLaneNo;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 65)]
            public Char[] cVehicleType;
            public int iFileAttr;
            public NETFILE_QUERY_V5()
            {
                cOtherQuery = new char[65];
                cField = new char[5, 68];
                cLaneNo = new char[65];
                cVehicleType = new char[65];
            }
        };

        [StructLayout(LayoutKind.Sequential)]
        class NVS_FILE_DATA
        {
            public int m_iType;
            public int m_iChannel;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            public Char[] m_cFileName;
            public NVS_FILE_TIME m_struStartTime;
            public NVS_FILE_TIME m_struStoptime;
            public int m_iFileSize;
            public NVS_FILE_DATA()
            {
                m_cFileName = new char[250];
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RAWFRAME_INFO
        {
            public UInt32 nWidth;    //Video width, audio data is 0
            public UInt32 nHeight;   //Video height, audio data is 0
            public UInt32 nStamp;    //Time stamp(ms)
            public UInt32 nType;     //RAWFRAMETYPE, I Frame:0,P Frame:1,B Frame:2,Audio:5
            public UInt32 nEnCoder;  //Audio or Video encoder(Video,0:H263,1:H264, 2:MP4. Audio:0,G711_A:0x01,G711_U:0x02,ADPCM_A:0x03,G726:0x04)
            public UInt32 nFrameRate;//Frame rate
            public UInt32 nAbsStamp; //Absolute Time(s)
            public UInt32 ucBitsPerSample;// bit per sample [8/16/24] default 16
            public UInt32 uiSamplesPerSec;// Samples Per Sec，default 8000
        };

        public delegate void RAWFRAME_NOTIFY(UInt32 _ulID, IntPtr _cData, int _iLen, ref RAWFRAME_INFO _pRawFrameInfo, IntPtr _iUser);

        [StructLayout(LayoutKind.Sequential)]
        public struct RawFrameNotifyInfo
        {
            RAWFRAME_NOTIFY pcbkRawFrameNotify;     //raw data notify with play control
            public IntPtr pUserData;
            public int iForbidDecodeEnable; //whether need to play     0-play 1-no need decode and play
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PlayerParam
        {
            public int iSize;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public Char[] cFileName;
            public int iLogonID;                //remote file use
            public int iChannNo;                //remote time use
            public NVS_FILE_TIME tBeginTime;
            public NVS_FILE_TIME tEndTime;
            public int iPlayerType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public Char[] cLocalFilename;
            public int iPosition;               //file position,by 0%～100%;continue download，the pos of the file request
            public int iSpeed;                  //1，2，4，8，control file play speed, 0-pause
            public int iIFrame;             //juest send I frame 1,just play I frame;0,all play				
            public int iReqMode;                //need data mode 1,frame mode;0,stream mode					
            public int iRemoteFileLen;          //if local file is not NULL，this param set to NULL
            public int iVodTransEnable;     //enable
            public int iVodTransVideoSize;      //Video resolution
            public int iVodTransFrameRate;     //frame rate
            public int iVodTransStreamRate;    //stream rate
            public RawFrameNotifyInfo tRawNotifyInfo;       //raw frame notify with play control info
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DOWNLOAD_FILE
        {
            public int m_iSize;             //Structure size
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
            public char[] m_cRemoteFilename;    //Fornt end video file name
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
            public char[] m_cLocalFilename; //Local video file name
            public int m_iPosition;         //File location by percentage 0～100;When continue send after stop send,file pointer offset request 
            public int m_iSpeed;                //1，2，4，8，Control file play speed, 0-Suspend
            public int m_iIFrame;               //Only send I frame 1,Only play I Frame;0, All play					
            public int m_iReqMode;              //Require data mode 1,Frame mode;0,Stream mode					
            public int m_iRemoteFileLen;        //If local file is not null，the parameter set to null
            public int m_iVodTransEnable;       //Enable
            public int m_iVodTransVideoSize;    //Video pixel
            public int m_iVodTransFrameRate;   //Frame rate
            public int m_iVodTransStreamRate;  //Code rate
            public int m_iSaveFileType;
            public int m_iFileAttr;         //File attributes:0: nvr local storage; 10000: ipc storage
            public int m_iCryptType;            //iCryptType = 0, no encryption; iCryptType = 1, is AES encryption
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] m_cCryptKey;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DOWNLOAD_CONTROL
        {
            public int m_iSize;
            public int m_iPosition;
            public int m_iSpeed;
            public int m_iIFrame;
            public int m_iReqMode;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DOWNLOAD_TIMESPAN
        {
            public int m_iSize;             //Structure size
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
            public char[] m_cLocalFilename; //Local video file name
            public int m_iChannelNO;
            public NVS_FILE_TIME m_tTimeBegin;          //Start time
            public NVS_FILE_TIME m_tTimeEnd;                //End time     
            public int m_iPosition;         //File location by percentage 0～100;When continue send after stop send,file pointer offset request 
            public int m_iSpeed;                //1，2，4，8，Control file play speed, 0-Suspend
            public int m_iIFrame;               //Only send I frame 1,Only play I Frame;0, All play					
            public int m_iReqMode;              //Require data mode 1,Frame mode;0,Stream mode					
            public int m_iRemoteFileLen;        //If local file is not null，the parameter set to null
            public int m_iVodTransEnable;       //Enable
            public int m_iVodTransVideoSize;    //Video pixel
            public int m_iVodTransFrameRate;   //Frame rate
            public int m_iVodTransStreamRate;  //Code rate
            public int m_iFileFlag;            //0:Download multiple files  1:Download into a single file
            public int m_iSaveFileType;
            public int m_iStreamNo;
            public int m_iFileAttr;            //File attributes:0: nvr local storage; 10000: ipc storage
            public int m_iCryptType;            //iCryptType = 0, no encryption; iCryptType = 1, is AES encryption
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] m_cCryptKey;
        }

        public struct PlaybackProcess
        {
            public int iSize;
            public int iPlayByFileOrTime;
            public int iPlayedFrameNum;
            public int iTotalFrame;
            public int iProcess;
            public UInt32 uiCurrentPlayTime;
        }

        public struct NTPInfo
        {
            public int iSize;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] cServerAddress;

            public int iServerPort;
            public int iIntervalHour;
            public int iIntervalSec;
        }

        public class NetSDKType
        {
            public const int REC_FILE_TYPE_NORMAL = 0;
            public const int REC_FILE_TYPE_AVI = 1;
            public const int REC_FILE_TYPE_ASF = 2;
            public const int REC_FILE_TYPE_AUDIO = 3;
            public const int REC_FILE_TYPE_RAWAAC = 4;
            public const int REC_FILE_TYPE_VIDEO = 5;
            public const int REC_FILE_TYPE_MP4 = 6;
            public const int REC_FILE_TYPE_PS = 8;

            public const int CAPTURE_PICTURE_TYPE_BMP = 1;
            public const int CAPTURE_PICTURE_TYPE_JPG = 2;
        }

        public class NetSDKMsg
        {
            public const int WM_USER = 0x0400; //
            public const int WM_MAIN_MESSAGE = WM_USER + 1001;
            public const int MSG_PARACHG = WM_USER + 90910;
            public const int MSG_ALARM = WM_USER + 90911;

            public const int WCM_ERR_ORDER = 2;
            public const int WCM_ERR_DATANET = 3;
            public const int WCM_LOGON_NOTIFY = 7;
            public const int WCM_VIDEO_HEAD = 8;
            public const int WCM_VIDEO_DISCONNECT = 9;
            public const int WCM_RECORD_ERR = 13;
            public const int WCM_QUERYFILE_FINISHED = 18;
            public const int WCM_DWONLOAD_FINISHED = 19;
            public const int WCM_DWONLOAD_FAULT = 20;
            public const int WCM_DOWNLOAD_INTERRUPT = 29;
            public const int WCM_VIDEO_HEAD_EX = 181;

            public const int LOGON_SUCCESS = 0;
            public const int LOGON_ING = 1;
            public const int LOGON_RETRY = 2;
            public const int LOGON_DSMING = 3;
            public const int LOGON_FAILED = 4;
            public const int LOGON_TIMEOUT = 5;
            public const int NOT_LOGON = 6;
        }

        public class NetSDKCmd
        {
            public const int COMMAND_ID_MIN = 0;
            public const int COMMAND_ID_3D_POSITION = (COMMAND_ID_MIN + 57);

            public const int CMD_NETFILE_QUERY_MIN = 0;
            public const int CMD_NETFILE_QUERY_FILE = (COMMAND_ID_MIN + 0);

            public const int PLAY_CONTROL_PLAY = 1;                     //play start
            public const int PLAY_CONTROL_PAUSE = 2;                    //play pause
            public const int PLAY_CONTROL_SEEK = 3;
            public const int PLAY_CONTROL_FAST_FORWARD = 4;             //play fast
            public const int PLAY_CONTROL_SLOW_FORWARD = 5;             //play slow
            public const int PLAY_CONTROL_OSD = 6;                      //Add OSD
            public const int PLAY_CONTROL_GET_PROCESS = 7;              //get process
            public const int PLAY_CONTROL_START_AUDIO = 8;              //PlayAudio
            public const int PLAY_CONTROL_STOP_AUDIO = 9;               //Stop Audio
            public const int PLAY_CONTROL_SET_VOLUME = 10;              //SetVolume
            public const int PLAY_CONTROL_GET_VOLUME = 11;              //Get Volume
            public const int PLAY_CONTROL_STEPFORWARD = 12;             //stepforward
            public const int PLAY_CONTROL_START_CAPTUREFILE = 13;       //Capture File
            public const int PLAY_CONTROL_STOP_CAPTUREFILE = 14;        //Capture File
            public const int PLAY_CONTROL_START_CAPTUREPIC = 15;        //Capture Pic
            public const int PLAY_CONTROL_PLAYRECT = 16;                //Play Rect
            public const int PLAY_CONTROL_GETUSERINFO = 17;             //Get UserInfo
            public const int PLAY_CONTROL_SETDECRYPTKEY = 18;           //SetVideoDecryptKey
            public const int PLAY_CONTROL_GETFILEHEAD = 19;             //get video param
            public const int PLAY_CONTROL_SETFILEHEAD = 20;             //set file header
            public const int PLAY_CONTROL_GETFRAMERATE = 21;            //get frame rate
            public const int PLAY_CONTROL_SYC_ADD = 22;                 //add player to synch group 
            public const int PLAY_CONTROL_SYC_DEL = 23;                 //delete player from synch group
            public const int PLAY_CONTROL_GET_PLAYER_INFO = 24;         //Get Player info

            public const int GET_USERDATA_INFO_TIME = 0;

            public const int PLAYBACK_TYPE_FILE = 1;
            public const int PLAYBACK_TYPE_TIME = 2;

            public const int DOWNLOAD_CMD_MIN = 0;
            public const int DOWNLOAD_CMD_FILE = (DOWNLOAD_CMD_MIN + 0);
            public const int DOWNLOAD_CMD_TIMESPAN = (DOWNLOAD_CMD_MIN + 1);
            public const int DOWNLOAD_CMD_CONTROL = (DOWNLOAD_CMD_MIN + 2);
            public const int DOWNLOAD_CMD_FILE_CONTINUE = (DOWNLOAD_CMD_MIN + 3);
            public const int DOWNLOAD_CMD_GET_FILE_COUNT = (DOWNLOAD_CMD_MIN + 4);
            public const int DOWNLOAD_CMD_GET_FILE_INFO = (DOWNLOAD_CMD_MIN + 5);
            public const int DOWNLOAD_CMD_SET_FILE_INFO = (DOWNLOAD_CMD_MIN + 6);
            public const int DOWNLOAD_CMD_MAX = (DOWNLOAD_CMD_MIN + 7);

            public const int DOWNLOAD_FILE_TYPE_SDV = 0;
            public const int DOWNLOAD_FILE_TYPE_PS = 3;

            public const int NET_CLIENT_NTP_INFO = 100;
        }
        public class ActionControlMsg
        {
            public const int MOVE = 60;
            public const int MOVE_STOP = 61;
            public const int MOVE_UP = 1;
            public const int MOVE_DOWN = 2;
            public const int MOVE_LEFT = 3;
            public const int MOVE_RIGHT = 4;
            public const int MOVE_UP_LEFT = 6;
            public const int MOVE_UP_RIGHT = 5;
            public const int MOVE_DOWN_LEFT = 8;
            public const int MOVE_DOWN_RIGHT = 7;
            public const int ZOOM_BIG = 10;
            public const int ZOOM_SMALL = 11;
            public const int FOCUS_NEAR = 13;
            public const int FOCUS_FAR = 14;
            public const int IRIS_OPEN = 17;
            public const int IRIS_CLOSE = 18;
            public const int RAIN_ON = 19;
            public const int RAIN_OFF = 20;
            public const int LIGHT_ON = 21;
            public const int LIGHT_OFF = 22;
            public const int HOR_AUTO = 23;
            public const int HOR_AUTO_STOP = 24;
            public const int CALL_VIEW = 25;
            public const int SET_VIEW = 28;
            public const int POWER_ON = 29;
            public const int POWER_OFF = 30;
            public const int ZOOM_BIG_STOP = 32;
            public const int ZOOM_SMALL_STOP = 34;
            public const int FOCUS_FAR_STOP = 36;
            public const int FOCUS_NEAR_STOP = 38;
            public const int IRIS_OPEN_STOP = 40;
            public const int IRIS_CLOSE_STOP = 42;
        }

    }
}
