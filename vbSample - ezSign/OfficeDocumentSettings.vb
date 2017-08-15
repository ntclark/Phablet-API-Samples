Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports System.Runtime.InteropServices

Public Class OfficeDocumentSettings

Private nativeAspectRatioLabel As String = ""
Private nativeAspectRatio As Double = 0.0

Private Sub OfficeDocumentSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   If "" = nativeAspectRatioLabel Then
      nativeAspectRatioLabel = labelCurrentAspectRatio.Text
      nativeAspectRatio = ezSign.phabletDevice.Width / ezSign.phabletDevice.Height
   End If

   If aspectRatioLabel.Text.Contains("%") Then
      Dim ar As Double
      ar = ezSign.phabletDevice.Width / ezSign.phabletDevice.Height
      aspectRatioLabel.Text = aspectRatioLabel.Text.Substring(0, aspectRatioLabel.Text.IndexOf("%")) + String.Format("{0}", Math.Round(ar, 2)) + _
                                 aspectRatioLabel.Text.Substring(aspectRatioLabel.Text.IndexOf("%") + 1)
   End If

   excelWorkbookName.Text = My.Settings.excelWorkbookName
   keepWorkbookOpen.Checked = Not My.Settings.closeWorkbookAfterEmbed

   excelRow.Text = My.Settings.excelRow
   excelColumn.Text = My.Settings.excelColumn

   If 0 = My.Settings.resultImageWidth Then
      My.Settings.resultImageWidth = ezSign.phabletDevice.Width
   End If

   If 0 = My.Settings.resultImageHeight Then
      My.Settings.resultImageHeight = ezSign.phabletDevice.Height
   End If

   imageHeight.Text = My.Settings.resultImageHeight
   imageWidth.Text = My.Settings.resultImageWidth

   useDeviceDimensions.Checked = My.Settings.usePhabletDimensions

   Dim oldSelection As String = ""

   If Not -1 = worksheets.SelectedIndex Then
      oldSelection = worksheets.SelectedItem
   Else
      oldSelection = My.Settings.excelSheetName
   End If

   worksheets.Items.Clear()

   If 0 = excelWorkbookName.Text.Length Then
      Exit Sub
   End If

   If Not IO.File.Exists(excelWorkbookName.Text) Then
      Exit Sub
   End If

   Dim workbook As Excel.Workbook = Utilities.getWorkbook(excelWorkbookName.Text)

   If workbook Is Nothing Then
      excelWorkbookName.Text = ""
      Exit Sub
   End If

   Dim ws As Excel.Worksheet

   For Each ws In workbook.Sheets

      worksheets.Items.Add(ws.Name)

      If oldSelection = ws.Name Then
         worksheets.SelectedIndex = worksheets.Items.Count - 1
      End If

   Next ws

   If Not Utilities.lastWorkbookWasOpen Then
      workbook.Close(False)
   End If

   If Not Utilities.excelApplicationWasActive Then
      Utilities.excelApp.Quit()
   End If

End Sub

Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
  DialogResult = Windows.Forms.DialogResult.Cancel
  Close()
End Sub

Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
   DialogResult = Windows.Forms.DialogResult.OK
   My.Settings.excelWorkbookName = excelWorkbookName.Text
   My.Settings.closeWorkbookAfterEmbed = Not keepWorkbookOpen.Checked
   If Not -1 = worksheets.SelectedIndex Then
      My.Settings.excelSheetName = worksheets.SelectedItem
   Else
      My.Settings.excelSheetName = ""
   End If
   My.Settings.excelRow = excelRow.Text
   My.Settings.excelColumn = excelColumn.Text
   My.Settings.resultImageWidth = imageWidth.Text
   My.Settings.resultImageHeight = imageHeight.Text
   My.Settings.usePhabletDimensions = useDeviceDimensions.Checked
   Close()
End Sub

Private Sub getExcelWorkbook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getExcelWorkbook.Click

   Dim getFile As Windows.Forms.OpenFileDialog

   getFile = New Windows.Forms.OpenFileDialog()

   getFile.Title = "Select an Excel file..."
   getFile.Filter = "Excel Files (*.xlsx;*.xlsm;*.xlsb;*.xlam;*.xltx;*.xltm;*.lls;*.xla;*.xlt;*.xlm;*.xlw) |*.xlsx;*.xlsm;*.xlsb;*.xlam;*.xltx;*.xltm;*.lls;*.xla;*.xlt;*.xlm;*.xlw"
   getFile.DefaultExt = "xlsx"

   If DialogResult.Cancel = getFile.ShowDialog Then
      Exit Sub
   End If

   My.Settings.excelWorkbookName = getFile.FileName

   OfficeDocumentSettings_Load(Nothing, Nothing)

End Sub

Private Sub imageWidth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imageWidth.TextChanged

  If 0 = imageHeight.Text.Length Then
     Exit Sub
  End If

  Dim ar As Double = Double.Parse(imageWidth.Text) / Double.Parse(imageHeight.Text)
  Dim heightGoal As Double = Double.Parse(imageWidth.Text) / nativeAspectRatio

  labelCurrentAspectRatio.Text = nativeAspectRatioLabel.Substring(0, nativeAspectRatioLabel.IndexOf("%")) + _
                                    Math.Round(ar, 2).ToString() + _
                                    nativeAspectRatioLabel.Substring(nativeAspectRatioLabel.IndexOf("%") + 1) + _
                                    ". Height should be about : " + Math.Round(heightGoal, 0).ToString()
End Sub

Private Sub imageHeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imageHeight.TextChanged

  If 0 = imageWidth.Text.Length Then
     Exit Sub
  End If

  Dim ar As Double = Double.Parse(imageWidth.Text) / Double.Parse(imageHeight.Text)
  Dim widthGoal As Double = Double.Parse(imageHeight.Text) * nativeAspectRatio

  labelCurrentAspectRatio.Text = nativeAspectRatioLabel.Substring(0, nativeAspectRatioLabel.IndexOf("%")) + _
                                    Math.Round(ar, 2).ToString() + _
                                    nativeAspectRatioLabel.Substring(nativeAspectRatioLabel.IndexOf("%") + 1) + _
                                    ". Width should be about : " + Math.Round(widthGoal, 0).ToString()
End Sub

Private Sub useDeviceDimensions_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles useDeviceDimensions.CheckedChanged
   Dim isEnabled = True
   If useDeviceDimensions.Checked Then
      isEnabled = False
   End If
   For Each c As Control In imageSettingsGroup.Controls
      If Not c Is useDeviceDimensions Then
         c.Enabled = isEnabled
      End If
   Next c
End Sub
End Class