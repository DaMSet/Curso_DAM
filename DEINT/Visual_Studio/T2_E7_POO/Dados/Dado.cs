using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    internal class Dado
    {
        Random random = new Random();

       
        //random.Next(1, 6);

        public int Valor { get; set; }
        public Dado() 
        {
        
        }

        public void tirar() 
        {

            Valor = random.Next(1, 6);

            Console.WriteLine(Valor);

        }

    }
}
