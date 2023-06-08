using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnyProjekt
{
    public partial class Form4 : Form
    {
        public Form4()
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string directory = @"graph.txt";
                Graph g = new Graph();

                // InputBox pro zadání kořene stromu
                string input = Microsoft.VisualBasic.Interaction.InputBox("Zadejte kořen stromu:", "Kořen");

                // převod řetězce na číslo
                int YourRoot;
                bool isNumeric = int.TryParse(input, out YourRoot);

                // zobrazení odpovídající zprávy
                if (isNumeric)
                {
                    Node root = new Node(YourRoot);
                    g.SetRoot(root);
                    MessageBox.Show($"Graf s kořenem {g.GetRoot().value}", "Kořen");

                    // InputBox pro zadání počtu uzlů
                    string InputOfNumberOfNodes = Microsoft.VisualBasic.Interaction.InputBox("Vyberte si počet uzlů, které chcete zadávat: ", "Počet uzlů");

                    // převod řetězce na číslo
                    int NumOfNodes;
                    bool isNumeric2 = int.TryParse(InputOfNumberOfNodes, out NumOfNodes);

                    int[] arr = new int[NumOfNodes + 1];
                    arr[0] = YourRoot;

                    // zobrazení odpovídající zprávy
                    if (isNumeric2)
                    {
                        do
                        {
                            string InputOfNodes = Microsoft.VisualBasic.Interaction.InputBox("Zadejte čislo nějakého uzlu a neopakujte stejná čísla: ", "Zadávání uzlů");
                            int Node;
                            bool isNumeric3 = int.TryParse(InputOfNodes, out Node);

                            if (isNumeric3)
                            {
                                g.VlozeniHodnoty(root, Node);
                                for (int i = 1; i <= NumOfNodes; i++)
                                {
                                    arr[i] = Node;
                                }
                                NumOfNodes--;
                            }
                            else
                            {
                                Interaction.MsgBox("Nezadali jste žádnou hodnotu uzlu nebo jste zadali neplatnou hodnotu", MsgBoxStyle.Information, "Špatně");
                            }
                        } while (NumOfNodes != 0);

                        MessageBox.Show($"Počet vrcholů v grafu {g.CountNodes(root)}", "Počet vrcholů");
                        MessageBox.Show(root.PrintTree(), "Výsledný graf");

                        if (MessageBox.Show("Přejete si tento graf uložit?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Form8 form8 = new Form8(); // vytvoří novou instanci formy
                            form8.ShowDialog(); // zobrazí formu na obrazovce
                            form8 = null;

                            // Uložení grafu do textového souboru
                            int numberOfPrintedGraphs = 0;

                            // Knotrola zda již soubor existuje
                            if (File.Exists(directory))
                            {
                                string[] lines = File.ReadAllLines(directory);
                                for (int i = 0; i < lines.Length; i++)
                                {
                                    if (lines.Length > 0 && lines[i].StartsWith("Graph "))
                                    {
                                        if (int.TryParse(lines[i].Substring("Graph ".Length), out int count))
                                        {
                                            numberOfPrintedGraphs = count;
                                        }
                                    }
                                }
                            }

                            numberOfPrintedGraphs++;
                            string graf = $"Graph {numberOfPrintedGraphs}\n{root.PrintTree()}";
                            File.AppendAllText(directory, graf);

                            MessageBox.Show($"Seřazování čísel -->");
                            MessageBox.Show($"{g.InOrder(root)}", "InOrder");
                            MessageBox.Show($"{g.PreOrder(root)}", "PreOrder");
                            MessageBox.Show($"{g.PostOrder(root)}", "PostOrder");
                            MessageBox.Show($"{HeapSort.Sort(arr)}", "HeapSort");
                            QuickSort.Sort(arr, 0, arr.Length - 1);
                            MessageBox.Show(string.Join(" ", arr), "QuickSort");
                        }
                        else
                        {
                            MessageBox.Show($"Seřazování čísel -->");
                            MessageBox.Show($"{g.InOrder(root)}", "InOrder");
                            MessageBox.Show($"{g.PreOrder(root)}", "PreOrder");
                            MessageBox.Show($"{g.PostOrder(root)}", "PostOrder");
                            MessageBox.Show($"{HeapSort.Sort(arr)}", "HeapSort");
                            QuickSort.Sort(arr, 0, arr.Length - 1);
                            MessageBox.Show(string.Join(" ", arr), "QuickSort");
                        }
                    }
                    else
                    {
                        Interaction.MsgBox("Nezadali jste žádný počet uzlů nebo jste zadali neplatnou hodnotu", MsgBoxStyle.Information, "Špatně");
                    }
                }
                else
                {
                    Interaction.MsgBox("Nezadali jste žádný kořen stromu nebo jste zadali neplatnou hodnotu", MsgBoxStyle.Information, "Špatně");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form5 = new Form5();
            form5.ShowDialog();
            form5 = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form10 = new Form10();
            form10.ShowDialog();
            form10 = null;
        }
    }
}
