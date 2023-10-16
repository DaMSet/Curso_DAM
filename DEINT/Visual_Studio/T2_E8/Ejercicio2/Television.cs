using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Television : Electrodomestico
    {

        //resolución (en pulgadas) y sintonizador TDT (booleano)

        public int Resolucion { get; set; }
        public bool Sintonizador { get; set; }

        public Television( ) : base()
        {

            this.Resolucion = 20;
            this.Sintonizador = false;

        }


        public Television(int resolucion, bool sintonizador, int precio,  int peso) : base(precio, peso)
        {

            this.Resolucion = resolucion;
            this.Sintonizador = sintonizador;
          

        }

        public Television(int resolucion, bool sintonizador,int precio, char consume, int peso, string color) : base(precio, consume, peso, color)
        {
            
            this.Resolucion = resolucion;
            this.Sintonizador = sintonizador;

        }


        public new double precioFinal() 
        {

            double precio = base.precioFinal();

            if (this.Sintonizador) { precio += 50; }

            if (this.Resolucion > 40)
            {
                precio = 0.3* precio;

            }

            return precio;

        }

        /*: si tiene una resolución mayor de 40 pulgadas, se incrementara el
        precio un 30% y si tiene un sintonizador TDT incorporado, aumentara 50 €.
        Recuerda que las condiciones que hemos visto en la clase Electrodomestico
        también deben afectar al precio.*/


        public override string ToString()
        {
            return base.ToString() + " Televisor: ";
        }

    }
}
