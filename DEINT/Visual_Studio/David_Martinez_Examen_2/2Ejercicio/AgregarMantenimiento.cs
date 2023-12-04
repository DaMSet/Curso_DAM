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
    public partial class AgregarMantenimiento : Form
    {
        public AgregarMantenimiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenimientoDLL mantenimiento = new MantenimientoDLL();

            mantenimiento.AgregarMantenimiento(int.Parse(codigo.Text),codigoMantenimiento.Text,codigorecursotecnologico.Text,fechainicio.Text,fechafin.Text,descripcion.Text);
        }
    }
}
