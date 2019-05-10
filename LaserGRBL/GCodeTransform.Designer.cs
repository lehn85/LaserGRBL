namespace LaserGRBL
{
    partial class GCodeTransform
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
            this.label1 = new System.Windows.Forms.Label();
            this.nud_baseX = new System.Windows.Forms.NumericUpDown();
            this.transformParamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nud_baseY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_dX = new System.Windows.Forms.NumericUpDown();
            this.nud_dY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nud_angle = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chBox_lockRatio = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_scaleX = new System.Windows.Forms.NumericUpDown();
            this.nud_scaleY = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_baseX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transformParamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_baseY)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dY)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_angle)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_scaleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_scaleY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // nud_baseX
            // 
            this.nud_baseX.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transformParamBindingSource, "BaseX", true));
            this.nud_baseX.DecimalPlaces = 1;
            this.nud_baseX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_baseX.Location = new System.Drawing.Point(47, 17);
            this.nud_baseX.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_baseX.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nud_baseX.Name = "nud_baseX";
            this.nud_baseX.Size = new System.Drawing.Size(96, 20);
            this.nud_baseX.TabIndex = 1;
            // 
            // transformParamBindingSource
            // 
            this.transformParamBindingSource.DataSource = typeof(LaserGRBL.GCodeTransform.TransformParam);
            // 
            // nud_baseY
            // 
            this.nud_baseY.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transformParamBindingSource, "BaseY", true));
            this.nud_baseY.DecimalPlaces = 1;
            this.nud_baseY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_baseY.Location = new System.Drawing.Point(47, 41);
            this.nud_baseY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_baseY.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nud_baseY.Name = "nud_baseY";
            this.nud_baseY.Size = new System.Drawing.Size(96, 20);
            this.nud_baseY.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nud_baseX);
            this.groupBox1.Controls.Add(this.nud_baseY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base point";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nud_dX);
            this.groupBox2.Controls.Add(this.nud_dY);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(186, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 77);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Translate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "dY";
            // 
            // nud_dX
            // 
            this.nud_dX.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transformParamBindingSource, "DX", true));
            this.nud_dX.DecimalPlaces = 1;
            this.nud_dX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_dX.Location = new System.Drawing.Point(47, 17);
            this.nud_dX.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_dX.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nud_dX.Name = "nud_dX";
            this.nud_dX.Size = new System.Drawing.Size(96, 20);
            this.nud_dX.TabIndex = 1;
            // 
            // nud_dY
            // 
            this.nud_dY.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transformParamBindingSource, "DY", true));
            this.nud_dY.DecimalPlaces = 1;
            this.nud_dY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_dY.Location = new System.Drawing.Point(47, 41);
            this.nud_dY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_dY.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nud_dY.Name = "nud_dY";
            this.nud_dY.Size = new System.Drawing.Size(96, 20);
            this.nud_dY.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "dX";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nud_angle);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(186, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 54);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rotate";
            // 
            // nud_angle
            // 
            this.nud_angle.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transformParamBindingSource, "Angle", true));
            this.nud_angle.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_angle.Location = new System.Drawing.Point(55, 17);
            this.nud_angle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nud_angle.Name = "nud_angle";
            this.nud_angle.Size = new System.Drawing.Size(88, 20);
            this.nud_angle.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Angle";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chBox_lockRatio);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.nud_scaleX);
            this.groupBox4.Controls.Add(this.nud_scaleY);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(12, 99);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(159, 98);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scale";
            // 
            // chBox_lockRatio
            // 
            this.chBox_lockRatio.AutoSize = true;
            this.chBox_lockRatio.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.transformParamBindingSource, "LockRatio", true));
            this.chBox_lockRatio.Location = new System.Drawing.Point(18, 67);
            this.chBox_lockRatio.Name = "chBox_lockRatio";
            this.chBox_lockRatio.Size = new System.Drawing.Size(73, 17);
            this.chBox_lockRatio.TabIndex = 2;
            this.chBox_lockRatio.Text = "Lock ratio";
            this.chBox_lockRatio.UseVisualStyleBackColor = true;
            this.chBox_lockRatio.CheckedChanged += new System.EventHandler(this.chBox_lockRatio_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "scaleY";
            // 
            // nud_scaleX
            // 
            this.nud_scaleX.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transformParamBindingSource, "ScaleX", true));
            this.nud_scaleX.DecimalPlaces = 4;
            this.nud_scaleX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nud_scaleX.Location = new System.Drawing.Point(71, 17);
            this.nud_scaleX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_scaleX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nud_scaleX.Name = "nud_scaleX";
            this.nud_scaleX.Size = new System.Drawing.Size(82, 20);
            this.nud_scaleX.TabIndex = 1;
            this.nud_scaleX.ValueChanged += new System.EventHandler(this.nud_scaleX_ValueChanged);
            // 
            // nud_scaleY
            // 
            this.nud_scaleY.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transformParamBindingSource, "ScaleY", true));
            this.nud_scaleY.DecimalPlaces = 4;
            this.nud_scaleY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nud_scaleY.Location = new System.Drawing.Point(71, 41);
            this.nud_scaleY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_scaleY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nud_scaleY.Name = "nud_scaleY";
            this.nud_scaleY.Size = new System.Drawing.Size(82, 20);
            this.nud_scaleY.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "scaleX";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(186, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(266, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(260, 162);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(85, 23);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Reset values";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(12, 204);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 23);
            this.btn_preview.TabIndex = 5;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // GCodeTransform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 239);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GCodeTransform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GCode Transform";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GCodeTransform_FormClosed);
            this.Load += new System.EventHandler(this.GCodeTransform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_baseX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transformParamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_baseY)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dY)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_angle)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_scaleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_scaleY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_baseX;
        private System.Windows.Forms.NumericUpDown nud_baseY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_dX;
        private System.Windows.Forms.NumericUpDown nud_dY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nud_angle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chBox_lockRatio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_scaleX;
        private System.Windows.Forms.NumericUpDown nud_scaleY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource transformParamBindingSource;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_preview;
    }
}