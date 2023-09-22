namespace EjercicioDeC_2_Media_4Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double media = 0;
            double num = 0;

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Por favor, ingresa un numero:");
                String cadena = Console.ReadLine();

               num = Convert.ToDouble(cadena);

                //Console.WriteLine(num);
                media += num;

                

            }
            media = media / 4;

            Console.WriteLine("La media es: " + media);

        }
    }
}