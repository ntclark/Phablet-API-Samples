Public Class imageDisplay

Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
  Close()
End Sub

Private Sub saveImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveImage.Click

   saveImageLocation.Title = "Save the current image..."
   saveImageLocation.Filter = "Bitmap (*.bmp) |*.bmp|JPeg image (*.jpeg)|*.jpeg|PNG image|*.png"
   saveImageLocation.DefaultExt = "jpeg"

   If DialogResult.Cancel = saveImageLocation.ShowDialog() Then
      Exit Sub
   End If

   If 1 = saveImageLocation.FilterIndex Then
      thePicture.Image.Save(saveImageLocation.FileName, Imaging.ImageFormat.Bmp)
   ElseIf 2 = saveImageLocation.FilterIndex Then
      thePicture.Image.Save(saveImageLocation.FileName, Imaging.ImageFormat.Jpeg)
   Else
      thePicture.Image.Save(saveImageLocation.FileName, Imaging.ImageFormat.Png)
   End If

End Sub
End Class