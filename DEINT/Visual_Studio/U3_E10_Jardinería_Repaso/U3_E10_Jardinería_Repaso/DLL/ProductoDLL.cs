using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_E10_Jardinería_Repaso.DLL
{
    internal class ProductoDLL
    {
        Conexion conexion;
        public ProductoDLL() 
        {
            conexion = new Conexion();
        }

        public bool AgregarProducto(string codigo_producto, string nombre, string gama, string dimensiones, string proveedor, string descripcion, int cantidad_en_stock, double precio_venta, double precio_proveedor)
        {

            string consulta = "INSERT INTO producto (codigo_producto, nombre, gama, dimensiones, proveedor, descripcion, cantidad_en_stock, precio_venta, precio_proveedor) " +
                  "VALUES ('"+codigo_producto+"','"+ nombre + "', '" + gama+"', '"+dimensiones + "', '" + proveedor + "', '" + descripcion + "', '" + cantidad_en_stock + "', '" + precio_venta + "', '" + precio_proveedor + "')";


            //return conexion.EjecutarComandoSinRetornarDatos("Insert into producto(codigo_producto,nombre,gama,dimensiones,proveedor,descripcion,cantidad_en_stock,precio_venta,precio_proveedor) values('" + codigo_producto + "," + nombre + "," + gama + "," + dimensiones + "," + proveedor + "," + descripcion + "," + cantidad_en_stock + "," + precio_venta + "," + precio_proveedor + " ')");

            return conexion.EjecutarComandoSinRetornarDatos(consulta);


        }

        public DataSet ProductoBarato() 
        {

            SqlCommand sentencia = new SqlCommand("Select nombre,precio_venta from producto WHERE precio_venta = (SELECT MIN(precio_venta) FROM producto) ");
            return conexion.EjecutarSentencia(sentencia);

        }

        public DataSet ProductoCaro()
        {

            SqlCommand sentencia = new SqlCommand("Select nombre,precio_venta from producto WHERE precio_venta = (SELECT MAX(precio_venta) FROM producto) ");
            return conexion.EjecutarSentencia(sentencia);

        }

        public bool BorrarProductoPorGama(string gama) 
        {

            string consulta = "DELETE FROM producto WHERE gama = '" + gama + "'";

            return conexion.EjecutarComandoSinRetornarDatos(consulta);

        }

        public bool AgregarGama(string gama) 
        {

            string consulta = "Insert into gama_producto(gama) values('" + gama + "')";

            return conexion.EjecutarComandoSinRetornarDatos(consulta);

        }


        public bool BorrarGama(string gama) 
        {

            string consulta = "DELETE FROM gama_producto WHERE gama = '"+gama+"'";

            return conexion.EjecutarComandoSinRetornarDatos(consulta);

        }

        public DataSet mostrarGamas() 
        {

            SqlCommand sentencia = new SqlCommand("Select * from gama_producto");
            return conexion.EjecutarSentencia(sentencia);

        }
      


    }


    

}


