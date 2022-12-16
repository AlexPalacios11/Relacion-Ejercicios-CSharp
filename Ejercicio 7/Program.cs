namespace Ejercicio07
{
    class Program
    {
        public static void Main()
        {
            int side1, side2, side3;

            Console.WriteLine("Introduzca las dimensiones de los lados de un triángulo:");

            Console.Write("Lado 1: ");
            side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lado 2: ");
            side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lado 3: ");
            side3 = Convert.ToInt32(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("El triángulo que has definido es \"EQUILÁTERO\"");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("El triángulo que has definido es \"ISÓCELES\"");
            }
            else
            {
                Console.WriteLine("El triángulo que has definido es \"ESCALENO\"");
            }

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}