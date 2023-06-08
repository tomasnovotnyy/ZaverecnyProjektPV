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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form9 = new Form9();
            form9.ShowDialog();
            form9 = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form11 = new Form11();
            form11.ShowDialog();
            form11 = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Zde pouze zvolím otázku, kterou chci položit uživateli a následně kontroluji zda se jeho odpověď rovná ano nebo ne
            if (MessageBox.Show("Opravdu chcete zpět?", "Zpět", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Zavření aplikace
                this.Close();
                Form4 form4 = new Form4();
                form4.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form13 = new Form13();
            form13.ShowDialog();
            form13 = null;
        }
    }
}
