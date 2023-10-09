using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Extendidos
{
    public static class Class1
    {

      

        public static String Saludar(this string? nombre) 
        {

            return $"¡Hola, {nombre}!";

        }

        public static void ImprimirLista<T> (this List<T> lista) 
        {

            foreach (var item in lista) 
            {
            
                Console.WriteLine(item?.ToString());

            }

        }




    }
}
