
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
    [Table("Usuarios")]
    public class Usuario:TableData
    {
        [Column("name"), Indexed, NotNull]
        public string Name { get; set; }

        [Unique]
        public string Phone { get; set; }

        [MaxLength(100)]
        public int Age { get; set; }
        public string Address { get; set; }


        //Relacion 1 a N
        [OneToMany(CascadeOperations = CascadeOperation.CascadeInsert | CascadeOperation.CascadeRead | CascadeOperation.CascadeDelete)]
        public List<Transaccion> transacciones { get; set; }

    }
}
