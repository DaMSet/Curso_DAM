using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace U3_E8_Serializacion
{
    public class Banco
    {

        public List<Cliente> Clientes { get; set; }

        private DataTable dataTable;

        public Banco() { }

        public Banco(List<Cliente> clientes) 
        {
        
            this.Clientes = clientes;

        }


        public void añadirCliente(string dni, string nombre,string direccio, int edad, int telefono, int nC) 
        {
            
            this.Clientes.Add(new Cliente(dni,nombre,direccio,edad,telefono,nC));


            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Cliente>));

            using (var stream = new FileStream("Clientes.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(stream, this.Clientes);
            }


        }


        public DataTable  DevolverTablaClientes() 
        {
            dataTable = new DataTable();

            IniciarTabla();

            agregarDatosTabla();

            return dataTable;

        }

        private void IniciarTabla() 
        {

            // Añadir columnas al DataTable
            dataTable.Columns.Add("DNI", typeof(string));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Direccion", typeof(string));
            dataTable.Columns.Add("Edad", typeof(int));
            dataTable.Columns.Add("Telefono", typeof(int));
            dataTable.Columns.Add("Num Cuenta", typeof(int));

        }

        private void agregarDatosTabla() 
        {

            foreach(Cliente cliente in this.Clientes) {

                // Añadir una nueva fila al DataTable con datos de ejemplo
                DataRow newRow = dataTable.NewRow();
                newRow["DNI"] = cliente.DNI;
                newRow["Nombre"] = cliente.Nombre;
                newRow["Direccion"] = cliente.Direccion;
                newRow["Edad"] = cliente.Edad;
                newRow["Telefono"] = cliente.Telefono;
                newRow["Num Cuenta"] = cliente.N_cuenta;

                dataTable.Rows.Add(newRow);

            }
           


        }





    }
}
