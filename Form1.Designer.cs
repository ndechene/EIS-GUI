﻿namespace PSSDKPlotEISExample
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnMeasure = new System.Windows.Forms.Button();
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.grpDevice = new System.Windows.Forms.GroupBox();
            this.lbOrgan = new System.Windows.Forms.Label();
            this.tbOrgan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDeviceStatus = new System.Windows.Forms.TextBox();
            this.lblCurrentRange = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.lblVolt = new System.Windows.Forms.Label();
            this.tbPotential = new System.Windows.Forms.TextBox();
            this.lblPotential = new System.Windows.Forms.Label();
            this.grpMeasurement = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.plotBode = new SDKPlot.WinForms.Plot();
            this.plot = new SDKPlot.WinForms.Plot();
            this.grpConsole = new System.Windows.Forms.GroupBox();
            this.lbConsole = new System.Windows.Forms.ListBox();
            this.psCommSimpleWinForms = new PalmSens.Core.Simplified.WinForms.PSCommSimpleWinForms(this.components);
            this.grpConnection.SuspendLayout();
            this.grpDevice.SuspendLayout();
            this.grpMeasurement.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDevices
            // 
            this.cmbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(6, 19);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(155, 21);
            this.cmbDevices.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 46);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(86, 46);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnMeasure
            // 
            this.btnMeasure.Enabled = false;
            this.btnMeasure.Location = new System.Drawing.Point(6, 19);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(75, 23);
            this.btnMeasure.TabIndex = 3;
            this.btnMeasure.Text = "Measure";
            this.btnMeasure.UseVisualStyleBackColor = true;
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // grpConnection
            // 
            this.grpConnection.Controls.Add(this.cmbDevices);
            this.grpConnection.Controls.Add(this.btnRefresh);
            this.grpConnection.Controls.Add(this.btnConnect);
            this.grpConnection.Location = new System.Drawing.Point(12, 10);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(171, 79);
            this.grpConnection.TabIndex = 4;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "Connection";
            // 
            // grpDevice
            // 
            this.grpDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDevice.Controls.Add(this.lbOrgan);
            this.grpDevice.Controls.Add(this.tbOrgan);
            this.grpDevice.Controls.Add(this.label1);
            this.grpDevice.Controls.Add(this.tbDeviceStatus);
            this.grpDevice.Controls.Add(this.lblCurrentRange);
            this.grpDevice.Controls.Add(this.lblCurrent);
            this.grpDevice.Controls.Add(this.tbCurrent);
            this.grpDevice.Controls.Add(this.lblVolt);
            this.grpDevice.Controls.Add(this.tbPotential);
            this.grpDevice.Controls.Add(this.lblPotential);
            this.grpDevice.Location = new System.Drawing.Point(190, 10);
            this.grpDevice.Name = "grpDevice";
            this.grpDevice.Size = new System.Drawing.Size(814, 79);
            this.grpDevice.TabIndex = 5;
            this.grpDevice.TabStop = false;
            this.grpDevice.Text = "Device Status";
            // 
            // lbOrgan
            // 
            this.lbOrgan.AutoSize = true;
            this.lbOrgan.Location = new System.Drawing.Point(381, 19);
            this.lbOrgan.Name = "lbOrgan";
            this.lbOrgan.Size = new System.Drawing.Size(39, 13);
            this.lbOrgan.TabIndex = 9;
            this.lbOrgan.Text = "Organ:";
            this.lbOrgan.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbOrgan
            // 
            this.tbOrgan.Location = new System.Drawing.Point(426, 19);
            this.tbOrgan.Multiline = true;
            this.tbOrgan.Name = "tbOrgan";
            this.tbOrgan.ReadOnly = true;
            this.tbOrgan.Size = new System.Drawing.Size(230, 46);
            this.tbOrgan.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Status:";
            // 
            // tbDeviceStatus
            // 
            this.tbDeviceStatus.Location = new System.Drawing.Point(192, 45);
            this.tbDeviceStatus.Name = "tbDeviceStatus";
            this.tbDeviceStatus.ReadOnly = true;
            this.tbDeviceStatus.Size = new System.Drawing.Size(98, 20);
            this.tbDeviceStatus.TabIndex = 6;
            // 
            // lblCurrentRange
            // 
            this.lblCurrentRange.AutoSize = true;
            this.lblCurrentRange.Location = new System.Drawing.Point(140, 48);
            this.lblCurrentRange.Name = "lblCurrentRange";
            this.lblCurrentRange.Size = new System.Drawing.Size(44, 13);
            this.lblCurrentRange.TabIndex = 5;
            this.lblCurrentRange.Text = "* 10 mA";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(7, 48);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(44, 13);
            this.lblCurrent.TabIndex = 4;
            this.lblCurrent.Text = "Current:";
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(64, 45);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.ReadOnly = true;
            this.tbCurrent.Size = new System.Drawing.Size(70, 20);
            this.tbCurrent.TabIndex = 3;
            // 
            // lblVolt
            // 
            this.lblVolt.AutoSize = true;
            this.lblVolt.Location = new System.Drawing.Point(140, 22);
            this.lblVolt.Name = "lblVolt";
            this.lblVolt.Size = new System.Drawing.Size(14, 13);
            this.lblVolt.TabIndex = 2;
            this.lblVolt.Text = "V";
            // 
            // tbPotential
            // 
            this.tbPotential.Location = new System.Drawing.Point(64, 19);
            this.tbPotential.Name = "tbPotential";
            this.tbPotential.ReadOnly = true;
            this.tbPotential.Size = new System.Drawing.Size(70, 20);
            this.tbPotential.TabIndex = 1;
            // 
            // lblPotential
            // 
            this.lblPotential.AutoSize = true;
            this.lblPotential.Location = new System.Drawing.Point(7, 22);
            this.lblPotential.Name = "lblPotential";
            this.lblPotential.Size = new System.Drawing.Size(51, 13);
            this.lblPotential.TabIndex = 0;
            this.lblPotential.Text = "Potential:";
            // 
            // grpMeasurement
            // 
            this.grpMeasurement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMeasurement.Controls.Add(this.tableLayoutPanel1);
            this.grpMeasurement.Controls.Add(this.btnMeasure);
            this.grpMeasurement.Location = new System.Drawing.Point(190, 96);
            this.grpMeasurement.Name = "grpMeasurement";
            this.grpMeasurement.Size = new System.Drawing.Size(814, 373);
            this.grpMeasurement.TabIndex = 6;
            this.grpMeasurement.TabStop = false;
            this.grpMeasurement.Text = "Measurement";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.plotBode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.plot, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 319);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // plotBode
            // 
            this.plotBode.BackColor = System.Drawing.Color.White;
            this.plotBode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotBode.Location = new System.Drawing.Point(3, 3);
            this.plotBode.MarkerSize = 5;
            this.plotBode.MarkerType = OxyPlot.MarkerType.Circle;
            this.plotBode.Name = "plotBode";
            this.plotBode.Size = new System.Drawing.Size(796, 313);
            this.plotBode.TabIndex = 5;
            this.plotBode.Title = null;
            this.plotBode.XAxisLabel = null;
            this.plotBode.XAxisType = SDKPlot.AxisType.Linear;
            this.plotBode.YAxisLabel = null;
            this.plotBode.YAxisSecondaryLabel = null;
            this.plotBode.YAxisSecondaryType = SDKPlot.AxisType.Linear;
            this.plotBode.YAxisType = SDKPlot.AxisType.Linear;
            // 
            // plot
            // 
            this.plot.BackColor = System.Drawing.Color.White;
            this.plot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plot.Location = new System.Drawing.Point(3, 3);
            this.plot.MarkerSize = 5;
            this.plot.MarkerType = OxyPlot.MarkerType.Circle;
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(1, 313);
            this.plot.TabIndex = 4;
            this.plot.Title = null;
            this.plot.XAxisLabel = null;
            this.plot.XAxisType = SDKPlot.AxisType.Linear;
            this.plot.YAxisLabel = null;
            this.plot.YAxisSecondaryLabel = null;
            this.plot.YAxisSecondaryType = SDKPlot.AxisType.Linear;
            this.plot.YAxisType = SDKPlot.AxisType.Linear;
            // 
            // grpConsole
            // 
            this.grpConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpConsole.Controls.Add(this.lbConsole);
            this.grpConsole.Location = new System.Drawing.Point(12, 96);
            this.grpConsole.Name = "grpConsole";
            this.grpConsole.Size = new System.Drawing.Size(172, 373);
            this.grpConsole.TabIndex = 7;
            this.grpConsole.TabStop = false;
            this.grpConsole.Text = "Console";
            // 
            // lbConsole
            // 
            this.lbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbConsole.FormattingEnabled = true;
            this.lbConsole.Location = new System.Drawing.Point(7, 19);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.Size = new System.Drawing.Size(154, 342);
            this.lbConsole.TabIndex = 0;
            // 
            // psCommSimpleWinForms
            // 
            this.psCommSimpleWinForms.EnableBluetooth = false;
            this.psCommSimpleWinForms.EnableSerialPort = false;
            this.psCommSimpleWinForms.Parent = this;
            this.psCommSimpleWinForms.ReceiveStatus += new PalmSens.Comm.StatusEventHandler(this.psCommSimpleWinForms_ReceiveStatus);
            this.psCommSimpleWinForms.MeasurementStarted += new System.EventHandler(this.psCommSimpleWinForms_MeasurementStarted);
            this.psCommSimpleWinForms.MeasurementEnded += new System.EventHandler<System.Exception>(this.psCommSimpleWinForms_MeasurementEnded);
            this.psCommSimpleWinForms.SimpleCurveStartReceivingData += new PalmSens.Core.Simplified.PSCommSimple.SimpleCurveStartReceivingDataHandler(this.psCommSimpleWinForms_SimpleCurveStartReceivingData);
            this.psCommSimpleWinForms.StateChanged += new PalmSens.Comm.CommManager.StatusChangedEventHandler(this.psCommSimpleWinForms_StateChanged);
            this.psCommSimpleWinForms.Disconnected += new PalmSens.Core.Simplified.DisconnectedEventHandler(this.psCommSimpleWinForms_Disconnected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 481);
            this.Controls.Add(this.grpConsole);
            this.Controls.Add(this.grpMeasurement);
            this.Controls.Add(this.grpDevice);
            this.Controls.Add(this.grpConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpConnection.ResumeLayout(false);
            this.grpDevice.ResumeLayout(false);
            this.grpDevice.PerformLayout();
            this.grpMeasurement.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpConsole.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PalmSens.Core.Simplified.WinForms.PSCommSimpleWinForms psCommSimpleWinForms;
        private System.Windows.Forms.Button btnMeasure;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.GroupBox grpDevice;
        private System.Windows.Forms.GroupBox grpMeasurement;
        private System.Windows.Forms.GroupBox grpConsole;
        private System.Windows.Forms.ListBox lbConsole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDeviceStatus;
        private System.Windows.Forms.Label lblCurrentRange;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.Label lblVolt;
        private System.Windows.Forms.TextBox tbPotential;
        private System.Windows.Forms.Label lblPotential;
        private SDKPlot.WinForms.Plot plot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SDKPlot.WinForms.Plot plotBode;
        private System.Windows.Forms.Label lbOrgan;
        private System.Windows.Forms.TextBox tbOrgan;
    }
}

