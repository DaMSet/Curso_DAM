using AdministradorTareas.MVVM.Model;

using System.Collections.ObjectModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;


namespace AdministradorTareas.MVVM.ViewModel
{
    public class ColectionViewModelTareas
    {
        public ObservableCollection<Tarea> Tareas { get; set; } = new ObservableCollection<Tarea>();
        public ObservableCollection<Categoria> Categorias { get; set; } = new ObservableCollection<Categoria>();
        
         

        public ColectionViewModelTareas()
        {
            
            Tareas = new ObservableCollection<Tarea>
            {
                 new Tarea
                     {
                     IdTarea = 0,
                     
                     Nombre = "limpiar",
                     Completa = false,
                     },
                 new Tarea
                     {
                     IdTarea = 1,
                     
                     Nombre = "limpiar 1",
                     Completa = false,
                     },
                 new Tarea
                     {
                     IdTarea = 2,
                     
                     Nombre = "limpiar 2",
                     Completa = true,
                     },
              

            };

            Categorias = new ObservableCollection<Categoria>
            {
                 new Categoria 
                     {
                     IdCategoria = 0,
                     Nombre = "categoria 0",

                     },
                 new Categoria
                     {
                     IdCategoria = 1,
                     Nombre = "categoria 1",
                     
                    
                                          },
                 new Categoria
                     {
                     IdCategoria = 2,
                     Nombre = "categoria 2",
                      
                                           
                     },


            };
        }

        
      
    }
}
