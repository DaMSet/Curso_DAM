using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.DLL
{
    internal class PedidoDLL
    {

        Connection connection;

        private static PedidoDLL instance;

        public PedidoDLL()
        {
            connection = new Connection();
        }


        public DataSet getPedidos(int numMes)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM pedido WHERE MONTH(fecha_pedido) = '"+ numMes + "';");
            return connection.EjecutarSentencia(sqlCommand);
        }




        public static PedidoDLL getInstance()
        {
            if (instance == null)
            {
                instance = new PedidoDLL();
            }
            return instance;
        }

    }
}
