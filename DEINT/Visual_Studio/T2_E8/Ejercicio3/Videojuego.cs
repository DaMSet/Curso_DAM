using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Videojuego: Entregable
    {

        //título, horas estimadas, entregado, género y compañía

        private string titulo;
        private int horas_estimadas;
        private bool Entregado;
        private string genero;
        private string compañia;
        public Videojuego() 
        {
            this.Entregado = false;
            

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
