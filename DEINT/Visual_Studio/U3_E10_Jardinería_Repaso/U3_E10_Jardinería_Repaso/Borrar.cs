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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace U3_E10_Jardinería_Repaso
{
    public partial class Borrar : Form
    {
        public Borrar()
        {
            InitializeComponent();

            ProductoDLL productoDLL = new ProductoDLL();

            DataSet Gamas = productoDLL.mostrarGamas();

            //Añadimos al combobox solo la primera fila es decir el nombre de la gama

            if (Gamas != null && Gamas.Tables.Count > 0)
            {
            
                foreach (DataRow fila in Gamas.Tables[0].Rows) 
                {

                    // Verificar si hay al menos una columna en la fila
                    if (fila.ItemArray.Length > 0)
                    {
                        // Añadir solo el primer string de cada fila al ComboBox
                        cmbGama.Items.Add(fila[0].ToString());
                    }

                }

            }

        }

        private void txtBorrarGama_Click(object sender, EventArgs e)
        {
            ProductoDLL productoDLL = new ProductoDLL();

            productoDLL.BorrarProductoPorGama(cmbGama.SelectedItem.ToString());
            productoDLL.BorrarGama(cmbGama.SelectedItem.ToString());

        }

        private void btnCancelarBorrado_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
