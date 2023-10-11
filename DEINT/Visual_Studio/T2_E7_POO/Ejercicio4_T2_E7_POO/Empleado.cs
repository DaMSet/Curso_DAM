using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_T2_E7_POO
{
    internal class Empleado : Persona

    {
        public int Sueldo { get; set; }

        public Empleado(string nombre, int edad,int sueldo) : base(nombre, edad)
        {
            this.Sueldo = sueldo;
        }


        public override string ToString()
        {
            return base.ToString() + $" Sueldo {Sueldo}";
        }

    }
}
