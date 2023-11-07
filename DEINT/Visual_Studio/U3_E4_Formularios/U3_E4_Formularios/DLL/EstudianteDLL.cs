using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U3_E4_Formularios.Model;

namespace U3_E4_Formularios.DLL
{
    internal class EstudianteDLL
    {
        Conexion conexion;
        public EstudianteDLL()
        {

            conexion = new Conexion();


        }

        internal DataSet MostrarEstudiantes()
        {
            
            
            SqlCommand sentencia = new SqlCommand("Select * from Estudiante");
            return conexion.EjecutarSentencia(sentencia);

            
        }

        public bool Agregar(Estudiante estudiante)
        {

            return conexion.EjecutarComandoSinRetornarDatos("INSERT INTO Estudiante(nombre, primerapellido, segundoapellido, email, foto) " +
                "VALUES('" + estudiante.NombreEstudiante + "', '" + estudiante.PrimerApellido + "', '" + estudiante.SegundoApellido + "', '" + estudiante.Email + "', '" + estudiante.FotoEstudiante + "')");

        }

       

        public string pasarImagenString(Image image, System.Drawing.Imaging.ImageFormat format) 
        {

            return conexion.ImageToBase64(image, format);
        }

        public Image pasarStringImagen(string base64String) 
        {

          return conexion.Base64ToImage(base64String);

        }

    }
}
