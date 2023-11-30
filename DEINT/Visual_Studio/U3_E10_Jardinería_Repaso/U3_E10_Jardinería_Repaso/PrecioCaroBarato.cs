using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U3_E10_Jardinería_Repaso.DLL;

namespace U3_E10_Jardinería_Repaso
{
    public partial class PrecioCaroBarato : Form
    {
        public PrecioCaroBarato()
        {
            InitializeComponent();


            ProductoDLL productoDLL = new ProductoDLL();

            DataSet ProductoCaro = productoDLL.ProductoCaro();
            DataSet ProductoBarato = productoDLL.ProductoBarato();


            //Añadimos al texto solo la primera fila es decir el nombre del producto

            if (ProductoCaro != null && ProductoCaro.Tables.Count > 0)
            {

                foreach (DataRow fila in ProductoCaro.Tables[0].Rows)
                {

                    // Verificar si hay al menos una columna en la fila
                    if (fila.ItemArray.Length > 0)
                    {

                        txtNombreProductoCaro.Text = fila[0].ToString();
                        txtPrecioCaro.Text = fila[1].ToString();
                    }

                }

            }

            //Añadimos al texto solo la primera fila es decir el nombre del producto

            if (ProductoBarato != null && ProductoBarato.Tables.Count > 0)
            {

                foreach (DataRow fila in ProductoBarato.Tables[0].Rows)
                {

                    // Verificar si hay al menos una columna en la fila
                    if (fila.ItemArray.Length > 0)
                    {

                        txtNombreProductoBarato.Text = fila[0].ToString();
                        txtPrecioBarato.Text = fila[1].ToString();
                    }

                }

            }




        }





        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
