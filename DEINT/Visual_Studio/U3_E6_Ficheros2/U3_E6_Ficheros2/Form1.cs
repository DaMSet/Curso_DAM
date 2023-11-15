namespace U3_E6_Ficheros2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {


            string rutaDirectorio = textBox1.Text.ToString();


            if (Directory.Exists(rutaDirectorio))
            {
                string[] archivos = Directory.GetFiles(rutaDirectorio);

                if (archivos.Length > 0)
                {

                    foreach (string archivo in archivos)
                    {
                        label1.Text += $"{archivo}\n";

                        // Imprimir el �ltimo archivo utilizado
                        if (!string.IsNullOrEmpty(archivo))
                        {
                            label1.Text += $"�ltimo archivo utilizado: {archivo}";
                        }
                        else
                        {
                            label1.Text += "No se ha utilizado ning�n archivo anteriormente.";
                        }

                      

                    }



                }
                else if (archivos.Length == 0) 
                {
                    label1.Text += "No hay archivos";
                }
        

            }
            else
            {
                label1.Text = "No existe ese directorio";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

/*
 Realiza un programa, que solicita al usuario introducir el nombre de un directorio.
Dicho programa comprobar� si el directorio existe, si no fuese as�, informar� del
error. En caso de que exista, comprobaremos si tiene ficheros dentro, si no fuese
as�, tambi�n se informar� al usuario de este hecho. Si tuviese ficheros, debemos
mostrar el fichero al que se ha accedido m�s recientemente.
 */