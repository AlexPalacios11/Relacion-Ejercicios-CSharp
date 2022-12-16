namespace Ejercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[100];
            double sum = 0;

            for (int i = 0; i < numbers.Length;i++)
            {
                numbers[i] = i + 1;
            }
            for (int j = 0; j < numbers.Length; j++)
            {
                sum += numbers[j];
            }
            Console.WriteLine(sum / numbers.Length);

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}
