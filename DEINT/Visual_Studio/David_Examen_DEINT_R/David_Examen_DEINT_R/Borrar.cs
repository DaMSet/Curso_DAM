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
    public partial class Borrar : Form
    {
        public Borrar()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

           
            LibroDLL.getInstance().borrarLibro(int.Parse(cmbDato.SelectedItem.ToString()));


        }

        private void Borrar_Load(object sender, EventArgs e)
        {

            DataSet ds = LibroDLL.getInstance().getlibro();

            List<string> list = new List<string>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                String isbn = row["isbn"].ToString();
                cmbDato.Items.Add(isbn);
                list.Add(isbn);
            }

        }
    }
}
