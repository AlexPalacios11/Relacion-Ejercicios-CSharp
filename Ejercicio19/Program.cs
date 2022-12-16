namespace Ejercicio20
{
    class Program
    {
        public enum MonthOfYear
        {
            January = 1, February, March, April, May, June, July,
            August, September, Octuber, November, December
        }

        public static void Main()
        {
            Console.Write("Introduzca un número entre el 1 y el 12: ");

            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((MonthOfYear)num);

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}