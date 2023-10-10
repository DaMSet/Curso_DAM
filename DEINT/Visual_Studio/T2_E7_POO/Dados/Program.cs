namespace Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Juego juego = new Juego();


            juego.tirar();

            Console.WriteLine(juego.ganar());
            
            

        }



    }
}