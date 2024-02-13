using PruebaBDMAUITODO.Abstration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBDMAUITODO.MVVM.Model
{
    public class Transaccion: TableData
    {
        public string NombreT { get; set; }


        public double Cantidad { get; set; }
        public Boolean Ingreso { get; set; }
        public DateTime Fecha { get; set; }

    }
}
