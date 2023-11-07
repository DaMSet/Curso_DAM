using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_E4_Formularios.Model
{
    public class Estudiante
    {

        public int Id { get; set; }
        public string NombreEstudiante { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Email { get; set; }
        public int Ciclo { get; set; }
        public byte[] FotoEstudiante { get; set; }


    }
}
