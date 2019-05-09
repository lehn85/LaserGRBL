﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaserGRBL
{
	public partial class SettingsForm : Form
	{
        private GrblCore Core;
        public static event EventHandler SettingsChanged;

		public SettingsForm(GrblCore core)
		{
			InitializeComponent();

            this.Core = core;

            //BackColor = ColorScheme.FormBackColor;
            //ForeColor = ColorScheme.FormForeColor;
            //TpRasterImport.BackColor = TpHardware.BackColor = BtnCancel.BackColor = BtnSave.BackColor = ColorScheme.FormButtonsColor;

            InitCoreCB();
			InitProtocolCB();
			InitStreamingCB();
			InitThreadingCB();

            CBCore.SelectedItem = (Firmware)Settings.GetObject("Firmware Type", Firmware.Grbl);
			CBSupportPWM.Checked = (bool)Settings.GetObject("Support Hardware PWM", true);
			CBProtocol.SelectedItem = Settings.GetObject("ComWrapper Protocol", ComWrapper.WrapperType.UsbSerial);
			CBStreamingMode.SelectedItem = Settings.GetObject("Streaming Mode", GrblCore.StreamingMode.Buffered);
			CbUnidirectional.Checked = (bool)Settings.GetObject("Unidirectional Engraving", false);
			CbThreadingMode.SelectedItem = Settings.GetObject("Threading Mode", GrblCore.ThreadingMode.UltraFast);
			CbIssueDetector.Checked = !(bool)Settings.GetObject("Do not show Issue Detector", false);
			CbSoftReset.Checked = (bool)Settings.GetObject("Reset Grbl On Connect", true);
			CbHardReset.Checked = (bool)Settings.GetObject("HardReset Grbl On Connect", false);

            CbContinuosJog.Checked = (bool)Settings.GetObject("Enable Continuous Jog", false);
            CbEnableZJog.Checked = (bool)Settings.GetObject("Enale Z Jog Control", false);

            CbPlotter.Checked = (bool)Settings.GetObject("Plotter", false);
            tbPenUpCmd.Text = (string)Settings.GetObject("Plotter.PenUpCmd", "M3 S0");
            tbPenDownCmd.Text = (string)Settings.GetObject("Plotter.PenDownCmd", "M3 S200");
        }

        private void InitCoreCB()
        {
            CBCore.BeginUpdate();
            CBCore.Items.Add(Firmware.Grbl);
            CBCore.Items.Add(Firmware.Smoothie);
            CBCore.EndUpdate();
        }

        private void InitThreadingCB()
		{
			CbThreadingMode.BeginUpdate();
			CbThreadingMode.Items.Add(GrblCore.ThreadingMode.Insane);
			CbThreadingMode.Items.Add(GrblCore.ThreadingMode.UltraFast);
			CbThreadingMode.Items.Add(GrblCore.ThreadingMode.Fast);
			CbThreadingMode.Items.Add(GrblCore.ThreadingMode.Quiet);
			CbThreadingMode.Items.Add(GrblCore.ThreadingMode.Slow);
			CbThreadingMode.EndUpdate();
		}

		private void InitProtocolCB()
		{
			CBProtocol.BeginUpdate();
			CBProtocol.Items.Add(ComWrapper.WrapperType.UsbSerial);
			CBProtocol.Items.Add(ComWrapper.WrapperType.Telnet);
			CBProtocol.Items.Add(ComWrapper.WrapperType.LaserWebESP8266);
			CBProtocol.Items.Add(ComWrapper.WrapperType.Emulator);
			CBProtocol.EndUpdate();
		}

		private void InitStreamingCB()
		{
			CBStreamingMode.BeginUpdate();
			CBStreamingMode.Items.Add(GrblCore.StreamingMode.Buffered);
			CBStreamingMode.Items.Add(GrblCore.StreamingMode.Synchronous);
			CBStreamingMode.Items.Add(GrblCore.StreamingMode.RepeatOnError);
			CBStreamingMode.EndUpdate();
		}

		internal static void CreateAndShowDialog(GrblCore core)
		{
			using (SettingsForm sf = new SettingsForm(core))
				sf.ShowDialog();
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
            Settings.SetObject("Firmware Type", CBCore.SelectedItem);
            Settings.SetObject("Support Hardware PWM", CBSupportPWM.Checked);
			Settings.SetObject("ComWrapper Protocol", CBProtocol.SelectedItem);
			Settings.SetObject("Streaming Mode", CBStreamingMode.SelectedItem);
			Settings.SetObject("Unidirectional Engraving", CbUnidirectional.Checked);
			Settings.SetObject("Threading Mode", CbThreadingMode.SelectedItem);
			Settings.SetObject("Do not show Issue Detector", !CbIssueDetector.Checked);
			Settings.SetObject("Reset Grbl On Connect", CbSoftReset.Checked);
			Settings.SetObject("HardReset Grbl On Connect", CbHardReset.Checked);
            Settings.SetObject("Enable Continuous Jog", CbContinuosJog.Checked);
            Settings.SetObject("Enale Z Jog Control", CbEnableZJog.Checked);
            Settings.SetObject("Plotter", CbPlotter.Checked);
            Settings.SetObject("Plotter.PenUpCmd", tbPenUpCmd.Text);
            Settings.SetObject("Plotter.PenDownCmd", tbPenDownCmd.Text);
            Settings.Save();

            if (SettingsChanged != null)
                SettingsChanged(this, null);

            Close();

            if (Core.Type != (Firmware)Settings.GetObject("Firmware Type", Firmware.Grbl) && MessageBox.Show(Strings.FirmwareRequireRestartNow, Strings.FirmwareRequireRestart, MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Restart();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BtnModulationInfo_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"http://lasergrbl.com/configuration/#pwm-support");
		}

		private void BtnLaserMode_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"http://lasergrbl.com/configuration/#laser-mode");
		}

		private void BtnProtocol_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"http://lasergrbl.com/configuration/#protocol");
		}

		private void BtnStreamingMode_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"http://lasergrbl.com/configuration/#streaming-mode");
		}

		private void BtnThreadingModel_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"http://lasergrbl.com/configuration/#threading-mode");
		}
    }
}
