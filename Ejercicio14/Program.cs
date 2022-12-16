namespace Ejercicio14
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Introduzca dos numeros enteros: ");

            Console.Write("Primer número: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo número: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Random creadorRandom = new Random(number1);

            int number;

            for (int cont = 0; cont < number2; cont++)
            {
                number = creadorRandom.Next(0, 256);
                Console.Write("{0} = ", number);
                char ascii = (char)number;
                Console.WriteLine(ascii);
            }

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}