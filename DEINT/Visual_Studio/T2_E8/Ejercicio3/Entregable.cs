using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal interface Entregable
    {

        public void entregar(); //: cambia el atributo entregado a true.
        public void devolver();//: cambia el atributo entregado a false.
        public bool isEntregado(); //: devuelve el estado del atributo entregado.

    }
}
