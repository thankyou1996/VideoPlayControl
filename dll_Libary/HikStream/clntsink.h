/*****************************************************
Copyright 2007-2008 Hikvision Digital Technology Co., Ltd.   
FileName: clntsink.h
Description:  	 
Author: guanguochen       
Date: 2008.5.11     
*****************************************************/

#ifndef __CLIENT_SINK_H__
#define __CLIENT_SINK_H__

//回调函数的集合类

class IHikClientAdviseSink
{
public:
	/******************************************************************
	在Setup时被调用,获取总的播放长度.nLength为总的播放长度,以1/64秒为单位
	*/
	virtual int OnPosLength(unsigned long nLength) = 0;

	/******************************************************************
     在Setup后被调用,表示URL已经被成功打开,sucess为1表示成功,0表示失败
	*/
	virtual int OnPresentationOpened(int success) = 0;

	 /************************************************************************
     在Player被停止销毁后调用
     */
	virtual int OnPresentationClosed() = 0;

	 /************************************************************************
     未使用
     */
	virtual int OnPreSeek(unsigned long uOldTime, unsigned long uNewTime) = 0;

	 /************************************************************************
     未使用
     */
	virtual int OnPostSeek(unsigned long uOldTime, unsigned long uNewTime) = 0;

	 /************************************************************************
     未使用
	 */	
	virtual int OnStop() = 0;

	 /************************************************************************
     在Pause时被调用，uTime目前都是0
     */
	virtual int OnPause(unsigned long uTime) = 0;

	/************************************************************************
     在开始播放时调用，uTime目前都是0
     */
	virtual int OnBegin(unsigned long uTime) = 0;

     /************************************************************************
     在随机播放时调用，uTime目前都是0
     */
	virtual int OnRandomBegin(unsigned long uTime) = 0;

	/************************************************************************
     在Setup前调用，pszHost表示正在连接的服务器
     */
	virtual int OnContacting(const char* pszHost) = 0;
    
	/************************************************************************
	在服务器端返回出错信息是调用， pError中为出错信息内容
	*/
	virtual int OnPutErrorMsg(const char* pError) = 0;
	
	/************************************************************************
    未使用
     */
	virtual int OnBuffering(unsigned int uFlag, unsigned short uPercentComplete) = 0;

	virtual int OnChangeRate(int flag) = 0;

	virtual int OnDisconnect() = 0;

};

#endif

