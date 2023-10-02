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

        }
    }
}

/*
 LEER

Para realizar este ejercicio, puedes seguir los siguientes pasos:

Ingreso de la fórmula: Primero, solicita al usuario que ingrese una fórmula que contenga paréntesis, 
corchetes y llaves. Por ejemplo, el usuario podría ingresar "(2+[3-12]*{8/3})".

Validación de los paréntesis, corchetes y llaves: A continuación, debes verificar si estos caracteres 
están balanceados correctamente. Para hacerlo, puedes utilizar una pila (stack) para realizar un seguimiento 
de los caracteres de apertura mientras recorres la fórmula.

Recorrido de la fórmula: Recorre cada carácter de la fórmula uno por uno.

Si es un carácter de apertura: Si el carácter es uno de los caracteres de apertura (paréntesis, corchete o llave), agrégalo a la pila.

Si es un carácter de cierre: Si el carácter es uno de los caracteres de cierre, verifica si la pila está vacía.
Si está vacía, significa que no hay un carácter de apertura correspondiente y la fórmula no está balanceada correctamente. 
Si la pila no está vacía, saca el último carácter de la pila y verifica si coincide con el carácter de cierre actual. 
Si no coinciden, la fórmula no está balanceada correctamente.

Al final del recorrido: Después de recorrer toda la fórmula, verifica si la pila está vacía. Si está vacía, significa 
que todos los caracteres de apertura tienen sus correspondientes caracteres de cierre y la fórmula está balanceada correctamente.

Aquí tienes un ejemplo de código en C# que implementa este proceso:

csharp
Copy code
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Por favor, ingresa una fórmula:");
        string formula = Console.ReadLine();

        if (EstaBalanceada(formula))
        {
            Console.WriteLine("La fórmula está balanceada correctamente.");
        }
        else
        {
            Console.WriteLine("La fórmula no está balanceada correctamente.");
        }
    }

    static bool EstaBalanceada(string formula)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char caracter in formula)
        {
            if (EsCaracterDeApertura(caracter))
            {
                pila.Push(caracter);
            }
            else if (EsCaracterDeCierre(caracter))
            {
                if (pila.Count == 0 || !Corresponden(pila.Pop(), caracter))
                {
                    return false;
                }
            }
        }

        return pila.Count == 0;
    }

    static bool EsCaracterDeApertura(char c)
    {
        return c == '(' || c == '[' || c == '{';
    }

    static bool EsCaracterDeCierre(char c)
    {
        return c == ')' || c == ']' || c == '}';
    }

    static bool Corresponden(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '[' && cierre == ']') ||
               (apertura == '{' && cierre == '}');
    }
}
Este código solicitará al usuario que ingrese una fórmula y luego verificará si los paréntesis, corchetes y llaves están balanceados correctamente. Si lo están, mostrará un mensaje de que la fórmula es válida; de lo contrario, mostrará un mensaje de que no es válida.

 */