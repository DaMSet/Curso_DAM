using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.DLL
{
    internal class EmpleadoDLL
    {
        Connection connection;

        private static EmpleadoDLL instance;
        public EmpleadoDLL()
        {
            connection = new Connection();
        }



        public DataSet getEmpleados(int codigoJefe)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM empleado WHERE codigo_jefe = '"+codigoJefe+"'; ");
            return connection.EjecutarSentencia(sqlCommand);
        }





        public static EmpleadoDLL getInstance()
        {
            if (instance == null)
            {
                instance = new EmpleadoDLL();
            }
            return instance;
        }
    }
}
