namespace Ejercicio3_T2_E7_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Cliente1 cliente = new Cliente1();

            Console.WriteLine( cliente.comprobar());

            cliente.ingresar(33);
            Console.WriteLine(cliente.comprobar());

            cliente.extraer(1000);
            Console.WriteLine(cliente.comprobar());

        }
    }
}

/*
 3. Crea un programa con las siguientes clases:
a. Cliente: esta clase tendrá los siguientes atributos DNI, nombre y cantidad
ahorrada y los métodos Ingresar (aumentará la cantidad ahorrada con el dinero
indicado), Extraer (restará a la cantidad ahorrada lo que se indique) y Consultar
Saldo, que mostrará la cantidad ahorrada en cada momento.
b. Banco: tiene un atributo que será un array de tamaño 3 de objetos de tipo Cliente.
Tendrá un método Operar, que permitirá llamar a los métodos Ingresar y Extraer
de los clientes. Para ello nos solicitará el cliente sobre el DNI sobre el que
queremos operar, la operación a realizar y la cantidad. También banco debe tener
otro método que “al final del día” calcule la cantidad de dinero que hay
depositada.
 */