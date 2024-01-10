using Jardineria.Servicio;
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
    public partial class FormEliminarGama : Form
    {
        private Servicio.Servicio servicio;

        public FormEliminarGama()
        {
            InitializeComponent();

            servicio = Servicio.Servicio.getInstace();
        }
        private void FormEliminarGama_Load(object sender, EventArgs e)
        {
            ActualizarCmBoxNombreGama();
        }

        private void ActualizarCmBoxNombreGama()
        {
            List<String> gamas = servicio.getListaGamasNombre();

            cmBoxNombreGama.Items.Clear();
            foreach (var item in gamas)
            {
                cmBoxNombreGama.Items.Add(item);
            }
        }

        private void cmBoxNombreGama_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDescripcion.Text = servicio.getGamaDescripcionTexto(cmBoxNombreGama.SelectedItem.ToString());
            txtDescripcionHtml.Text = servicio.getGamaDescripcionHtml(cmBoxNombreGama.SelectedItem.ToString());
            txtImagen.Text = servicio.getGamaImagen(cmBoxNombreGama.SelectedItem.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (servicio.eliminarGama(cmBoxNombreGama.SelectedItem.ToString()))
            {
                ActualizarCmBoxNombreGama();
                txtDescripcion.Text = "";
                txtDescripcionHtml.Text = "";
                txtImagen.Text = "";
            }
            else
            {
                MessageBox.Show("¡Existe un producto con esta gama!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
