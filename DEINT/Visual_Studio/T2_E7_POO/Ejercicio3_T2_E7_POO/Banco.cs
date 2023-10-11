using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_T2_E7_POO
{
    internal class Banco
    {

            private static Cliente1[] clientes = new Cliente1[3];
            private static int salario_ingresado = 0;
        public Banco() 
        {
            clientes[0] = new Cliente1("123","pepe");
            clientes[1] = new Cliente1("456","jojo");
            clientes[2] = new Cliente1("789","ferna");

            //mostrarMenu();

        }



        public  void mostrarMenu() 
        {

            Console.WriteLine("1 operar");
            Console.WriteLine("2 mirar ingresos");
            Console.WriteLine("3 salir");
            
            int seleccion = Convert.ToInt32(Console.ReadLine());

            switch (seleccion) 
            {
                case 1: Console.WriteLine("Inserte dni");

                    string dni = Console.ReadLine();

                    operar(dni);

                    break;

                case 2: Console.WriteLine("Mirar ingresos");


                    break;

                case 3: Console.WriteLine("Adios");
                    break;



            }


        }


        private  void operar(string dni) 
        {

            foreach (var cliente in clientes)
            {
                if (cliente.DNI.Equals(dni))
                {

                    Console.WriteLine("1 insertar");
                    Console.WriteLine("2 sacar");
                    Console.WriteLine("3 mirar salario");
                    Console.WriteLine("4 salir");

                    int eleccion = Convert.ToInt32(Console.ReadLine());


                    switch (eleccion)
                    {
                        case 1:
                            int num = Convert.ToInt32(Console.ReadLine());
                            salario_ingresado += num;
                            cliente.ingresar(num);
                            break;
                        case 2:
                            int num2 = Convert.ToInt32(Console.ReadLine());
                            salario_ingresado += num2;
                            cliente.extraer(num2);
                            break;
                        case 3:
                            Console.WriteLine(cliente.comprobar());
                            break;
                        case 4:
                            Console.WriteLine("adios");
                            break;


                    }

                }

            }
        }
    }
}

/*b. Banco: tiene un atributo que será un array de tamaño 3 de objetos de tipo Cliente.
Tendrá un método Operar, que permitirá llamar a los métodos Ingresar y Extraer
de los clientes. Para ello nos solicitará el cliente sobre el DNI sobre el que
queremos operar, la operación a realizar y la cantidad. También banco debe tener
otro método que “al final del día” calcule la cantidad de dinero que hay
depositada.
 */