
#define DEFINE_DATA

#include "PadKillerClient.h"

#include "pkAPI_i.c"

   static WSADATA wsaData = {0};

   int __stdcall WinMain(HINSTANCE hInst,HINSTANCE hInstancePrevious,LPSTR lpCmdLine,int nCmdShow) {

   hModule = hInst;

   if ( WSAStartup(MAKEWORD(2,2),&wsaData) ) {
      MessageBox(NULL,L"There was an error starting, WSAStartup failed",L"Note",MB_OK | MB_ICONEXCLAMATION);
      return 0;
   }

   OleInitialize(NULL);

   DialogBoxParam(hModule,MAKEINTRESOURCE(IDD_PAD_KILLER),NULL,(DLGPROC)handler,NULL);

   return 0L;
   }
