using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Hidden_in_Pict.Properties;

namespace Hidden_in_Pict
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Path = @"C:\Program Files\WinRAR\WinRAR.exe";
            if (!File.Exists(Path)){
                MessageBox.Show("This Program need winrar to run","Warning!", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
                System.Environment.Exit(1);
            }
            MessageBox.Show("Please open help, everything you need was in there", "Please", MessageBoxButtons.OK);
        }

        private void BBrowse_Click(object sender, EventArgs e)
        {
            if (opImage.ShowDialog() == DialogResult.OK)
            {
                var found = false;
                var line = new StreamReader(opImage.FileName);
                while (!line.EndOfStream)
                {
                    var ini = line.ReadLine();
                    if (ini.Contains("Rar!"))
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    DialogResult dResult = MessageBox.Show("File already have rar inside it, you want to open it?","RAR Exist", MessageBoxButtons.OKCancel);
                    if (dResult == DialogResult.OK)
                        Process.Start("winrar.exe", string.Format(@"""{0}""", opImage.FileName));
                    else if (dResult == DialogResult.Cancel)
                    tbFileImage.Text = "";
                }
                else
                    tbFileImage.Text = opImage.FileName;
            }
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            System.Environment.Exit(1);
        }

        private void BBrowseArchive_Click(object sender, EventArgs e)
        {
            if (opArchive.ShowDialog() == DialogResult.OK)
            {
                tbFileArchive.Text = opArchive.FileName;
            }
        }

        private void BProcess_Click(object sender, EventArgs e)
        {
            if (File.Exists(tbFileArchive.Text) && File.Exists(tbFileImage.Text))
            {
                if (cbCMD.Checked == true)
                {
                    string vRar = tbFileArchive.Text;
                    string vPict = tbFileImage.Text;
                    string thefile = Path.GetDirectoryName(tbFileImage.Text);
                    System.Threading.Thread.Sleep(5000);
                    Process cmd = Process.Start("cmd", string.Format(@"/K copy /b ""{0}"" + ""{1}"" ""{0}"" && exit", vPict, vRar));
                    cmd.WaitForExit();
                    MessageBox.Show(string.Format(@"Done, [{0}] has been hidden inside [{1}]", vRar, vPict));
                    Process.Start("explorer.exe", thefile);
                    tbFileImage.Text = "";
                    tbFileArchive.Text = "";
                }
                else if (cbCMD.Checked == false)
                {
                    MessageBox.Show("There are no other method than CMD");
                }
            }
            else
                MessageBox.Show("The program cannot find the file specified");
        }

        private void BHelp_Click(object sender, EventArgs e)
        {
            fHelp f2 = new fHelp();
            f2.ShowDialog();
        }
    }
}
