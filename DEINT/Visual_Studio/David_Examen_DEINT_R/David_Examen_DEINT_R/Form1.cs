using David_Examen_DEINT_R.Clases;
using David_Examen_DEINT_R.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace David_Examen_DEINT_R
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Crear crear = new Crear();

            crear.ShowDialog();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            Leer leer = new Leer();

            leer.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Borrar borrar = new Borrar();

            borrar.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar actualizar = new Actualizar();

            actualizar.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Guardamos la informacion de los libros en una array biblioteca
            DataSet ds =  LibroDLL.getInstance().getlibro();

            List<Libro> list = new List<Libro>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
               
                String isbn = row["isbn"].ToString();
                String titulo = row["titulo"].ToString();
                String autor = row["autor"].ToString();
                String genero = row["genero"].ToString();
                String año = row["año_publicacion"].ToString();
                String cod_Ed = row["cod_editorial"].ToString();

                
                Libro libro = new Libro(int.Parse(isbn),titulo,autor,int.Parse(año), int.Parse(cod_Ed), genero);
                list.Add(libro);
            }

            // Serializar objeto a XML
            XmlSerializer serializer = new XmlSerializer(typeof(List<Libro>));
            TextWriter writer = new StreamWriter(@"C:\Users\dam\Desktop\DatosListaLibros.xml");
            serializer.Serialize(writer,list);
            writer.Close();


            //accedemos a la informacion de los libros en una array biblioteca sacada de un xml


            
            // Deserializar XML a objeto
            XmlSerializer serializer2 = new XmlSerializer(typeof(List<Libro>));
            TextReader reader = new StreamReader(@"C:\Users\dam\Desktop\DatosListaLibros.xml");
            List<Libro> biblioteca = (List<Libro>)serializer2.Deserialize(reader);

            reader.Close();
            

            



        }

        private void btnLibroPorGenero_Click(object sender, EventArgs e)
        {
            ConsultaLibrosPorGeneros lpg = new ConsultaLibrosPorGeneros();

            lpg.ShowDialog();

        }

        private void btnLibroPorEditorial_Click(object sender, EventArgs e)
        {
            ConsultaLibrosEditorial lpe = new ConsultaLibrosEditorial();

            lpe.ShowDialog();

        }
    }
}
