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
    internal class ProductoDLL
    {
        Connection connection;

        private static ProductoDLL instance;
        public ProductoDLL()
        {
            connection = new Connection();
        }


        public bool agregarProducto(Producto producto)
        {
            return connection.EjecutarComandoSinRetornarDatos("Insert into producto(codigo_producto, nombre, gama, dimensiones, proveedor, descripcion, cantidad_en_Stock, precio_venta, precio_proveedor) " +
                "values ('" + producto.codigoProducto + "', '" + producto.nombre + "', '" + producto.gama + "', '" + producto.dimensiones + "', '" + producto.proveedor + "', '" + producto.descripcion + "', '" + producto.cantidadStock + "', '" + producto.precioVenta + "', '" + producto.precioProveedor + "')");

        }

        public DataSet getPrecioMasBaratoCaro()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT MAX(precio_venta) AS precio_mas_caro, MIN(precio_venta) AS precio_mas_barato FROM producto;");
            return connection.EjecutarSentencia(sqlCommand);
        }

        public static ProductoDLL getInstance()
        {
            if (instance == null)
            {
                instance = new ProductoDLL();
            }
            return instance;
        }
    }
}
