Imports System.Drawing.Imaging
Imports System.Threading

Public Class LGOMain

    'Declare public variables
    Public ADCStatus1 As Integer 'If ADC Status1 (ADC #0) is low, then the roof is closed
    Public ADCStatus2 As Integer 'If ADC Status2 (ADC #2) is low, then the roof is open
    Public Status0 As Long 'Scope on/off relay - Relay Bank #0 #0
    Public Status1 As Long 'Roof motor to close relay
    Public Status2 As Long 'Motor direction change relay - combine with Relay1 to close roof
    Public Status3 As Long 'Roof motor to open relay
    Public Status4 As Long 'Large heat trip on/off relay - Relay Bank #0 #4
    Public Status5 As Long 'Small heat strip on/off reay - Relay Bank #0 #5
    Public Status6 As Long 'Scope fans on/off relay - Relay Bank #0 #6
    Public Status7 As Long 'Camera power on/off relay - Relay Bank #1 #7   
    Public Status8 As Long 'IR Illuminator on/off relay - Relay Bank #1 #1
    Public Abort As Long = 0
    Public ComPort As String
 

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        NcdComponent1.ClosePort() 'Close serial port when form closes
    End Sub

    Private Sub LGOMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim TimerActive As NCD.TimerParameters

        'Load initial pics 
        RadarPictureBox.ImageLocation = "http://api.wunderground.com/api/9ca3fbaae1d0550d/radar/image.gif?centerlat=36.131&centerlon=-84.796&radius=10&width=540&height=320&newmaps=1"
        'LGOPictureBox.ImageLocation = "http://lgo.dynalias.net:8081/cgi-bin/zm/nph-zms?mode=single&monitor=8&scale=100&user=tim&pass=buddie"
        LGOPictureBox.ImageLocation = "http://192.168.1.101:8081/cgi-bin/zm/nph-zms?mode=single&monitor=8&scale=100&user=tim&pass=buddie"

        'Connect relays
        ConnectRelays()

        'Check roof relays to make sure that none are on
        RoofRelaysOff()

        'Check roof status and update control
        RoofStatus()

        'Update Relay and equipment status
        UpdateRelayStatus()

        'Check for existing fan timer
        TimerActive = NcdComponent1.ProXR.Timers.TimerQuery(0)
        If TimerActive.hours <> 0 Or TimerActive.minutes <> 0 Or TimerActive.seconds <> 0 Then
            FanCountdownTimer.Enabled = True
        Else
            FanTimeRemainingTB.Text = "Timer Not Set"
        End If

        'Start timers for pictures and update timer - LGO pics gets updated every second and Radar gets updated every 2.5 minutes
        LGOPictureTimer.Enabled = True
        RadarPictureTimer.Enabled = True
        UpdateStatusTimer.Enabled = True



    End Sub


    Private Sub LGOPictureTimer_Tick(sender As Object, e As EventArgs) Handles LGOPictureTimer.Tick

        'LGOPictureBox.ImageLocation = "http://lgo.dynalias.net:8081/cgi-bin/zm/nph-zms?mode=single&monitor=8&scale=100&user=tim&pass=buddie"
        LGOPictureBox.ImageLocation = "http://192.168.1.101:8081/cgi-bin/zm/nph-zms?mode=single&monitor=8&scale=100&user=tim&pass=buddie"


    End Sub

    Private Sub RadarPictureTimer_Tick(sender As Object, e As EventArgs) Handles RadarPictureTimer.Tick

        RadarPictureBox.ImageLocation = "http://api.wunderground.com/api/9ca3fbaae1d0550d/radar/image.gif?centerlat=36.131&centerlon=-84.796&radius=10&width=540&height=320&newmaps=1"

    End Sub

    Sub ConnectRelays()

        Try
            NcdComponent1.OpenPort(2000) 'Open serial port and set timeout to 2 seconds
            If NcdComponent1.IsOpen = False Then 'Get status of serial port
                NcdComponent1.SettingPort()
                NcdComponent1.OpenPort(2000) 'Open serial port and set timeout to 2 seconds
            End If
        Catch ex As Exception
            MsgBox("Can't connect to relay panel!" & vbCrLf & ex.Message)
        End Try


        Return
    End Sub

    Sub UpdateRelayStatus()

        On Error GoTo ErrorHandler

        'Get status of relays
        Status0 = NcdComponent1.ProXR.RelayBanks.GetStatusInBank(0, 1)
        Status1 = NcdComponent1.ProXR.RelayBanks.GetStatusInBank(1, 1)
        Status2 = NcdComponent1.ProXR.RelayBanks.GetStatusInBank(2, 1)
        Status3 = NcdComponent1.ProXR.RelayBanks.GetStatusInBank(3, 1)
        Status4 = NcdComponent1.ProXR.RelayBanks.GetStatusInBank(4, 1)
        Status5 = NcdComponent1.ProXR.RelayBanks.GetStatusInBank(5, 1)
        Status6 = NcdComponent1.ProXR.RelayBanks.GetStatusInBank(6, 1)
        Status7 = NcdComponent1.ProXR.RelayBanks.GetStatusInBank(7, 2)
        Status8 = NcdComponent1.ProXR.RelayBanks.GetStatusInBank(0, 2)

        'Set status of relay status buttons and equipment status buttons
        If Status0 = 1 Then
            Relay0StatusBtn.BackColor = Color.Lime
            Relay0StatusBtn.Text = "ON"
            ScopeStatusBtn.BackColor = Color.Lime
            ScopeStatusBtn.Text = "SCOPE ON"
        Else
            Relay0StatusBtn.BackColor = Color.Red
            Relay0StatusBtn.Text = "OFF"
            ScopeStatusBtn.BackColor = Color.Red
            ScopeStatusBtn.Text = "SCOPE OFF"
        End If

        If Status1 = 1 Then
            Relay1StatusBtn.BackColor = Color.Lime
            Relay1StatusBtn.Text = "ON"
        Else
            Relay1StatusBtn.BackColor = Color.Red
            Relay1StatusBtn.Text = "OFF"
        End If

        If Status2 = 1 Then
            Relay2StatusBtn.BackColor = Color.Lime
            Relay2StatusBtn.Text = "ON"
        Else
            Relay2StatusBtn.BackColor = Color.Red
            Relay2StatusBtn.Text = "OFF"
        End If

        If Status3 = 1 Then
            Relay3StatusBtn.BackColor = Color.Lime
            Relay3StatusBtn.Text = "ON"
        Else
            Relay3StatusBtn.BackColor = Color.Red
            Relay3StatusBtn.Text = "OFF"
        End If

        If Status4 = 1 Then
            DewStrap1StatusBtn.BackColor = Color.Lime
            DewStrap1StatusBtn.Text = "DEW STRAP #1 ON"
            Relay4StatusBtn.BackColor = Color.Lime
            Relay4StatusBtn.Text = "ON"
        Else
            DewStrap1StatusBtn.BackColor = Color.Red
            DewStrap1StatusBtn.Text = "DEW STRAP #1 OFF"
            Relay4StatusBtn.BackColor = Color.Red
            Relay4StatusBtn.Text = "OFF"
        End If

        If Status5 = 1 Then
            DewStrap2StatusBtn.BackColor = Color.Lime
            DewStrap2StatusBtn.Text = "DEW STRAP #1 ON"
            Relay5StatusBtn.BackColor = Color.Lime
            Relay5StatusBtn.Text = "ON"
        Else
            DewStrap2StatusBtn.BackColor = Color.Red
            DewStrap2StatusBtn.Text = "DEW STRAP #1 OFF"
            Relay5StatusBtn.BackColor = Color.Red
            Relay5StatusBtn.Text = "OFF"
        End If

        If Status6 = 1 Then
            FansStatusBtn.BackColor = Color.Lime
            FansStatusBtn.Text = "FANS ON"
            Relay6StatusBtn.BackColor = Color.Lime
            Relay6StatusBtn.Text = "ON"
        Else
            FansStatusBtn.BackColor = Color.Red
            FansStatusBtn.Text = "FANS OFF"
            Relay6StatusBtn.BackColor = Color.Red
            Relay6StatusBtn.Text = "OFF"
        End If

        If Status7 = 1 Then
            CamFocStatusBtn.BackColor = Color.Lime
            CamFocStatusBtn.Text = "CAMERA FOCUSER ON"
            Button3.BackColor = Color.Lime
            Button3.Text = "ON"
        Else
            CamFocStatusBtn.BackColor = Color.Red
            CamFocStatusBtn.Text = "CAMERA FOCUSER OFF"
            Button3.BackColor = Color.Red
            Button3.Text = "OFF"
        End If

        If Status8 = 0 Then
            IRStatusBtn.BackColor = Color.Lime
            IRStatusBtn.Text = "IR ILLUM. ON"
            Relay8StatusBtn.BackColor = Color.Red
            Relay8StatusBtn.Text = "OFF"
        Else
            IRStatusBtn.BackColor = Color.Red
            IRStatusBtn.Text = "IR ILLUM. OFF"
            Relay8StatusBtn.BackColor = Color.Lime
            Relay8StatusBtn.Text = "ON"
        End If

        Exit Sub

ErrorHandler:

        If (TypeOf Err.GetException() Is TimeoutException) Then
            MsgBox("Relay Panel Timeout!" & vbCrLf)
        End If
        'NcdComponent1.SettingPort()
        'NcdComponent1.OpenPort(2000) 'Open serial port and set timeout to 2 seconds

        'Resume Next
        Exit Sub

    End Sub

    Private Sub UpdateStatusTimer_Tick(sender As Object, e As EventArgs) Handles UpdateStatusTimer.Tick

        UpdateRelayStatus()

    End Sub

    Private Sub ScopeToggleBtn_Click(sender As Object, e As EventArgs) Handles ScopeToggleBtn.Click
        'Toggle Scope Power
        UpdateRelayStatus() 'Get relay status

        If Status0 = 0 Then 'If relay is off, turn it on
            NcdComponent1.ProXR.RelayBanks.TurnOnRelayInBank(0, 1)
        Else 'If relay is on, turn it off
            NcdComponent1.ProXR.RelayBanks.TurnOffRelayInBank(0, 1)
        End If

        'Update status buttons
        UpdateRelayStatus()

    End Sub

    Private Sub CamFocToggleBtn_Click(sender As Object, e As EventArgs) Handles CamFocToggleBtn.Click
        'Toggle Camera and Focuser Power
        UpdateRelayStatus() 'Get relay status

        If Status7 = 0 Then 'If relay is off, turn it on
            NcdComponent1.ProXR.RelayBanks.TurnOnRelayInBank(7, 2)
        Else 'If relay is on, turn it off
            NcdComponent1.ProXR.RelayBanks.TurnOffRelayInBank(7, 2)
        End If

        'Update status buttons
        UpdateRelayStatus()
    End Sub


    Private Sub DewStrap1ToggleBtn_Click(sender As Object, e As EventArgs) Handles DewStrap1ToggleBtn.Click
        'Toggle Dew Strap #1 Power
        UpdateRelayStatus() 'Get relay status

        If Status4 = 0 Then 'If relay is off, turn it on
            NcdComponent1.ProXR.RelayBanks.TurnOnRelayInBank(4, 1)
        Else 'If relay is on, turn it off
            NcdComponent1.ProXR.RelayBanks.TurnOffRelayInBank(4, 1)
        End If

        'Update status buttons
        UpdateRelayStatus()
    End Sub


    Private Sub FansToggleBtn_Click(sender As Object, e As EventArgs) Handles FansToggleBtn.Click

        'Toggle scope fans Power
        UpdateRelayStatus() 'Get relay status

        If Status6 = 0 Then 'If relay is off, turn it on
            NcdComponent1.ProXR.RelayBanks.TurnOnRelayInBank(6, 1)

        Else 'If relay is on, turn it off
            NcdComponent1.ProXR.RelayBanks.TurnOffRelayInBank(6, 1)
            FanCountdownTimer.Enabled = False
            ClearFanTimer() 'Clear any existing fan timer
        End If

        'Update status buttons  
        UpdateRelayStatus()
    End Sub

    Sub ClearFanTimer()
        FanTimeRemainingTB.Text = "Timer Not Set"
        NcdComponent1.ProXR.Timers.SetDurationTimerImmediately(0, 0, 0, 0, 6)
        FanCountdownTimer.Enabled = False
    End Sub

    Private Sub DewStrap2ToggleBtn_Click(sender As Object, e As EventArgs) Handles DewStrap2ToggleBtn.Click

        'Toggle Dew Strap #2 Power
        UpdateRelayStatus() 'Get relay status

        If Status5 = 0 Then 'If relay is off, turn it on
            NcdComponent1.ProXR.RelayBanks.TurnOnRelayInBank(5, 1)
        Else 'If relay is on, turn it off
            NcdComponent1.ProXR.RelayBanks.TurnOffRelayInBank(5, 1)
        End If

        'Update status buttons
        UpdateRelayStatus()
    End Sub

    Sub RoofRelaysOff()
        UpdateRelayStatus()
        'Check roof relays to make sure none of them are on when program loads. If any are on, turn them off

        If Status1 = 1 Or Status2 = 1 Or Status3 = 1 Then
            If Status1 = 1 Then
                NcdComponent1.ProXR.RelayBanks.TurnOffRelayInBank(1, 1)
            End If
            If Status2 = 1 Then
                NcdComponent1.ProXR.RelayBanks.TurnOffRelayInBank(2, 1)
            End If
            If Status3 = 1 Then
                NcdComponent1.ProXR.RelayBanks.TurnOffRelayInBank(3, 1)
            End If
        End If

    End Sub

    Sub RoofStatus()
        'Get position of the roof and configure roof control
        ADCStatus1 = NcdComponent1.ProXR.AD8.Read10BitsValue(0) ' Get state of roof closed ADC
        ADCStatus2 = NcdComponent1.ProXR.AD8.Read10BitsValue(2) ' Get state of roof open ADC

        If ADCStatus1 < 500 Then 'ADC #0 to ground is open indicating roof is closed
            RoofStatusBtn.BackColor = Color.Red
            RoofStatusBtn.Text = "CLOSED"
            RoofCloseBtn.Enabled = False
            RoofOpenBtn.Enabled = True
        ElseIf ADCStatus2 < 500 Then 'ADC #1 to ground is open indicating roof is open
            RoofStatusBtn.BackColor = Color.Lime
            RoofStatusBtn.Text = "OPEN"
            RoofCloseBtn.Enabled = True
            RoofOpenBtn.Enabled = False
        Else
            MessageBox.Show("Roof Appears To Be Partially Open!") 'If ADCs are not configured properly for either position, show warning and disable buttons
            RoofCloseBtn.Enabled = False
            RoofOpenBtn.Enabled = False
            RoofStatusBtn.BackColor = Color.White
            RoofStatusBtn.Text = "UNKNOWN"
        End If

    End Sub

    Private Sub RoofOpenBtn_Click(sender As Object, e As EventArgs) Handles RoofOpenBtn.Click

        Dim ADCStatusOpen As Integer 'Status of ADC #1 - if the ADC value is close to zero, the roof is open
        Dim StatusForm As New Form2 'Pop-up form indication closing or opening action
        Dim RoofMsgResult As DialogResult = MessageBox.Show("You are about to move the roof! Proceed?", "Warning!", MessageBoxButtons.YesNo) 'Warning box

        If RoofMsgResult = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        ADCStatusOpen = NcdComponent1.ProXR.AD8.Read10BitsValue(2) 'Read ADC status

        'Begin roof opening sequence

        StatusForm.Show()
        StatusForm.Label1.Text = "Opening Roof. Please Wait."
        NcdComponent1.ProXR.RelayBanks.TurnOnRelayInBank(3, 1) 'Turn on relay to power motor to open roof
        RoofStatusBtn.BackColor = Color.Yellow
        RoofStatusBtn.Text = "MOVING"

        RoofTimer.Enabled = True
        RoofTimer.Start()

        Do While ADCStatusOpen > 500 And Abort < 59  'Start loop checking to see if the ADC status changes indicating roof is now open
            Application.DoEvents() 'Allow other threads to work while checking roof position
            ADCStatusOpen = NcdComponent1.ProXR.AD8.Read10BitsValue(2) 'Read ADC status
        Loop
        NcdComponent1.ProXR.RelayBanks.TurnOffRelayInBank(3, 1) 'Turn roof opening relay off once roof is open.

        If ADCStatusOpen < 500 Then
            RoofStatusBtn.BackColor = Color.Lime 'When loop exits, change status of panel indicators
            StatusForm.Hide() 'Close roof motion status form
            MessageBox.Show("Roof Successfully Opened.")
            RoofStatus() 'Call roof status sub to set controls to indicate open
        ElseIf Abort >= 59 Then 'Roof opening timed out. Something went terribly wrong. Abort closing and turn off relays
            MessageBox.Show("Roof Opening Timed Out. Aborting...")
            'RoofCloseBtn.Enabled = False
            'RoofOpenBtn.Enabled = False
            'RoofStatusBtn.BackColor = Color.White
            'RoofStatusBtn.Text = "UNKNOWN"
            RoofStatus() 'Call roof status sub to set controls to indicate open
            StatusForm.Hide()
            Abort = 0
            Exit Sub
        End If

        RoofTimer.Enabled = False 'Turn off roof timer
        Abort = 0 'Reset Abort

    End Sub

    Private Sub RoofTimer_Tick(sender As Object, e As EventArgs) Handles RoofTimer.Tick
        Abort = Abort + 1
    End Sub

    Private Sub TestBtn_Click(sender As Object, e As EventArgs)
        Dim StatusForm As New Form2 'Pop-up form indication closing or opening action
        StatusForm.Show()
        StatusForm.Label1.Text = "Opening Roof. Please Wait."
    End Sub

    Private Sub RoofCloseBtn_Click(sender As Object, e As EventArgs) Handles RoofCloseBtn.Click
        Dim ADCStatusClosed As Integer 'Status of ADC #1 - if the ADC value is close to zero, the roof is open
        Dim StatusForm As New Form2 'Pop-up form indication closing or opening action
        Dim RoofMsgResult As DialogResult = MessageBox.Show("You are about to move the roof! Proceed?", "Warning!", MessageBoxButtons.YesNo) 'Warning box

        If RoofMsgResult = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        ADCStatusClosed = NcdComponent1.ProXR.AD8.Read10BitsValue(0) 'Read ADC status

        'Begin roof closing sequence

        StatusForm.Show()
        StatusForm.Label1.Text = "Closing Roof. Please Wait."
        NcdComponent1.ProXR.RelayBanks.TurnOnRelayInBank(2, 1) 'Turn on relay to switch motor direction
        Threading.Thread.Sleep(500) 'Wait half a second before starting motor relay
        NcdComponent1.ProXR.RelayBanks.TurnOnRelayInBank(1, 1) 'Turn on relay start motor
        RoofStatusBtn.BackColor = Color.Yellow
        RoofStatusBtn.Text = "MOVING"

        RoofTimer.Enabled = True
        RoofTimer.Start()

        Do While ADCStatusClosed > 500 And Abort < 59  'Start loop checking to see if the ADC status changes indicating roof is now open
            Application.DoEvents() 'Allow other threads to work while checking roof position
            ADCStatusClosed = NcdComponent1.ProXR.AD8.Read10BitsValue(0) 'Read ADC status
        Loop
        NcdComponent1.ProXR.RelayBanks.TurnOffRelayInBank(2, 1) 'Turn roof closing relays off once roof is open.
        NcdComponent1.ProXR.RelayBanks.TurnOffRelayInBank(1, 1)

        If ADCStatusClosed < 500 Then
            RoofStatusBtn.BackColor = Color.Lime 'When loop exits, change status of panel indicators
            StatusForm.Hide() 'Close roof motion status form
            MessageBox.Show("Roof Successfully Closed.")
            RoofStatus() 'Call roof status sub to set controls to indicate open
        ElseIf Abort >= 59 Then 'Roof opening timed out. Something went terribly wrong. Abort closing and turn off relays
            MessageBox.Show("Roof Closing Timed Out. Aborting...")
            'RoofCloseBtn.Enabled = False
            'RoofOpenBtn.Enabled = False
            'RoofStatusBtn.BackColor = Color.White
            'RoofStatusBtn.Text = "UNKNOWN"
            RoofStatus() 'Call roof status sub to set controls to indicate open
            StatusForm.Hide()
            Abort = 0
            Exit Sub
        End If

        RoofTimer.Enabled = False 'Turn off roof timer
        Abort = 0 'Reset Abort

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FanTimerCmboBox.SelectedIndexChanged 'Set fans timer based on selected index

        'Indexes are :
        '   0 = 30 minutes
        '   1 = 1 hour
        '   2 = 2 hours
        '   3 = 3 hours
        '   4 = 4 hours
        '   5 = No timer

        Select Case FanTimerCmboBox.SelectedIndex

            Case 0 '30 minute timer selected
                NcdComponent1.ProXR.RelayBanks.SelectBank(1)
                NcdComponent1.ProXR.Timers.SetDurationTimerImmediately(0, 0, 30, 0, 6)
            Case 1 'One hour timer selected
                NcdComponent1.ProXR.RelayBanks.SelectBank(1)
                NcdComponent1.ProXR.Timers.SetDurationTimerImmediately(0, 1, 0, 0, 6)
            Case 2 'Two hour timer seleccted
                NcdComponent1.ProXR.RelayBanks.SelectBank(1)
                NcdComponent1.ProXR.Timers.SetDurationTimerImmediately(0, 2, 0, 0, 6)
            Case 3 'Three hour timer seleted
                NcdComponent1.ProXR.RelayBanks.SelectBank(1)
                NcdComponent1.ProXR.Timers.SetDurationTimerImmediately(0, 3, 0, 0, 6)
            Case 4 'four hour timer selected
                NcdComponent1.ProXR.RelayBanks.SelectBank(1)
                NcdComponent1.ProXR.Timers.SetDurationTimerImmediately(0, 4, 0, 0, 6)
            Case 5 'No timer selected
                ClearFanTimer()
                Exit Sub
        End Select
        'Start fan countdown timer
        FanCountdownTimer.Enabled = True
    End Sub

    Private Sub FanCountdownTimer_Tick(sender As Object, e As EventArgs) Handles FanCountdownTimer.Tick
        Dim TimeRemaining As NCD.TimerParameters = NcdComponent1.ProXR.Timers.TimerQuery(0)
        Dim ShowTimeRemaining As String

        ShowTimeRemaining = String.Format("{0}:{1}:{2}", TimeRemaining.hours, TimeRemaining.minutes, TimeRemaining.seconds)

        FanTimeRemainingTB.Text = ShowTimeRemaining
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles IRToggleBtn.Click
        'Toggle IR Illuminator
        UpdateRelayStatus() 'Get relay status

        If Status8 = 0 Then 'If relay is off, turn it on
            NcdComponent1.ProXR.RelayBanks.TurnOnRelayInBank(0, 2)
        Else 'If relay is on, turn it off
            NcdComponent1.ProXR.RelayBanks.TurnOffRelayInBank(0, 2)
        End If

        'Update status buttons
        UpdateRelayStatus()
    End Sub

    Private Sub EStop_Btn_Click(sender As Object, e As EventArgs) Handles EStop_Btn.Click

        NcdComponent1.ProXR.RelayBanks.TurnOffRelayInBank(2, 1) 'Turn off all roof motion relays
        NcdComponent1.ProXR.RelayBanks.TurnOffRelayInBank(1, 1)
        NcdComponent1.ProXR.RelayBanks.TurnOffRelayInBank(3, 1)

        MessageBox.Show("Roof Motion Emergency Stop!") 'If ADCs are not configured properly for either position, show warning and disable buttons

    End Sub

End Class
