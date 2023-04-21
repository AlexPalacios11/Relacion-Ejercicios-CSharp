using System.Diagnostics;

namespace Ejercicio10;

class Program
{
	static void Main(string[] args)
	{
		ProcessStartInfo process = new ProcessStartInfo()
		{
			FileName = "Diamante.exe",
			RedirectStandardInput = true,
			RedirectStandardOutput = true
		};

		using Process proceso = Process.Start(process);

		proceso.StandardInput.WriteLine(Console.ReadLine());

		string line;

		while ((line = proceso.StandardOutput.ReadLine()) != null) 
			Console.WriteLine(line);

		proceso.WaitForExit();
    }
}