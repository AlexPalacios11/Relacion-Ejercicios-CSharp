namespace Ejercicio08
{
    class Program
    {
        public static void Main()
        {
            int number, firstnumber, secondnumber;

            Console.Write("Introduzca un número entero de dos cifras: ");

            number = Convert.ToInt32(Console.ReadLine());
            firstnumber = number / 10;
            secondnumber = number % 10;

            Console.WriteLine("El número invertido sería: {0}{1}", secondnumber, firstnumber);

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}