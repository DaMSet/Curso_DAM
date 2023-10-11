using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_T2_E7_POO
{
    internal class Cliente1
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }

        private int dinero { get; set; }

        public Cliente1(string dni, string nombre) 
        {
            this.DNI = dni;
            this.Nombre = nombre;
            this.dinero = 10000;


        }

        public void ingresar(int dinero) 
        {

            this.dinero += dinero;

        }

        public void extraer(int dinero) 
        {
        
                this.dinero -= dinero;

        }

        public int comprobar() 
        {
        
            return this.dinero;

        }
    }
}
