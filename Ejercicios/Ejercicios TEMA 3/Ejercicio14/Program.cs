using System.Security.Cryptography.X509Certificates;

namespace Ejercicio14;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] numeros = new int[30];

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = random.Next(1, 21);
        }

        Console.WriteLine("Último número: {0}", numeros.Last());

        Console.WriteLine("Números pares: [{0}]", string.Join(", ", numeros.Where(x => x % 2 == 0)));

        Console.WriteLine("Números con menos de 2 cifras: [{0}]", string.Join(", ", numeros.Where(x => x < 10)));

        Console.WriteLine("Números que no terminan en 5: [{0}]", string.Join(", ", numeros.Where(x => x % 10 != 5)));

        Console.WriteLine("Maximo: {0}, Minimo: {1}", numeros.Max(), numeros.Min());

        Console.WriteLine("Media aritmética: {0}", numeros.Average());

        Console.WriteLine("Media cuadrática: {0}", Math.Sqrt(numeros.Average(x => x * x)));

        Console.WriteLine("Números ordenados descendentemente sin repeticiones: [{0}]", string.Join(", ", numeros.Distinct().OrderByDescending(x => x)));

        Console.WriteLine("La mitad de cada número sin decimales: [{0}]", string.Join(", ", numeros.Select(x => x / 2)));

        Console.WriteLine("Logaritmo en base 2 con decimales: [{0}]", string.Join(", ", numeros.Select(x => Math.Log2(x).ToString("0.00"))));

        Console.WriteLine("Moda: {0}", numeros.GroupBy(x => x).OrderByDescending(g => g.Count()).First().Key);

        // En estos casos conviene sacar fuera la operación para reutilizarla ya que,
        // si hacemos numeros.Where(x => x > numeros.Average() / 2), se va a calcular 
        // la media aritmética por cada número que se vaya a comparar. Por tanto,
        // si tuviéramos 1000 números estaríamos calculando 1000 veces la media aritmética
        double media = numeros.Average() / 2;
        Console.WriteLine("Números mayores a la mitad de la media aritmética: [{0}]", string.Join(", ", numeros.Where(x => x > media)));

        Console.WriteLine("Primer número > 10: {0}", numeros.First(x => x > 10));

        Console.WriteLine("Números entre posición 10 y 20: [{0}]", string.Join(", ", numeros.Skip(10).Take(10)));

        Console.WriteLine("Hay número mayor que 10: {0}", numeros.Any(x => x > 10));

        Console.WriteLine("Todos los números están en intervalo [1, 20]: {0}", numeros.All(x => 1 <= x && x <= 20));

        Console.WriteLine("Está el 5: {0}", numeros.Contains(5));

        Console.WriteLine("Diferencia conjunto: [{0}]", string.Join(", ", numeros.Except(new[] { 1, 3, 5, 7, 11, 13, 17, 19, 23, 29 })));
    }
}