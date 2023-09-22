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

            

            int monedas2 = 0;
            int monedas1 = 0;
            int monedas50 = 0;
            int monedas20 = 0;
            int monedas10 = 0;
            int monedas5 = 0;



            double aDevolver = 0;

            const double PRECIO = 0.45;

            Console.WriteLine("Por favor, ingresa una moneda o billete:");

            string texto = Console.ReadLine();

            aDevolver = Convert.ToDouble(texto);

            aDevolver -= PRECIO;



                while (aDevolver % 2 != 0 && aDevolver % 2 > 0 || aDevolver % 2 == 0)
                {

                    if (aDevolver % 2 != 0 && aDevolver % 2 > 0 || aDevolver % 2 == 0) {

                    aDevolver -= 2;

                    monedas2++;

                }

                while (aDevolver - 1 > 0 || aDevolver - 1 == 0)
                {
                    if (aDevolver - 1 > 0 || aDevolver - 1 == 0)
                    {

                        aDevolver -= 1;

                        monedas1++;
                    }
                }

                while (aDevolver - 0.50 > 0 || aDevolver - 0.50 == 0)
                {
                    if (aDevolver - 0.50 > 0 || aDevolver - 0.50 == 0)
                    {

                        aDevolver -= 0.50;

                        monedas50++;
                    }
                }

                while (aDevolver - 0.50 > 0 || aDevolver - 0.50 == 0)
                {
                    if (aDevolver - 0.50 > 0 || aDevolver - 0.50 == 0)
                    {

                        aDevolver -= 0.50;

                        monedas50++;
                    }
                }

                while (aDevolver - 0.20 > 0 || aDevolver - 0.20 == 0)
                {
                    if (aDevolver - 0.20 > 0 || aDevolver - 0.20 == 0)
                    {

                        aDevolver -= 0.20;

                        monedas20++;
                    }
                }

                while (aDevolver - 0.10 > 0 || aDevolver - 0.10 == 0)
                {
                    if (aDevolver - 0.10 > 0 || aDevolver - 0.10 == 0)
                    {

                        aDevolver -= 0.10;

                        monedas10++;
                    }
                }


                while (aDevolver - 0.05 > 0 || aDevolver - 0.05 == 0)
                {
                    if (aDevolver - 0.05 > 0 || aDevolver - 0.05 == 0)
                    {

                        aDevolver -= 0.05;

                        monedas5++;
                    }
                }


                Console.WriteLine("Monedas de 2 $: "+monedas2);

                Console.WriteLine("Monedas de 1 &: " + monedas2);

                Console.WriteLine("Monedas de 50 ctm: " + monedas2);

                Console.WriteLine("Monedas de 20 ctm: " + monedas2);

                Console.WriteLine("Monedas de 10 ctm: " + monedas2);

                Console.WriteLine("Monedas de 5 ctm: " + monedas2);

            }
    }
}