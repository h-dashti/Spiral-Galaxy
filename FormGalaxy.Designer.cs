namespace Galaxy__Windows_
{
    partial class FormGalaxy
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
            this.buttonNext = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelnINitActive = new System.Windows.Forms.Label();
            this.textBoxv = new System.Windows.Forms.TextBox();
            this.textBoxNInitActive = new System.Windows.Forms.TextBox();
            this.textBoxp = new System.Windows.Forms.TextBox();
            this.labelATime = new System.Windows.Forms.Label();
            this.labelp = new System.Windows.Forms.Label();
            this.textBoxActivationTime = new System.Windows.Forms.TextBox();
            this.textBoxdt = new System.Windows.Forms.TextBox();
            this.labelnRings = new System.Windows.Forms.Label();
            this.labeldt = new System.Windows.Forms.Label();
            this.textBoxNumRings = new System.Windows.Forms.TextBox();
            this.labelv = new System.Windows.Forms.Label();
            this.textBoxActiveCells = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(930, 67);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(66, 23);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Next Step";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(867, 719);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(65, 211);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset Data";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonAuto
            // 
            this.buttonAuto.Location = new System.Drawing.Point(885, 26);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(68, 23);
            this.buttonAuto.TabIndex = 3;
            this.buttonAuto.Text = "Auto Step";
            this.buttonAuto.UseVisualStyleBackColor = true;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(966, 27);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(65, 23);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelnINitActive);
            this.groupBox2.Controls.Add(this.textBoxv);
            this.groupBox2.Controls.Add(this.textBoxNInitActive);
            this.groupBox2.Controls.Add(this.textBoxp);
            this.groupBox2.Controls.Add(this.labelATime);
            this.groupBox2.Controls.Add(this.labelp);
            this.groupBox2.Controls.Add(this.buttonReset);
            this.groupBox2.Controls.Add(this.textBoxActivationTime);
            this.groupBox2.Controls.Add(this.textBoxdt);
            this.groupBox2.Controls.Add(this.labelnRings);
            this.groupBox2.Controls.Add(this.labeldt);
            this.groupBox2.Controls.Add(this.textBoxNumRings);
            this.groupBox2.Controls.Add(this.labelv);
            this.groupBox2.Location = new System.Drawing.Point(885, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 239);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Init Data";
            // 
            // labelnINitActive
            // 
            this.labelnINitActive.AutoSize = true;
            this.labelnINitActive.Location = new System.Drawing.Point(3, 156);
            this.labelnINitActive.Name = "labelnINitActive";
            this.labelnINitActive.Size = new System.Drawing.Size(62, 13);
            this.labelnINitActive.TabIndex = 33;
            this.labelnINitActive.Text = "init n Active";
            // 
            // textBoxv
            // 
            this.textBoxv.Location = new System.Drawing.Point(69, 101);
            this.textBoxv.Name = "textBoxv";
            this.textBoxv.Size = new System.Drawing.Size(71, 20);
            this.textBoxv.TabIndex = 26;
            // 
            // textBoxNInitActive
            // 
            this.textBoxNInitActive.Location = new System.Drawing.Point(69, 153);
            this.textBoxNInitActive.Name = "textBoxNInitActive";
            this.textBoxNInitActive.Size = new System.Drawing.Size(71, 20);
            this.textBoxNInitActive.TabIndex = 32;
            // 
            // textBoxp
            // 
            this.textBoxp.Location = new System.Drawing.Point(69, 49);
            this.textBoxp.Name = "textBoxp";
            this.textBoxp.Size = new System.Drawing.Size(71, 20);
            this.textBoxp.TabIndex = 22;
            // 
            // labelATime
            // 
            this.labelATime.AutoSize = true;
            this.labelATime.Location = new System.Drawing.Point(14, 182);
            this.labelATime.Name = "labelATime";
            this.labelATime.Size = new System.Drawing.Size(35, 13);
            this.labelATime.TabIndex = 31;
            this.labelATime.Text = "a time";
            // 
            // labelp
            // 
            this.labelp.AutoSize = true;
            this.labelp.Location = new System.Drawing.Point(14, 52);
            this.labelp.Name = "labelp";
            this.labelp.Size = new System.Drawing.Size(13, 13);
            this.labelp.TabIndex = 23;
            this.labelp.Text = "p";
            // 
            // textBoxActivationTime
            // 
            this.textBoxActivationTime.Location = new System.Drawing.Point(69, 179);
            this.textBoxActivationTime.Name = "textBoxActivationTime";
            this.textBoxActivationTime.Size = new System.Drawing.Size(71, 20);
            this.textBoxActivationTime.TabIndex = 30;
            // 
            // textBoxdt
            // 
            this.textBoxdt.Location = new System.Drawing.Point(69, 75);
            this.textBoxdt.Name = "textBoxdt";
            this.textBoxdt.Size = new System.Drawing.Size(71, 20);
            this.textBoxdt.TabIndex = 24;
            // 
            // labelnRings
            // 
            this.labelnRings.AutoSize = true;
            this.labelnRings.Location = new System.Drawing.Point(14, 130);
            this.labelnRings.Name = "labelnRings";
            this.labelnRings.Size = new System.Drawing.Size(43, 13);
            this.labelnRings.TabIndex = 29;
            this.labelnRings.Text = "n Rings";
            // 
            // labeldt
            // 
            this.labeldt.AutoSize = true;
            this.labeldt.Location = new System.Drawing.Point(14, 78);
            this.labeldt.Name = "labeldt";
            this.labeldt.Size = new System.Drawing.Size(16, 13);
            this.labeldt.TabIndex = 25;
            this.labeldt.Text = "dt";
            // 
            // textBoxNumRings
            // 
            this.textBoxNumRings.Location = new System.Drawing.Point(69, 127);
            this.textBoxNumRings.Name = "textBoxNumRings";
            this.textBoxNumRings.Size = new System.Drawing.Size(71, 20);
            this.textBoxNumRings.TabIndex = 28;
            // 
            // labelv
            // 
            this.labelv.AutoSize = true;
            this.labelv.Location = new System.Drawing.Point(14, 104);
            this.labelv.Name = "labelv";
            this.labelv.Size = new System.Drawing.Size(13, 13);
            this.labelv.TabIndex = 27;
            this.labelv.Text = "v";
            // 
            // textBoxActiveCells
            // 
            this.textBoxActiveCells.Location = new System.Drawing.Point(906, 645);
            this.textBoxActiveCells.Name = "textBoxActiveCells";
            this.textBoxActiveCells.ReadOnly = true;
            this.textBoxActiveCells.Size = new System.Drawing.Size(85, 20);
            this.textBoxActiveCells.TabIndex = 24;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(906, 680);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(126, 20);
            this.textBoxTime.TabIndex = 23;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(880, 168);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(152, 45);
            this.trackBar1.TabIndex = 25;
            this.trackBar1.Value = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(936, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Speed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(891, 210);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown1.TabIndex = 27;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(963, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Step\r\nIterations";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FormGalaxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1038, 769);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxActiveCells);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonAuto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGalaxy";
            this.Text = "Galaxy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGalaxy_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelnINitActive;
        private System.Windows.Forms.TextBox textBoxv;
        private System.Windows.Forms.TextBox textBoxNInitActive;
        private System.Windows.Forms.TextBox textBoxp;
        private System.Windows.Forms.Label labelATime;
        private System.Windows.Forms.Label labelp;
        private System.Windows.Forms.TextBox textBoxActivationTime;
        private System.Windows.Forms.TextBox textBoxdt;
        private System.Windows.Forms.Label labelnRings;
        private System.Windows.Forms.Label labeldt;
        private System.Windows.Forms.TextBox textBoxNumRings;
        private System.Windows.Forms.Label labelv;
        private System.Windows.Forms.TextBox textBoxActiveCells;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

