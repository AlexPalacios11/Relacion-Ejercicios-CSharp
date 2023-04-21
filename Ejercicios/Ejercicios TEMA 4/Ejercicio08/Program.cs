using System.Diagnostics;

namespace Ejercicio08;

internal class Program
{
	static void Main(string[] args)
	{
		Console.Write("Escriba el nombre de la imagen del escritorio que quiere abrir: ");
		string name = Console.ReadLine();

		ProcessStartInfo process = new ProcessStartInfo()
		{
			FileName = $"C:\\Users\\Alejandro\\Desktop\\{name}.jpg",
			UseShellExecute = true

		};

		Process.Start(process);
	}
}