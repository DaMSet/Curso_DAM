using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U3_E10_Jardinería_Repaso.DLL;

namespace U3_E10_Jardinería_Repaso
{
    public partial class Añadir : Form
    {
        public Añadir()
        {
            InitializeComponent();

            ProductoDLL productoDLL = new ProductoDLL();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductoDLL productoDLL = new ProductoDLL();
            productoDLL.AgregarGama(txtGama.Text);
            productoDLL.AgregarProducto(txtCodigoProducto.Text,txtNombre.Text,txtGama.Text,txtDimensiones.Text,txtProveedor.Text,txtDescripcion.Text,int.Parse(txtStock.Text), double.Parse(txtPrecioVenta.Text), double.Parse(txtProveedor.Text));

        }
    }
}
