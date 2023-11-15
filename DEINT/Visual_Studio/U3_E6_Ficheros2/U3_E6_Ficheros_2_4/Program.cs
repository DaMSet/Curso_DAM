// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 Crea un programa que solicite al usuario una extensión de fichero. Una vez
introducida, preguntaremos al usuario si desea borrar los ficheros del directorio
actual, que mostraremos por pantalla, que tengan dicha extensión. Si la respuesta
es afirmativa borraremos los ficheros, y mostraremos el resto de ficheros que
hayan quedado en el directorio.

 */

// Obtener la ruta del directorio actual
string directorioActual = Directory.GetCurrentDirectory();

// Solicitar al usuario la extensión de archivo
Console.Write("Ingrese la extensión de archivo a buscar (sin el punto): ");
string extension = Console.ReadLine();

// Obtener la lista de archivos con la extensión especificada en el directorio actual
string[] archivos = Directory.GetFiles(directorioActual, $"*.{extension}");

if (archivos.Length == 0)
{
    Console.WriteLine($"No hay archivos con la extensión '{extension}' en el directorio actual.");
}
else
{
    // Mostrar los archivos con la extensión especificada
    Console.WriteLine($"Archivos con la extensión '{extension}' en el directorio actual:");

    foreach (string archivo in archivos)
    {
        Console.WriteLine(Path.GetFileName(archivo));
    }

    // Preguntar al usuario si desea borrar los archivos
    Console.Write("¿Desea borrar estos archivos? (Sí/No): ");
    string respuesta = Console.ReadLine();

    if (respuesta.Equals("Sí", StringComparison.OrdinalIgnoreCase))
    {
        // Borrar los archivos con la extensión especificada
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
    string[] archivosRestantes = Directory.GetFiles(directorioActual);
    Console.WriteLine("Archivos restantes en el directorio actual:");

    foreach (string archivo in archivosRestantes)
    {
        Console.WriteLine(Path.GetFileName(archivo));
    }
}