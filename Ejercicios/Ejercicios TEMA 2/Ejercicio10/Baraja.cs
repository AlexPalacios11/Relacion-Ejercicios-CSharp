namespace Ejercicio10
{
    internal abstract class Baraja<T> where T : Enum
    {
        protected Carta<T>[] cartas;
        protected int posicionSiguienteCarta;
        protected int numeroCartas;
        protected int cartasPorPalo;

        public Baraja()
        {
            posicionSiguienteCarta= 0;
        }

        public abstract void CrearBaraja();

        public void Barajar()
        {
            Random random = new Random();   

            for (int i = 0; i < cartas.Length; i++)
            {
                int count = random.Next(cartas.Length);
                Carta<T> auxi = cartas[i];
                cartas[i] = cartas[count];
                cartas[count] = auxi;
            }
            posicionSiguienteCarta = 0;
        }
        public int CartasDisponibles()
        {
            return cartas.Length - posicionSiguienteCarta;
        }
        public Carta<T> CogerCarta()
        {
            Carta<T> result = null;

            if (posicionSiguienteCarta >= cartas.Length)
            {
                Console.WriteLine("No quedan cartas en la baraja, vuelva a barajar");
            }
            else
            {
                result = cartas[posicionSiguienteCarta];
                posicionSiguienteCarta++;
            }
            return result;
        }
        public Carta<T>[] CogerCartas(int cantidad)
        {
            Carta<T>[] result = null;

            if (cantidad >= CartasDisponibles()) Console.WriteLine("No hay suficientes cartas para mostrar" );
            else if (cantidad >= numeroCartas) Console.WriteLine("No hay suficientes cartas en la baraja");
            else
            {
                result = new Carta<T>[cantidad];

                for (int i = 0; i < cantidad; i++)
                {
                    result[i] = CogerCarta();
                }
            }
            return result;
        }
        public void MostrarMonton()
        {
            if (posicionSiguienteCarta == 0) Console.WriteLine("No se ha sacado ninguna carta todavía");

            else
            {
                for (int i = 0; i < posicionSiguienteCarta; i++)
                {
                    Console.WriteLine(cartas[i]);
                }
            }
        }
        public void MostrarBaraja()
        {
            if (posicionSiguienteCarta == cartas.Length) Console.WriteLine("Ya no quedan cartas en la baraja por mostrar");

            else
            {
                for (int i = posicionSiguienteCarta; i < cartas.Length; i++)
                {
                    Console.WriteLine(cartas[i]);
                }
            }
        }
    }
}
