namespace ZaverecnyProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Button pro ukon�en� aplikace
        // U�ivatel tak m��e ukon�it aplikaci bu� k��kem v prav�m horn�m rohu nebo tla��tkem Exit
        private void button4_Click(object sender, EventArgs e)
        {
            // Zde pouze zvol�m ot�zku, kterou chci polo�it u�ivateli a n�sledn� kontroluji zda se jeho odpov�� rovn� ano nebo ne
            if (MessageBox.Show("Opravdu chcete ukon�it aplikaci?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Zav�en� aplikace
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // zav�e aktu�ln� formu (Form1)
            Form2 form2 = new Form2(); // vytvo�� novou instanci druh� formy
            form2.ShowDialog(); // zobraz� druhou formu na obrazovce
            form2 = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // zav�e aktu�ln� formu (Form1)
            Form3 form3 = new Form3(); // vytvo�� novou instanci t�et� formy
            form3.ShowDialog(); // zobraz� t�et� formu na obrazovce
            form3 = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // zav�e aktu�ln� formu (Form1)
            Form4 form4 = new Form4(); // vytvo�� novou instanci �tvrt� formy
            form4.ShowDialog(); // zobraz� �tvrtou formu na obrazovce
            form4 = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}