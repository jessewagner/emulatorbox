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
    public partial class SNES : Form
    {
        public SNES()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMULATORBOX.fileOpener("snes9x.exe", "Snes9x 1.52", "Super Nintendo Roms");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EMULATORBOX.emulatorOpener("snes9x.exe", "Snes9x 1.52");
        }
    }
}
