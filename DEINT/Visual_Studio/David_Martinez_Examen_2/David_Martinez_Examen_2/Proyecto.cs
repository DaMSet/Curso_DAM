using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace David_Martinez_Examen_2
{
    internal class Proyecto
    {

       


        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }

        public List<Tareas> Tareas { get; set; }
        
        public Proyecto(string nombre, string descripcion, DateTime fecha , List<Tareas> tareas)
        {
        
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Fecha = fecha;
            this.Tareas = tareas;

        }


        public void crearXML_proyecto() 
        {
            // Serializar objeto a XML
            XmlSerializer serializer = new XmlSerializer(typeof(Proyecto));
            TextWriter writer = new StreamWriter(this.Nombre+".xml");
           //XmlSerializer.Serialize(writer,new Proyecto(this.Nombre,this.Descripcion,this.Fecha,this.Tareas));
            

            writer.Close();

        }


        /*
          // Serializar objeto a XML
            XmlSerializer serializer = new XmlSerializer(typeof(Proyecto));
            TextWriter writer = new StreamWriter("ruta\\archivo.xml");
            Serializer.Serialize(writer, objeto);
            writer.Close();

            // Deserializar XML a objeto
            XmlSerializer serializer = new XmlSerializer(typeof(Proyecto));
            TextReader reader = new StreamReader("ruta\\archivo.xml");
            TipoDeObjeto objeto = (TipoDeObjeto)serializer.Deserialize(reader);
            reader.Close();*/



    }

   
}
