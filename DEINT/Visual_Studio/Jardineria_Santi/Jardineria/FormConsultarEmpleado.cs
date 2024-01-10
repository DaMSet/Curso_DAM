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
    public partial class FormConsultarEmpleado : Form
    {

        private Servicio.Servicio servicio;


        public FormConsultarEmpleado()
        {
            InitializeComponent();

            servicio = Servicio.Servicio.getInstace();
        }

        private void FormConsultarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void cmBoxCodigoJefe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoJefe = int.Parse(txtCodigoJefe.Text);
                List<String> nombres = servicio.GetListaNombresEmpleados(codigoJefe);
                List<String> apellido1 = servicio.GetListaApellido1Empleados(codigoJefe);
                List<String> apellido2 = servicio.GetListaApellido2Empleados(codigoJefe);
                List<String> email = servicio.GetListaEmailEmpleados(codigoJefe);

                lblNombre.Text = "";
                lblApellido1.Text = "";
                lblApellido2.Text = "";
                lblEmail.Text = "";

                for (int i = 0; i < nombres.Count; i++)
                {
                    lblNombre.Text += nombres[i] + "\n\n";
                    lblApellido1.Text += apellido1[i] + "\n\n";
                    lblApellido2.Text += apellido2[i] + "\n\n";
                    lblEmail.Text += email[i] + "\n\n";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Tienes que escribir un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
