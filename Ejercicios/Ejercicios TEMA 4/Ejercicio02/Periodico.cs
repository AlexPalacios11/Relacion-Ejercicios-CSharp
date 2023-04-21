namespace Ejercicio2;

public abstract class Periodico
{
    private Random random = new Random();

    public void PublicarNoticias()
    {
        while (true)
        {
            Noticia noticia = ObtenerNoticia();
            Notificar(noticia);

            // Entre 2 y 3 segundos (2000 y 3000 ms)
            Thread.Sleep((int)((2 + random.NextDouble()) * 1000));
        }
    }

    protected Noticia ObtenerNoticia()
    {
        Temas tipo = random.NextDouble() < 0.5
            ? Temas.Musica
            : Temas.Deporte;

        return new Noticia(tipo);
    }

    protected abstract void Notificar(Noticia noticia);
}
