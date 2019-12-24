<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ezSign
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
      Me.components = New System.ComponentModel.Container()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ezSign))
      Me.ok = New System.Windows.Forms.Button()
      Me.startCapture = New System.Windows.Forms.Button()
      Me.stopCapture = New System.Windows.Forms.Button()
      Me.clearHandwriting = New System.Windows.Forms.Button()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.getNativeImage = New System.Windows.Forms.Button()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.deviceName = New System.Windows.Forms.TextBox()
      Me.connectDevice = New System.Windows.Forms.Button()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.getBitmap = New System.Windows.Forms.Button()
      Me.getBackgroundFile = New System.Windows.Forms.OpenFileDialog()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.clearEverything = New System.Windows.Forms.Button()
      Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
      Me.embedGroup = New System.Windows.Forms.GroupBox()
      Me.embedImage = New System.Windows.Forms.Button()
      Me.embedSettings = New System.Windows.Forms.Button()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.phabletDevice = New AxPhabletSignaturePad.AxPhabletSignaturePad()
      Me.GroupBox1.SuspendLayout()
      Me.embedGroup.SuspendLayout()
      CType(Me.phabletDevice, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'ok
      '
      Me.ok.Location = New System.Drawing.Point(13, 801)
      Me.ok.Name = "ok"
      Me.ok.Size = New System.Drawing.Size(75, 23)
      Me.ok.TabIndex = 0
      Me.ok.Text = "Ok"
      Me.ok.UseVisualStyleBackColor = True
      '
      'startCapture
      '
      Me.startCapture.Location = New System.Drawing.Point(13, 553)
      Me.startCapture.Name = "startCapture"
      Me.startCapture.Size = New System.Drawing.Size(75, 23)
      Me.startCapture.TabIndex = 7
      Me.startCapture.Text = "Start"
      Me.startCapture.UseVisualStyleBackColor = True
      '
      'stopCapture
      '
      Me.stopCapture.Location = New System.Drawing.Point(93, 553)
      Me.stopCapture.Name = "stopCapture"
      Me.stopCapture.Size = New System.Drawing.Size(75, 23)
      Me.stopCapture.TabIndex = 8
      Me.stopCapture.Text = "Stop"
      Me.stopCapture.UseVisualStyleBackColor = True
      '
      'clearHandwriting
      '
      Me.clearHandwriting.Location = New System.Drawing.Point(15, 606)
      Me.clearHandwriting.Name = "clearHandwriting"
      Me.clearHandwriting.Size = New System.Drawing.Size(75, 23)
      Me.clearHandwriting.TabIndex = 9
      Me.clearHandwriting.Text = "Clear"
      Me.toolTip.SetToolTip(Me.clearHandwriting, "Clears any handwriting, does not clear buttons or background image")
      Me.clearHandwriting.UseVisualStyleBackColor = True
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.getNativeImage)
      Me.GroupBox1.Location = New System.Drawing.Point(18, 645)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(161, 55)
      Me.GroupBox1.TabIndex = 12
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Images"
      '
      'getNativeImage
      '
      Me.getNativeImage.Location = New System.Drawing.Point(7, 19)
      Me.getNativeImage.Name = "getNativeImage"
      Me.getNativeImage.Size = New System.Drawing.Size(111, 23)
      Me.getNativeImage.TabIndex = 12
      Me.getNativeImage.Text = "Signature Image"
      Me.getNativeImage.UseVisualStyleBackColor = True
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(19, 757)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(81, 13)
      Me.Label3.TabIndex = 14
      Me.Label3.Text = "Phablet device:"
      '
      'deviceName
      '
      Me.deviceName.Location = New System.Drawing.Point(106, 754)
      Me.deviceName.Name = "deviceName"
      Me.deviceName.Size = New System.Drawing.Size(100, 20)
      Me.deviceName.TabIndex = 15
      Me.deviceName.Text = "localhost"
      '
      'connectDevice
      '
      Me.connectDevice.Location = New System.Drawing.Point(213, 753)
      Me.connectDevice.Name = "connectDevice"
      Me.connectDevice.Size = New System.Drawing.Size(75, 23)
      Me.connectDevice.TabIndex = 16
      Me.connectDevice.Text = "Connect"
      Me.connectDevice.UseVisualStyleBackColor = True
      '
      'Label4
      '
      Me.Label4.Location = New System.Drawing.Point(264, 527)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(200, 40)
      Me.Label4.TabIndex = 18
      Me.Label4.Text = "To set the background bitmap, press Bitmap. It is stored in the Phablet device. T" &
    "o clear it, use Clear Everything"
      '
      'getBitmap
      '
      Me.getBitmap.Location = New System.Drawing.Point(267, 570)
      Me.getBitmap.Name = "getBitmap"
      Me.getBitmap.Size = New System.Drawing.Size(75, 23)
      Me.getBitmap.TabIndex = 19
      Me.getBitmap.Text = "Bitmap"
      Me.getBitmap.UseVisualStyleBackColor = True
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(13, 537)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(105, 13)
      Me.Label5.TabIndex = 20
      Me.Label5.Text = "Control pen events..."
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(15, 590)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(97, 13)
      Me.Label6.TabIndex = 21
      Me.Label6.Tag = "Clear any handwriting. Does not change the Start and Stop state"
      Me.Label6.Text = "Clear handwriting..."
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.Location = New System.Drawing.Point(118, 590)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(120, 13)
      Me.Label7.TabIndex = 22
      Me.Label7.Tag = "Clear the display. Note that pad will still remember the background bitmap and bu" &
    "ttons created on it, which will be shown when it is next connected to."
      Me.Label7.Text = "Clear pad (Everything)..."
      '
      'clearEverything
      '
      Me.clearEverything.Location = New System.Drawing.Point(121, 606)
      Me.clearEverything.Name = "clearEverything"
      Me.clearEverything.Size = New System.Drawing.Size(92, 23)
      Me.clearEverything.TabIndex = 23
      Me.clearEverything.Text = "Clear Everything"
      Me.toolTip.SetToolTip(Me.clearEverything, "Clears handwriting, buttons, and background bitmap. Buttons and background bitmap" &
        " are in the non-volatile memory of the pad, they will appear when the pad is nex" &
        "t ""connected"" to.")
      Me.clearEverything.UseVisualStyleBackColor = True
      '
      'embedGroup
      '
      Me.embedGroup.Controls.Add(Me.embedImage)
      Me.embedGroup.Controls.Add(Me.embedSettings)
      Me.embedGroup.Controls.Add(Me.Label8)
      Me.embedGroup.Location = New System.Drawing.Point(196, 645)
      Me.embedGroup.Name = "embedGroup"
      Me.embedGroup.Size = New System.Drawing.Size(227, 85)
      Me.embedGroup.TabIndex = 30
      Me.embedGroup.TabStop = False
      Me.embedGroup.Text = "Embed"
      '
      'embedImage
      '
      Me.embedImage.Location = New System.Drawing.Point(107, 45)
      Me.embedImage.Name = "embedImage"
      Me.embedImage.Size = New System.Drawing.Size(75, 23)
      Me.embedImage.TabIndex = 2
      Me.embedImage.Text = "Embed"
      Me.embedImage.UseVisualStyleBackColor = True
      '
      'embedSettings
      '
      Me.embedSettings.Location = New System.Drawing.Point(10, 45)
      Me.embedSettings.Name = "embedSettings"
      Me.embedSettings.Size = New System.Drawing.Size(75, 23)
      Me.embedSettings.TabIndex = 1
      Me.embedSettings.Text = "Settings"
      Me.embedSettings.UseVisualStyleBackColor = True
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.Location = New System.Drawing.Point(7, 19)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(206, 13)
      Me.Label8.TabIndex = 0
      Me.Label8.Text = "Place the signature in an Excel Workbook"
      '
      'phabletDevice
      '
      Me.phabletDevice.Enabled = True
      Me.phabletDevice.Location = New System.Drawing.Point(12, 0)
      Me.phabletDevice.Name = "phabletDevice"
      Me.phabletDevice.OcxState = CType(resources.GetObject("phabletDevice.OcxState"), System.Windows.Forms.AxHost.State)
      Me.phabletDevice.Size = New System.Drawing.Size(800, 500)
      Me.phabletDevice.TabIndex = 29
      '
      'ezSign
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(842, 850)
      Me.Controls.Add(Me.phabletDevice)
      Me.Controls.Add(Me.embedGroup)
      Me.Controls.Add(Me.stopCapture)
      Me.Controls.Add(Me.ok)
      Me.Controls.Add(Me.startCapture)
      Me.Controls.Add(Me.Label6)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.clearHandwriting)
      Me.Controls.Add(Me.connectDevice)
      Me.Controls.Add(Me.Label7)
      Me.Controls.Add(Me.getBitmap)
      Me.Controls.Add(Me.GroupBox1)
      Me.Controls.Add(Me.deviceName)
      Me.Controls.Add(Me.clearEverything)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.Label3)
      Me.Name = "ezSign"
      Me.Text = "Phablet Signature Pad"
      Me.GroupBox1.ResumeLayout(False)
      Me.embedGroup.ResumeLayout(False)
      Me.embedGroup.PerformLayout()
      CType(Me.phabletDevice, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents startCapture As System.Windows.Forms.Button
    Friend WithEvents stopCapture As System.Windows.Forms.Button
    Friend WithEvents clearHandwriting As System.Windows.Forms.Button
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents getNativeImage As System.Windows.Forms.Button
   Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents deviceName As System.Windows.Forms.TextBox
    Friend WithEvents connectDevice As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents getBitmap As System.Windows.Forms.Button
    Friend WithEvents getBackgroundFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents clearEverything As System.Windows.Forms.Button
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents phabletDevice As AxPhabletSignaturePad.AxPhabletSignaturePad
    Friend WithEvents embedGroup As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents embedSettings As System.Windows.Forms.Button
    Friend WithEvents embedImage As System.Windows.Forms.Button

End Class
