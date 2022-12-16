using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Ejercicio18
{
    class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            Console.Write("Introduce la cantidad de números: ");

            int size = PedirNumeroEntero();

            double suma = 0;

            for (int i = 0; i < size; i++)
            {
                double number = PedirNumeroConDecimales();
                suma += number * number;
            }
            double resultado = Math.Sqrt(suma / size);
            Console.WriteLine(resultado);

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
        static int PedirNumeroEntero()
        {
            int resultado = -1;

            do
            {
                try
                {
                    resultado =(int) uint.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("No me jodas, repite");
                }
            }
            while (resultado == -1);
            return resultado;
        }
        static double PedirNumeroConDecimales()
        {
            double resultado = -1;

            do
            {
                try
                {
                    resultado = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("No me jodas, repite");
                }
            }
            while (resultado == -1);
            return resultado;
        }
    }
}

