using System.Windows.Forms;

namespace U3_E7_BlockDeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            nuevoArchivo();

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoArchivo();
        }


        private void btnAbrir_Click(object sender, EventArgs e)
        {
            abrirArchivo();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirArchivo();
        }


        private void nuevoArchivo()
        {

            // Verificar si hay texto en el RichTextBox
            if (richTextBoxPantalla.Text.Length > 0)
            {
                // Preguntar al usuario si desea guardar el contenido
                DialogResult resultado = MessageBox.Show("¿Quieres guardar el contenido?", "Guardar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    // Mostrar SaveFileDialog para que el usuario elija la ubicación y el nombre del archivo
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*";
                        saveFileDialog.Title = "Guardar archivo";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Guardar el nombre del archivo seleccionado
                            string nombreArchivo = saveFileDialog.FileName;

                            // Guardar el contenido en el archivo
                            System.IO.File.WriteAllText(nombreArchivo, richTextBoxPantalla.Text);

                            MessageBox.Show("Contenido guardado correctamente", "Guardar");
                        }
                    }
                }
                else
                {
                    // Limpiar el contenido del RichTextBox
                    richTextBoxPantalla.Clear();
                }
            }
            else
            {
                MessageBox.Show("No hay contenido para guardar", "Guardar");
            }

        }

        private void abrirArchivo()
        {


            //Configurar OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto|*.txt|Archivos RTF|*.rtf|Todos los archivos|*.*";
                openFileDialog.Title = "Abrir archivo";

                // Mostrar solo archivos con extensión .txt o .rtf
                openFileDialog.DefaultExt = ".txt";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener el nombre del archivo seleccionado
                    string nombreArchivo = openFileDialog.FileName;

                    // Cargamos el contenido en el RichTextBox

                    richTextBoxPantalla.LoadFile(nombreArchivo, RichTextBoxStreamType.PlainText);

                    MessageBox.Show($"Archivo '{nombreArchivo}' abierto correctamente", "Abrir");
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCortar_Click(object sender, EventArgs e)
        {

        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {

        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}