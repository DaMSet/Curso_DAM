// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 Crea un programa que solicite al usuario el nombre de un directorio. Dicho
programa comprobará si el directorio existe, si no fuese así, informará del error. En
caso de que exista, pediremos al usuario que introduzca un nombre para crear un
subdirectorio dentro de él, Una vez creado dicho subdirectorio, copiaremos en él
todos los archivos que tengan la extensión igual que la que habremos solicitado al
usuario previamente.
 */

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

    // Solicitar al usuario la extensión de los archivos a copiar
    Console.Write("Ingrese la extensión de los archivos a copiar (sin el punto): ");
    string extension = Console.ReadLine();

    // Obtener la lista de archivos con la extensión especificada en el directorio principal
    string[] archivos = Directory.GetFiles(nombreDirectorio, $"*.{extension}");

    // Copiar cada archivo al subdirectorio
    foreach (string archivo in archivos)
    {
        string nombreArchivo = Path.GetFileName(archivo);
        string rutaDestino = Path.Combine(rutaSubdirectorio, nombreArchivo);
        File.Copy(archivo, rutaDestino, true);
    }

    Console.WriteLine("Archivos copiados exitosamente al subdirectorio.");
}
else
{
    Console.WriteLine($"El directorio '{nombreDirectorio}' no existe. Verifique la ruta proporcionada.");
}