namespace Ejercicio02
{
    class Program
    {
        public static void Main()
        {
            //using System.Globalization; (esto es para que los decimales puedan ponerse con "," y con ".")
            //CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Escribe dos números reales: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            double result = number1 + number2;
            Console.WriteLine("El resultado de la suma es: {0} + {1} = {2}", number1, number2, result);

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}