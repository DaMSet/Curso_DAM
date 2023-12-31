﻿namespace T2_E7_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Triangulo tri = new Triangulo();

            Console.WriteLine(tri.Altura);
            Console.WriteLine(tri.Ladodiferente);
            Console.WriteLine(tri.LadosIguales);


            Console.WriteLine(tri.calcularPerimetro());

            Console.WriteLine(tri.calcularArea());
           


        }


    }
}

/*
 Actividad 7. Ejercicios con Clases
NOTA: Debes crear al menos un pequeño programa principal en el que se muestre el uso de las
clases que hayas creado.
1. Crea una clase para trabajar con triángulos isósceles, (dos lados iguales y uno
diferente). Para ello, define las variables (que serán tres: una, la longitud de los lados de
igual tamaño, otra, la longitud del lado diferente, y por último la altura del triángulo).
Construye los métodos necesarios para poder consultar dichas longitudes, el método
constructor e implementa otros métodos para calcular el perímetro y el área de un
triángulo. (Perímetro es igual a la suma de los lados y área es igual a lado desigual por
altura dividido entre dos). También has de realizar las propiedades correspondientes a
cada uno de los atributos.
2. Crea un programa que permita jugar a los dados. Para ello debes crear dos clases:
a. Dado: con atributo valor y métodos Tirar, que generará un aleatorio entre 1 y 6, y
un método Imprimir que mostrará el valor del dado.
b. Juego: con un atributo que será un array de tamaño 3 con objetos de tipo Dado y
un método Jugar, que debe tirar los tres dados, mostrar su valor y decirnos si
hemos perdido o ganado. Las reglas de juego son: se tiran tres dados si los tres
salen con el mismo valor mostrar un mensaje que "gano", sino "perdió".
3. Crea un programa con las siguientes clases:
a. Cliente: esta clase tendrá los siguientes atributos DNI, nombre y cantidad
ahorrada y los métodos Ingresar (aumentará la cantidad ahorrada con el dinero
indicado), Extraer (restará a la cantidad ahorrada lo que se indique) y Consultar
Saldo, que mostrará la cantidad ahorrada en cada momento.
b. Banco: tiene un atributo que será un array de tamaño 3 de objetos de tipo Cliente.
Tendrá un método Operar, que permitirá llamar a los métodos Ingresar y Extraer
de los clientes. Para ello nos solicitará el cliente sobre el DNI sobre el que
queremos operar, la operación a realizar y la cantidad. También banco debe tener
otro método que “al final del día” calcule la cantidad de dinero que hay
depositada.
4. Confeccionar una clase Persona que tenga como atributos el nombre y la edad (definir las
propiedades para poder acceder a dichos atributos). Definir también un método para
imprimir. Plantear una segunda clase Empleado que herede de la clase Persona. Añadir un
atributo sueldo (y su propiedad) y el método para imprimir su sueldo. Definir un objeto de
la clase Persona y llamar a sus métodos y propiedades. También crear un objeto de la
clase Empleado y llamar a sus métodos y propiedades.
 */