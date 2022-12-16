namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce dos números enteros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int result = Fibonacci(a) + Fibonacci(b);

            Console.WriteLine(result);

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
        static int Fibonacci(int x) 
        { 
            int result;
            if (x <= 1)
                result = x;
            else
                result = Fibonacci(x - 1) + Fibonacci(x - 2);
            
            return result;
        }
    }
}