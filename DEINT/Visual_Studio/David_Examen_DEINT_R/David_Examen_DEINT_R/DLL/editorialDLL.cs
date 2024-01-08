using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.DLL
{

    internal class editorialDLL
    {
        Connection connection;
        private static editorialDLL instance;
        public editorialDLL()
        {
            connection = new Connection();
        }



        public DataSet getEditorial()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Editorial");
            return connection.EjecutarSentencia(sqlCommand);
        }





        public static editorialDLL getInstance()
        {
            if (instance == null)
            {
                instance = new editorialDLL();
            }
            return instance;
        }

    }
}
