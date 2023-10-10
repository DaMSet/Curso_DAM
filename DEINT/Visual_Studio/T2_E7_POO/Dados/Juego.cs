using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    internal class Juego
    {

        internal Dado[] Dados = new Dado[3];

        //public Dado[] Dados { get; set; }

        public Juego() 
        {
           
            Dados[0] = new Dado();
            Dados[1] = new Dado();
            Dados[2] = new Dado();
        
           

        }

        public void tirar() {

            for (int i = 0; i < Dados.Length; i++) 
            {
                Dados[i].tirar();                
            }

        }

        public Boolean ganar() 
        {

            if (Dados[0] == Dados[1] && Dados[0] == Dados[2]) { return true; }


            return false;

        }

    }
}
