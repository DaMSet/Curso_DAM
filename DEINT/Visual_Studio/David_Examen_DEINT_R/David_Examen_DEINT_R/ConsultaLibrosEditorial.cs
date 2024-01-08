using David_Examen_DEINT_R.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace David_Examen_DEINT_R
{
    public partial class ConsultaLibrosEditorial : Form
    {
        public ConsultaLibrosEditorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgConsulta.DataSource = LibroDLL.getInstance().getlibroPorEditorial().Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
