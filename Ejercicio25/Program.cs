namespace Ejercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce dos números enteros");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int result = Factorial(n) - Factorial(m);
            Console.WriteLine(result);

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
        static int Factorial(int x)
        {
            int result;
            if (x == 0) result = 1;
            
            else result = x * Factorial(x - 1);

            return result;
        }
    }
}