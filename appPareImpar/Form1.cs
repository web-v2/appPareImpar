namespace appPareImpar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(textBox1.Text);

            if (dato %2 == 0 ) {
                MessageBox.Show("El n�mero " + dato + " es ***PAR***");
            }
            else
            {
                MessageBox.Show("El n�mero " + dato + " es ***IMPAR***");
            }

            textBox1.ResetText();
            textBox1.Focus();
        }
    }
}