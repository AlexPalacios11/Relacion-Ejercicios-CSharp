namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("María", 20, "123456789");
            Persona persona2 = new Persona("Pedro", 40, "987654321");

            Cuenta cuenta1 = new Cuenta(persona2);
            CuentaJoven cuenta2 = new CuentaJoven(10,persona1);
            CuentaJoven cuenta3 = new CuentaJoven(10,persona2);

            cuenta1.Ingresar(100);
            cuenta2.Ingresar(100);
            cuenta3.Ingresar(100);

            cuenta1.Retirar(50);
            cuenta2.Retirar(50);
            cuenta3.Retirar(50);

            Console.WriteLine(persona1);
            Console.WriteLine();
            Console.WriteLine(persona2);
            Console.WriteLine();
            Console.WriteLine(cuenta1);
            Console.WriteLine();
            Console.WriteLine(cuenta2);
            Console.WriteLine();
            Console.WriteLine(cuenta3);


        }
    }
}