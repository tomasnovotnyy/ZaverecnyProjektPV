using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Zde pouze zvolím otázku, kterou chci položit uživateli a následně kontroluji zda se jeho odpověď rovná ano nebo ne
            if (MessageBox.Show("Opravdu chcete zpět na domovskou obrazovku?", "Home", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Zavření aplikace
                this.Close();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
