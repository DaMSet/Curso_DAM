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
    public partial class FormConsultarPrecios : Form
    {
        private Servicio.Servicio servicio;
        public FormConsultarPrecios()
        {
            InitializeComponent();

            servicio = Servicio.Servicio.getInstace();
        }

        private void btnMostrarPrecios_Click(object sender, EventArgs e)
        {
            List<double> precios = servicio.GetPreciosMasCaroMasBarato();

            lblMasCaro.Text = precios[0].ToString()+"€";
            lblMasBarato.Text = precios[1].ToString()+"€";
        }

        private void FormConsultarPrecios_Load(object sender, EventArgs e)
        {

        }
    }
}
