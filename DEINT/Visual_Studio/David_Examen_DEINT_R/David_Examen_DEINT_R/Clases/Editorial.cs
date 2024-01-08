using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Examen_DEINT_R.Clases
{
    internal class Editorial
    {

       
        public int codigoEditorial { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }



        public Editorial()
        {

        }

        public Editorial(int codigoEditorial,string nombre,string direccion) 
        {
            this.codigoEditorial = codigoEditorial;
            this.nombre = nombre;
            this.direccion = direccion;

        }

    }
}
