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

            Console.Write("Ingrese la ruta del directorio: ");
            string rutaDirectorio = Console.ReadLine();

            if (Directory.Exists(rutaDirectorio))
            {
                string[] archivos = Directory.GetFiles(rutaDirectorio);

                if (archivos.Length == 0)
                {
                    Console.WriteLine("El directorio no contiene archivos.");
                }
                else
                {
                    Console.Write("Ingrese la extensión de archivo a filtrar (sin el punto): ");
                    string extension = Console.ReadLine();

                    Console.WriteLine($"Archivos con extensión '{extension}':");

                    foreach (string archivo in archivos)
                    {
                        if (Path.GetExtension(archivo).Equals($".{extension}", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine(Path.GetFileName(archivo));
                        }
                    }
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
así, también se informará al usuario de este hecho. Si tuviese ficheros,
solicitaremos al usuario una extensión de fichero, y mostraremos por pantalla sólo
los ficheros que tengan dicha extensión
 */