namespace Ejercicio30 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número entero: ");
            int filas = int.Parse(Console.ReadLine()); 
            
            for(int i = 1; i <= filas; i++) 
            {
                int spaces = filas - i;
                Console.Write(new string(' ', spaces));
                
                for ( int j = 0; j <= i; j++)
                {
                    Console.Write(Combinatorio(i,j) + " ");
                }

                Console.WriteLine();
            }
            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }     
        static int Combinatorio(int m, int n)
        {
            return Factorial(m) / (Factorial(n) * Factorial(m - n));
        }
        static int Factorial(int x)
        {
            int result = 1;

            for (int i= 2; i<=x; i++)
            {
                result *= i;    
            }
            return result;  
        }
    }
}