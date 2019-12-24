<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficeDocumentSettings
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
Me.Label1 = New System.Windows.Forms.Label
Me.excelWorkbookName = New System.Windows.Forms.TextBox
Me.ok = New System.Windows.Forms.Button
Me.cancel = New System.Windows.Forms.Button
Me.getExcelWorkbook = New System.Windows.Forms.Button
Me.GroupBox1 = New System.Windows.Forms.GroupBox
Me.excelColumn = New System.Windows.Forms.TextBox
Me.Label6 = New System.Windows.Forms.Label
Me.excelRow = New System.Windows.Forms.TextBox
Me.Label5 = New System.Windows.Forms.Label
Me.Label4 = New System.Windows.Forms.Label
Me.worksheets = New System.Windows.Forms.ComboBox
Me.Label3 = New System.Windows.Forms.Label
Me.imageSettingsGroup = New System.Windows.Forms.GroupBox
Me.labelCurrentAspectRatio = New System.Windows.Forms.Label
Me.imageHeight = New System.Windows.Forms.TextBox
Me.imageWidth = New System.Windows.Forms.TextBox
Me.Label8 = New System.Windows.Forms.Label
Me.Label7 = New System.Windows.Forms.Label
Me.aspectRatioLabel = New System.Windows.Forms.Label
Me.Label2 = New System.Windows.Forms.Label
Me.useDeviceDimensions = New System.Windows.Forms.CheckBox
Me.keepWorkbookOpen = New System.Windows.Forms.CheckBox
Me.Label9 = New System.Windows.Forms.Label
Me.Label10 = New System.Windows.Forms.Label
Me.Label11 = New System.Windows.Forms.Label
Me.GroupBox1.SuspendLayout()
Me.imageSettingsGroup.SuspendLayout()
Me.SuspendLayout()
'
'Label1
'
Me.Label1.AutoSize = True
Me.Label1.Location = New System.Drawing.Point(13, 13)
Me.Label1.Name = "Label1"
Me.Label1.Size = New System.Drawing.Size(202, 13)
Me.Label1.TabIndex = 0
Me.Label1.Text = "Select a Microsoft Office Excel workbook"
'
'excelWorkbookName
'
Me.excelWorkbookName.Location = New System.Drawing.Point(32, 29)
Me.excelWorkbookName.Name = "excelWorkbookName"
Me.excelWorkbookName.Size = New System.Drawing.Size(277, 20)
Me.excelWorkbookName.TabIndex = 1
'
'ok
'
Me.ok.Location = New System.Drawing.Point(16, 310)
Me.ok.Name = "ok"
Me.ok.Size = New System.Drawing.Size(75, 23)
Me.ok.TabIndex = 4
Me.ok.Text = "Ok"
Me.ok.UseVisualStyleBackColor = True
'
'cancel
'
Me.cancel.Location = New System.Drawing.Point(109, 310)
Me.cancel.Name = "cancel"
Me.cancel.Size = New System.Drawing.Size(75, 23)
Me.cancel.TabIndex = 5
Me.cancel.Text = "Cancel"
Me.cancel.UseVisualStyleBackColor = True
'
'getExcelWorkbook
'
Me.getExcelWorkbook.Location = New System.Drawing.Point(315, 28)
Me.getExcelWorkbook.Name = "getExcelWorkbook"
Me.getExcelWorkbook.Size = New System.Drawing.Size(39, 23)
Me.getExcelWorkbook.TabIndex = 6
Me.getExcelWorkbook.Text = "..."
Me.getExcelWorkbook.UseVisualStyleBackColor = True
'
'GroupBox1
'
Me.GroupBox1.Controls.Add(Me.excelColumn)
Me.GroupBox1.Controls.Add(Me.Label6)
Me.GroupBox1.Controls.Add(Me.excelRow)
Me.GroupBox1.Controls.Add(Me.Label5)
Me.GroupBox1.Controls.Add(Me.Label4)
Me.GroupBox1.Controls.Add(Me.worksheets)
Me.GroupBox1.Controls.Add(Me.Label3)
Me.GroupBox1.Location = New System.Drawing.Point(370, 103)
Me.GroupBox1.Name = "GroupBox1"
Me.GroupBox1.Size = New System.Drawing.Size(228, 201)
Me.GroupBox1.TabIndex = 8
Me.GroupBox1.TabStop = False
Me.GroupBox1.Text = "Signature Location"
'
'excelColumn
'
Me.excelColumn.Location = New System.Drawing.Point(154, 102)
Me.excelColumn.Name = "excelColumn"
Me.excelColumn.Size = New System.Drawing.Size(44, 20)
Me.excelColumn.TabIndex = 6
Me.excelColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'Label6
'
Me.Label6.AutoSize = True
Me.Label6.Location = New System.Drawing.Point(106, 105)
Me.Label6.Name = "Label6"
Me.Label6.Size = New System.Drawing.Size(45, 13)
Me.Label6.TabIndex = 5
Me.Label6.Text = "Column:"
'
'excelRow
'
Me.excelRow.Location = New System.Drawing.Point(55, 102)
Me.excelRow.Name = "excelRow"
Me.excelRow.Size = New System.Drawing.Size(44, 20)
Me.excelRow.TabIndex = 4
Me.excelRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'Label5
'
Me.Label5.AutoSize = True
Me.Label5.Location = New System.Drawing.Point(22, 105)
Me.Label5.Name = "Label5"
Me.Label5.Size = New System.Drawing.Size(32, 13)
Me.Label5.TabIndex = 3
Me.Label5.Text = "Row:"
'
'Label4
'
Me.Label4.AutoSize = True
Me.Label4.Location = New System.Drawing.Point(18, 55)
Me.Label4.Name = "Label4"
Me.Label4.Size = New System.Drawing.Size(64, 13)
Me.Label4.TabIndex = 2
Me.Label4.Text = "Worksheets"
'
'worksheets
'
Me.worksheets.FormattingEnabled = True
Me.worksheets.Location = New System.Drawing.Point(19, 74)
Me.worksheets.Name = "worksheets"
Me.worksheets.Size = New System.Drawing.Size(121, 21)
Me.worksheets.TabIndex = 1
'
'Label3
'
Me.Label3.Location = New System.Drawing.Point(18, 20)
Me.Label3.Name = "Label3"
Me.Label3.Size = New System.Drawing.Size(202, 35)
Me.Label3.TabIndex = 0
Me.Label3.Text = "Select the worksheet, row, and column of the cell that will contain the signature" & _
    ""
'
'imageSettingsGroup
'
Me.imageSettingsGroup.Controls.Add(Me.useDeviceDimensions)
Me.imageSettingsGroup.Controls.Add(Me.labelCurrentAspectRatio)
Me.imageSettingsGroup.Controls.Add(Me.imageHeight)
Me.imageSettingsGroup.Controls.Add(Me.imageWidth)
Me.imageSettingsGroup.Controls.Add(Me.Label8)
Me.imageSettingsGroup.Controls.Add(Me.Label7)
Me.imageSettingsGroup.Controls.Add(Me.aspectRatioLabel)
Me.imageSettingsGroup.Controls.Add(Me.Label2)
Me.imageSettingsGroup.Location = New System.Drawing.Point(16, 103)
Me.imageSettingsGroup.Name = "imageSettingsGroup"
Me.imageSettingsGroup.Size = New System.Drawing.Size(338, 201)
Me.imageSettingsGroup.TabIndex = 10
Me.imageSettingsGroup.TabStop = False
Me.imageSettingsGroup.Text = "Signature Image Settings"
'
'labelCurrentAspectRatio
'
Me.labelCurrentAspectRatio.AutoSize = True
Me.labelCurrentAspectRatio.Location = New System.Drawing.Point(27, 162)
Me.labelCurrentAspectRatio.Name = "labelCurrentAspectRatio"
Me.labelCurrentAspectRatio.Size = New System.Drawing.Size(113, 13)
Me.labelCurrentAspectRatio.TabIndex = 6
Me.labelCurrentAspectRatio.Text = "Current aspect ratio: %"
'
'imageHeight
'
Me.imageHeight.Location = New System.Drawing.Point(175, 136)
Me.imageHeight.Name = "imageHeight"
Me.imageHeight.Size = New System.Drawing.Size(49, 20)
Me.imageHeight.TabIndex = 5
Me.imageHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'imageWidth
'
Me.imageWidth.Location = New System.Drawing.Point(69, 136)
Me.imageWidth.Name = "imageWidth"
Me.imageWidth.Size = New System.Drawing.Size(49, 20)
Me.imageWidth.TabIndex = 4
Me.imageWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'Label8
'
Me.Label8.AutoSize = True
Me.Label8.Location = New System.Drawing.Point(128, 141)
Me.Label8.Name = "Label8"
Me.Label8.Size = New System.Drawing.Size(41, 13)
Me.Label8.TabIndex = 3
Me.Label8.Text = "Height:"
'
'Label7
'
Me.Label7.AutoSize = True
Me.Label7.Location = New System.Drawing.Point(24, 141)
Me.Label7.Name = "Label7"
Me.Label7.Size = New System.Drawing.Size(38, 13)
Me.Label7.TabIndex = 2
Me.Label7.Text = "Width:"
'
'aspectRatioLabel
'
Me.aspectRatioLabel.Location = New System.Drawing.Point(24, 96)
Me.aspectRatioLabel.Name = "aspectRatioLabel"
Me.aspectRatioLabel.Size = New System.Drawing.Size(258, 44)
Me.aspectRatioLabel.TabIndex = 1
Me.aspectRatioLabel.Text = "You should try to keep the ratio of width/height close to % which is the aspect r" & _
    "atio of your device"
'
'Label2
'
Me.Label2.Location = New System.Drawing.Point(21, 62)
Me.Label2.Name = "Label2"
Me.Label2.Size = New System.Drawing.Size(261, 41)
Me.Label2.TabIndex = 0
Me.Label2.Text = "Specify the width and height ( in pixels ) of the image placed in the spreadsheet" & _
    ""
'
'useDeviceDimensions
'
Me.useDeviceDimensions.AutoSize = True
Me.useDeviceDimensions.Location = New System.Drawing.Point(14, 27)
Me.useDeviceDimensions.Name = "useDeviceDimensions"
Me.useDeviceDimensions.Size = New System.Drawing.Size(257, 17)
Me.useDeviceDimensions.TabIndex = 7
Me.useDeviceDimensions.Text = "Use the dimensions of the Phablet Signature Pad"
Me.useDeviceDimensions.UseVisualStyleBackColor = True
'
'keepWorkbookOpen
'
Me.keepWorkbookOpen.AutoSize = True
Me.keepWorkbookOpen.Location = New System.Drawing.Point(13, 57)
Me.keepWorkbookOpen.Name = "keepWorkbookOpen"
Me.keepWorkbookOpen.Size = New System.Drawing.Size(298, 17)
Me.keepWorkbookOpen.TabIndex = 11
Me.keepWorkbookOpen.Text = "Keep the workbook open after embedding the signature ?"
Me.keepWorkbookOpen.UseVisualStyleBackColor = True
'
'Label9
'
Me.Label9.AutoSize = True
Me.Label9.Location = New System.Drawing.Point(46, 76)
Me.Label9.Name = "Label9"
Me.Label9.Size = New System.Drawing.Size(262, 13)
Me.Label9.TabIndex = 12
Me.Label9.Text = "(If the workbook was already open, it will remain open)"
'
'Label10
'
Me.Label10.AutoSize = True
Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Label10.Location = New System.Drawing.Point(370, 13)
Me.Label10.Name = "Label10"
Me.Label10.Size = New System.Drawing.Size(29, 13)
Me.Label10.TabIndex = 13
Me.Label10.Text = "Tip:"
'
'Label11
'
Me.Label11.Location = New System.Drawing.Point(375, 31)
Me.Label11.Name = "Label11"
Me.Label11.Size = New System.Drawing.Size(234, 54)
Me.Label11.TabIndex = 14
Me.Label11.Text = "Specify an Excel template. That way, when the document is saved, it will prompt f" & _
    "or a new name, and you won't place multiple signatures in one file."
'
'OfficeDocumentSettings
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(619, 343)
Me.ControlBox = False
Me.Controls.Add(Me.Label11)
Me.Controls.Add(Me.Label10)
Me.Controls.Add(Me.Label9)
Me.Controls.Add(Me.keepWorkbookOpen)
Me.Controls.Add(Me.GroupBox1)
Me.Controls.Add(Me.imageSettingsGroup)
Me.Controls.Add(Me.getExcelWorkbook)
Me.Controls.Add(Me.cancel)
Me.Controls.Add(Me.ok)
Me.Controls.Add(Me.excelWorkbookName)
Me.Controls.Add(Me.Label1)
Me.Name = "OfficeDocumentSettings"
Me.Text = "Excel Workbook Settings"
Me.GroupBox1.ResumeLayout(False)
Me.GroupBox1.PerformLayout()
Me.imageSettingsGroup.ResumeLayout(False)
Me.imageSettingsGroup.PerformLayout()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents excelWorkbookName As System.Windows.Forms.TextBox
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents getExcelWorkbook As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents excelColumn As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents excelRow As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents worksheets As System.Windows.Forms.ComboBox
    Friend WithEvents imageSettingsGroup As System.Windows.Forms.GroupBox
    Friend WithEvents aspectRatioLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents imageHeight As System.Windows.Forms.TextBox
    Friend WithEvents imageWidth As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents labelCurrentAspectRatio As System.Windows.Forms.Label
    Friend WithEvents useDeviceDimensions As System.Windows.Forms.CheckBox
    Friend WithEvents keepWorkbookOpen As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
