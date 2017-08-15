
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports Microsoft.Office.Core
Imports System.Runtime.InteropServices

Module Utilities

Public lastWorkbookWasOpen As Boolean = False
Public excelApplicationWasActive As Boolean = False
Public excelApp As Excel.Application = Nothing

Public Sub embedImageInWorkbook(ByVal imageFileName As String)

   If Not IO.File.Exists(My.Settings.excelWorkbookName) Then
      MsgBox(String.Format("The MS Excel workbook: {0} does not exist or is inaccessible", My.Settings.excelWorkbookName))
      Exit Sub
   End If

   Dim workBook As Excel.Workbook = getWorkbook(My.Settings.excelWorkbookName)

   If workBook Is Nothing Then
      Exit Sub
   End If

   Dim workSheet As Excel.Worksheet = Nothing
   Dim wsTest As Excel.Worksheet

   For Each wsTest In workBook.Sheets

      If wsTest.Name = My.Settings.excelSheetName Then
         workSheet = wsTest
         Exit For
      End If

   Next wsTest

   If workSheet Is Nothing Then

      MsgBox(String.Format("The MS Excel workbook: {0} does not contain the worksheet {1}", My.Settings.excelWorkbookName, My.Settings.excelSheetName))

      If Not lastWorkbookWasOpen Then
         workBook.Close(False)
      End If

      excelApp.Quit()

      Exit Sub

   End If

   Dim targetRange As Excel.Range = Nothing
   Dim cellReference As String = My.Settings.excelColumn + My.Settings.excelRow

   excelApp.Visible = True
   excelApp.Windows(workBook.Name).Visible = True

   workBook.Activate()
   workSheet.Activate()

   targetRange = workSheet.Range(cellReference).Cells(1, 1)

   Dim xlPic As Excel.Shape

   Dim left As Int16 = targetRange.Left
   Dim top As Int16 = targetRange.Top

   If My.Settings.usePhabletDimensions Then
      xlPic = workSheet.Shapes.AddPicture(imageFileName, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, _
                                             targetRange.Left, targetRange.Top, ezSign.phabletDevice.Width, ezSign.phabletDevice.Height)
   Else
      xlPic = workSheet.Shapes.AddPicture(imageFileName, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, _
                                             targetRange.Left, targetRange.Top, My.Settings.resultImageWidth, My.Settings.resultImageHeight)
   End If

   'xlPic.LockAspectRatio = Microsoft.Office.Core.MsoTriState.msoCTrue

   If My.Settings.closeWorkbookAfterEmbed Then

      If Not lastWorkbookWasOpen Then
         workBook.Save()
         workBook.Close()
      End If

      If Not excelApplicationWasActive Then
         excelApp.Quit()
      End If

   End If

End Sub


Public Function getWorkbook(ByVal fileName As String) As Excel.Workbook

   excelApplicationWasActive = False

   Try

   excelApp = Marshal.GetActiveObject("Excel.Application")

   excelApplicationWasActive = True

   Catch theError As System.Runtime.InteropServices.COMException

   System.Console.WriteLine(theError.Message)

   End Try

   Dim wb As Excel.Workbook = Nothing

   lastWorkbookWasOpen = False

   If excelApp Is Nothing Then

      wb = GetObject(fileName)

      excelApp = wb.Application

   Else

      Dim workBooks As Excel.Workbooks = excelApp.Workbooks

      Dim testWb As Object = Nothing

      For Each testWb In workBooks

         If testWb.FullName = fileName Then
            lastWorkbookWasOpen = True
            wb = testWb
            Exit For
         End If

      Next testWb

      If wb Is Nothing Then

         lastWorkbookWasOpen = False

         wb = workBooks.Open(fileName)

      End If

   End If

   getWorkbook = wb

End Function

End Module
