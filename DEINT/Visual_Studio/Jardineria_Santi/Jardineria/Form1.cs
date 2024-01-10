using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jardineria
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

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FormAgregarProducto form = new FormAgregarProducto();
            form.ShowDialog();
        }

        private void btnEliminarGama_Click(object sender, EventArgs e)
        {
            FormEliminarGama form = new FormEliminarGama();
            form.ShowDialog();
        }

        private void btnConsultarPedido_Click(object sender, EventArgs e)
        {
            FormConsultarPedidos form = new FormConsultarPedidos();
            form.ShowDialog();
        }

        private void btnConsultarEmpleado_Click(object sender, EventArgs e)
        {
            FormConsultarEmpleado form = new FormConsultarEmpleado();
            form.ShowDialog();
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            FormConsultarClientes form = new FormConsultarClientes();
            form.ShowDialog();
        }

        private void btnConsultarPrecios_Click(object sender, EventArgs e)
        {
            FormConsultarPrecios form = new FormConsultarPrecios();
            form.ShowDialog();
        }
    }
}
