namespace Ejercicio04
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Introduzca un número entero: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int lastnumber = number % 10;
            Console.WriteLine("La cifra que esta en las unidades es el {0}", lastnumber);

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}