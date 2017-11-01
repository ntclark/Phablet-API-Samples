
#include "PadKillerClient.h"

   Gdiplus::Bitmap *pPadBitmap = NULL;
   ULONG_PTR gdiplusToken;
   Gdiplus::GdiplusStartupInput gdiplusStartupInput = 0L;

   static long cxPad = 0L;
   static long cyPad = 0L;
   static long nativeHeight = 0L;
   static long nativeWidth = 0L;
   static long isConnected = 0L;

   WCHAR szwServerName[MAX_PATH] = {0};

   LRESULT CALLBACK handler(HWND hwnd,UINT msg,WPARAM wParam,LPARAM lParam) {

   switch ( msg ) {

   case WM_INITDIALOG: {

      CoCreateInstance(CLSID_PhabletSignaturePad,NULL,CLSCTX_ALL,IID_IBasicSignaturePad,reinterpret_cast<void **>(&pISignaturePad));

      Gdiplus::GdiplusStartup(&gdiplusToken,&gdiplusStartupInput,NULL);

      EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_CONNECT_SERVER),FALSE);

      EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_SEND_IMAGE),FALSE);
      EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_START),FALSE);
      EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_STOP),FALSE);
      EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_CLEAR),FALSE);

      RECT rc;

      GetWindowRect(hwnd,&rc);

      nativeHeight = rc.bottom - rc.top;

      nativeWidth = rc.right - rc.left;

      //SetDlgItemText(hwnd,IDDI_PAD_KILLER_SERVER,L"192.168.1.139");
      //SetDlgItemText(hwnd,IDDI_PAD_KILLER_IMAGE_FILE,L"C:\\Users\\Nate\\Documents\\StandardFormOmega.bmp");

      hwndDialog = hwnd;

      nativeControlHandler = (WNDPROC)SetWindowLong(GetDlgItem(hwndDialog,IDDI_PAD_KILLER_PAD),GWL_WNDPROC,(long)padBackgroundHandler);

      }
      return (LRESULT)0L;

   case WM_COMMAND: {

      switch ( LOWORD(wParam) ) {

      case IDDI_PAD_KILLER_SERVER: {
         GetDlgItemTextW(hwnd,IDDI_PAD_KILLER_SERVER,szwServerName,MAX_PATH);
         EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_CONNECT_SERVER),szwServerName[0] ? TRUE : FALSE);
         }
         break;

      case IDDI_PAD_KILLER_CONNECT_SERVER: {
         WCHAR szwServerName[MAX_PATH];
         GetDlgItemTextW(hwnd,IDDI_PAD_KILLER_SERVER,szwServerName,MAX_PATH);
         if ( ! szwServerName[0] ) {
            MessageBox(hwnd,L"Please provide a name for the Android device",L"Note",MB_OK | MB_ICONEXCLAMATION);
            break;
         }
         WCHAR szwTemp[MAX_PATH];
         swprintf_s(szwTemp,MAX_PATH,L"Connecting to: %ls",szwServerName);
         SetDlgItemText(hwnd,IDDI_PAD_KILLER_CONNECT_LABEL,szwTemp);
         HRESULT rc = pISignaturePad -> Connect(szwServerName);
         if ( ! ( S_OK == rc ) ) {
            MessageBox(hwnd,L"There was an error connecting to the Android device",L"Note",MB_OK | MB_ICONEXCLAMATION);
            SetDlgItemText(hwnd,IDDI_PAD_KILLER_CONNECT_LABEL,L"Enter the IP address or network name of your Android device");
            break;
         }

         swprintf_s(szwTemp,MAX_PATH,L"Connected to: %ls",szwServerName);

         SetDlgItemText(hwnd,IDDI_PAD_KILLER_CONNECT_LABEL,szwTemp);

         swprintf_s(szwTemp,MAX_PATH,L"%ls is connected",szwServerName);

         SetDlgItemText(hwnd,IDDI_PAD_KILLER_PAD_LABEL,szwTemp);

         isConnected = 1L;

         EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_START),TRUE);
         EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_STOP),TRUE);
         EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_CLEAR),TRUE);

         WCHAR szTemp[MAX_PATH];

         GetDlgItemText(hwnd,IDDI_PAD_KILLER_IMAGE_FILE,szTemp,MAX_PATH);

         if ( szTemp[0] ) {
            EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_SEND_IMAGE),TRUE);
            handler(hwnd,WM_COMMAND,MAKEWPARAM(IDDI_PAD_KILLER_SEND_IMAGE,0L),0L);
         }

         pISignaturePad -> put_DrawingWindowHandle(GetDlgItem(hwnd,IDDI_PAD_KILLER_PAD));

         }

         break;

      case IDDI_PAD_KILLER_IMAGE_FILE: {

         WCHAR szwTemp[MAX_PATH];

         GetDlgItemText(hwnd,IDDI_PAD_KILLER_IMAGE_FILE,szwTemp,MAX_PATH);

         FILE *fX = NULL;

         _wfopen_s(&fX,szwTemp,L"rb");

         if ( ! fX ) {
            EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_SEND_IMAGE),FALSE);
            EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_START),FALSE);
            EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_STOP),FALSE);
            EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_CLEAR),FALSE);
            break;
         }

         fclose(fX);

         if ( isConnected ) {
            EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_SEND_IMAGE),TRUE);
            EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_START),TRUE);
            EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_STOP),TRUE);
            EnableWindow(GetDlgItem(hwnd,IDDI_PAD_KILLER_CLEAR),TRUE);
         }

         if ( cxPad )
            break;

         if ( pPadBitmap )
            delete pPadBitmap;

         pPadBitmap = new Gdiplus::Bitmap(szwTemp);

         cxPad = pPadBitmap -> GetWidth();
         cyPad = pPadBitmap -> GetHeight();

         domainMaxX = cxPad;
         domainMaxY = cyPad;

         RECT rcPad,rcParent;

         GetWindowRect(GetDlgItem(hwnd,IDDI_PAD_KILLER_PAD),&rcPad);

         GetWindowRect(hwnd,&rcParent);

         long xOffsetPad = rcPad.left - rcParent.left;
         long yOffsetPad = rcPad.top - rcParent.top;

         SetWindowPos(GetDlgItem(hwnd,IDDI_PAD_KILLER_PAD),HWND_TOP,0,0,cxPad,cyPad,SWP_NOMOVE);

         long cx = cxPad + (rcPad.left - rcParent.left) + 16;
         long cy = cyPad + (rcPad.top - rcParent.top) + 48;

         SetWindowPos(hwnd,HWND_TOP,0,0,max(nativeWidth,cx),max(nativeHeight,cy),SWP_NOMOVE);

         SetWindowPos(GetDlgItem(hwnd,IDDI_PAD_KILLER_PAD_LABEL),HWND_TOP,xOffsetPad,yOffsetPad + cyPad - GetSystemMetrics(SM_CYCAPTION),cxPad,24,0L);

         pISignaturePad -> put_DrawingWindowHandle(GetDlgItem(hwnd,IDDI_PAD_KILLER_PAD));

         InvalidateRect(hwnd,NULL,FALSE);

         RedrawWindow(hwnd,NULL,NULL,RDW_UPDATENOW | RDW_ERASENOW);

         PostMessage(hwnd,WM_PAINT,0L,0L);

         }
         break;         

      case IDDI_PAD_KILLER_GET_IMAGE: {

         OPENFILENAME openFileName = {0};
                  
         WCHAR szwFilter[MAX_PATH],szwFile[MAX_PATH];
                     
         memset(szwFilter,0,sizeof(szwFilter));
         memset(szwFile,0,sizeof(szwFile));
                     
         wsprintf(szwFilter,L"Image Files (*.bmp,*.jpg,*.jpeg,*.png)");
         long k = wcslen(szwFilter) + wsprintf(szwFilter + wcslen(szwFilter) + 1,L"*.bmp;*.jpg;*.jpeg;*.png");
         k = k + wsprintf(szwFilter + k + 2,L"All Files");
         wsprintf(szwFilter + k + 3,L"*.*");
                     
         openFileName.lStructSize = sizeof(OPENFILENAME);
         openFileName.hwndOwner = hwnd;
         openFileName.Flags = OFN_FILEMUSTEXIST | OFN_NOCHANGEDIR | OFN_PATHMUSTEXIST;
         openFileName.lpstrFilter = szwFilter;
         openFileName.lpstrFile = szwFile;
         openFileName.lpstrDefExt = L"pdf";
         openFileName.nFilterIndex = 1;
         openFileName.nMaxFile = MAX_PATH;
         openFileName.lpstrTitle = L"Select the existing image file";
                  
         if ( ! GetOpenFileName(&openFileName) ) 
            break;

         cxPad = 0L;
         cyPad = 0L;

         SetDlgItemText(hwnd,IDDI_PAD_KILLER_IMAGE_FILE,openFileName.lpstrFile);

         }
         break;

      case IDDI_PAD_KILLER_SEND_IMAGE: {

         WCHAR szwImage[MAX_PATH];

         GetDlgItemText(hwnd,IDDI_PAD_KILLER_IMAGE_FILE,szwImage,MAX_PATH);

         if ( ! szwImage[0] )
            break;

         pISignaturePad -> put_BackgroundBitmapFile(szwImage);

         WCHAR szwTemp[MAX_PATH];

         swprintf_s(szwTemp,MAX_PATH,L"Background set to %ls",szwImage);

         SetDlgItemText(hwnd,IDDI_PAD_KILLER_PAD_LABEL,szwTemp);


#if 0
         if ( ! ( S_OK == sendImage(szImage) ) ) {
            MessageBox(hwndDialog,L"There was an error sending the image, is the Pad Connected?",L"Error",MB_OK | MB_ICONEXCLAMATION);
            break;
         }

         char szCommand[128];

         sprintf(szCommand,"%ld",CLEARHOTSPOTS);
         sendCommand(szCommand);

         sprintf(szCommand,"%ld %ld %ld %ld %ld %ld",HOTSPOT,565,0,640,40,1);
         sendCommand(szCommand);

         sprintf(szCommand,"%ld %ld %ld %ld %ld %ld",HOTSPOT,0,0,136,41,0);
         sendCommand(szCommand);

         sprintf(szCommand,"%ld 4 4 130 41 0 Clear",CREATEBUTTON);
         sendCommand(szCommand);

         sprintf(szCommand,"%ld 561 4 630 40 1 Ok",CREATEBUTTON);
         sendCommand(szCommand);
#endif

         }
         break;

      case IDDI_PAD_KILLER_START: {
         pISignaturePad -> Start();
         WCHAR szwTemp[MAX_PATH];
         swprintf_s(szwTemp,MAX_PATH,L"%ls is collecting signature data",szwServerName);
         SetDlgItemText(hwnd,IDDI_PAD_KILLER_PAD_LABEL,szwTemp);
         }
         break;

      case IDDI_PAD_KILLER_STOP: {
         pISignaturePad -> Stop();
         WCHAR szwTemp[MAX_PATH];
         swprintf_s(szwTemp,MAX_PATH,L"%ls is not collecting signature data",szwServerName);
         SetDlgItemText(hwnd,IDDI_PAD_KILLER_PAD_LABEL,szwTemp);
         }
         break;

      case IDDI_PAD_KILLER_CLEAR: {
         pISignaturePad -> ClearEverything();
         WCHAR szwTemp[MAX_PATH];
         swprintf_s(szwTemp,MAX_PATH,L"%ls is cleared",szwServerName);
         SetDlgItemText(hwnd,IDDI_PAD_KILLER_PAD_LABEL,szwTemp);
         }
         break;
   
      case IDDI_PAD_KILLER_CLOSE:
         pISignaturePad -> Release();
         EndDialog(hwnd,0L);
         break;

      default:
         break;

      }

      }
      break;

   case WM_DESTROY: {
      Gdiplus::GdiplusShutdown(gdiplusToken);
      }
      break;

   default:
      break;

   }

   return 0L;
   }


   LRESULT CALLBACK padBackgroundHandler(HWND hwnd,UINT msg,WPARAM wParam,LPARAM lParam) {

   LRESULT rc = CallWindowProc((WNDPROC)nativeControlHandler,hwnd,msg,wParam,lParam);

   if ( ! ( WM_PAINT == msg ) )
      return rc;

   if ( ! pPadBitmap ) 
      return rc;

   HDC hdcTarget = GetDC(hwnd);

   HDC hdcSource = CreateCompatibleDC(NULL);

   HBITMAP hBitmapSource;

   HBITMAP hBitmapTarget = CreateBitmap(cxPad,cyPad,1,GetDeviceCaps(hdcTarget,BITSPIXEL),NULL);

   pPadBitmap -> GetHBITMAP(NULL,&hBitmapSource);

   HGDIOBJ oldObj1 = SelectObject(hdcTarget,hBitmapTarget);

   HGDIOBJ oldObj2 = SelectObject(hdcSource,hBitmapSource);

   long rc2 = BitBlt(hdcTarget,0,0,cxPad,cyPad,hdcSource,0,0,SRCCOPY);

   DeleteObject(SelectObject(hdcTarget,oldObj1));

   DeleteObject(SelectObject(hdcSource,oldObj2));

   ReleaseDC(hwnd,hdcTarget);

   return rc;
   }