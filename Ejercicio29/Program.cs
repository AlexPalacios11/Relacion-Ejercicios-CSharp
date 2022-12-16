using System.Globalization;

namespace Ejercicio29
{
    class Program
    {
        const double EURO_A_LIBRA = 0.86;
        const double EURO_A_DOLAR = 1.28611;
        const double EURO_A_YEN = 129.852;
        enum Moneda { Libra, Dolar, Yen };
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Elige opción (libra, dolar, yen): ");
            string moneda = Console.ReadLine();

            Console.Write("Introduce la cantidad de euros: ");
            double euros = double.Parse(Console.ReadLine());

            Convertir(euros, moneda);

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
        static void Convertir(double euros, string moneda)
        {
            object currency;

            if((Moneda)Enum.Parse(typeof(Moneda), moneda, true, out currency))
            {
                double result = 0;
                switch ((Moneda)currency)
                {
                    case Moneda.Libra:
                        result = euros * EURO_A_LIBRA;
                        break;
                    case Moneda.Dolar:
                        result = euros * EURO_A_DOLAR;
                        break;
                    case Moneda.Yen:
                        result = euros * EURO_A_YEN;
                        break;
                }
                Console.WriteLine($"{euros} son {result} {currency}");
            }
            else
            {
                Console.WriteLine("No se que moneda es");
            } 
        }
    }
}