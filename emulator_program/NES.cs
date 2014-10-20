﻿using System;
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
            EMULATORBOX.fileOpener("nestopia.exe", "Nestopia 1.4", "Nintendo Roms");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EMULATORBOX.emulatorOpener("nestopia.exe", "Nestopia 1.4");
        }
    }
}
