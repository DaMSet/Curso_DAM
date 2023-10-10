using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_T2_E7_POO
{
    internal class Persona
    {

        private string Nombre { get; set; }
        
        private int edad { get; set; }


        public Persona(string nombre, int edad) 
        {
            this.Nombre = nombre;
            this.edad = edad;

        }

        

    }
}
