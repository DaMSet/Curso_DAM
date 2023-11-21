using System.Xml.Serialization;

namespace U3_E8_Serializacion
{
    public partial class Form1 : Form
    {
        Banco banco = new Banco();
        public Form1()
        {
            InitializeComponent();

            List<Cliente> clientes = new List<Cliente>();

            banco = new Banco(clientes);

        }



        private void btnAñadir_Click(object sender, EventArgs e)
        {
            //Cliente cliente = new Cliente(txtDNI.Text,txtNombre.Text,txtDireccion.Text,int.Parse(txtEdad.Text), int.Parse(txtTelefono.Text), int.Parse(txtNC.Text));

            banco.añadirCliente(txtDNI.Text, txtNombre.Text, txtDireccion.Text, int.Parse(txtEdad.Text), int.Parse(txtTelefono.Text), int.Parse(txtNC.Text));
            
        
        }

        

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            dtgbanco.DataSource = banco.DevolverTablaClientes();

        }
    }
}