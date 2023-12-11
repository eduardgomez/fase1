using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Factura1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=DESKTOP-LGO655M\\SQLEXPRESS;database=factura; integrated security=true");
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            conexion.Open();
            string consulta = "select * from usuario where celular ='"textBox1.Text"'";
        }
    }
}
