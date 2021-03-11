<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpBasic = New System.Windows.Forms.TabPage()
        Me.gbInstrument = New System.Windows.Forms.GroupBox()
        Me.btnSetLocalHost = New System.Windows.Forms.Button()
        Me.cbRemote = New System.Windows.Forms.CheckBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbIPAddress = New System.Windows.Forms.TextBox()
        Me.grpField = New System.Windows.Forms.GroupBox()
        Me.btnGetField = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbFieldStatusRead = New System.Windows.Forms.TextBox()
        Me.tbFieldRead = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSetField = New System.Windows.Forms.Button()
        Me.cbEndMode = New System.Windows.Forms.ComboBox()
        Me.cbFieldApproach = New System.Windows.Forms.ComboBox()
        Me.tbFieldRateTarget = New System.Windows.Forms.TextBox()
        Me.tbFieldTarget = New System.Windows.Forms.TextBox()
        Me.grpTemperature = New System.Windows.Forms.GroupBox()
        Me.btnGetTemp = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbTempStatusRead = New System.Windows.Forms.TextBox()
        Me.tbTempRead = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSetTemp = New System.Windows.Forms.Button()
        Me.cbTempApproach = New System.Windows.Forms.ComboBox()
        Me.tbTempRateTarget = New System.Windows.Forms.TextBox()
        Me.tbTempTarget = New System.Windows.Forms.TextBox()
        Me.grpChamber = New System.Windows.Forms.GroupBox()
        Me.btnGetChamber = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbChamberStatus = New System.Windows.Forms.TextBox()
        Me.cbChamberSetCode = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnSetChamber = New System.Windows.Forms.Button()
        Me.tpPosition = New System.Windows.Forms.TabPage()
        Me.grpPosition = New System.Windows.Forms.GroupBox()
        Me.btnGetPosition = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbPositionStatus = New System.Windows.Forms.TextBox()
        Me.tbReadPosition = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnSetPosition = New System.Windows.Forms.Button()
        Me.cbPositionMode = New System.Windows.Forms.ComboBox()
        Me.tbSpeed = New System.Windows.Forms.TextBox()
        Me.tbSetPosition = New System.Windows.Forms.TextBox()
        Me.tpSDOAndPPMS = New System.Windows.Forms.TabPage()
        Me.gbSendPpmsCommand = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.tbErrorStr = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tbReply = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnSendCommand = New System.Windows.Forms.Button()
        Me.tbCommand = New System.Windows.Forms.TextBox()
        Me.grpSDO = New System.Windows.Forms.GroupBox()
        Me.tbReadSDO = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbSubindex = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbIndex = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbNode = New System.Windows.Forms.TextBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.btnReadSDO = New System.Windows.Forms.Button()
        Me.grpPPMSData = New System.Windows.Forms.GroupBox()
        Me.cbFast = New System.Windows.Forms.CheckBox()
        Me.tbPPMSData = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tbChannel = New System.Windows.Forms.TextBox()
        Me.btnReadPPMSData = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tpBasic.SuspendLayout()
        Me.gbInstrument.SuspendLayout()
        Me.grpField.SuspendLayout()
        Me.grpTemperature.SuspendLayout()
        Me.grpChamber.SuspendLayout()
        Me.tpPosition.SuspendLayout()
        Me.grpPosition.SuspendLayout()
        Me.tpSDOAndPPMS.SuspendLayout()
        Me.gbSendPpmsCommand.SuspendLayout()
        Me.grpSDO.SuspendLayout()
        Me.grpPPMSData.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpBasic)
        Me.TabControl1.Controls.Add(Me.tpPosition)
        Me.TabControl1.Controls.Add(Me.tpSDOAndPPMS)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(422, 538)
        Me.TabControl1.TabIndex = 21
        '
        'tpBasic
        '
        Me.tpBasic.Controls.Add(Me.gbInstrument)
        Me.tpBasic.Controls.Add(Me.grpField)
        Me.tpBasic.Controls.Add(Me.grpTemperature)
        Me.tpBasic.Controls.Add(Me.grpChamber)
        Me.tpBasic.Location = New System.Drawing.Point(4, 22)
        Me.tpBasic.Name = "tpBasic"
        Me.tpBasic.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBasic.Size = New System.Drawing.Size(414, 512)
        Me.tpBasic.TabIndex = 0
        Me.tpBasic.Text = "Basic"
        Me.tpBasic.UseVisualStyleBackColor = True
        '
        'gbInstrument
        '
        Me.gbInstrument.Controls.Add(Me.btnSetLocalHost)
        Me.gbInstrument.Controls.Add(Me.cbRemote)
        Me.gbInstrument.Controls.Add(Me.btnConnect)
        Me.gbInstrument.Controls.Add(Me.Label8)
        Me.gbInstrument.Controls.Add(Me.tbIPAddress)
        Me.gbInstrument.Location = New System.Drawing.Point(6, 6)
        Me.gbInstrument.Name = "gbInstrument"
        Me.gbInstrument.Size = New System.Drawing.Size(400, 100)
        Me.gbInstrument.TabIndex = 2
        Me.gbInstrument.TabStop = False
        Me.gbInstrument.Text = "Instrument"
        '
        'btnSetLocalHost
        '
        Me.btnSetLocalHost.Location = New System.Drawing.Point(288, 23)
        Me.btnSetLocalHost.Name = "btnSetLocalHost"
        Me.btnSetLocalHost.Size = New System.Drawing.Size(65, 23)
        Me.btnSetLocalHost.TabIndex = 19
        Me.btnSetLocalHost.Text = "localhost"
        Me.btnSetLocalHost.UseVisualStyleBackColor = True
        '
        'cbRemote
        '
        Me.cbRemote.AutoSize = True
        Me.cbRemote.Location = New System.Drawing.Point(26, 28)
        Me.cbRemote.Name = "cbRemote"
        Me.cbRemote.Size = New System.Drawing.Size(63, 17)
        Me.cbRemote.TabIndex = 16
        Me.cbRemote.Text = "Remote"
        Me.cbRemote.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(26, 62)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 14
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(103, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "IP Address:"
        '
        'tbIPAddress
        '
        Me.tbIPAddress.Enabled = False
        Me.tbIPAddress.Location = New System.Drawing.Point(170, 25)
        Me.tbIPAddress.Name = "tbIPAddress"
        Me.tbIPAddress.Size = New System.Drawing.Size(112, 20)
        Me.tbIPAddress.TabIndex = 14
        Me.tbIPAddress.Text = "127.0.0.1"
        '
        'grpField
        '
        Me.grpField.Controls.Add(Me.btnGetField)
        Me.grpField.Controls.Add(Me.Label5)
        Me.grpField.Controls.Add(Me.Label6)
        Me.grpField.Controls.Add(Me.tbFieldStatusRead)
        Me.grpField.Controls.Add(Me.tbFieldRead)
        Me.grpField.Controls.Add(Me.Label4)
        Me.grpField.Controls.Add(Me.Label3)
        Me.grpField.Controls.Add(Me.Label2)
        Me.grpField.Controls.Add(Me.Label1)
        Me.grpField.Controls.Add(Me.btnSetField)
        Me.grpField.Controls.Add(Me.cbEndMode)
        Me.grpField.Controls.Add(Me.cbFieldApproach)
        Me.grpField.Controls.Add(Me.tbFieldRateTarget)
        Me.grpField.Controls.Add(Me.tbFieldTarget)
        Me.grpField.Location = New System.Drawing.Point(6, 249)
        Me.grpField.Name = "grpField"
        Me.grpField.Size = New System.Drawing.Size(400, 162)
        Me.grpField.TabIndex = 1
        Me.grpField.TabStop = False
        Me.grpField.Text = "Field"
        '
        'btnGetField
        '
        Me.btnGetField.Location = New System.Drawing.Point(273, 71)
        Me.btnGetField.Name = "btnGetField"
        Me.btnGetField.Size = New System.Drawing.Size(75, 23)
        Me.btnGetField.TabIndex = 13
        Me.btnGetField.Text = "Get Field"
        Me.btnGetField.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Status (Code)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(240, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Field (Oe)"
        '
        'tbFieldStatusRead
        '
        Me.tbFieldStatusRead.Location = New System.Drawing.Point(298, 45)
        Me.tbFieldStatusRead.Name = "tbFieldStatusRead"
        Me.tbFieldStatusRead.ReadOnly = True
        Me.tbFieldStatusRead.Size = New System.Drawing.Size(82, 20)
        Me.tbFieldStatusRead.TabIndex = 10
        '
        'tbFieldRead
        '
        Me.tbFieldRead.Location = New System.Drawing.Point(298, 19)
        Me.tbFieldRead.Name = "tbFieldRead"
        Me.tbFieldRead.ReadOnly = True
        Me.tbFieldRead.Size = New System.Drawing.Size(82, 20)
        Me.tbFieldRead.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "End Mode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Approach Mode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Rate (Oe/sec)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Set Field (Oe)"
        '
        'btnSetField
        '
        Me.btnSetField.Location = New System.Drawing.Point(59, 125)
        Me.btnSetField.Name = "btnSetField"
        Me.btnSetField.Size = New System.Drawing.Size(75, 23)
        Me.btnSetField.TabIndex = 2
        Me.btnSetField.Text = "Set Field"
        Me.btnSetField.UseVisualStyleBackColor = True
        '
        'cbEndMode
        '
        Me.cbEndMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEndMode.FormattingEnabled = True
        Me.cbEndMode.Items.AddRange(New Object() {"Persistent", "Driven"})
        Me.cbEndMode.Location = New System.Drawing.Point(95, 98)
        Me.cbEndMode.Name = "cbEndMode"
        Me.cbEndMode.Size = New System.Drawing.Size(93, 21)
        Me.cbEndMode.TabIndex = 5
        '
        'cbFieldApproach
        '
        Me.cbFieldApproach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFieldApproach.FormattingEnabled = True
        Me.cbFieldApproach.Items.AddRange(New Object() {"Linear", "No Overshoot", "Oscillate"})
        Me.cbFieldApproach.Location = New System.Drawing.Point(95, 71)
        Me.cbFieldApproach.Name = "cbFieldApproach"
        Me.cbFieldApproach.Size = New System.Drawing.Size(93, 21)
        Me.cbFieldApproach.TabIndex = 4
        '
        'tbFieldRateTarget
        '
        Me.tbFieldRateTarget.Location = New System.Drawing.Point(95, 45)
        Me.tbFieldRateTarget.Name = "tbFieldRateTarget"
        Me.tbFieldRateTarget.Size = New System.Drawing.Size(93, 20)
        Me.tbFieldRateTarget.TabIndex = 3
        Me.tbFieldRateTarget.Text = "100.0"
        '
        'tbFieldTarget
        '
        Me.tbFieldTarget.Location = New System.Drawing.Point(95, 19)
        Me.tbFieldTarget.Name = "tbFieldTarget"
        Me.tbFieldTarget.Size = New System.Drawing.Size(93, 20)
        Me.tbFieldTarget.TabIndex = 2
        Me.tbFieldTarget.Text = "1000.0"
        '
        'grpTemperature
        '
        Me.grpTemperature.Controls.Add(Me.btnGetTemp)
        Me.grpTemperature.Controls.Add(Me.Label9)
        Me.grpTemperature.Controls.Add(Me.Label10)
        Me.grpTemperature.Controls.Add(Me.tbTempStatusRead)
        Me.grpTemperature.Controls.Add(Me.tbTempRead)
        Me.grpTemperature.Controls.Add(Me.Label12)
        Me.grpTemperature.Controls.Add(Me.Label13)
        Me.grpTemperature.Controls.Add(Me.Label14)
        Me.grpTemperature.Controls.Add(Me.btnSetTemp)
        Me.grpTemperature.Controls.Add(Me.cbTempApproach)
        Me.grpTemperature.Controls.Add(Me.tbTempRateTarget)
        Me.grpTemperature.Controls.Add(Me.tbTempTarget)
        Me.grpTemperature.Location = New System.Drawing.Point(6, 112)
        Me.grpTemperature.Name = "grpTemperature"
        Me.grpTemperature.Size = New System.Drawing.Size(400, 131)
        Me.grpTemperature.TabIndex = 14
        Me.grpTemperature.TabStop = False
        Me.grpTemperature.Text = "Temperature"
        '
        'btnGetTemp
        '
        Me.btnGetTemp.Location = New System.Drawing.Point(262, 73)
        Me.btnGetTemp.Name = "btnGetTemp"
        Me.btnGetTemp.Size = New System.Drawing.Size(99, 23)
        Me.btnGetTemp.TabIndex = 13
        Me.btnGetTemp.Text = "Get Temperature"
        Me.btnGetTemp.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(221, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Status (Code)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(240, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Temp. (K)"
        '
        'tbTempStatusRead
        '
        Me.tbTempStatusRead.Location = New System.Drawing.Point(298, 45)
        Me.tbTempStatusRead.Name = "tbTempStatusRead"
        Me.tbTempStatusRead.ReadOnly = True
        Me.tbTempStatusRead.Size = New System.Drawing.Size(82, 20)
        Me.tbTempStatusRead.TabIndex = 10
        '
        'tbTempRead
        '
        Me.tbTempRead.Location = New System.Drawing.Point(298, 19)
        Me.tbTempRead.Name = "tbTempRead"
        Me.tbTempRead.ReadOnly = True
        Me.tbTempRead.Size = New System.Drawing.Size(82, 20)
        Me.tbTempRead.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Approach Mode"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Rate (K/min)"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Set Temp. (K)"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnSetTemp
        '
        Me.btnSetTemp.Location = New System.Drawing.Point(38, 98)
        Me.btnSetTemp.Name = "btnSetTemp"
        Me.btnSetTemp.Size = New System.Drawing.Size(101, 23)
        Me.btnSetTemp.TabIndex = 2
        Me.btnSetTemp.Text = "Set Temperature"
        Me.btnSetTemp.UseVisualStyleBackColor = True
        '
        'cbTempApproach
        '
        Me.cbTempApproach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTempApproach.FormattingEnabled = True
        Me.cbTempApproach.Items.AddRange(New Object() {"Fast Settle", "No Overshoot"})
        Me.cbTempApproach.Location = New System.Drawing.Point(95, 71)
        Me.cbTempApproach.Name = "cbTempApproach"
        Me.cbTempApproach.Size = New System.Drawing.Size(93, 21)
        Me.cbTempApproach.TabIndex = 4
        '
        'tbTempRateTarget
        '
        Me.tbTempRateTarget.Location = New System.Drawing.Point(95, 45)
        Me.tbTempRateTarget.Name = "tbTempRateTarget"
        Me.tbTempRateTarget.Size = New System.Drawing.Size(93, 20)
        Me.tbTempRateTarget.TabIndex = 3
        Me.tbTempRateTarget.Text = "10.0"
        '
        'tbTempTarget
        '
        Me.tbTempTarget.Location = New System.Drawing.Point(95, 19)
        Me.tbTempTarget.Name = "tbTempTarget"
        Me.tbTempTarget.Size = New System.Drawing.Size(93, 20)
        Me.tbTempTarget.TabIndex = 2
        Me.tbTempTarget.Text = "300.0"
        '
        'grpChamber
        '
        Me.grpChamber.Controls.Add(Me.btnGetChamber)
        Me.grpChamber.Controls.Add(Me.Label11)
        Me.grpChamber.Controls.Add(Me.tbChamberStatus)
        Me.grpChamber.Controls.Add(Me.cbChamberSetCode)
        Me.grpChamber.Controls.Add(Me.Label16)
        Me.grpChamber.Controls.Add(Me.btnSetChamber)
        Me.grpChamber.Location = New System.Drawing.Point(6, 417)
        Me.grpChamber.Name = "grpChamber"
        Me.grpChamber.Size = New System.Drawing.Size(400, 85)
        Me.grpChamber.TabIndex = 15
        Me.grpChamber.TabStop = False
        Me.grpChamber.Text = "Chamber"
        '
        'btnGetChamber
        '
        Me.btnGetChamber.Location = New System.Drawing.Point(263, 52)
        Me.btnGetChamber.Name = "btnGetChamber"
        Me.btnGetChamber.Size = New System.Drawing.Size(99, 23)
        Me.btnGetChamber.TabIndex = 13
        Me.btnGetChamber.Text = "Get Chamber"
        Me.btnGetChamber.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(222, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Status (Code)"
        '
        'tbChamberStatus
        '
        Me.tbChamberStatus.Location = New System.Drawing.Point(299, 21)
        Me.tbChamberStatus.Name = "tbChamberStatus"
        Me.tbChamberStatus.ReadOnly = True
        Me.tbChamberStatus.Size = New System.Drawing.Size(82, 20)
        Me.tbChamberStatus.TabIndex = 10
        '
        'cbChamberSetCode
        '
        Me.cbChamberSetCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbChamberSetCode.FormattingEnabled = True
        Me.cbChamberSetCode.Items.AddRange(New Object() {"Seal", "Purge and Seal", "Vent and Seal", "Pump Continuous", "Vent Continuous", "High Vacuum"})
        Me.cbChamberSetCode.Location = New System.Drawing.Point(96, 20)
        Me.cbChamberSetCode.Name = "cbChamberSetCode"
        Me.cbChamberSetCode.Size = New System.Drawing.Size(120, 21)
        Me.cbChamberSetCode.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 13)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Chamber State"
        '
        'btnSetChamber
        '
        Me.btnSetChamber.Location = New System.Drawing.Point(37, 52)
        Me.btnSetChamber.Name = "btnSetChamber"
        Me.btnSetChamber.Size = New System.Drawing.Size(101, 23)
        Me.btnSetChamber.TabIndex = 2
        Me.btnSetChamber.Text = "Set Chamber"
        Me.btnSetChamber.UseVisualStyleBackColor = True
        '
        'tpPosition
        '
        Me.tpPosition.Controls.Add(Me.grpPosition)
        Me.tpPosition.Location = New System.Drawing.Point(4, 22)
        Me.tpPosition.Name = "tpPosition"
        Me.tpPosition.Size = New System.Drawing.Size(414, 512)
        Me.tpPosition.TabIndex = 2
        Me.tpPosition.Text = "Position"
        Me.tpPosition.UseVisualStyleBackColor = True
        '
        'grpPosition
        '
        Me.grpPosition.Controls.Add(Me.btnGetPosition)
        Me.grpPosition.Controls.Add(Me.Label21)
        Me.grpPosition.Controls.Add(Me.Label22)
        Me.grpPosition.Controls.Add(Me.tbPositionStatus)
        Me.grpPosition.Controls.Add(Me.tbReadPosition)
        Me.grpPosition.Controls.Add(Me.Label25)
        Me.grpPosition.Controls.Add(Me.Label26)
        Me.grpPosition.Controls.Add(Me.Label27)
        Me.grpPosition.Controls.Add(Me.btnSetPosition)
        Me.grpPosition.Controls.Add(Me.cbPositionMode)
        Me.grpPosition.Controls.Add(Me.tbSpeed)
        Me.grpPosition.Controls.Add(Me.tbSetPosition)
        Me.grpPosition.Location = New System.Drawing.Point(8, 3)
        Me.grpPosition.Name = "grpPosition"
        Me.grpPosition.Size = New System.Drawing.Size(400, 149)
        Me.grpPosition.TabIndex = 2
        Me.grpPosition.TabStop = False
        Me.grpPosition.Text = "Position"
        '
        'btnGetPosition
        '
        Me.btnGetPosition.Location = New System.Drawing.Point(273, 73)
        Me.btnGetPosition.Name = "btnGetPosition"
        Me.btnGetPosition.Size = New System.Drawing.Size(75, 23)
        Me.btnGetPosition.TabIndex = 13
        Me.btnGetPosition.Text = "Get Position"
        Me.btnGetPosition.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(221, 52)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 13)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Status (Code)"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(221, 26)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 13)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "Position (deg)"
        '
        'tbPositionStatus
        '
        Me.tbPositionStatus.Location = New System.Drawing.Point(298, 45)
        Me.tbPositionStatus.Name = "tbPositionStatus"
        Me.tbPositionStatus.ReadOnly = True
        Me.tbPositionStatus.Size = New System.Drawing.Size(82, 20)
        Me.tbPositionStatus.TabIndex = 10
        '
        'tbReadPosition
        '
        Me.tbReadPosition.Location = New System.Drawing.Point(298, 19)
        Me.tbReadPosition.Name = "tbReadPosition"
        Me.tbReadPosition.ReadOnly = True
        Me.tbReadPosition.Size = New System.Drawing.Size(82, 20)
        Me.tbReadPosition.TabIndex = 9
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(16, 76)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(34, 13)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Mode"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(12, 52)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 13)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Speed (deg/sec)"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(9, 26)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(90, 13)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Set Position (deg)"
        '
        'btnSetPosition
        '
        Me.btnSetPosition.Location = New System.Drawing.Point(57, 106)
        Me.btnSetPosition.Name = "btnSetPosition"
        Me.btnSetPosition.Size = New System.Drawing.Size(75, 23)
        Me.btnSetPosition.TabIndex = 2
        Me.btnSetPosition.Text = "Set Position"
        Me.btnSetPosition.UseVisualStyleBackColor = True
        '
        'cbPositionMode
        '
        Me.cbPositionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPositionMode.FormattingEnabled = True
        Me.cbPositionMode.Items.AddRange(New Object() {"Go to Target", "Go to Limit", "Define"})
        Me.cbPositionMode.Location = New System.Drawing.Point(105, 71)
        Me.cbPositionMode.Name = "cbPositionMode"
        Me.cbPositionMode.Size = New System.Drawing.Size(93, 21)
        Me.cbPositionMode.TabIndex = 4
        '
        'tbSpeed
        '
        Me.tbSpeed.Location = New System.Drawing.Point(105, 45)
        Me.tbSpeed.Name = "tbSpeed"
        Me.tbSpeed.Size = New System.Drawing.Size(93, 20)
        Me.tbSpeed.TabIndex = 3
        Me.tbSpeed.Text = "10.0"
        '
        'tbSetPosition
        '
        Me.tbSetPosition.Location = New System.Drawing.Point(105, 19)
        Me.tbSetPosition.Name = "tbSetPosition"
        Me.tbSetPosition.Size = New System.Drawing.Size(93, 20)
        Me.tbSetPosition.TabIndex = 2
        Me.tbSetPosition.Text = "100.0"
        '
        'tpSDOAndPPMS
        '
        Me.tpSDOAndPPMS.Controls.Add(Me.gbSendPpmsCommand)
        Me.tpSDOAndPPMS.Controls.Add(Me.grpSDO)
        Me.tpSDOAndPPMS.Controls.Add(Me.grpPPMSData)
        Me.tpSDOAndPPMS.Location = New System.Drawing.Point(4, 22)
        Me.tpSDOAndPPMS.Name = "tpSDOAndPPMS"
        Me.tpSDOAndPPMS.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSDOAndPPMS.Size = New System.Drawing.Size(414, 512)
        Me.tpSDOAndPPMS.TabIndex = 1
        Me.tpSDOAndPPMS.Text = "SDO and PPMS Data"
        Me.tpSDOAndPPMS.UseVisualStyleBackColor = True
        '
        'gbSendPpmsCommand
        '
        Me.gbSendPpmsCommand.Controls.Add(Me.Label31)
        Me.gbSendPpmsCommand.Controls.Add(Me.tbErrorStr)
        Me.gbSendPpmsCommand.Controls.Add(Me.Label29)
        Me.gbSendPpmsCommand.Controls.Add(Me.tbReply)
        Me.gbSendPpmsCommand.Controls.Add(Me.Label28)
        Me.gbSendPpmsCommand.Controls.Add(Me.btnSendCommand)
        Me.gbSendPpmsCommand.Controls.Add(Me.tbCommand)
        Me.gbSendPpmsCommand.Location = New System.Drawing.Point(8, 199)
        Me.gbSendPpmsCommand.Name = "gbSendPpmsCommand"
        Me.gbSendPpmsCommand.Size = New System.Drawing.Size(398, 149)
        Me.gbSendPpmsCommand.TabIndex = 16
        Me.gbSendPpmsCommand.TabStop = False
        Me.gbSendPpmsCommand.Text = "Send PPMS Command"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(11, 116)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(62, 13)
        Me.Label31.TabIndex = 22
        Me.Label31.Text = "Error String:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbErrorStr
        '
        Me.tbErrorStr.Location = New System.Drawing.Point(79, 109)
        Me.tbErrorStr.Name = "tbErrorStr"
        Me.tbErrorStr.ReadOnly = True
        Me.tbErrorStr.Size = New System.Drawing.Size(299, 20)
        Me.tbErrorStr.TabIndex = 21
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(36, 90)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(37, 13)
        Me.Label29.TabIndex = 19
        Me.Label29.Text = "Reply:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbReply
        '
        Me.tbReply.Location = New System.Drawing.Point(79, 83)
        Me.tbReply.Name = "tbReply"
        Me.tbReply.ReadOnly = True
        Me.tbReply.Size = New System.Drawing.Size(299, 20)
        Me.tbReply.TabIndex = 17
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(16, 31)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(57, 13)
        Me.Label28.TabIndex = 17
        Me.Label28.Text = "Command:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnSendCommand
        '
        Me.btnSendCommand.Location = New System.Drawing.Point(19, 54)
        Me.btnSendCommand.Name = "btnSendCommand"
        Me.btnSendCommand.Size = New System.Drawing.Size(101, 23)
        Me.btnSendCommand.TabIndex = 16
        Me.btnSendCommand.Text = "Send Command"
        Me.btnSendCommand.UseVisualStyleBackColor = True
        '
        'tbCommand
        '
        Me.tbCommand.Location = New System.Drawing.Point(79, 28)
        Me.tbCommand.Name = "tbCommand"
        Me.tbCommand.Size = New System.Drawing.Size(229, 20)
        Me.tbCommand.TabIndex = 16
        Me.tbCommand.Text = "$GETONE? 3"
        '
        'grpSDO
        '
        Me.grpSDO.Controls.Add(Me.tbReadSDO)
        Me.grpSDO.Controls.Add(Me.Label20)
        Me.grpSDO.Controls.Add(Me.tbSubindex)
        Me.grpSDO.Controls.Add(Me.Label18)
        Me.grpSDO.Controls.Add(Me.Label19)
        Me.grpSDO.Controls.Add(Me.tbIndex)
        Me.grpSDO.Controls.Add(Me.Label17)
        Me.grpSDO.Controls.Add(Me.tbNode)
        Me.grpSDO.Controls.Add(Me.cbType)
        Me.grpSDO.Controls.Add(Me.btnReadSDO)
        Me.grpSDO.Location = New System.Drawing.Point(6, 6)
        Me.grpSDO.Name = "grpSDO"
        Me.grpSDO.Size = New System.Drawing.Size(400, 107)
        Me.grpSDO.TabIndex = 16
        Me.grpSDO.TabStop = False
        Me.grpSDO.Text = "SDO"
        '
        'tbReadSDO
        '
        Me.tbReadSDO.Location = New System.Drawing.Point(151, 76)
        Me.tbReadSDO.Name = "tbReadSDO"
        Me.tbReadSDO.ReadOnly = True
        Me.tbReadSDO.Size = New System.Drawing.Size(229, 20)
        Me.tbReadSDO.TabIndex = 14
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(212, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 13)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Subindex (hex):"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbSubindex
        '
        Me.tbSubindex.Location = New System.Drawing.Point(298, 45)
        Me.tbSubindex.Name = "tbSubindex"
        Me.tbSubindex.Size = New System.Drawing.Size(82, 20)
        Me.tbSubindex.TabIndex = 16
        Me.tbSubindex.Text = "2"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(29, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Data Type:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(230, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 13)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Index (hex):"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbIndex
        '
        Me.tbIndex.Location = New System.Drawing.Point(298, 19)
        Me.tbIndex.Name = "tbIndex"
        Me.tbIndex.Size = New System.Drawing.Size(82, 20)
        Me.tbIndex.TabIndex = 13
        Me.tbIndex.Text = "2002"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(53, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 13)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Node:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbNode
        '
        Me.tbNode.Location = New System.Drawing.Point(95, 19)
        Me.tbNode.Name = "tbNode"
        Me.tbNode.Size = New System.Drawing.Size(82, 20)
        Me.tbNode.TabIndex = 10
        Me.tbNode.Text = "3"
        '
        'cbType
        '
        Me.cbType.DropDownHeight = 180
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.FormattingEnabled = True
        Me.cbType.IntegralHeight = False
        Me.cbType.Items.AddRange(New Object() {"Signed-8", "Unsigned-8", "Signed-16", "Unsigned-16", "Signed-32", "Unsigned-32", "Signed-64", "Unsigned-64", "Float-32", "Float-64", "String", "Binary"})
        Me.cbType.Location = New System.Drawing.Point(95, 45)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(93, 21)
        Me.cbType.TabIndex = 4
        '
        'btnReadSDO
        '
        Me.btnReadSDO.Location = New System.Drawing.Point(37, 74)
        Me.btnReadSDO.Name = "btnReadSDO"
        Me.btnReadSDO.Size = New System.Drawing.Size(101, 23)
        Me.btnReadSDO.TabIndex = 2
        Me.btnReadSDO.Text = "Read SDO"
        Me.btnReadSDO.UseVisualStyleBackColor = True
        '
        'grpPPMSData
        '
        Me.grpPPMSData.Controls.Add(Me.cbFast)
        Me.grpPPMSData.Controls.Add(Me.tbPPMSData)
        Me.grpPPMSData.Controls.Add(Me.Label24)
        Me.grpPPMSData.Controls.Add(Me.tbChannel)
        Me.grpPPMSData.Controls.Add(Me.btnReadPPMSData)
        Me.grpPPMSData.Location = New System.Drawing.Point(6, 119)
        Me.grpPPMSData.Name = "grpPPMSData"
        Me.grpPPMSData.Size = New System.Drawing.Size(400, 74)
        Me.grpPPMSData.TabIndex = 18
        Me.grpPPMSData.TabStop = False
        Me.grpPPMSData.Text = "PPMS Data"
        '
        'cbFast
        '
        Me.cbFast.AutoSize = True
        Me.cbFast.Checked = True
        Me.cbFast.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFast.Location = New System.Drawing.Point(215, 21)
        Me.cbFast.Name = "cbFast"
        Me.cbFast.Size = New System.Drawing.Size(46, 17)
        Me.cbFast.TabIndex = 15
        Me.cbFast.Text = "Fast"
        Me.cbFast.UseVisualStyleBackColor = True
        '
        'tbPPMSData
        '
        Me.tbPPMSData.Location = New System.Drawing.Point(151, 47)
        Me.tbPPMSData.Name = "tbPPMSData"
        Me.tbPPMSData.ReadOnly = True
        Me.tbPPMSData.Size = New System.Drawing.Size(170, 20)
        Me.tbPPMSData.TabIndex = 14
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(44, 22)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(46, 13)
        Me.Label24.TabIndex = 12
        Me.Label24.Text = "Channel"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbChannel
        '
        Me.tbChannel.Location = New System.Drawing.Point(95, 19)
        Me.tbChannel.Name = "tbChannel"
        Me.tbChannel.Size = New System.Drawing.Size(82, 20)
        Me.tbChannel.TabIndex = 10
        Me.tbChannel.Text = "1"
        '
        'btnReadPPMSData
        '
        Me.btnReadPPMSData.Location = New System.Drawing.Point(38, 45)
        Me.btnReadPPMSData.Name = "btnReadPPMSData"
        Me.btnReadPPMSData.Size = New System.Drawing.Size(101, 23)
        Me.btnReadPPMSData.TabIndex = 2
        Me.btnReadPPMSData.Text = "Read Data"
        Me.btnReadPPMSData.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 538)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "QDInstrument Example"
        Me.TabControl1.ResumeLayout(False)
        Me.tpBasic.ResumeLayout(False)
        Me.gbInstrument.ResumeLayout(False)
        Me.gbInstrument.PerformLayout()
        Me.grpField.ResumeLayout(False)
        Me.grpField.PerformLayout()
        Me.grpTemperature.ResumeLayout(False)
        Me.grpTemperature.PerformLayout()
        Me.grpChamber.ResumeLayout(False)
        Me.grpChamber.PerformLayout()
        Me.tpPosition.ResumeLayout(False)
        Me.grpPosition.ResumeLayout(False)
        Me.grpPosition.PerformLayout()
        Me.tpSDOAndPPMS.ResumeLayout(False)
        Me.gbSendPpmsCommand.ResumeLayout(False)
        Me.gbSendPpmsCommand.PerformLayout()
        Me.grpSDO.ResumeLayout(False)
        Me.grpSDO.PerformLayout()
        Me.grpPPMSData.ResumeLayout(False)
        Me.grpPPMSData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpBasic As System.Windows.Forms.TabPage
    Friend WithEvents gbInstrument As System.Windows.Forms.GroupBox
    Friend WithEvents btnSetLocalHost As System.Windows.Forms.Button
    Friend WithEvents cbRemote As System.Windows.Forms.CheckBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbIPAddress As System.Windows.Forms.TextBox
    Friend WithEvents grpField As System.Windows.Forms.GroupBox
    Friend WithEvents btnGetField As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbFieldStatusRead As System.Windows.Forms.TextBox
    Friend WithEvents tbFieldRead As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSetField As System.Windows.Forms.Button
    Friend WithEvents cbEndMode As System.Windows.Forms.ComboBox
    Friend WithEvents cbFieldApproach As System.Windows.Forms.ComboBox
    Friend WithEvents tbFieldRateTarget As System.Windows.Forms.TextBox
    Friend WithEvents tbFieldTarget As System.Windows.Forms.TextBox
    Friend WithEvents grpTemperature As System.Windows.Forms.GroupBox
    Friend WithEvents btnGetTemp As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbTempStatusRead As System.Windows.Forms.TextBox
    Friend WithEvents tbTempRead As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnSetTemp As System.Windows.Forms.Button
    Friend WithEvents cbTempApproach As System.Windows.Forms.ComboBox
    Friend WithEvents tbTempRateTarget As System.Windows.Forms.TextBox
    Friend WithEvents tbTempTarget As System.Windows.Forms.TextBox
    Friend WithEvents grpChamber As System.Windows.Forms.GroupBox
    Friend WithEvents btnGetChamber As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbChamberStatus As System.Windows.Forms.TextBox
    Friend WithEvents cbChamberSetCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnSetChamber As System.Windows.Forms.Button
    Friend WithEvents tpPosition As System.Windows.Forms.TabPage
    Friend WithEvents grpPosition As System.Windows.Forms.GroupBox
    Friend WithEvents btnGetPosition As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tbPositionStatus As System.Windows.Forms.TextBox
    Friend WithEvents tbReadPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btnSetPosition As System.Windows.Forms.Button
    Friend WithEvents cbPositionMode As System.Windows.Forms.ComboBox
    Friend WithEvents tbSpeed As System.Windows.Forms.TextBox
    Friend WithEvents tbSetPosition As System.Windows.Forms.TextBox
    Friend WithEvents tpSDOAndPPMS As System.Windows.Forms.TabPage
    Friend WithEvents gbSendPpmsCommand As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents tbErrorStr As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents tbReply As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents btnSendCommand As System.Windows.Forms.Button
    Friend WithEvents tbCommand As System.Windows.Forms.TextBox
    Friend WithEvents grpSDO As System.Windows.Forms.GroupBox
    Friend WithEvents tbReadSDO As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tbSubindex As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tbIndex As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tbNode As System.Windows.Forms.TextBox
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents btnReadSDO As System.Windows.Forms.Button
    Friend WithEvents grpPPMSData As System.Windows.Forms.GroupBox
    Friend WithEvents cbFast As System.Windows.Forms.CheckBox
    Friend WithEvents tbPPMSData As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents tbChannel As System.Windows.Forms.TextBox
    Friend WithEvents btnReadPPMSData As System.Windows.Forms.Button

End Class
