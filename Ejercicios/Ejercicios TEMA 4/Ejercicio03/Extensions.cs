namespace Ejercicio03;

static class Extensions
{
	public static IEnumerable<T> Take<T>(this IEnumerable<T> source, int num)
	{
		List<T> list = new List<T>();

		foreach (T item in source)
		{
			if (num > 0)
			{
				list.Add(item);
				num--;
			}
		}

		return list;
	}

	public static IEnumerable<T> Skip<T>(this IEnumerable<T> source, int num)
	{
		List<T> list = new List<T>();
		int count = 1;

		foreach (T item in source)
		{
			if (count <= num)
				count++;
			else list.Add(item);
		}

		return list;
	}
	public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> source, Func<T, bool> func)
	{
		List<T> list = new List<T>();
		bool x = true;

		foreach (T item in source)
		{
			if (func(item) && x)
				list.Add(item);
			else x = false;
		}
		return list;
	}

	public static IEnumerable<T> SkipWhile<T>(this IEnumerable<T> source, Func<T, bool> func)
	{
		List<T> list = new List<T>();
		bool x = false;

		foreach (T item in source)
		{
			if (!func(item))
				x = true;

			if (x) list.Add(item);
		}
		return list;
	}

	public static int Count<T>(this IEnumerable<T> source)
	{
		int count = 0;

		foreach (T item in source)
			count++;

		return count;
	}

	public static bool All<T>(this IEnumerable<T> source, Func<T, bool> func)
	{
		bool result = true;

		foreach (T item in source)
		{
			if (result)
				result = func(item);
		}

		return result;
	}

	public static bool Any<T>(this IEnumerable<T> source, Func<T, bool> func)
	{
		bool result = false;

		foreach (T item in source)
		{
			if (!result)
				result = func(item);
		}

		return result;
	}

	public static bool Contains<T>(IEnumerable<T> source, T item)
	{
		bool result = false;

		foreach (T chosen in source)
		{
			if (!result)
				result = chosen.Equals(item);
		}

		return result;
	}

	public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> func)
	{
		List<T> result = new List<T>();

		foreach (T item in source)
		{
			if (func(item))
				result.Add(item);
		}

		return result;
	}

	public static IEnumerable<G> Select<T, G>(this IEnumerable<T> source, Func<T, G> func)
	{
		List<G> result = new List<G>();

		foreach (T item in source)
			result.Add(func(item));

		return result;
	}

	public static IEnumerable<G> SelectMany<T, G>(this IEnumerable<IEnumerable<T>> source, Func<T, G> func)
	{
		List<G> list = new List<G>();

		foreach (IEnumerable<T> collection in source)
		{
			foreach (T item in collection)
			{
				list.Add(func(item));
			}
		}
		return list;
	}
}
