namespace Ejercicio10;

class Program
{
    static void Main(string[] args)
    {
        Cola<int> cola = new Cola<int>(Enumerable.Range(0, 30));

        Console.WriteLine(cola.Count);
        cola.Dequeue();
        Console.WriteLine(cola.Peek());
        Console.WriteLine(cola.Contains(5));

        foreach (int num in cola)
        {
            Console.WriteLine(num);
        }
    }
}