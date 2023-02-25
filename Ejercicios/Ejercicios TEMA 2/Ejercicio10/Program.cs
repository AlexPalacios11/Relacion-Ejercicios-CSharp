namespace Ejercicio10
{
    internal class Program
    {
        private const int CARTAS_A_COGER = 5;

        static void Main(string[] args)
        {
            BarajaEspanola barajaEspanola = new BarajaEspanola(false);
            BarajaFrancesa barajaFrancesa = new BarajaFrancesa();

            Procesar(barajaEspanola);
            Procesar(barajaFrancesa);
        }

        static void Procesar<T>(Baraja<T> baraja) where T : Enum
        {
            Console.WriteLine("Hay {0} cartas disponibles", baraja.CartasDisponibles());

            baraja.CogerCarta();

            Console.WriteLine("Hay {0} cartas disponibles", baraja.CartasDisponibles());
            baraja.MostrarMonton();

            baraja.Barajar();
            Carta<T>[] cartas = baraja.CogerCartas(CARTAS_A_COGER);

            for (int i = 0; i < cartas.Length; i++)
            {
                Carta<T> carta = cartas[i];
                Console.Write(carta);

                BarajaFrancesa barajaFrancesa = baraja as BarajaFrancesa;

                if (barajaFrancesa != null)
                {
                    Carta<PalosBarajaFrancesa> cartaFrancesa = (Carta<PalosBarajaFrancesa>)(object)carta;
                    bool esRoja = barajaFrancesa.EsRoja(cartaFrancesa);
                    Console.Write($" es {(esRoja ? "roja" : "negra")}");
                }
                Console.WriteLine();
            }
            baraja.MostrarBaraja();
        }
    }
}