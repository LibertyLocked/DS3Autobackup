namespace DS3Autosaver
{
    partial class FormOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSave = new System.Windows.Forms.TextBox();
            this.buttonBrowseSave = new System.Windows.Forms.Button();
            this.openFileDialogSave = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMaxBackups = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBackupDir = new System.Windows.Forms.TextBox();
            this.buttonBackupDir = new System.Windows.Forms.Button();
            this.folderBrowserDialogBackupDir = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQuicksave = new System.Windows.Forms.TextBox();
            this.textBoxQuickload = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxBackups)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save File";
            // 
            // textBoxSave
            // 
            this.textBoxSave.Location = new System.Drawing.Point(15, 26);
            this.textBoxSave.Name = "textBoxSave";
            this.textBoxSave.Size = new System.Drawing.Size(299, 20);
            this.textBoxSave.TabIndex = 1;
            // 
            // buttonBrowseSave
            // 
            this.buttonBrowseSave.Location = new System.Drawing.Point(320, 26);
            this.buttonBrowseSave.Name = "buttonBrowseSave";
            this.buttonBrowseSave.Size = new System.Drawing.Size(55, 20);
            this.buttonBrowseSave.TabIndex = 2;
            this.buttonBrowseSave.Text = "Browse";
            this.buttonBrowseSave.UseVisualStyleBackColor = true;
            this.buttonBrowseSave.Click += new System.EventHandler(this.buttonBrowseSave_Click);
            // 
            // openFileDialogSave
            // 
            this.openFileDialogSave.Filter = "Dark Souls Savegame (*.sl2)|*.sl2";
            this.openFileDialogSave.InitialDirectory = "%APPDATA%/DARKSOULSIII";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Auto Backup Interval (Minutes)";
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Location = new System.Drawing.Point(171, 52);
            this.numericUpDownInterval.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownInterval.TabIndex = 4;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max Backups";
            // 
            // numericUpDownMaxBackups
            // 
            this.numericUpDownMaxBackups.Location = new System.Drawing.Point(315, 52);
            this.numericUpDownMaxBackups.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxBackups.Name = "numericUpDownMaxBackups";
            this.numericUpDownMaxBackups.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownMaxBackups.TabIndex = 6;
            this.numericUpDownMaxBackups.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Backup Folder";
            // 
            // textBoxBackupDir
            // 
            this.textBoxBackupDir.Location = new System.Drawing.Point(15, 100);
            this.textBoxBackupDir.Name = "textBoxBackupDir";
            this.textBoxBackupDir.Size = new System.Drawing.Size(299, 20);
            this.textBoxBackupDir.TabIndex = 8;
            // 
            // buttonBackupDir
            // 
            this.buttonBackupDir.Location = new System.Drawing.Point(320, 99);
            this.buttonBackupDir.Name = "buttonBackupDir";
            this.buttonBackupDir.Size = new System.Drawing.Size(55, 20);
            this.buttonBackupDir.TabIndex = 9;
            this.buttonBackupDir.Text = "Browse";
            this.buttonBackupDir.UseVisualStyleBackColor = true;
            this.buttonBackupDir.Click += new System.EventHandler(this.buttonBackupDir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quicksave";
            this.label5.Visible = false;
            // 
            // textBoxQuicksave
            // 
            this.textBoxQuicksave.Enabled = false;
            this.textBoxQuicksave.Location = new System.Drawing.Point(76, 126);
            this.textBoxQuicksave.Name = "textBoxQuicksave";
            this.textBoxQuicksave.Size = new System.Drawing.Size(50, 20);
            this.textBoxQuicksave.TabIndex = 11;
            this.textBoxQuicksave.Visible = false;
            // 
            // textBoxQuickload
            // 
            this.textBoxQuickload.Enabled = false;
            this.textBoxQuickload.Location = new System.Drawing.Point(193, 126);
            this.textBoxQuickload.Name = "textBoxQuickload";
            this.textBoxQuickload.Size = new System.Drawing.Size(50, 20);
            this.textBoxQuickload.TabIndex = 13;
            this.textBoxQuickload.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quickload";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(27, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quicksave feature is not implemented ATM";
            this.label7.Visible = false;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Image = global::DS3Autosaver.Properties.Resources.check_3x;
            this.buttonConfirm.Location = new System.Drawing.Point(316, 159);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(59, 33);
            this.buttonConfirm.TabIndex = 14;
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 204);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxQuickload);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxQuicksave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonBackupDir);
            this.Controls.Add(this.textBoxBackupDir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownMaxBackups);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownInterval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBrowseSave);
            this.Controls.Add(this.textBoxSave);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormOptions";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxBackups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSave;
        private System.Windows.Forms.Button buttonBrowseSave;
        private System.Windows.Forms.OpenFileDialog openFileDialogSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxBackups;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBackupDir;
        private System.Windows.Forms.Button buttonBackupDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogBackupDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQuicksave;
        private System.Windows.Forms.TextBox textBoxQuickload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label7;
    }
}