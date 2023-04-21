using System.Diagnostics;

namespace Ejercicio11;

internal class Program
{
	static void Main(string[] args)
	{
		ProcessStartInfo process = new ProcessStartInfo()
		{
			FileName = "Ejercicio05.exe",
			RedirectStandardError = true,
			RedirectStandardOutput = true,
			RedirectStandardInput = true
		};

		using Process proceso = Process.Start(process);

		Console.WriteLine(proceso.StandardOutput.ReadLine());
		proceso.StandardInput.WriteLine(Console.ReadLine());

		Console.WriteLine(proceso.StandardOutput.ReadLine());

		Console.WriteLine(proceso.StandardOutput.ReadLine());
		proceso.StandardInput.WriteLine();

		Console.WriteLine(proceso.StandardError.ReadToEnd());

		proceso.WaitForExit();
	}
}