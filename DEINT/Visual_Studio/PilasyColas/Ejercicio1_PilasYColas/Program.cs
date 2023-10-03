using System.ComponentModel.DataAnnotations;

namespace Ejercicio1_PilasYColas
{
    public class Program
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
          /*
            Stack<char> pila = new Stack<char>();

            bool correcto = true;
            string texto = "";
            

            Console.WriteLine("Por favor, ingresa el codigo ");
            texto = Console.ReadLine();

            char[] caracteres = texto.ToCharArray();

         
            for (int i = 0; i < caracteres.Length; i++) 
            {

                Console.WriteLine(caracteres[i]);

                if (caracteres[i].Equals('(') || caracteres[i].Equals('[') || caracteres[i].Equals('{'))
                {

                    pila.Push(caracteres[i]);



                } 
                else if (caracteres[i].Equals(')') || caracteres[i].Equals(']') || caracteres[i].Equals('}')) 
                {

                    if (caracteres[i].Equals(')'))
                    {
                        if (pila.Peek().Equals('(')) { pila.Pop(); }
                    }
                    
                    if (caracteres[i].Equals(']'))
                    {
                        if (pila.Peek().Equals('[')) { pila.Pop(); }
                    }
                    
                    if (caracteres[i].Equals('}'))
                    {
                        if (pila.Peek().Equals('{')) { pila.Pop(); }
                    }

                    
                    else { correcto = false; break; }
                    
                    

                }


            }


            Console.WriteLine(correcto);
        */
        }




        public static bool comprobarFormula(string cadena) 
        {
            Stack<char> pila = new Stack<char>();
            char[] caracteres = cadena.ToCharArray();


            foreach (char caracter in caracteres) 
            {

                if (caracter.Equals('(') || caracter.Equals('[') || caracter.Equals('{'))
                {

                    pila.Push(caracter);

                }
                else if(caracter.Equals(')') || caracter.Equals(']') || caracter.Equals('}'))
                {

                    if (Corresponden(pila.Peek(), caracter))
                    {

                        pila.Pop();

                    }
                    else
                    { 
                    
                        return false;

                    }


                }

            }

            return true;

        }


        static bool Corresponden(char apertura, char cierre)
        {
            return (apertura == '(' && cierre == ')') ||
                   (apertura == '[' && cierre == ']') ||
                   (apertura == '{' && cierre == '}');
        }

    }
}

