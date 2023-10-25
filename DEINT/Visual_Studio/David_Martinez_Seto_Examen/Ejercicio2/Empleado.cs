using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Empleado:interfaz
    {
        private string DNI;
        private string Nombre;
        private int Edad;
        private string Correo;
        private double Salario;

        const double Plus = 300; 

        public string dni{ get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string correo { get; set; }
        public double salario { get; set; }


        public Empleado(string dni, string nombre, int edad, string correo) 
        {
            try {
                if (Regex.IsMatch(dni, @"^\d{8}\w$")) { this.DNI = dni; }
                
                if (Regex.IsMatch(correo, @"^[\d\w]+@\w+.\w$")) { this.Correo = correo; };
            }
            catch (Exception e)
            { Console.WriteLine("Error de dni o correo"+ e); } //Aqui se mostraria el error personalizado 
            finally 
            {

                this.Nombre = nombre;
                this.Edad = edad;
                this.Salario = 0;

            }
            

        }

        public void ActualizarSalario() 
        {
        
            this.Salario += Plus;

        }

        public void ActualizarSalario(double salario)
        {

            this.Salario += salario;

        }

        public override string ToString()
        {
            return $"Dni :{DNI} Nombre: {Nombre} Edad: {Edad} Correo: {Correo} Salario: {Salario}";
        }

        public virtual void plus()
        {
            throw new NotImplementedException();
        }
    }
}
