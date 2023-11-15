namespace U3_E6_Ficheros2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Solicitar al usuario el nombre del directorio
            Console.Write("Ingrese el nombre del directorio: ");
            string nombreDirectorio = Console.ReadLine();

            // Comprobar si el directorio existe
            if (Directory.Exists(nombreDirectorio))
            {
                // Solicitar al usuario el nombre del subdirectorio a crear
                Console.Write("Ingrese el nombre del subdirectorio a crear: ");
                string nombreSubdirectorio = Console.ReadLine();

                // Combinar las rutas para obtener la ruta completa del subdirectorio
                string rutaSubdirectorio = Path.Combine(nombreDirectorio, nombreSubdirectorio);

                // Crear el subdirectorio
                Directory.CreateDirectory(rutaSubdirectorio);

                // Solicitar al usuario la extensi�n de los archivos a copiar
                Console.Write("Ingrese la extensi�n de los archivos a copiar (sin el punto): ");
                string extension = Console.ReadLine();

                // Obtener la lista de archivos con la extensi�n especificada en el directorio principal
                string[] archivos = Directory.GetFiles(nombreDirectorio, $"*.{extension}");

                // Copiar cada archivo al subdirectorio
                foreach (string archivo in archivos)
                {
                    string nombreArchivo = Path.GetFileName(archivo);
                    string rutaDestino = Path.Combine(rutaSubdirectorio, nombreArchivo);
                    File.Copy(archivo, rutaDestino, true);
                }

                Console.WriteLine("Archivos copiados exitosamente.");
            }
            else
            {
                Console.WriteLine("El directorio no existe. Verifique la ruta proporcionada.");
            }
        }
    }
}
/*
 Crea un programa que solicite al usuario el nombre de un directorio. Dicho
programa comprobar� si el directorio existe, si no fuese as�, informar� del error. En
caso de que exista, pediremos al usuario que introduzca un nombre para crear un
subdirectorio dentro de �l, Una vez creado dicho subdirectorio, copiaremos en �l
todos los archivos que tengan la extensi�n igual que la que habremos solicitado al
usuario previamente
 */