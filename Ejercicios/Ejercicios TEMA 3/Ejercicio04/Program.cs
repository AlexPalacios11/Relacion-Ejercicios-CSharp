namespace Ejercicio04;
class Program
{
    static void Main(string[] args)
    {
        Stack<int> numbers = new Stack<int>(100);
        Random random = new Random();

        int i = 0;
        while (i < 100)
        {
            numbers.Push(random.Next(1, 11));
            i++;
        }
        foreach (int x in numbers)
        {
            Console.Write(x + ", ");
        }
        Console.WriteLine();
        while (numbers.Peek() % 2 != 0)
        {
            numbers.Pop();
        }
        Console.WriteLine(numbers.Peek());
    }
}