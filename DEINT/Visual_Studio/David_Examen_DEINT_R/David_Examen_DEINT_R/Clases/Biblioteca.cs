using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Examen_DEINT_R.Clases
{
    internal class Biblioteca
    {

        public List<Libro> libros { get; set; }

        public Biblioteca() 
        {
            
            libros = new List<Libro>();

        }

        public void añadirLibro(Libro libro) 
        {
            libros.Add(libro);
        }

    }
}
