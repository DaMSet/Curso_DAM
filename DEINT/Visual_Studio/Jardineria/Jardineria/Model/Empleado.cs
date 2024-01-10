using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.Model
{
    internal class Empleado
    {

        public int codigoEmpleado {  get; set; }
        public String nombre {  get; set; }
        public String apellido1 { get; set; }
        public String apellido2 { get; set; }
        public String extension { get; set; }
        public String email { get; set; }
        public String codigoOficina { get; set; }
        public int codigoJefe {  get; set; }
        public String puesto { get; set; }

        public Empleado(int codigoEmpleado, String nombre, String apellido1, String apellido2, String extension, String email, String codigoOficina, int codigoJefe, String puesto)
        {
            this.codigoEmpleado = codigoEmpleado;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.extension = extension;
            this.email = email;
            this.codigoOficina = codigoOficina;
            this.codigoJefe = codigoJefe;
            this.puesto = puesto;
        }

    }
}
