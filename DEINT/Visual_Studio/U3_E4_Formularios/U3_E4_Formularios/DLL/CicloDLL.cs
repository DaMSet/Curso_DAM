using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_E4_Formularios.DLL
{
    internal class CicloDLL
    {
        Conexion conexion;

        public CicloDLL() 
        {
        
            conexion = new Conexion();

        }

        public bool Agregar(string nombreCiclo) 
        {
        
            return conexion.EjecutarComandoSinRetornarDatos("Insert into Ciclo(nombre) values('" + nombreCiclo + "')");

        }

        public DataSet MostrarCiclos() 
        {
            SqlCommand sentencia = new SqlCommand("Select * from ciclo");
            return conexion.EjecutarSentencia(sentencia);

        }

    }
}
