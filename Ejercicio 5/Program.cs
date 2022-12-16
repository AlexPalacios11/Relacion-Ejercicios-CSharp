namespace Ejercicio05
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Introduzca un número entero: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}