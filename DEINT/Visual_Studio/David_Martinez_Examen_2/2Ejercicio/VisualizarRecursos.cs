using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Ejercicio
{
    public partial class VisualizarRecursos : Form
    {
        public VisualizarRecursos()
        {
            InitializeComponent();

            RecursoDLL recursoDLL = new RecursoDLL();

            DataSet tabla =  recursoDLL.obtenerRecurso();

            foreach (DataRow row in tabla)
            {
            
                listBox1.Items.Add(row.ToString());

            }

        }

        private void VisualizarRecursos_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
