// See https://aka.ms/new-console-template for more information


/*
Realiza un programa, que solicita al usuario introducir el nombre de un directorio.
Dicho programa comprobará si el directorio existe, si no fuese así, informará del
error. En caso de que exista, comprobaremos si tiene ficheros dentro, si no fuese
así, también se informará al usuario de este hecho. Si tuviese ficheros, debemos
mostrar el fichero al que se ha accedido más recientemente.
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
        // Encontrar el archivo más recientemente accedido
        string archivoMasReciente = ObtenerArchivoMasReciente(archivos);

        Console.WriteLine($"El archivo más recientemente accedido en '{nombreDirectorio}' es:");
        Console.WriteLine(Path.GetFileName(archivoMasReciente));
    }
}
else
{
    Console.WriteLine($"El directorio '{nombreDirectorio}' no existe. Verifique la ruta proporcionada.");
}

// Método para obtener el archivo más recientemente accedido
static string ObtenerArchivoMasReciente(string[] archivos)
{
    DateTime ultimaFechaAcceso = DateTime.MinValue;
    string archivoMasReciente = "";

    foreach (string archivo in archivos)
    {
        DateTime fechaAcceso = File.GetLastAccessTime(archivo);

        if (fechaAcceso > ultimaFechaAcceso)
        {
            ultimaFechaAcceso = fechaAcceso;
            archivoMasReciente = archivo;
        }
    }

    return archivoMasReciente;
}