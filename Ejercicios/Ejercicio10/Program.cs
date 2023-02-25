namespace Ejercicio10
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Introduzca un número entero: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("El número {0} es divisible entre 2 y 3", i);
                }
            }

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}