using DS3Autosaver.Properties;
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
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();

            // Load Settings to controls
            LoadSettingsToControls();
        }

        private void buttonBrowseSave_Click(object sender, EventArgs e)
        {
            openFileDialogSave.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var result = openFileDialogSave.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxSave.Text = openFileDialogSave.FileName;
            }
        }

        private void buttonBackupDir_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialogBackupDir.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxBackupDir.Text = folderBrowserDialogBackupDir.SelectedPath;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            var validResult = Utils.ValidateSettings(textBoxSave.Text, textBoxBackupDir.Text);
            if (!validResult.Valid)
            {
                MessageBox.Show(validResult.Message, "Invalid settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveSettingsFromControls();
            Close();
        }

        private void LoadSettingsToControls()
        {
            textBoxSave.Text = Settings.Default.SaveFile;
            numericUpDownInterval.Value = Settings.Default.Interval.Minutes;
            numericUpDownMaxBackups.Value = Settings.Default.MaxBackups;
            textBoxBackupDir.Text = Settings.Default.BackupDir;
            textBoxQuicksave.Text = Settings.Default.QuicksaveKey.ToString();
            textBoxQuickload.Text = Settings.Default.QuickloadKey.ToString();
        }

        private void SaveSettingsFromControls()
        {
            Settings.Default.SaveFile = textBoxSave.Text;
            Settings.Default.Interval = TimeSpan.FromMinutes((double)numericUpDownInterval.Value);
            Settings.Default.MaxBackups = (int)numericUpDownMaxBackups.Value;
            Settings.Default.BackupDir = textBoxBackupDir.Text;
            // Settings.Default.QuicksaveKey = 
            // Settings.Default.QuickloadKey = 
            Settings.Default.Save();
        }
    }
}
