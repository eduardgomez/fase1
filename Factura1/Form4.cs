using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void View1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string precio = this.textBox4.Text;
            string cantidad = this.textBox3.Text;
            string celular = this.textBox1.Text;
            string codigo = this.textBox2.Text;

            this.View1.Rows.Add(codigo, precio, cantidad, Total, celular);
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();

        }
    }
}
