using DS3Autosaver.Properties;
using ScumLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3Autosaver
{
    public partial class FormRestore : Form
    {
        SaveManager saveMan;

        public FormRestore(SaveManager saveMan)
        {
            InitializeComponent();

            this.saveMan = saveMan;
            PopulateControlValues();
        }

        private void FormRestore_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenExplorer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Settings.Default.BackupDir);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            PopulateControlValues();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBoxAuto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RestoreFile(listBoxAuto.SelectedItem?.ToString());
        }

        private void listBoxSticky_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RestoreFile(listBoxSticky.SelectedItem?.ToString());
        }

        void PopulateControlValues()
        {
            listBoxAuto.Items.Clear();
            listBoxSticky.Items.Clear();

            var autoFiles = saveMan.GetAutoBackupFiles();
            var manualFiles = saveMan.GetManualBackupFiles();

            foreach (var f in autoFiles)
            {
                listBoxAuto.Items.Add(f.Name);
            }

            foreach (var f in manualFiles)
            {
                listBoxSticky.Items.Add(f.Name);
            }

            labelAutoCount.Text = autoFiles.Length + "/" + saveMan.MaxBackups;
            labelStickyCount.Text = manualFiles.Length.ToString();
        }

        void RestoreFile(string filename)
        {
            var result = MessageBox.Show("Are you sure you want to restore\n\n" + filename,
                "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    saveMan.RestoreBackup(filename);
                    MessageBox.Show("Savefile restored\n" + filename);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to restore file\n" + filename + "\n\n" + ex.ToString(),
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PopulateControlValues();
        }
    }
}
