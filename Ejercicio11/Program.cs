namespace Ejercicio11_1
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Introduzca un número entero: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int dividen = 2;
            int divider = 1;
            int cont = 0;

            while (dividen <= number)
            {
                while (divider <= dividen)
                {
                    if (dividen % divider == 0)
                    {
                        cont++;
                    }
                    divider++;
                }
                if (cont == 2)
                {
                    Console.WriteLine("[" + dividen + "]");
                }
                dividen++;
                divider = 1;
                cont = 0;
            }
            Console.ReadKey();

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}