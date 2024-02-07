using P10CONTROLGASTOS.Abstration;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P10CONTROLGASTOS.MVVM.Model
{
    [Table("Transacciones")]
    public class Transaccion
    {

        [Column("NombreTransaccion"), Indexed, NotNull]
        public string NNombreTransaccioname { get; set; }

    }
}
