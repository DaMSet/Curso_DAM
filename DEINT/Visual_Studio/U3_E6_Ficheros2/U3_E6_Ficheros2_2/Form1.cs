namespace U3_E6_Ficheros2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            string rutaDirectorio = textBox1.Text.ToString();
            string tipo = textBox2.Text.ToString();

            if (Directory.Exists(rutaDirectorio))
            {
                string[] archivos = Directory.GetFiles(rutaDirectorio);

                if (archivos.Length > 0)
                {

                   

                        // Crear un cuadro de diálogo para seleccionar archivos
                        OpenFileDialog openFileDialog = new OpenFileDialog();

                        // Establecer filtros de extensión
                        openFileDialog.Filter = $"Archivos de texto (*.{tipo})|*.{tipo}|Todos los archivos (*.*)|*.*";
                        openFileDialog.FilterIndex = 1; // Índice del filtro por defecto
                        openFileDialog.CheckFileExists = false;
                        openFileDialog.CheckPathExists = true;
                        openFileDialog.FileName = rutaDirectorio;

                    // Mostrar el cuadro de diálogo y verificar si el usuario selecciona un archivo
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        label1.Text += $"{openFileDialog.FileName}\n";
                    }


                }
                else if (archivos.Length == 0)
                {
                    label1.Text += "No hay archivos";
                }


            }
            else
            {
                label1.Text = "No existe ese directorio";
            }
        }
    }
}
/*
 Realiza un programa, que solicita al usuario introducir el nombre de un directorio.
Dicho programa comprobará si el directorio existe, si no fuese así, informará del
error. En caso de que exista, comprobaremos si tiene ficheros dentro, si no fuese
así, también se informará al usuario de este hecho. Si tuviese ficheros,
solicitaremos al usuario una extensión de fichero, y mostraremos por pantalla sólo
los ficheros que tengan dicha extensión
 */