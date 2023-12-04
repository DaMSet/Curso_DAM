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
    public partial class ModificarEstadoRecursos : Form
    {
        public ModificarEstadoRecursos()
        {
            InitializeComponent();

            RecursoDLL recursoDLL = new RecursoDLL();

            DataSet codigos = recursoDLL.obtenerCodigoRecurso();

            foreach (DataRow row in codigos)
            {
                comboBox1.Items.Add(row);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {

            RecursoDLL recurso = new RecursoDLL();

            int codigo = int.Parse(comboBox1.SelectedItem.ToString());

            recurso.ModificarEstadoRecurso(codigo, txtEstado.Text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
