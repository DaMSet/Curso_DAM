using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E8
{
    internal class Directivo: Empleado
    {

        public Directivo(string Nombre) : base(Nombre) { }


       

        public override string ToString()
        {
            return base.ToString() + "-> Directivo";
        }


    }
}
