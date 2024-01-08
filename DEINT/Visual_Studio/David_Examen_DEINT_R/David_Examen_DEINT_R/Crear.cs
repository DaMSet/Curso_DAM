using David_Examen_DEINT_R.Clases;
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
    public partial class Crear : Form
    {
        public Crear()
        {
            InitializeComponent();
        }

        private void Crear_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

           
            if (txtAutor.Text == "") 
            {
                //errorProvider1.SetError("erro");
                
            }

            if (txtAutor.Text == "")
            {
                errorProvider1.GetError(txtAutor);
            }

            
            Libro libro = new Libro(int.Parse(txtIsbn.Text),txtTitulo.Text,txtAutor.Text, int.Parse(txtAño.Text), int.Parse(txtCodEditorial.Text), txtGenero.Text);

            LibroDLL.getInstance().añadirLibro(libro);

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            if (txtAutor.Text == "")
            {
                errorProvider1.GetError(txtAutor);
            }
        }
    }
}
