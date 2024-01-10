using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.DLL
{
    internal class Connection
    {
        private String cadenaConexion = "Data Source=DESKTOP-ACT8DKG\\SQLEXPRESS01; Initial Catalog=jardineria; Integrated Security = True";
        SqlConnection sqlConnection;

        public SqlConnection EstablecerConexion()
        {
            this.sqlConnection = new SqlConnection(this.cadenaConexion);
            return this.sqlConnection;
        }

        public bool EjecutarComandoSinRetornarDatos(String strComando)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = strComando;
                sqlCommand.Connection = this.EstablecerConexion();
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataSet EjecutarSentencia(SqlCommand sqlComando)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand = sqlComando;
                sqlCommand.Connection = this.EstablecerConexion();
                adapter.SelectCommand = sqlCommand;
                sqlConnection.Open();
                adapter.Fill(ds);
                sqlConnection.Close();
                return ds;
            }
            catch (Exception e)
            {
                return ds;
            }

        }
    }
}
