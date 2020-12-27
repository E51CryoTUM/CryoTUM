using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Statement required to use QDInstrument features
using QuantumDesign.QDInstrument;

namespace QDInstrument_Example_CSharp
{
    public partial class MainForm : Form
    {
        //Global variable holding reference to Quantum Design Instrument
        //All communication is through this variable
        //This variable is intialized in the method btnConnect_Click
        private QDInstrumentBase Instrument;
                
        #region Instrument Connection
        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;

            //Connect to the instrument
            //Change the first argument for different instrument types (PPMS, DynaCool, VersaLab, SVSM)
            Instrument = QDInstrumentFactory.GetQDInstrument(QDInstrumentBase.QDInstrumentType.PPMS, cbRemote.Checked, tbIPAddress.Text);
        }

        private void cbRemote_CheckedChanged(object sender, EventArgs e)
        {
            tbIPAddress.Enabled = cbRemote.Checked;
        }

        private void btnSetLocalHost_Click(object sender, EventArgs e)
        {
            tbIPAddress.Text = "127.0.0.1";
        }
        #endregion

        #region Temperature
        private void btnSetTemp_Click(object sender, EventArgs e)
        {
            try
            {
                //Sends the temperature, ramp rate, and end mode to MultiVu based on user input
                double T = Convert.ToDouble(tbTempTarget.Text);
                double R = Convert.ToDouble(tbTempRateTarget.Text);
                Instrument.SetTemperature(T, R, (QDInstrumentBase.TemperatureApproach)cbTempApproach.SelectedIndex);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void btnGetTemp_Click(object sender, EventArgs e)
        {
            //Gets the temperature and temperature status from MultiVu, then displays them in text boxes
            double T = 0;
            QDInstrumentBase.TemperatureStatus S = QDInstrumentBase.TemperatureStatus.TemperatureUnknown;
            Instrument.GetTemperature(ref T, ref S);
            tbTempRead.Text = T.ToString("0.000");
            tbTempStatusRead.Text = ((Int16)S).ToString();
        }
        #endregion

        #region Field
        private void btnSetField_Click(object sender, EventArgs e)
        {
            //Sends the field, ramp rate, approach mode, and end mode to MultiVu based on user input
            try
            {
                double H = Convert.ToDouble(tbFieldTarget.Text);
                double R = Convert.ToDouble(tbFieldRateTarget.Text);
                Instrument.SetField(H, R, (QDInstrumentBase.FieldApproach)cbFieldApproach.SelectedIndex, (QDInstrumentBase.FieldMode)cbEndMode.SelectedIndex);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void btnGetField_Click(object sender, EventArgs e)
        {
            //Gets the field and field status from MultiVu, then displays them in text boxes
            double H = 0;
            QDInstrumentBase.FieldStatus S = QDInstrumentBase.FieldStatus.MagnetUnknown;
            Instrument.GetField(ref H, ref S);
            tbFieldRead.Text = H.ToString("0.00");
            tbFieldStatusRead.Text = ((Int16)S).ToString();
        }
        #endregion

        #region Chamber
        private void btnSetChamber_Click(object sender, EventArgs e)
        {
            //Sends chamber command to MultiVu based on user input
            Instrument.SetChamber((QDInstrumentBase.ChamberCommand)cbChamberSetCode.SelectedIndex);
        }

        private void btnGetChamber_Click(object sender, EventArgs e)
        {
            //Gets chamber status from MultiVu, then display in a text box
            QDInstrumentBase.ChamberStatus S = QDInstrumentBase.ChamberStatus.ChamberUnknown;
            Instrument.GetChamber(ref S);
            tbChamberStatus.Text = ((Int16)S).ToString();
        }
        #endregion

        #region Position
        private void btnSetPosition_Click(object sender, EventArgs e)
        {
            //Sends the rotator position, speed, and position mode to MultiVu based on user input
            try
            {
                double P = Convert.ToDouble(tbSetPosition.Text);
                double Speed = Convert.ToDouble(tbSpeed.Text);
                Instrument.SetPosition("Horizontal Rotator", P, Speed, (QDInstrumentBase.PositionMode)cbPositionMode.SelectedIndex);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void btnGetPosition_Click(object sender, EventArgs e)
        {
            //Gets the position and position status from MultiVu, then displays them in text boxes
            double P = 0;
            QDInstrumentBase.PositionStatus S = QDInstrumentBase.PositionStatus.PositionUnknown;
            Instrument.GetPosition("Horizontal Rotator", ref P, ref S);
            tbReadPosition.Text = P.ToString("0.000");
            tbPositionStatus.Text = ((Int16)S).ToString();
        }
        #endregion

        #region SDO
        private void btnReadSDO_Click(object sender, EventArgs e)
        {
            //Reads an SDO specified by user-input CAN node, index, subindex, and type, then displays result in a text box
            try
            {
                tbReadSDO.Text = Instrument.ReadSDO(Convert.ToByte(tbNode.Text),
                    int.Parse(tbIndex.Text, System.Globalization.NumberStyles.HexNumber),
                    int.Parse(tbSubindex.Text, System.Globalization.NumberStyles.HexNumber),
                    (TCanType)(cbType.SelectedIndex + 1)).ToString();
            }
            catch (CANException ex)
            {
                MessageBox.Show("CAN Error: " + ex.Message, "CAN Error", MessageBoxButtons.OK);
            }
        }
        #endregion

        #region PPMS
        private void btnReadPPMSData_Click(object sender, EventArgs e)
        {
            //Reads user-specified data channel from the Model 6000, then displays result in a text box
            //Channels are specified in Table A-1 of "Physical Property Measurement System GPIB Commands Manual"
            double result = 0;
            Instrument.GetPPMSItem(Convert.ToInt16(tbChannel.Text), ref result, cbFast.Checked);
            tbPPMSData.Text = result.ToString();
        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            //Sends user-specified GPIB command to the Model 6000, reads reply string (if any), and displays reply in a text box
            //Also displays error string, if any, in a text box
            string reply = "";
            string errorStr = "";
            Instrument.SendPPMSCommand(tbCommand.Text, ref reply, ref errorStr, 0, 0);
            tbReply.Text = reply;
            tbErrorStr.Text = errorStr;
        }
        #endregion

        #region GUI Initialization
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Set defaults for combo boxes:
            cbTempApproach.SelectedIndex = 0;
            cbFieldApproach.SelectedIndex = 0;
            cbEndMode.SelectedIndex = 0;
            cbChamberSetCode.SelectedIndex = 0;
            cbPositionMode.SelectedIndex = 0;
            cbType.SelectedIndex = 8;
        }
        #endregion

    }
}
