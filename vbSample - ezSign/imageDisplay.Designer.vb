<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class imageDisplay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
Me.ok = New System.Windows.Forms.Button
Me.thePicture = New System.Windows.Forms.PictureBox
Me.saveImage = New System.Windows.Forms.Button
Me.saveImageLocation = New System.Windows.Forms.SaveFileDialog
CType(Me.thePicture, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'ok
'
Me.ok.Location = New System.Drawing.Point(13, 226)
Me.ok.Name = "ok"
Me.ok.Size = New System.Drawing.Size(46, 23)
Me.ok.TabIndex = 0
Me.ok.Text = "Ok"
Me.ok.UseVisualStyleBackColor = True
'
'thePicture
'
Me.thePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.thePicture.Location = New System.Drawing.Point(12, 12)
Me.thePicture.Name = "thePicture"
Me.thePicture.Size = New System.Drawing.Size(530, 208)
Me.thePicture.TabIndex = 1
Me.thePicture.TabStop = False
'
'saveImage
'
Me.saveImage.Location = New System.Drawing.Point(467, 227)
Me.saveImage.Name = "saveImage"
Me.saveImage.Size = New System.Drawing.Size(75, 23)
Me.saveImage.TabIndex = 2
Me.saveImage.Text = "Save"
Me.saveImage.UseVisualStyleBackColor = True
'
'imageDisplay
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(554, 262)
Me.ControlBox = False
Me.Controls.Add(Me.saveImage)
Me.Controls.Add(Me.thePicture)
Me.Controls.Add(Me.ok)
Me.Name = "imageDisplay"
Me.Text = "Image"
CType(Me.thePicture, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)

End Sub
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents thePicture As System.Windows.Forms.PictureBox
    Friend WithEvents saveImage As System.Windows.Forms.Button
    Friend WithEvents saveImageLocation As System.Windows.Forms.SaveFileDialog
End Class
