using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Martinez_Examen_2
{
    internal class Tareas
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public Estado estado { get; set; }

        public Tareas(string nombre, string descripcion, DateTime fechaVencimiento,Estado estado) 
        {
        
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.fechaVencimiento = fechaVencimiento;
            this.estado = estado;

        } 
    }
}
