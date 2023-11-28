using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_E10_Jardinería_Repaso.DLL
{
    internal class Conexion
    {

        private string cadenaConexion = "Data Source = DAM2-14; Initial Catalog=db.Jardineria; Integrated Security = True";

        SqlConnection sqlConnection;

        public SqlConnection EstablecerConexion()
        {
            sqlConnection = new SqlConnection(cadenaConexion);
            return sqlConnection;
        }

        public bool EjecutarComandoSinRetornarDatos(string strComando)
        {

            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = strComando;
                sqlCommand.Connection = EstablecerConexion();
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
                sqlCommand.Connection = EstablecerConexion();
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


        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                // Convert byte[] to base 64 string
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }



        public Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

    }
}
