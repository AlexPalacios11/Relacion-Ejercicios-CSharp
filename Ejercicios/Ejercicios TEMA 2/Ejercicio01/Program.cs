namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Paco");
            Cuenta cuenta2 = new Cuenta("María", 1000);

            cuenta1.Ingresar(1000);
            cuenta2.Ingresar(1000);

            cuenta1.Retirar(150);
            cuenta2.Retirar(300);

            Console.WriteLine(cuenta1); 
            Console.WriteLine(cuenta2);
        }
    }
}