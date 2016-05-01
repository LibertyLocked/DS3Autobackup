using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DS3Autosaver
{
    struct ValidationResult
    {
        public readonly bool Valid;
        public readonly string Message;

        public ValidationResult(bool valid, string message)
        {
            Valid = valid;
            Message = message;
        }
    }

    class Utils
    {
        public static ValidationResult ValidateSettings(string saveFile, string backupDir)
        {
            bool valid = true;
            string message = "";
            
            // Check save file
            if (!File.Exists(saveFile))
            {
                valid = false;
                message += "Save file does not exist\n";
            }

            // Check backup dir
            if (!Directory.Exists(backupDir))
            {
                valid = false;
                message += "Backup directory does not exist\n";
            }

            return new ValidationResult(valid, message);
        }
    }
}
