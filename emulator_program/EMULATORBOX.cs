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
using System.Xml;

namespace emulator_program
{
    public partial class EMULATORBOX : Form
    {
        private string romFolder;
        private string nesExe;
        private string nesFolder;
        private string nesRomLocation;
        private string snesExe;
        private string snesFolder;
        private string snesRomLocation;
        private string n64Exe;
        private string n64Folder;
        private string n64RomLocation;
        private string gameboyExe;
        private string gameboyFolder;
        private string gameboyRomLocation;
        private string NDSExe;
        private string NDSFolder;
        private string NDSRomLocation;
        private string genesisExe;
        private string genesisFolder;
        private string genesisRomLocation;
        private string neoGeoExe;
        private string neoGeoFolder;
        //this doesn't get used, just makes things easier with the xmlParser
        private string neoGeoRomLocation;

        public EMULATORBOX()
        {
            try
            {
                XmlTextReader reader = new XmlTextReader("user_settings.xml");

                xmlParser(reader, out romFolder);
                xmlParser(reader, "nes", out nesExe, out nesFolder, out nesRomLocation);
                xmlParser(reader, "snes", out snesExe, out snesFolder, out snesRomLocation);
                xmlParser(reader, "n64", out n64Exe, out n64Folder, out n64RomLocation);
                xmlParser(reader, "gameboy", out gameboyExe, out gameboyFolder, out gameboyRomLocation);
                xmlParser(reader, "NDS", out NDSExe, out NDSFolder, out NDSRomLocation);
                xmlParser(reader, "genesis", out genesisExe, out genesisFolder, out genesisRomLocation);
                xmlParser(reader, "neogeo", out neoGeoExe, out neoGeoFolder, out neoGeoRomLocation);
                
                InitializeComponent();
            }
            catch(Exception ex)
            {
                MessageBox.Show("The program has encountered an error: " + ex.Message);
                this.Close();
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
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
            fileOpener(nesExe, nesFolder, nesRomLocation, romFolder);
        }

        private void nesEmuOpenButton_Click(object sender, EventArgs e)
        {
            emulatorOpener(nesExe, nesFolder);
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
            fileOpener(snesExe, snesFolder, snesRomLocation, romFolder);
        }

        private void snesEmuOpenButton_Click(object sender, EventArgs e)
        {
            emulatorOpener(snesExe, snesFolder);
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
            fileOpener(n64Exe, n64Folder, n64RomLocation, romFolder);
        }

        private void n64EmuOpenButton_Click(object sender, EventArgs e)
        {
            emulatorOpener(n64Exe, n64Folder);
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
            fileOpener(gameboyExe, gameboyFolder, gameboyRomLocation, romFolder);
        }

        private void gameboyEmuOpenButton_Click(object sender, EventArgs e)
        {
            emulatorOpener(gameboyExe, gameboyFolder);
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
            fileOpener(NDSExe, NDSFolder, NDSRomLocation, romFolder);
        }

        private void NDSEmuOpenButton_Click(object sender, EventArgs e)
        {
            emulatorOpener(NDSExe, NDSFolder);
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
            fileOpener(genesisExe, genesisFolder, genesisRomLocation, romFolder);
        }

        private void genesisEmuOpenButton_Click(object sender, EventArgs e)
        {
            emulatorOpener(genesisExe, genesisFolder);
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
            emulatorOpener(neoGeoExe, neoGeoFolder);
        }
        #endregion

        #region "fileOpener section"
        private static void fileOpener(string fileName, string pathName, string searchPath, string romFolder)
        {
            try
            {
                string myFileName = fileName;
                string root = Path.GetFullPath(myFileName);
                root = root.Remove(3);
                string FBDpath = Path.Combine(root, romFolder, searchPath);
                OpenFileDialog OFD = new OpenFileDialog();
                OFD.Multiselect = false;
                OFD.InitialDirectory = FBDpath;
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                        string path = Path.Combine(root, pathName, myFileName);
                        string path2 = string.Format("\"{0}\"", OFD.FileName);
                        Process startProgram = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo(path);
                        startInfo.Arguments = path2;
                        Process.Start(startInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "emulatorOpener section"
        private static void emulatorOpener(string fileName, string pathName)
        {
            try
            {
                string myFileName = fileName;
                string root = Path.GetFullPath(myFileName);
                root = root.Remove(3);
                string path = Path.Combine(root, pathName, myFileName);
                Process startProgram = new Process();
                startProgram.StartInfo.FileName = path;
                startProgram.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "xmlParser section"
        private static void xmlParser(XmlTextReader reader, out string romFolder)
        {
            reader.ReadToFollowing("rom_folder");
            romFolder = reader.ReadElementContentAsString();
        }

        private static void xmlParser(XmlTextReader reader, string panelName, out string executable, out string folder, out string romLocation)
        {
            try
            {
                reader.ReadToFollowing(panelName);
                if (reader.EOF)
                {
                    executable = null;
                    folder = null;
                    romLocation = null;
                    return;
                }
                reader.ReadToFollowing("executable");
                executable = reader.ReadElementContentAsString();
                reader.ReadToFollowing("folder");
                folder = reader.ReadElementContentAsString();
                reader.ReadToFollowing("rom_location");
                romLocation = reader.ReadElementContentAsString();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
