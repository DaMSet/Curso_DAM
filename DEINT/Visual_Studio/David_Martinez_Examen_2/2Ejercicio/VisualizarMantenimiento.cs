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
    public partial class VisualizarMantenimiento : Form
    {
        public VisualizarMantenimiento()
        {
            InitializeComponent();

            MantenimientoDLL mantenimientoDLL = new MantenimientoDLL();

            DataSet tabla = mantenimientoDLL.obtenermantenimiento();

            foreach (DataRow row in tabla)
            {

                listBox1.Items.Add(row.ToString());

            }
        }

        private void VisualizarMantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
