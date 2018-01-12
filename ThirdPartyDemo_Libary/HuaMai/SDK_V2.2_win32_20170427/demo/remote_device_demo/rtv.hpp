#ifndef __RTV_H__
#define __RTV_H__
#include <windows.h>
#include <map>
#include "hmsdk/hm_sdk.h"

struct rtv_play_t;
std::map<HWND, rtv_play_t*> g_rtv_param_map;

LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam);
static void OnRecvRealTimeVideo(pointer user_data, P_FRAME_DATA frame, uint32 err);	//	接收视频数据回调
static rtv_play_t* Query(HWND hwnd);	//	根据窗口句柄查询实时视频对象
static DWORD WINAPI UIThread(LPVOID param);

struct rtv_play_t
{
	typedef rtv_play_t self_t;

public :
	explicit rtv_play_t(uint32 id) : id_(id), port_() {}
	~rtv_play_t() {}

public :
	void OpenVideo(node_handle dev)
	{
		if(!dev) return;
		hm_result res;
		CONNECT_INFO ci = {};
		ci.ct = CT_PC;
		ci.cp = CPI_DEF;
		ci.cm = CM_DEF;
		if((res = hm_pu_login_ex(dev, &ci, &uid_)) != HMEC_OK)
		{
			printf("---登录失败 : %x---\n", res);
			return;
		}
		else
		{
			printf("---登录成功---\n");
		}
		i_open_video();
	}

	void OpenVideo(cpchar ip, uint16 port, cpchar sn, cpchar usr, cpchar pwd)
	{
		if(!ip || !usr || port == 0) return;
		hm_result res;
		if((res = hm_pu_login(ip, port, sn, usr, pwd, CT_PC, &uid_)) != HMEC_OK)
		{
			printf("---连接出错 : %x---\n", res);
			return;
		}
		else
		{
			printf("---登录成功---\n");
		}
		i_open_video();
	}

public :
	HWND CreateMainWindow(LPCTSTR cap, UINT w, UINT h)
	{
		HINSTANCE hInst = ::GetModuleHandle(0);
		WNDCLASSEX wcex;
		wcex.cbSize			= sizeof(WNDCLASSEX);
		wcex.style			= CS_HREDRAW | CS_VREDRAW;
		wcex.lpfnWndProc	= WndProc;
		wcex.cbClsExtra		= 0;
		wcex.cbWndExtra		= 0;
		wcex.hInstance		= hInst;
		wcex.hIcon			= 0;
		wcex.hCursor		= LoadCursor(NULL, IDC_ARROW);
		wcex.hbrBackground	= (HBRUSH)(COLOR_WINDOWFRAME);
		wcex.lpszMenuName	= 0;
		wcex.lpszClassName	= cap;
		wcex.hIconSm		= 0;
		RegisterClassEx(&wcex);

		HWND hwnd = CreateWindow(cap, cap, 
			WS_OVERLAPPEDWINDOW,
			CW_USEDEFAULT, 0, CW_USEDEFAULT, 0, NULL, NULL, hInst, NULL);
		if(!hwnd) return 0;

		HWND deskhwnd = GetDesktopWindow();
		RECT deskrect;
		GetWindowRect(deskhwnd, &deskrect);
		int32 width = deskrect.right - deskrect.left;
		int32 height = deskrect.bottom - deskrect.top;
		SetWindowPos(hwnd, HWND_TOP, (width - w) / 2, (height - h) / 2, w, h, SWP_SHOWWINDOW);

		return hwnd;
	}

private :
	void i_open_video()
	{
		OPEN_VIDEO_PARAM ovp = {};
		ovp.channel = 0;
		ovp.cs_type = HME_CS_MAJOR;
		ovp.data = this;
		ovp.vs_type = HME_VS_REAL;
		ovp.cb_data = &OnRecvRealTimeVideo;

		hm_result res;
		if((res = hm_pu_open_video(uid_, &ovp, &hvideo_)) != HMEC_OK)
		{
			printf("---open video 失败 : %x---\n", res);
			return;
		}
		else
		{
			printf("---open video 成功---\n");
		}

		//	开启UI线程
		thread_ = ::CreateThread(0, 0, UIThread, this, 0, 0);
	}

public :
	OPEN_VIDEO_RES	ovr_;		//	视频信息
	user_id			uid_;		//	一条连接好的设备句柄
	video_handle	hvideo_;	//	实时视频句柄
	port_handle		port_;		//	播放句柄
	HANDLE			thread_;	//	UI线程
	uint32			id_;
};

DWORD WINAPI UIThread(LPVOID param)
{
	rtv_play_t* player = (rtv_play_t*)param;

	hm_result res;
	res = hm_pu_start_video(player->hvideo_, &(player->ovr_));
	if(res != HMEC_OK)
	{
		printf("---start video 失败 : %x---\n", res);
		return 0;
	}
	else
	{
		printf("---start video 成功---\n");
	}

	int32 video_weight, video_height;
	uint32 code_type;
	video_weight = player->ovr_.image_width;
	video_height = player->ovr_.image_height;
	code_type = player->ovr_.encode_type;

	//	根据打开的视频信息创建窗口
	char buf[15] = {};
	sprintf(buf, "RTV Demo %d", player->id_);
	HWND hwnd = player->CreateMainWindow(buf, 800, 450);
	if(!hwnd) return 0;

	DISPLAY_OPTION disp_op = {};
	disp_op.dm = HME_DM_DX;
	disp_op.pq = HME_PQ_HIGH;
	res = hm_video_display_open_port(hwnd, &disp_op, &(player->port_));
	hm_video_display_start(player->port_, 0, 0, 25);
	if(res != HMEC_OK) return 0;
	g_rtv_param_map.insert(std::pair<HWND, rtv_play_t*>(hwnd, player));

	MSG msg;
	while(GetMessage(&msg, 0, 0, 0))
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}

	return 0;
}

static void OnRecvRealTimeVideo(pointer user_data, P_FRAME_DATA frame, uint32 err)
{
	if(!user_data) return;
	if (err)
	{
		printf("recv err = %x\n", err);
		return;
	}
 	rtv_play_t* prtv = (rtv_play_t*)user_data;

	while(!prtv->port_) Sleep(1);

	if(frame->frame_info.frame_type == HME_RFT_P || frame->frame_info.frame_type == HME_RFT_I || 
		frame->frame_info.frame_type == HME_RFT_H265_P || frame->frame_info.frame_type == HME_RFT_H265_I)
	{
		hm_video_display_input_data(prtv->port_, frame->frame_stream, frame->frame_len, true);
	}
}

static void OnRecvRealTimeAudio(pointer user_data, P_FRAME_DATA frame, uint32 err)
{
	return;
}

LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	rtv_play_t* prtv = Query(hWnd);
	if(!prtv) return DefWindowProc(hWnd, message, wParam, lParam);

	switch(message)
	{
	case WM_KEYDOWN :
		{
			switch(wParam)
			{
			case VK_RETURN :
				{
					hm_result res;
					res = hm_pu_force_iframe(prtv->hvideo_);
				}
				break;
			case VK_SPACE :
				{
					hm_pu_stop_video(prtv->hvideo_);
					hm_pu_close_video(prtv->hvideo_);

					{
						static int i = 1;
						OPEN_VIDEO_PARAM ovp = {};
						ovp.channel = 0;
						ovp.cs_type = (CODE_STREAM)((++i % 2) + 1);
						ovp.data = prtv;
						ovp.vs_type = HME_VS_REAL;
						ovp.cb_data = &OnRecvRealTimeVideo;
						if(hm_pu_open_video(prtv->uid_, &ovp, &prtv->hvideo_) != HMEC_OK)
						{
							printf("---打开视频失败---\n");
							break;
						}

						OPEN_VIDEO_RES ovr = {};
						if(hm_pu_start_video(prtv->hvideo_, &ovr) != HMEC_OK)
						{
							printf("高标清切换失败\n");
						}
						else
						{
							printf("高标清切换成功\n");
						}
					}
				}
				break;
			case VK_LEFT :	hm_pu_ptz_control(prtv->uid_, 0, HME_PC_LEFT, 5);	break;
			case VK_UP :	hm_pu_ptz_control(prtv->uid_, 0, HME_PC_UP, 5);		break;
			case VK_RIGHT : hm_pu_ptz_control(prtv->uid_, 0, HME_PC_RIGHT, 5);	break;
			case VK_DOWN :	hm_pu_ptz_control(prtv->uid_, 0, HME_PC_DOWN, 5);	break;
			case VK_ESCAPE :	break;
			case VK_CONTROL :	break;
			case VK_SHIFT :		break;
			default :			break;
			}
		}
		break;
	default :
		break;
	}

	return DefWindowProc(hWnd, message, wParam, lParam);
}

static rtv_play_t* Query(HWND hwnd)
{
	if(!hwnd) return 0;
	std::map<HWND, rtv_play_t*>::const_iterator iter = g_rtv_param_map.find(hwnd);
	if(iter != g_rtv_param_map.end()) return iter->second;
	return 0;
}

#endif //	__RTV_H__
