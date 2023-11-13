namespace U3_E5_2_Ficheros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string archivo, fraseABuscar, ruta1;

            archivo = txtArchivo.Text;
            fraseABuscar = txtCadena.Text;
            

            //Sacamos la ruta donde se encuentran nuestros archivos en este caso en el mismo dirtectorio que el programa y lo combinamos con el nombre del archivo
            ruta1 = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), $"{archivo}.txt");






            try
            {
                //Leemos con el stream reader
                StreamReader stream = new StreamReader(ruta1);
                if (stream != null)
                {

                    string[] lineas = File.ReadAllLines(ruta1);

                    List<string> lineasCoincidentes = new List<string>();

                    for (int i = 0; i < lineas.Length; i++)
                    {
                        if (lineas[i].Contains(fraseABuscar))
                        {
                            lineasCoincidentes.Add($"Línea {i + 1}: {lineas[i]}");
                        }
                    }


                    if (lineasCoincidentes.Count > 0)
                    {
                        //Console.WriteLine($"Frases en el archivo que contienen '{fraseABuscar}':");
                        foreach (string linea in lineasCoincidentes)
                        {
                            ltFrases.Items.Add(linea);
                            
                        }
                    }
                    else
                    {
                        ltFrases.Items.Add($"No se encontró la frase '{fraseABuscar}' en el archivo.");
                    }

                }

                

            }
            catch (Exception ex)
            {

            }

        }

        private void ltFrases_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

/*
 Un programa que pida al usuario el nombre de un fichero de texto y una frase a
buscar, y que muestre en pantalla todas las frases de ese fichero que contengan
esa frase. Cada frase se debe preceder del numero de linea (la primera linea del
fichero sera la 1, la segunda sera la 2, y así sucesivamente).
 */