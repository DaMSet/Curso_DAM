namespace EjercicioDeC_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa de consola en el que se muestre por pantalla los 5 primeros números primos
            

            static bool EsPrimo(int numero) {

                if (numero <= 1)
                {
                    return false;
                }

                if (numero <= 3)
                {
                    return true;
                }

                if (numero % 2 == 0 || numero % 3 == 0)
                {

                    return false;

                }

                for (int i = 5; i * i <= numero; i += 6)
                {
                    if (numero % i == 0 || numero % (i + 2) == 0)
                        return false;
                }


                return true;
            }

            int numDePrimos = 0;
            int inicio = 2;

            while (numDePrimos <10)
            {
                if (EsPrimo(inicio)) {

                    Console.WriteLine(inicio);
                    numDePrimos++;
                }

                inicio++;
                               
            }

        }
    }
}