using System.Runtime.Intrinsics.X86;

namespace Ejercicio02;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = CrearLista(100);
        MostrarLista(numbers);
        Console.WriteLine();

        //---------------------------------------------------------------------

        int contnumber = 1;
        int cont = 0;

        for (int i = 0; i < numbers.Count && cont <=10; i++) 
        {
            if (numbers[i] == contnumber)
            {
                cont++;
                contnumber++;
            }
        }
        if (cont == 10) Console.WriteLine("Están todos los números del 1 al 10");
        else Console.WriteLine("No están todos los números del 1 al 10");

        //---------------------------------------------------------------------

        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            if (numbers[i] % 2 == 0) numbers.Remove(numbers[i]);
        }
        MostrarLista(numbers);

        //---------------------------------------------------------------------

        static void MostrarLista(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
        }
        static List<int> CrearLista(int capacidad)
        {
            List<int> numbers = new List<int>(capacidad);

            Random random = new Random();

            for (int i = 0; i < numbers.Capacity; i++)
            {
                numbers.Add(random.Next(1, 11));
            }
            return numbers;
        }
    }
}