using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _2Ejercicio
{
    internal class RecursoDLL
    {

        Conexion conexion;
        public RecursoDLL()
        {
            conexion = new Conexion();
        }

        public bool AgregarRecurso(int codigo, string codigo_recurso, string nombre, string descripcion, string fecha_adquisicion, string estado)
        {
            if (Regex.IsMatch(codigo_recurso,$"^([0]|[1-9])3 [a-A]$")) 
            {
                string consulta = "INSERT INTO recurso_tecnologico (codigo, codigo_recurso, nombre, descripcion, fecha_adquisicion, estado) " +
                      "VALUES ('" + codigo + "','" + codigo_recurso + "', '" + nombre + "', '" + descripcion + "', '" + fecha_adquisicion + "', '" + estado + "')";



                return conexion.EjecutarComandoSinRetornarDatos(consulta);
            }
            else 
            {
                return false;
            }


        }

        public bool ModificarEstadoRecurso(int codigo, string estado)
        {
            try
            {
                string consulta = $"UPDATE recurso_tecnologico SET estado = {estado} where codigo = {codigo}";


                return conexion.EjecutarComandoSinRetornarDatos(consulta);
            }
            catch 
            {
                return false;
            }
        }

        public DataSet obtenerRecurso()
        {

            SqlCommand sentencia = new SqlCommand("Select codigo, codigo_recurso, nombre, descripcion, fecha_adquisicion, estado FROM recurso_tecnologico ");
            return conexion.EjecutarSentencia(sentencia);

        }

        public DataSet obtenerCodigoRecurso() 
                    {
            SqlCommand sentencia = new SqlCommand("Select codigo_recurso FROM recurso_tecnologico ");
            return conexion.EjecutarSentencia(sentencia);
        }
    }
}
