namespace QDInstrument_Example_CSharp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tpBasic = new System.Windows.Forms.TabPage();
            this.gbInstrument = new System.Windows.Forms.GroupBox();
            this.btnSetLocalHost = new System.Windows.Forms.Button();
            this.cbRemote = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.grpField = new System.Windows.Forms.GroupBox();
            this.btnGetField = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.tbFieldStatusRead = new System.Windows.Forms.TextBox();
            this.tbFieldRead = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnSetField = new System.Windows.Forms.Button();
            this.cbEndMode = new System.Windows.Forms.ComboBox();
            this.cbFieldApproach = new System.Windows.Forms.ComboBox();
            this.tbFieldRateTarget = new System.Windows.Forms.TextBox();
            this.tbFieldTarget = new System.Windows.Forms.TextBox();
            this.grpTemperature = new System.Windows.Forms.GroupBox();
            this.btnGetTemp = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.tbTempStatusRead = new System.Windows.Forms.TextBox();
            this.tbTempRead = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.btnSetTemp = new System.Windows.Forms.Button();
            this.cbTempApproach = new System.Windows.Forms.ComboBox();
            this.tbTempRateTarget = new System.Windows.Forms.TextBox();
            this.tbTempTarget = new System.Windows.Forms.TextBox();
            this.grpChamber = new System.Windows.Forms.GroupBox();
            this.btnGetChamber = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.tbChamberStatus = new System.Windows.Forms.TextBox();
            this.cbChamberSetCode = new System.Windows.Forms.ComboBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.btnSetChamber = new System.Windows.Forms.Button();
            this.tpPosition = new System.Windows.Forms.TabPage();
            this.grpPosition = new System.Windows.Forms.GroupBox();
            this.btnGetPosition = new System.Windows.Forms.Button();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.tbPositionStatus = new System.Windows.Forms.TextBox();
            this.tbReadPosition = new System.Windows.Forms.TextBox();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.btnSetPosition = new System.Windows.Forms.Button();
            this.cbPositionMode = new System.Windows.Forms.ComboBox();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.tbSetPosition = new System.Windows.Forms.TextBox();
            this.tpSDOAndPPMS = new System.Windows.Forms.TabPage();
            this.gbSendPpmsCommand = new System.Windows.Forms.GroupBox();
            this.Label31 = new System.Windows.Forms.Label();
            this.tbErrorStr = new System.Windows.Forms.TextBox();
            this.Label29 = new System.Windows.Forms.Label();
            this.tbReply = new System.Windows.Forms.TextBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.grpSDO = new System.Windows.Forms.GroupBox();
            this.tbReadSDO = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.tbSubindex = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.tbNode = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnReadSDO = new System.Windows.Forms.Button();
            this.grpPPMSData = new System.Windows.Forms.GroupBox();
            this.cbFast = new System.Windows.Forms.CheckBox();
            this.tbPPMSData = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.tbChannel = new System.Windows.Forms.TextBox();
            this.btnReadPPMSData = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.tpBasic.SuspendLayout();
            this.gbInstrument.SuspendLayout();
            this.grpField.SuspendLayout();
            this.grpTemperature.SuspendLayout();
            this.grpChamber.SuspendLayout();
            this.tpPosition.SuspendLayout();
            this.grpPosition.SuspendLayout();
            this.tpSDOAndPPMS.SuspendLayout();
            this.gbSendPpmsCommand.SuspendLayout();
            this.grpSDO.SuspendLayout();
            this.grpPPMSData.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tpBasic);
            this.TabControl1.Controls.Add(this.tpPosition);
            this.TabControl1.Controls.Add(this.tpSDOAndPPMS);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(426, 542);
            this.TabControl1.TabIndex = 22;
            // 
            // tpBasic
            // 
            this.tpBasic.Controls.Add(this.gbInstrument);
            this.tpBasic.Controls.Add(this.grpField);
            this.tpBasic.Controls.Add(this.grpTemperature);
            this.tpBasic.Controls.Add(this.grpChamber);
            this.tpBasic.Location = new System.Drawing.Point(4, 22);
            this.tpBasic.Name = "tpBasic";
            this.tpBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tpBasic.Size = new System.Drawing.Size(418, 516);
            this.tpBasic.TabIndex = 0;
            this.tpBasic.Text = "Basic";
            this.tpBasic.UseVisualStyleBackColor = true;
            // 
            // gbInstrument
            // 
            this.gbInstrument.Controls.Add(this.btnSetLocalHost);
            this.gbInstrument.Controls.Add(this.cbRemote);
            this.gbInstrument.Controls.Add(this.btnConnect);
            this.gbInstrument.Controls.Add(this.Label8);
            this.gbInstrument.Controls.Add(this.tbIPAddress);
            this.gbInstrument.Location = new System.Drawing.Point(6, 6);
            this.gbInstrument.Name = "gbInstrument";
            this.gbInstrument.Size = new System.Drawing.Size(400, 100);
            this.gbInstrument.TabIndex = 2;
            this.gbInstrument.TabStop = false;
            this.gbInstrument.Text = "Instrument";
            // 
            // btnSetLocalHost
            // 
            this.btnSetLocalHost.Location = new System.Drawing.Point(288, 23);
            this.btnSetLocalHost.Name = "btnSetLocalHost";
            this.btnSetLocalHost.Size = new System.Drawing.Size(65, 23);
            this.btnSetLocalHost.TabIndex = 19;
            this.btnSetLocalHost.Text = "localhost";
            this.btnSetLocalHost.UseVisualStyleBackColor = true;
            this.btnSetLocalHost.Click += new System.EventHandler(this.btnSetLocalHost_Click);
            // 
            // cbRemote
            // 
            this.cbRemote.AutoSize = true;
            this.cbRemote.Location = new System.Drawing.Point(26, 28);
            this.cbRemote.Name = "cbRemote";
            this.cbRemote.Size = new System.Drawing.Size(63, 17);
            this.cbRemote.TabIndex = 16;
            this.cbRemote.Text = "Remote";
            this.cbRemote.UseVisualStyleBackColor = true;
            this.cbRemote.CheckedChanged += new System.EventHandler(this.cbRemote_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(26, 62);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(103, 28);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(61, 13);
            this.Label8.TabIndex = 15;
            this.Label8.Text = "IP Address:";
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Enabled = false;
            this.tbIPAddress.Location = new System.Drawing.Point(170, 25);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(112, 20);
            this.tbIPAddress.TabIndex = 14;
            this.tbIPAddress.Text = "127.0.0.1";
            // 
            // grpField
            // 
            this.grpField.Controls.Add(this.btnGetField);
            this.grpField.Controls.Add(this.Label5);
            this.grpField.Controls.Add(this.Label6);
            this.grpField.Controls.Add(this.tbFieldStatusRead);
            this.grpField.Controls.Add(this.tbFieldRead);
            this.grpField.Controls.Add(this.Label4);
            this.grpField.Controls.Add(this.Label3);
            this.grpField.Controls.Add(this.Label2);
            this.grpField.Controls.Add(this.Label1);
            this.grpField.Controls.Add(this.btnSetField);
            this.grpField.Controls.Add(this.cbEndMode);
            this.grpField.Controls.Add(this.cbFieldApproach);
            this.grpField.Controls.Add(this.tbFieldRateTarget);
            this.grpField.Controls.Add(this.tbFieldTarget);
            this.grpField.Location = new System.Drawing.Point(6, 249);
            this.grpField.Name = "grpField";
            this.grpField.Size = new System.Drawing.Size(400, 162);
            this.grpField.TabIndex = 1;
            this.grpField.TabStop = false;
            this.grpField.Text = "Field";
            // 
            // btnGetField
            // 
            this.btnGetField.Location = new System.Drawing.Point(273, 71);
            this.btnGetField.Name = "btnGetField";
            this.btnGetField.Size = new System.Drawing.Size(75, 23);
            this.btnGetField.TabIndex = 13;
            this.btnGetField.Text = "Get Field";
            this.btnGetField.UseVisualStyleBackColor = true;
            this.btnGetField.Click += new System.EventHandler(this.btnGetField_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(221, 52);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(71, 13);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "Status (Code)";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(240, 26);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(52, 13);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "Field (Oe)";
            // 
            // tbFieldStatusRead
            // 
            this.tbFieldStatusRead.Location = new System.Drawing.Point(298, 45);
            this.tbFieldStatusRead.Name = "tbFieldStatusRead";
            this.tbFieldStatusRead.ReadOnly = true;
            this.tbFieldStatusRead.Size = new System.Drawing.Size(82, 20);
            this.tbFieldStatusRead.TabIndex = 10;
            // 
            // tbFieldRead
            // 
            this.tbFieldRead.Location = new System.Drawing.Point(298, 19);
            this.tbFieldRead.Name = "tbFieldRead";
            this.tbFieldRead.ReadOnly = true;
            this.tbFieldRead.Size = new System.Drawing.Size(82, 20);
            this.tbFieldRead.TabIndex = 9;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(33, 106);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(56, 13);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "End Mode";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 79);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(83, 13);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Approach Mode";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(14, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 13);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Rate (Oe/sec)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Set Field (Oe)";
            // 
            // btnSetField
            // 
            this.btnSetField.Location = new System.Drawing.Point(59, 125);
            this.btnSetField.Name = "btnSetField";
            this.btnSetField.Size = new System.Drawing.Size(75, 23);
            this.btnSetField.TabIndex = 2;
            this.btnSetField.Text = "Set Field";
            this.btnSetField.UseVisualStyleBackColor = true;
            this.btnSetField.Click += new System.EventHandler(this.btnSetField_Click);
            // 
            // cbEndMode
            // 
            this.cbEndMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndMode.FormattingEnabled = true;
            this.cbEndMode.Items.AddRange(new object[] {
            "Persistent",
            "Driven"});
            this.cbEndMode.Location = new System.Drawing.Point(95, 98);
            this.cbEndMode.Name = "cbEndMode";
            this.cbEndMode.Size = new System.Drawing.Size(93, 21);
            this.cbEndMode.TabIndex = 5;
            // 
            // cbFieldApproach
            // 
            this.cbFieldApproach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFieldApproach.FormattingEnabled = true;
            this.cbFieldApproach.Items.AddRange(new object[] {
            "Linear",
            "No Overshoot",
            "Oscillate"});
            this.cbFieldApproach.Location = new System.Drawing.Point(95, 71);
            this.cbFieldApproach.Name = "cbFieldApproach";
            this.cbFieldApproach.Size = new System.Drawing.Size(93, 21);
            this.cbFieldApproach.TabIndex = 4;
            // 
            // tbFieldRateTarget
            // 
            this.tbFieldRateTarget.Location = new System.Drawing.Point(95, 45);
            this.tbFieldRateTarget.Name = "tbFieldRateTarget";
            this.tbFieldRateTarget.Size = new System.Drawing.Size(93, 20);
            this.tbFieldRateTarget.TabIndex = 3;
            this.tbFieldRateTarget.Text = "100.0";
            // 
            // tbFieldTarget
            // 
            this.tbFieldTarget.Location = new System.Drawing.Point(95, 19);
            this.tbFieldTarget.Name = "tbFieldTarget";
            this.tbFieldTarget.Size = new System.Drawing.Size(93, 20);
            this.tbFieldTarget.TabIndex = 2;
            this.tbFieldTarget.Text = "1000.0";
            // 
            // grpTemperature
            // 
            this.grpTemperature.Controls.Add(this.btnGetTemp);
            this.grpTemperature.Controls.Add(this.Label9);
            this.grpTemperature.Controls.Add(this.Label10);
            this.grpTemperature.Controls.Add(this.tbTempStatusRead);
            this.grpTemperature.Controls.Add(this.tbTempRead);
            this.grpTemperature.Controls.Add(this.Label12);
            this.grpTemperature.Controls.Add(this.Label13);
            this.grpTemperature.Controls.Add(this.Label14);
            this.grpTemperature.Controls.Add(this.btnSetTemp);
            this.grpTemperature.Controls.Add(this.cbTempApproach);
            this.grpTemperature.Controls.Add(this.tbTempRateTarget);
            this.grpTemperature.Controls.Add(this.tbTempTarget);
            this.grpTemperature.Location = new System.Drawing.Point(6, 112);
            this.grpTemperature.Name = "grpTemperature";
            this.grpTemperature.Size = new System.Drawing.Size(400, 131);
            this.grpTemperature.TabIndex = 14;
            this.grpTemperature.TabStop = false;
            this.grpTemperature.Text = "Temperature";
            // 
            // btnGetTemp
            // 
            this.btnGetTemp.Location = new System.Drawing.Point(262, 73);
            this.btnGetTemp.Name = "btnGetTemp";
            this.btnGetTemp.Size = new System.Drawing.Size(99, 23);
            this.btnGetTemp.TabIndex = 13;
            this.btnGetTemp.Text = "Get Temperature";
            this.btnGetTemp.UseVisualStyleBackColor = true;
            this.btnGetTemp.Click += new System.EventHandler(this.btnGetTemp_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(221, 52);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(71, 13);
            this.Label9.TabIndex = 12;
            this.Label9.Text = "Status (Code)";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(240, 26);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(53, 13);
            this.Label10.TabIndex = 11;
            this.Label10.Text = "Temp. (K)";
            // 
            // tbTempStatusRead
            // 
            this.tbTempStatusRead.Location = new System.Drawing.Point(298, 45);
            this.tbTempStatusRead.Name = "tbTempStatusRead";
            this.tbTempStatusRead.ReadOnly = true;
            this.tbTempStatusRead.Size = new System.Drawing.Size(82, 20);
            this.tbTempStatusRead.TabIndex = 10;
            // 
            // tbTempRead
            // 
            this.tbTempRead.Location = new System.Drawing.Point(298, 19);
            this.tbTempRead.Name = "tbTempRead";
            this.tbTempRead.ReadOnly = true;
            this.tbTempRead.Size = new System.Drawing.Size(82, 20);
            this.tbTempRead.TabIndex = 9;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(7, 74);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(83, 13);
            this.Label12.TabIndex = 7;
            this.Label12.Text = "Approach Mode";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(23, 52);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(67, 13);
            this.Label13.TabIndex = 6;
            this.Label13.Text = "Rate (K/min)";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(17, 26);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(72, 13);
            this.Label14.TabIndex = 2;
            this.Label14.Text = "Set Temp. (K)";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSetTemp
            // 
            this.btnSetTemp.Location = new System.Drawing.Point(38, 98);
            this.btnSetTemp.Name = "btnSetTemp";
            this.btnSetTemp.Size = new System.Drawing.Size(101, 23);
            this.btnSetTemp.TabIndex = 2;
            this.btnSetTemp.Text = "Set Temperature";
            this.btnSetTemp.UseVisualStyleBackColor = true;
            this.btnSetTemp.Click += new System.EventHandler(this.btnSetTemp_Click);
            // 
            // cbTempApproach
            // 
            this.cbTempApproach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTempApproach.FormattingEnabled = true;
            this.cbTempApproach.Items.AddRange(new object[] {
            "Fast Settle",
            "No Overshoot"});
            this.cbTempApproach.Location = new System.Drawing.Point(95, 71);
            this.cbTempApproach.Name = "cbTempApproach";
            this.cbTempApproach.Size = new System.Drawing.Size(93, 21);
            this.cbTempApproach.TabIndex = 4;
            // 
            // tbTempRateTarget
            // 
            this.tbTempRateTarget.Location = new System.Drawing.Point(95, 45);
            this.tbTempRateTarget.Name = "tbTempRateTarget";
            this.tbTempRateTarget.Size = new System.Drawing.Size(93, 20);
            this.tbTempRateTarget.TabIndex = 3;
            this.tbTempRateTarget.Text = "10.0";
            // 
            // tbTempTarget
            // 
            this.tbTempTarget.Location = new System.Drawing.Point(95, 19);
            this.tbTempTarget.Name = "tbTempTarget";
            this.tbTempTarget.Size = new System.Drawing.Size(93, 20);
            this.tbTempTarget.TabIndex = 2;
            this.tbTempTarget.Text = "300.0";
            // 
            // grpChamber
            // 
            this.grpChamber.Controls.Add(this.btnGetChamber);
            this.grpChamber.Controls.Add(this.Label11);
            this.grpChamber.Controls.Add(this.tbChamberStatus);
            this.grpChamber.Controls.Add(this.cbChamberSetCode);
            this.grpChamber.Controls.Add(this.Label16);
            this.grpChamber.Controls.Add(this.btnSetChamber);
            this.grpChamber.Location = new System.Drawing.Point(6, 417);
            this.grpChamber.Name = "grpChamber";
            this.grpChamber.Size = new System.Drawing.Size(400, 85);
            this.grpChamber.TabIndex = 15;
            this.grpChamber.TabStop = false;
            this.grpChamber.Text = "Chamber";
            // 
            // btnGetChamber
            // 
            this.btnGetChamber.Location = new System.Drawing.Point(263, 52);
            this.btnGetChamber.Name = "btnGetChamber";
            this.btnGetChamber.Size = new System.Drawing.Size(99, 23);
            this.btnGetChamber.TabIndex = 13;
            this.btnGetChamber.Text = "Get Chamber";
            this.btnGetChamber.UseVisualStyleBackColor = true;
            this.btnGetChamber.Click += new System.EventHandler(this.btnGetChamber_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(222, 28);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(71, 13);
            this.Label11.TabIndex = 12;
            this.Label11.Text = "Status (Code)";
            // 
            // tbChamberStatus
            // 
            this.tbChamberStatus.Location = new System.Drawing.Point(299, 21);
            this.tbChamberStatus.Name = "tbChamberStatus";
            this.tbChamberStatus.ReadOnly = true;
            this.tbChamberStatus.Size = new System.Drawing.Size(82, 20);
            this.tbChamberStatus.TabIndex = 10;
            // 
            // cbChamberSetCode
            // 
            this.cbChamberSetCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChamberSetCode.FormattingEnabled = true;
            this.cbChamberSetCode.Items.AddRange(new object[] {
            "Seal",
            "Purge and Seal",
            "Vent and Seal",
            "Pump Continuous",
            "Vent Continuous",
            "High Vacuum"});
            this.cbChamberSetCode.Location = new System.Drawing.Point(96, 20);
            this.cbChamberSetCode.Name = "cbChamberSetCode";
            this.cbChamberSetCode.Size = new System.Drawing.Size(120, 21);
            this.cbChamberSetCode.TabIndex = 4;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(12, 28);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(77, 13);
            this.Label16.TabIndex = 7;
            this.Label16.Text = "Chamber State";
            // 
            // btnSetChamber
            // 
            this.btnSetChamber.Location = new System.Drawing.Point(37, 52);
            this.btnSetChamber.Name = "btnSetChamber";
            this.btnSetChamber.Size = new System.Drawing.Size(101, 23);
            this.btnSetChamber.TabIndex = 2;
            this.btnSetChamber.Text = "Set Chamber";
            this.btnSetChamber.UseVisualStyleBackColor = true;
            this.btnSetChamber.Click += new System.EventHandler(this.btnSetChamber_Click);
            // 
            // tpPosition
            // 
            this.tpPosition.Controls.Add(this.grpPosition);
            this.tpPosition.Location = new System.Drawing.Point(4, 22);
            this.tpPosition.Name = "tpPosition";
            this.tpPosition.Size = new System.Drawing.Size(418, 516);
            this.tpPosition.TabIndex = 2;
            this.tpPosition.Text = "Position";
            this.tpPosition.UseVisualStyleBackColor = true;
            // 
            // grpPosition
            // 
            this.grpPosition.Controls.Add(this.btnGetPosition);
            this.grpPosition.Controls.Add(this.Label21);
            this.grpPosition.Controls.Add(this.Label22);
            this.grpPosition.Controls.Add(this.tbPositionStatus);
            this.grpPosition.Controls.Add(this.tbReadPosition);
            this.grpPosition.Controls.Add(this.Label25);
            this.grpPosition.Controls.Add(this.Label26);
            this.grpPosition.Controls.Add(this.Label27);
            this.grpPosition.Controls.Add(this.btnSetPosition);
            this.grpPosition.Controls.Add(this.cbPositionMode);
            this.grpPosition.Controls.Add(this.tbSpeed);
            this.grpPosition.Controls.Add(this.tbSetPosition);
            this.grpPosition.Location = new System.Drawing.Point(8, 3);
            this.grpPosition.Name = "grpPosition";
            this.grpPosition.Size = new System.Drawing.Size(400, 149);
            this.grpPosition.TabIndex = 2;
            this.grpPosition.TabStop = false;
            this.grpPosition.Text = "Position";
            // 
            // btnGetPosition
            // 
            this.btnGetPosition.Location = new System.Drawing.Point(273, 73);
            this.btnGetPosition.Name = "btnGetPosition";
            this.btnGetPosition.Size = new System.Drawing.Size(75, 23);
            this.btnGetPosition.TabIndex = 13;
            this.btnGetPosition.Text = "Get Position";
            this.btnGetPosition.UseVisualStyleBackColor = true;
            this.btnGetPosition.Click += new System.EventHandler(this.btnGetPosition_Click);
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(221, 52);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(71, 13);
            this.Label21.TabIndex = 12;
            this.Label21.Text = "Status (Code)";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(221, 26);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(71, 13);
            this.Label22.TabIndex = 11;
            this.Label22.Text = "Position (deg)";
            // 
            // tbPositionStatus
            // 
            this.tbPositionStatus.Location = new System.Drawing.Point(298, 45);
            this.tbPositionStatus.Name = "tbPositionStatus";
            this.tbPositionStatus.ReadOnly = true;
            this.tbPositionStatus.Size = new System.Drawing.Size(82, 20);
            this.tbPositionStatus.TabIndex = 10;
            // 
            // tbReadPosition
            // 
            this.tbReadPosition.Location = new System.Drawing.Point(298, 19);
            this.tbReadPosition.Name = "tbReadPosition";
            this.tbReadPosition.ReadOnly = true;
            this.tbReadPosition.Size = new System.Drawing.Size(82, 20);
            this.tbReadPosition.TabIndex = 9;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(16, 76);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(34, 13);
            this.Label25.TabIndex = 7;
            this.Label25.Text = "Mode";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(12, 52);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(87, 13);
            this.Label26.TabIndex = 6;
            this.Label26.Text = "Speed (deg/sec)";
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(9, 26);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(90, 13);
            this.Label27.TabIndex = 2;
            this.Label27.Text = "Set Position (deg)";
            // 
            // btnSetPosition
            // 
            this.btnSetPosition.Location = new System.Drawing.Point(57, 106);
            this.btnSetPosition.Name = "btnSetPosition";
            this.btnSetPosition.Size = new System.Drawing.Size(75, 23);
            this.btnSetPosition.TabIndex = 2;
            this.btnSetPosition.Text = "Set Position";
            this.btnSetPosition.UseVisualStyleBackColor = true;
            this.btnSetPosition.Click += new System.EventHandler(this.btnSetPosition_Click);
            // 
            // cbPositionMode
            // 
            this.cbPositionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPositionMode.FormattingEnabled = true;
            this.cbPositionMode.Items.AddRange(new object[] {
            "Go to Target",
            "Go to Limit",
            "Define"});
            this.cbPositionMode.Location = new System.Drawing.Point(105, 71);
            this.cbPositionMode.Name = "cbPositionMode";
            this.cbPositionMode.Size = new System.Drawing.Size(93, 21);
            this.cbPositionMode.TabIndex = 4;
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(105, 45);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(93, 20);
            this.tbSpeed.TabIndex = 3;
            this.tbSpeed.Text = "10.0";
            // 
            // tbSetPosition
            // 
            this.tbSetPosition.Location = new System.Drawing.Point(105, 19);
            this.tbSetPosition.Name = "tbSetPosition";
            this.tbSetPosition.Size = new System.Drawing.Size(93, 20);
            this.tbSetPosition.TabIndex = 2;
            this.tbSetPosition.Text = "100.0";
            // 
            // tpSDOAndPPMS
            // 
            this.tpSDOAndPPMS.Controls.Add(this.gbSendPpmsCommand);
            this.tpSDOAndPPMS.Controls.Add(this.grpSDO);
            this.tpSDOAndPPMS.Controls.Add(this.grpPPMSData);
            this.tpSDOAndPPMS.Location = new System.Drawing.Point(4, 22);
            this.tpSDOAndPPMS.Name = "tpSDOAndPPMS";
            this.tpSDOAndPPMS.Padding = new System.Windows.Forms.Padding(3);
            this.tpSDOAndPPMS.Size = new System.Drawing.Size(418, 516);
            this.tpSDOAndPPMS.TabIndex = 1;
            this.tpSDOAndPPMS.Text = "SDO and PPMS Data";
            this.tpSDOAndPPMS.UseVisualStyleBackColor = true;
            // 
            // gbSendPpmsCommand
            // 
            this.gbSendPpmsCommand.Controls.Add(this.Label31);
            this.gbSendPpmsCommand.Controls.Add(this.tbErrorStr);
            this.gbSendPpmsCommand.Controls.Add(this.Label29);
            this.gbSendPpmsCommand.Controls.Add(this.tbReply);
            this.gbSendPpmsCommand.Controls.Add(this.Label28);
            this.gbSendPpmsCommand.Controls.Add(this.btnSendCommand);
            this.gbSendPpmsCommand.Controls.Add(this.tbCommand);
            this.gbSendPpmsCommand.Location = new System.Drawing.Point(8, 199);
            this.gbSendPpmsCommand.Name = "gbSendPpmsCommand";
            this.gbSendPpmsCommand.Size = new System.Drawing.Size(398, 149);
            this.gbSendPpmsCommand.TabIndex = 16;
            this.gbSendPpmsCommand.TabStop = false;
            this.gbSendPpmsCommand.Text = "Send PPMS Command";
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(11, 116);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(62, 13);
            this.Label31.TabIndex = 22;
            this.Label31.Text = "Error String:";
            this.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbErrorStr
            // 
            this.tbErrorStr.Location = new System.Drawing.Point(79, 109);
            this.tbErrorStr.Name = "tbErrorStr";
            this.tbErrorStr.ReadOnly = true;
            this.tbErrorStr.Size = new System.Drawing.Size(299, 20);
            this.tbErrorStr.TabIndex = 21;
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(36, 90);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(37, 13);
            this.Label29.TabIndex = 19;
            this.Label29.Text = "Reply:";
            this.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbReply
            // 
            this.tbReply.Location = new System.Drawing.Point(79, 83);
            this.tbReply.Name = "tbReply";
            this.tbReply.ReadOnly = true;
            this.tbReply.Size = new System.Drawing.Size(299, 20);
            this.tbReply.TabIndex = 17;
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(16, 31);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(57, 13);
            this.Label28.TabIndex = 17;
            this.Label28.Text = "Command:";
            this.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(19, 54);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(101, 23);
            this.btnSendCommand.TabIndex = 16;
            this.btnSendCommand.Text = "Send Command";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(79, 28);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(229, 20);
            this.tbCommand.TabIndex = 16;
            this.tbCommand.Text = "$GETONE? 3";
            // 
            // grpSDO
            // 
            this.grpSDO.Controls.Add(this.tbReadSDO);
            this.grpSDO.Controls.Add(this.Label20);
            this.grpSDO.Controls.Add(this.tbSubindex);
            this.grpSDO.Controls.Add(this.Label18);
            this.grpSDO.Controls.Add(this.Label19);
            this.grpSDO.Controls.Add(this.tbIndex);
            this.grpSDO.Controls.Add(this.Label17);
            this.grpSDO.Controls.Add(this.tbNode);
            this.grpSDO.Controls.Add(this.cbType);
            this.grpSDO.Controls.Add(this.btnReadSDO);
            this.grpSDO.Location = new System.Drawing.Point(6, 6);
            this.grpSDO.Name = "grpSDO";
            this.grpSDO.Size = new System.Drawing.Size(400, 107);
            this.grpSDO.TabIndex = 16;
            this.grpSDO.TabStop = false;
            this.grpSDO.Text = "SDO";
            // 
            // tbReadSDO
            // 
            this.tbReadSDO.Location = new System.Drawing.Point(151, 76);
            this.tbReadSDO.Name = "tbReadSDO";
            this.tbReadSDO.ReadOnly = true;
            this.tbReadSDO.Size = new System.Drawing.Size(229, 20);
            this.tbReadSDO.TabIndex = 14;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(212, 48);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(80, 13);
            this.Label20.TabIndex = 17;
            this.Label20.Text = "Subindex (hex):";
            this.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbSubindex
            // 
            this.tbSubindex.Location = new System.Drawing.Point(298, 45);
            this.tbSubindex.Name = "tbSubindex";
            this.tbSubindex.Size = new System.Drawing.Size(82, 20);
            this.tbSubindex.TabIndex = 16;
            this.tbSubindex.Text = "2";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(29, 48);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(60, 13);
            this.Label18.TabIndex = 15;
            this.Label18.Text = "Data Type:";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(230, 22);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(62, 13);
            this.Label19.TabIndex = 14;
            this.Label19.Text = "Index (hex):";
            this.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(298, 19);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(82, 20);
            this.tbIndex.TabIndex = 13;
            this.tbIndex.Text = "2002";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(53, 22);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(36, 13);
            this.Label17.TabIndex = 12;
            this.Label17.Text = "Node:";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbNode
            // 
            this.tbNode.Location = new System.Drawing.Point(95, 19);
            this.tbNode.Name = "tbNode";
            this.tbNode.Size = new System.Drawing.Size(82, 20);
            this.tbNode.TabIndex = 10;
            this.tbNode.Text = "3";
            // 
            // cbType
            // 
            this.cbType.DropDownHeight = 180;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.IntegralHeight = false;
            this.cbType.Items.AddRange(new object[] {
            "Signed-8",
            "Unsigned-8",
            "Signed-16",
            "Unsigned-16",
            "Signed-32",
            "Unsigned-32",
            "Signed-64",
            "Unsigned-64",
            "Float-32",
            "Float-64",
            "String",
            "Binary"});
            this.cbType.Location = new System.Drawing.Point(95, 45);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(93, 21);
            this.cbType.TabIndex = 4;
            // 
            // btnReadSDO
            // 
            this.btnReadSDO.Location = new System.Drawing.Point(37, 74);
            this.btnReadSDO.Name = "btnReadSDO";
            this.btnReadSDO.Size = new System.Drawing.Size(101, 23);
            this.btnReadSDO.TabIndex = 2;
            this.btnReadSDO.Text = "Read SDO";
            this.btnReadSDO.UseVisualStyleBackColor = true;
            this.btnReadSDO.Click += new System.EventHandler(this.btnReadSDO_Click);
            // 
            // grpPPMSData
            // 
            this.grpPPMSData.Controls.Add(this.cbFast);
            this.grpPPMSData.Controls.Add(this.tbPPMSData);
            this.grpPPMSData.Controls.Add(this.Label24);
            this.grpPPMSData.Controls.Add(this.tbChannel);
            this.grpPPMSData.Controls.Add(this.btnReadPPMSData);
            this.grpPPMSData.Location = new System.Drawing.Point(6, 119);
            this.grpPPMSData.Name = "grpPPMSData";
            this.grpPPMSData.Size = new System.Drawing.Size(400, 74);
            this.grpPPMSData.TabIndex = 18;
            this.grpPPMSData.TabStop = false;
            this.grpPPMSData.Text = "PPMS Data";
            // 
            // cbFast
            // 
            this.cbFast.AutoSize = true;
            this.cbFast.Checked = true;
            this.cbFast.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFast.Location = new System.Drawing.Point(215, 21);
            this.cbFast.Name = "cbFast";
            this.cbFast.Size = new System.Drawing.Size(46, 17);
            this.cbFast.TabIndex = 15;
            this.cbFast.Text = "Fast";
            this.cbFast.UseVisualStyleBackColor = true;
            // 
            // tbPPMSData
            // 
            this.tbPPMSData.Location = new System.Drawing.Point(151, 47);
            this.tbPPMSData.Name = "tbPPMSData";
            this.tbPPMSData.ReadOnly = true;
            this.tbPPMSData.Size = new System.Drawing.Size(170, 20);
            this.tbPPMSData.TabIndex = 14;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(44, 22);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(46, 13);
            this.Label24.TabIndex = 12;
            this.Label24.Text = "Channel";
            this.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbChannel
            // 
            this.tbChannel.Location = new System.Drawing.Point(95, 19);
            this.tbChannel.Name = "tbChannel";
            this.tbChannel.Size = new System.Drawing.Size(82, 20);
            this.tbChannel.TabIndex = 10;
            this.tbChannel.Text = "1";
            // 
            // btnReadPPMSData
            // 
            this.btnReadPPMSData.Location = new System.Drawing.Point(38, 45);
            this.btnReadPPMSData.Name = "btnReadPPMSData";
            this.btnReadPPMSData.Size = new System.Drawing.Size(101, 23);
            this.btnReadPPMSData.TabIndex = 2;
            this.btnReadPPMSData.Text = "Read Data";
            this.btnReadPPMSData.UseVisualStyleBackColor = true;
            this.btnReadPPMSData.Click += new System.EventHandler(this.btnReadPPMSData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 542);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "QDInstrument Example";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl1.ResumeLayout(false);
            this.tpBasic.ResumeLayout(false);
            this.gbInstrument.ResumeLayout(false);
            this.gbInstrument.PerformLayout();
            this.grpField.ResumeLayout(false);
            this.grpField.PerformLayout();
            this.grpTemperature.ResumeLayout(false);
            this.grpTemperature.PerformLayout();
            this.grpChamber.ResumeLayout(false);
            this.grpChamber.PerformLayout();
            this.tpPosition.ResumeLayout(false);
            this.grpPosition.ResumeLayout(false);
            this.grpPosition.PerformLayout();
            this.tpSDOAndPPMS.ResumeLayout(false);
            this.gbSendPpmsCommand.ResumeLayout(false);
            this.gbSendPpmsCommand.PerformLayout();
            this.grpSDO.ResumeLayout(false);
            this.grpSDO.PerformLayout();
            this.grpPPMSData.ResumeLayout(false);
            this.grpPPMSData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage tpBasic;
        internal System.Windows.Forms.GroupBox gbInstrument;
        internal System.Windows.Forms.Button btnSetLocalHost;
        internal System.Windows.Forms.CheckBox cbRemote;
        internal System.Windows.Forms.Button btnConnect;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox tbIPAddress;
        internal System.Windows.Forms.GroupBox grpField;
        internal System.Windows.Forms.Button btnGetField;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox tbFieldStatusRead;
        internal System.Windows.Forms.TextBox tbFieldRead;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnSetField;
        internal System.Windows.Forms.ComboBox cbEndMode;
        internal System.Windows.Forms.ComboBox cbFieldApproach;
        internal System.Windows.Forms.TextBox tbFieldRateTarget;
        internal System.Windows.Forms.TextBox tbFieldTarget;
        internal System.Windows.Forms.GroupBox grpTemperature;
        internal System.Windows.Forms.Button btnGetTemp;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox tbTempStatusRead;
        internal System.Windows.Forms.TextBox tbTempRead;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Button btnSetTemp;
        internal System.Windows.Forms.ComboBox cbTempApproach;
        internal System.Windows.Forms.TextBox tbTempRateTarget;
        internal System.Windows.Forms.TextBox tbTempTarget;
        internal System.Windows.Forms.GroupBox grpChamber;
        internal System.Windows.Forms.Button btnGetChamber;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox tbChamberStatus;
        internal System.Windows.Forms.ComboBox cbChamberSetCode;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Button btnSetChamber;
        internal System.Windows.Forms.TabPage tpPosition;
        internal System.Windows.Forms.GroupBox grpPosition;
        internal System.Windows.Forms.Button btnGetPosition;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.TextBox tbPositionStatus;
        internal System.Windows.Forms.TextBox tbReadPosition;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.Button btnSetPosition;
        internal System.Windows.Forms.ComboBox cbPositionMode;
        internal System.Windows.Forms.TextBox tbSpeed;
        internal System.Windows.Forms.TextBox tbSetPosition;
        internal System.Windows.Forms.TabPage tpSDOAndPPMS;
        internal System.Windows.Forms.GroupBox gbSendPpmsCommand;
        internal System.Windows.Forms.Label Label31;
        internal System.Windows.Forms.TextBox tbErrorStr;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.TextBox tbReply;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.Button btnSendCommand;
        internal System.Windows.Forms.TextBox tbCommand;
        internal System.Windows.Forms.GroupBox grpSDO;
        internal System.Windows.Forms.TextBox tbReadSDO;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.TextBox tbSubindex;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.TextBox tbIndex;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.TextBox tbNode;
        internal System.Windows.Forms.ComboBox cbType;
        internal System.Windows.Forms.Button btnReadSDO;
        internal System.Windows.Forms.GroupBox grpPPMSData;
        internal System.Windows.Forms.CheckBox cbFast;
        internal System.Windows.Forms.TextBox tbPPMSData;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox tbChannel;
        internal System.Windows.Forms.Button btnReadPPMSData;
    }
}

