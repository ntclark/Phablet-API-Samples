﻿
Public Class phabletSample

Private Const idClearButton As Long = 1
Private Const idOkButton As Long = 2

Dim formLoaded As Boolean = False

Private Sub phabletSample_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   deviceName.Text = phabletDevice.IPOrNetworkName

   '
   ' If you want to change the color of the ink programmatically, here is one way to do it. Specify a value of 0-255 for each
   ' level of intensity for each of Red, Green, and Blue. The example color is pure Red.
   '
   'phabletDevice.InkColor = RGB(255, 0, 0)

   phabletDevice.Connect("")

   phabletDevice.FontSize = 12.0

      '
      ' Buttons are created on the phabletDevice. The size of the buttons are a function of the 
      ' FontSize specified. Therefore, if you want to place the buttons in a location relative to the Phablet screen, 
      ' for example, on the right edge of the Phablet display, Create the button invisible ( 5th argument is 0 ) obtain the 
      ' size (Bounds) of the button after creating it, and use that size to determine the location.
      ' An example of this is shown for the Ok button, which is placed on the right edge of the Phablet device
      '

      ' ButtonText, Event #, x position, y position:
      '
      phabletDevice.CreateButton("Clear", idClearButton, 4, 4, 0)

   '
   ' The event ID ( 2nd parameter) of the button is up to the developer. You can specify any value, when you recieve the
   ' option selected event, this ID value will be in the event parameter.
   '
   phabletDevice.CreateButton("Ok", idOkButton, 4, 4, 0)

   '
   ' Obtain the size of the Ok button in order to place it against the right edge of the display ( minus 4 pixels )
   '
   Dim rect As PhabletSignaturePad.tagRECT
   Dim point As PhabletSignaturePad.tagPOINT

   Dim buttonWidth As Integer

   rect = phabletDevice.get_ControlBounds(idOkButton)

   buttonWidth = rect.right - rect.left

   rect.left = phabletDevice.CtlWidth - buttonWidth - 4
   rect.right = rect.left + buttonWidth

   point.x = rect.left
   point.y = rect.top

   phabletDevice.set_ControlPosition(idOkButton, point)

End Sub

Private Sub phabletSample_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
   formLoaded = True
End Sub

Private Sub showDisplay(ByVal theBitmap As Bitmap)

   Dim showDisplay As imageDisplay

   showDisplay = New imageDisplay

   showDisplay.thePicture.Image = theBitmap

   Dim nativeBottomMargin As Integer
   Dim nativeRightMargin As Integer

   nativeBottomMargin = showDisplay.ClientRectangle.Height - showDisplay.thePicture.Bottom
   nativeRightMargin = showDisplay.ClientRectangle.Width - showDisplay.thePicture.Right

   showDisplay.thePicture.Width = showDisplay.thePicture.Image.Width
   showDisplay.thePicture.Height = showDisplay.thePicture.Image.Height
   showDisplay.Height = showDisplay.thePicture.Bottom + nativeBottomMargin + (showDisplay.Height - showDisplay.ClientRectangle.Height)
   showDisplay.Width = showDisplay.thePicture.Right + nativeRightMargin + (showDisplay.Width - showDisplay.ClientRectangle.Width)

   showDisplay.ok.Top = showDisplay.thePicture.Bottom + 8
   showDisplay.saveImage.Top = showDisplay.ok.Top
   showDisplay.saveImage.Left = showDisplay.thePicture.Right - showDisplay.saveImage.Width

   showDisplay.ShowDialog()

   showDisplay.thePicture.Image.Dispose()

End Sub

'
' Note that the following event handlers process the events from controls in this sample application. 
' Events originating from the Phablet API ( and therefore, the Android or Windows TabletPC comprising the device )
' are handled in the group after this.
'
Private Sub startCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startCapture.Click
   '
   ' Events involving the motion of the pen or stylus on the surface of the Phablet device are not sent until
   ' the device has been "Start"ed. Also, pen feedback does not occur on the device until Started. 
   ' Other events, such as Command Button selection(s), will be active all the time.
   '
   Call phabletDevice.Start()

End Sub


Private Sub stopCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stopCapture.Click
   Call phabletDevice.Stop()
End Sub


Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
   phabletDevice.Disconnect()
   Close()
End Sub


Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearHandwriting.Click
  Call phabletDevice.ClearInk()
End Sub


Private Sub clearEverything_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearEverything.Click
   phabletDevice.ClearEverything()
End Sub

Private Sub clearMemory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  phabletDevice.ClearSettings()
End Sub

Private Sub getNativeImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getNativeImage.Click

   Dim s As String

   '
   ' A "Native" size image is an image in the dimensions of the Phablet device - which will vary depending on the device used.
   ' This is in contrast to just the "Image" - which will be created as the same size as the control window you, the developer,
   ' created when you hosted the Phablet API object on your form. To prevent distortion, it is usually best to have the aspect ratio,
   ' ratio of width/height, or height/width equal between the actual Phablet Device and the control you created on the form.
   '
   s = phabletDevice.NativeSizeImageFile

   showDisplay(New Bitmap(s))

   My.Computer.FileSystem.DeleteFile(s)

End Sub


Private Sub getImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getImage.Click
   showDisplay(Image.FromHbitmap(phabletDevice.Image))
End Sub


Private Sub connectDevice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles connectDevice.Click
  If phabletDevice.IsConnected() Then
     phabletDevice.Disconnect()
  End If
  phabletDevice.IPOrNetworkName = deviceName.Text
  phabletSample_Load(Nothing, Nothing)
End Sub


Private Sub getBitmap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getBitmap.Click

   getBackgroundFile.Title = "Open an image file..."
   getBackgroundFile.Filter = "Bitmap (*.bmp) |*.bmp|JPeg image (*.jpeg)|*.jpeg|PNG image|*.png"
   getBackgroundFile.DefaultExt = "jpeg"

   If DialogResult.Cancel = getBackgroundFile.ShowDialog Then
      Exit Sub
   End If

   phabletDevice.BackgroundBitmapFile = getBackgroundFile.FileName

End Sub

Private Sub pdfFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pdfFile.Click

   getBackgroundFile.Title = "Open a pdf file..."
   getBackgroundFile.Filter = "PDF (*.pdf) |*.pdf"
   getBackgroundFile.DefaultExt = "pdf"

   If DialogResult.Cancel = getBackgroundFile.ShowDialog Then
      Exit Sub
   End If

   phabletDevice.PDFFile = getBackgroundFile.FileName

End Sub

Private Sub operationalTypesTab_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles operationalTypesTab.SelectedIndexChanged

   If 0 = operationalTypesTab.SelectedIndex Then

      userInterfaceTabPage.Controls.Remove(phabletDevice)
      signatureCaptureTabPage.Controls.Add(phabletDevice)

      phabletDevice.ShowControl(idClearButton)
      phabletDevice.ShowControl(idOkButton)

      Return

   End If

   If 1 = operationalTypesTab.SelectedIndex Then

      signatureCaptureTabPage.Controls.Remove(phabletDevice)
      userInterfaceTabPage.Controls.Add(phabletDevice)

      phabletDevice.HideControl(idClearButton)
      phabletDevice.HideControl(idOkButton)

      Return

   End If

End Sub

'
' Note that the following event handlers process the events coming from the Phablet API
'
Private Sub phabletDevice_OptionSelected(ByVal sender As System.Object, ByVal e As AxPhabletSignaturePad.IPhabletSignaturePadEvents_OptionSelectedEvent) Handles phabletDevice.OptionSelected

   If e.optionNumber = 1 Then
      phabletDevice.ClearInk()
   End If

   If e.optionNumber = 2 Then
      Close()
   End If

End Sub

Private Sub phabletDevice_ItemSelected(ByVal sender As System.Object, ByVal e As AxPhabletSignaturePad.IPhabletSignaturePadEvents_ItemSelectedEvent) Handles phabletDevice.ItemSelected

End Sub

Private Sub phabletDevice_OptionUnSelected(ByVal sender As System.Object, ByVal e As AxPhabletSignaturePad.IPhabletSignaturePadEvents_OptionUnSelectedEvent) Handles phabletDevice.OptionUnSelected

End Sub
End Class
