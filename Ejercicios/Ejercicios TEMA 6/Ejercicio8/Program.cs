using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Ejercicio8;

internal class Program
{
    static void Main(string[] args)
    {
        string text = File.ReadAllText("regex.txt");

        // Encuentra todas las palabras que comiencen con la letra "i"
        Console.WriteLine("Encuentra todas las palabras que comiencen con la letra \"i\"");
        GetAndShowResult(text, @"i\w+");

        // Encuentra todas las palabras que no tengan número
        Console.WriteLine("Encuentra todas las palabras que no tengan número");
        GetAndShowResult(text, @"[^(\d+)]+");

        // Encuentra todas las palabras que contengan la letra "o" y terminen con la letra "n"
        Console.WriteLine("Encuentra todas las palabras que contengan la letra \"o\" y terminen con la letra \"n\"");
        GetAndShowResult(text, @"\w*o\w*n");

        // Encuentra todas las palabras que tengan más de 5 letras
        Console.WriteLine("Encuentra todas las palabras que tengan más de 5 letras");
        GetAndShowResult(text, @"\w{6,}");

        // Encuentra todas las palabras que tengan una letra en mayúscula al principio
        Console.WriteLine("Encuentra todas las palabras que tengan una letra en mayúscula al principio");
        GetAndShowResult(text, @"A\w*");

        // Encuentra todas las palabras que contengan la letra la letra "o" precedida de una "t"
        Console.WriteLine("Encuentra todas las palabras que contengan la letra la letra \"o\" precedida de una \"t\"");
        GetAndShowResult(text, @"\w*t\w*o\w*");

        // Encuentra todas las palabras que contengan la letra "t" o la letra "o"
        Console.WriteLine("Encuentra todas las palabras que contengan la letra \"t\" o la letra \"o\"");
        GetAndShowResult(text, @"\w*[to]\w*");

        // Encuentra todas las palabras que contengan un punto "."
        Console.WriteLine("Encuentra todas las palabras que contengan un punto \".\"");
        GetAndShowResult(text, @"\w*\.\w*");

        // Encuentra todas las palabras que comiencen con la letra "s" y tengan al menos una letra "a"
        Console.WriteLine("Encuentra todas las palabras que comiencen con la letra \"s\" y tengan al menos una letra \"a\"");
        GetAndShowResult(text, @"s\w*a\w*");

        // Encuentra todas las palabras que comiencen con la letra "b" y terminen con la letra "s" o la letra "n"
        Console.WriteLine("Encuentra todas las palabras que comiencen con la letra \"b\" y terminen con la letra \"s\" o la letra \"n\"");
        GetAndShowResult(text, @"b\w*[sn]");

        // Encuentra todas las palabras que contengan un número después de un signo de dólar "$"
        Console.WriteLine("Encuentra todas las palabras que contengan un número seguido de un signo de dólar \"$\"");
        GetAndShowResult(text, @"\w*\$\d+\w*");

        // Encuentra todos los números que estén seguidos por la palabra "billones"
        Console.WriteLine("Encuentra todos los números que estén seguidos por la palabra \"billones\"");
        GetAndShowResult(text, @"\$\d+(\.\d+)?\s+billones");
    }

    static void GetAndShowResult(string text, [StringSyntax(StringSyntaxAttribute.Regex)] string pattern)
    {
        MatchCollection result = Regex.Matches(text, pattern);
        foreach (Match match in result) Console.WriteLine(match.Value);
        Console.WriteLine();
    }
}