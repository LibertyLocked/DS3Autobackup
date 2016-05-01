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
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonSource_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/libertylocked/ds3autobackup");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
