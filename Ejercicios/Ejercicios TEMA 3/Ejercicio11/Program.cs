namespace Ejercicio11;

class Program
{
    static void Main(string[] args)
    {
        Pila<int> pila = new Pila<int>(Enumerable.Range(0, 30));

        Console.WriteLine(pila.Count);
        pila.Pop();
        Console.WriteLine(pila.Peek());
        Console.WriteLine(pila.Contains(5));

        foreach (int num in pila)
        {
            Console.WriteLine(num);
        }
    }
}