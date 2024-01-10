using Jardineria.DLL;
using Jardineria.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.Servicio
{
    internal class Servicio
    {
        private static Servicio servicio = null;

        public Servicio()
        {

        }

        //METODOS PRODUCTOS
        public void AgregarProducto(String codigoProducto, String nombre, String gama, String dimensiones, String proveedor, String descripcion, String cantidadStock, String precioVenta, String precioProveedor)
        {
            Producto producto = new Producto(codigoProducto, nombre, gama, dimensiones, proveedor, descripcion, int.Parse(cantidadStock), double.Parse(precioVenta), double.Parse(precioProveedor));
            ProductoDLL.getInstance().agregarProducto(producto);
        }


        public List<double> GetPreciosMasCaroMasBarato()
        {
            DataSet dataSet = ProductoDLL.getInstance().getPrecioMasBaratoCaro();

            List<double> precios = new List<double>();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {

                double precioCaro = double.Parse(row["precio_mas_caro"].ToString());
                double precioBarato = double.Parse(row["precio_mas_barato"].ToString());

                precios.Add(precioCaro);
                precios.Add(precioBarato);
            }

            return precios;

        }


        //METODOS GAMAS
        public List<string> getListaGamasNombre()
        {
            DataSet dataSet = GamaDLL.getInstance().GetGamas();

            List<string> listaGamas = new List<string>();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                if (dataSet.Tables[0].Columns.Contains("gama"))
                {
                    listaGamas.Add(row["gama"].ToString());
                }
            }

            return listaGamas;
        }

        public List<Gama> getListaGamas()
        {
            DataSet dataSet = GamaDLL.getInstance().GetGamas();

            List<Gama> listaGamas = new List<Gama>();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                string nombre = row["gama"].ToString();
                string descripcionTexto = row["descripcion_texto"].ToString();
                string descripcionHtml = row["descripcion_html"].ToString();
                string imagen = row["imagen"].ToString();

                Gama gama = new Gama(nombre, descripcionTexto, descripcionHtml, imagen);
                listaGamas.Add(gama);
            }

            return listaGamas;
        }

        public String getGamaDescripcionTexto(String nombreGama)
        {
            DataSet dataSet = GamaDLL.getInstance().GetGamas();

            String DescripcionTexto = "";

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                if (row["gama"].ToString().Equals(nombreGama, StringComparison.OrdinalIgnoreCase))
                {
                    DescripcionTexto = row["Descripcion_texto"].ToString();
                }
            }

            return DescripcionTexto;

        }

        public String getGamaDescripcionHtml(String nombreGama)
        {
            DataSet dataSet = GamaDLL.getInstance().GetGamas();

            String DescripcionHtml = "";

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                if (row["gama"].ToString().Equals(nombreGama))
                {
                    DescripcionHtml = row["Descripcion_html"].ToString();
                }
            }
            return DescripcionHtml;
        }

        public String getGamaImagen(String nombreGama)
        {
            DataSet dataSet = GamaDLL.getInstance().GetGamas();

            String imagen = "";

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                if (row["gama"].ToString().Equals(nombreGama))
                {
                    imagen = row["imagen"].ToString();
                }
            }
            return imagen;
        }

        public bool eliminarGama(String nombreGama)
        {
            bool eliminado = false;

            List<Gama> gamas = getListaGamas();

            foreach (var gama in gamas)
            {
                if (gama.Nombre.Equals(nombreGama))
                {
                    eliminado = GamaDLL.getInstance().eliminarGama(gama);
                }
            }

            return eliminado;
        }


        //METODOS PEDIDOS

        public List<Pedido> GetPedidos(int numMes)
        {
            try
            {
                DataSet dataSet = PedidoDLL.getInstance().getPedidos(numMes);

                List<Pedido> pedidos = new List<Pedido>();

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    int codigoPedido = int.Parse(row["codigo_pedido"].ToString());
                    DateTime fechaPedido = DateTime.Parse(row["fecha_pedido"].ToString());
                    DateTime fechaEspera = DateTime.Parse(row["fecha_esperada"].ToString());
                    DateTime fechaEntrega = DateTime.Parse(row["fecha_entrega"].ToString());
                    String estado = row["estado"].ToString();
                    String comentario = row["comentarios"].ToString();
                    int codigoCliente = int.Parse(row["codigo_cliente"].ToString());

                    Pedido pedido = new Pedido(codigoPedido, fechaPedido, fechaEspera, fechaEntrega, estado, comentario, codigoCliente);

                    pedidos.Add(pedido);

                }

                return pedidos;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return new List<Pedido>();
        }

        public List<int> GetListaCodigoPedido(int numMes)
        {
            List<Pedido> pedidos = GetPedidos(numMes);

            return pedidos.Select(pedido => pedido.CodigoPedido).ToList();
        }

        public List<DateTime> GetListaFechaPedido(int numMes)
        {
            List<Pedido> pedidos = GetPedidos(numMes);

            return pedidos.Select(pedido => pedido.FechaPedido).ToList();
        }
        public List<DateTime> GetListaFechaEspera(int numMes)
        {
            List<Pedido> pedidos = GetPedidos(numMes);

            return pedidos.Select(pedido => pedido.FechaEspera).ToList();

        }

        public List<DateTime> GetListaFechaEntrega(int numMes)
        {
            List<Pedido> pedidos = GetPedidos(numMes);

            return pedidos.Select(pedido => pedido.FechaEntrega).ToList();
        }

        public List<String> GetListaEstado(int numMes)
        {
            List<Pedido> pedidos = GetPedidos(numMes);

            return pedidos.Select(pedido => pedido.Estado).ToList();
        }

        public List<String> GetListaComentario(int numMes)
        {
            List<Pedido> pedidos = GetPedidos(numMes);

            return pedidos.Select(pedido => pedido.Comentario).ToList();
        }

        public List<int> GetListaCodigoCliente(int numMes)
        {
            List<Pedido> pedidos = GetPedidos(numMes);

            return pedidos.Select(pedido => pedido.CodigoPedido).ToList();
        }


        //METODOS EMPLEADOS

        public List<Empleado> GetListaEmpleados(int codJefe)
        {
            DataSet dataSet = EmpleadoDLL.getInstance().getEmpleados(codJefe);

            List<Empleado> empleados = new List<Empleado>();

            //int codigoEmpleado, String nombre, String apellido1, String apellido2, String extension, String email, String codigoOficina, int codigoJefe, String puesto)

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                int codigoEmpleado = int.Parse(row["codigo_empleado"].ToString());
                String nombre = row["nombre"].ToString();
                String apellido1 = row["apellido1"].ToString();
                String apellido2 = row["apellido2"].ToString();
                String extension = row["extension"].ToString();
                String email = row["email"].ToString();
                String codigoOficina = row["codigo_oficina"].ToString();
                int codigoJefe = int.Parse(row["codigo_jefe"].ToString());
                String puesto = row["puesto"].ToString();

                Empleado empleado = new Empleado(codigoEmpleado, nombre, apellido1, apellido2, extension, email, codigoOficina, codigoJefe, puesto);
            
                empleados.Add(empleado);
            }

            return empleados;

        }

        public List<String> GetListaNombresEmpleados(int codJefe)
        {
            List<Empleado> empleados = GetListaEmpleados(codJefe);

            return empleados.Select(empleado => empleado.nombre).ToList();
        }


        public List<String> GetListaApellido1Empleados(int codJefe)
        {
            List<Empleado> empleados = GetListaEmpleados(codJefe);

            return empleados.Select(empleado => empleado.apellido1).ToList();
        }

        public List<String> GetListaApellido2Empleados(int codJefe)
        {
            List<Empleado> empleados = GetListaEmpleados(codJefe);

            return empleados.Select(empleado => empleado.apellido2).ToList();
        }

        public List<String> GetListaEmailEmpleados(int codJefe)
        {
            List<Empleado> empleados = GetListaEmpleados(codJefe);

            return empleados.Select(empleado => empleado.email).ToList();
        }



        //METODOS CLIENTES


        public DataSet getClientes()
        {
            return ClienteDLL.getInstance().getClientes();
        }

        public List<Cliente> getListaClientes()
        {
            DataSet dataSet = ClienteDLL.getInstance().getClientes();

            List<Cliente> clientes = new List<Cliente>();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                int codigoCliente = int.Parse(row["codigo_cliente"].ToString());
                String nombreCliente = row["nombre_cliente"].ToString();
                String nombreContacto = row["nombre_contacto"].ToString();
                String apellidoContacto = row["apellido_contacto"].ToString();
                String telefono = row["telefono"].ToString();
                String fax = row["fax"].ToString();
                String lineaDireccion1 = row["linea_direccion1"].ToString();
                String lineaDireccion2 = row["linea_direccion2"].ToString();
                String ciudad = row["ciudad"].ToString();
                String region = row["region"].ToString();
                String pais = row["pais"].ToString();
                String codigoPostal = row["codigo_postal"].ToString();
                int codigoEmpleado = int.Parse(row["codigo_empleado_rep_ventas"].ToString());
                double limiteCredito = double.Parse(row["limite_credito"].ToString());

                Cliente cliente = new Cliente(codigoCliente, nombreCliente, nombreContacto, apellidoContacto, telefono, fax, lineaDireccion1, lineaDireccion2, ciudad, region, pais, codigoPostal, codigoEmpleado, limiteCredito);
            
                clientes.Add(cliente);
            }

            return clientes;
        }


        public List<int> GetListaCodigoClientes()
        {
            List<Cliente> clientes = getListaClientes();

            return clientes.Select(cliente => cliente.CodigoCliente).ToList();
        }

        public List<String> GetListaNombreCliente()
        {
            List<Cliente> clientes = getListaClientes();

            return clientes.Select(cliente => cliente.NombreCliente).ToList();
        }

        public List<String> GetListaNombreContacto()
        {
            List<Cliente> clientes = getListaClientes();

            return clientes.Select(cliente => cliente.NombreContacto).ToList();
        }

        public List<String> GetListaApellidoContacto()
        {
            List<Cliente> clientes = getListaClientes();

            return clientes.Select(cliente => cliente.ApellidoContacto).ToList();
        }

        public List<String> GetListaTelefono()
        {
            List<Cliente> clientes = getListaClientes();

            return clientes.Select(cliente => cliente.Telefono).ToList();
        }

        public List<String> GetListaFax()
        {
            List<Cliente> clientes = getListaClientes();

            return clientes.Select(cliente => cliente.Fax).ToList();
        }

        public List<String> GetListaLineaDireccion1()
        {
            List<Cliente> clientes = getListaClientes();

            return clientes.Select(cliente => cliente.LineaDireccion1).ToList();
        }

        public List<String> GetListaLineaDireccion2()
        {
            List<Cliente> clientes = getListaClientes();

            return clientes.Select(cliente => cliente.LineaDireccion2).ToList();
        }

        public List<String> GetListaCiudad()
        {
            List<Cliente> clientes = getListaClientes();

            return clientes.Select(cliente => cliente.Ciudad).ToList();
        }

        public List<String> GetListaRegion()
        {
            List<Cliente> clientes = getListaClientes();

            return clientes.Select(cliente => cliente.Region).ToList();
        }

        public List<String> GetListaPais()
        {
            List<Cliente> clientes = getListaClientes();

            return clientes.Select(cliente => cliente.Pais).ToList();
        }

        public List<String> GetListaCodigoPostal()
        {
            List<Cliente> clientes = getListaClientes();

            return clientes.Select(cliente => cliente.CodigoPostal).ToList();
        }

        public List<int> GetListaCodigoEmpleado()
        {
            List<Cliente> clientes = getListaClientes();

            return clientes.Select(cliente => cliente.CodigoEmpleado).ToList();
        }

        public List<double> GetListaLimiteCredito()
        {
            List<Cliente> clientes = getListaClientes();

            return clientes.Select(cliente => cliente.LimiteCredito).ToList();
        }


        //SINGLETON
        public static Servicio getInstace()
        {
            if (servicio == null)
            {
                return servicio = new Servicio();
            }
            return servicio;
        }
    }
}
