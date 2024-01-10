using Jardineria.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.DLL
{
    internal class GamaDLL
    {
        Connection connection;

        private static GamaDLL instance;

        public GamaDLL()
        {
            connection = new Connection();
        }


        public DataSet GetGamas()
        {
            SqlCommand sentencia = new SqlCommand("Select gama, descripcion_texto, descripcion_html, imagen from gama_producto");
            return connection.EjecutarSentencia(sentencia);
        }

        public bool eliminarGama(Gama gama)
        {
            return connection.EjecutarComandoSinRetornarDatos("DELETE FROM gama_producto WHERE gama = '" + gama.Nombre + "' ;");
        }

        public static GamaDLL getInstance()
        {
            if (instance == null)
            {
                instance = new GamaDLL();
            }
            return instance;
        }
    }
}
