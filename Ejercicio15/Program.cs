namespace Ejercicio15
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Introduce un número entero: ");
            double number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce {0} notas diferentes para hacer la media: ", number);
            int cont;
            double sum = 0;

            for (cont = 1; cont <= number; cont++)
            {
                Console.Write("Nota {0}: ", cont);
                int note = Convert.ToInt32(Console.ReadLine());
                sum = sum + note;
            }

            double promedio = sum / number;
            Console.WriteLine();
            Console.WriteLine("La media es {0}", promedio);

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }

}