namespace U3_E6_Ficheros2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string directorio = textBox1.Text.ToString();
            bool existe = Directory.Exists(directorio);

            string directorioNuevo = textBox1.Text.ToString() +"nuevodirectorio";
            Directory.CreateDirectory(directorioNuevo);

            if (existe)
            {
                Console.WriteLine("El directorio existe.");
            }
            else
            {
                Console.WriteLine("El directorio no existe.");
            }

        }
    }
}
/*
 Crea un programa que solicite al usuario el nombre de un directorio. Dicho
programa comprobará si el directorio existe, si no fuese así, informará del error. En
caso de que exista, pediremos al usuario que introduzca un nombre para crear un
subdirectorio dentro de él, Una vez creado dicho subdirectorio, copiaremos en él
todos los archivos que tengan la extensión igual que la que habremos solicitado al
usuario previamente
 */