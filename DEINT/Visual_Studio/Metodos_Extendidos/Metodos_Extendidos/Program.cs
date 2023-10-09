namespace Metodos_Extendidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
                string nombre = "Juan";

                // Usa el método de extensión Saludar
                string saludo = nombre.Saludar();

                Console.WriteLine(saludo);

               

                List<string> list = new List<string>() {"s","d","f","h" };

                List<int> ints = new List<int>() { 1, 2, 3 };


            list.ImprimirLista();
            ints.ImprimirLista();

            
        }


    }
}