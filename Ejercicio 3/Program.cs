namespace Ejercicio03
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Introduce una temperatura en Grados Fahrenheit:");
            int fahrenheit = Convert.ToInt32(Console.ReadLine());
            int degrees = (((fahrenheit - 32) / 9) * 5);
            Console.WriteLine("El equivalente en Grados Celsius sería: {0} Cº", degrees);

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}