namespace Ejercicio04;
class Program
{
	static void Main()
	{
		(int, char) tuple1 = (int.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
        Console.WriteLine(tuple1);

        (int, char) tuple2 = (Número: int.Parse(Console.ReadLine()), Letra: char.Parse(Console.ReadLine()));
        Console.WriteLine(tuple2);

        if(tuple1==tuple2)
            Console.WriteLine("Son iguales");
        else Console.WriteLine("No son iguales");
    }
}