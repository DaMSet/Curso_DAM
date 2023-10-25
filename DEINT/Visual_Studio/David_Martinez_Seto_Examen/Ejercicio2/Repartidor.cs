using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Repartidor : Empleado
    {

        private string Zona;

        public string zona { get; set; }

        public Repartidor(string dni, string nombre, int edad, string correo,string zona) : base(dni, nombre, edad, correo)
        {

            this.Zona = zona;

        }


        public override string ToString()
        {
            return base.ToString()+ $"Zona :{Zona}";
        }


        public override void plus()
        {
            if (this.edad < 25 && Zona.Equals("zona 3") ) { this.ActualizarSalario(); }
        }

    }
}
