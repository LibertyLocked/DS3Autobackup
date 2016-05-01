using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ScumLib
{
    public class SaveManager
    {
        static object fileLock = new object();

        //const string QUICKSAVE_FILENAME = "quicksave.sl2";
        const string AUTO_PREFIX = "AUTO_";

        public DirectoryInfo BackupDirectory { get; private set; }
        public FileInfo SaveFile { get; private set; }
        public int MaxBackups { get; private set; }

        public SaveManager(string saveFilename, string backupDir, int maxBackups)
        {
            BackupDirectory = new DirectoryInfo(backupDir);
            SaveFile = new FileInfo(saveFilename);
            MaxBackups = maxBackups;
        }

        public FileInfo CreateBackup(string destFileName)
        {
            lock (fileLock)
            {
                // Check if reached max backups
                var files = GetAutoBackupFiles();
                if (files.Length >= MaxBackups)
                {
                    // Delete the oldest
                    GetOldestBackup().Delete();
                }

                var backup = SaveFile.CopyTo(GetBackupFileInfo(AUTO_PREFIX + destFileName).FullName, true);
                return backup;
            }
        }

        public void RestoreBackup(string destFileName)
        {
            lock (fileLock)
            {
                var backup = GetBackupFileInfo(destFileName);
                backup.CopyTo(SaveFile.FullName, true);
            }
        }

        public FileInfo[] GetBackupFiles()
        {
            return BackupDirectory.GetFiles("*.sl2");
        }

        public FileInfo[] GetAutoBackupFiles()
        {
            var files = GetBackupFiles();
            return files.Where(info => info.Name.StartsWith(AUTO_PREFIX)).ToArray();
        }

        public FileInfo[] GetManualBackupFiles()
        {
            var files = GetBackupFiles();
            return files.Where(info => !info.Name.StartsWith(AUTO_PREFIX)).ToArray();
        }

        public FileInfo GetOldestBackup()
        {
            var files = GetBackupFiles();
            var min = files.Min(info => info.CreationTime);
            return files.Where(info => info.CreationTime == min).First();
        }

        public FileInfo GetLatestBackup()
        {
            var files = GetBackupFiles();
            var max = files.Max(info => info.CreationTime);
            return files.Where(info => info.CreationTime == max).First();
        }

        private FileInfo GetBackupFileInfo(string filename)
        {
            return new FileInfo(Path.Combine(BackupDirectory.FullName, filename));
        }
    }
}
