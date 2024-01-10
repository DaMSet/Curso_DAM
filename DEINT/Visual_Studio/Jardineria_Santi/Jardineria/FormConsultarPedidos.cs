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
    public partial class FormConsultarPedidos : Form
    {
        private Servicio.Servicio servicio;
        private Dictionary<int, String> mesesDiccionario;
        private bool iniciado = false;
        public FormConsultarPedidos()
        {
            InitializeComponent();

            servicio = Servicio.Servicio.getInstace();
        }

        private void FormConsultarPedidos_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;

            mesesDiccionario = new Dictionary<int, String>();

            for (int i = 0; i < 12; i++)
            {
                DateTime mes = fecha.AddMonths(i);
                mesesDiccionario.Add(i, mes.ToString("MMMM"));
            }

            foreach (var kvp in mesesDiccionario)
            {
                int clave = kvp.Key;
                String valor = kvp.Value;

                cmBoxMes.Items.Add(valor);
            }

            iniciado = true;
        }

        private void cmBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (iniciado)
            {
                String nombreMes = cmBoxMes.SelectedItem.ToString();

                int numMes = 0;

                foreach (var kvp in mesesDiccionario)
                {
                    int clave = kvp.Key;
                    String valor = kvp.Value;

                    if (valor.Equals(nombreMes))
                    {
                        numMes = clave;
                    }
                }

                List<int> codigoPedido = servicio.GetListaCodigoPedido(numMes);
                List<DateTime> fechaPedido = servicio.GetListaFechaPedido(numMes);
                List<DateTime> fechaEspera = servicio.GetListaFechaEspera(numMes);
                List<DateTime> fechaEntrega = servicio.GetListaFechaEntrega(numMes);
                List<String> estado = servicio.GetListaEstado(numMes);
                List<String> comentarios = servicio.GetListaComentario(numMes);
                List<int> codigoCliente = servicio.GetListaCodigoCliente(numMes);

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("CodigoPedido", typeof(int));
                dataTable.Columns.Add("FechaPedido", typeof(DateTime));
                dataTable.Columns.Add("FechaEspera", typeof(DateTime));
                dataTable.Columns.Add("FechaEntrega", typeof(DateTime));
                dataTable.Columns.Add("Estado", typeof(string));
                dataTable.Columns.Add("Comentarios", typeof(string));
                dataTable.Columns.Add("CodigoCliente", typeof(int));

                for (int i = 0; i < codigoPedido.Count; i++)
                {
                    if (estado[i].Equals("Entregado"))
                    {
                        dataTable.Rows.Add(
                            codigoPedido[i],
                            fechaPedido[i],
                            fechaEspera[i],
                            fechaEntrega[i],
                            estado[i],
                            comentarios[i],
                            codigoCliente[i]
                        );
                    }

                }

                dataGridView1.DataSource = dataTable;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
