﻿namespace LaserGRBL
{
	partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.MainTabPage = new System.Windows.Forms.TabControl();
            this.TpHardware = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CBCore = new System.Windows.Forms.ComboBox();
            this.CbThreadingMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBStreamingMode = new System.Windows.Forms.ComboBox();
            this.BtnStreamingMode = new LaserGRBL.UserControls.ImageButton();
            this.CBProtocol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnProtocol = new LaserGRBL.UserControls.ImageButton();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnThreadingModel = new LaserGRBL.UserControls.ImageButton();
            this.CbIssueDetector = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbSoftReset = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbHardReset = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TpRasterImport = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CbUnidirectional = new System.Windows.Forms.CheckBox();
            this.CBSupportPWM = new System.Windows.Forms.CheckBox();
            this.BtnModulationInfo = new LaserGRBL.UserControls.ImageButton();
            this.TpJogControl = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CbEnableZJog = new System.Windows.Forms.CheckBox();
            this.CbContinuosJog = new System.Windows.Forms.CheckBox();
            this.CbPlotter = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.MainTabPage.SuspendLayout();
            this.TpHardware.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.TpRasterImport.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.TpJogControl.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MainTabPage, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.BtnCancel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnSave, 2, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BtnCancel, "BtnCancel");
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            resources.ApplyResources(this.BtnSave, "BtnSave");
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // MainTabPage
            // 
            this.MainTabPage.Controls.Add(this.TpHardware);
            this.MainTabPage.Controls.Add(this.TpRasterImport);
            this.MainTabPage.Controls.Add(this.TpJogControl);
            resources.ApplyResources(this.MainTabPage, "MainTabPage");
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.SelectedIndex = 0;
            // 
            // TpHardware
            // 
            this.TpHardware.Controls.Add(this.tableLayoutPanel3);
            resources.ApplyResources(this.TpHardware, "TpHardware");
            this.TpHardware.Name = "TpHardware";
            this.TpHardware.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.CBCore, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.CbThreadingMode, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.CBStreamingMode, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.BtnStreamingMode, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.CBProtocol, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.BtnProtocol, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.BtnThreadingModel, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.CbIssueDetector, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label7, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.CbSoftReset, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.CbHardReset, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label8, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // CBCore
            // 
            resources.ApplyResources(this.CBCore, "CBCore");
            this.CBCore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCore.FormattingEnabled = true;
            this.CBCore.Name = "CBCore";
            // 
            // CbThreadingMode
            // 
            resources.ApplyResources(this.CbThreadingMode, "CbThreadingMode");
            this.CbThreadingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbThreadingMode.FormattingEnabled = true;
            this.CbThreadingMode.Name = "CbThreadingMode";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // CBStreamingMode
            // 
            resources.ApplyResources(this.CBStreamingMode, "CBStreamingMode");
            this.CBStreamingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStreamingMode.FormattingEnabled = true;
            this.CBStreamingMode.Name = "CBStreamingMode";
            // 
            // BtnStreamingMode
            // 
            this.BtnStreamingMode.AltImage = null;
            this.BtnStreamingMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnStreamingMode.Coloration = System.Drawing.Color.Empty;
            this.BtnStreamingMode.Image = ((System.Drawing.Image)(resources.GetObject("BtnStreamingMode.Image")));
            resources.ApplyResources(this.BtnStreamingMode, "BtnStreamingMode");
            this.BtnStreamingMode.Name = "BtnStreamingMode";
            this.BtnStreamingMode.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.BtnStreamingMode.UseAltImage = false;
            this.BtnStreamingMode.Click += new System.EventHandler(this.BtnStreamingMode_Click);
            // 
            // CBProtocol
            // 
            resources.ApplyResources(this.CBProtocol, "CBProtocol");
            this.CBProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBProtocol.FormattingEnabled = true;
            this.CBProtocol.Name = "CBProtocol";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // BtnProtocol
            // 
            this.BtnProtocol.AltImage = null;
            this.BtnProtocol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnProtocol.Coloration = System.Drawing.Color.Empty;
            this.BtnProtocol.Image = ((System.Drawing.Image)(resources.GetObject("BtnProtocol.Image")));
            resources.ApplyResources(this.BtnProtocol, "BtnProtocol");
            this.BtnProtocol.Name = "BtnProtocol";
            this.BtnProtocol.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.BtnProtocol.UseAltImage = false;
            this.BtnProtocol.Click += new System.EventHandler(this.BtnProtocol_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // BtnThreadingModel
            // 
            this.BtnThreadingModel.AltImage = null;
            this.BtnThreadingModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnThreadingModel.Coloration = System.Drawing.Color.Empty;
            this.BtnThreadingModel.Image = ((System.Drawing.Image)(resources.GetObject("BtnThreadingModel.Image")));
            resources.ApplyResources(this.BtnThreadingModel, "BtnThreadingModel");
            this.BtnThreadingModel.Name = "BtnThreadingModel";
            this.BtnThreadingModel.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.BtnThreadingModel.UseAltImage = false;
            this.BtnThreadingModel.Click += new System.EventHandler(this.BtnThreadingModel_Click);
            // 
            // CbIssueDetector
            // 
            resources.ApplyResources(this.CbIssueDetector, "CbIssueDetector");
            this.CbIssueDetector.Name = "CbIssueDetector";
            this.CbIssueDetector.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // CbSoftReset
            // 
            resources.ApplyResources(this.CbSoftReset, "CbSoftReset");
            this.CbSoftReset.Name = "CbSoftReset";
            this.CbSoftReset.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // CbHardReset
            // 
            resources.ApplyResources(this.CbHardReset, "CbHardReset");
            this.CbHardReset.Name = "CbHardReset";
            this.CbHardReset.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // TpRasterImport
            // 
            this.TpRasterImport.Controls.Add(this.tableLayoutPanel4);
            resources.ApplyResources(this.TpRasterImport, "TpRasterImport");
            this.TpRasterImport.Name = "TpRasterImport";
            this.TpRasterImport.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.CbUnidirectional, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.CBSupportPWM, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnModulationInfo, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.CbPlotter, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label12, 2, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // CbUnidirectional
            // 
            resources.ApplyResources(this.CbUnidirectional, "CbUnidirectional");
            this.CbUnidirectional.Name = "CbUnidirectional";
            this.CbUnidirectional.UseVisualStyleBackColor = true;
            // 
            // CBSupportPWM
            // 
            resources.ApplyResources(this.CBSupportPWM, "CBSupportPWM");
            this.CBSupportPWM.Name = "CBSupportPWM";
            this.CBSupportPWM.UseVisualStyleBackColor = true;
            // 
            // BtnModulationInfo
            // 
            this.BtnModulationInfo.AltImage = null;
            this.BtnModulationInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnModulationInfo.Coloration = System.Drawing.Color.Empty;
            this.BtnModulationInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnModulationInfo.Image")));
            resources.ApplyResources(this.BtnModulationInfo, "BtnModulationInfo");
            this.BtnModulationInfo.Name = "BtnModulationInfo";
            this.BtnModulationInfo.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.BtnModulationInfo.UseAltImage = false;
            this.BtnModulationInfo.Click += new System.EventHandler(this.BtnModulationInfo_Click);
            // 
            // TpJogControl
            // 
            this.TpJogControl.Controls.Add(this.tableLayoutPanel5);
            resources.ApplyResources(this.TpJogControl, "TpJogControl");
            this.TpJogControl.Name = "TpJogControl";
            this.TpJogControl.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label11, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.CbEnableZJog, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.CbContinuosJog, 1, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // CbEnableZJog
            // 
            resources.ApplyResources(this.CbEnableZJog, "CbEnableZJog");
            this.CbEnableZJog.Name = "CbEnableZJog";
            this.CbEnableZJog.UseVisualStyleBackColor = true;
            // 
            // CbContinuosJog
            // 
            resources.ApplyResources(this.CbContinuosJog, "CbContinuosJog");
            this.CbContinuosJog.Name = "CbContinuosJog";
            this.CbContinuosJog.UseVisualStyleBackColor = true;
            // 
            // CBPlotter
            // 
            resources.ApplyResources(this.CbPlotter, "CBPlotter");
            this.CbPlotter.Name = "CBPlotter";
            this.CbPlotter.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.MainTabPage.ResumeLayout(false);
            this.TpHardware.ResumeLayout(false);
            this.TpHardware.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.TpRasterImport.ResumeLayout(false);
            this.TpRasterImport.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.TpJogControl.ResumeLayout(false);
            this.TpJogControl.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.CheckBox CBSupportPWM;
		private System.Windows.Forms.Label label1;
		private UserControls.ImageButton BtnModulationInfo;
		private System.Windows.Forms.ComboBox CBProtocol;
		private System.Windows.Forms.Label label3;
		private UserControls.ImageButton BtnProtocol;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox CBStreamingMode;
		private UserControls.ImageButton BtnStreamingMode;
		private System.Windows.Forms.CheckBox CbUnidirectional;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox CbThreadingMode;
		private System.Windows.Forms.Label label6;
		private UserControls.ImageButton BtnThreadingModel;
		private System.Windows.Forms.CheckBox CbIssueDetector;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox CbSoftReset;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox CbHardReset;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TabControl MainTabPage;
		private System.Windows.Forms.TabPage TpHardware;
		private System.Windows.Forms.TabPage TpRasterImport;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox CBCore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage TpJogControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox CbEnableZJog;
        private System.Windows.Forms.CheckBox CbContinuosJog;
        private System.Windows.Forms.CheckBox CbPlotter;
        private System.Windows.Forms.Label label12;
    }
}