﻿Public Class phabletGUI

   Private Const idWelcomeToPhablet1 As Long = 1
   Private Const idWelcomeToPhablet2 As Long = 2
   Private Const idWelcomeToPhablet3 As Long = 3
   Private Const idWelcomeToPhablet4 As Long = 4
   Private Const idWelcomeToPhablet5 As Long = 5
   Private Const idWelcomeToPhablet6 As Long = 6

   Private Const idGoButton As Long = 7
   Private Const idDropDownBox As Long = 8
   Private Const idEntryField As Long = 9

   Private Const idColumn1Label As Long = 10
   Private Const idColumn2Label As Long = 11
   Private Const idColumn3Label As Long = 12
   Private Const idColumn4Label As Long = 13

   Private Const idCheckBox As Long = 14

   Private Const idRadioButtonGroupA1 As Long = 15
   Private Const idRadioButtonGroupA2 As Long = 16
   Private Const idRadioButtonGroupA3 As Long = 17

   Private Const minPage1Ids = 1
   Private Const maxPage1Ids = 17

   Private Const idButtonPage2 = 102
   Private Const idButtonPage3 = 103

   Private Const idTextBox = 200
   Private Const idButtonPage1 = 201

   Private Const idClearButton = 301
   Private Const idOkButton = 302
   Private Const idSignBackButton = 303
   Private Const idSignInstructions = 304

   Private isAgreed As Boolean = False

   Private Const fontSize = 8
   Private Const fontFamily = "Arial"

   Dim formLoaded As Boolean = False

   Private Sub loadUserInterface()

      Dim rect As PhabletSignaturePad.tagRECT
      Dim rectControl As PhabletSignaturePad.tagRECT
      Dim rectButton As PhabletSignaturePad.tagRECT
      Dim rectEntire As PhabletSignaturePad.tagRECT

      Dim ptControl As PhabletSignaturePad.tagPOINT
      Dim controlWidth As Integer, controlHeight As Integer
      Dim textHeight As Integer, headlineBottom As Integer
      Dim introBottom As Integer
      Dim buttonHeight As Integer

      Try

         If (Not phabletDevice.IsConnected) Then
            phabletDevice.Connect(deviceIP.Text)
         End If


      Catch ex As Exception

         MsgBox("Is the Phablet Device connected ?" +
               Chr(10) + Chr(10) + "Please make sure the PhabletSignaturePad App is running on the Android device." +
               Chr(10) + Chr(10) + "Please also double check the IP Address or network name for the device." +
               Chr(10) + Chr(10) + "The system was expecting to find the device at: " + phabletDevice.IPOrNetworkName)

         Exit Sub

      End Try

      My.Settings.DeviceIP = deviceIP.Text

      phabletDevice.IPOrNetworkName = deviceIP.Text

      phabletDevice.ClearEverything()

      '
      ' Setting the Phablet to not show updates while creating controls prevents the UI from displaying them
      ' as they are getting created, providing a snappier interface construction experience.
      '
      phabletDevice.ShowUpdates = True

      phabletDevice.FontFamily = fontFamily

      phabletDevice.FontSize = fontSize

      rectEntire = phabletDevice.get_Bounds()

      phabletDevice.CreatePage("Page 1", 1, 1)
      '
      ' Creating a Label. Last parameter is fontSize in 1/72 of an inch (points)
      '
      phabletDevice.CreateLabelInches("The Phablet Signature Pad interface builder", idWelcomeToPhablet1, 0.0, 0.0, 1, "Arial", 1.5 * fontSize)

      rect = phabletDevice.get_ControlBounds(idWelcomeToPhablet1)

      headlineBottom = rect.bottom

      textHeight = rect.bottom - rect.top

      phabletDevice.CreateTextBox("Now you can easily create user interface controls on this Android device and deploy a " &
                                       "Windows application TO Android with NO Android development required." & Chr(13) & Chr(10) & "Here are some examples",
                                          idWelcomeToPhablet2, 16, textHeight, phabletDevice.DeviceWidth - 16 - 8, phabletDevice.DeviceHeight - textHeight - 8, 1)

      rect = phabletDevice.get_ControlBounds(idWelcomeToPhablet2)

      introBottom = rect.bottom + 8

      phabletDevice.CreateLabel("DropDown Box:", idColumn1Label, 16, introBottom, 1, fontFamily, fontSize)

      rect = phabletDevice.get_ControlBounds(idColumn1Label)

      phabletDevice.CreateLabel("Command Button:", idColumn2Label, rect.right + 20, introBottom, 1, fontFamily, fontSize)

      rect = phabletDevice.get_ControlBounds(idColumn2Label)

      phabletDevice.CreateLabel("Radio Button Group:", idColumn3Label, rect.right + 32, introBottom, 1, fontFamily, fontSize)

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

      'phabletDevice.CreateLabelInches("Text at (0.25,1.55) inches", idWelcomeToPhablet6, 0.25, 1.55, 1, fontFamily, fontSize)

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
      ' The entry field will be below the Go button
      '
      phabletDevice.CreateLabel("Entry Field:", idColumn4Label, 16, rectControl.bottom + 24, 1, fontFamily, fontSize)

      rectControl = phabletDevice.get_ControlBounds(idColumn4Label)

      phabletDevice.CreateEntryField("", idEntryField, rectControl.right + 16, rectControl.top, 240, 1, fontFamily, fontSize)

      rect = phabletDevice.get_ControlBounds(idColumn1Label)

      '
      ' Creating a CheckBox
      '
      ' Arguments are: Text, id, x, y, isVisible, isChecked
      '
      phabletDevice.CreateCheckBox("Check if you Like Broccoli ?", idCheckBox, 16, phabletDevice.DeviceHeight - 60, 1, 1)

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

      ptControl.x = rect.left + 24

      ptControl.y = rect.top + buttonHeight

      phabletDevice.set_ControlPosition(idRadioButtonGroupA1, ptControl)
      phabletDevice.ShowControl(idRadioButtonGroupA1)

      ptControl.y = ptControl.y + buttonHeight

      phabletDevice.set_ControlPosition(idRadioButtonGroupA2, ptControl)
      phabletDevice.ShowControl(idRadioButtonGroupA2)

      ptControl.y = ptControl.y + buttonHeight

      phabletDevice.set_ControlPosition(idRadioButtonGroupA3, ptControl)
      phabletDevice.ShowControl(idRadioButtonGroupA3)

      '
      ' Another Button to show the next page.
      '
      phabletDevice.CreateButton("Next", idButtonPage2, 0, 0, 1)

      rectButton = phabletDevice.get_ControlBounds(idButtonPage2)

      ptControl.x = phabletDevice.DeviceWidth - rectButton.right - rectButton.left - 16
      ptControl.y = phabletDevice.DeviceHeight - (rectButton.bottom - rectButton.top) - 8

      phabletDevice.set_ControlPosition(idButtonPage2, ptControl)

      '
      ' Now, create a whole new page of controls, which aren't shown until the user presses next
      ' 

      phabletDevice.CreatePage("Page 2", 2, 1)

      phabletDevice.CreateTextBox(My.Resources.TextBoxEntry, idTextBox, 4, 4, phabletDevice.DeviceWidth - 16,
                  phabletDevice.DeviceHeight - (rectButton.bottom - rectButton.top) - 16 - 8, 0, fontFamily, fontSize)

      phabletDevice.CreateButton("Back", idButtonPage1, 16, phabletDevice.DeviceHeight - (rectButton.bottom - rectButton.top) - 8, 0)

      phabletDevice.CreateButton("Sign", idButtonPage3, phabletDevice.DeviceWidth - rectButton.right - rectButton.left - 16,
                                    phabletDevice.DeviceHeight - (rectButton.bottom - rectButton.top) - 8, 0)

      phabletDevice.CreatePage("Page 3", 3, 1)

      '
      ' These controls are on the "sign here" page.
      '

      phabletDevice.CreateButton("Clear", idClearButton, 4, 4, 0)

      '
      ' The event ID ( 2nd parameter) of the button is up to the developer. You can specify any value, when you recieve the
      ' option selected event, this ID value will be in the event parameter.
      '

      phabletDevice.CreateButton("Ok", idOkButton, 4, 4, 0)

      phabletDevice.CreateButton("Back", idSignBackButton, 16, phabletDevice.DeviceHeight - (rectButton.bottom - rectButton.top) - 8, 0)

      rectButton = phabletDevice.get_ControlBounds(idSignBackButton)

      phabletDevice.CreateCheckBox("I have read and understood the agreement", idSignInstructions, rectButton.right + 32, phabletDevice.DeviceHeight - (rectButton.bottom - rectButton.top) - 8, 0, 0)

      phabletDevice.ShowUpdates = True

   End Sub


   Private Sub phabletDevice_OptionSelected(ByVal sender As System.Object, ByVal e As AxPhabletSignaturePad.IPhabletSignaturePadEvents_OptionSelectedEvent) Handles phabletDevice.OptionSelected

      If e.optionNumber = idGoButton Then
         MsgBox("Someone taped Go on the Phablet")
      End If

      If e.optionNumber = idCheckBox Then
         MsgBox("Somebody likes brocolli")
      End If

      If idRadioButtonGroupA1 <= e.optionNumber And e.optionNumber <= idRadioButtonGroupA3 Then
         MsgBox("Somebody Is feeling " + phabletDevice.get_ControlText(e.optionNumber) + " today")
      End If

      If e.optionNumber = idButtonPage2 Then

         phabletDevice.ShowPage(2, 1)

      End If

      If e.optionNumber = idButtonPage1 Then

         phabletDevice.ShowPage(1, 1)

      End If

      If e.optionNumber = idButtonPage3 Then

         phabletDevice.ShowPage(2, 0)

         phabletDevice.ShowPage(3, 1)

         '
         ' Obtain the size of the Ok button in order to place it against the right edge of the display ( minus 12 pixels )
         '
         Dim rect As PhabletSignaturePad.tagRECT
         Dim point As PhabletSignaturePad.tagPOINT

         Dim buttonWidth As Integer, buttonHeight As Integer

         rect = phabletDevice.get_ControlBounds(idOkButton)

         buttonWidth = rect.right - rect.left
         buttonHeight = rect.bottom - rect.top

         rect.left = phabletDevice.DeviceWidth - buttonWidth - 12

         point.x = rect.left
         point.y = rect.top

         phabletDevice.set_ControlPosition(idOkButton, point)

         'phabletDevice.ShowControl(idSignBackButton)
         'phabletDevice.ShowControl(idSignInstructions)

         Dim hBitmap As IntPtr = My.Resources.StandardForm.GetHbitmap()

         Do While 0 > hBitmap.ToInt64

            hBitmap = My.Resources.StandardForm.GetHbitmap()

         Loop

         phabletDevice.BackgroundBitmapHandle = hBitmap

         phabletDevice.Start()

         phabletDevice.ShowUpdates = True

      End If

      If e.optionNumber = idClearButton Then

         phabletDevice.ClearInk()

      End If

      If e.optionNumber = idSignInstructions Then
         isAgreed = True
      End If

      If e.optionNumber = idOkButton Then

         If Not isAgreed Then

            phabletDevice.ShowMessage("Please affirm your agreement and try again")

            Exit Sub

         End If

         tabControl.TabPages.Add("Signature" & (tabControl.TabPages.Count()).ToString())

         Dim newPage As TabPage = tabControl.TabPages(tabControl.TabPages.Count() - 1)

         Dim pictureBox As PictureBox = New PictureBox()

         Dim bitmap As New Bitmap(phabletDevice.NativeSizeImageFile)

         pictureBox.Image = bitmap.Clone()

         newPage.Controls.Add(pictureBox)

         pictureBox.Width = phabletDevice.DeviceWidth
         pictureBox.Height = phabletDevice.DeviceHeight

         pictureBox.Left = newPage.Width / 2 - pictureBox.Width / 2
         pictureBox.Top = newPage.Height / 2 - pictureBox.Height / 2

         bitmap.Dispose()

         My.Computer.FileSystem.DeleteFile(phabletDevice.NativeSizeImageFile)

         phabletDevice.ClearInk()

         phabletDevice.ClearBackground()

         phabletDevice.ShowPage(1, 1)

      End If

      If e.optionNumber = idSignBackButton Then

         phabletDevice.ClearInk()

         phabletDevice.ClearBackground()

         phabletDevice.ShowPage(2, 1)

      End If

   End Sub

   Private Sub phabletDevice_OptionUnSelected(ByVal sender As System.Object, ByVal e As AxPhabletSignaturePad.IPhabletSignaturePadEvents_OptionUnSelectedEvent) Handles phabletDevice.OptionUnSelected

      If e.optionNumber = idCheckBox Then
         MsgBox("Somebody doesn't like brocolli")
      End If

      If e.optionNumber = idSignInstructions Then
         isAgreed = False
      End If

   End Sub


   Private Sub phabletGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      deviceIP.Text = My.Settings.DeviceIP

   End Sub

   Private Sub connect_Click(sender As Object, e As EventArgs) Handles connect.Click

      description.Text = My.Resources.isLoading

      'Update()

      Try

         phabletDevice.Connect(deviceIP.Text)

         If (phabletDevice.IsConnected) Then
            loadUserInterface()
            description.Text = My.Resources.isLoaded
         End If

         Exit Try

      Catch ex As Exception

         MsgBox("Is the Phablet Device connected ?" +
               Chr(10) + Chr(10) + "Please make sure the PhabletSignaturePad App is running on the Android device." +
               Chr(10) + Chr(10) + "Please also double check the IP Address or network name for the device." +
               Chr(10) + Chr(10) + "Is a firewall blocking ports 17639 thru 17642 ?" +
               Chr(10) + Chr(10) + "The system was expecting to find the device at: " + deviceIP.Text)

      End Try

   End Sub

   Private Sub phabletDevice_ShuttingDown(sender As Object, e As EventArgs) Handles phabletDevice.ShuttingDown

      Application.Exit()

   End Sub

End Class