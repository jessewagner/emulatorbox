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
using System.Diagnostics;

namespace emulator_program
{
    public partial class NES : Form
    {
        public NES()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myFileName = "nestopia.exe";
            string root = Path.GetFullPath(myFileName);
            root = root.Remove(3);
            string FBDpath = Path.Combine(root, "Roms", "Nintendo Roms");
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Multiselect = false;
            OFD.InitialDirectory = FBDpath;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = Path.Combine(root, "Nestopia 1.4", myFileName);
                    string path2 = string.Format("\"{0}\"", OFD.FileName);
                    Process startProgram = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo(path);
                    startInfo.Arguments = path2;
                    Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string myFileName = "nestopia.exe";
            string root = Path.GetFullPath(myFileName);
            root = root.Remove(3);
            string path = Path.Combine(root, "Nestopia 1.4", myFileName);
            Process startProgram = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo(path);
            Process.Start(startInfo);
        }
    }
}
