using System.Windows.Forms;

namespace Factura1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Form2();
            formulario1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario2 = new Form4();
            formulario2.Show();


        }
    }
}