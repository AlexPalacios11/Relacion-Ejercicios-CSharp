namespace Ejercicio05;
class Program
{
	static void Main()
	{
		Numero numero1 = new Numero(10);
		Numero numero2 = new Numero(2);

		Console.WriteLine(++numero1);
		Console.WriteLine(--numero1);
		Console.WriteLine(-numero1);

		Console.WriteLine();

		Console.WriteLine(numero1 + numero2);
		Console.WriteLine(numero1 - numero2);
		Console.WriteLine(numero1 * numero2);
		Console.WriteLine(numero1 / numero2);

		Console.WriteLine();

		Console.WriteLine(numero1.Equals(2));
		Console.WriteLine(numero1.Equals(numero1));
		Console.WriteLine(numero1 == numero2);
		Console.WriteLine(numero1 != numero2);
		Console.WriteLine(numero1 < numero2);
		Console.WriteLine(numero1 > numero2);
		Console.WriteLine(numero1 <= numero2);
		Console.WriteLine(numero1 >= numero2);

		Console.WriteLine();

		int n = numero1;
		Console.WriteLine(n);
		Console.WriteLine((Numero)5);
	}
}