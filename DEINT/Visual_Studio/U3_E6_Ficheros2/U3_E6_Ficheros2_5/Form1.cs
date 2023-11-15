namespace U3_E6_Ficheros2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Solicitar al usuario el nombre del archivo
            Console.Write("Ingrese el nombre del archivo (incluyendo la extensión): ");
            string nombreArchivo = Console.ReadLine();

            // Validar si el archivo existe
            if (File.Exists(nombreArchivo))
            {
                // Solicitar al usuario la nueva extensión
                Console.Write("Ingrese la nueva extensión del archivo (sin el punto): ");
                string nuevaExtension = Console.ReadLine();

                // Cambiar la extensión del archivo
                string nuevoNombreArchivo = Path.ChangeExtension(nombreArchivo, nuevaExtension);

                try
                {
                    // Copiar el archivo con la nueva extensión
                    File.Copy(nombreArchivo, nuevoNombreArchivo);

                    // Borrar el archivo original
                    File.Delete(nombreArchivo);

                    Console.WriteLine("La extensión del archivo ha sido cambiada exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("El archivo no existe. Verifique el nombre proporcionado.");
            }
        }
    }
}
/*
 Realiza un programa que haciendo uso de la clase Path, cambie la extensión a un
fichero. Para ello tendrás que solicitar al usuario el nombre de un fichero, y la
nueva extensión, haciendo una copia de dicho fichero con la nueva extensión, y
posteriormente borrarás el fichero original.
 */