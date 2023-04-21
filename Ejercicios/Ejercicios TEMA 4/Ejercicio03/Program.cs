namespace Ejercicio03;
class Program
{
	static void Main()
	{
		IEnumerable<int> nums = Enumerable.Range(1, 10);

		Console.WriteLine($"Take: {string.Join(", ", nums.Take(5))}");
		Console.WriteLine($"Skip: {string.Join(", ", nums.Skip(4))}");
		Console.WriteLine($"TakeWhile: {string.Join(", ", nums.TakeWhile(x => x % 2 != 0))}");
		Console.WriteLine($"SkipWhile: {string.Join(", ", nums.SkipWhile(x => x < 5))}");
		Console.WriteLine($"Count: {string.Join(", ", nums.Count())}");
		Console.WriteLine($"All: {string.Join(", ", nums.All(x => x < 9))}");
		Console.WriteLine($"Any: {string.Join(", ", nums.Any(x => x % 2 == 0))}");
		Console.WriteLine($"Contains: {string.Join(", ", nums.Contains(7))}");
		Console.WriteLine($"Where: {string.Join(", ", nums.Where(x => x % 2 != 0))}");
		Console.WriteLine($"Select: {string.Join(", ", nums.Select(x => x * 7))}");
		Console.WriteLine($"SelectMany: {string.Join(", ", nums.Select(x => Enumerable.Range(1, x)).SelectMany(x => x))}");

	}
}

