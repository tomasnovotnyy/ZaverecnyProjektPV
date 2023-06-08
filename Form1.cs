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

        // Button pro ukonèení aplikace
        // Uživatel tak mùže ukonèit aplikaci buï køížkem v pravém horním rohu nebo tlaèítkem Exit
        private void button4_Click(object sender, EventArgs e)
        {
            // Zde pouze zvolím otázku, kterou chci položit uživateli a následnì kontroluji zda se jeho odpovìï rovná ano nebo ne
            if (MessageBox.Show("Opravdu chcete ukonèit aplikaci?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Zavøení aplikace
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // zavøe aktuální formu (Form1)
            Form2 form2 = new Form2(); // vytvoøí novou instanci druhé formy
            form2.ShowDialog(); // zobrazí druhou formu na obrazovce
            form2 = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // zavøe aktuální formu (Form1)
            Form3 form3 = new Form3(); // vytvoøí novou instanci tøetí formy
            form3.ShowDialog(); // zobrazí tøetí formu na obrazovce
            form3 = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // zavøe aktuální formu (Form1)
            Form4 form4 = new Form4(); // vytvoøí novou instanci ètvrté formy
            form4.ShowDialog(); // zobrazí ètvrtou formu na obrazovce
            form4 = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}