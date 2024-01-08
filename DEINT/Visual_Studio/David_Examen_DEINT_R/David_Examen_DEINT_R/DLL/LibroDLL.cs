using Jardineria.DLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Examen_DEINT_R.DLL
{
    internal class LibroDLL
    {

        Connection connection;
        private static LibroDLL instance;
        public LibroDLL()
        {
            connection = new Connection();
        }



        public DataSet getlibro()
        {
            SqlCommand sqlCommand = new SqlCommand(" SELECT * FROM Libro");
            return connection.EjecutarSentencia(sqlCommand);
        }

        public bool añadirLibro(Clases.Libro libro) 
        {
            return connection.EjecutarComandoSinRetornarDatos("INSERT INTO Libro (isbn,titulo,autor,genero,año_publicacion,cod_editorial) " +
                "VALUES ('"+libro.isbn+ "','"+libro.titulo+ "','"+libro.autor+ "','"+libro.genero+"','"+libro.añoPublicacion+ "','"+libro.codigoEditorial+"')");
        }


        public bool borrarLibro(int isbn) 
        {
            return connection.EjecutarComandoSinRetornarDatos("DELETE FROM Libro WHERE isbn = '"+isbn+"' ");
                  
        }

        public bool editarLibro(Clases.Libro libro, int isbn)
        {
            return connection.EjecutarComandoSinRetornarDatos("UPDATE Libro SET (titulo,autor,genero,año_publicacion,cod_editorial) " +
                "VALUES ('" + libro.titulo + "','" + libro.autor + "','" + libro.genero + "','" + libro.añoPublicacion + "','" + libro.codigoEditorial + "') WHERE isbn = '"+isbn+"' ");
        }


        public static LibroDLL getInstance()
        {
            if (instance == null)
            {
                instance = new LibroDLL();
            }
            return instance;
        }

        public DataSet getlibroPorEditorial()
        {
            SqlCommand sqlCommand = new SqlCommand(" SELECT * FROM Libro  order by cod_editorial");
            return connection.EjecutarSentencia(sqlCommand);
        }

        public DataSet getlibroPorGenero()
        {
            SqlCommand sqlCommand = new SqlCommand(" SELECT isbn,titulo,genero FROM Libro ");
            return connection.EjecutarSentencia(sqlCommand);
        }

    }
}
