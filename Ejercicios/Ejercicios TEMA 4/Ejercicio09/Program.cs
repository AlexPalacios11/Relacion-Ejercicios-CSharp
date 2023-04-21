using System.Diagnostics;

namespace Ejercicio09;

internal class Program
{
	static void Main(string[] args)
	{
		ProcessStartInfo process = new ProcessStartInfo()
		{
			FileName = "Diamante.exe"
		};

		Process.Start(process);

	}
}