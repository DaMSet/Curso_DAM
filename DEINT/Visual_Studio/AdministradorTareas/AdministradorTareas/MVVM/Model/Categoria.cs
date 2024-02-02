using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorTareas.MVVM.Model
{
    public class Categoria
    {

        public int IdCategoria { get; set; }
        public string Nombre { get; set; }

        private List<Tarea> tareasC = new List<Tarea>();
        public int cantidadTareas
        {
            get { return ObtenerTareas().Count(); }
        }

        public int cantidadTareasCompletas
        {
            get { return ObtenerTareasCompletas().Count(); }
        }

        public double Progreso
        {
            get
            {
                
                if (cantidadTareas == 0)
                {
                    return 0;
                }

                // Calcular el progreso como cantidadTareasCompletas / cantidadTareas
                return (double)cantidadTareasCompletas / (double)cantidadTareas;
            }




        }


        
        public IEnumerable<Tarea> ObtenerTareas()
        {
          
            return this.tareasC;
        }

        
        public IEnumerable<Tarea> ObtenerTareasCompletas()
        {
            return ObtenerTareas().Where(t => t.Completa);
        }

        public void AgregarTarea(Tarea nuevaTarea)
        {
           
            this.tareasC.Add(nuevaTarea);

            Console.WriteLine($"Se ha agregado la tarea '{nuevaTarea.Nombre}' a la categoría '{Nombre}'.");
        }


      
        public void MarcarTareaCompleta(string nombre)
        {
            var tarea = ObtenerTareas().FirstOrDefault(t => t.Nombre == nombre);

            if (tarea != null)
            {
                tarea.Completa = true;
                Console.WriteLine($"Se ha marcado la tarea '{tarea.Nombre}' como completa en la categoría '{Nombre}'.");
            }
        }



    }
}
