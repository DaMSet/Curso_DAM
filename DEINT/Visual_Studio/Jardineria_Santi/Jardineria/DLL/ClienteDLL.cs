using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.DLL
{
    
    internal class ClienteDLL
    {
        Connection connection;
        private static ClienteDLL instance;
        public ClienteDLL() 
        {
            connection = new Connection();
        }



        public DataSet getClientes()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT  c.* FROM cliente c " +
                "LEFT JOIN pago p ON c.codigo_cliente = p.codigo_cliente WHERE p.codigo_cliente IS NULL;");
            return connection.EjecutarSentencia(sqlCommand);
        }



        public static ClienteDLL getInstance()
        {
            if (instance == null)
            {
                instance = new ClienteDLL();
            }
            return instance;
        }

    }
}
