using System.Reflection;

namespace Ejercicio14;

internal class Program
{
	static void Main(string[] args)
	{
		Type intType = typeof(int);

		var fieldsIntType = intType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public)
			.Where(f => f.FieldType.Equals(intType));

		foreach (FieldInfo field in fieldsIntType)
		{
			Console.WriteLine(field.Name);
		}

		var methodIntParameterReturnString = intType.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public)
			.Where(m => m.GetParameters().Any(t => t.ParameterType.Equals(typeof(string))) && m.ReturnType.Equals(intType));

		foreach (MethodInfo method in methodIntParameterReturnString)
		{
			Console.WriteLine($"{method.Name} {method.IsVirtual}");
		}

		Type listType = typeof(List<int>);

		var methodNoParameter = listType.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
			.First(m => m.GetParameters().Length == 0);

		Console.WriteLine(methodNoParameter.Name);

		var methodVoid = listType.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
			.First(m => m.ReturnType.Equals(typeof(void)));

		Console.WriteLine(methodVoid.Name);
	}
}