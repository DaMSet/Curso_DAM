using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.Model
{
    internal class Gama
    {

        public string Nombre { get; set; }
        public string DescripcionTexto { get; set;}
        public string DescripcionHtml { get; set; }
        public string imagen { get; set; }

        public Gama(String nombre, String descripcionTexto, String descripcionHtml, String imagen)
        {
            this.Nombre = nombre;
            this.DescripcionTexto = descripcionTexto;
            this.DescripcionHtml = descripcionHtml;
            this.imagen = imagen;
        }


    }
}
