using System.Text.RegularExpressions;

namespace Validaciones_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Primera forma por las caracteristicas de los componentes en la parte visual

        private void textBox2_TextChanged(object sender, KeyPressEventArgs e)
        {

            //  Va a permitir introducir un numero o la tecla borrar
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                MessageBox.Show("El caracter no es una cifra");
                e.Handled = true; // Cancela la entrada del caracter no valido

            }

        }

        private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (e.Cancel) { }
            string pattern = @"^[^@\s]+";
            //Regex

        }

        private void button1_Click(object sender, EventArgs e)
        {



            String rutaArchivo = @"E:\Curso_2Dam\a.txt";

            StreamReader sr = new StreamReader(rutaArchivo);

            string linea = "";

            while ((linea = sr.ReadLine()) != null  )
            {

                //Console.WriteLine(sr.ReadToEnd());

                textBox2.Text += linea;
            }

            MessageBox.Show("Funciona");


           


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}