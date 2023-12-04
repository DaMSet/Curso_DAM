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
    internal class MantenimientoDLL
    {

        Conexion conexion;
        public MantenimientoDLL()
        {
            conexion = new Conexion();
        }

        public bool AgregarMantenimiento(int codigo, string cod_mantenimiento, string codigo_recurso_tecnologico, string fecha_inicio, string fecha_fin, string descripcion)
        {
            if (Regex.IsMatch(codigo_recurso_tecnologico, $"^[a-A]3 - ([0]|[1-9])2$"))
            {
                string consulta = "INSERT INTO mantenimiento (codigo, cod_mantenimiento, codigo_recurso_tecnologico, fecha_inicio, fecha_fin, descripcion) " +
                  "VALUES ('" + codigo + "','" + cod_mantenimiento + "', '" + codigo_recurso_tecnologico + "', '" + fecha_inicio + "', '" + fecha_fin + "', '" + descripcion + "')";



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
                string consulta = $"UPDATE mantenimiento SET estado = {estado} where codigo = {codigo}";


                return conexion.EjecutarComandoSinRetornarDatos(consulta);
            }
            catch (Exception ex) 
            {
                return false;
            }
            
        }
        public DataSet obtenermantenimiento()
        {

            SqlCommand sentencia = new SqlCommand("Select codigo, cod_mantenimiento, codigo_recurso_tecnologico, fecha_inicio, fecha_fin, descripcion FROM mantenimiento ");
            return conexion.EjecutarSentencia(sentencia);

        }


    }


}
