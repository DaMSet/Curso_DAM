namespace U3_E6_Ficheros2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Solicitar al usuario la extensi�n de archivo
            Console.Write("Ingrese la extensi�n de archivo a buscar (sin el punto): ");
            string extension = Console.ReadLine();

            // Obtener la lista de archivos con la extensi�n especificada en el directorio actual
            string[] archivos = Directory.GetFiles(Directory.GetCurrentDirectory(), $"*.{extension}");

            if (archivos.Length == 0)
            {
                Console.WriteLine($"No hay archivos con la extensi�n '{extension}' en el directorio actual.");
            }
            else
            {
                Console.WriteLine($"Archivos con la extensi�n '{extension}' en el directorio actual:");

                foreach (string archivo in archivos)
                {
                    Console.WriteLine(Path.GetFileName(archivo));
                }

                // Preguntar al usuario si desea borrar los archivos
                Console.Write("�Desea borrar estos archivos? (S�/No): ");
                string respuesta = Console.ReadLine();

                if (respuesta.Equals("S�", StringComparison.OrdinalIgnoreCase))
                {
                    // Borrar los archivos con la extensi�n especificada
                    foreach (string archivo in archivos)
                    {
                        File.Delete(archivo);
                    }

                    Console.WriteLine("Archivos borrados correctamente.");
                }
                else
                {
                    Console.WriteLine("No se han borrado archivos. Fin del programa.");
                }

                // Mostrar el resto de archivos en el directorio actual
                string[] archivosRestantes = Directory.GetFiles(Directory.GetCurrentDirectory());
                Console.WriteLine("Archivos restantes en el directorio actual:");

                foreach (string archivo in archivosRestantes)
                {
                    Console.WriteLine(Path.GetFileName(archivo));
                }
            }

        }
    }
}
/*
 Crea un programa que solicite al usuario una extensi�n de fichero. Una vez
introducida, preguntaremos al usuario si desea borrar los ficheros del directorio
actual, que mostraremos por pantalla, que tengan dicha extensi�n. Si la respuesta
es afirmativa borraremos los ficheros, y mostraremos el resto de ficheros que
hayan quedado en el directorio.

 */