namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista<int> lista = new Lista<int>(2);

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                lista.Add(random.Next(1, 11));
            }

            Console.WriteLine(lista);
            Console.WriteLine(lista.Get(10));

            for (int i = 1; i <= 10; i++)
            {
                lista.Remove(i);
            }
            Console.WriteLine(lista);

        }
    }
}