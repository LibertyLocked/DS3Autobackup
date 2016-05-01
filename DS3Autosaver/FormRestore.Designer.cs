namespace DS3Autosaver
{
    partial class FormRestore
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
            this.listBoxAuto = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxSticky = new System.Windows.Forms.ListBox();
            this.buttonOpenExplorer = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelAutoCount = new System.Windows.Forms.Label();
            this.labelStickyCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto Backups";
            // 
            // listBoxAuto
            // 
            this.listBoxAuto.FormattingEnabled = true;
            this.listBoxAuto.Location = new System.Drawing.Point(15, 26);
            this.listBoxAuto.Name = "listBoxAuto";
            this.listBoxAuto.Size = new System.Drawing.Size(282, 108);
            this.listBoxAuto.TabIndex = 1;
            this.listBoxAuto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxAuto_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sticky Backups";
            // 
            // listBoxSticky
            // 
            this.listBoxSticky.FormattingEnabled = true;
            this.listBoxSticky.Location = new System.Drawing.Point(12, 153);
            this.listBoxSticky.Name = "listBoxSticky";
            this.listBoxSticky.Size = new System.Drawing.Size(285, 82);
            this.listBoxSticky.TabIndex = 3;
            this.listBoxSticky.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSticky_MouseDoubleClick);
            // 
            // buttonOpenExplorer
            // 
            this.buttonOpenExplorer.Location = new System.Drawing.Point(12, 241);
            this.buttonOpenExplorer.Name = "buttonOpenExplorer";
            this.buttonOpenExplorer.Size = new System.Drawing.Size(75, 28);
            this.buttonOpenExplorer.TabIndex = 4;
            this.buttonOpenExplorer.Text = "Open Folder";
            this.buttonOpenExplorer.UseVisualStyleBackColor = true;
            this.buttonOpenExplorer.Click += new System.EventHandler(this.buttonOpenExplorer_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(93, 241);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(74, 28);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(223, 241);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(74, 28);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelAutoCount
            // 
            this.labelAutoCount.AutoSize = true;
            this.labelAutoCount.Location = new System.Drawing.Point(92, 10);
            this.labelAutoCount.Name = "labelAutoCount";
            this.labelAutoCount.Size = new System.Drawing.Size(35, 13);
            this.labelAutoCount.TabIndex = 7;
            this.labelAutoCount.Text = "Count";
            // 
            // labelStickyCount
            // 
            this.labelStickyCount.AutoSize = true;
            this.labelStickyCount.Location = new System.Drawing.Point(99, 137);
            this.labelStickyCount.Name = "labelStickyCount";
            this.labelStickyCount.Size = new System.Drawing.Size(35, 13);
            this.labelStickyCount.TabIndex = 8;
            this.labelStickyCount.Text = "Count";
            // 
            // FormRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 281);
            this.Controls.Add(this.labelStickyCount);
            this.Controls.Add(this.labelAutoCount);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonOpenExplorer);
            this.Controls.Add(this.listBoxSticky);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxAuto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRestore";
            this.Text = "Restore Savefile";
            this.Load += new System.EventHandler(this.FormRestore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxSticky;
        private System.Windows.Forms.Button buttonOpenExplorer;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelAutoCount;
        private System.Windows.Forms.Label labelStickyCount;
    }
}