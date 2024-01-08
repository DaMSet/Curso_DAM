using David_Examen_DEINT_R.DLL;
using Jardineria.DLL;
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
    public partial class Leer : Form
    {
        public Leer()
        {
            InitializeComponent();


        }

        private void btnLeer_Click(object sender, EventArgs e)
        {

            dtgDatosEditorial.DataSource = editorialDLL.getInstance().getEditorial().Tables[0];
            dtgDatosLibros.DataSource = LibroDLL.getInstance().getlibro().Tables[0];

            /*
            DataSet ds = editorialDLL.getInstance().getEditorial();

            List<string> list = new List<string>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                String nombre = row["nombre_cliente"].ToString();
                list.Add(nombre);
            }

            foreach (String item in list)
            {
                //label1.Text += item + "\n";
            }
            */

        }
    }
}
