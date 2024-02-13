
using PruebaBDMAUITODO.Abstration;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBDMAUITODO.MVVM.Model
{

    [Table("Usuario")]
    public class Usuario:TableData
    {


        [Column("name"), Indexed, NotNull]
        public string NombreU { get; set; }

        
        public double Total { get; set; }
        public double Ingreso { get; set; }
        public double Gasto { get; set; }


        




    }
}
