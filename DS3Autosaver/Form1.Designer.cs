namespace DS3Autosaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.groupBoxAutosave = new System.Windows.Forms.GroupBox();
            this.buttonManual = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerSave = new System.Windows.Forms.Timer(this.components);
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLastBackup = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAutoCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStickyCount = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonRefreshStatus = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.restoreSavefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBackupFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBoxAutosave.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreSavefileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoStartToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // autoStartToolStripMenuItem
            // 
            this.autoStartToolStripMenuItem.Name = "autoStartToolStripMenuItem";
            this.autoStartToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.autoStartToolStripMenuItem.Text = "Auto Start";
            this.autoStartToolStripMenuItem.Click += new System.EventHandler(this.autoStartToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBackupFolderToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 200;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // groupBoxAutosave
            // 
            this.groupBoxAutosave.Controls.Add(this.buttonManual);
            this.groupBoxAutosave.Controls.Add(this.buttonStart);
            this.groupBoxAutosave.Controls.Add(this.buttonStop);
            this.groupBoxAutosave.Location = new System.Drawing.Point(12, 27);
            this.groupBoxAutosave.Name = "groupBoxAutosave";
            this.groupBoxAutosave.Size = new System.Drawing.Size(179, 59);
            this.groupBoxAutosave.TabIndex = 3;
            this.groupBoxAutosave.TabStop = false;
            this.groupBoxAutosave.Text = "Auto Backup";
            // 
            // buttonManual
            // 
            this.buttonManual.Location = new System.Drawing.Point(98, 19);
            this.buttonManual.Name = "buttonManual";
            this.buttonManual.Size = new System.Drawing.Size(75, 34);
            this.buttonManual.TabIndex = 6;
            this.buttonManual.Text = "Backup Now";
            this.buttonManual.UseVisualStyleBackColor = true;
            this.buttonManual.Click += new System.EventHandler(this.buttonManual_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelTimer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 189);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(304, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabel1.Text = "Autobackup in";
            // 
            // toolStripStatusLabelTimer
            // 
            this.toolStripStatusLabelTimer.Name = "toolStripStatusLabelTimer";
            this.toolStripStatusLabelTimer.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabelTimer.Text = "XX:XX";
            // 
            // timerSave
            // 
            this.timerSave.Interval = 20000;
            this.timerSave.Tick += new System.EventHandler(this.timerSave_Tick);
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.buttonRefreshStatus);
            this.groupBoxStatus.Controls.Add(this.labelStickyCount);
            this.groupBoxStatus.Controls.Add(this.label3);
            this.groupBoxStatus.Controls.Add(this.labelAutoCount);
            this.groupBoxStatus.Controls.Add(this.label2);
            this.groupBoxStatus.Controls.Add(this.labelLastBackup);
            this.groupBoxStatus.Controls.Add(this.label1);
            this.groupBoxStatus.Location = new System.Drawing.Point(12, 92);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(280, 94);
            this.groupBoxStatus.TabIndex = 4;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last Backup";
            // 
            // labelLastBackup
            // 
            this.labelLastBackup.AutoSize = true;
            this.labelLastBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastBackup.Location = new System.Drawing.Point(113, 16);
            this.labelLastBackup.Name = "labelLastBackup";
            this.labelLastBackup.Size = new System.Drawing.Size(87, 16);
            this.labelLastBackup.TabIndex = 7;
            this.labelLastBackup.Text = "TIMESTAMP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Auto Backups";
            // 
            // labelAutoCount
            // 
            this.labelAutoCount.AutoSize = true;
            this.labelAutoCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutoCount.Location = new System.Drawing.Point(113, 42);
            this.labelAutoCount.Name = "labelAutoCount";
            this.labelAutoCount.Size = new System.Drawing.Size(44, 16);
            this.labelAutoCount.TabIndex = 9;
            this.labelAutoCount.Text = "XX/XX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sticky Backups";
            // 
            // labelStickyCount
            // 
            this.labelStickyCount.AutoSize = true;
            this.labelStickyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStickyCount.Location = new System.Drawing.Point(113, 68);
            this.labelStickyCount.Name = "labelStickyCount";
            this.labelStickyCount.Size = new System.Drawing.Size(24, 16);
            this.labelStickyCount.TabIndex = 11;
            this.labelStickyCount.Text = "XX";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // buttonRefreshStatus
            // 
            this.buttonRefreshStatus.Image = global::DS3Autosaver.Properties.Resources.reload_2x;
            this.buttonRefreshStatus.Location = new System.Drawing.Point(244, 59);
            this.buttonRefreshStatus.Name = "buttonRefreshStatus";
            this.buttonRefreshStatus.Size = new System.Drawing.Size(30, 29);
            this.buttonRefreshStatus.TabIndex = 12;
            this.buttonRefreshStatus.UseVisualStyleBackColor = true;
            this.buttonRefreshStatus.Click += new System.EventHandler(this.buttonRefreshStatus_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Image = global::DS3Autosaver.Properties.Resources.media_play_3x;
            this.buttonStart.Location = new System.Drawing.Point(6, 19);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(40, 34);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Image = global::DS3Autosaver.Properties.Resources.media_stop_3x;
            this.buttonStop.Location = new System.Drawing.Point(52, 19);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(40, 34);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // restoreSavefileToolStripMenuItem
            // 
            this.restoreSavefileToolStripMenuItem.Image = global::DS3Autosaver.Properties.Resources.data_transfer_upload_3x;
            this.restoreSavefileToolStripMenuItem.Name = "restoreSavefileToolStripMenuItem";
            this.restoreSavefileToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.restoreSavefileToolStripMenuItem.Text = "Restore Savefile";
            this.restoreSavefileToolStripMenuItem.Click += new System.EventHandler(this.restoreSavefileToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("optionsToolStripMenuItem.Image")));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // openBackupFolderToolStripMenuItem
            // 
            this.openBackupFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openBackupFolderToolStripMenuItem.Image")));
            this.openBackupFolderToolStripMenuItem.Name = "openBackupFolderToolStripMenuItem";
            this.openBackupFolderToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.openBackupFolderToolStripMenuItem.Text = "Open Backup Folder";
            this.openBackupFolderToolStripMenuItem.Click += new System.EventHandler(this.openBackupFolderToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::DS3Autosaver.Properties.Resources.info_3x;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 211);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxAutosave);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DS3 Autobackup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxAutosave.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.GroupBox groupBoxAutosave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTimer;
        private System.Windows.Forms.Timer timerSave;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.ToolStripMenuItem openBackupFolderToolStripMenuItem;
        private System.Windows.Forms.Button buttonManual;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreSavefileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLastBackup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAutoCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStickyCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button buttonRefreshStatus;
    }
}

