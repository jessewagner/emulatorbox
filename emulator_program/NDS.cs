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
    public partial class NDS : Form
    {
        public NDS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMULATORBOX.fileOpener("DeSmuME_0.9.10_x86.exe", "DeSmu", "Nintendo DS Roms");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EMULATORBOX.emulatorOpener("DeSmuME_0.9.10_x86.exe", "DeSmu");
        }
    }
}
