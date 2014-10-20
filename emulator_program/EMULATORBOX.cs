// COPYRIGHT 2014 JESSE WAGNER ALL RIGHTS RESERVED

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace emulator_program
{
    public partial class EMULATORBOX : Form
    {
        public EMULATORBOX()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NES nes = new NES();
            nes.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SNES snes = new SNES();
            snes.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            N64 n64 = new N64();
            n64.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            GameBoy gameboy = new GameBoy();
            gameboy.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            NDS nds = new NDS();
            nds.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Genesis genesis = new Genesis();
            genesis.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            NEOGEO neogeo = new NEOGEO();
            neogeo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void fileOpener(string fileName, string pathName, string searchPath)
        {
            string myFileName = fileName;
            string root = Path.GetFullPath(myFileName);
            root = root.Remove(3);
            string FBDpath = Path.Combine(root, "Roms", searchPath);
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Multiselect = false;
            OFD.InitialDirectory = FBDpath;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = Path.Combine(root, pathName, myFileName);
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

        public static void emulatorOpener(string fileName, string pathName)
        {
            string myFileName = fileName;
            string root = Path.GetFullPath(myFileName);
            root = root.Remove(3);
            string path = Path.Combine(root, pathName, myFileName);
            Process startProgram = new Process();
            startProgram.StartInfo.FileName = path;
            startProgram.Start();
        }
    }
}
