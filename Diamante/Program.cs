namespace Diamante
{
    class Program
    {
        public static void Main()
        {
            int n, actualline, space, star;
            Console.Write("Inserte el lado de la diamante: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (actualline = 1; actualline <= n; actualline++)
            {
                for (space = 0; space < n - actualline; space++)
                {
                    Console.Write(" ");
                }
                for (star = 0; star < (actualline * 2) - 1; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (actualline = n - 1; actualline > 0; actualline--)
            {
                for (space = 0; space < n - actualline; space++)
                {
                    Console.Write(" ");
                }
                for (star = 0; star < (actualline * 2) - 1; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}