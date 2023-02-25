namespace Ejercicio11;

class Program
{
    private static readonly Vector3 VELOCIDAD_JUGADOR1 = new Vector3(1, 0, 0);
    private static readonly Vector3 VELOCIDAD_JUGADOR2 = new Vector3(2, 0, 0);
    static void Main(string[] args)
    {
        Jugador jugador1 = new Jugador(new Vector3(10,0,2));
        Jugador jugador2 = new Jugador(new Vector3());

        int iteraciones = 0;

        while (jugador1.EstaVivo)
        {
            jugador1.Mover(VELOCIDAD_JUGADOR1);
            jugador2.Mover(VELOCIDAD_JUGADOR2);

            jugador2.Matar(jugador1);
            iteraciones++;
        }

        Console.WriteLine("Iteraciones: {0}", iteraciones);
    }
}
