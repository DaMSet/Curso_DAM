using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3_E4_Formularios.frm
{
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccione Imagen";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                pcbEstudiante.Image = Image.FromStream(selectorImagen.OpenFile());

                MemoryStream memoryStream = new MemoryStream();

                pcbEstudiante.Image.Save(memoryStream,System.Drawing.Imaging.ImageFormat.Png);

                imgaenByte = memoryStream.ToArray();
            }
        }
    }
}
