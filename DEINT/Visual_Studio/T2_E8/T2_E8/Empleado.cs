using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E8
{
    internal class Empleado
    {

        private string Nombre { get; set; }

        public Empleado(string nombre) 
        {

            this.Nombre = nombre;

        }


        public string getNombre() 
        {
            return Nombre;
        }

        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }


        public override string ToString()
        {
            return $"Empleado : {Nombre} ";
        }

    }
}
