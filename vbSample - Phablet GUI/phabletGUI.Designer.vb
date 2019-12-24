<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class phabletGUI
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
   <System.Diagnostics.DebuggerStepThrough()>
   Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(phabletGUI))
      Me.tabControl = New System.Windows.Forms.TabControl()
      Me.interfaceTab = New System.Windows.Forms.TabPage()
      Me.phabletDevice = New AxPhabletSignaturePad.AxPhabletSignaturePad()
      Me.description = New System.Windows.Forms.Label()
      Me.connect = New System.Windows.Forms.Button()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.deviceIP = New System.Windows.Forms.TextBox()
      Me.tabControl.SuspendLayout()
      Me.interfaceTab.SuspendLayout()
      CType(Me.phabletDevice, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'tabControl
      '
      Me.tabControl.Controls.Add(Me.interfaceTab)
      Me.tabControl.Location = New System.Drawing.Point(13, 52)
      Me.tabControl.Name = "tabControl"
      Me.tabControl.SelectedIndex = 0
      Me.tabControl.Size = New System.Drawing.Size(973, 709)
      Me.tabControl.TabIndex = 0
      '
      'interfaceTab
      '
      Me.interfaceTab.Controls.Add(Me.phabletDevice)
      Me.interfaceTab.Location = New System.Drawing.Point(4, 22)
      Me.interfaceTab.Name = "interfaceTab"
      Me.interfaceTab.Padding = New System.Windows.Forms.Padding(3)
      Me.interfaceTab.Size = New System.Drawing.Size(965, 683)
      Me.interfaceTab.TabIndex = 0
      Me.interfaceTab.Text = "Interface"
      Me.interfaceTab.UseVisualStyleBackColor = True
      '
      'phabletDevice
      '
      Me.phabletDevice.Enabled = True
      Me.phabletDevice.Location = New System.Drawing.Point(16, 20)
      Me.phabletDevice.Name = "phabletDevice"
      Me.phabletDevice.OcxState = CType(resources.GetObject("phabletDevice.OcxState"), System.Windows.Forms.AxHost.State)
      Me.phabletDevice.Size = New System.Drawing.Size(922, 401)
      Me.phabletDevice.TabIndex = 0
      '
      'description
      '
      Me.description.Location = New System.Drawing.Point(14, 764)
      Me.description.Name = "description"
      Me.description.Size = New System.Drawing.Size(586, 92)
      Me.description.TabIndex = 1
      '
      'connect
      '
      Me.connect.Location = New System.Drawing.Point(464, 10)
      Me.connect.Name = "connect"
      Me.connect.Size = New System.Drawing.Size(75, 23)
      Me.connect.TabIndex = 2
      Me.connect.Text = "Connect"
      Me.connect.UseVisualStyleBackColor = True
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(20, 13)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(246, 13)
      Me.Label1.TabIndex = 3
      Me.Label1.Text = "IP Address or network name of the Phablet Device"
      '
      'deviceIP
      '
      Me.deviceIP.Location = New System.Drawing.Point(267, 10)
      Me.deviceIP.Name = "deviceIP"
      Me.deviceIP.Size = New System.Drawing.Size(185, 20)
      Me.deviceIP.TabIndex = 4
      '
      'phabletGUI
      '
      Me.ClientSize = New System.Drawing.Size(1111, 861)
      Me.Controls.Add(Me.deviceIP)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.connect)
      Me.Controls.Add(Me.description)
      Me.Controls.Add(Me.tabControl)
      Me.Name = "phabletGUI"
      Me.tabControl.ResumeLayout(False)
      Me.interfaceTab.ResumeLayout(False)
      CType(Me.phabletDevice, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents description As Label
   Friend WithEvents tabControl As TabControl
   Friend WithEvents interfaceTab As TabPage
   Friend WithEvents Label1 As Label
   Friend WithEvents deviceIP As TextBox
   Friend WithEvents connect As Button
   Friend WithEvents phabletDevice As AxPhabletSignaturePad.AxPhabletSignaturePad
End Class
