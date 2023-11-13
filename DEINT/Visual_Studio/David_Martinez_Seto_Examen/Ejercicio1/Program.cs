namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Servicio Serv = new Servicio();

            Serv.AgregarDocumentoPendiente("manu");
            Serv.AgregarDocumentoPendiente("manu2");
            Serv.AgregarDocumentoPendiente("manu3");

            Serv.ArchivarDocumento();
            Serv.ArchivarDocumento();


            List<documento> lista = Serv.MostrarDocumentosArchivados();

            foreach (var i in lista)
            {
                Console.WriteLine("Archivados");
                Console.WriteLine(i.Nombre+"  "+i.Fecha);
            }

            List<documento> lista2 = Serv.MostrarDocumentosPendientes();

            foreach (var i in lista2)
            {
                Console.WriteLine("Pendientes");
                Console.WriteLine(i.Nombre + "  " + i.Fecha);
            }


        }
    }
}