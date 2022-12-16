namespace Ejercicio09
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("POSIBLES ESTADOS CIVILES:");

            Console.WriteLine();

            Console.WriteLine("C : Casado/a");
            Console.WriteLine("S : Soltero/a");
            Console.WriteLine("V : Viudo/a");
            Console.WriteLine("D ; Divorciado/a");

            Console.WriteLine();

            Console.Write("Introduzca la letra que se identifique con su estado civil: ");
            string letter = Console.ReadLine();
            letter = letter.ToUpper();

            switch (letter)
            {
                case "C":
                    Console.WriteLine("Casado/a");
                    break;
                case "S":
                    Console.WriteLine("Soltero/a");
                    break;
                case "V":
                    Console.WriteLine("Viudo/a");
                    break;
                case "D":
                    Console.WriteLine("Divorciado/a");
                    break;
                default:
                    Console.WriteLine("La letra introducida no coincide con ningun estado civil");
                    break;
            }

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}