using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Lavadora : Electrodomestico
    {

        const int CargaB = 5;

        public int Carga { get; set; }


        public Lavadora( ) : base()
        {

            this.Carga = CargaB;


        }

        public Lavadora(double precio, int peso) : base(precio,  peso)
        {

            this.Carga = CargaB;

        }
        public Lavadora(int carga, double precio, char consume, int peso, string color) :base( precio,  consume,  peso,  color) 
        {
        
            this.Carga = carga;

        }


        public new double precioFinal( ) 
        {
            double precio = base.precioFinal(); 

            if (this.Carga > 30) 
            {
                precio += 50;

            } 
        
            return precio;

        }
        /* : si tiene carga mayor a 30kg, aumenta el precio 50€, sino es así no
         se incrementa el precio.Llama al método padre y añade el código necesario*/


        public override string ToString()
        {
            return base.ToString()+ " Labadora: ";
        }

    }
}
