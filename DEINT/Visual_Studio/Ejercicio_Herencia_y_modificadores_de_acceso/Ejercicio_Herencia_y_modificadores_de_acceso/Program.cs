namespace Ejercicio_Herencia_y_modificadores_de_acceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CuentaBancaria cuenta1 = new CuentaBancaria("pepe");
            CuentaEmpresarial cuenta2 = new CuentaEmpresarial("jojo");
            /*
            cuenta1.ingresar(100);
            cuenta2.ingresar(100);

            cuenta2.RealizarTransferencia(cuenta1,10);

            Console.WriteLine(cuenta1.comprobar());
            Console.WriteLine("----");
            Console.WriteLine(cuenta2.comprobar());
            */

            Console.WriteLine(cuenta1.comprobar());
            Console.WriteLine(cuenta2.comprobar());

            cuenta2.RealizarTransferencia(cuenta1, 10);

            Console.WriteLine(cuenta1.comprobar());
            Console.WriteLine(cuenta2.comprobar());


           

        }
    }
}

/*
 Gestión de Cuentas Bancarias


Crea una jerarquía de clases para gestionar cuentas bancarias. La clase base es "CuentaBancaria", 
que tiene un titular y un saldo. Implementa métodos para mostrar el saldo, realizar depósitos y retiradas. 
La clase base debe tener un método protegido llamado "RealizarTransferencia" que permita transferir fondos de una cuenta a otra.


Luego, crea una clase derivada llamada "CuentaEmpresarial", que hereda de "CuentaBancaria". 
Esta clase adicionalmente puede realizar transferencias de fondos a otras cuentas, incluso 
de otras instancias de "CuentaBancaria".


Finalmente, en el programa principal, crea instancias de "CuentaBancaria" y "CuentaEmpresarial",
realiza algunas transacciones y muestra los saldos actualizados después de cada operación.


Asegúrate de utilizar los modificadores de acceso public, private, protected, y internal 
según sea necesario para mantener la encapsulación y la seguridad en la manipulación de datos.


Ten en cuenta que las transferencias desde una cuenta empresarial deben utilizar el método
protegido de la clase base, y las demás operaciones deben ser realizadas a través de los métodos públicos proporcionados.
 */