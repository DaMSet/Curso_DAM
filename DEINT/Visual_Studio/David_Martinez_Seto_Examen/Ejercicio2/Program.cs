using System.Text.RegularExpressions;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Empleado> list = new List<Empleado>();
            
            

            list.Add(new Comercial("123456780","Pepe",45,"correo@gmail.44",250));
            list.Add(new Comercial("12345678A", "Pepe", 45, "correo@gmail.com", 250));
            list.Add(new Comercial("12345678S", "Pepe", 45, "correo@gmail.com", 250));
            list.Add(new Comercial("12345678D", "Pepe", 45, "correo@gmail.com", 250));
            list.Add(new Comercial("12345678F", "Pepe", 45, "correo@gmail.com", 250));
            list.Add(new Repartidor("12345678G", "jose", 45, "correo@gmail.com", "zona 2"));
            list.Add(new Repartidor("12345678H", "jojo", 45, "correo@gmail.com","zona 3"));

            
            string num;
            int num1;
            

            string dni, nombre, edad, correo, zona, comision, tipo;

            Console.WriteLine("Cuantos Empleados quiere añadir");
            num = Console.ReadLine();
            //Aqui se realiza el parseo 
            num1 =Convert.ToInt32(num);

            for (int i = 0; i < num1; i++) 
            {

                Console.WriteLine("inserte el dni");
                dni = Console.ReadLine();
                Console.WriteLine("inserte el nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("inserte el edad");
                edad = Console.ReadLine();
                Console.WriteLine("inserte el correo");
                correo = Console.ReadLine();

                Console.WriteLine("que tipo de empleado es , N ,C o R");
                tipo = Console.ReadLine();

                if (tipo.Equals("N")) 
                {
                    list.Add(new Empleado(dni, nombre, Convert.ToInt32(edad), correo));
                }

                if (tipo.Equals("C")) 
                { comision = Console.ReadLine();

                    list.Add(new Comercial(dni, nombre, Convert.ToInt32(edad), correo, Convert.ToInt32(comision)));

                }


                if (tipo.Equals("R")) 
                { zona = Console.ReadLine();

                    list.Add(new Repartidor(dni, nombre, Convert.ToInt32(edad), correo, zona));

                }



            }



            Empleado EmpleadoMenorSueldo() 
            {
                List<Empleado> lista = new List<Empleado>();

                
                return lista[0];
            }

            Empleado CantidadEmp50mas()
            {
                

                return list[0];
            }

            List<Empleado> EmpleadosPorZonas()
            {
                List<Empleado> lista = new List<Empleado>();


                return lista;
            }


            List<Empleado> EmpleadosMayorMenorSueldo()
            {
                List<Empleado> lista = new List<Empleado>();

               


                return lista;
            }


        }
    }
}