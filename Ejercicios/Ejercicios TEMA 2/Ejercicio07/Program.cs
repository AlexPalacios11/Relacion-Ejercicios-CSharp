namespace Ejercicio07
{
    internal class Program
    {
        private const int CANTIDAD_ARTICULOS = 5;
        static void Main(string[] args)
        {
            Serie[] series = new Serie[CANTIDAD_ARTICULOS];
            Videojuego[] videojuegos = new Videojuego[CANTIDAD_ARTICULOS];

            series[0] = new Serie();
            series[1] = new Serie("Juego de tronos", "George R. R. Martin ");
            series[2] = new Serie("Los Simpsons", 25, "Humor", "Matt Groening");
            series[3] = new Serie("Padre de familia", 12, "Humor", "Seth MacFarlane");
            series[4] = new Serie("Breaking Bad", 5, "Thriller", "Vince Gilligan");

            videojuegos[0] = new Videojuego();
            videojuegos[1] = new Videojuego("Assasin creed 2", 30, "Aventura", "EA");
            videojuegos[2] = new Videojuego("God of war 3", 40);
            videojuegos[3] = new Videojuego("Super Mario 3DS", 30, "Plataforma", "Nintendo");
            videojuegos[4] = new Videojuego("Final fantasy X", 200, "Rol", "Square Enix");

            series[1].Entregar();
            series[4].Entregar();
            videojuegos[0].Entregar();
            videojuegos[3].Entregar();

            int entregados = 0;

            for (int i = 0; i < CANTIDAD_ARTICULOS; i++)
            {
                if (series[i].EsEntregado()) entregados += 1;

                if (videojuegos[i].EsEntregado()) entregados += 1;
            }
            Console.WriteLine("Hay " + entregados + " artículos entregados");

            Serie serieMayor = series[0];
            Videojuego videojuegoMayor = videojuegos[0];
            
            for (int i = 1; i < CANTIDAD_ARTICULOS; i++)
            {
                if (series[i].CompareTo(serieMayor) > 0) serieMayor = series[i];

                if (videojuegos[i].CompareTo(videojuegoMayor) > 0) videojuegoMayor = videojuegos[i];
            }
            
            Console.WriteLine(videojuegoMayor);
            Console.WriteLine(serieMayor);
        }
    }
}