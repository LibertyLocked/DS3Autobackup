using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ScumLib
{
    class Save
    {
        public FileInfo File { get; private set; }
        public DateTime BackupTime { get; private set; }

        public Save()
        {

        }
    }
}
