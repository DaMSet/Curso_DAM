using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Serie
    {

        //título, numero de temporadas, entregado, género y creador

        private string Titulo,genero,creador;
        private int Ntemporadas;
        private bool Entregado;
        
        public Serie() 
        {
            this.Titulo = default;
            this.Entregado = false;
            this.Ntemporadas = 3;
            this.genero = default;
            this.creador = default;

        }

        public Serie(string titulo, string creador)
        {
            this.Titulo = titulo;
            this.Entregado = false;
            this.Ntemporadas = 3;
            this.genero = default;
            this.creador = creador;

        }

        public Serie(string titulo, bool entregado, int ntemporadas, string genero, string creador)
        {
            this.Titulo = titulo;
            this.Entregado = entregado;
            this.Ntemporadas = ntemporadas;
            this.genero = genero;
            this.creador = creador;

        }


        public override string ToString()
        {
            return $" Titulo: {this.Titulo} , esta entregado: {this.Entregado} tiene {this.Ntemporadas} temporadas , es de genero {this.genero} y su creador es: {this.creador}";
        }

        public void devolver()
        {
            this.Entregado = false;
        }

        public void entregar()
        {
            this.Entregado = true;
        }

        public bool isEntregado()
        {
            return this.Entregado;
        }


    }
}
