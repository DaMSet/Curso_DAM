using System.IO;

namespace U3_E5_Ficheros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string archivo1,archivo2,ruta1,ruta2,s = "";

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
                        s += stream.ReadLine();
                    }

                    //btnPasarContenido.Text = s;
                }

                //Editamos con el strem writer 
                StreamWriter streamW = new StreamWriter(ruta2,true);

                streamW.WriteLine(s);

                streamW.Close();
                streamW.Dispose();

            }
            catch (Exception ex) 
            {
            
            }
            

            
            
            

        }
    }
}

/*
 Un programa que vuelque todo el contenido de un fichero de texto a otro. Los
nombres de ambos ficheros se deben indican como parámetros en la línea de
comandos.

 */