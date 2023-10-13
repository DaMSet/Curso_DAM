using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Electrodomestico
    {

       /* enum Consumo 
        {
        A,B,C,D,E,F
        }*/

        private double Precio_base;
        private string Color;
        private char Consumo;
        private int Peso;

        public Electrodomestico() 
        {
            this.Precio_base = 100;
            this.Consumo = 'F'; 
            this.Peso = 5;
            this.Color = "Blanco";

        }

        public Electrodomestico(double precio, int peso)
        {
            this.Precio_base = precio;
            this.Consumo = 'F';
            this.Peso = peso;
            this.Color = "Blanco";

        }

        public Electrodomestico(double precio, char consume, int peso, string color)
        {
            this.Precio_base = precio;
            if (comprobarConsumoEnergia(Consumo))
            {
                this.Consumo = consume;
            }
            else 
            {
                this.Consumo = 'F';
            }
            
            this.Peso = peso;

            if (comprobarColor(color))
            {
                this.Color = color;
            }
            else { this.Color = "Blanco"; }

            

        }




        public bool comprobarConsumoEnergia(char letra) 
        {

            if (letra.Equals('A') || letra.Equals('B') || letra.Equals('C')
                || letra.Equals('D') || letra.Equals('E') || letra.Equals('F'))
            { 
            return true;
            }

            return false;

        }
        /*: comprueba que la letra es correcta,
        sino es correcta usara la letra por defecto.Se invocará al crear el objeto y no
        será visible.*/

        public bool comprobarColor(string color) 
        {
            //blanco, negro, rojo, azul y gris

            if (color.ToLower() == "blanco" || color.ToLower() == "negro" || color.ToLower() == "rojo"
                || color.ToLower() == "azul" || color.ToLower() == "gris") 
            {
                return true;
            }

            return false;

        }


        /*comprueba que el color es correcto, sino lo es
        usa el color por defecto. Se invocará al crear el objeto y no será visible.
        */
        public double precioFinal() 
        {
            double precio = 0;

            switch (this.Consumo) 
            {
            
                case 'A':
                    precio += 100;
                    break;
                case 'B':
                    precio += 80;
                    break;
                case 'C':
                    precio += 60;
                    break;
                case 'D':
                    precio += 50;
                    break;
                case 'E':
                    precio += 30;
                    break;
                case 'F':
                    precio += 10;
                    break;

            }

            if (this.Peso > 0 && this.Peso <= 19 ) 
            {
                precio += 10;

            }else if (this.Peso >= 20 && this.Peso <= 49) 
            {
                precio += 50;
            }
            else if (this.Peso >= 50 && this.Peso <= 79)
            {
                precio += 80;
            }
            else if (this.Peso >= 80)
            {
                precio += 100;
            }


            return precio;
        }


        public override string ToString()
        {
            return "Electrodomestico: ";
        }
        /*según el consumo energético, aumentara su precio, y según su
        tamaño, también.Esta es la lista de precios:*/

    }
}
