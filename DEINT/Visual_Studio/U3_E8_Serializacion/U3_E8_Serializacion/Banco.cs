using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_E8_Serializacion
{
    public class Banco
    {

        public List<Cliente> Clientes { get; set; }
        
        public Banco() { }

        public Banco(List<Cliente> clientes) 
        {
        
            this.Clientes = clientes;

        }


        public void añadirCliente(string dni, string nombre,string direccio, int edad, int telefono, int nC) 
        {
            
            this.Clientes.Add(new Cliente(dni,nombre,direccio,edad,telefono,nC));

        }





    }
}
