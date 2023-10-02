namespace Ejercicio1_PilasYColas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             
            Todo compilador o intérprete de un lenguaje tiene un módulo dedicado a analizar si una
            expresión está correctamente codificada, es decir que los paréntesis están abiertos y
            cerrados en un orden lógico y bien balanceados.
            Se debe desarrollar un programa que tenga las siguientes responsabilidades:
            - Ingresar una fórmula que contenga paréntesis, corchetes y llaves.
            - Validar que los ( ) [] y {} estén correctamente balanceados.
            Ejemplo de fórmula: (2+[3-12]*{8/3})

             */

            Stack<char> pila = new Stack<char>();

            bool correcto = true;
            string texto = "";
            

            Console.WriteLine("Por favor, ingresa el codigo ");
            texto = Console.ReadLine();

            char[] caracteres = texto.ToCharArray();

         
            for (int i = 0; i < caracteres.Length; i++) 
            {

                if (caracteres[i].Equals("(") || caracteres[i].Equals("[") || caracteres[i].Equals("{"))
                {

                    pila.Push(caracteres[i]);



                } else if (caracteres[i].Equals(")") || caracteres[i].Equals("]") || caracteres[i].Equals("}")) 
                {

                    if (pila.Peek().Equals(caracteres[i]))
                    {
                        pila.Pop();
                    }
                    else 
                    {
                        correcto = false;
                    }
                    

                }


            }


            Console.WriteLine(correcto);

        }
    }
}