namespace Ejercicio2;

public class Persona
{
    public Temas[] Temas { get; private set; }

    public Persona(Temas[] temas)
    {
        Temas = temas;
    }

    protected void RecibirNoticia(Noticia noticia)
    {
        if (Temas.Contains(noticia.Tema))
        {
            Console.WriteLine($"Leyendo noticia sobre {noticia.Tema}");
        }
    }
}
