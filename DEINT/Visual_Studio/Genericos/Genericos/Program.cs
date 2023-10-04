namespace Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Genericos
            //Nos permite pasar parametros de cualquier tipo
            //nos ayuda a reutilizar codigo


            int CalcularLongitudArray <T>(T[] array) {

                return array.Length;

            }

            DateTime[] fechas = { DateTime.Today, DateTime.Today.AddDays(3), DateTime.Today.AddDays(5) };

            Console.WriteLine("Longitud de fechas "+CalcularLongitudArray(fechas));
            Console.WriteLine($"Longitud de fechas { CalcularLongitudArray(fechas)}");

            int[] numeros = {1,2,3,4,5,6,7,8,9 };

            Console.WriteLine("Longitud de numeros " + CalcularLongitudArray(numeros));

            //Tambien puede ser generico el tipo de salida

            T? CalcularTipoArray2<T>(T[] array)
            {

                if (array.Length == 0) { return default; }

                return array[0] ;

            }

           

            Console.WriteLine("tipo de fechas " + CalcularTipoArray2(fechas));

            Console.WriteLine("tipo de numeros " + CalcularTipoArray2(numeros));

        }
    }
}