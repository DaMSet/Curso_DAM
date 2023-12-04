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
    public partial class AgregarRecurso : Form
    {
        public AgregarRecurso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecursoDLL recurso = new RecursoDLL();

            recurso.AgregarRecurso(int.Parse(codigo.Text), codigoRecurso.Text,nombre.Text,descripcion.Text,fecha.Text,estado.Text);

        }
    }
}
