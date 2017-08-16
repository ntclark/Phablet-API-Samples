
#include <Ws2tcpip.h>
#include <windows.h>
#include <stdio.h>

#ifndef RC_INVOKED
#include <Gdiplus.h>
#endif

#include "resource.h"

#include "pkAPI_i.h"

   LRESULT CALLBACK handler(HWND hwnd,UINT msg,WPARAM wParam,LPARAM lParam);
   LRESULT CALLBACK padBackgroundHandler(HWND hwnd,UINT msg,WPARAM wParam,LPARAM lParam);

#ifdef DEFINE_DATA

   HMODULE hModule = NULL;

   HWND hwndDialog = NULL;

   long lastSignatureX = 0L;
   long lastSignatureY = 0L;

   long domainMinX = 0L;
   long domainMaxX = 0L;
   long domainMinY = 0L;
   long domainMaxY = 0L;

   IBasicSignaturePad *pISignaturePad = NULL;

   WNDPROC nativeControlHandler = NULL;

#else

   extern HMODULE hModule;

   extern HWND hwndDialog;

   extern long lastSignatureX;
   extern long lastSignatureY;

   extern long domainMinX;
   extern long domainMaxX;
   extern long domainMinY;
   extern long domainMaxY;

   extern IBasicSignaturePad *pISignaturePad;

   extern WNDPROC nativeControlHandler;

#endif
