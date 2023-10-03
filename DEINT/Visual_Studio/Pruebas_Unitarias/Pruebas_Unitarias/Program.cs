namespace Pruebas_Unitarias
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }

        public static bool stringDiferente(string[] vs, string[] vs2)
        {
            string conjuntoString = "" ,conjuntoString2 = "";
            

            foreach (string v in vs)
            {

                conjuntoString += v;

            }

            foreach (string v in vs2)
            {

                conjuntoString2 += v;

            }

            


            return conjuntoString.Equals(conjuntoString2);
        }
    }
}