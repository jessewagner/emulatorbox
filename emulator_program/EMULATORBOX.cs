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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region "nes section"
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            nesPanel.Visible = true;
            mainPanel.Visible = false;
        }

        private void nesBackButton_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            nesPanel.Visible = false;
        }

        private void nesOpenFileButton_Click(object sender, EventArgs e)
        {
            fileOpener("nestopia.exe", "Nestopia 1.4", "Nintendo Roms");
        }

        private void nesEmuOpenButton_Click(object sender, EventArgs e)
        {
            emulatorOpener("nestopia.exe", "Nestopia 1.4");
        }
        #endregion

        #region "snes section"
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            snesPanel.Visible = true;
            mainPanel.Visible = false;
        }

        private void snesBackButton_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            snesPanel.Visible = false;
        }

        private void snesOpenFileButton_Click(object sender, EventArgs e)
        {
            fileOpener("snes9x.exe", "Snes9x 1.52", "Super Nintendo Roms");
        }

        private void snesEmuOpenButton_Click(object sender, EventArgs e)
        {
            emulatorOpener("snes9x.exe", "Snes9x 1.52");
        }
        #endregion

        #region "n64 section"
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            n64Panel.Visible = true;
            mainPanel.Visible = false;
        }

        private void n64BackButton_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            n64Panel.Visible = false;
        }

        private void n64OpenFileButton_Click(object sender, EventArgs e)
        {
            fileOpener("Project64.exe", "Project64", "Nintendo 64 Roms");
        }

        private void n64EmuOpenButton_Click(object sender, EventArgs e)
        {
            emulatorOpener("Project64.exe", "Project64");
        }
        #endregion

        #region "gameboy section"
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            gameboyPanel.Visible = true;
            mainPanel.Visible = false;
        }

        private void gameboyBackButton_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            gameboyPanel.Visible = false;
        }

        private void gameboyOpenFileButton_Click(object sender, EventArgs e)
        {
            fileOpener("VisualBoyAdvance-M.exe", "VisualBoyAdvance-M", "Nintendo Advance Roms");
        }

        private void gameboyEmuOpenButton_Click(object sender, EventArgs e)
        {
            emulatorOpener("VisualBoyAdvance-M.exe", "VisualBoyAdvance-M");
        }
        #endregion

        #region "NDS section"
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            NDSPanel.Visible = true;
            mainPanel.Visible = false;
        }

        private void NDSBackButton_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            NDSPanel.Visible = false;
        }

        private void NDSOpenFileButton_Click(object sender, EventArgs e)
        {
            fileOpener("DeSmuME_0.9.10_x86.exe", "DeSmu", "Nintendo DS Roms");
        }

        private void NDSEmuOpenButton_Click(object sender, EventArgs e)
        {
            emulatorOpener("DeSmuME_0.9.10_x86.exe", "DeSmu");
        }
        #endregion

        #region "genesis section"
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            genesisPanel.Visible = true;
            mainPanel.Visible = false;
        }

        private void genesisBackButton_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            genesisPanel.Visible = false;
        }

        private void genesisOpenFileButton_Click(object sender, EventArgs e)
        {
            fileOpener("Fusion.exe", "Fusion364", "Genesis Roms");
        }

        private void genesisEmuOpenButton_Click(object sender, EventArgs e)
        {
            emulatorOpener("Fusion.exe", "Fusion364");
        }
        #endregion

        #region "neogeo section"
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            neogeoPanel.Visible = true;
            mainPanel.Visible = false;
        }

        private void neogeoBackButton_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            neogeoPanel.Visible = false;
        }

        private void neogeoEmuOpenButton_Click(object sender, EventArgs e)
        {
            emulatorOpener("WinKawaks.exe", "Kawaks");
        }
        #endregion

        #region "fileOpener section"
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
        #endregion

        #region "emulatorOpener section"
        public static void emulatorOpener(string fileName, string pathName)
        {
            string myFileName = fileName;
            string root = Path.GetFullPath(myFileName);
            root = root.Remove(3);
            string path = Path.Combine(root, pathName, myFileName);
            Process startProgram = new Process();
            try
            {
                startProgram.StartInfo.FileName = path;
                startProgram.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
