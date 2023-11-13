namespace U3_E5_3_Ficheros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string archivo1, archivo2, ruta1, ruta2, s = "";

            archivo1 = txtArchivo1.Text;
            archivo2 = txtArchivo2.Text;

            //Sacamos la ruta donde se encuentran nuestros archivos en este caso en el mismo dirtectorio que el programa y lo combinamos con el nombre del archivo
            ruta1 = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), $"{archivo1}.txt");


            ruta2 = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), $"{archivo2}.txt");



            try
            {
                //Leemos con el stream reader
                StreamReader stream = new StreamReader(ruta1);
                if (stream != null)
                {
                    while (!stream.EndOfStream)
                    {
                        s += stream.ReadLine()+"\n";
                    }

                    //btnPasarContenido.Text = s;
                }

                //Editamos con el strem writer 
                StreamWriter streamW = new StreamWriter(ruta2, true);

                streamW.WriteLine(s);

                streamW.Close();
                streamW.Dispose();

            }
            catch (Exception ex)
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

/*
 Un programa que duplique un fichero, copiando todo su contenido a un nuevo
fichero. El nombre de ambos ficheros se debe leer de la línea de comandos.
 */