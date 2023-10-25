using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Servicio
    {

        private Stack<documento> Pila;
        private Queue<documento> Cola;
        public Stack<documento> pila { get; set; }
        public Queue<documento> cola { get; set; }

        public Servicio() { 
        
            Pila = new Stack<documento>();
            /*
            Pila.Peek();
            Pila.Pop();
            Pila.Push(new documento("Prueba"));
            */

            Cola = new Queue<documento>();
            /*
            Cola.Enqueue(new documento("pepe"));
            Cola.Dequeue();
            */


        }


        public void AgregarDocumentoPendiente(string nombreDoc) 
        {
            Cola.Enqueue(new documento(nombreDoc));
        }

        public void ArchivarDocumento()
        {
            Pila.Push(Cola.Dequeue());
        }

        public List<documento> MostrarDocumentosPendientes()
        {
            List<documento> lista = new List<documento>();
            foreach (documento documento in Cola) 
            {
                lista.Add(documento);
            }

            return lista;
        }

        public List<documento> MostrarDocumentosArchivados()
        {

            List<documento> lista = new List<documento>();
            foreach (documento documento in Pila)
            {
                lista.Add(documento);
            }

            return lista;

        }

    }
}
