namespace U3_E6_Ficheros2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {


            string rutaDirectorio = textBox1.Text.ToString();


            if (Directory.Exists(rutaDirectorio))
            {
                string[] archivos = Directory.GetFiles(rutaDirectorio);

                if (archivos.Length > 0)
                {

                    foreach (string archivo in archivos)
                    {
                        label1.Text += $"{archivo}\n";

                        // Imprimir el último archivo utilizado
                        if (!string.IsNullOrEmpty(archivo))
                        {
                            label1.Text += $"Último archivo utilizado: {archivo}";
                        }
                        else
                        {
                            label1.Text += "No se ha utilizado ningún archivo anteriormente.";
                        }



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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Console.Write("Ingrese la ruta del directorio: ");
            string directorioPadre = Console.ReadLine();



            if (Directory.Exists(directorioPadre))
            {
                Console.Write("Ingrese el nombre del subdirectorio a crear: ");
                string nombreSubdirectorio = Console.ReadLine();
                string rutaSubdirectorio = Path.Combine(directorioPadre, nombreSubdirectorio);

                // Verificamos si el subdirectorio ya existe
                if (!Directory.Exists(rutaSubdirectorio))
                {
                    Directory.CreateDirectory(rutaSubdirectorio);

                    Console.Write("Ingrese la extensión de los archivos a copiar (sin el punto): ");
                    string extension = Console.ReadLine();

                    // Obtenemos todos los archivos con la extensión proporcionada en el directorio padre
                    string[] archivos = Directory.GetFiles(directorioPadre, $"*.{extension}");

                    foreach (string archivo in archivos)
                    {
                        // Creamos la ruta de destino para la copia
                        string destino = Path.Combine(rutaSubdirectorio, Path.GetFileName(archivo));

                        // Copiamos el archivo al subdirectorio
                        File.Copy(archivo, destino, true);
                    }

                    Console.WriteLine("Archivos copiados exitosamente.");
                }
                else
                {
                    Console.WriteLine("El subdirectorio ya existe. Intente con un nombre diferente.");
                }
            }
            else
            {
                Console.WriteLine("El directorio no existe. Verifique la ruta proporcionada.");
            }
        }

    
    }
}

/*
 Realiza un programa, que solicita al usuario introducir el nombre de un directorio.
Dicho programa comprobará si el directorio existe, si no fuese así, informará del
error. En caso de que exista, comprobaremos si tiene ficheros dentro, si no fuese
así, también se informará al usuario de este hecho. Si tuviese ficheros, debemos
mostrar el fichero al que se ha accedido más recientemente.
 */