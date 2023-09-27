namespace Punto_De_Silla
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            
            Realiza una aplicación de consola que implemente una clase matriz cuyos
            atributos serán número de filas y número de columnas, ambos enteros.
            Además tendrá que contener los métodos necesarios para que la aplicación
            haga lo siguiente:
            a) Se solicitará al usuario las dimensiones para construir la matriz de
            valores enteros.
            b) Se solicitarán también al usuario los valores de dicha matriz.
            c) También deberá tener un método capaz de calcular el Punto de
            Silla.
            Se dice que una matriz tiene un punto de silla si alguna posición de la
            matriz es el menor valor de su fila y a la vez el mayor de su columna.
            Dicho método nos devolverá este valor, si existe, junto con la posición que
            ocupa en la matriz, y si no mostrará un mensaje informando de este
            hecho.
            Has de realizar control de entrada, de manera que si el usuario introduce
            algún elemento que no sea entero, se le informe y se le permita introducirlo
            de nuevo.

             */

            bool salir = true;

            while (salir)
            {


                int[,] matriz;

                Console.WriteLine("Por favor, ingresa el tamaño de la matriz num1");

                string texto = Console.ReadLine();

                int num1 = Convert.ToInt32(texto);

                Console.WriteLine("Por favor, ingresa el tamaño de la matriz num2");

                texto = Console.ReadLine();

                int num2 = Convert.ToInt32(texto);


                matriz = new int[num1, num2];


                for (int i = 0; i < num1; i++)
                {

                    for (int j = 0; j < num2; j++) {

                        bool continuar = false;

                        while (!continuar) 
                        {

                            Console.WriteLine("Por favor, ingresa el numero ");
                            texto = Console.ReadLine();
                            if (int.TryParse(texto, out int num3)) continuar = true;
                            matriz[i, j] = num3;

                            


                        }

                       


                         

                    } 

                }

                bool valor;
                int valorPS = 0;



                for (int i = 0; i < num1; i++)
                {


                    for (int j = 0; j < num2; j++)
                    {
                        valor = EsPuntoDeSilla(matriz,i,j);

                        if (valor) 
                        {
                            valorPS = matriz[i, j];

                            Console.WriteLine("El valor "+valorPS+ "Es un punto de silla en "+i+" "+j);
                        }
                        

                    }
                    
                }




                    for (int i = 0; i < num1; i++) {

                    for (int j = 0; j < num2; j++)
                    {
                        Console.Write(matriz[i, j]+",");
                    }
                    Console.WriteLine();
                }


                Console.WriteLine("quieres salir?");
                texto = Console.ReadLine();

                if (texto == "y" || texto == "Y")
                {
                    salir = false;
                }

            }



            static bool EsPuntoDeSilla(int[,] matriz, int fila, int columna)
            {

                int valor = matriz[fila, columna];
                int filas = matriz.GetLength(0);
                int columnas = matriz.GetLength(1);


                for (int i = 0; i < filas; i++)
                {
                    if (matriz[i, columna] > valor)
                    {
                        return false;
                    }
                }

                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[fila, j] < valor)
                    {
                        return false;
                    }
                }



                return true;

            }


        }
    }
}