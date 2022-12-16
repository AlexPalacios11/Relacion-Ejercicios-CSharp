namespace Ejercicio38
{
    class Program
    {
        
        const int QUANTITY = 10;
        static void Main(string[] args)
        {
            char[] letters = { 'a', 'b', 'c' };
            letters[0] = 'z';

            Random random = new Random();
            int[] numbers = new int[QUANTITY];
            
            for (int i = 0; i < QUANTITY; i++)
            {
                numbers[i] = random.Next();

                if (i != 0 && i % 2 != 0) 
                {
                    Console.WriteLine("Posición {0} del array = {1}", i, numbers[i]);
                }
            }

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}
