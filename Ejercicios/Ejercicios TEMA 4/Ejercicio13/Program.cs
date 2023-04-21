using System.Reflection;

namespace Ejercicio13;

internal class Program
{
	static void Main(string[] args)
	{
		Assembly assembly = Assembly.LoadFrom("Ejercicio7.dll");

		foreach (Type type in assembly.GetTypes())
		{
			Console.WriteLine(type);
		}

		Type videojuegoType = assembly.GetType("Ejercicio7.Videojuego");
		object videojuego = Activator.CreateInstance(videojuegoType, "Pokémon", 300, "RPG", "Game Freak");
		MethodInfo esEntregadoMethod = videojuegoType.GetMethod("EsEntregado");
		MethodInfo entregarMethod = videojuegoType.GetMethod("Entregar");
		Console.WriteLine(esEntregadoMethod.Invoke(videojuego, null));
		entregarMethod.Invoke(videojuego, null);
		Console.WriteLine(esEntregadoMethod.Invoke(videojuego, null));
	}
}