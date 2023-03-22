namespace Prueba;

class Program
{
    static void Main()
    {
        int[] num = new int[100];
        Random random = new Random();
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = random.Next(1, 101);
        }

        Console.WriteLine("Numeros pares: " + (from numero in num where numero % 2 == 0 select numero).ToList().Count() +
                        "Numeros impares: " + (from numero in num where numero % 2 != 0 select numero).ToList().Count());
        Console.WriteLine(num.Sum());
        var numerosMayores = from numero in num where numero > 50 select numero;
        Console.WriteLine(numerosMayores.Average());

        //Console.WriteLine("[{0}]", string.Join(", ", num));
        //Console.WriteLine();
        //Console.WriteLine(num.Sum());
        //Console.WriteLine(num.();
        //Console.WriteLine("1: [{0}]", num.Last());
        //Console.WriteLine("2: [{0}]", string.Join(", ", num.Where(x => x % 2 == 0)));
        //Console.WriteLine("3: [{0}]", string.Join(", ", num.Where(x=> x<10)));
        //Console.WriteLine("4: [{0}]", string.Join(", ", num.Where(x=> x%10!=5)));
        //Console.WriteLine("5: [{0}], [{1}]", num.Max(), num.Min());
        //Console.WriteLine("6: [{0}]", num.Average());
        //Console.WriteLine("7: [{0}]", Math.Sqrt(num.Average(x =>x*x)));
        //Console.WriteLine("8: [{0}]", string.Join(", ", num.Distinct().OrderByDescending(x => x)));
        //Console.WriteLine("9: [{0}]", string.Join(", ", num.Select(x => x / 2)));
        //Console.WriteLine("10: [{0}]", string.Join(", ", num.Select(x => Math.Log2(x).ToString("0.00"))));
        //Console.WriteLine("11: [{0}]", );
        //Console.WriteLine("12: [{0}]", );
        //Console.WriteLine("13: [{0}]", );
        //Console.WriteLine("14: [{0}]", );
        //Console.WriteLine("15: [{0}]", );
        //Console.WriteLine("16: [{0}]", );
        //Console.WriteLine("17: [{0}]", );
        //Console.WriteLine("18: [{0}]", );


        //Hashtable datos = new Hashtable();
        //datos.Add("txt", "notepad.exe");
        //datos.Add("jpg", "paint.exe");
        //string programa = datos["txt"] as string;
        //Console.WriteLine(programa);
        //int hash = datos["txt"].GetHashCode();
        //Console.WriteLine(hash);
        //Console.WriteLine("notepad.exe".GetHashCode());
    }
}