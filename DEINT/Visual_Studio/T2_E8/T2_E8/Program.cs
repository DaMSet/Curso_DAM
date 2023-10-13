namespace T2_E8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Empleado rafa = new Empleado("RAFA");
            Empleado pepe = new Directivo("pepe");
            Empleado jojo = new Operario("jojo");
            Empleado lana = new Oficial("lana");
            Empleado lira = new Tecnico("lira");

            Console.WriteLine(rafa.ToString());
            Console.WriteLine(pepe.ToString());
            Console.WriteLine(jojo.ToString());
            Console.WriteLine(lana.ToString());
            Console.WriteLine(lira.ToString());

        }
    }
}