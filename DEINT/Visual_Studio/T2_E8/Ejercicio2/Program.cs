namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Electrodomestico[] electrodomesticos = new Electrodomestico[10];

            electrodomesticos[0] = new Electrodomestico();
            electrodomesticos[1] = new Electrodomestico(30,100);
            electrodomesticos[2] = new Electrodomestico(12,'A',56,"blanco");
            electrodomesticos[3] = new Electrodomestico();
            electrodomesticos[4] = new Lavadora();
            electrodomesticos[5] = new Lavadora(13,45);
            electrodomesticos[6] = new Lavadora(45,78,'F',55,"negro");
            electrodomesticos[7] = new Television();
            electrodomesticos[8] = new Television(55,true,33,77);
            electrodomesticos[9] = new Television(12,false,33,'E',44,"fefe");
            

            double suma = 0;

            foreach (Electrodomestico elec in electrodomesticos) 
            {

                Console.WriteLine(elec.ToString()+"  "+elec.precioFinal());
                suma+= elec.precioFinal();

            
            }

            Console.WriteLine("Suma total: "+suma);

        }
    }
}