namespace U3_E10_Jardinería_Repaso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            
            Form añadir = new Añadir();

            añadir.ShowDialog();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            Form borrar = new Borrar();

            borrar.ShowDialog();

        }

        private void btnPedidosEntregados_Click(object sender, EventArgs e)
        {
            Form pedidosEntregados = new PedidosEntregados();

            pedidosEntregados.ShowDialog();
        }

        private void btnEmpleadosJefe_Click(object sender, EventArgs e)
        {
            Form empleadosJefe = new EmpleadosJefe();

            empleadosJefe.ShowDialog();
        }

        private void btnClienteNoPaga_Click(object sender, EventArgs e)
        {
            Form clientesNoPagan = new ClientesNoPagan();

            clientesNoPagan.ShowDialog();
        }

        private void btnPrecioCaroBarato_Click(object sender, EventArgs e)
        {
            Form precioCaroBarato = new PrecioCaroBarato();

            precioCaroBarato.ShowDialog();
        }
    }
}