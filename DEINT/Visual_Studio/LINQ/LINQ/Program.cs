namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] numeros2 = Enumerable.Range(1,11).ToArray();

            //extraer numeros pares (sintaxis metodos)

            var numerosPares = numeros.Where(n => n % 2 == 0).ToList();

            //nos permite hacer filtros de esta manera

            int[] numeros3 = Enumerable.Range(1, 20).ToArray();

            var numerosImpares = numeros3.Where(n => n% 2 == 1).ToList();
            
            var numerosImparesMayor10 = numeros3.Where(n => n % 2 == 1 && n > 10).ToList();




            //EJEMPLO CON OBJETOS

            Persona[] personas =
            {
            new Persona(12),new Persona(99),new Persona(33)

            };
           


            //Funcion con first, firstOrDefault


            var primeraPersona = personas.First();

            var primeraPersona2 = personas.FirstOrDefault();


            //filtros extra

            var primeraPMenor25 = personas.First(p => p.Edad < 25);

            var primeraPMayor100 = personas.First(p => p.Edad > 25);

        }
    }
}