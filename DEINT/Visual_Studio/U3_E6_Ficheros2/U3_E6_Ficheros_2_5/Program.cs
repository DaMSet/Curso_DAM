// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 Realiza un programa que haciendo uso de la clase Path, cambie la extensión a un
fichero. Para ello tendrás que solicitar al usuario el nombre de un fichero, y la
nueva extensión, haciendo una copia de dicho fichero con la nueva extensión, y
posteriormente borrarás el fichero original.
 */

// Solicitar al usuario el nombre del archivo
Console.Write("Ingrese el nombre del archivo (incluyendo la extensión): ");
string nombreArchivo = Console.ReadLine();

// Validar si el archivo existe
if (File.Exists(nombreArchivo))
{
    // Solicitar al usuario la nueva extensión
    Console.Write("Ingrese la nueva extensión del archivo (sin el punto): ");
    string nuevaExtension = Console.ReadLine();

    try
    {
        // Cambiar la extensión del archivo
        string nuevoNombreArchivo = Path.ChangeExtension(nombreArchivo, nuevaExtension);

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