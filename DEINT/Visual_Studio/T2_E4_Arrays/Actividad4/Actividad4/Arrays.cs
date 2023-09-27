using System;
using System.Collections.Generic;

namespace Actividad4
{
    public class Arrays
    {
        static void Main(string[] args)
        {
        }

        public static int minValorArray(int[] array)
        {
            //TODO
            if (array.Length == 0)
            {
                
                int minV = 0;
                return minV;
            }
            else {

                int minV = array[0]; ;

                for (int i = 0; i < array.Length; i++)
                {


                    if (minV > array[i])
                    {

                        minV = array[i];

                    }

                }
                return minV;
            }
            

            

            throw new NotImplementedException();
        }
        public static int[] invertirArray(int[] array)
        {
            //TODO

            int temp =  0,temp2 = 0;

            for(int i = 0; i < array.Length; i++) { 
            
                temp = array[i];
                temp2 = array[^(i+1)];

                array[i] = temp2;
                array[^(i+1)] = temp;

            }

            return array;

                throw new NotImplementedException();
        }

        public static int comprobarValorEnArray(int[] array, int valor)
        {
            //TODO

            int salida = -1;

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == valor)
                {

                    return i;
                }
                
            }

            return salida;


            throw new NotImplementedException();
        }

        public static int calcularModa(int[] entrada)
        {

            //Mapa en C#
            Dictionary<int, int> frecuencias = new Dictionary<int, int>();

            // Contar la frecuencia de cada elemento en el array
            foreach (int numero in entrada)
            {
                if (frecuencias.ContainsKey(numero))
                {
                    frecuencias[numero]++;
                }
                else
                {
                    frecuencias[numero] = 1;
                }
            }

            int moda = 0;
            int maxFrecuencia = 0;

            // Encontrar el elemento con la frecuencia máxima
            foreach (var numero in frecuencias)
            {
                if (numero.Value > maxFrecuencia)
                {
                    moda = numero.Key;
                    maxFrecuencia = numero.Value;
                }
            }

            return moda;



            //TODO
            throw new NotImplementedException();
        }
    }
}
