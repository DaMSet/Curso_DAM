using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Examen_DEINT_R.Clases
{
    public class Libro
    {

        public int isbn { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public int añoPublicacion { get; set; }
        public int codigoEditorial { get; set; } //Este codigo es el mismo que el de la editorial
        public string genero{ get; set; }



        public Libro() 
        {
        
        }

        public Libro(int isbn, string titulo, string autor, int añoPublicacion,  int codigoEditorial, string genero)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.añoPublicacion = añoPublicacion;
           
            this.codigoEditorial = codigoEditorial;
            this.genero = genero;
        }
    }
}
