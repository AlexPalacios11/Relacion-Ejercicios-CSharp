namespace Ejercicio03;

internal class Program
{
    static void Main(string[] args)
    {
        Queue<int> numbers = new Queue<int>(100);
        Random random = new Random();

        int i = 0;
        while (i < 100)
        {
            numbers.Enqueue(random.Next(1, 11));
            i++;
        }
        foreach ( int x in numbers) 
        {
            Console.Write(x + ", ");
        }
        Console.WriteLine();
        while (numbers.Peek() % 2 != 0 )
        {
            numbers.Dequeue();
        }
        Console.WriteLine(numbers.Peek());


        

    }
}