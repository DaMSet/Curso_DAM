namespace ListasyDiccionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //LISTA

            List<int> listaEnteros = new List<int>();

            //Añadimos valores

            List<int> listaEnteros2 = new List<int>(){1,2,3,4,5,6,2};

            //Para acceder a ellos

            Console.WriteLine(listaEnteros2[0]);

            //Metodos

            //Añadir el dato especifico

            listaEnteros2.Add(3);

            //Borrar el dato especifico

            listaEnteros2.Remove(3);

            //Insertar en una posicion

            listaEnteros2.Insert(2, 6);

            //Para recorrerlos

            foreach(int i in listaEnteros2){
            
                Console.WriteLine(i);

            }


            //para ordenar

            listaEnteros2.Sort();


            //posicion del numero que pongamos

            Console.WriteLine(listaEnteros2.IndexOf(2));

            //Ultimo indice del numero dado

            Console.WriteLine(listaEnteros2.LastIndexOf(2));


            //nos devuelbe el valor que cumpla una condicion

            listaEnteros2.Find(e => e > 2);

            //busca el ultimo  valor que cumpla una condicion

            listaEnteros2.FindLast(e => e > 2);

            //busca todos los valores que cumpla una condicion

            listaEnteros2.FindLast(e => e > 2);






            //DISCCIONARIOS

            var diccionario = new Dictionary<int, string>() { };

            Dictionary<int , string> dic = new Dictionary<int, string>()
            {
                [0] = "ana",
                [1] = "juan",
                [2] = "pepe",

            };

            dic.Add(3,"antonio");
            dic[5] = "maria";
            dic.Remove(2);


            if (!dic.ContainsKey(5)) {

                dic.Add(5, "jose");

            }

            Console.WriteLine("Separar");

            foreach(int i in dic.Keys) { 
            
                Console.WriteLine(i);

            }

            foreach(var i in dic)
            {

                Console.WriteLine(i);

            }




            //TIPO DATE









        }
    }
}