namespace EjercicioDeC_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 50; i++)
            {
                if (i % 2 == 0) { 
                //Es par

                    if (i % 3 <= 0) {

                        Console.WriteLine(i);

                    }

                }
            }


        }
    }
}