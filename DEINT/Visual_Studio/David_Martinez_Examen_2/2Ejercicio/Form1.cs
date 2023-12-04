namespace _2Ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarRecurso_Click(object sender, EventArgs e)
        {
            AgregarMantenimiento agregarMantenimiento = new AgregarMantenimiento();

            agregarMantenimiento.Show();
        }

        private void btnModificarRecurso_Click(object sender, EventArgs e)
        {
            ModificarEstadoRecursos modificarEstadoRecursos = new ModificarEstadoRecursos();
            modificarEstadoRecursos.Show();
        }

        private void btnVerRecursos_Click(object sender, EventArgs e)
        {
            VisualizarRecursos visualizarRecursos = new VisualizarRecursos();
            visualizarRecursos.Show();
        }

        private void btnVerMantenimiento_Click(object sender, EventArgs e)
        {
            VisualizarMantenimiento visualizarMantenimiento = new VisualizarMantenimiento();
            visualizarMantenimiento.Show();
        }

        private void btnAgregarMantenimiento_Click(object sender, EventArgs e)
        {
            AgregarMantenimiento agregarMantenimiento = new AgregarMantenimiento();
            agregarMantenimiento.Show();
        }
    }
}