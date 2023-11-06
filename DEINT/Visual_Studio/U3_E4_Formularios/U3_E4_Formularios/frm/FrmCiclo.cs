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
        public FrmCiclo()
        {
            InitializeComponent();
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CicloDLL cicloDLL = new CicloDLL();
            cicloDLL.Agregar(textBox2.Text);
        }

        
    }
}
