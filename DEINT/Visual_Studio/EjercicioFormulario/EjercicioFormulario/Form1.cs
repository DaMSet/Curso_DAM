namespace EjercicioFormulario
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

            txtResultado.AppendText(contar().ToString() + "\t");

        }


        private int contar()
        {
            int cont = 0;

            for (int i = 0; i < txtDato.TextLength; i++)
            {

                if (txtDato.Text[i].ToString().Equals(cmbLetra.SelectedItem.ToString())) { cont++; }

            }

            return cont;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.ResetText();
        }
    }
}