using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U3_E4_Formularios.DLL;
using U3_E4_Formularios.Model;

namespace U3_E4_Formularios.frm
{
    public partial class FrmCiclo : Form
    {
        CicloDLL Ciclodll;


        public FrmCiclo()
        {
            Ciclodll = new CicloDLL();
            InitializeComponent();

            dgCiclo.DataSource = Ciclodll.MostrarCiclos().Tables[0];
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CicloDLL cicloDLL = new CicloDLL();
            cicloDLL.Agregar(txtNombreCiclo.Text);


            dgCiclo.DataSource = Ciclodll.MostrarCiclos().Tables[0];

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            CicloDLL cicloDLL = new CicloDLL();
            cicloDLL.Editar(txtID.Text, txtNombreCiclo.Text);

            dgCiclo.DataSource = Ciclodll.MostrarCiclos().Tables[0];
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            CicloDLL cicloDLL = new CicloDLL();
            cicloDLL.Borrar(txtID.Text);


            dgCiclo.DataSource = Ciclodll.MostrarCiclos().Tables[0];
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgCiclo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
