using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.Model
{
    internal class Producto
    {
        public String codigoProducto { get; set; }
        public String nombre { get; set; }
        public String gama { get; set; }
        public String dimensiones { get; set; }
        public String proveedor { get; set; }
        public String descripcion { get; set; }
        public int cantidadStock { get; set; }
        public double precioVenta { get; set; }
        public double precioProveedor { get; set; }


        public Producto(String codigoProducto, String nombre, String gama, String dimensiones, String proveedor, String descripcion, int cantidadStock, double precioVenta, double precioProveedor)
        {
            this.codigoProducto = codigoProducto;
            this.nombre = nombre;
            this.gama = gama;
            this.dimensiones = dimensiones;
            this.proveedor = proveedor;
            this.descripcion = descripcion;
            this.cantidadStock = cantidadStock;
            this.precioVenta = precioVenta;
            this.precioProveedor = precioProveedor;
        }
    }
}
