using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.Model
{
    internal class Pedido
    {

        public int CodigoPedido { get; set; }
        public DateTime FechaPedido { get; set; }   
        public DateTime FechaEspera {  get; set; }
        public DateTime FechaEntrega { get; set; }
        public String Estado { get; set; }
        public String Comentario { get; set;}
        public int CodigoCliente { get; set; }

        public Pedido(int codigoPedido, DateTime fechaPedido, DateTime fechaEspera, DateTime fechaEntrega, String estado, String comentario, int codigoCliente)
        {
            this.CodigoPedido = codigoPedido;
            this.FechaPedido = fechaPedido;
            this.FechaEspera = fechaEspera;
            this.FechaEntrega = fechaEntrega;
            this.Estado = estado;
            this.Comentario = comentario;
            this.CodigoCliente = codigoCliente;
        }

    }
}
