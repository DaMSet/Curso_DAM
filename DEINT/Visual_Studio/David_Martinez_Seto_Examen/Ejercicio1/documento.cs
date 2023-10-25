using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class documento
    {

       

        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }

        public documento() 
        {
        
            this.Nombre = " ";
            this.Fecha = DateTime.MinValue;

        }

        public documento(string nombre)
        {

            this.Nombre = nombre;
            this.Fecha = DateTime.Today;

        }


    }
}
