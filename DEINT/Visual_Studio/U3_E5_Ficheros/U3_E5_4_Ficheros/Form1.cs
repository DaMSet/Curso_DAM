using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace U3_E5_4_Ficheros
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


            string archivo1, ruta1, ruta2, s = "", nombre;

            double nota, notaMedia = 0, notaMaxima = -1;

            archivo1 = "notas";


            //Sacamos la ruta donde se encuentran nuestros archivos en este caso en el mismo dirtectorio que el programa y lo combinamos con el nombre del archivo
            ruta1 = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), $"{archivo1}.txt");

            ruta2 = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), $"solucion.txt");



            try
            {
                //Leemos con el stream reader
                StreamReader stream = new StreamReader(ruta1);

                if (stream != null)
                {

                    string[] lineas = File.ReadAllLines(ruta1);



                    // Palabra clave a buscar
                    string palabraClave1 = "Matematicas:";
                    string palabraClave2 = "Informatica:";

                    // Patrón de expresión regular para buscar la palabra clave seguida de un número del 0 al 10
                    string patronMates = $"{palabraClave1}\\s+((10)|[0-9])";
                    string patronInfor = $"{palabraClave2}\\s+((10)|[0-9])";

                    



                    for (int i = 0; i < lineas.Length; i++)
                    {
                        Match match1 = Regex.Match(lineas[i], patronMates, RegexOptions.IgnoreCase);
                        Match match2 = Regex.Match(lineas[i], patronInfor, RegexOptions.IgnoreCase);

                        if (match1.Success) 
                        {
                            string numeroString = match1.Groups[1].Value;

                            if (double.TryParse(numeroString, out double numero))
                            {
                                notaMedia += numero;
                            }


                        }

                        if (match2.Success)
                        {
                            string numeroString = match2.Groups[1].Value;


                            if (double.TryParse(numeroString, out double numero))
                            {

                                if (notaMaxima == -1)
                                {
                                    notaMaxima = numero;
                                }
                                else if (notaMaxima <numero) 
                                {
                                    notaMaxima = numero;
                                }

                            }


                        }



                    }

                    notaMedia = notaMedia / (lineas.Length-1);
                }
                

                //Editamos con el strem writer 
                StreamWriter streamW = new StreamWriter(ruta2, true);

                streamW.WriteLine($"La nota media de mates es {notaMedia} y la nota maxima de informatica es {notaMaxima}");

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
 . Se tiene un fichero tipo texto conteniendo en cada línea el nombre y las
calificaciones en matemáticas e informática de uno de los alumnos de un grupo.
Escribir un programa que a partir de dichos datos escriba en otro fichero la nota
media del grupo en matemáticas y la mejor nota en informática así como el nombre
del alumno que la obtuvo.
 */