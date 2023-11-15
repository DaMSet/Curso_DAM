// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/*
 Realiza un programa, que solicita al usuario introducir el nombre de un directorio.
Dicho programa comprobará si el directorio existe, si no fuese así, informará del
error. En caso de que exista, comprobaremos si tiene ficheros dentro, si no fuese
así, también se informará al usuario de este hecho. Si tuviese ficheros,
solicitaremos al usuario una extensión de fichero, y mostraremos por pantalla sólo
los ficheros que tengan dicha extensión.

 */

// Solicitar al usuario el nombre del directorio
Console.Write("Ingrese el nombre del directorio: ");
string nombreDirectorio = Console.ReadLine();

// Comprobar si el directorio existe
if (Directory.Exists(nombreDirectorio))
{
    // Obtener la lista de archivos en el directorio
    string[] archivos = Directory.GetFiles(nombreDirectorio);

    if (archivos.Length == 0)
    {
        Console.WriteLine($"El directorio '{nombreDirectorio}' no contiene archivos.");
    }
    else
    {
        // Solicitar al usuario la extensión de archivo
        Console.Write("Ingrese la extensión de archivo a filtrar (sin el punto): ");
        string extension = Console.ReadLine();

        // Filtrar y mostrar solo los archivos con la extensión especificada
        var archivosFiltrados = archivos.Where(a => Path.GetExtension(a).Equals($".{extension}", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine($"Archivos con la extensión '{extension}' en '{nombreDirectorio}':");

        foreach (string archivo in archivosFiltrados)
        {
            Console.WriteLine(Path.GetFileName(archivo));
        }
    }
}
else
{
    Console.WriteLine($"El directorio '{nombreDirectorio}' no existe. Verifique la ruta proporcionada.");
}