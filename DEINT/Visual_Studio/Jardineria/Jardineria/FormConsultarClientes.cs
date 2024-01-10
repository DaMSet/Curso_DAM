using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jardineria
{
    public partial class FormConsultarClientes : Form
    {
        Servicio.Servicio servicio;
        public FormConsultarClientes()
        {
            InitializeComponent();

            servicio = Servicio.Servicio.getInstace();
        }

        private void FormConsultarClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = servicio.getClientes().Tables[0];

            /*
            List<int> codigoCliente = servicio.GetListaCodigoClientes();
            List<String> nombreCliente = servicio.GetListaNombreCliente();
            List<String> nombreContacto = servicio.GetListaNombreContacto();
            List<String> apellidoContacto = servicio.GetListaApellidoContacto();
            List<String> telefono = servicio.GetListaTelefono();
            List<String> fax = servicio.GetListaFax();
            List<String> lineaDireccion1 = servicio.GetListaLineaDireccion1();
            List<String> lineaDireccion2 = servicio.GetListaLineaDireccion2();
            List<String> ciudad = servicio.GetListaCiudad();
            List<String> region = servicio.GetListaRegion();
            List<String> pais = servicio.GetListaPais();
            List<String> codigoPostal = servicio.GetListaCodigoPostal();
            List<int> codigoEmpleado = servicio.GetListaCodigoEmpleado();
            List<double> limiteCredito = servicio.GetListaLimiteCredito();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Codigo Cliente", typeof(int));
            dataTable.Columns.Add("Nombre Cliente", typeof(String));
            dataTable.Columns.Add("Nombre Contacto", typeof(String));
            dataTable.Columns.Add("Apellido Contacto", typeof(String));
            dataTable.Columns.Add("Telefono", typeof(String));
            dataTable.Columns.Add("Fax", typeof(String));
            dataTable.Columns.Add("Linea Direccion 1", typeof(String));
            dataTable.Columns.Add("Linea Direecion 2", typeof(String));
            dataTable.Columns.Add("Ciudad", typeof(String));
            dataTable.Columns.Add("Region", typeof(String));
            dataTable.Columns.Add("Pais", typeof(String));
            dataTable.Columns.Add("Codigo Postal", typeof(String));
            dataTable.Columns.Add("Codigo Empleado", typeof(int));
            dataTable.Columns.Add("Limite Credito", typeof(double));

            for (int i = 0; i < codigoCliente.Count; i++)
            {
                dataTable.Rows.Add(codigoCliente[i], nombreCliente[i], nombreContacto[i], apellidoContacto[i], telefono[i], fax[i], lineaDireccion1[i], lineaDireccion2[i], ciudad[i], region[i], pais[i], codigoPostal[i], codigoEmpleado[i], limiteCredito[i]);
            }

            dataGridView1.DataSource = dataTable;
            */
        }
    }
}
