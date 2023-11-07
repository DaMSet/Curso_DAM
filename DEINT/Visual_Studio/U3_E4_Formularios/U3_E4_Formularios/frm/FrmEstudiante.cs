using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U3_E4_Formularios.DLL;
using U3_E4_Formularios.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace U3_E4_Formularios.frm
{
    public partial class FrmEstudiante : Form
    {

        Estudiante estudiante;
        private byte[] imgaenByte;

        CicloDLL cicloDLL = new CicloDLL();
        EstudianteDLL estudianteDLL = new EstudianteDLL();

        public FrmEstudiante()
        {
            InitializeComponent();

            estudiante = new Estudiante();


            //SACAR LOS ID DE LOS CICLOS


            foreach (DataRow row in cicloDLL.MostrarCiclos().Tables[0].Rows)
            {

                cmbCiclo.Items.Add(row["id"].ToString());


            }

            //Tomamos la tabla con una consulta y la mostramos
           
            dgEstudiante.DataSource = estudianteDLL.MostrarEstudiantes().Tables[0];

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccione Imagen";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                pcbEstudiante.Image = Image.FromStream(selectorImagen.OpenFile());

                MemoryStream memoryStream = new MemoryStream();

                pcbEstudiante.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

                imgaenByte = memoryStream.ToArray();

            }

            dgEstudiante.DataSource = estudianteDLL.MostrarEstudiantes().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            estudiante.NombreEstudiante = txtNombre.Text;
            estudiante.PrimerApellido = txtPApellido.Text;
            estudiante.SegundoApellido = txtSApellido.Text;
            estudiante.Email = txtCorreo.Text;
            estudiante.Ciclo = int.Parse(cmbCiclo.Text);
            estudiante.FotoEstudiante = imgaenByte;

            estudianteDLL.Agregar(estudiante);


            dgEstudiante.DataSource = estudianteDLL.MostrarEstudiantes().Tables[0];
        }
    }
}
