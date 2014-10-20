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
    public partial class N64 : Form
    {
        public N64()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMULATORBOX.fileOpener("Project64.exe", "Project64", "Nintendo 64 Roms");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EMULATORBOX.emulatorOpener("Project64.exe", "Project64");
        }
    }
}
