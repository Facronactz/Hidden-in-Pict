using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace Hidden_in_Pict
{
    public partial class fHelp : Form
    {
        public fHelp()
        {
            InitializeComponent();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            string fText = "Readme.txt";
            if (!File.Exists(fText))
                File.WriteAllText(fText, Properties.Resources.ReadMe);
            Process.Start("notepad.exe", fText);
        }
    }
}
