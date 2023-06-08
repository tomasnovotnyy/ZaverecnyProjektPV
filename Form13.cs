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
    public partial class Form13 : Form
    {
        public Form13()
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
                Form10 form10 = new Form10();
                form10.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string inputText = inputTextBox.Text;
                string encodedText = CaesarCipherEncoding.Encode(inputText);
                encodedTextBox.Text = encodedText;
                inputTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Někde nastala chyba, zkuste to prosím znovu...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputTextBox.Clear();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string inputText = inputTextBox2.Text;
                string decodedText = CaesarCipherEncoding.Decode(inputText);
                encodedTextBox2.Text = decodedText;
                inputTextBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Někde nastala chyba, zkuste to prosím znovu...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputTextBox2.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            inputTextBox2.Clear();
            encodedTextBox.Clear();
            encodedTextBox2.Clear();
        }
    }
}
