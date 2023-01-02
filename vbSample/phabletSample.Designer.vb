<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class phabletSample
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(phabletSample))
      Me.ok = New System.Windows.Forms.Button()
      Me.startCapture = New System.Windows.Forms.Button()
      Me.stopCapture = New System.Windows.Forms.Button()
      Me.clearHandwriting = New System.Windows.Forms.Button()
      Me.getImage = New System.Windows.Forms.Button()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
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
      Me.pdfFile = New System.Windows.Forms.Button()
      Me.Label9 = New System.Windows.Forms.Label()
      Me.operationalTypesTab = New System.Windows.Forms.TabControl()
      Me.signatureCaptureTabPage = New System.Windows.Forms.TabPage()
      Me.phabletDevice = New AxPhabletSignaturePad.AxPhabletSignaturePad()
      Me.Label10 = New System.Windows.Forms.Label()
      Me.userInterfaceTabPage = New System.Windows.Forms.TabPage()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.GroupBox1.SuspendLayout()
      Me.operationalTypesTab.SuspendLayout()
      Me.signatureCaptureTabPage.SuspendLayout()
      CType(Me.phabletDevice, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.userInterfaceTabPage.SuspendLayout()
      Me.SuspendLayout()
      '
      'ok
      '
      Me.ok.Location = New System.Drawing.Point(12, 561)
      Me.ok.Name = "ok"
      Me.ok.Size = New System.Drawing.Size(75, 23)
      Me.ok.TabIndex = 0
      Me.ok.Text = "Ok"
      Me.ok.UseVisualStyleBackColor = True
      '
      'startCapture
      '
      Me.startCapture.Location = New System.Drawing.Point(26, 256)
      Me.startCapture.Name = "startCapture"
      Me.startCapture.Size = New System.Drawing.Size(75, 23)
      Me.startCapture.TabIndex = 7
      Me.startCapture.Text = "Start"
      Me.startCapture.UseVisualStyleBackColor = True
      '
      'stopCapture
      '
      Me.stopCapture.Location = New System.Drawing.Point(106, 256)
      Me.stopCapture.Name = "stopCapture"
      Me.stopCapture.Size = New System.Drawing.Size(75, 23)
      Me.stopCapture.TabIndex = 8
      Me.stopCapture.Text = "Stop"
      Me.stopCapture.UseVisualStyleBackColor = True
      '
      'clearHandwriting
      '
      Me.clearHandwriting.Location = New System.Drawing.Point(28, 309)
      Me.clearHandwriting.Name = "clearHandwriting"
      Me.clearHandwriting.Size = New System.Drawing.Size(75, 23)
      Me.clearHandwriting.TabIndex = 9
      Me.clearHandwriting.Text = "Clear"
      Me.toolTip.SetToolTip(Me.clearHandwriting, "Clears any handwriting, does not clear buttons or background image")
      Me.clearHandwriting.UseVisualStyleBackColor = True
      '
      'getImage
      '
      Me.getImage.Location = New System.Drawing.Point(15, 19)
      Me.getImage.Name = "getImage"
      Me.getImage.Size = New System.Drawing.Size(88, 23)
      Me.getImage.TabIndex = 11
      Me.getImage.Text = "Control Image"
      Me.getImage.UseVisualStyleBackColor = True
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.Label2)
      Me.GroupBox1.Controls.Add(Me.Label1)
      Me.GroupBox1.Controls.Add(Me.getNativeImage)
      Me.GroupBox1.Controls.Add(Me.getImage)
      Me.GroupBox1.Location = New System.Drawing.Point(31, 348)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(339, 85)
      Me.GroupBox1.TabIndex = 12
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Images"
      '
      'Label2
      '
      Me.Label2.Location = New System.Drawing.Point(155, 48)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(125, 35)
      Me.Label2.TabIndex = 14
      Me.Label2.Text = "In the dimensions of the device"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(13, 45)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(122, 13)
      Me.Label1.TabIndex = 13
      Me.Label1.Text = "In the dimensions above"
      '
      'getNativeImage
      '
      Me.getNativeImage.Location = New System.Drawing.Point(158, 19)
      Me.getNativeImage.Name = "getNativeImage"
      Me.getNativeImage.Size = New System.Drawing.Size(87, 23)
      Me.getNativeImage.TabIndex = 12
      Me.getNativeImage.Text = "Native Image"
      Me.getNativeImage.UseVisualStyleBackColor = True
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(276, 456)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(81, 13)
      Me.Label3.TabIndex = 14
      Me.Label3.Text = "Phablet device:"
      '
      'deviceName
      '
      Me.deviceName.Location = New System.Drawing.Point(363, 453)
      Me.deviceName.Name = "deviceName"
      Me.deviceName.Size = New System.Drawing.Size(100, 20)
      Me.deviceName.TabIndex = 15
      '
      'connectDevice
      '
      Me.connectDevice.Location = New System.Drawing.Point(470, 452)
      Me.connectDevice.Name = "connectDevice"
      Me.connectDevice.Size = New System.Drawing.Size(75, 23)
      Me.connectDevice.TabIndex = 16
      Me.connectDevice.Text = "Connect"
      Me.connectDevice.UseVisualStyleBackColor = True
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(199, 261)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(215, 13)
      Me.Label4.TabIndex = 18
      Me.Label4.Text = "To set the background bitmap, press Bitmap"
      '
      'getBitmap
      '
      Me.getBitmap.Location = New System.Drawing.Point(419, 256)
      Me.getBitmap.Name = "getBitmap"
      Me.getBitmap.Size = New System.Drawing.Size(75, 23)
      Me.getBitmap.TabIndex = 19
      Me.getBitmap.Text = "Bitmap"
      Me.getBitmap.UseVisualStyleBackColor = True
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(26, 240)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(105, 13)
      Me.Label5.TabIndex = 20
      Me.Label5.Text = "Control pen events..."
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(28, 293)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(97, 13)
      Me.Label6.TabIndex = 21
      Me.Label6.Tag = "Clear any handwriting. Does not change the Start and Stop state"
      Me.Label6.Text = "Clear handwriting..."
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.Location = New System.Drawing.Point(166, 293)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(120, 13)
      Me.Label7.TabIndex = 22
      Me.Label7.Tag = "Clear the display. Note that pad will still remember the background bitmap and bu" &
    "ttons created on it, which will be shown when it is next connected to."
      Me.Label7.Text = "Clear pad (Everything)..."
      '
      'clearEverything
      '
      Me.clearEverything.Location = New System.Drawing.Point(169, 310)
      Me.clearEverything.Name = "clearEverything"
      Me.clearEverything.Size = New System.Drawing.Size(75, 23)
      Me.clearEverything.TabIndex = 23
      Me.clearEverything.Text = "Clear"
      Me.toolTip.SetToolTip(Me.clearEverything, "Clears handwriting, buttons, and background bitmap. Buttons and background bitmap" &
        " are in the non-volatile memory of the pad, they will appear when the pad is nex" &
        "t ""connected"" to.")
      Me.clearEverything.UseVisualStyleBackColor = True
      '
      'pdfFile
      '
      Me.pdfFile.Location = New System.Drawing.Point(213, 419)
      Me.pdfFile.Name = "pdfFile"
      Me.pdfFile.Size = New System.Drawing.Size(75, 23)
      Me.pdfFile.TabIndex = 28
      Me.pdfFile.Text = "PDF"
      Me.pdfFile.UseVisualStyleBackColor = True
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.Location = New System.Drawing.Point(48, 424)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(159, 13)
      Me.Label9.TabIndex = 27
      Me.Label9.Text = "To display a PDF file, press PDF"
      '
      'operationalTypesTab
      '
      Me.operationalTypesTab.Controls.Add(Me.signatureCaptureTabPage)
      Me.operationalTypesTab.Controls.Add(Me.userInterfaceTabPage)
      Me.operationalTypesTab.Location = New System.Drawing.Point(12, 12)
      Me.operationalTypesTab.Name = "operationalTypesTab"
      Me.operationalTypesTab.SelectedIndex = 0
      Me.operationalTypesTab.Size = New System.Drawing.Size(568, 522)
      Me.operationalTypesTab.TabIndex = 30
      '
      'signatureCaptureTabPage
      '
      Me.signatureCaptureTabPage.BackColor = System.Drawing.SystemColors.Control
      Me.signatureCaptureTabPage.Controls.Add(Me.phabletDevice)
      Me.signatureCaptureTabPage.Controls.Add(Me.Label10)
      Me.signatureCaptureTabPage.Controls.Add(Me.stopCapture)
      Me.signatureCaptureTabPage.Controls.Add(Me.startCapture)
      Me.signatureCaptureTabPage.Controls.Add(Me.Label5)
      Me.signatureCaptureTabPage.Controls.Add(Me.connectDevice)
      Me.signatureCaptureTabPage.Controls.Add(Me.getBitmap)
      Me.signatureCaptureTabPage.Controls.Add(Me.deviceName)
      Me.signatureCaptureTabPage.Controls.Add(Me.Label4)
      Me.signatureCaptureTabPage.Controls.Add(Me.Label3)
      Me.signatureCaptureTabPage.Controls.Add(Me.clearEverything)
      Me.signatureCaptureTabPage.Controls.Add(Me.GroupBox1)
      Me.signatureCaptureTabPage.Controls.Add(Me.Label7)
      Me.signatureCaptureTabPage.Controls.Add(Me.clearHandwriting)
      Me.signatureCaptureTabPage.Controls.Add(Me.Label6)
      Me.signatureCaptureTabPage.Location = New System.Drawing.Point(4, 22)
      Me.signatureCaptureTabPage.Name = "signatureCaptureTabPage"
      Me.signatureCaptureTabPage.Padding = New System.Windows.Forms.Padding(3)
      Me.signatureCaptureTabPage.Size = New System.Drawing.Size(560, 496)
      Me.signatureCaptureTabPage.TabIndex = 0
      Me.signatureCaptureTabPage.Text = "Signature Capture"
      '
      'phabletDevice
      '
      Me.phabletDevice.Enabled = True
      Me.phabletDevice.Location = New System.Drawing.Point(68, 20)
      Me.phabletDevice.Name = "phabletDevice"
      Me.phabletDevice.OcxState = CType(resources.GetObject("phabletDevice.OcxState"), System.Windows.Forms.AxHost.State)
      Me.phabletDevice.Size = New System.Drawing.Size(449, 176)
      Me.phabletDevice.TabIndex = 29
      '
      'Label10
      '
      Me.Label10.AutoSize = True
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(42, 209)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(475, 20)
      Me.Label10.TabIndex = 30
      Me.Label10.Text = "The controls and logic on this page are typical of signature capture"
      '
      'userInterfaceTabPage
      '
      Me.userInterfaceTabPage.Controls.Add(Me.Label8)
      Me.userInterfaceTabPage.Controls.Add(Me.Label9)
      Me.userInterfaceTabPage.Controls.Add(Me.pdfFile)
      Me.userInterfaceTabPage.Location = New System.Drawing.Point(4, 22)
      Me.userInterfaceTabPage.Name = "userInterfaceTabPage"
      Me.userInterfaceTabPage.Padding = New System.Windows.Forms.Padding(3)
      Me.userInterfaceTabPage.Size = New System.Drawing.Size(560, 496)
      Me.userInterfaceTabPage.TabIndex = 1
      Me.userInterfaceTabPage.Text = "Phablet User Interface"
      Me.userInterfaceTabPage.UseVisualStyleBackColor = True
      '
      'Label8
      '
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(36, 233)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(475, 44)
      Me.Label8.TabIndex = 31
      Me.Label8.Text = "The controls and logic on this page show how to create and use a User Interface o" &
    "n the Phablet Device" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
      '
      'phabletSample
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(603, 596)
      Me.Controls.Add(Me.operationalTypesTab)
      Me.Controls.Add(Me.ok)
      Me.Name = "phabletSample"
      Me.Text = "Phablet Signature Pad"
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.operationalTypesTab.ResumeLayout(False)
      Me.signatureCaptureTabPage.ResumeLayout(False)
      Me.signatureCaptureTabPage.PerformLayout()
      CType(Me.phabletDevice, System.ComponentModel.ISupportInitialize).EndInit()
      Me.userInterfaceTabPage.ResumeLayout(False)
      Me.userInterfaceTabPage.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents startCapture As System.Windows.Forms.Button
    Friend WithEvents stopCapture As System.Windows.Forms.Button
    Friend WithEvents clearHandwriting As System.Windows.Forms.Button
    Friend WithEvents getImage As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents pdfFile As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents phabletDevice As AxPhabletSignaturePad.AxPhabletSignaturePad
    Friend WithEvents operationalTypesTab As System.Windows.Forms.TabControl
    Friend WithEvents signatureCaptureTabPage As System.Windows.Forms.TabPage
    Friend WithEvents userInterfaceTabPage As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
