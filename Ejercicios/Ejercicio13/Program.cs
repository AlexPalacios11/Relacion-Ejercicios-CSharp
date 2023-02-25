namespace Ejercicio13
{
    class Program
    {
        public static void Main()
        {
            Random creadorRandom = new Random();

            Console.Write("Introduca un numero entero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int num1 = creadorRandom.Next(1, num + 1);
            int num2 = creadorRandom.Next(1, num + 1);
            int num3 = creadorRandom.Next(1, num + 1);
            int num4 = creadorRandom.Next(1, num + 1);
            int num5 = creadorRandom.Next(1, num + 1);

            Console.WriteLine();
            Console.WriteLine(($"Cinco números aleatorios entre el 1 y el {num}: {num1} , {num2} , {num3} , {num4} , {num5}"));
            Console.WriteLine();

            if (num1 == num)
            {
                Console.WriteLine("El primer número aleatorio coincide con tu número");
            }
            else if (num2 == num)
            {
                Console.WriteLine("El segundo número aleatorio coincide con tu número");
            }
            else if (num3 == num)
            {
                Console.WriteLine("El tercer número aleatorio coincide con tu número");
            }
            else if (num4 == num)
            {
                Console.WriteLine("El cuarto número aleatorio coincide con tu número");
            }
            else if (num5 == num)
            {
                Console.WriteLine("El quinto número aleatorio coincide con tu número");
            }
            else
            {
                Console.WriteLine("Ningun número coincide con el tuyo");
            }

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}