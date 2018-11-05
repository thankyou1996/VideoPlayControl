/*****************************************************
Copyright 2007-2008 Hikvision Digital Technology Co., Ltd.   
FileName: client.h
Description:  	 
Author: guanguochen       
Date: 2008.5.11     
*****************************************************/
#ifndef __CLIENT_H__
#define __CLIENT_H__

#ifdef CLIENT_EXPORTS
#define CLIENT_API __declspec(dllexport)
#else
#define CLIENT_API __declspec(dllimport)
#endif

#ifdef __cplusplus
extern "C" {
#endif

#include "clntsink.h"
typedef int (__stdcall *pDataRec)(int sid, int iusrdata, int idatatype, char* pdata, int ilen);
typedef int (__stdcall *pMsgBack)(int sid, int opt, int param1, int param2);
typedef int HSESSION;

CLIENT_API int __stdcall InitStreamClientLib(void);
CLIENT_API int __stdcall FiniStreamClientLib(void);
CLIENT_API HSESSION __stdcall HIKS_CreatePlayer(IHikClientAdviseSink* pSink, void* pWndSiteHandle, pDataRec pRecFunc, pMsgBack pMsgFunc = 0,int TransMethod = 0);
CLIENT_API int __stdcall HIKS_OpenURL(HSESSION hSession,const char* pszURL,int iusrdata);
CLIENT_API int __stdcall HIKS_Play(HSESSION hSession);
CLIENT_API int __stdcall HIKS_RandomPlay(HSESSION hSession,unsigned long timepos);
CLIENT_API int __stdcall HIKS_Pause(HSESSION hSession);
CLIENT_API int __stdcall HIKS_Resume(HSESSION hSession);
CLIENT_API int __stdcall HIKS_Stop(HSESSION hSession);
CLIENT_API int __stdcall HIKS_GetCurTime(HSESSION hSession,unsigned long *utime);
CLIENT_API int __stdcall HIKS_ChangeRate(HSESSION hSession,int scale);
CLIENT_API int __stdcall HIKS_Destroy(HSESSION hSession);
CLIENT_API int __stdcall HIKS_GetVideoParams(HSESSION hSession, int *ibri, int *icon, int *isat, int *ihue);
CLIENT_API int __stdcall HIKS_SetVideoParams(HSESSION hSession, int ibri, int icon, int isat, int ihue);
CLIENT_API int __stdcall HIKS_PTZControl(HSESSION hSession, unsigned int ucommand, int iparam1, int iparam2, int iparam3, int iparam4);
CLIENT_API int __stdcall HIKS_SetVolume(HSESSION hSession,unsigned short volume);
CLIENT_API int __stdcall HIKS_OpenSound(HSESSION hSession,bool bExclusive=false);
CLIENT_API int __stdcall HIKS_CloseSound(HSESSION hSession);
CLIENT_API int __stdcall HIKS_ThrowBFrameNum(HSESSION hSession,unsigned int nNum);
CLIENT_API int __stdcall HIKS_GrabPic(HSESSION hSession,const char* szPicFileName, unsigned short byPicType);

#ifdef __cplusplus
}
#endif

#endif

/**************************/
/*云台控制命令码及参数定义*/
/************************************************************************************************
2	－	接通灯光电源			(Param1: 1-开始/0-停止, Param2: 无效, Param3: 无效, Param4: 无效)
3	－	接通雨刷开关			(Param1: 1-开始/0-停止, Param2: 无效, Param3: 无效, Param4: 无效)
4	－	接通风扇开关			(Param1: 1-开始/0-停止, Param2: 无效, Param3: 无效, Param4: 无效)
5	－	接通加热器开关			(Param1: 1-开始/0-停止, Param2: 无效, Param3: 无效, Param4: 无效)
6	－	接通辅助设备开关		(Param1: 1-开始/0-停止, Param2: 无效, Param3: 无效, Param4: 无效)

11	－	焦距变大(倍率变大)		(Param1: 1-开始/0-停止, Param2: 速度 [0-10,0表示默认速度,1-10表示速度级别], Param3: 无效, Param4: 无效)
12	－	焦距变小(倍率变小)		(Param1: 1-开始/0-停止, Param2: 速度 [0-10,0表示默认速度,1-10表示速度级别], Param3: 无效, Param4: 无效)
13	－	焦点前调				(Param1: 1-开始/0-停止, Param2: 速度 [0-10,0表示默认速度,1-10表示速度级别], Param3: 无效, Param4: 无效)
14	－	焦点后调				(Param1: 1-开始/0-停止, Param2: 速度 [0-10,0表示默认速度,1-10表示速度级别], Param3: 无效, Param4: 无效)
15	－	光圈扩大				(Param1: 1-开始/0-停止, Param2: 速度 [0-10,0表示默认速度,1-10表示速度级别], Param3: 无效, Param4: 无效)
16	－	光圈缩小				(Param1: 1-开始/0-停止, Param2: 速度 [0-10,0表示默认速度,1-10表示速度级别], Param3: 无效, Param4: 无效)

21	－	云台上仰				(Param1: 1-开始/0-停止, Param2: 速度 [0-10,0表示默认速度,1-10表示速度级别], Param3: 无效, Param4: 无效)
22	－	云台下俯				(Param1: 1-开始/0-停止, Param2: 速度 [0-10,0表示默认速度,1-10表示速度级别], Param3: 无效, Param4: 无效)
23	－	云台左转				(Param1: 1-开始/0-停止, Param2: 速度 [0-10,0表示默认速度,1-10表示速度级别], Param3: 无效, Param4: 无效)
24	－	云台右转				(Param1: 1-开始/0-停止, Param2: 速度 [0-10,0表示默认速度,1-10表示速度级别], Param3: 无效, Param4: 无效)
25	－	云台上仰和左转			(Param1: 1-开始/0-停止, Param2: 速度 [0-10,0表示默认速度,1-10表示速度级别], Param3: 无效, Param4: 无效)
26	－	云台上仰和右转			(Param1: 1-开始/0-停止, Param2: 速度 [0-10,0表示默认速度,1-10表示速度级别], Param3: 无效, Param4: 无效)
27	－	云台下俯和左转			(Param1: 1-开始/0-停止, Param2: 速度 [0-10,0表示默认速度,1-10表示速度级别], Param3: 无效, Param4: 无效)
28	－	云台下俯和右转			(Param1: 1-开始/0-停止, Param2: 速度 [0-10,0表示默认速度,1-10表示速度级别], Param3: 无效, Param4: 无效)
29	－	云台左右自动扫描		(Param1: 1-开始/0-停止, Param2: 速度 [0-10,0表示默认速度,1-10表示速度级别], Param3: 无效, Param4: 无效)

40	－	*设置预置点				(Param1: 预置点序号[>=0], Param2: 无效, Param3: 无效, Param4: 无效)
41	－	*清除预置点				(Param1: 预置点序号[>=0], Param2: 无效, Param3: 无效, Param4: 无效)
42	－	*转到预置点				(Param1: 预置点序号[>=0], Param2: 无效, Param3: 无效, Param4: 无效)

51  -   *开始设置巡航路径		(Param1: 无效, Param2: 无效, Param3: 无效, Param4: 无效)
52  -	*结束设置巡航路径		(Param1: 无效, Param2: 无效, Param3: 无效, Param4: 无效)
53	－	*将预置点加入巡航序列	(Param1: 巡航路线号[>=0], Param2: 巡航点序号[>=0], Param3: 预置点序号[>=0], Param4: 无效)
54	－	*开始巡航				(Param1: 巡航路线号[>=0], Param2: 无效, Param3: 无效, Param4: 无效)
55	－	*停止巡航				(Param1: 巡航路线号[>=0], Param2: 无效, Param3: 无效, Param4: 无效)
56	-	*将预置点从巡航序列删除	(Param1: 巡航路线号[>=0], Param2: 巡航点序号[>=0], Param3: 无效, Param4: 无效)
57	-	*设置巡航点停顿时间		(Param1: 巡航路线号[>=0], Param2: 巡航点序号[>=0], Param3: 停顿时间[秒,>=0], Param4: 无效)
58  -   *设置巡航速度			(Param1: 巡航路线号[>=0], Param2: 巡航点序号[>=0], Param3: 巡航速度[1-10], Param4: 无效)

61	－	*开始记录轨迹			(Param1: 无效, Param2: 无效, Param3: 无效, Param4: 无效)
62	－	*停止记录轨迹			(Param1: 无效, Param2: 无效, Param3: 无效, Param4: 无效)
63	－	*开始轨迹				(Param1: 无效, Param2: 无效, Param3: 无效, Param4: 无效)

71  -   球机放大缩小			(Param1: 方框起始点的x坐标, Param2: 方框结束点的y坐标, Param3: 方框结束点的x坐标, Param4: 方框结束点的y坐标)

99	－	*系统复位				(Param1: 无效, Param2: 无效, Param3: 无效, Param4: 无效)

********************************************************************************************************/