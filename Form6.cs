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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Zde pouze zvolím otázku, kterou chci položit uživateli a následně kontroluji zda se jeho odpověď rovná ano nebo ne
            if (MessageBox.Show("Opravdu chcete zpět?", "Zpět", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Zavření aplikace
                this.Close();
                Form3 form3 = new Form3();
                form3.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
