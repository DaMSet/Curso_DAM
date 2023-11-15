namespace U3_E5_5_Ficheros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string inputFile1 = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), $"{txtArchivo1.Text.ToString()}.txt");
            string inputFile2 = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), $"{txtArchivo2.Text.ToString()}.txt");
            string outputFile = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), "union.txt");

            try
            {
                CombineFiles(inputFile1, inputFile2, outputFile);
                Console.WriteLine("La combinaci�n de archivos se ha realizado con �xito. El resultado se encuentra en 'union.txt'");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void CombineFiles(string inputFile1, string inputFile2, string outputFile)
        {
            using (StreamReader reader1 = new StreamReader(inputFile1))
            using (StreamReader reader2 = new StreamReader(inputFile2))
            using (StreamWriter writer = new StreamWriter(outputFile,true))
            {
                while (!reader1.EndOfStream || !reader2.EndOfStream)
                {
                    if (!reader1.EndOfStream)
                    {
                        string line1 = reader1.ReadLine();
                        writer.WriteLine(line1);
                    }

                    if (!reader2.EndOfStream)
                    {
                        string line2 = reader2.ReadLine();
                        writer.WriteLine(line2);
                    }
                }
            }

        }


    }
}
/*
 Realizar un programa que permita la combinaci�n de dos ficheros de texto, cuyo
nombre se pasa en la l�nea de comandos. Dicho programa crear� un tercer fichero
llamado union.txt en el que iremos mezclando las l�neas de los ficheros anteriores.
Es decir escribiremos una l�nea del fichero1 y a continuaci�n una l�nea del fichero2.
Si alguno de los ficheros tiene mayor contenido, se escribir�n todas las l�neas que
queden seguidas
 */