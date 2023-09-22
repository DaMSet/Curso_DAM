using System;

namespace Ejercicio2DeC__Monedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear un programa llamado monedas.cs en el que se debe de calcular el menor
             número de monedas necesarias para devolver el cambio de una maquina
             expendedora en la que todos los productos cuestan lo mismo (45 céntimos). Se
             pueden devolver monedas de 5, 10, 20 y 50 céntimos y de 1 y 2 euros. El
             programa debe de solicitar por teclado la cantidad introducida.
             */

            bool salir = false;

            List<double> monedas = new List<double>();

            double aDevolver = 0;

            const double PRECIO = 0.45;

            while (salir)
            {

                Console.WriteLine("Por favor, ingresa una moneda o billete:");
                
                string texto = Console.ReadLine();

                aDevolver = Convert.ToDouble(texto);

                aDevolver -= PRECIO;
            
            

                if (aDevolver % 2 != 0 && aDevolver % 2 > 0 || aDevolver % 2 == 0) {

                    aDevolver -= 2;

                    monedas.Add(2);
                }
                

                else if (aDevolver -1 >0 ||  aDevolver - 1 == 0)
                {

                    aDevolver -= 1;

                    monedas.Add(1);
                }
                else if (aDevolver - 0.50 > 0 || aDevolver - 0.50 == 0)
                {

                    aDevolver -= 0.50;

                    monedas.Add(0.50);
                }
                else if (aDevolver - 0.20 > 0 || aDevolver - 0.20 == 0)
                {

                    aDevolver -= 0.20;

                    monedas.Add(0.20);
                }
                else if (aDevolver - 0.10 > 0 || aDevolver - 0.10 == 0)
                {

                    aDevolver -= 0.10;

                    monedas.Add(0.10);
                }
                else if (aDevolver - 0.05 > 0 || aDevolver - 0.05 == 0)
                {

                    aDevolver -= 0.05;

                    monedas.Add(0.05);
                }



               

            }


        }
    }
}