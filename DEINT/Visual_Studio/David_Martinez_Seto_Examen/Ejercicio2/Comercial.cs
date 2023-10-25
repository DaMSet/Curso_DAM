using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Comercial : Empleado
    {

        private double Comision;

        public double comision { get; set; }



        public Comercial(string dni, string nombre, int edad, string correo,double comision) : base(dni, nombre, edad, correo)
        {

            this.Comision = comision;

        }


        public override string ToString()
        {
            return base.ToString() + $"Comision :{Comision}";
        }

        public override void plus()
        {
            if (this.edad >= 30 && comision >= 200) { this.ActualizarSalario(); }
        }

    }
}
