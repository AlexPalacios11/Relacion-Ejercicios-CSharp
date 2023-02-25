namespace Ejercicio16
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Introduzca un número entero en base 10: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Ahora introduzca a la base a la que quiere pasar el número introduzido\n " +
                           "anteriormente (solo se puede convertir a una base entre 2 y 9): ");
            int baseuser = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int rest;
            string finalnumber = String.Empty;

            while (number > 0)
            {
                rest = number % baseuser;
                number /= baseuser;
                finalnumber += rest.ToString();
            }
            Console.WriteLine(finalnumber);

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}