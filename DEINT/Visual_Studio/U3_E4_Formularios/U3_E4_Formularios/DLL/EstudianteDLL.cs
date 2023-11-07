using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_E4_Formularios.DLL
{
    internal class EstudianteDLL
    {
        Conexion conexion;
        public EstudianteDLL()
        {

            conexion = new Conexion();

        }

        public bool Agregar(string nombre,string primerapellido,string segundoapellido,string email,  )
        {

            return conexion.EjecutarComandoSinRetornarDatos("Insert into Estudiante(nombre,primerapellido, segundoapellido, email) values('" + nombre + ","+primerapellido+", "+segundoapellido+", "+email+"')");

        }

        public DataSet MostrarAlumnos()
        {
            SqlCommand sentencia = new SqlCommand("Select * from estudiante");
            return conexion.EjecutarSentencia(sentencia);

        }

        public string pasarImagenString(Image image, System.Drawing.Imaging.ImageFormat format) 
        {

            return conexion.ImageToBase64(image, format);
        }

        public string pasarStringImagen() 
        {
            

            return Image;

        }

    }
}
