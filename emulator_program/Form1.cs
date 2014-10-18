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

        private void button1_Click(object sender, EventArgs e)
        {
            //Button to start the NES Emulator
            string myFileName = "nestopia.exe";
            string root = Path.GetFullPath(myFileName);
            root = root.Remove(3);
            string path = Path.Combine(root, "Nestopia 1.4", myFileName);
            Process startProgram = new Process();
            startProgram.StartInfo.FileName = path;
            startProgram.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Button to start the SNES Emulator
            string myFileName = "snes9x.exe";
            string root = Path.GetFullPath(myFileName);
            root = root.Remove(3);
            string path = Path.Combine(root, "Snes9x 1.52", myFileName);
            Process startProgram = new Process();
            startProgram.StartInfo.FileName = path;
            startProgram.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Button to start the Genesis Emulator
            string myFileName = "Fusion.exe";
            string root = Path.GetFullPath(myFileName);
            root = root.Remove(3);
            string path = Path.Combine(root, "Genesis", "Fusion364", myFileName);
            Process startProgram = new Process();
            startProgram.StartInfo.FileName = path;
            startProgram.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Button to start the NEOGEO/CAPCOM Emulator
            string myFileName = "WinKawaks.exe";
            string root = Path.GetFullPath(myFileName);
            root = root.Remove(3);
            string path = Path.Combine(root, "Kawaks", myFileName);
            Process startProgram = new Process();
            startProgram.StartInfo.FileName = path;
            startProgram.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Button to start the Nintendo 64 Emulator
            string myFileName = "Project64.exe";
            string root = Path.GetFullPath(myFileName);
            root = root.Remove(3);
            string path = Path.Combine(root, "Project64", myFileName);
            Process startProgram = new Process();
            startProgram.StartInfo.FileName = path;
            startProgram.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Button to start the GameBoy Advance and GameBoy Emulator
            string myFileName = "VisualBoyAdvance-M.exe";
            string root = Path.GetFullPath(myFileName);
            root = root.Remove(3);
            string path = Path.Combine(root, "VisualBoyAdvance-M", myFileName);
            Process startProgram = new Process();
            startProgram.StartInfo.FileName = path;
            startProgram.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Button to start the Nintendo DS Emulator
            string myFileName = "DeSmuME_0.9.10_x86.exe";
            string root = Path.GetFullPath(myFileName);
            root = root.Remove(3);
            string path = Path.Combine(root, "DeSmu", myFileName);
            Process startProgram = new Process();
            startProgram.StartInfo.FileName = path;
            startProgram.Start();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
