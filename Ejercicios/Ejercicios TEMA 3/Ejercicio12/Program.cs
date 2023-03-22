namespace Ejercicio12;

internal class Program
{
    static void Main(string[] args)
    {
        ListaDobleEnlazada<int> lista = new ListaDobleEnlazada<int>(Enumerable.Range(0, 30));

        Console.WriteLine(lista.Count);
        lista.Remove(0);
        lista.Remove(10);
        Console.WriteLine(lista.Contains(5));

        foreach (int num in lista)
        {
            Console.WriteLine(num);
        }
    }
}