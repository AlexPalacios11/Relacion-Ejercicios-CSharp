namespace Ejercicio32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            
            for (int i = 0; i< numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i< numbers.Length; i++)
            {
                Console.WriteLine("{0} => {1}",i, numbers[i]);
            }

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}