using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_E4_Formularios.DLL
{
    internal class Conexion
    {

        private string cadenaConexion = "Data Source = DAM2-14; Initial Catalog=db.Sistema; Integrated Security = True";

        SqlConnection sqlConnection;

        public SqlConnection EstablecerConexion()
        {
            this.sqlConnection = new SqlConnection(this.cadenaConexion);
            return this.sqlConnection;
        }

        public bool EjecutarComandoSinRetornarDatos(string strComando) 
        {

            try {
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

    }
}
