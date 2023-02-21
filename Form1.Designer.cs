namespace Lab2 {
    partial class Form1 {

        private System.ComponentModel.IContainer components = null;


        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxOut = new System.Windows.Forms.PictureBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBoxR = new System.Windows.Forms.CheckBox();
            this.checkBoxG = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FilterGistogramSourceBlue = new System.Windows.Forms.CheckBox();
            this.FilterGistogramSourceGreen = new System.Windows.Forms.CheckBox();
            this.FilterGistogramSourceRed = new System.Windows.Forms.CheckBox();
            this.GistogramSource = new System.Windows.Forms.PictureBox();
            this.FilterGistogramTargetBlue = new System.Windows.Forms.CheckBox();
            this.FilterGistogramTargetGreen = new System.Windows.Forms.CheckBox();
            this.FilterGistogramTargetRed = new System.Windows.Forms.CheckBox();
            this.GistogramTarget = new System.Windows.Forms.PictureBox();
            this.FilterGistogramResBlue = new System.Windows.Forms.CheckBox();
            this.FilterGistogramResGreen = new System.Windows.Forms.CheckBox();
            this.FilterGistogramResRed = new System.Windows.Forms.CheckBox();
            this.GistogramRes = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioYIQ = new System.Windows.Forms.RadioButton();
            this.radioHSV = new System.Windows.Forms.RadioButton();
            this.radioHSL = new System.Windows.Forms.RadioButton();
            this.radioLab = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GistogramSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GistogramTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GistogramRes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(18, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 576);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(608, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(576, 576);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxOut
            // 
            this.pictureBoxOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOut.Location = new System.Drawing.Point(1203, 16);
            this.pictureBoxOut.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxOut.Name = "pictureBoxOut";
            this.pictureBoxOut.Size = new System.Drawing.Size(576, 576);
            this.pictureBoxOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOut.TabIndex = 2;
            this.pictureBoxOut.TabStop = false;
            // 
            // applyBtn
            // 
            this.applyBtn.Enabled = false;
            this.applyBtn.Location = new System.Drawing.Point(1788, 31);
            this.applyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(99, 28);
            this.applyBtn.TabIndex = 3;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(1788, 66);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(99, 28);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // checkBoxR
            // 
            this.checkBoxR.AutoSize = true;
            this.checkBoxR.Checked = true;
            this.checkBoxR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxR.Location = new System.Drawing.Point(1788, 138);
            this.checkBoxR.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxR.Name = "checkBoxR";
            this.checkBoxR.Size = new System.Drawing.Size(40, 21);
            this.checkBoxR.TabIndex = 5;
            this.checkBoxR.Text = "R";
            this.checkBoxR.UseVisualStyleBackColor = true;
            this.checkBoxR.CheckedChanged += new System.EventHandler(this.checkBoxR_CheckedChanged);
            // 
            // checkBoxG
            // 
            this.checkBoxG.AutoSize = true;
            this.checkBoxG.Checked = true;
            this.checkBoxG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxG.Location = new System.Drawing.Point(1788, 166);
            this.checkBoxG.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxG.Name = "checkBoxG";
            this.checkBoxG.Size = new System.Drawing.Size(41, 21);
            this.checkBoxG.TabIndex = 6;
            this.checkBoxG.Text = "G";
            this.checkBoxG.UseVisualStyleBackColor = true;
            this.checkBoxG.CheckedChanged += new System.EventHandler(this.checkBoxG_CheckedChanged);
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Checked = true;
            this.checkBoxB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxB.Location = new System.Drawing.Point(1788, 194);
            this.checkBoxB.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(39, 21);
            this.checkBoxB.TabIndex = 7;
            this.checkBoxB.Text = "B";
            this.checkBoxB.UseVisualStyleBackColor = true;
            this.checkBoxB.CheckedChanged += new System.EventHandler(this.checkBoxB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(879, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Target";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1483, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Result";
            // 
            // FilterGistogramSourceBlue
            // 
            this.FilterGistogramSourceBlue.AutoSize = true;
            this.FilterGistogramSourceBlue.Checked = true;
            this.FilterGistogramSourceBlue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterGistogramSourceBlue.Location = new System.Drawing.Point(554, 652);
            this.FilterGistogramSourceBlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterGistogramSourceBlue.Name = "FilterGistogramSourceBlue";
            this.FilterGistogramSourceBlue.Size = new System.Drawing.Size(39, 21);
            this.FilterGistogramSourceBlue.TabIndex = 18;
            this.FilterGistogramSourceBlue.Text = "B";
            this.FilterGistogramSourceBlue.UseVisualStyleBackColor = true;
            this.FilterGistogramSourceBlue.CheckedChanged += new System.EventHandler(this.FilterGistogramSourceBlue_CheckedChanged);
            // 
            // FilterGistogramSourceGreen
            // 
            this.FilterGistogramSourceGreen.AutoSize = true;
            this.FilterGistogramSourceGreen.Checked = true;
            this.FilterGistogramSourceGreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterGistogramSourceGreen.Location = new System.Drawing.Point(554, 625);
            this.FilterGistogramSourceGreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterGistogramSourceGreen.Name = "FilterGistogramSourceGreen";
            this.FilterGistogramSourceGreen.Size = new System.Drawing.Size(41, 21);
            this.FilterGistogramSourceGreen.TabIndex = 17;
            this.FilterGistogramSourceGreen.Text = "G";
            this.FilterGistogramSourceGreen.UseVisualStyleBackColor = true;
            this.FilterGistogramSourceGreen.CheckedChanged += new System.EventHandler(this.FilterGistogramSourceGreen_CheckedChanged);
            // 
            // FilterGistogramSourceRed
            // 
            this.FilterGistogramSourceRed.AutoSize = true;
            this.FilterGistogramSourceRed.Checked = true;
            this.FilterGistogramSourceRed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterGistogramSourceRed.Location = new System.Drawing.Point(554, 598);
            this.FilterGistogramSourceRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterGistogramSourceRed.Name = "FilterGistogramSourceRed";
            this.FilterGistogramSourceRed.Size = new System.Drawing.Size(40, 21);
            this.FilterGistogramSourceRed.TabIndex = 16;
            this.FilterGistogramSourceRed.Text = "R";
            this.FilterGistogramSourceRed.UseVisualStyleBackColor = true;
            this.FilterGistogramSourceRed.CheckedChanged += new System.EventHandler(this.FilterGistogramSourceRed_CheckedChanged);
            // 
            // GistogramSource
            // 
            this.GistogramSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GistogramSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GistogramSource.Location = new System.Drawing.Point(18, 598);
            this.GistogramSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GistogramSource.Name = "GistogramSource";
            this.GistogramSource.Size = new System.Drawing.Size(530, 329);
            this.GistogramSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GistogramSource.TabIndex = 15;
            this.GistogramSource.TabStop = false;
            // 
            // FilterGistogramTargetBlue
            // 
            this.FilterGistogramTargetBlue.AutoSize = true;
            this.FilterGistogramTargetBlue.Checked = true;
            this.FilterGistogramTargetBlue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterGistogramTargetBlue.Location = new System.Drawing.Point(1144, 652);
            this.FilterGistogramTargetBlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterGistogramTargetBlue.Name = "FilterGistogramTargetBlue";
            this.FilterGistogramTargetBlue.Size = new System.Drawing.Size(39, 21);
            this.FilterGistogramTargetBlue.TabIndex = 22;
            this.FilterGistogramTargetBlue.Text = "B";
            this.FilterGistogramTargetBlue.UseVisualStyleBackColor = true;
            this.FilterGistogramTargetBlue.CheckedChanged += new System.EventHandler(this.FilterGistogramTargetBlue_CheckedChanged);
            // 
            // FilterGistogramTargetGreen
            // 
            this.FilterGistogramTargetGreen.AutoSize = true;
            this.FilterGistogramTargetGreen.Checked = true;
            this.FilterGistogramTargetGreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterGistogramTargetGreen.Location = new System.Drawing.Point(1144, 625);
            this.FilterGistogramTargetGreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterGistogramTargetGreen.Name = "FilterGistogramTargetGreen";
            this.FilterGistogramTargetGreen.Size = new System.Drawing.Size(41, 21);
            this.FilterGistogramTargetGreen.TabIndex = 21;
            this.FilterGistogramTargetGreen.Text = "G";
            this.FilterGistogramTargetGreen.UseVisualStyleBackColor = true;
            this.FilterGistogramTargetGreen.CheckedChanged += new System.EventHandler(this.FilterGistogramTargetGreen_CheckedChanged);
            // 
            // FilterGistogramTargetRed
            // 
            this.FilterGistogramTargetRed.AutoSize = true;
            this.FilterGistogramTargetRed.Checked = true;
            this.FilterGistogramTargetRed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterGistogramTargetRed.Location = new System.Drawing.Point(1144, 598);
            this.FilterGistogramTargetRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterGistogramTargetRed.Name = "FilterGistogramTargetRed";
            this.FilterGistogramTargetRed.Size = new System.Drawing.Size(40, 21);
            this.FilterGistogramTargetRed.TabIndex = 20;
            this.FilterGistogramTargetRed.Text = "R";
            this.FilterGistogramTargetRed.UseVisualStyleBackColor = true;
            this.FilterGistogramTargetRed.CheckedChanged += new System.EventHandler(this.FilterGistogramTargetRed_CheckedChanged);
            // 
            // GistogramTarget
            // 
            this.GistogramTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GistogramTarget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GistogramTarget.Location = new System.Drawing.Point(608, 598);
            this.GistogramTarget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GistogramTarget.Name = "GistogramTarget";
            this.GistogramTarget.Size = new System.Drawing.Size(530, 329);
            this.GistogramTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GistogramTarget.TabIndex = 19;
            this.GistogramTarget.TabStop = false;
            // 
            // FilterGistogramResBlue
            // 
            this.FilterGistogramResBlue.AutoSize = true;
            this.FilterGistogramResBlue.Checked = true;
            this.FilterGistogramResBlue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterGistogramResBlue.Location = new System.Drawing.Point(1739, 648);
            this.FilterGistogramResBlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterGistogramResBlue.Name = "FilterGistogramResBlue";
            this.FilterGistogramResBlue.Size = new System.Drawing.Size(39, 21);
            this.FilterGistogramResBlue.TabIndex = 26;
            this.FilterGistogramResBlue.Text = "B";
            this.FilterGistogramResBlue.UseVisualStyleBackColor = true;
            this.FilterGistogramResBlue.CheckedChanged += new System.EventHandler(this.FilterGistogramResBlue_CheckedChanged);
            // 
            // FilterGistogramResGreen
            // 
            this.FilterGistogramResGreen.AutoSize = true;
            this.FilterGistogramResGreen.Checked = true;
            this.FilterGistogramResGreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterGistogramResGreen.Location = new System.Drawing.Point(1739, 623);
            this.FilterGistogramResGreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterGistogramResGreen.Name = "FilterGistogramResGreen";
            this.FilterGistogramResGreen.Size = new System.Drawing.Size(41, 21);
            this.FilterGistogramResGreen.TabIndex = 25;
            this.FilterGistogramResGreen.Text = "G";
            this.FilterGistogramResGreen.UseVisualStyleBackColor = true;
            this.FilterGistogramResGreen.CheckedChanged += new System.EventHandler(this.FilterGistogramResGreen_CheckedChanged);
            // 
            // FilterGistogramResRed
            // 
            this.FilterGistogramResRed.AutoSize = true;
            this.FilterGistogramResRed.Checked = true;
            this.FilterGistogramResRed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterGistogramResRed.Location = new System.Drawing.Point(1739, 598);
            this.FilterGistogramResRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterGistogramResRed.Name = "FilterGistogramResRed";
            this.FilterGistogramResRed.Size = new System.Drawing.Size(40, 21);
            this.FilterGistogramResRed.TabIndex = 24;
            this.FilterGistogramResRed.Text = "R";
            this.FilterGistogramResRed.UseVisualStyleBackColor = true;
            this.FilterGistogramResRed.CheckedChanged += new System.EventHandler(this.FilterGistogramResRed_CheckedChanged);
            // 
            // GistogramRes
            // 
            this.GistogramRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GistogramRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GistogramRes.Location = new System.Drawing.Point(1203, 598);
            this.GistogramRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GistogramRes.Name = "GistogramRes";
            this.GistogramRes.Size = new System.Drawing.Size(530, 329);
            this.GistogramRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GistogramRes.TabIndex = 23;
            this.GistogramRes.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioYIQ);
            this.groupBox1.Controls.Add(this.radioHSV);
            this.groupBox1.Controls.Add(this.radioHSL);
            this.groupBox1.Controls.Add(this.radioLab);
            this.groupBox1.Location = new System.Drawing.Point(1789, 239);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 146);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color spaces";
            // 
            // radioYIQ
            // 
            this.radioYIQ.AutoSize = true;
            this.radioYIQ.Location = new System.Drawing.Point(8, 108);
            this.radioYIQ.Name = "radioYIQ";
            this.radioYIQ.Size = new System.Drawing.Size(52, 21);
            this.radioYIQ.TabIndex = 3;
            this.radioYIQ.TabStop = true;
            this.radioYIQ.Text = "YIQ";
            this.radioYIQ.UseVisualStyleBackColor = true;
            // 
            // radioHSV
            // 
            this.radioHSV.AutoSize = true;
            this.radioHSV.Location = new System.Drawing.Point(8, 80);
            this.radioHSV.Margin = new System.Windows.Forms.Padding(4);
            this.radioHSV.Name = "radioHSV";
            this.radioHSV.Size = new System.Drawing.Size(57, 21);
            this.radioHSV.TabIndex = 2;
            this.radioHSV.Text = "HSV";
            this.radioHSV.UseVisualStyleBackColor = true;
            // 
            // radioHSL
            // 
            this.radioHSL.AutoSize = true;
            this.radioHSL.Location = new System.Drawing.Point(8, 52);
            this.radioHSL.Margin = new System.Windows.Forms.Padding(4);
            this.radioHSL.Name = "radioHSL";
            this.radioHSL.Size = new System.Drawing.Size(56, 21);
            this.radioHSL.TabIndex = 1;
            this.radioHSL.Text = "HSL";
            this.radioHSL.UseVisualStyleBackColor = true;
            // 
            // radioLab
            // 
            this.radioLab.AutoSize = true;
            this.radioLab.Checked = true;
            this.radioLab.Location = new System.Drawing.Point(8, 23);
            this.radioLab.Margin = new System.Windows.Forms.Padding(4);
            this.radioLab.Name = "radioLab";
            this.radioLab.Size = new System.Drawing.Size(55, 21);
            this.radioLab.TabIndex = 0;
            this.radioLab.TabStop = true;
            this.radioLab.Text = "LAB";
            this.radioLab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 938);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FilterGistogramResBlue);
            this.Controls.Add(this.FilterGistogramResGreen);
            this.Controls.Add(this.FilterGistogramResRed);
            this.Controls.Add(this.GistogramRes);
            this.Controls.Add(this.FilterGistogramTargetBlue);
            this.Controls.Add(this.FilterGistogramTargetGreen);
            this.Controls.Add(this.FilterGistogramTargetRed);
            this.Controls.Add(this.GistogramTarget);
            this.Controls.Add(this.FilterGistogramSourceBlue);
            this.Controls.Add(this.FilterGistogramSourceGreen);
            this.Controls.Add(this.FilterGistogramSourceRed);
            this.Controls.Add(this.GistogramSource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxB);
            this.Controls.Add(this.checkBoxG);
            this.Controls.Add(this.checkBoxR);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.pictureBoxOut);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Lab2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GistogramSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GistogramTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GistogramRes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxOut;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxR;
        private System.Windows.Forms.CheckBox checkBoxG;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox FilterGistogramSourceBlue;
        private System.Windows.Forms.CheckBox FilterGistogramSourceGreen;
        private System.Windows.Forms.CheckBox FilterGistogramSourceRed;
        private System.Windows.Forms.PictureBox GistogramSource;
        private System.Windows.Forms.CheckBox FilterGistogramTargetBlue;
        private System.Windows.Forms.CheckBox FilterGistogramTargetGreen;
        private System.Windows.Forms.CheckBox FilterGistogramTargetRed;
        private System.Windows.Forms.PictureBox GistogramTarget;
        private System.Windows.Forms.CheckBox FilterGistogramResBlue;
        private System.Windows.Forms.CheckBox FilterGistogramResGreen;
        private System.Windows.Forms.CheckBox FilterGistogramResRed;
        private System.Windows.Forms.PictureBox GistogramRes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioHSV;
        private System.Windows.Forms.RadioButton radioHSL;
        private System.Windows.Forms.RadioButton radioLab;
        private System.Windows.Forms.RadioButton radioYIQ;
    }
}

