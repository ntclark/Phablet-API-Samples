
#define DEFINE_DATA

#include "PadKillerClient.h"

#include "pkAPI_i.c"

   static WSADATA wsaData = {0};

   int __stdcall WinMain(HINSTANCE hInst,HINSTANCE hInstancePrevious,LPSTR lpCmdLine,int nCmdShow) {

   hModule = hInst;

   WSAStartup(MAKEWORD(2,2),&wsaData);

   OleInitialize(NULL);

   DialogBoxParam(hModule,MAKEINTRESOURCE(IDD_PAD_KILLER),NULL,(DLGPROC)handler,NULL);

   return 0L;
   }
