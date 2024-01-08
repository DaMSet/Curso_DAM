using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;


namespace Jardineria.DLL
{
    internal class Connection
    {
        private String cadenaConexion = "Data Source=DESKTOP-DRH2NA7; Initial Catalog=jardineria; Integrated Security = True";
        SqlConnection sqlConnection;

        public SqlConnection EstablecerConexion()
        {
            this.sqlConnection = new SqlConnection(this.cadenaConexion);
            return this.sqlConnection;
        }

        public bool EjecutarComandoSinRetornarDatos(String strComando)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = strComando;
                sqlCommand.Connection = this.EstablecerConexion();
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataSet EjecutarSentencia(SqlCommand sqlComando)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand = sqlComando;
                sqlCommand.Connection = this.EstablecerConexion();
                adapter.SelectCommand = sqlCommand;
                sqlConnection.Open();
                adapter.Fill(ds);
                sqlConnection.Close();
                return ds;
            }
            catch (Exception e)
            {
                return ds;
            }

        }

        public string Comprobarficheros()
        {

            File.Exists(@"C:\archivo.txt");
            string ruta = @"C:\archivo1.txt";
            string ruta2 = @"C:\archivo2.txt";
            string datos = "datos extras";

            String rutaFichero1 = Path.GetFullPath(ruta); //Obtiene la ruta absoluta del fichero
            String contenido = File.ReadAllText(rutaFichero1); //Guarda el contenido del fichero
            File.WriteAllText(ruta2, contenido); // Escribe el contenido en un fichero

            File.Exists(ruta2); //Comprueba que existe el fichero
            string[] lineas = File.ReadAllLines(ruta2); //Guarda en cada posicion del array una linea del fichero

            File.Copy(ruta, ruta2); //Duplica un fichero existente (fichero) con un nuevo nombre (nuevoFichero)

            File.AppendAllText(ruta, $"Mejor nota en informática: {datos}\n"); //Añade a un fichero una linea de texto



            //StreamReader es otro enfoque para leer ficheros, al igual que StreamWriter para escribir.

            string nombreFicheroUnion = "union.txt";
            StreamReader leerFichero1 = null;
            StreamReader leerFichero2 = null;
            StreamWriter escribirUnion = null;

            leerFichero1 = new StreamReader(ruta);
            leerFichero2 = new StreamReader(ruta2);
            escribirUnion = new StreamWriter(nombreFicheroUnion);


            //Para leer y escribir:
            while (!leerFichero1.EndOfStream)
            {
                escribirUnion.WriteLine(leerFichero1.ReadLine());
            }

            return null;
        }

        public DataSet prueba()
        {
            // dataGridView1.DataSource = ClienteDLL.getInstance().getClientes().Tables[0];


            DataSet ds = ClienteDLL.getInstance().getClientes();

            List<string> list = new List<string>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                String nombre = row["nombre_cliente"].ToString();
                list.Add(nombre);
            }

            foreach (String item in list)
            {
                //label1.Text += item + "\n";
            }

            return null;
        }

        public string SerializarDeserializar()
        {

            // Serializar objeto a XML
            XmlSerializer serializer = new XmlSerializer(typeof(string)); //Puede ser cualquier clase
            TextWriter writer = new StreamWriter("ruta\\archivo.xml");
            serializer.Serialize(writer, "cadena objeto");
            writer.Close();

            // Deserializar XML a objeto
            XmlSerializer serializer2 = new XmlSerializer(typeof(int));
            TextReader reader = new StreamReader("ruta\\archivo.xml");
            int objeto = (int)serializer2.Deserialize(reader);
            reader.Close();



            /*
            // Serializar objeto a JSON
            JsonSerializerOptions opciones = new JsonSerializerOptions { WriteIndented = true };
            string jsonString1 = JsonSerializer.Serialize(objeto, opciones);
            // Escribir JSON en un archivo
            File.WriteAllText("ruta\\archivo.json", jsonString1);
            // Deserializar JSON a objeto
            string jsonString2 = File.ReadAllText("ruta\\archivo.json");
            string objetoDeserializado = JsonSerializer.Deserialize<string>(jsonString2);
            // Utilizar el objeto deserializado
            Console.WriteLine($"Propiedad1: {objetoDeserializado.Propiedad1}");
            Console.WriteLine($"Propiedad2: {objetoDeserializado.Propiedad2}");*/



            return null;
        }


    }
}



/*

Directory.Exists(directorioPath) //Comprueba que exista el directorio

String directorioActual = Environment.CurrentDirectory; // Obtiene la ruta completa del directorio actual
String directorioPath = Path.Combine(directorioActual, directorio); //Combina un directorio con otro (Mete uno dentro del otro)
String[] ficheros = Directory.GetFiles(directorioPath); //Guarda en un array los ficheros dentro del directorio

Path.GetExtension(fichero); //obtener la extensión de un archivo

String subDirectorioPath = Path.Combine(directorioPath, subDirectorio); //Se combinan para luego crear un subDirectorio
Directory.CreateDirectory(subDirectorioPath); //Crea un nuevo directorio en la ruta especificada

File.Copy(archivo, destinoArchivo, true); //copiar un archivo de origen (archivo) a un destino (destinoArchivo).

File.Delete(archivo); // Elimina el archivo

Path.GetFileNameWithoutExtension(fichero); //obtener el nombre de archivo (sin la extensión) 

*/


