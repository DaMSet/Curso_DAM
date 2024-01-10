using Jardineria.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jardineria
{
    public partial class FormAgregarProducto : Form
    {
        private Servicio.Servicio servicio;
        public FormAgregarProducto()
        {
            InitializeComponent();

            servicio = Servicio.Servicio.getInstace();
        }

        private void FormAgregarProducto_Load(object sender, EventArgs e)
        {
            List<String> gamas = servicio.getListaGamasNombre();

            foreach (var item in gamas)
            {
                cmBoxGama.Items.Add(item);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            servicio.AgregarProducto(txtCodigoProducto.Text, txtNombre.Text, cmBoxGama.SelectedItem.ToString(), txtDimensiones.Text, txtProveedor.Text, txtDescripcion.Text, txtCantidadStock.Text, txtPrecioVenta.Text, txtPrecioProveedor.Text);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtNombre.Text, @"^[A-Za-z]+$"))
            {
                errorNombre.SetError(txtNombre, "Datos invalidos");
                e.Cancel = true;
            }
            else
            {
                errorNombre.SetError(txtNombre, "");
                e.Cancel = false;
            }

        }


        private void txtDimensiones_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtDimensiones.Text, @"^\w+$"))
            {
                errorDimensiones.SetError(txtDimensiones, "Datos invalidos");
                e.Cancel = true;
            }
            else
            {
                errorDimensiones.SetError(txtDimensiones, "");
                e.Cancel = false;
            }
        }

        private void txtProveedor_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtProveedor.Text, @"^[A-Za-z]+$"))
            {
                errorProveedor.SetError(txtProveedor, "Datos invalidos");
                e.Cancel = true;
            }
            else
            {
                errorProveedor.SetError(txtProveedor, "");
                e.Cancel = false;
            }
        }

        private void txtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtDescripcion.Text, @"^[A-Za-z]+$"))
            {
                errorDescripcion.SetError(txtDescripcion, "Datos invalidos");
                e.Cancel = true;
            }
            else
            {
                errorDescripcion.SetError(txtDescripcion, "");
                e.Cancel = false;
            }
        }

        private void txtCantidadStock_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtCantidadStock.Text, @"^[0-9]+$"))
            {
                errorCantidadStock.SetError(txtCantidadStock, "Datos invalidos");
                e.Cancel = true;
            }
            else
            {
                errorCantidadStock.SetError(txtCantidadStock, "");
                e.Cancel = false;
            }
        }

        private void txtPrecioVenta_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtPrecioVenta.Text, @"^[0-9]+(.[0-9]+)?$"))
            {
                errorPrecioVenta.SetError(txtPrecioVenta, "Datos invalidos");
                e.Cancel = true;
            }
            else
            {
                errorPrecioVenta.SetError(txtPrecioVenta, "");
                e.Cancel = false;
            }
        }

        private void txtPrecioProveedor_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtPrecioProveedor.Text, @"^[0-9]+(.[0-9]+)?$"))
            {
                errorPrecioProveedor.SetError(txtPrecioProveedor, "Datos invalidos");
                e.Cancel = true;
            }
            else
            {
                errorPrecioProveedor.SetError(txtPrecioProveedor, "");
                e.Cancel = false;
            }
        }

    }
}
