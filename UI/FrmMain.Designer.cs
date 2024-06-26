﻿namespace FluentTypeSimulator
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChkCopyPaste = new System.Windows.Forms.CheckBox();
            this.cmbAfterTypeEvent = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericStartDelay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericNewLineDelay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericKeyPressDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNewLineDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKeyPressDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSource);
            this.groupBox1.Controls.Add(this.BtnOpenFile);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Purple;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // txtSource
            // 
            this.txtSource.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(9, 21);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSource.Size = new System.Drawing.Size(764, 394);
            this.txtSource.TabIndex = 1;
            this.txtSource.Text = resources.GetString("txtSource.Text");
            this.txtSource.WordWrap = false;
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnOpenFile.Location = new System.Drawing.Point(9, 419);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(97, 28);
            this.BtnOpenFile.TabIndex = 0;
            this.BtnOpenFile.Text = "&Load File";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChkCopyPaste);
            this.groupBox2.Controls.Add(this.cmbAfterTypeEvent);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericStartDelay);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericNewLineDelay);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericKeyPressDelay);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Purple;
            this.groupBox2.Location = new System.Drawing.Point(12, 471);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // ChkCopyPaste
            // 
            this.ChkCopyPaste.AutoSize = true;
            this.ChkCopyPaste.Location = new System.Drawing.Point(624, 78);
            this.ChkCopyPaste.Name = "ChkCopyPaste";
            this.ChkCopyPaste.Size = new System.Drawing.Size(150, 20);
            this.ChkCopyPaste.TabIndex = 8;
            this.ChkCopyPaste.Text = "Copy/Paste Mode";
            this.ChkCopyPaste.UseVisualStyleBackColor = true;
            // 
            // cmbAfterTypeEvent
            // 
            this.cmbAfterTypeEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAfterTypeEvent.FormattingEnabled = true;
            this.cmbAfterTypeEvent.Items.AddRange(new object[] {
            "-",
            "F5",
            "Ctrl+F5",
            "Ctrl+S"});
            this.cmbAfterTypeEvent.Location = new System.Drawing.Point(128, 80);
            this.cmbAfterTypeEvent.Name = "cmbAfterTypeEvent";
            this.cmbAfterTypeEvent.Size = new System.Drawing.Size(234, 24);
            this.cmbAfterTypeEvent.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(15, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "After Type Event :";
            // 
            // numericStartDelay
            // 
            this.numericStartDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericStartDelay.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericStartDelay.Location = new System.Drawing.Point(706, 32);
            this.numericStartDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericStartDelay.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericStartDelay.Name = "numericStartDelay";
            this.numericStartDelay.Size = new System.Drawing.Size(65, 22);
            this.numericStartDelay.TabIndex = 5;
            this.numericStartDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericStartDelay.ThousandsSeparator = true;
            this.numericStartDelay.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(621, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Delay :";
            // 
            // numericNewLineDelay
            // 
            this.numericNewLineDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericNewLineDelay.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericNewLineDelay.Location = new System.Drawing.Point(436, 34);
            this.numericNewLineDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericNewLineDelay.Name = "numericNewLineDelay";
            this.numericNewLineDelay.Size = new System.Drawing.Size(68, 22);
            this.numericNewLineDelay.TabIndex = 3;
            this.numericNewLineDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericNewLineDelay.ThousandsSeparator = true;
            this.numericNewLineDelay.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(328, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Line Delay :";
            // 
            // numericKeyPressDelay
            // 
            this.numericKeyPressDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericKeyPressDelay.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericKeyPressDelay.Location = new System.Drawing.Point(126, 32);
            this.numericKeyPressDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericKeyPressDelay.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericKeyPressDelay.Name = "numericKeyPressDelay";
            this.numericKeyPressDelay.Size = new System.Drawing.Size(54, 22);
            this.numericKeyPressDelay.TabIndex = 1;
            this.numericKeyPressDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericKeyPressDelay.ThousandsSeparator = true;
            this.numericKeyPressDelay.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "KeyPress Delay :";
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.White;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnStart.Location = new System.Drawing.Point(309, 594);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(183, 41);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Start Typing !";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fluent Type Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNewLineDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKeyPressDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericKeyPressDelay;
        private System.Windows.Forms.NumericUpDown numericNewLineDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericStartDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAfterTypeEvent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChkCopyPaste;
    }
}
