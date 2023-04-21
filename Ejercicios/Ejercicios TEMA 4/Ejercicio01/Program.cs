namespace Ejercicio01;
class Program
{
	static void Main()
	{
		Random random = new Random();
		int? num;

		if (random.Next(0, 2) == 0)
			num = random.Next(0, 11);
		else num = null;

		if (num.HasValue)
            Console.WriteLine(num);
		else Console.WriteLine("No tiene valor");
    }
}