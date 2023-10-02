using System;
using System.Linq;

namespace Actividad5
{
    public class Actividad5
    {
        static void Main(string[] args)
        {
            isPalindromo("Salida adilas");
        }

        public static string devolverString(string[] vs)
        {
            string conjuntoString = "";

            foreach (string v in vs) 
            {
            
                conjuntoString += v;

            }

            return conjuntoString;
        }

        public static string devolverStringOrdenado(string[] vs)
        {
            string conjuntoString = "";
            string[] temp;

            Array.Sort(vs);


            foreach (string v in vs)
            {
                conjuntoString += v;
            }

            return conjuntoString; 
        }

        public static int contarCaracter(string[] vs, char v)
        {
            string temp = devolverStringOrdenado(vs);
            int contador = 0;

            foreach(char c in temp)
            {

                if (char.ToLower(c) == char.ToLower(v))
                {
                    contador++;
                }

            }


            return contador;
        }

        public static int[] sumarArrays(int[] vs1, int[] vs2)
        {
            int[] temp = new int[vs1.Length];

          
                for (int i = 0; i < vs1.Length; i++)
                {

                    temp[i] = vs1[i] + vs2[i];

                }

            
            

            return temp;
        }

        public static int[] multiplicarArrays(int[] vs1, int[] vs2)
        {
            int[] temp = new int[vs1.Length];


            for (int i = 0; i < vs1.Length; i++)
            {

                temp[i] = vs1[i] * vs2[i];

            }


            return temp;
        }

        public static bool isPalindromo(string entrada)
        {
            entrada = entrada.ToLower();
            string temp = entrada.Replace(" ", "");
            string part1 = "", part2 = "",part2Inverted = "";

            temp.Reverse();

            for (int i = 0; i < temp.Length; i++) {



                if (i >= temp.Length / 2)
                {

                    part2 += temp[i];

                }
                else 
                {

                    part1 += temp[i];

                }

            }


            for (int i = part2.Length - 1; i >= 0; i--)
            {
                part2Inverted += part2[i];
            }


            Boolean retorno = false;

            if(part1.Equals(part2Inverted)) retorno = true;

            return retorno;

        }

        public static int contarPalabras(string entrada)
        {
            //TODO
            int cantidad = 0;

            foreach (char car in entrada) 
            {

                if (car == ' ')
                {
                    cantidad++;
                }

                
            }

            if (cantidad > 0) cantidad++;


            return cantidad;
        }

        public static int contarCaracteres(string entrada)
        {
            //TODO
            entrada = entrada.Replace(" ", "");
            int contador = 0;


            foreach (char c in entrada) 
            {

                contador++;

            }


            return contador;
        }
    }
}
