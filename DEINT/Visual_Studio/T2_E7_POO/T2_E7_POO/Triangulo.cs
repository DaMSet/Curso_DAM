using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E7_POO
{
    internal class Triangulo
    {
        /*
        int _ladosIguales;
        int _ladodiferente;
        int _altura;
        */

        public int LadosIguales { get; set; }
        public int Ladodiferente { get; set; }
        public int Altura { get; set; }


        public Triangulo()
        {
            LadosIguales = 5;
            Ladodiferente = 10;
            Altura = 10;
        }

        public int calcularPerimetro() 
        {
            return (LadosIguales*2) + Ladodiferente;
        }

        public int calcularArea() 
        {
            return (Ladodiferente*Altura)/2;
        }

    }
}
