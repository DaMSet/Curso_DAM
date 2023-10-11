using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia_y_modificadores_de_acceso
{
    internal class CuentaEmpresarial : CuentaBancaria
    {
        public CuentaEmpresarial(string titular) : base(titular)

        {
        }

        public void RealizarTransferencia(CuentaBancaria cuenta, double dinero) 
        {
        
            base.RealizarTransferencia (cuenta, dinero);

        }

    }
}
