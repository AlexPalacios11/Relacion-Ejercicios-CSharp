namespace Ejercicio13;

class Program
{
    static void Main(string[] args)
    {
        Conjunto<int> conjunto = new Conjunto<int>(Enumerable.Range(0, 30));

        conjunto.Add(1);
        Console.WriteLine(conjunto.Count);
        conjunto.Remove(0);
        conjunto.Remove(10);
        Console.WriteLine(conjunto.Contains(5));

        foreach (int num in conjunto)
        {
            Console.WriteLine(num);
        }
    }
}