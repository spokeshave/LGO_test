<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LGOMain
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
        Me.NcdComponent1 = New NCD.NCDComponent(Me.components)
        Me.RadarPictureBox = New System.Windows.Forms.PictureBox()
        Me.LGOPictureTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RadarPictureTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ScopeGroup = New System.Windows.Forms.GroupBox()
        Me.ScopeStatusBtn = New System.Windows.Forms.Button()
        Me.ScopeToggleBtn = New System.Windows.Forms.Button()
        Me.CamFocuserGroup = New System.Windows.Forms.GroupBox()
        Me.CamFocStatusBtn = New System.Windows.Forms.Button()
        Me.CamFocToggleBtn = New System.Windows.Forms.Button()
        Me.DewStrapsGroup = New System.Windows.Forms.GroupBox()
        Me.DewStrap2StatusBtn = New System.Windows.Forms.Button()
        Me.DewStrap2ToggleBtn = New System.Windows.Forms.Button()
        Me.DewStrap1StatusBtn = New System.Windows.Forms.Button()
        Me.DewStrap1ToggleBtn = New System.Windows.Forms.Button()
        Me.FansGroup = New System.Windows.Forms.GroupBox()
        Me.FansStatusBtn = New System.Windows.Forms.Button()
        Me.FansToggleBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EStop_Btn = New System.Windows.Forms.Button()
        Me.RoofCloseBtn = New System.Windows.Forms.Button()
        Me.RoofOpenBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RoofStatusBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Relay8StatusBtn = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Relay6StatusBtn = New System.Windows.Forms.Button()
        Me.Relay5StatusBtn = New System.Windows.Forms.Button()
        Me.Relay7StatusBtn = New System.Windows.Forms.Button()
        Me.Relay4StatusBtn = New System.Windows.Forms.Button()
        Me.Relay0StatusBtn = New System.Windows.Forms.Button()
        Me.Relay3StatusBtn = New System.Windows.Forms.Button()
        Me.Relay2StatusBtn = New System.Windows.Forms.Button()
        Me.Relay1StatusBtn = New System.Windows.Forms.Button()
        Me.UpdateStatusTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RoofTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LGOPictureBox = New System.Windows.Forms.PictureBox()
        Me.CameraExposureTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FanTimerCmboBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FanTimeRemainingTB = New System.Windows.Forms.TextBox()
        Me.FanCountdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.IRStatusBtn = New System.Windows.Forms.Button()
        Me.IRToggleBtn = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        CType(Me.RadarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ScopeGroup.SuspendLayout()
        Me.CamFocuserGroup.SuspendLayout()
        Me.DewStrapsGroup.SuspendLayout()
        Me.FansGroup.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.LGOPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'NcdComponent1
        '
        Me.NcdComponent1.BaudRate = 115200
        Me.NcdComponent1.IPAddress = "192.168.0.104"
        Me.NcdComponent1.IsTwoWay = True
        Me.NcdComponent1.Port = 2101
        Me.NcdComponent1.PortName = "COM3"
        Me.NcdComponent1.ReadTimeOut = 100
        Me.NcdComponent1.UsingComPort = True
        '
        'RadarPictureBox
        '
        Me.RadarPictureBox.Location = New System.Drawing.Point(621, 324)
        Me.RadarPictureBox.Name = "RadarPictureBox"
        Me.RadarPictureBox.Size = New System.Drawing.Size(540, 320)
        Me.RadarPictureBox.TabIndex = 1
        Me.RadarPictureBox.TabStop = False
        '
        'LGOPictureTimer
        '
        Me.LGOPictureTimer.Enabled = True
        Me.LGOPictureTimer.Interval = 1000
        '
        'RadarPictureTimer
        '
        Me.RadarPictureTimer.Enabled = True
        Me.RadarPictureTimer.Interval = 150000
        '
        'ScopeGroup
        '
        Me.ScopeGroup.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ScopeGroup.Controls.Add(Me.ScopeStatusBtn)
        Me.ScopeGroup.Controls.Add(Me.ScopeToggleBtn)
        Me.ScopeGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScopeGroup.Location = New System.Drawing.Point(40, 204)
        Me.ScopeGroup.Name = "ScopeGroup"
        Me.ScopeGroup.Size = New System.Drawing.Size(200, 84)
        Me.ScopeGroup.TabIndex = 6
        Me.ScopeGroup.TabStop = False
        Me.ScopeGroup.Text = "Telescope Power"
        '
        'ScopeStatusBtn
        '
        Me.ScopeStatusBtn.BackColor = System.Drawing.Color.Red
        Me.ScopeStatusBtn.Enabled = False
        Me.ScopeStatusBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScopeStatusBtn.Location = New System.Drawing.Point(113, 21)
        Me.ScopeStatusBtn.Name = "ScopeStatusBtn"
        Me.ScopeStatusBtn.Size = New System.Drawing.Size(75, 50)
        Me.ScopeStatusBtn.TabIndex = 7
        Me.ScopeStatusBtn.Text = "SCOPE OFF"
        Me.ScopeStatusBtn.UseVisualStyleBackColor = False
        '
        'ScopeToggleBtn
        '
        Me.ScopeToggleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScopeToggleBtn.Location = New System.Drawing.Point(13, 22)
        Me.ScopeToggleBtn.Name = "ScopeToggleBtn"
        Me.ScopeToggleBtn.Size = New System.Drawing.Size(91, 49)
        Me.ScopeToggleBtn.TabIndex = 0
        Me.ScopeToggleBtn.Text = "Power On/Off"
        Me.ScopeToggleBtn.UseVisualStyleBackColor = True
        '
        'CamFocuserGroup
        '
        Me.CamFocuserGroup.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CamFocuserGroup.Controls.Add(Me.CamFocStatusBtn)
        Me.CamFocuserGroup.Controls.Add(Me.CamFocToggleBtn)
        Me.CamFocuserGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CamFocuserGroup.Location = New System.Drawing.Point(279, 204)
        Me.CamFocuserGroup.Name = "CamFocuserGroup"
        Me.CamFocuserGroup.Size = New System.Drawing.Size(200, 84)
        Me.CamFocuserGroup.TabIndex = 7
        Me.CamFocuserGroup.TabStop = False
        Me.CamFocuserGroup.Text = "AUX 12V"
        '
        'CamFocStatusBtn
        '
        Me.CamFocStatusBtn.BackColor = System.Drawing.Color.Red
        Me.CamFocStatusBtn.Enabled = False
        Me.CamFocStatusBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CamFocStatusBtn.Location = New System.Drawing.Point(113, 21)
        Me.CamFocStatusBtn.Name = "CamFocStatusBtn"
        Me.CamFocStatusBtn.Size = New System.Drawing.Size(75, 50)
        Me.CamFocStatusBtn.TabIndex = 7
        Me.CamFocStatusBtn.Text = "AUX 12V OFF"
        Me.CamFocStatusBtn.UseVisualStyleBackColor = False
        '
        'CamFocToggleBtn
        '
        Me.CamFocToggleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CamFocToggleBtn.Location = New System.Drawing.Point(13, 22)
        Me.CamFocToggleBtn.Name = "CamFocToggleBtn"
        Me.CamFocToggleBtn.Size = New System.Drawing.Size(91, 49)
        Me.CamFocToggleBtn.TabIndex = 0
        Me.CamFocToggleBtn.Text = "Power On/Off"
        Me.CamFocToggleBtn.UseVisualStyleBackColor = True
        '
        'DewStrapsGroup
        '
        Me.DewStrapsGroup.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DewStrapsGroup.Controls.Add(Me.DewStrap2StatusBtn)
        Me.DewStrapsGroup.Controls.Add(Me.DewStrap2ToggleBtn)
        Me.DewStrapsGroup.Controls.Add(Me.DewStrap1StatusBtn)
        Me.DewStrapsGroup.Controls.Add(Me.DewStrap1ToggleBtn)
        Me.DewStrapsGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DewStrapsGroup.Location = New System.Drawing.Point(518, 204)
        Me.DewStrapsGroup.Name = "DewStrapsGroup"
        Me.DewStrapsGroup.Size = New System.Drawing.Size(402, 84)
        Me.DewStrapsGroup.TabIndex = 8
        Me.DewStrapsGroup.TabStop = False
        Me.DewStrapsGroup.Text = "Dew Straps"
        '
        'DewStrap2StatusBtn
        '
        Me.DewStrap2StatusBtn.BackColor = System.Drawing.Color.Red
        Me.DewStrap2StatusBtn.Enabled = False
        Me.DewStrap2StatusBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DewStrap2StatusBtn.Location = New System.Drawing.Point(313, 21)
        Me.DewStrap2StatusBtn.Name = "DewStrap2StatusBtn"
        Me.DewStrap2StatusBtn.Size = New System.Drawing.Size(75, 50)
        Me.DewStrap2StatusBtn.TabIndex = 9
        Me.DewStrap2StatusBtn.Text = "DEW STRAP #2 OFF"
        Me.DewStrap2StatusBtn.UseVisualStyleBackColor = False
        '
        'DewStrap2ToggleBtn
        '
        Me.DewStrap2ToggleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DewStrap2ToggleBtn.Location = New System.Drawing.Point(213, 22)
        Me.DewStrap2ToggleBtn.Name = "DewStrap2ToggleBtn"
        Me.DewStrap2ToggleBtn.Size = New System.Drawing.Size(91, 49)
        Me.DewStrap2ToggleBtn.TabIndex = 8
        Me.DewStrap2ToggleBtn.Text = "Power On/Off"
        Me.DewStrap2ToggleBtn.UseVisualStyleBackColor = True
        '
        'DewStrap1StatusBtn
        '
        Me.DewStrap1StatusBtn.BackColor = System.Drawing.Color.Red
        Me.DewStrap1StatusBtn.Enabled = False
        Me.DewStrap1StatusBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DewStrap1StatusBtn.Location = New System.Drawing.Point(113, 21)
        Me.DewStrap1StatusBtn.Name = "DewStrap1StatusBtn"
        Me.DewStrap1StatusBtn.Size = New System.Drawing.Size(75, 50)
        Me.DewStrap1StatusBtn.TabIndex = 7
        Me.DewStrap1StatusBtn.Text = "DEW STRAP #1 OFF"
        Me.DewStrap1StatusBtn.UseVisualStyleBackColor = False
        '
        'DewStrap1ToggleBtn
        '
        Me.DewStrap1ToggleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DewStrap1ToggleBtn.Location = New System.Drawing.Point(13, 22)
        Me.DewStrap1ToggleBtn.Name = "DewStrap1ToggleBtn"
        Me.DewStrap1ToggleBtn.Size = New System.Drawing.Size(91, 49)
        Me.DewStrap1ToggleBtn.TabIndex = 0
        Me.DewStrap1ToggleBtn.Text = "Power On/Off"
        Me.DewStrap1ToggleBtn.UseVisualStyleBackColor = True
        '
        'FansGroup
        '
        Me.FansGroup.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FansGroup.Controls.Add(Me.FansStatusBtn)
        Me.FansGroup.Controls.Add(Me.FansToggleBtn)
        Me.FansGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FansGroup.Location = New System.Drawing.Point(959, 204)
        Me.FansGroup.Name = "FansGroup"
        Me.FansGroup.Size = New System.Drawing.Size(200, 84)
        Me.FansGroup.TabIndex = 9
        Me.FansGroup.TabStop = False
        Me.FansGroup.Text = "Telescope Fans"
        '
        'FansStatusBtn
        '
        Me.FansStatusBtn.BackColor = System.Drawing.Color.Red
        Me.FansStatusBtn.Enabled = False
        Me.FansStatusBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FansStatusBtn.Location = New System.Drawing.Point(113, 21)
        Me.FansStatusBtn.Name = "FansStatusBtn"
        Me.FansStatusBtn.Size = New System.Drawing.Size(75, 50)
        Me.FansStatusBtn.TabIndex = 7
        Me.FansStatusBtn.Text = "FANS OFF"
        Me.FansStatusBtn.UseVisualStyleBackColor = False
        '
        'FansToggleBtn
        '
        Me.FansToggleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FansToggleBtn.Location = New System.Drawing.Point(13, 22)
        Me.FansToggleBtn.Name = "FansToggleBtn"
        Me.FansToggleBtn.Size = New System.Drawing.Size(91, 49)
        Me.FansToggleBtn.TabIndex = 0
        Me.FansToggleBtn.Text = "Power On/Off"
        Me.FansToggleBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.EStop_Btn)
        Me.GroupBox1.Controls.Add(Me.RoofCloseBtn)
        Me.GroupBox1.Controls.Add(Me.RoofOpenBtn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RoofStatusBtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 171)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Roof Control"
        '
        'EStop_Btn
        '
        Me.EStop_Btn.BackColor = System.Drawing.Color.Red
        Me.EStop_Btn.Enabled = False
        Me.EStop_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EStop_Btn.Location = New System.Drawing.Point(212, 100)
        Me.EStop_Btn.Name = "EStop_Btn"
        Me.EStop_Btn.Size = New System.Drawing.Size(75, 51)
        Me.EStop_Btn.TabIndex = 13
        Me.EStop_Btn.Text = "STOP"
        Me.EStop_Btn.UseVisualStyleBackColor = False
        '
        'RoofCloseBtn
        '
        Me.RoofCloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoofCloseBtn.Location = New System.Drawing.Point(113, 19)
        Me.RoofCloseBtn.Name = "RoofCloseBtn"
        Me.RoofCloseBtn.Size = New System.Drawing.Size(75, 51)
        Me.RoofCloseBtn.TabIndex = 12
        Me.RoofCloseBtn.Text = "CLOSE ROOF"
        Me.RoofCloseBtn.UseVisualStyleBackColor = True
        '
        'RoofOpenBtn
        '
        Me.RoofOpenBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoofOpenBtn.Location = New System.Drawing.Point(13, 19)
        Me.RoofOpenBtn.Name = "RoofOpenBtn"
        Me.RoofOpenBtn.Size = New System.Drawing.Size(75, 51)
        Me.RoofOpenBtn.TabIndex = 11
        Me.RoofOpenBtn.Text = "OPEN ROOF"
        Me.RoofOpenBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Automatic Roof Movement"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Roof Status"
        '
        'RoofStatusBtn
        '
        Me.RoofStatusBtn.BackColor = System.Drawing.Color.Red
        Me.RoofStatusBtn.Enabled = False
        Me.RoofStatusBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoofStatusBtn.Location = New System.Drawing.Point(212, 19)
        Me.RoofStatusBtn.Name = "RoofStatusBtn"
        Me.RoofStatusBtn.Size = New System.Drawing.Size(75, 51)
        Me.RoofStatusBtn.TabIndex = 8
        Me.RoofStatusBtn.Text = "ROOF CLOSED"
        Me.RoofStatusBtn.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Relay8StatusBtn)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Relay6StatusBtn)
        Me.GroupBox2.Controls.Add(Me.Relay5StatusBtn)
        Me.GroupBox2.Controls.Add(Me.Relay7StatusBtn)
        Me.GroupBox2.Controls.Add(Me.Relay4StatusBtn)
        Me.GroupBox2.Controls.Add(Me.Relay0StatusBtn)
        Me.GroupBox2.Controls.Add(Me.Relay3StatusBtn)
        Me.GroupBox2.Controls.Add(Me.Relay2StatusBtn)
        Me.GroupBox2.Controls.Add(Me.Relay1StatusBtn)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(361, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(514, 168)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Relay Status"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(447, 116)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Relay 7"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(394, 116)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 13)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Relay 6"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(341, 115)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Relay 5"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(288, 116)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 13)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "Relay 4"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(237, 116)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 13)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "Relay 3"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(182, 116)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Relay 2"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(129, 116)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 13)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = "Relay 1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Location = New System.Drawing.Point(396, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 25)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "NIU"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Location = New System.Drawing.Point(343, 87)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 25)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "NIU"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(449, 87)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 25)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "OFF"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button4.Location = New System.Drawing.Point(290, 87)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 25)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "NIU"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button5.Location = New System.Drawing.Point(237, 88)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 25)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "NIU"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button6.Location = New System.Drawing.Point(184, 88)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(40, 25)
        Me.Button6.TabIndex = 25
        Me.Button6.Text = "NIU"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button7.Location = New System.Drawing.Point(131, 88)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(40, 25)
        Me.Button7.TabIndex = 24
        Me.Button7.Text = "NIU"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(78, 116)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Relay 0"
        '
        'Relay8StatusBtn
        '
        Me.Relay8StatusBtn.BackColor = System.Drawing.Color.Red
        Me.Relay8StatusBtn.Location = New System.Drawing.Point(78, 88)
        Me.Relay8StatusBtn.Name = "Relay8StatusBtn"
        Me.Relay8StatusBtn.Size = New System.Drawing.Size(40, 25)
        Me.Relay8StatusBtn.TabIndex = 22
        Me.Relay8StatusBtn.Text = "OFF"
        Me.Relay8StatusBtn.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Bank 2"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Bank 1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(447, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Relay 7"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(394, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Relay 6"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(341, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Relay 5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(288, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Relay 4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(237, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Relay 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Relay 0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(182, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Relay 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(129, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Relay 1"
        '
        'Relay6StatusBtn
        '
        Me.Relay6StatusBtn.BackColor = System.Drawing.Color.Red
        Me.Relay6StatusBtn.Location = New System.Drawing.Point(396, 16)
        Me.Relay6StatusBtn.Name = "Relay6StatusBtn"
        Me.Relay6StatusBtn.Size = New System.Drawing.Size(40, 25)
        Me.Relay6StatusBtn.TabIndex = 7
        Me.Relay6StatusBtn.Text = "OFF"
        Me.Relay6StatusBtn.UseVisualStyleBackColor = False
        '
        'Relay5StatusBtn
        '
        Me.Relay5StatusBtn.BackColor = System.Drawing.Color.Red
        Me.Relay5StatusBtn.Location = New System.Drawing.Point(343, 15)
        Me.Relay5StatusBtn.Name = "Relay5StatusBtn"
        Me.Relay5StatusBtn.Size = New System.Drawing.Size(40, 25)
        Me.Relay5StatusBtn.TabIndex = 6
        Me.Relay5StatusBtn.Text = "OFF"
        Me.Relay5StatusBtn.UseVisualStyleBackColor = False
        '
        'Relay7StatusBtn
        '
        Me.Relay7StatusBtn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Relay7StatusBtn.Location = New System.Drawing.Point(449, 15)
        Me.Relay7StatusBtn.Name = "Relay7StatusBtn"
        Me.Relay7StatusBtn.Size = New System.Drawing.Size(40, 25)
        Me.Relay7StatusBtn.TabIndex = 5
        Me.Relay7StatusBtn.Text = "NIU"
        Me.Relay7StatusBtn.UseVisualStyleBackColor = False
        '
        'Relay4StatusBtn
        '
        Me.Relay4StatusBtn.BackColor = System.Drawing.Color.Red
        Me.Relay4StatusBtn.Location = New System.Drawing.Point(290, 15)
        Me.Relay4StatusBtn.Name = "Relay4StatusBtn"
        Me.Relay4StatusBtn.Size = New System.Drawing.Size(40, 25)
        Me.Relay4StatusBtn.TabIndex = 4
        Me.Relay4StatusBtn.Text = "OFF"
        Me.Relay4StatusBtn.UseVisualStyleBackColor = False
        '
        'Relay0StatusBtn
        '
        Me.Relay0StatusBtn.BackColor = System.Drawing.Color.Red
        Me.Relay0StatusBtn.Location = New System.Drawing.Point(78, 16)
        Me.Relay0StatusBtn.Name = "Relay0StatusBtn"
        Me.Relay0StatusBtn.Size = New System.Drawing.Size(40, 25)
        Me.Relay0StatusBtn.TabIndex = 3
        Me.Relay0StatusBtn.Text = "OFF"
        Me.Relay0StatusBtn.UseVisualStyleBackColor = False
        '
        'Relay3StatusBtn
        '
        Me.Relay3StatusBtn.BackColor = System.Drawing.Color.Red
        Me.Relay3StatusBtn.Location = New System.Drawing.Point(237, 16)
        Me.Relay3StatusBtn.Name = "Relay3StatusBtn"
        Me.Relay3StatusBtn.Size = New System.Drawing.Size(40, 25)
        Me.Relay3StatusBtn.TabIndex = 2
        Me.Relay3StatusBtn.Text = "OFF"
        Me.Relay3StatusBtn.UseVisualStyleBackColor = False
        '
        'Relay2StatusBtn
        '
        Me.Relay2StatusBtn.BackColor = System.Drawing.Color.Red
        Me.Relay2StatusBtn.Location = New System.Drawing.Point(184, 16)
        Me.Relay2StatusBtn.Name = "Relay2StatusBtn"
        Me.Relay2StatusBtn.Size = New System.Drawing.Size(40, 25)
        Me.Relay2StatusBtn.TabIndex = 1
        Me.Relay2StatusBtn.Text = "OFF"
        Me.Relay2StatusBtn.UseVisualStyleBackColor = False
        '
        'Relay1StatusBtn
        '
        Me.Relay1StatusBtn.BackColor = System.Drawing.Color.Red
        Me.Relay1StatusBtn.Location = New System.Drawing.Point(131, 16)
        Me.Relay1StatusBtn.Name = "Relay1StatusBtn"
        Me.Relay1StatusBtn.Size = New System.Drawing.Size(40, 25)
        Me.Relay1StatusBtn.TabIndex = 0
        Me.Relay1StatusBtn.Text = "OFF"
        Me.Relay1StatusBtn.UseVisualStyleBackColor = False
        '
        'UpdateStatusTimer
        '
        Me.UpdateStatusTimer.Interval = 1000
        '
        'RoofTimer
        '
        Me.RoofTimer.Interval = 1000
        '
        'LGOPictureBox
        '
        Me.LGOPictureBox.Location = New System.Drawing.Point(40, 324)
        Me.LGOPictureBox.Name = "LGOPictureBox"
        Me.LGOPictureBox.Size = New System.Drawing.Size(540, 320)
        Me.LGOPictureBox.TabIndex = 0
        Me.LGOPictureBox.TabStop = False
        '
        'CameraExposureTimer
        '
        Me.CameraExposureTimer.Interval = 1000
        '
        'FanTimerCmboBox
        '
        Me.FanTimerCmboBox.FormattingEnabled = True
        Me.FanTimerCmboBox.Items.AddRange(New Object() {"30 Minutes", "1 hour", "2 Hours", "3 Hours", "4 Hours", "No Timer"})
        Me.FanTimerCmboBox.Location = New System.Drawing.Point(1040, 15)
        Me.FanTimerCmboBox.MaxDropDownItems = 6
        Me.FanTimerCmboBox.Name = "FanTimerCmboBox"
        Me.FanTimerCmboBox.Size = New System.Drawing.Size(121, 21)
        Me.FanTimerCmboBox.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(958, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Set Fan Timer:"
        '
        'FanTimeRemainingTB
        '
        Me.FanTimeRemainingTB.Location = New System.Drawing.Point(1040, 43)
        Me.FanTimeRemainingTB.Name = "FanTimeRemainingTB"
        Me.FanTimeRemainingTB.Size = New System.Drawing.Size(121, 20)
        Me.FanTimeRemainingTB.TabIndex = 14
        '
        'FanCountdownTimer
        '
        Me.FanCountdownTimer.Interval = 1000
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(927, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Fan Time Remaining:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox3.Controls.Add(Me.IRStatusBtn)
        Me.GroupBox3.Controls.Add(Me.IRToggleBtn)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(959, 82)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 101)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "IR Illuminator"
        '
        'IRStatusBtn
        '
        Me.IRStatusBtn.BackColor = System.Drawing.Color.Lime
        Me.IRStatusBtn.Enabled = False
        Me.IRStatusBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IRStatusBtn.Location = New System.Drawing.Point(113, 21)
        Me.IRStatusBtn.Name = "IRStatusBtn"
        Me.IRStatusBtn.Size = New System.Drawing.Size(75, 50)
        Me.IRStatusBtn.TabIndex = 7
        Me.IRStatusBtn.Text = "IR ILLUM. ON"
        Me.IRStatusBtn.UseVisualStyleBackColor = False
        '
        'IRToggleBtn
        '
        Me.IRToggleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IRToggleBtn.Location = New System.Drawing.Point(13, 22)
        Me.IRToggleBtn.Name = "IRToggleBtn"
        Me.IRToggleBtn.Size = New System.Drawing.Size(91, 49)
        Me.IRToggleBtn.TabIndex = 0
        Me.IRToggleBtn.Text = "Power On/Off"
        Me.IRToggleBtn.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(209, 154)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(85, 13)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "Emergency Stop"
        '
        'LGOMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 673)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.FanTimeRemainingTB)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.FanTimerCmboBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FansGroup)
        Me.Controls.Add(Me.DewStrapsGroup)
        Me.Controls.Add(Me.CamFocuserGroup)
        Me.Controls.Add(Me.ScopeGroup)
        Me.Controls.Add(Me.RadarPictureBox)
        Me.Controls.Add(Me.LGOPictureBox)
        Me.Name = "LGOMain"
        Me.Text = "Looking Glass Observatory Control Panel"
        CType(Me.RadarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ScopeGroup.ResumeLayout(False)
        Me.CamFocuserGroup.ResumeLayout(False)
        Me.DewStrapsGroup.ResumeLayout(False)
        Me.FansGroup.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.LGOPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NcdComponent1 As NCD.NCDComponent
    Friend WithEvents RadarPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LGOPictureTimer As System.Windows.Forms.Timer
    Friend WithEvents RadarPictureTimer As System.Windows.Forms.Timer
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents ScopeGroup As System.Windows.Forms.GroupBox
    Friend WithEvents ScopeStatusBtn As System.Windows.Forms.Button
    Friend WithEvents ScopeToggleBtn As System.Windows.Forms.Button
    Friend WithEvents CamFocuserGroup As System.Windows.Forms.GroupBox
    Friend WithEvents CamFocStatusBtn As System.Windows.Forms.Button
    Friend WithEvents CamFocToggleBtn As System.Windows.Forms.Button
    Friend WithEvents DewStrapsGroup As System.Windows.Forms.GroupBox
    Friend WithEvents DewStrap2StatusBtn As System.Windows.Forms.Button
    Friend WithEvents DewStrap2ToggleBtn As System.Windows.Forms.Button
    Friend WithEvents DewStrap1StatusBtn As System.Windows.Forms.Button
    Friend WithEvents DewStrap1ToggleBtn As System.Windows.Forms.Button
    Friend WithEvents FansGroup As System.Windows.Forms.GroupBox
    Friend WithEvents FansStatusBtn As System.Windows.Forms.Button
    Friend WithEvents FansToggleBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RoofStatusBtn As System.Windows.Forms.Button
    Friend WithEvents RoofCloseBtn As System.Windows.Forms.Button
    Friend WithEvents RoofOpenBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Relay6StatusBtn As System.Windows.Forms.Button
    Friend WithEvents Relay5StatusBtn As System.Windows.Forms.Button
    Friend WithEvents Relay7StatusBtn As System.Windows.Forms.Button
    Friend WithEvents Relay4StatusBtn As System.Windows.Forms.Button
    Friend WithEvents Relay0StatusBtn As System.Windows.Forms.Button
    Friend WithEvents Relay3StatusBtn As System.Windows.Forms.Button
    Friend WithEvents Relay2StatusBtn As System.Windows.Forms.Button
    Friend WithEvents Relay1StatusBtn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UpdateStatusTimer As System.Windows.Forms.Timer
    Friend WithEvents RoofTimer As System.Windows.Forms.Timer
    Friend WithEvents LGOPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents CameraExposureTimer As System.Windows.Forms.Timer
    Friend WithEvents FanTimerCmboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents FanTimeRemainingTB As System.Windows.Forms.TextBox
    Friend WithEvents FanCountdownTimer As System.Windows.Forms.Timer
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents IRStatusBtn As System.Windows.Forms.Button
    Friend WithEvents IRToggleBtn As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Relay8StatusBtn As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents EStop_Btn As Button
    Friend WithEvents Label23 As Label
End Class
