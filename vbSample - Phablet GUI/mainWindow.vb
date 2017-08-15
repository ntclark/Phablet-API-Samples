
Public Class mainWindow

   Private Const idWelcomeToPhablet1 As Long = 1
   Private Const idWelcomeToPhablet2 As Long = 2
   Private Const idWelcomeToPhablet3 As Long = 3
   Private Const idWelcomeToPhablet4 As Long = 4
   Private Const idWelcomeToPhablet5 As Long = 5

   Private Const idGoButton As Long = 6
   Private Const idDropDownBox As Long = 7

   Private Const idColumn1Label As Long = 8
   Private Const idColumn2Label As Long = 9
   Private Const idColumn3Label As Long = 10

   Private Const idCheckBox As Long = 11

   Private Const idRadioButtonGroupA1 As Long = 14
   Private Const idRadioButtonGroupA2 As Long = 15
   Private Const idRadioButtonGroupA3 As Long = 16

   Private Const minPage1Ids = 1
   Private Const maxPage1Ids = 16

   Private Const idButtonPage2 = 101
   Private Const idButtonPage1 = 102

   Private Const idTextBox = 200

   Private Const fontSize = 10

   Dim formLoaded As Boolean = False

   Private Sub mainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

      Dim rect As PhabletSignaturePad.tagRECT
      Dim rectControl As PhabletSignaturePad.tagRECT
      Dim rectButton As PhabletSignaturePad.tagRECT
      Dim ptControl As PhabletSignaturePad.tagPOINT
      Dim controlWidth As Integer, controlHeight As Integer
      Dim textHeight As Integer, headlineBottom As Integer
      Dim introBottom As Integer
      Dim buttonHeight As Integer

      Try

         phabletDevice.Connect("")

      Catch ex As Exception

         MsgBox("Is the Phablet Device connected ?" +
               Chr(10) + Chr(10) + "For Android devices, please make sure the Phablet App is running on it." +
               Chr(10) + Chr(10) + "Please also double check the IP Address or network name for the device." +
               Chr(10) + Chr(10) + "The system was expecting to find the device at: " + phabletDevice.IPOrNetworkName)

         Exit Sub

      End Try

      phabletDevice.FontFamily = "Arial"

      phabletDevice.FontSize = fontSize

      '
      ' Creating a Label. Last parameter is fontSize in 1/72 of an inch (points)
      '
      phabletDevice.CreateLabelInches("Welcome to the Phablet Signature Pad interface builder", idWelcomeToPhablet1, 0.0, 0.0, 1, "Arial", 1.5 * fontSize)

      rect = phabletDevice.get_ControlBounds(idWelcomeToPhablet1)

      headlineBottom = rect.bottom

      textHeight = rect.bottom - rect.top

      phabletDevice.CreateTextBox("Now you can easily create user interface controls on this pad and develop a powerful Windows application which communicates with your users no matter where they are with the pad." & Chr(13) & Chr(10) & "Here are some examples",
                                          idWelcomeToPhablet2, 16, textHeight, phabletDevice.DeviceWidth - 16 - 8, phabletDevice.DeviceHeight - textHeight - 8, 1)

      rect = phabletDevice.get_ControlBounds(idWelcomeToPhablet2)

      introBottom = rect.bottom + 8

      phabletDevice.CreateLabel("A DropDown Box:", idColumn1Label, 16, introBottom, 1) ', "Arial", fontSize)

      rect = phabletDevice.get_ControlBounds(idColumn1Label)

      phabletDevice.CreateLabel("A Command Button:", idColumn2Label, rect.right + 24, introBottom, 1) ', "Arial", fontSize)

      rect = phabletDevice.get_ControlBounds(idColumn2Label)

      phabletDevice.CreateLabel("A Radio Button Group:", idColumn3Label, rect.right + 24, introBottom, 1) ', "Arial", fontSize)

      '
      ' Creating a ComboBox
      ' 
      ' Arguments are: list of items ( comma delimited ), control ID, x, y, isVisible, selected item (optional)
      '   (The control is created hidden, it's size is determined, and the position is adjusted, before showing the control)
      '

      phabletDevice.CreateDropDownBox("item 1,item 2,item 3,item 4", idDropDownBox, 0, 0, 0, "item 3")

      '
      ' The Combobox is centered beneath the label above it
      '

      rect = phabletDevice.get_ControlBounds(idColumn1Label)

      rectControl = phabletDevice.get_ControlBounds(idDropDownBox)

      controlWidth = rectControl.right - rectControl.left
      controlHeight = rectControl.bottom - rectControl.top

      rectControl.left = (rect.right - rect.left) / 2 - (rectControl.right - rectControl.left) / 2
      rectControl.top = rect.bottom + 6
      rectControl.right = rectControl.left + controlWidth
      rectControl.bottom = rectControl.top + controlHeight

      ptControl.x = rectControl.left
      ptControl.y = rectControl.top

      phabletDevice.set_ControlPosition(idDropDownBox, ptControl)

      phabletDevice.ShowControl(idDropDownBox)

      '
      ' A Command Button
      '
      ' Arguments are: Text, controlId, x, y, isVisible
      '
      phabletDevice.CreateButton("Go", idGoButton, 0, 0, 0)

      rect = phabletDevice.get_ControlBounds(idColumn2Label)

      rectControl = phabletDevice.get_ControlBounds(idGoButton)

      controlWidth = rectControl.right - rectControl.left
      controlHeight = rectControl.bottom - rectControl.top

      rectControl.left = (rect.right + rect.left) / 2 - controlWidth / 2
      rectControl.top = rect.bottom + 6
      rectControl.right = rectControl.left + controlWidth
      rectControl.bottom = rectControl.top + controlHeight

      ptControl.x = rectControl.left
      ptControl.y = rectControl.top

      phabletDevice.set_ControlPosition(idGoButton, ptControl)

      phabletDevice.ShowControl(idGoButton)

      '
      ' Creating a CheckBox
      '
      ' Arguments are: Text, id, x, y, isVisible, isChecked
      '
      phabletDevice.CreateCheckBox("Check if you like Broccoli ?", idCheckBox, 16, 480, 1, 1)

      '
      ' Creating a RadioButton. Be sure to set the group number of all radio buttons in a logical set to the same value.
      ' Radio buttons in the same group number represent a mutually exclusive choice among members of that group.
      '
      ' Arguments are: Text, id, x, y, isVisible, groupNumber, isChecked
      '
      phabletDevice.CreateRadioButton("Happy", idRadioButtonGroupA1, 0, 0, 0, 2, 0)

      '
      ' Creating another RadioButton in the same group
      '
      phabletDevice.CreateRadioButton("Sad", idRadioButtonGroupA2, 0, 0, 0, 2, 0)

      '
      ' Creating another RadioButton in the same group
      '
      phabletDevice.CreateRadioButton("None of Your Business", idRadioButtonGroupA3, 0, 0, 0, 2, 1)

      '
      ' Position this group of radio buttons under column 3
      '
      rect = phabletDevice.get_ControlBounds(idColumn3Label)

      rectButton = phabletDevice.get_ControlBounds(idRadioButtonGroupA1)

      buttonHeight = rectButton.bottom - rectButton.top

      ptControl.x = rect.left + 8

      ptControl.y = rect.top + buttonHeight

      phabletDevice.set_ControlPosition(idRadioButtonGroupA1, ptControl)

      ptControl.y = ptControl.y + buttonHeight

      phabletDevice.set_ControlPosition(idRadioButtonGroupA2, ptControl)

      ptControl.y = ptControl.y + buttonHeight

      phabletDevice.set_ControlPosition(idRadioButtonGroupA3, ptControl)

      phabletDevice.ShowControl(idRadioButtonGroupA1)
      phabletDevice.ShowControl(idRadioButtonGroupA2)
      phabletDevice.ShowControl(idRadioButtonGroupA3)

      '
      ' Another Button to show the next page.
      '
      phabletDevice.CreateButton("Next", idButtonPage2, 0, 0, 0)

      rectButton = phabletDevice.get_ControlBounds(idButtonPage2)

      rectControl = phabletDevice.get_Bounds()

      ptControl.x = rectControl.right - (rectButton.right - rectButton.left) - 16
      ptControl.y = (rectControl.bottom - rectControl.top) / 2 - (rectButton.bottom - rectButton.top) / 2

      phabletDevice.set_ControlPosition(idButtonPage2, ptControl)

      phabletDevice.ShowControl(idButtonPage2)

      '
      ' Now, create a whole new page of controls, which aren't shown until the user presses next
      ' 

      phabletDevice.CreateTextBox(My.Resources.TextBoxEntry, idTextBox, 0, 0, phabletDevice.DeviceWidth, phabletDevice.DeviceHeight - 64, 0, "Arial", 24)

      phabletDevice.CreateButton("Back", idButtonPage1, 16, phabletDevice.DeviceHeight - 60, 0)

   End Sub


   'Private Sub mainWindow_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

   '   formLoaded = True

   'End Sub


   Private Sub phabletDevice_OptionSelected(ByVal sender As System.Object, ByVal e As AxPhabletSignaturePad.IPhabletSignaturePadEvents_OptionSelectedEvent) Handles phabletDevice.OptionSelected

      If e.optionNumber = idGoButton Then
         MsgBox("Someone taped Go on the Phablet")
      End If

      If e.optionNumber = idCheckBox Then
         MsgBox("Somebody likes brocolli")
      End If

      If idRadioButtonGroupA1 <= e.optionNumber And e.optionNumber <= idRadioButtonGroupA3 Then
         MsgBox("Somebody is feeling " + phabletDevice.get_ControlText(e.optionNumber) + " today")
      End If

      If e.optionNumber = idButtonPage2 Then

         Dim k As Integer
         Dim controlIds As String
         controlIds = ""
         For k = minPage1Ids To maxPage1Ids
            'phabletDevice.HideControl(k)
            controlIds = controlIds & k & ","
         Next k

         phabletDevice.HideControlList(controlIds)

         phabletDevice.HideControl(idButtonPage2)

         phabletDevice.ShowControl(idTextBox)

         phabletDevice.ShowControl(idButtonPage1)

      End If

      If e.optionNumber = idButtonPage1 Then

         phabletDevice.HideControl(idTextBox)

         phabletDevice.HideControl(idButtonPage1)

         Dim k As Integer
         Dim controlIds As String
         controlIds = ""
         For k = minPage1Ids To maxPage1Ids
            ''phabletDevice.ShowControl(k)
            controlIds = controlIds & k & ","
         Next k

         phabletDevice.ShowControlList(controlIds)

         phabletDevice.ShowControl(idButtonPage2)

      End If

   End Sub

Private Sub phabletDevice_ItemSelected(ByVal sender As System.Object, ByVal e As AxPhabletSignaturePad.IPhabletSignaturePadEvents_ItemSelectedEvent) Handles phabletDevice.ItemSelected

   If e.controlID = idDropDownBox And formLoaded Then
      MsgBox(e.theItem + " has been selected")
   End If

End Sub

Private Sub phabletDevice_OptionUnSelected(ByVal sender As System.Object, ByVal e As AxPhabletSignaturePad.IPhabletSignaturePadEvents_OptionUnSelectedEvent) Handles phabletDevice.OptionUnSelected

   If e.optionNumber = idCheckBox Then
      MsgBox("Somebody doesn't like brocolli")
   End If

End Sub

End Class
