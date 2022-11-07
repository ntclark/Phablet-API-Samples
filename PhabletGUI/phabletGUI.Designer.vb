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
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(phabletGUI))
        Me.deviceIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.connect = New System.Windows.Forms.Button()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.interfaceTab = New System.Windows.Forms.TabPage()
        Me.phabletDevice = New AxPhabletSignaturePad.AxPhabletSignaturePad()
        Me.description = New System.Windows.Forms.Label()
        Me.tabControl.SuspendLayout()
        Me.interfaceTab.SuspendLayout()
        CType(Me.phabletDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deviceIP
        '
        Me.deviceIP.Location = New System.Drawing.Point(267, 22)
        Me.deviceIP.Name = "deviceIP"
        Me.deviceIP.Size = New System.Drawing.Size(185, 20)
        Me.deviceIP.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "IP Address or network name of the Phablet Device"
        '
        'connect
        '
        Me.connect.Location = New System.Drawing.Point(464, 22)
        Me.connect.Name = "connect"
        Me.connect.Size = New System.Drawing.Size(75, 23)
        Me.connect.TabIndex = 5
        Me.connect.Text = "Connect"
        Me.connect.UseVisualStyleBackColor = True
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.interfaceTab)
        Me.tabControl.Location = New System.Drawing.Point(23, 64)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(806, 427)
        Me.tabControl.TabIndex = 8
        '
        'interfaceTab
        '
        Me.interfaceTab.BackColor = System.Drawing.Color.White
        Me.interfaceTab.Controls.Add(Me.phabletDevice)
        Me.interfaceTab.Location = New System.Drawing.Point(4, 22)
        Me.interfaceTab.Name = "interfaceTab"
        Me.interfaceTab.Padding = New System.Windows.Forms.Padding(3)
        Me.interfaceTab.Size = New System.Drawing.Size(798, 401)
        Me.interfaceTab.TabIndex = 0
        Me.interfaceTab.Text = "Interface"
        '
        'phabletDevice
        '
        Me.phabletDevice.Enabled = True
        Me.phabletDevice.Location = New System.Drawing.Point(0, 0)
        Me.phabletDevice.Margin = New System.Windows.Forms.Padding(0)
        Me.phabletDevice.Name = "phabletDevice"
        Me.phabletDevice.OcxState = CType(resources.GetObject("phabletDevice.OcxState"), System.Windows.Forms.AxHost.State)
        Me.phabletDevice.Size = New System.Drawing.Size(752, 361)
        Me.phabletDevice.TabIndex = 0
        '
        'description
        '
        Me.description.Location = New System.Drawing.Point(24, 494)
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(747, 55)
        Me.description.TabIndex = 9
        '
        'phabletGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 558)
        Me.Controls.Add(Me.description)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.deviceIP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.connect)
        Me.Name = "phabletGUI"
        Me.Text = "Phablet GUI"
        Me.tabControl.ResumeLayout(False)
        Me.interfaceTab.ResumeLayout(False)
        CType(Me.phabletDevice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents deviceIP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents connect As Button
    Friend WithEvents tabControl As TabControl
    Friend WithEvents interfaceTab As TabPage
    Friend WithEvents phabletDevice As AxPhabletSignaturePad.AxPhabletSignaturePad
    Friend WithEvents description As Label
End Class
