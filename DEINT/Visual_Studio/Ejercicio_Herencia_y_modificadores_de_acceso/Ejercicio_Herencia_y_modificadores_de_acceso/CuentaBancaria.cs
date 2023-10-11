using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia_y_modificadores_de_acceso
{
    internal class CuentaBancaria
    {
        //private string titular;
        //private double Salario;

        public string Titular { get; set; }
        public double Salario { get; set; }

        public CuentaBancaria(string titular)
        {
            this.Titular = titular;
            this.Salario = 10000;


        }

        public virtual void ingresar(double salario)
        {

            this.Salario += salario;

        }

        public virtual void extraer(double dinero)
        {

            this.Salario -= dinero;

        }

        public virtual double comprobar()
        {

            return this.Salario;

        }

        protected void RealizarTransferencia(CuentaBancaria cuenta, double dinero) 
        {
            this.extraer(dinero);
            cuenta.ingresar(dinero);

        }

    }


  

}
