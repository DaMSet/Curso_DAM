namespace PilasyColas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Pilas 

            Stack<int> pila = new Stack<int>();

            pila.Push(1); //Meter un dato
            pila.Pop(); //quita y devuelve el objeto de arriba de la pila
            pila.Peek(); // solo muestra el objeto de arriba


            //Colas

            Queue<int> cola = new Queue<int>();

            cola.Enqueue(1); //meter un dato
            cola.Dequeue(); //quita y devuelve el primer objeto de la cola
            cola.Peek(); //devuelve el primer objeto de la cola



        }
    }
}