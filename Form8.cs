﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnyProjekt
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 10;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
            }
        }
    }
}
