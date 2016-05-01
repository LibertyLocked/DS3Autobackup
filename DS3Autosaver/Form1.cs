using DS3Autosaver.Properties;
using ScumLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3Autosaver
{
    public partial class Form1 : Form
    {
        KeyboardHook keyHook = new KeyboardHook();
        SaveManager saveMan;
        static object saveLock = new object();
        DateTime timeStarted;

        public Form1()
        {
            InitializeComponent();

            // Register hotkeys
            //keyHook.KeyPressed += KeyHook_KeyPressed;
            //keyHook.RegisterHotKey(ScumLib.ModifierKeys.None, Settings.Default.QuicksaveKey);
            //keyHook.RegisterHotKey(ScumLib.ModifierKeys.None, Settings.Default.QuickloadKey);

            autoStartToolStripMenuItem.Checked = Settings.Default.Autostart;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start autobackup when the form is loaded, if the settings are valid
            var validationResult = Utils.ValidateSettings(Settings.Default.SaveFile, Settings.Default.BackupDir);
            if (!validationResult.Valid)
                new FormOptions().ShowDialog();

            if (ResetAutobackup() && Settings.Default.Autostart) buttonStart_Click(sender, e);

            UpdateStatusLabels();
        }

        //private void KeyHook_KeyPressed(object sender, KeyPressedEventArgs e)
        //{
        //    if (e.Key == Settings.Default.QuicksaveKey)
        //    {
        //        SystemSounds.Beep.Play();
        //        saveMan.CreateBackup(QUICKSAVE_FILENAME);
        //    }
        //    else if (e.Key == Settings.Default.QuickloadKey)
        //    {
        //        SystemSounds.Beep.Play();
        //        saveMan.RestoreBackup(QUICKSAVE_FILENAME);
        //    }
        //}

        private void restoreSavefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new FormRestore(saveMan).ShowDialog();
            }
            catch { }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void autoStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoStartToolStripMenuItem.Checked = !autoStartToolStripMenuItem.Checked;
            Settings.Default.Autostart = autoStartToolStripMenuItem.Checked;
            Settings.Default.Save();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonStop_Click(sender, e);
            new FormOptions().ShowDialog();
            ResetAutobackup();
        }

        private void openBackupFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Settings.Default.BackupDir);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }

        private void buttonRefreshStatus_Click(object sender, EventArgs e)
        {
            UpdateStatusLabels();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerSave.Start();

            statusStrip1.Visible = true;
            buttonStop.Enabled = true;
            buttonStart.Enabled = false;

            // Tick once when start is clicked
            timerSave_Tick(sender, e);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerSave.Stop();

            statusStrip1.Visible = false;
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        private void buttonManual_Click(object sender, EventArgs e)
        {
            // Restart timer if timer is started
            if (timerSave.Enabled)
            {
                timerSave.Stop();
                timerSave.Start();
            }

            timerSave_Tick(sender, e);
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if (timerSave.Enabled)
            {
                toolStripStatusLabelTimer.Text = (timeStarted + TimeSpan.FromMilliseconds(timerSave.Interval) - DateTime.Now).ToString(@"mm\:ss");
            }
            else
            {

            }
        }

        private void timerSave_Tick(object sender, EventArgs e)
        {
            try
            {
                timeStarted = DateTime.Now;
                string destFileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".sl2";
                saveMan.CreateBackup(destFileName);
                UpdateStatusLabels();
            }
            catch (Exception ex)
            {
                buttonStop_Click(sender, e);
                MessageBox.Show("Failed to create backup. Check your settings!\n\n" + ex.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool ResetAutobackup()
        {
            try
            {
                buttonStop_Click(null, null);
                timerSave.Interval = (int)Settings.Default.Interval.TotalMilliseconds;
                saveMan = new SaveManager(Settings.Default.SaveFile, Settings.Default.BackupDir, Settings.Default.MaxBackups);
                UpdateStatusLabels();
                return true;
            }
            catch
            {
                //MessageBox.Show("Invalid settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void UpdateStatusLabels()
        {
            string lastbackup = "";
            string autoCount = "";
            string stickyCount = "";

            try
            {
                lastbackup = saveMan.GetLatestBackup().CreationTime.ToString();
                autoCount = saveMan.GetAutoBackupFiles().Length + "/" + saveMan.MaxBackups;
                stickyCount = saveMan.GetManualBackupFiles().Length.ToString();
            }
            catch
            {

            }

            labelLastBackup.Text = lastbackup;
            labelAutoCount.Text = autoCount;
            labelStickyCount.Text = stickyCount;
        }
    }
}
