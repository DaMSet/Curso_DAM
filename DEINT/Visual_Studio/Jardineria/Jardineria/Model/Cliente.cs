using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.Model
{
    internal class Cliente
    {
        public int CodigoCliente {  get; set; }
        public String NombreCliente { get; set; }
        public String NombreContacto { get; set; }
        public String ApellidoContacto { get; set; }
        public String Telefono {  get; set; }
        public String Fax { get; set; }
        public String LineaDireccion1 { get; set; }
        public String LineaDireccion2 { get; set; }
        public String Ciudad {  get; set; }
        public String Region { get; set; }
        public String Pais { get; set; }
        public String CodigoPostal {  get; set; }
        public int CodigoEmpleado { get; set; }
        public double LimiteCredito { get; set; }

        public Cliente(int codigoCliente, String nombreCliente, String nombreContacto, String apellidoContacto, String telefono, String fax, String lineaDireccion1, String lineaDireccion2, String ciudad, String region, String pais, String codigoPostal, int codigoEmpleado, double limiteCredito)
        {
            this.CodigoCliente = codigoCliente;
            this.NombreCliente = nombreCliente;
            this.NombreContacto = nombreContacto;
            this.ApellidoContacto = apellidoContacto;
            this.Telefono = telefono;
            this.Fax = fax;
            this.LineaDireccion1 = lineaDireccion1;
            this.LineaDireccion2 = lineaDireccion2;
            this.Ciudad = ciudad;
            this.Region = region;
            this.Pais = pais;
            this.CodigoPostal = codigoPostal;
            this.CodigoEmpleado = codigoEmpleado;
            this.LimiteCredito = limiteCredito;
        }

    }
}
