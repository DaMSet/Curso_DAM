using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Excepciones:Exception
    {

        public Excepciones() { }

        Exception FormatoIncorrecto() { return new Exception(); }

    }
}
