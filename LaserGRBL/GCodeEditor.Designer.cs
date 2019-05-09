namespace LaserGRBL
{
    partial class GCodeEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCodeEditor));
            this.fCTBCode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.cmsCode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditorHotkeys = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsCodeSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCodeCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCodePaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsFindDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsReplaceDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsCodeSendLine = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCommentOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsUpdate2DView = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fCTBCode)).BeginInit();
            this.cmsCode.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fCTBCode
            // 
            this.fCTBCode.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fCTBCode.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fCTBCode.BackBrush = null;
            this.fCTBCode.CharHeight = 14;
            this.fCTBCode.CharWidth = 8;
            this.fCTBCode.ContextMenuStrip = this.cmsCode;
            this.fCTBCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fCTBCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fCTBCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fCTBCode.IsReplaceMode = false;
            this.fCTBCode.Location = new System.Drawing.Point(3, 39);
            this.fCTBCode.Name = "fCTBCode";
            this.fCTBCode.Paddings = new System.Windows.Forms.Padding(0);
            this.fCTBCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fCTBCode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fCTBCode.ServiceColors")));
            this.fCTBCode.Size = new System.Drawing.Size(735, 424);
            this.fCTBCode.TabIndex = 0;
            this.fCTBCode.Zoom = 100;
            this.fCTBCode.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fCTBCode_TextChanged);
            // 
            // cmsCode
            // 
            this.cmsCode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditorHotkeys,
            this.toolStripSeparator11,
            this.cmsCodeSelect,
            this.cmsCodeCopy,
            this.cmsCodePaste,
            this.toolStripSeparator14,
            this.cmsFindDialog,
            this.cmsReplaceDialog,
            this.toolStripSeparator12,
            this.cmsCodeSendLine,
            this.cmsCommentOut,
            this.toolStripSeparator13,
            this.cmsUpdate2DView});
            this.cmsCode.Name = "cmsCode";
            this.cmsCode.ShowImageMargin = false;
            this.cmsCode.Size = new System.Drawing.Size(217, 226);
            this.cmsCode.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsCode_ItemClicked);
            // 
            // cmsEditorHotkeys
            // 
            this.cmsEditorHotkeys.Name = "cmsEditorHotkeys";
            this.cmsEditorHotkeys.Size = new System.Drawing.Size(216, 22);
            this.cmsEditorHotkeys.Text = "Editor hotkeys";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(213, 6);
            // 
            // cmsCodeSelect
            // 
            this.cmsCodeSelect.Name = "cmsCodeSelect";
            this.cmsCodeSelect.Size = new System.Drawing.Size(216, 22);
            this.cmsCodeSelect.Text = "Select All";
            // 
            // cmsCodeCopy
            // 
            this.cmsCodeCopy.Name = "cmsCodeCopy";
            this.cmsCodeCopy.Size = new System.Drawing.Size(216, 22);
            this.cmsCodeCopy.Text = "Copy to clipboard";
            // 
            // cmsCodePaste
            // 
            this.cmsCodePaste.Name = "cmsCodePaste";
            this.cmsCodePaste.Size = new System.Drawing.Size(216, 22);
            this.cmsCodePaste.Text = "Paste from clipboard";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(213, 6);
            // 
            // cmsFindDialog
            // 
            this.cmsFindDialog.Name = "cmsFindDialog";
            this.cmsFindDialog.Size = new System.Drawing.Size(216, 22);
            this.cmsFindDialog.Text = "Find Dialog";
            // 
            // cmsReplaceDialog
            // 
            this.cmsReplaceDialog.Name = "cmsReplaceDialog";
            this.cmsReplaceDialog.Size = new System.Drawing.Size(216, 22);
            this.cmsReplaceDialog.Text = "Replace dialog";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(213, 6);
            // 
            // cmsCodeSendLine
            // 
            this.cmsCodeSendLine.Name = "cmsCodeSendLine";
            this.cmsCodeSendLine.Size = new System.Drawing.Size(216, 22);
            this.cmsCodeSendLine.Text = "Send marked line towards GRBL";
            // 
            // cmsCommentOut
            // 
            this.cmsCommentOut.Name = "cmsCommentOut";
            this.cmsCommentOut.Size = new System.Drawing.Size(216, 22);
            this.cmsCommentOut.Text = "Comment out unknown GCode";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(213, 6);
            // 
            // cmsUpdate2DView
            // 
            this.cmsUpdate2DView.Name = "cmsUpdate2DView";
            this.cmsUpdate2DView.Size = new System.Drawing.Size(216, 22);
            this.cmsUpdate2DView.Text = "Update 2D view";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.fCTBCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(741, 466);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 30);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(90, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(9, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // GCodeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GCodeEditor";
            this.Text = "GCodeEditor";
            ((System.ComponentModel.ISupportInitialize)(this.fCTBCode)).EndInit();
            this.cmsCode.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fCTBCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ContextMenuStrip cmsCode;
        private System.Windows.Forms.ToolStripMenuItem cmsEditorHotkeys;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem cmsCodeSelect;
        private System.Windows.Forms.ToolStripMenuItem cmsCodeCopy;
        private System.Windows.Forms.ToolStripMenuItem cmsCodePaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem cmsFindDialog;
        private System.Windows.Forms.ToolStripMenuItem cmsReplaceDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem cmsCodeSendLine;
        private System.Windows.Forms.ToolStripMenuItem cmsCommentOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem cmsUpdate2DView;
    }
}