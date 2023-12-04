namespace David_Martinez_Examen_2
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

        private void btnNuevoProyecto_Click(object sender, EventArgs e)
        {
            CrearProyecto crearProyecto = new CrearProyecto();

            crearProyecto.Show();
        }

        private void btnVerProyecto_Click(object sender, EventArgs e)
        {

        }
    }
}




