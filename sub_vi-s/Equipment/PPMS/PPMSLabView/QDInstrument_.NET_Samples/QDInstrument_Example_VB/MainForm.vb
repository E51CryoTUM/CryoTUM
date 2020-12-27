'Statement required to use QDInstrument features
Imports QuantumDesign.QDInstrument

Public Class MainForm

    'Global variable holding reference to Quantum Design Instrument
    'All communication is through this variable
    'This variable is intialized in the method btnConnect_Click
    Private Instrument As QDInstrumentBase

#Region "Instrument Connection"

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        btnConnect.Enabled = False

        'Connect to the instrument
        'Change the first argument for different instrument types (PPMS, DynaCool, VersaLab, SVSM)
        Instrument = QDInstrumentFactory.GetQDInstrument(QDInstrumentBase.QDInstrumentType.PPMS, cbRemote.Checked, tbIPAddress.Text)
    End Sub

    Private Sub cbRemote_CheckedChanged(sender As Object, e As EventArgs) Handles cbRemote.CheckedChanged
        tbIPAddress.Enabled = cbRemote.Checked
    End Sub

    Private Sub btnSetLocalHost_Click(sender As Object, e As EventArgs) Handles btnSetLocalHost.Click
        tbIPAddress.Text = "127.0.0.1"
    End Sub

#End Region

#Region "Temperature"

    Private Sub btnSetTemp_Click(sender As Object, e As EventArgs) Handles btnSetTemp.Click
        'Sends the temperature, ramp rate, and approach mode to MultiVu based on user input
        Try
            Dim T As Double = CDbl(tbTempTarget.Text)
            Dim R As Double = CDbl(tbTempRateTarget.Text)
            Instrument.SetTemperature(T, R, cbTempApproach.SelectedIndex)
        Catch ex As InvalidCastException
            MessageBox.Show("Please enter a valid number")
        End Try
    End Sub

    Private Sub btnGetTemp_Click(sender As Object, e As EventArgs) Handles btnGetTemp.Click
        'Gets the temperature and temperature status from MultiVu, then displays them in text boxes
        Dim T As Double
        Dim S As Int32
        Instrument.GetTemperature(T, S)
        tbTempRead.Text = Format(T, "0.000")
        tbTempStatusRead.Text = S
    End Sub

#End Region

#Region "Field"

    Private Sub btnSetField_Click(sender As Object, e As EventArgs) Handles btnSetField.Click
        'Sends the field, ramp rate, approach mode, and end mode to MultiVu based on user input
        Try
            Dim H As Double = CDbl(tbFieldTarget.Text)
            Dim R As Double = CDbl(tbFieldRateTarget.Text)
            Instrument.SetField(H, R, cbFieldApproach.SelectedIndex, cbEndMode.SelectedIndex)
        Catch ex As InvalidCastException
            MessageBox.Show("Please enter a valid number")
        End Try
    End Sub

    Private Sub btnGetField_Click(sender As Object, e As EventArgs) Handles btnGetField.Click
        'Gets the field and field status from MultiVu, then displays them in text boxes
        Dim H As Double
        Dim S As Int32
        Instrument.GetField(H, S)
        tbFieldRead.Text = Format(H, "0.00")
        tbFieldStatusRead.Text = S
    End Sub

#End Region

#Region "Chamber"

    Private Sub btnSetChamber_Click(sender As Object, e As EventArgs) Handles btnSetChamber.Click
        'Sends chamber command to MultiVu based on user input
        Instrument.SetChamber(cbChamberSetCode.SelectedIndex)
    End Sub

    Private Sub btnGetChamber_Click(sender As Object, e As EventArgs) Handles btnGetChamber.Click
        'Gets chamber status from MultiVu, then display in a text box
        Dim S As Int32
        Instrument.GetChamber(S)
        tbChamberStatus.Text = S
    End Sub

#End Region

#Region "Position"

    Private Sub btnSetPosition_Click(sender As Object, e As EventArgs) Handles btnSetPosition.Click
        'Sends the rotator position, speed, and position mode to MultiVu based on user input
        Try
            Dim P As Double = CDbl(tbSetPosition.Text)
            Dim Speed As Double = CDbl(tbSpeed.Text)
            Instrument.SetPosition("Horizontal Rotator", P, Speed, cbPositionMode.SelectedIndex)
        Catch ex As InvalidCastException
            MessageBox.Show("Please enter a valid number")
        End Try
    End Sub

    Private Sub btnGetPosition_Click(sender As Object, e As EventArgs) Handles btnGetPosition.Click
        'Gets the position and position status from MultiVu, then displays them in text boxes
        Dim P As Double
        Dim S As Int32
        Instrument.GetPosition("Horizontal Rotator", P, S)
        tbReadPosition.Text = Format(P, "0.000")
        tbPositionStatus.Text = S
    End Sub

#End Region

#Region "SDO"
    Private Sub btnReadSDO_Click(sender As Object, e As EventArgs) Handles btnReadSDO.Click
        'Reads an SDO specified by user-input CAN node, index, subindex, and type, then displays result in a text box
        Try
            tbReadSDO.Text = Instrument.ReadSDO(tbNode.Text, _
                                                Integer.Parse(tbIndex.Text, Globalization.NumberStyles.HexNumber), _
                                                Integer.Parse(tbSubindex.Text, Globalization.NumberStyles.HexNumber), _
                                                cbType.SelectedIndex + 1)
        Catch ex As CANException
            MessageBox.Show("CAN Error: " & ex.Message, "CAN Error", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region

#Region "PPMS"

    Private Sub btnReadPPMSData_Click(sender As Object, e As EventArgs) Handles btnReadPPMSData.Click
        'Reads user-specified data channel from the Model 6000, then displays result in a text box
        'Channels are specified in Table A-1 of "Physical Property Measurement System GPIB Commands Manual"
        Dim result As Double
        Instrument.GetPPMSItem(CInt(tbChannel.Text), result, cbFast.Checked)
        tbPPMSData.Text = result
    End Sub

    Private Sub btnSendCommand_Click(sender As Object, e As EventArgs) Handles btnSendCommand.Click
        'Sends user-specified GPIB command to the Model 6000, reads reply string (if any), and displays reply in a text box
        'Also displays error string, if any, in a text box
        Dim reply As String = ""
        Dim errorStr As String = ""
        Instrument.SendPPMSCommand(tbCommand.Text, reply, errorStr, 0, 0)
        tbReply.Text = reply
        tbErrorStr.Text = errorStr
    End Sub

#End Region

#Region "GUI Initialization"

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set defaults for combo boxes:
        cbTempApproach.SelectedIndex = 0
        cbFieldApproach.SelectedIndex = 0
        cbEndMode.SelectedIndex = 0
        cbChamberSetCode.SelectedIndex = 0
        cbPositionMode.SelectedIndex = 0
        cbType.SelectedIndex = 8
    End Sub

#End Region

End Class
