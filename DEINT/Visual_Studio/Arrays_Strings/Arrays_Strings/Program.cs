namespace Arrays_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");

            //indicamos el tipo

            int[] array = new int[10];

            int[] array2 = new int[] { 1,2,3,4,5,6,7,8};

            int[,] matriz = new int[3,4]; //tamaño del primero y del segundo

            matriz[0, 0] = 0;


            for (int i = 0; i < matriz.Length; i++)
            {

                for (int j = 0; j < matriz.Length; j++)
                {
                    Console.Write(array[i]);
                }    

            }


            array[^1] = 0; //Esto es la ultima


            array[..3];

        }
    }
}