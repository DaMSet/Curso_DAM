using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_E8_Serializacion
{
    internal class Cliente
    {

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public int N_cuenta { get; set; }


        public Cliente()
        { }


        public Cliente(string dNI, string nombre, string direccion,int edad,int telefono,int n_cuenta)
        {

            DNI = dNI;
            Nombre = nombre;
            Direccion = direccion;
            Edad = edad;
            Telefono = telefono;
            N_cuenta = n_cuenta;


        }

    }
}
