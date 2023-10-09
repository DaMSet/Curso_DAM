using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    internal class Juego
    {

        internal Dado[] _dados = { };

        public Dado[] Dados { get; set; }

        public Juego() 
        {

            _dados[0] = new Dado();
            _dados[1] = new Dado();
            _dados[2] = new Dado();

        }

        public void tirar() {

            for (int i = 0; i < _dados.Length; i++) 
            {
                _dados[i].tirar();                
            }

        }

        public Boolean ganar() 
        {

            if (_dados[0] == _dados[1] && _dados[0] == _dados[2]) { return true; }


            return false;

        }

    }
}
