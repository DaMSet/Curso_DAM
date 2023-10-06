using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Coche
    {

        internal string _marca;
        int _año;
        string _modelo;


        internal string Modelo 
        {
        get { return _modelo.ToUpper(); }

        set { _modelo = value; }
        }

        //prop
        public string Marca { get; set; }
        internal int Año { get; set; } //Si el dato no se va a tratar no se necesita poner mas que esto

        internal int año2 { get; set; } = 1999; //para asignarle una por defecto

        internal int Velocidad { get; private set; } = 20; // 

        internal string NombreComercial => $"{Modelo} ({Año})";

        int VelocidadMaxima = 120;

        internal void Acelerar() 
        {
            Acelerar(1);
        }

        internal void Acelerar(int incremento) 
        {
            if (Velocidad >= VelocidadMaxima)
            {
                Console.WriteLine("Velocidad maxima ");
                return;
            }
            else if (Velocidad + incremento > VelocidadMaxima) 
            {
                incremento = VelocidadMaxima - Velocidad;
            }

            Velocidad += incremento;

        }


        internal void Detener() => Velocidad = 0;




        //Constructor ctor TAB TAB
        //por defecto sin parametros
        //tiene el mismo nombre de la clase
        //no devuelve nada 



        internal Coche() : this("marca por defecto")
        {
            Console.WriteLine("instancia un coche");
        }


        internal Coche(string marca) 
        {
            Console.WriteLine();
            Marca = marca;
        }

    }
}
