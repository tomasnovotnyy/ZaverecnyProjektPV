using Microsoft.VisualBasic;
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
    public partial class Form5 : Form
    {
        public Form5()
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
                Form4 form4 = new Form4();
                form4.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // InputBox pro zadání počátečního vrcholu
                string input = Microsoft.VisualBasic.Interaction.InputBox("Zadejte počáteční vrchol v rozmezí od 0-3:", "Počáteční vrchol");

                // převod řetězce na číslo
                int YourSource;
                bool isNumeric = int.TryParse(input, out YourSource);

                // zobrazení odpovídající zprávy
                if (isNumeric && YourSource >= 0 && YourSource <= 3)
                {
                    int[,] graph =  {
                          { 0, 2, 0, 0 },
                          { 2, 0, 3, 0 },
                          { 0, 3, 0, 4 },
                          { 0, 0, 4, 0 }
                         };
                    MessageBox.Show(Dijkstra.DijkstraAlgo(graph, YourSource, 4));

                }
                else
                {
                    Interaction.MsgBox("Nezadali jste žádný počáteční vrchol nebo jste zadali neplatnou hodnotu", MsgBoxStyle.Information, "Špatně");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
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
    }
}
